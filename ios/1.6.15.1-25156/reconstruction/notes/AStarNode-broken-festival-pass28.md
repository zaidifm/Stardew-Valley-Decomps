# AStarNode broken-festival-tile pass 28

Target: `get_BrokenFestivalTile`, token `0x06006638`, native `0x101fa8920`, iOS `1.6.15.1` build `25156`.

Source commit: `e6b3109e873bc1b1ba153b6de52829cb188a1508`.

## Exact managed constants

The new LLVM AOT scalar decoder resolves the two season globals used by the native body:

- scalar `0x1038ef1f8` -> `fall`
- scalar `0x1038ef200` -> `winter`

The remaining opaque scalar at `0x1038d5780` is an LLVM GOT patch of type `MONO_PATCH_INFO_SFLDA`. Mono runtime source defines SFLDA payloads as `decode_field_info`, which decodes a class reference followed by a FieldDef index.

For this target, the patch decodes as:

- `MONO_AOT_TYPEREF_TYPEDEF_INDEX`
- TypeDef index `1060` -> token `0x02000424` -> `StardewValley.Game1`
- FieldDef index `5388` -> token `0x0400150C` -> public static `Game1.dayOfMonth`

This proves the date field rather than inferring it from the numeric comparisons.

## Native predicate

The method first requires `Game1.CurrentEvent != null`, then returns true only for four hardcoded festival obstruction cells:

- `(18,31)` on fall 16
- `(16,19)` on fall 27
- `(66,4)` on winter 8
- `(103,28)` on winter 8

All other coordinates/dates return false.

String equality is the normal managed string comparison emitted through the external string helper; there is no culture-sensitive behavior visible in this method.

## Validation

The reconstructed property compiles with .NET SDK `10.0.400` against minimal Game1/AStarNode stubs with **0 warnings, 0 errors**.
