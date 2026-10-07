# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [1.4.10] - 2026-10-06

- Updated for BTD6 v57
- Improved memory performance of Jukebox songs

## [1.4.9] - 2026-08-09

- Fixed potential enumerator crashes for some utilities

## [1.4.8] - 2026-08-06

- Fixed for BTD6 v56
- Upgrade Queueing can no longer purchase upgrades the player hasn't unlocked with XP yet

## [1.4.7] - 2026-06-03

- Updated for BTD6 v55

## [1.4.6] - 2026-05-27

- Now using a ModLoadTask for asynchronous Jukebox folder loading
- Added a "Normalize Volume" setting (default true) for Jukebox tracks

## [1.4.5] - 2026-05-26

- Removed Sandbox VTSG as it's now allowed in vanilla

## [1.4.4] - 2026-05-26

- Fixed some minor Copy/Paste towers interactions with Paths++
- Added a toggleable utility "Monkey Auto Renamer" (default off) - When a named monkey is sold/destroyed, the monkey with the next highest number of pops will carry on its name.
- Fixed some more Upgrade Queueing edge cases

## [1.4.3] - 2026-05-06

- Minor improvements to Upgrade Queueing Paths++ support

## [1.4.2] - 2026-04-09

- Updated for BTD6 v54
- Added a new feature where Middle-Clicking the play button will show a popup allowing you to specify a round before which autostart should be automatically paused

## [1.4.1] - 2026-02-23

- Removed Indiscriminate Pets as NK added it themselves
- Updated Jukebox Folder to always support all audio file types that Mod Helper does
- Added "Map Editor Placeable Counts" utility to show prop/stamp current counts and maximum

## [1.4.0] - 2026-02-12

- Fixed for BTD6 v53

#### Upgrade Queueing
- Allows you to queue upgrades to be automatically purchased later once you have the cash.
  - Default mode is 'Shift', which means holding the Shift key while trying to upgrade a tower will queue the upgrade.
  - Or, the 'Any' mode makes any upgrade attempt queue the upgrade if you don't have the cash for it.
  - Or it can be turned 'Off' entirely
- A list of currently queued upgrades is visible in the top left by the Cash display
  - Additionally, in the tower selection menu, the upgrade pips will be labeled with their position in queue
  - Clicking on the visual indicators in either place will cancel that queued upgrade
- If you try to Paste a tower when you don't have enough money, you'll now be able to place the base tower and have the upgrades be queued

## [1.3.16] - 2025-12-07

- Fixed the modifer key functionality for Quick Selling many of the same tower

## [1.3.15] - 2025-12-03

- Fixed a typo causing jukebox errors

## [1.3.14] - 2025-12-03

- Fixed for v52

## [1.3.13] - 2025-11-04

- To fix an issue with the Rounds Viewer window interacting with freeplay spawns, you can no longer view the Bloons in freeplay rounds until freeplay has begun within the match
- Added Previous and Next arrows for the Rounds Viewer window

## [1.3.12] - 2025-10-15

- Fixes for BTD6 v51
- Expanded the Single Player Co Op feature with a new button in the Map Select menu akin to the Boss Challenge Badges feature

## [1.3.11] - 2025-09-27

- Added a patch that fixes the Banana Farmer Pro's middle path tower link not saving properly. 
  - This should be fixed with BTD6 v51 next month and then this patch will be removed

## [1.3.10] - 2025-09-26

- Fixed sandbox clear projectiles button
- Fixed some issues with Copy/Pasting Powers Pro from Powers in Shop

## [1.3.9] - 2025-09-02

- Fixes for BTD6 v50.1

## [1.3.8] - 2025-08-30

- Made the Ability Seconds displayed number account for ability cooldown speed scale modifiers
- Fixed some errors with hotkey display for towers with no hotkeys
- Shortened the text for some specific keys in the hotkey display

## [1.3.7] - 2025-08-27

More v50 changes
- Indiscriminate Pets and Keep Default Upgrade Sounds back working
- Fixed a Sacrifice Helper interaction

## [1.3.6] - 2025-08-27

