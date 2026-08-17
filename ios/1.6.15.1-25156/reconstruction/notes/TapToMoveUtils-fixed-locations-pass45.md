# TapToMoveUtils fixed-location helpers pass 45

Targets:

- `ContainsTravellingCart(int,int)` token `0x060066CD`, native `0x101fc8764`
- `ContainsTravellingDesertShop(int,int)` token `0x060066CE`, native `0x101fc8954`
- `ContainsCinemaDoor(int,int)` token `0x060066CF`, native `0x101fc8a48`
- `ContainsCinemaTicketOffice(int,int)` token `0x060066D0`, native `0x101fc8b2c`
- `IsIslandNorthSuspensionBridgeRightSide(Vector2)` token `0x060066EA`, native `0x101fcb698`
- `IsWizardBuilding(AStarNode)` token `0x0600670E`, native `0x101fce788`
- `IsWizardBuilding(Vector2)` token `0x0600670F`, native `0x101fce7e0`
- public constructor token `0x0600671E`, native `0x101fd1484`

Canonical source commit after import qualification cleanup: `a1f404c148f52a4e2262f7b24730e40efaa42e6d`.

## Travelling cart / desert shop

These utility methods use the **same native class globals** previously proven in the completed AStarNode predicates:

- `0x1038c6c70` -> `StardewValley.Locations.Forest`
- `0x1038c6c18` -> `StardewValley.Locations.Desert`

The semantics differ from AStarNode because these methods take clicked point coordinates, not a node rectangle.

`ContainsTravellingCart`:

- require `gameLocation is Forest`;
- if `forest.travelingMerchantBounds` is null, false;
- iterate each Rectangle and return true on `bounds.Contains(pointX,pointY)`.

`ContainsTravellingDesertShop`:

- require `gameLocation is Desert`;
- return `desert.desertMerchantBounds.Contains(pointX,pointY)`.

The iOS metadata marks `Desert.desertMerchantBounds` internal, so this same-assembly utility access is legal even though the current Linux decompile presents a different source-level visibility.

## Cinema interaction footprints

Town identity and exact `ccMovieTheater` mail flag were already proven while reconstructing AStarNode.ContainsCinema.

Both methods require:

- `gameLocation is Town`;
- `Utility.doesMasterPlayerHaveMailReceivedButNotMailForTomorrow("ccMovieTheater")`.

Cinema door footprint from native comparisons:

- x 52..53
- y 18..19

Ticket-office footprint: the native low-four-bit mask condition is true only when all four comparisons hold:

- x > 53
- x < 57
- y > 18
- y < 21

therefore x 54..56 and y 19..20.

## Island North suspension bridge right side

Exact literal predicate:

`tile.X > 37 && tile.X < 48 && tile.Y == 39`.

The separate broader `isOnOrNearSuspensionBridge(int,int)` method remains unreconstructed because it also depends on an as-yet-unnamed Farmer NetBool field at native object offset `+0x438`; this pass does not guess that field.

## Wizard building

AStarNode overload directly reads the node coordinates and delegates as a Vector2; null follows ordinary native null-reference failure.

Vector2 overload:

1. require `gameLocation.IsBuildableLocation()`;
2. `gameLocation.getBuildingAt(tile)` must return a Building;
3. `building.buildingType.Value` must equal exact recovered LLVM string `Obelisk` or `Junimo Hut`.

LLVM literals:

- scalar `0x1038fae90` -> `Obelisk`
- scalar `0x1038ff320` -> `Junimo Hut`

The two native string helpers both implement equality paths here; the observable result is exact equality to either building type.

## Constructor

Native constructor body immediately returns. The reconstructed public constructor is intentionally empty.

## Validation

The eight methods were compiled together with .NET SDK 10.0.400 against MonoGame.Framework plus signature-compatible Forest/Desert/Town/Building/GameLocation stubs.

Result: **0 warnings, 0 errors**.

## Result

TapToMoveUtils reconstruction reaches **48/84 methods**.

Next cheap methods by native body size include player-position/warp-range helpers, house-plant/music-block/ore predicates, FetchGate, and IsTerrainFeatureAt. Prefer whichever forms the cleanest dependency-local cluster; keep the unresolved suspension-bridge Farmer field isolated rather than guessing it.
