# iOS C# reconstruction workflow

Branch: `ios-csharp-reconstruction`

Baseline evidence commit: `0fc927ef3939d1cd933fef644f3462172b4e321c`.

## Goal

Produce readable, evidence-backed C# reconstructions of Stardew Valley iOS 1.6.15.1 / build 25156 without altering the preserved extraction evidence.

This is a semantic reconstruction project, not a claim to recover ConcernedApe's original source text. Formatting, local names, source-file boundaries, compiler transformations, and other source-level details may be irrecoverable.

## Evidence hierarchy

1. iOS managed metadata: authoritative for managed type/member names, signatures, fields, properties, attributes, and tokens.
2. iOS native AOT evidence: authoritative for shipped implementation behavior. This includes managed-to-native maps, Ghidra pseudocode, and raw ARM64 fallback output.
3. Linux 1.6.15.24356 decompilation: high-value semantic reference for shared game logic, but never sufficient by itself to claim iOS equivalence.
4. Older decompilations and the unverified iOS 1.6.15.0 package: secondary structural references only.

## Immutable evidence rule

Do not edit the checked-in managed metadata skeletons, native pseudocode, ARM64 fallbacks, AOT mappings, manifests, or recovery scripts merely to make them prettier. Reconstruction output belongs under `ios/1.6.15.1-25156/reconstruction/`.

## Reconstruction loop

For each bounded unit:

1. Identify the iOS type/method and its managed token/signature.
2. Find the Linux counterpart when one exists.
3. Inspect the mapped iOS native implementation.
4. Compare control flow, constants, field accesses, calls, and platform-specific behavior.
5. Follow additional native callees only when ambiguity blocks reconstruction.
6. Write readable C# under `reconstruction/src/`.
7. Update the method ledger with evidence, status, confidence, and notes.
8. Validate the ledger and any available C# scaffolding.
9. Commit the completed semantic unit.

## Status vocabulary

- `queued`: identified but not yet triaged.
- `triaged`: evidence and likely counterpart identified.
- `reconstructing`: active semantic reconstruction.
- `reconstructed`: readable C# written, but native verification is incomplete.
- `verified`: reconstruction checked against the relevant native evidence.
- `blocked`: a specific unresolved dependency or evidence gap prevents completion.

Confidence is `high`, `medium`, or `low`. Confidence is an assessment of the reconstruction, not a substitute for the status field.

## Granularity and checkpoint discipline

Prefer a small class or roughly 5-20 tightly related methods per semantic commit. Make an earlier checkpoint when a new mapping rule, helper interpretation, or tooling improvement would otherwise exist only in transient chat/container state.

GitHub is the canonical conclusion/progress record. Private original binaries, IPAs, Ghidra databases, and bulky intermediate artifacts remain in the private Library workspace.

## Dependency policy

Use the existing global AOT map as a random-access index. Do not decompile the entire native program preemptively. Expand a dependency only when its behavior matters to the parent reconstruction. Promote repeated discoveries into scripts or documented conventions so later work gets cheaper.

## Pilot policy

Initial pilot candidates are scored in `ios/1.6.15.1-25156/reconstruction/subsystems.tsv`. The first pass favors bounded mobile/pathfinding/input units with complete native recovery and useful Linux context. Large integration methods such as `TapToMove.OnTap` are deferred until the smaller vocabulary and dependencies around them are understood.