- Fixed for BTD6 v50
- @oatsfx added a setting for Ability Seconds, making ability buttons display their cooldowns as text rather than just the circle (configurable in settings) 
- Three Column Shop (default false): Makes the in game list of towers in the shop have 3 columns instead of 2. 
- Sandbox Round End (default true): Allows round end triggers to still function in Sandbox mode

## [1.3.5] - 2025-08-06

- More In Game Charts features
  - Added a rolling average Damage per Second option to the damage meters
  - Added a compact mode setting to the Bloons chart
  - When the Bloons chart is in live mode, it will automatically start showing the next round's Bloons once the current round's emissions are over
- Updated the Clear Alerts feature with a couple more alerts
- Added a button within the Map Select Screen to show Boss Challenge Badges collected per map
  - Bronze Border if at least 1 Non-Elite Boss is defeated
  - Silver Border if all Non-Elite Bosses are defeated
  - Gold Border if at least 1 Elite Boss is defeated
  - Black Border if all Elite Bosses are defeated

## [1.3.4] - 2025-07-30

- Updated wikilinks for Desperados
- Added two In Game Charts that can be opened from the new Mod Helper start menu in game
  - "Meters" - Damage dealt / Cash Generation meters for your towers
  - "Bloons" - Shows the Bloons currently inbound for the round, or view other rounds' bloons

## [1.3.3] - 2025-06-26

