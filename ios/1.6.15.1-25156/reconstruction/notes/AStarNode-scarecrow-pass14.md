# AStarNode scarecrow predicate pass 14

Target:

- `ContainsScarecrow`, token `0x06006659`, native `0x101fad7f4`

Source commit: `f625023e8a71335f02f43f2a3b335c001f5c63a5`.

## Object lookup

The method uses the same object dictionary primitives already established elsewhere: it tests `gameLocation.objects` at `new Vector2(x,y)` and reads the object at that tile.

## ParentSheetIndex identity

The native scarecrow method reads an integer through:

`object + 0x58 -> referenced field + 0x68`

Direct ARM64 for iOS `Item.get_ParentSheetIndex` (token `0x06003845`, native `0x1018a5424`) is exactly:

- `ldr x8, [x0, #0x58]`
- `ldr w0, [x8, #0x68]`
- return

So the supposedly anonymous native field is proven to be `value.ParentSheetIndex`.

## Hardcoded legacy set

The shipped ARM64 subtracts 110 and tests a 58-bit range against mask `0x020000007c010009`, with a separate special case for ID 8.

Expanding that mask yields exactly:

`110, 113, 126, 136, 137, 138, 139, 140, 167`

Together with the special case, `ContainsScarecrow` accepts these ten legacy parent-sheet indices:

`8, 110, 113, 126, 136, 137, 138, 139, 140, 167`

The reconstruction preserves this hardcoded mobile set. It intentionally does not substitute the newer shared `Object.IsScarecrow()` data-driven API, because that would change the behavior being reconstructed.

## Validation

The method compiles under the persisted .NET SDK `10.0.400` against minimal object-dictionary and `ParentSheetIndex` stubs: 0 errors. One `CS0649` warning is only the stripped harness leaving `_aStarGraph` uninitialized.
