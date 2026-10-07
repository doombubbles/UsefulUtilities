using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.ModOptions;
using HarmonyLib;
using Il2CppAssets.Scripts.Simulation;
using Il2CppAssets.Scripts.Simulation.Bloons;
using UnityEngine;
namespace UsefulUtilities.Utilities;

public class UnFastForwardOnDanger : ToggleableUtility
{
    protected override bool DefaultEnabled => false;
    public override string Description =>
        "Automatically turn off fast forward when a certain danger level of Bloon gets a certain amount along the track";
    protected override bool CreateCategory => true;

    protected override string Icon => VanillaSprites.GoFastForwardIconOff;

    public static readonly ModSettingInt TrackThreshold = new(95)
    {
        description = "What percentage along the track the Bloons needs to get to qualify.",
        icon = VanillaSprites.AmbushTechIcon,
        min = 0,
        max = 100,
        slider = true,
        sliderSuffix = "%"
    };

    public static readonly ModSettingInt DangerThreshold = new(25)
    {
        description = "What percentage of your current lives the Bloons needs to leak for to qualify.",
        icon = VanillaSprites.DangerSoonIcon,
        min = 0,
        max = 100,
        slider = true,
        sliderSuffix = "%"
    };

    private static int cooldown;

    [HarmonyPatch(typeof(Simulation), nameof(Simulation.Simulate))]
    internal static class Simulation_Simulate
    {
        [HarmonyPostfix]
        internal static void Postfix(Simulation __instance)
        {
            if (!GetInstance<UnFastForwardOnDanger>().Enabled || Input.GetKey(KeyCode.Space)) return;
            cooldown--;
            if (cooldown > 0) return;
            cooldown = 0;

            CheckBloons(__instance);
        }

        internal static void CheckBloons(Simulation simulation)
        {
            var enumerator = simulation.factory.GetUncast<Bloon>().GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    var bloon = enumerator._current;
                    if (!bloon.bloonModel.isBoss &&
                        bloon.PercThroughMap() >= TrackThreshold / 100f &&
                        bloon.GetModifiedTotalLeakDamage() >= simulation.Health * DangerThreshold / 100f)
                    {
                        TimeManager.FastForwardActive = false;
                        cooldown = 180;
                    }
                }
            }
            finally
            {
                enumerator.Dispose();
            }
        }
    }
}