- If you have the [Unlimited 5th Tiers+ mod](https://github.com/doombubbles/unlimited-5th-tiers#readme) installed, Copy/Paste functionality will now work with Paragons and Heroes

## [1.3.2] - 2025-06-18

- Fixed for BTD6 v49
- Removed the Rogue Legends tower hotkey cycling, as Ninja Kiwi added it themselves
- Ninja Kiwi added their own version of tower placement snapping in the accessbility options, but Auto Nudge will not
be removed as it can still be useful for finding a very tiny mearby placement spot

## [1.3.1] - 2025-04-11

- Fixed a hotkey setting internally triggering an il2cpp bug that was causing some frame hitching in game
- The Un Fast Forward on Danger setting will now not activate if you are holding the fast forward key (Space)

## [1.3.0] - 2025-02-10

- Added a new "Un-FastForward on Danger" utility (default off)
  - Automatically turns off Fast Forward mode if a dangerous enough non-boss Bloon (default >25% of your lives) makes it past a certain point along a track (default 95%)
- Added a new "Map Events Pause Auto Start" utility (default on)
  - Next round won't be automatically started after ice destruction on Erosion or the eye closing on Polyphemus
- Wiki links now go to the community Bloons wiki and not the fandom one

#### Rogue Legends

- The reward popup after choosing a boost now goes away faster based on your fast forward speed
- Added hotkeys for choosing rewards (default 1,2,3,4,5), re-rolling rewards (default Tab), and selecting your reward choice (default Space, or pressing num again)
- You can reorder your towers in the My Party screen by selecting them and using the arrow keys
- Hotkey Display now works for Rogue Shop Icons, and if you have multiple of the same monkey pressing its hotkey repeatedly cycles through the options for it rather than only ever doing the first one

## [1.2.5] - 2025-02-05

- Copy/Paste Clipboard is no longer saved between games
- The following utilities will not be active within the new Rogue Legends mode
  - Copy/Paste Towers
  - In Game Hero Switch
  - Multi Place

## [1.2.4] - 2025-01-05

- Fixed Wiki Links not all turning off if disabled
- Fixed some in-game utilities working in the review map menu
- Fixed an error that affected Copy Pasted tower's total prices within discount villages

## [1.2.3] - 2024-12-11

- Fixed being able to copy paste some towers that aren't normally placeable

## [1.2.2] - 2024-12-10

- Fixed console errors in v46

## [1.2.1] - 2024-11-12

- Fixed the Quick Sell setting bypassing selling restrictions

## [1.2.0] - 2024-10-25

- Added the Jukebox Folder setting (Default `.../BloonsTD6/Jukebox`) wherein any .mp3 or .wav files will be automatically
  loaded into the BTD6 Jukebox
    - Can add new tracks from files without restarting the game, but can't delete them
- Added the Hide Friend Scores option (Default Off) that lets you Hide the indicators on the Map Select Screen of the
  highest round completed amongst you and your friends
- Added the Quick Sell option (Default On) that makes it so that if you hold down the Sell Tower hotkey, you will sell
  towers as you select them
- Dartling / Mortar / Paragon Sentry targeting and Bloon Trap Auto Retarget have moved to a separate
  mod [Tactical Tweaks](https://github.com/doombubbles/tactical-tweaks) for changes that directly alter gameplay and
  aren't just pure Quality of Life utilities

## [1.1.1] - 2024-10-09

- Fixed for BTD6 v45.0

## [1.1.0] - 2024-08-25

- Added an Auto Retarget Bloon Traps setting that can make Engineers with Larger Service Area periodically replace their traps to refersh them
- Added an In Game UI Transparency slider that can chance the opacity of certain UI elements that block the map area like the Tower Selection Menu
  - This slider is viewable in the in game Accessibility Settings menu like the effects slider, but if you want to make the change be persistent you'll need to edit it in the normal Mod Settings page
- Updated Wiki Links for recent additions like the Mermonkey
- Made In Game Hero Switch persist your switches more often when saving/loading

## [1.0.11] - 2024-08-18

- Fixed some interactions between In Game Hero Switch and restarting a match
- Added new functionality where you can right click on a Slider in the UI to manually set its value
- The default targeting option is no longer switched for Dartling Gunners / Mortars

## [1.0.10] - 2024-08-18

- Minor fixes for v44

## [1.0.9] - 2024-05-29

- Minor fixes for v43

## [1.0.8] - 2024-04-13

- Minor fixes for v42.1

## [1.0.7] - 2024-04-08

- Fixes for v42.0

## [1.0.6] - 2024-02-08

- Fixed In Game Hero Switch breaking after you start a new game

## [1.0.5] - 2024-02-07

- Fixes for v41.0

## [1.0.4] - 2023-12-05

- Fixes for v40.0

## [1.0.3] - 2023-10-14

- Updated degree calculations for v39 changes
- Added Degree Indicator to the paragon investment slider
- Removed the Sandbox Paragons utility in favor of NK's new way of doing it
  - The Unlimited 5th Tiers mod will also still automatically provided the old functionality

## [1.0.2] - 2023-10-10

- Recompiled for BTD6 39.0
- Fixed Embedded Browser usage on Epic

## [1.0.1] - 2023-09-27

- Fixed Dartling targeting not being applied to all crosspaths
- Fixed some mod settings icons

## [1.0.0] - 2023-09-27

- Initial Release

[unreleased]: https://github.com/doombubbles/UsefulUtilities/compare/1.4.10...HEAD
[1.4.10]: https://github.com/doombubbles/UsefulUtilities/compare/1.4.9...1.4.10
[1.4.9]: https://github.com/doombubbles/UsefulUtilities/compare/1.4.8...1.4.9
[1.4.8]: https://github.com/doombubbles/UsefulUtilities/compare/1.4.7...1.4.8
[1.4.7]: https://github.com/doombubbles/UsefulUtilities/compare/1.4.6...1.4.7
[1.4.6]: https://github.com/doombubbles/UsefulUtilities/compare/1.4.5...1.4.6
[1.4.5]: https://github.com/doombubbles/UsefulUtilities/compare/1.4.4...1.4.5
[1.4.4]: https://github.com/doombubbles/UsefulUtilities/compare/1.4.3...1.4.4
[1.4.3]: https://github.com/doombubbles/UsefulUtilities/compare/1.4.2...1.4.3
[1.4.2]: https://github.com/doombubbles/UsefulUtilities/compare/1.4.1...1.4.2
[1.4.1]: https://github.com/doombubbles/UsefulUtilities/compare/1.4.0...1.4.1
[1.4.0]: https://github.com/doombubbles/UsefulUtilities/compare/1.3.16...1.4.0
[1.3.16]: https://github.com/doombubbles/UsefulUtilities/compare/1.3.15...1.3.16
[1.3.15]: https://github.com/doombubbles/UsefulUtilities/compare/1.3.14...1.3.15
[1.3.14]: https://github.com/doombubbles/UsefulUtilities/compare/1.3.13...1.3.14
[1.3.13]: https://github.com/doombubbles/UsefulUtilities/compare/1.3.12...1.3.13
[1.3.12]: https://github.com/doombubbles/UsefulUtilities/compare/1.3.11...1.3.12
[1.3.11]: https://github.com/doombubbles/UsefulUtilities/compare/1.3.10...1.3.11
[1.3.10]: https://github.com/doombubbles/UsefulUtilities/compare/1.3.9...1.3.10
[1.3.9]: https://github.com/doombubbles/UsefulUtilities/compare/1.3.8...1.3.9
[1.3.8]: https://github.com/doombubbles/UsefulUtilities/compare/1.3.7...1.3.8
[1.3.7]: https://github.com/doombubbles/UsefulUtilities/compare/1.3.6...1.3.7
[1.3.6]: https://github.com/doombubbles/UsefulUtilities/compare/1.3.5...1.3.6
[1.3.5]: https://github.com/doombubbles/UsefulUtilities/compare/1.3.4...1.3.5
[1.3.4]: https://github.com/doombubbles/UsefulUtilities/compare/1.3.3...1.3.4
[1.3.3]: https://github.com/doombubbles/UsefulUtilities/compare/1.3.2...1.3.3
[1.3.2]: https://github.com/doombubbles/UsefulUtilities/compare/1.3.1...1.3.2
[1.3.1]: https://github.com/doombubbles/UsefulUtilities/compare/1.3.0...1.3.1
[1.3.0]: https://github.com/doombubbles/UsefulUtilities/compare/1.2.5...1.3.0
[1.2.5]: https://github.com/doombubbles/UsefulUtilities/compare/1.2.4...1.2.5
[1.2.4]: https://github.com/doombubbles/UsefulUtilities/compare/1.2.3...1.2.4
[1.2.3]: https://github.com/doombubbles/UsefulUtilities/compare/1.2.2...1.2.3
[1.2.2]: https://github.com/doombubbles/UsefulUtilities/compare/1.2.1...1.2.2
[1.2.1]: https://github.com/doombubbles/UsefulUtilities/compare/1.2.0...1.2.1
[1.2.0]: https://github.com/doombubbles/UsefulUtilities/compare/1.1.1...1.2.0
[1.1.1]: https://github.com/doombubbles/UsefulUtilities/compare/1.1.0...1.1.1
[1.1.0]: https://github.com/doombubbles/UsefulUtilities/compare/1.0.11...1.1.0
[1.0.11]: https://github.com/doombubbles/UsefulUtilities/compare/1.0.10...1.0.11
[1.0.10]: https://github.com/doombubbles/UsefulUtilities/compare/1.0.9...1.0.10
[1.0.9]: https://github.com/doombubbles/UsefulUtilities/compare/1.0.8...1.0.9
[1.0.8]: https://github.com/doombubbles/UsefulUtilities/compare/1.0.7...1.0.8
[1.0.7]: https://github.com/doombubbles/UsefulUtilities/compare/1.0.6...1.0.7
[1.0.6]: https://github.com/doombubbles/UsefulUtilities/compare/1.0.5...1.0.6
[1.0.5]: https://github.com/doombubbles/UsefulUtilities/compare/1.0.4...1.0.5
[1.0.4]: https://github.com/doombubbles/UsefulUtilities/compare/1.0.3...1.0.4
[1.0.3]: https://github.com/doombubbles/UsefulUtilities/compare/1.0.2...1.0.3
[1.0.2]: https://github.com/doombubbles/UsefulUtilities/compare/1.0.1...1.0.2
[1.0.1]: https://github.com/doombubbles/UsefulUtilities/compare/1.0.0...1.0.1
[1.0.0]: https://github.com/doombubbles/UsefulUtilities/compare/a98cbf90628b64277f7d141608b7995e83a10b33...1.0.0
