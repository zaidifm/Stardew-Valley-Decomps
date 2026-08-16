# Initial structural comparison: 1.6.8.24119 → 1.6.15.24356

The older uploaded GitHub tree identifies itself as `1.6.8.24119`; the current Steam assembly identifies itself as `1.6.15.24356`.

- Main current source units: **950** vs old **911** (excluding AssemblyInfo).
- Same canonical namespace/type path: **898**.
- Current-only paths: **52**.
- Old-only paths: **13**.
- Among the 898 same-path files, a conservative comment/using/whitespace-stripped text normalization finds **245 unchanged** and **653 textually changed**. Decompiler-version/local-variable differences inflate the changed count, so treat this as a triage metric, not a semantic diff.
- GameData: **167 current** vs **165 old**, with **2 current-only** and **0 old-only** paths.

## High-signal current additions / reorganizations

- `StardewValley.Network.Dedicated.DedicatedServer` and `DedicatedServerMessageType` now exist as top-level dedicated-server infrastructure.
- A `ContentManifest` / `ContentManifest.Internal` parser subsystem appears (14 top-level types).
- `StardewValley.SaveSerialization.SaveSerializer` and Vector2 serializer/reader/writer types now live in a dedicated save-serialization namespace.
- `StardewValley.StatsDictionary<TValue>` appears, and current `Stats.Values` / `specificMonstersKilled` use it instead of the older case-insensitive serializable dictionary directly.
- `StardewValley.ChatCommands`, `DebugTimings`, new delegate helpers, and extra test/translation-validation classes appear.
- Trinket classes are reorganized under `StardewValley.Objects.Trinkets`.
- `HaveBuildingQuest` appears as a current quest type.
- Current GameData adds `StardewValley.GameData.LostItem` and `StardewValley.GameData.FishPonds.FishPondWaterColor`.

## Current-only canonical paths

- `ContentManifest.Internal/CHArray.cs`
- `ContentManifest.Internal/CHBoolean.cs`
- `ContentManifest.Internal/CHElement.cs`
- `ContentManifest.Internal/CHJson.cs`
- `ContentManifest.Internal/CHJsonParserContext.cs`
- `ContentManifest.Internal/CHNumber.cs`
- `ContentManifest.Internal/CHObject.cs`
- `ContentManifest.Internal/CHParsable.cs`
- `ContentManifest.Internal/CHString.cs`
- `ContentManifest.Internal/CHValue.cs`
- `ContentManifest.Internal/CHValueEnum.cs`
- `ContentManifest.Internal/CHValueUnion.cs`
- `ContentManifest/CHJsonParser.cs`
- `ContentManifest/ContentHashParser.cs`
- `Microsoft.CodeAnalysis/EmbeddedAttribute.cs`
- `StardewValley.Constants/AchievementIds.cs`
- `StardewValley.Delegates/ChatCommandHandlerDelegate.cs`
- `StardewValley.Delegates/GetForEachItemPathDelegate.cs`
- `StardewValley.Extensions/GameExtensions.cs`
- `StardewValley.Extensions/StringExtensions.cs`
- `StardewValley.Internal/ForEachItemContext.cs`
- `StardewValley.Internal/LogBuilder.cs`
- `StardewValley.Menus/IScreenReadable.cs`
- `StardewValley.Network.Dedicated/DedicatedServer.cs`
- `StardewValley.Network.Dedicated/DedicatedServerMessageType.cs`
- `StardewValley.Objects.Trinkets/CompanionTrinketEffect.cs`
- `StardewValley.Objects.Trinkets/FairyBoxTrinketEffect.cs`
- `StardewValley.Objects.Trinkets/IceOrbTrinketEffect.cs`
- `StardewValley.Objects.Trinkets/MagicQuiverTrinketEffect.cs`
- `StardewValley.Objects.Trinkets/RainbowHairTrinketEffect.cs`
- `StardewValley.Objects.Trinkets/Trinket.cs`
- `StardewValley.Objects.Trinkets/TrinketEffect.cs`
- `StardewValley.Quests/HaveBuildingQuest.cs`
- `StardewValley.SaveSerialization/SaveSerializer.cs`
- `StardewValley.SaveSerialization/Vector2Reader.cs`
- `StardewValley.SaveSerialization/Vector2Serializer.cs`
- `StardewValley.SaveSerialization/Vector2Writer.cs`
- `StardewValley.Tests/ExtractSyntaxDelegate.cs`
- `StardewValley.Tests/SyntaxAbstractor.cs`
- `StardewValley.Tests/TranslationValidator.cs`
- `StardewValley.Tests/TranslationValidatorIssue.cs`
- `StardewValley.Tests/TranslationValidatorResult.cs`
- `StardewValley.Util/DictionarySaver.cs`
- `StardewValley.Util/SaveablePair.cs`
- `StardewValley.Util/SaveablePairExtensions.cs`
- `StardewValley.Util/StackTraceHelper.cs`
- `StardewValley.WorldMaps/MapAreaPositionWithContext.cs`
- `StardewValley/ChatCommands.cs`
- `StardewValley/DebugTimings.cs`
- `StardewValley/StatsDictionary.cs`
- `System.Runtime.CompilerServices/NullableAttribute.cs`
- `System.Runtime.CompilerServices/NullableContextAttribute.cs`

## Old-only canonical paths (removed or moved)

- `StardewValley.Network/NetBuildingRef.cs`
- `StardewValley.Objects/CompanionTrinketEffect.cs`
- `StardewValley.Objects/FairyBoxTrinketEffect.cs`
- `StardewValley.Objects/IceOrbTrinketEffect.cs`
- `StardewValley.Objects/MagicQuiverTrinketEffect.cs`
- `StardewValley.Objects/MusicPlayerTrinketEffect.cs`
- `StardewValley.Objects/RainbowHairTrinketEffect.cs`
- `StardewValley.Objects/ToolSkinTrinketEffect.cs`
- `StardewValley.Objects/Trinket.cs`
- `StardewValley.Objects/TrinketEffect.cs`
- `StardewValley/Vector2Reader.cs`
- `StardewValley/Vector2Serializer.cs`
- `StardewValley/Vector2Writer.cs`
