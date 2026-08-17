# TapToMoveUtils inventory/tool helpers pass 47

Targets:

- `SelectTool(string)` token `0x060066D1`, native `0x101fc8c44`
- `PlayerHasTool(string)` token `0x060066D2`, native `0x101fc8e08`
- `getBestAvailableWeapon()` token `0x060066D3`, native `0x101fc8f98`
- `FetchItemInInventoryByName(string)` token `0x060066D4`, native `0x101fc9280`

Source commit: `71eabe88242f5a081567363f794d7c8ce07be265`.

## Farmer inventory identity

All four methods iterate `Game1.player.Items` by index. Current Linux Farmer source independently identifies the same inventory property and `CurrentToolIndex` semantics, while the iOS native body remains implementation authority.

The virtual Item call at MonoVTable `+0x1E8` is the same ItemId getter already proven in house-plant/object reconstruction. Therefore the `toolName` / `itemName` arguments are compared against **ItemId**, not display names.

## SelectTool

For each non-null inventory item:

- compare `item.ItemId == toolName`;
- on match, set `Game1.player.CurrentToolIndex = i` using mapped Farmer setter token `0x060035A4`;
- call mapped `Farmer.UpdateItemStow()` token `0x060036BB`, native `0x10186367c`;
- return true.

No match returns false.

## PlayerHasTool

Same ItemId scan with no selection side effect. First match returns true, otherwise false.

## FetchItemInInventoryByName

Same ItemId scan and returns the matching Item itself. No match returns null.

The historical method name says “ByName,” but the shipped iOS implementation compares ItemId. That mismatch is preserved rather than modernized.

## getBestAvailableWeapon

LLVM CLASS patch scalar `0x1038c7a50` decodes to iOS TypeDef 1235, `StardewValley.Tools.MeleeWeapon`.

The candidate/best virtual method at MonoVTable `+0x4A8` corresponds to `MeleeWeapon.getItemLevel()`; iOS metadata token `0x060043D5`, mapped native `0x101a5bca4`, and current shared source independently confirm it is the virtual item-level ranking method.

Algorithm:

- inspect each inventory item that is a MeleeWeapon;
- first MeleeWeapon becomes best;
- later weapon replaces best when its `getItemLevel()` is greater;
- **or** when the current best has exact ItemId `Scythe`.

Exact LLVM string scalar `0x1038f0c60` -> `Scythe`.

This means Scythe is deliberately deprioritized: once it is the current best, any later MeleeWeapon replaces it even if the later weapon's item level is equal or lower. The reverse is not true; a later Scythe does not displace a stronger non-Scythe merely because it is a Scythe.

No MeleeWeapon returns null.

## Validation

All four methods compile together with .NET SDK 10.0.400 against signature-compatible Farmer/Item/MeleeWeapon stubs.

Result: **0 warnings, 0 errors**.

## Result

TapToMoveUtils reaches **57/84 reconstructed methods**.
