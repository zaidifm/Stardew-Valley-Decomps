# iOS 1.6.15.1 C# reconstruction

This directory contains semantic C# reconstruction work derived from the preserved iOS managed metadata and native ARM64/AOT evidence.

## Layout

- `subsystems.tsv` — coarse work queue and pilot scoring.
- `methods.tsv` — method-level reconstruction ledger.
- `src/` — readable reconstructed C# only after a unit has been investigated.
- `notes/` — concise subsystem-specific evidence notes when a ledger cell is insufficient.

The authoritative extraction evidence remains outside this directory under `managed-metadata/`, `native-aot/`, `mappings/`, and `manifests/`.

## Resume rule

A new worker should read `docs/IOS-CSHARP-RECONSTRUCTION.md`, then this README, then `subsystems.tsv` and `methods.tsv`, then inspect the latest commits on `ios-csharp-reconstruction`. Do not rely on chat history to determine project state.

## Method ledger key

Rows are keyed by `(assembly, type, method, token)`. Overloads therefore remain distinct even when their names match.

Evidence paths should point to checked-in repository artifacts wherever possible. A native address should be recorded when known. Linux counterpart paths are references, not proof of equivalence.
