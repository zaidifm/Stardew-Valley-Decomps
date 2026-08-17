# AStarNode object-debug pass 34

Target: `DebugObjectParentSheetIndexOnTile`, token `0x06006642`, native `0x101fa95f8`, iOS `1.6.15.1` build `25156`.

Source commit: `beee4b954359a267fddf752051ffb4892c9011c2`.

## Tile object lookup

The method uses the already-proven `gameLocation.objects.TryGetValue(new Vector2(x,y), out value)` helper. Missing object returns without logging.

## ParentSheetIndex field

The first object field read is at `Item +0x58`. Direct ARM64 for mapped `Item.get_ParentSheetIndex` (`0x06003845`, native `0x1018a5424`) is:

- load reference at `this +0x58`;
- load its integer value at `+0x68`.

Thus the referenced object is the managed `Item.parentSheetIndex : NetInt` field. The debug method retains the NetInt object itself and calls its virtual `ToString` when non-null.

## Virtual `+0x60` identity

Both the NetInt receiver and the tile object are dispatched through `MonoVTable +0x60`.

For `System.Object`, metadata virtuals are Finalize, ToString, Equals, GetHashCode. Mono's class-vtable assignment gathers metadata-order virtuals with `g_slist_prepend`, so the effective assigned order is GetHashCode slot0, Equals slot1, ToString slot2, Finalize slot3. With the ARM64 MonoVTable header at `0x50`, slot2 is byte offset `0x60`.

Therefore both calls are ordinary `ToString()` virtual dispatches.

## Recovered literals

LLVM scalar decoding supplies:

- `0x1039046b0` -> `obj.parentSheetIndex:`
- `0x1038d7758` -> `, `

The native four-argument concat is therefore equivalent to:

`string.Concat("obj.parentSheetIndex:", value.parentSheetIndex?.ToString(), ", ", value.ToString())`

and the result is passed to global mobile `Log.It(string)` (token `0x06000016`).

## Validation

The source shape is consistent with the preserved iOS managed field/method signatures. The only nullable branch in the native body is the defensive parentSheetIndex null check; the reconstruction preserves it with `?.ToString()`.
