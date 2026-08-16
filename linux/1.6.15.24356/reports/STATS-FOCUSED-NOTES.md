# Stats changes visible in 1.6.15

- `Values` is now `StatsDictionary<uint>`.
- `specificMonstersKilled` is now `StatsDictionary<int>`.
- `StatsDictionary<TValue>` merges duplicate serialized stat keys during deserialization (except special handling for `averageBedtime`), which is directly relevant to save compatibility.
- New public methods detected relative to the uploaded 1.6.8 source: `CanUnlockPlatformAchievements`, `checkForBooksReadAchievement`, `checkForCommunityCenterOrJojaAchievements`, `checkForFullHouseAchievement`, `checkForHeldItemAchievements`, `checkForMineAchievement`, `checkForMiniGameAchievements`, `checkForMonsterSlayerAchievement`, `checkForSkillAchievements`, `checkForStardropAchievement`.
- `AllowRetroactiveAchievements` now delegates to the active platform SDK capability.
