# AStarNode bubble flood-fill pass 12

Target:

- `SetBubbleIDRecursively`, token `0x0600662C`, native `0x101fa78ac`

Source commit: `f120c5bf97c117817025688f6884e513146d4778`.

## Recovered state fields

The managed metadata defines two fields not required by the earlier structural slices but used directly here:

- `bubbleChecked` at object offset `+0x44`
- `_searchAStarNode` reference at `+0x20`

Both are now present in the staged partial class.

## Control flow

The native method behaves as follows:

1. If `bubbleChecked` is already true, return false.
2. Set `bubbleChecked = true`.
3. If the primary `this.bubbleID` is nonzero and `TileClear` is false, return false.
4. Assign the requested ID to `bubbleID2` when `two == true`; otherwise assign it to primary `bubbleID`.
5. Fetch north `(x,y-1)`, store it in `_searchAStarNode`, recurse when non-null.
6. Repeat for south `(x,y+1)`, west `(x-1,y)`, and east `(x+1,y)` in that exact order.
7. Clear `_searchAStarNode` to null and return true.

The method deliberately ignores recursive return values. `bubbleChecked` is the recursion/visited guard.

The primary-bubble test in step 3 is exactly `this.bubbleID != 0`; it is not normalized to the constructor's `-1` sentinel or to the selected `two` target.

## Validation

The reconstructed partial compiles with the persisted .NET SDK `10.0.400` against minimal `AStarGraph.FetchAStarNode` / `TileClear` stubs: 0 errors. One `CS0649` warning comes solely from the stripped harness leaving `_aStarGraph` uninitialized.
