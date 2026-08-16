# iOS 1.6.15.1 C# reconstruction

This directory contains semantic C# reconstruction work derived from the preserved iOS managed metadata and native ARM64/AOT evidence.

## Layout

- `subsystems.tsv` — coarse work queue and pilot scoring.
- `methods.tsv` — periodically consolidated method-level ledger snapshot.
- `ledger/*.tsv` — append-only per-pass ledger rows newer than the current snapshot.
- `src/` — readable reconstructed C# only after a unit has been investigated.
- `notes/` — subsystem-specific evidence notes when a ledger cell is insufficient.
- `PROGRESS.md` — compact current resume/checkpoint marker.

The canonical logical method ledger is `methods.tsv + ledger/*.tsv`. The validator under `../scripts/check_reconstruction_ledger.py` reads both by default and rejects duplicate method keys.

The authoritative extraction evidence remains outside this directory under `managed-metadata/`, `native-aot/`, `mappings/`, and `manifests/`.

## Resume rule

A new worker should read `docs/IOS-CSHARP-RECONSTRUCTION.md`, then this README, `PROGRESS.md`, `subsystems.tsv`, the base `methods.tsv`, and any `ledger/*.tsv` fragments, then inspect the latest commits on `ios-csharp-reconstruction`. Do not rely on chat history to determine project state.

## Method ledger key

Rows are keyed by `(assembly, type, method, token)`. Overloads therefore remain distinct even when their names match.

Evidence paths should point to checked-in repository artifacts wherever possible. A native address should be recorded when known. Linux counterpart paths are references, not proof of equivalence.

Small passes should add a new ledger fragment rather than rewriting the complete base TSV. Periodically consolidate fragments into `methods.tsv` in an explicit maintenance commit after validating that the combined ledger is duplicate-free.
