# AStarNode NPC predicate pass 16

Targets:

- `ContainsNPC`, token `0x06006653`, native `0x101fac668`
- `FetchNPC`, token `0x06006654`, native `0x101facad0`

Source commit: `8649b73a6fe52c7ec6dc5fc180a4bb2a4b5c556a`.

## Special Beach NPC

Both native methods first apply a Mono class/supertype test using class global `0x1038c6b60`, then read subclass field `+0x2f8` as an NPC.

The class global is proven to be `StardewValley.Locations.Beach` from two independent pieces of evidence in iOS `TapToMove.OnTap`:

1. the same class global guards Beach-specific tap logic around tiles `(58/59, 11/12)`;
2. after that guard native code reads subclass field `+0x300` as `NetBool.Value`.

The iOS Beach managed metadata begins its subclass fields with:

- `internal NPC oldMariner`
- `public readonly NetBool bridgeFixed`
- `public NetMutex derbyMutex`

The native offsets therefore line up exactly as `oldMariner` at `+0x2f8`, `bridgeFixed` at `+0x300`, and `derbyMutex` at `+0x308`. `AdventureGuild.Gil`, the other plausible NPC-at-+0x2f8 candidate, is ruled out because the following AdventureGuild field is an ordinary bool and cannot produce the observed NetBool dereference.

The recovered methods consequently test `Beach.oldMariner` first and compare its `StandingPixel / 64` tile to `(x,y)`.

## Regular characters

The next loop reads GameLocation field `+0xa0`, which is the iOS managed `characters : NetCollection<NPC>` field.

`FetchNPC` returns the first regular NPC whose `StandingPixel.X / 64 == x` and `StandingPixel.Y / 64 == y`.

`ContainsNPC` has an additional shipped filter before the tile test:

`if (npc is Pet pet && pet.isSleepingOnFarmerBed.Value) continue;`

The Pet class global is pinned independently from iOS `NPC.get_Dialogue`, whose shared source checks `Monster`, `Pet`, `Horse`, and `Child` in that order. The second native class global used there is the same `0x1038c6688` used by `ContainsNPC`.

The Pet field dereferenced at object `+0x488` is independently proven as `Pet.isSleepingOnFarmerBed : NetBool` by iOS `Pet.UpdateSleepingOnBed`, which loads that exact field and its NetBool value at `+0x68`.

This sleeping-pet exclusion exists only in `ContainsNPC`; `FetchNPC` does not apply it. The semantic reconstruction preserves the asymmetry.

## Event actors

When the regular-character scan finishes, both native methods read GameLocation `+0x1f0`, then Event `+0x80`.

These are proven to be `GameLocation.currentEvent` and `Event.actors`:

- iOS `GameLocation.isCharacterAtTile` (token `0x06003A22`, native `0x1018e7738`) reads GameLocation `+0x1f0`; when non-null it iterates the collection at Event `+0x80`, otherwise it iterates GameLocation `characters` at `+0xa0`;
- the current shared C# for `isCharacterAtTile` has exactly that `currentEvent.actors` versus `characters` branch;
- Event managed field layout places `actors`, `props`, and `festivalProps` consecutively; earlier native passes independently pinned `props` at `+0x88` and `festivalProps` at `+0x90`, fixing `actors` at `+0x80`.

The AStar methods scan event actors after the regular-character list and apply the same `StandingPixel / 64` tile comparison.

## Signed division

ARM64 implements each coordinate `/ 64` by adding 63 for a negative value before arithmetic shift-right six places. This matches C# signed integer division truncating toward zero, so the reconstruction uses ordinary `standingPixel.X / 64` and `standingPixel.Y / 64` expressions.

## Validation

The pair was compile-checked with the persisted .NET SDK `10.0.400` against signature-compatible Beach, Pet, Event, NPC, and GameLocation stubs.

Result: 0 errors. Two `CS0649` warnings are stripped-harness-only uninitialized-field warnings (`_aStarGraph` and stub `Beach.oldMariner`).
