using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Api;
using BTD_Mod_Helper.Api.Audio;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Internal;
using BTD_Mod_Helper.Api.ModOptions;
using Il2CppNinjaKiwi.Localization;
using MelonLoader.Utils;
using UnityEngine;
using TaskScheduler = BTD_Mod_Helper.Api.TaskScheduler;

// ReSharper disable IteratorMethodResultIsIgnored

namespace UsefulUtilities.Utilities;

public class JukeboxFolder : UsefulUtility
{
    public static readonly ModSettingFolder FolderPath =
        new(Path.Combine(MelonEnvironment.GameRootDirectory, "Jukebox"))
        {
            displayName = "Jukebox Folder",
            icon = VanillaSprites.JukeboxIcon,
            category = UsefulUtilitiesMod.Jukebox,
            description =
                "Audio files you put in this folder will be automatically loaded into the BTD6 Jukebox. " +
                "Can add new tracks from files without restarting the game, but can't delete them.",
            onSave = newPath =>
            {
                if (Path.GetFullPath(newPath) == Path.GetFullPath(watcher!.Path)) return;
                watcher.Path = newPath;
                TaskScheduler.ScheduleTask(() => AddTracks(CreateTracks(newPath)));
            }
        };

    private static FileSystemWatcher watcher = null!;

    public static readonly ModSettingInt LoadedTrackLimit = new(3)
    {
        min = 1,
        max = 25,
        description = "How many jukebox tracks to keep decoded in memory at once. Tracks are decoded when you play " +
                      "them and the least recently played ones past this limit are dropped. Raising this uses a lot " +
                      "more memory: an hour of audio is over a gigabyte once decoded.",
        icon = VanillaSprites.LoadingWheel,
        category = UsefulUtilitiesMod.Jukebox,
        onSave = limit => ModJukeboxTrack.MaxLoadedLazyClips = (int) limit
    };

    public static readonly ModSettingBool NormalizeVolume = new(true)
    {
        description =
            "Normalizes the volume of jukebox tracks to be as load as they can be without peaking, as normal BTD6 music tends to be",
        icon = VanillaSprites.VolumeIcon,
        category = UsefulUtilitiesMod.Jukebox,
    };

    public override IEnumerable<ModContent> Load()
    {
        var result = base.Load();

        if (!Directory.Exists(FolderPath)) Directory.CreateDirectory(FolderPath);

        watcher = new FileSystemWatcher(FolderPath);
        foreach (var extension in ResourceHandler.AudioExtensions)
        {
            watcher.Filters.Add("*" + extension);
        }
        watcher.IncludeSubdirectories = true;
        watcher.Created += (_, args) => TaskScheduler.ScheduleTask(
            () => AddTracks(TracksFor([args.FullPath])), ScheduleType.WaitForSeconds, 1);

        return result.Concat(CreateTracks(FolderPath));
    }

    public override void OnRegister() => ModJukeboxTrack.MaxLoadedLazyClips = (int) LoadedTrackLimit;

    public static IEnumerable<string> GetFiles(string path) => ResourceHandler.AudioExtensions
        .SelectMany(extension => Directory.EnumerateFiles(path, "*" + extension, SearchOption.AllDirectories));

    public static FileJukeboxTrack[] CreateTracks(string folderPath) => TracksFor(GetFiles(folderPath));

    private static readonly HashSet<string> KnownFiles = [];

    private static FileJukeboxTrack[] TracksFor(IEnumerable<string> files) => files
        .Where(file => KnownFiles.Add(Path.GetFullPath(file)))
        .Select(file => new FileJukeboxTrack(file))
        .ToArray();

    public static void AddTracks(params IEnumerable<FileJukeboxTrack> tracks)
    {
        var newTracks = tracks.ToArray();
        if (newTracks.Length == 0) return;

        GetInstance<JukeboxFolder>().mod.AddContent(newTracks);

        foreach (var track in newTracks.Where(track => !track.Registered))
        {
            track.Register();
            track.RegisterText(LocalizationManager.Instance.textTable);
            track.Registered = true;
        }
    }

    public class FileJukeboxTrack : ModJukeboxTrack
    {
        public sealed override string Name { get; }

        public override string DisplayName => Name;

        public override bool LazyLoadClip => true;

        public override int RegisterPerFrame => 25;

        public string FilePath { get; }
        public bool Registered { get; internal set; }

        public FileJukeboxTrack(string filePath)
        {
            Name = Path.GetFileNameWithoutExtension(filePath);
            FilePath = filePath;
            mod = GetInstance<UsefulUtilitiesMod>();

            ModHelper.Msg<UsefulUtilitiesMod>($"Adding track \"{Name}\" from {FilePath}");
        }

        protected override AudioClip? LoadClip()
        {
            try
            {
                var start = DateTime.Now;
                using var waveStream = ResourceHandler.GetWaveStream(FilePath);
                if (NormalizeVolume) BloonsMod.NormalizeAudioVolume.Add(Id);
                var audioClip = ResourceHandler.CreateAudioClip(waveStream, Id);
                var end = DateTime.Now;

                if (audioClip != null)
                {
                    ModHelper.Msg<UsefulUtilitiesMod>(
                        $"Successfully processed track {Name} duration {TimeSpan.FromSeconds(audioClip.length):g} in {(end - start).TotalSeconds:N1}s");
                    return audioClip;
                }
            }
            catch (Exception e)
            {
                ModHelper.Error<UsefulUtilitiesMod>(e);
            }

            ModHelper.Error<UsefulUtilitiesMod>($"Unable to parse potential jukebox track file {FilePath}");
            return null;
        }
    }
}
