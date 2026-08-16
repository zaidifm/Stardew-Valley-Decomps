# AStarPath reconstruction pass 1

Target: `StardewValley.Mobile.AStarPath` in iOS `1.6.15.1` build `25156`.

Reconstruction source commit: `46f602a33edf8fd6f6dea2d7cdda67d88e43ed1e`.

## Correspondence result

No `StardewValley.Mobile.AStarPath` counterpart exists in the recovered Linux `1.6.15.24356` source tree. This is therefore a native-first mobile reconstruction rather than a Linux-assisted port.

## Verified methods

| Token | Method | Native address | Result |
|---|---|---:|---|
| `0x0600665E` | `get_nodes` | `0x101fae350` | returns `_nodeList` at object offset `0x10` |
| `0x0600665F` | `set_nodes` | `0x101fae374` | assigns `_nodeList` with the Mono GC write barrier |
| `0x06006660` | `get_length` | `0x101fae3b4` | returns `_length` at object offset `0x18` |
| `0x06006661` | `Bake` | `0x101fae3d8` | resets `_length`, walks each path node's passable neighbours, counts in-path edges only once using a visited list, and accumulates the squared coordinate distance |
| `0x06006662` | `Distance` | `0x101fae6e8` | squared Euclidean distance; no square root |
| `0x06006664` | `containsClosedGate` | `0x101faea0c` | returns first node where `isGate()` is true and `isGateOpen()` is false; otherwise null |
| `0x06006665` | `ContainsGate` | `0x101faec1c` | returns first node where `isGate()` is true; otherwise null |
| `0x06006666` | `.ctor` | `0x101faedbc` | initializes `_nodeList` to a new empty `List<AStarNode>` |

The native `Distance` body is particularly unambiguous. ARM64 instructions at `0x101fae6e8` form two 32-bit coordinate differences, sign-extend/convert them to floating point, square both lanes with `fmul.2d`, horizontally add them with `faddp.2d`, convert to `float`, and return. The same squared-distance calculation is inlined inside `Bake`.

`Bake` repeatedly invokes `AStarNode.GetNeighbouringNodeList(true)`. It tests whether each neighbour is in this path and is not already in the temporary visited list before adding the squared distance, then appends the current node to that visited list. This prevents counting an undirected edge twice.

## Deliberately unresolved

`0x06006663 AStarPath.ToString @ 0x101fae714` has recovered control flow, but its managed string constants are materialized through AOT runtime globals. The native shape shows repeated string concatenation and a final node-count suffix, but the exact literal punctuation/text has not yet been recovered. It is intentionally omitted rather than guessed.

## Validation

The staged `AStarPath.cs` was compiled with the persisted .NET SDK `10.0.400` against minimal `AStarNode` signature stubs. Result: 0 warnings, 0 errors. This validates C# syntax/type shape only; native equivalence is established from the iOS evidence above.

## Evidence paths

- `ios/1.6.15.1-25156/managed-metadata/source-skeleton/StardewValley.Mobile/AStarPath.cs`
- `ios/1.6.15.1-25156/managed-metadata/methods.tsv`
- `ios/1.6.15.1-25156/mappings/StardewValley.map.tsv`
- `ios/1.6.15.1-25156/native-aot/pseudocode/mobile-core/c/0600665e__SDV_StardewValley_Mobile_AStarPath_get_nodes_0600665e.c`
- through `06006666__SDV_StardewValley_Mobile_AStarPath_ctor_06006666.c`

## Next

Recover a bounded set of `AStarNode` structural primitives used directly by `AStarPath`, prioritizing coordinate/cost properties, neighbour-list behavior, and gate predicates. Return to `AStarPath.ToString` after string-literal recovery is mechanized rather than hand-guessed.
