# Reconstruction ledger fragments

`../methods.tsv` is the periodically consolidated base snapshot. This directory contains append-only per-pass TSV fragments created after the most recent consolidation.

The canonical logical ledger is therefore:

`methods.tsv + ledger/*.tsv`

Use `../scripts/check_reconstruction_ledger.py` from the iOS build root (or invoke the script by its repository path) to validate the combined ledger and detect duplicate method keys.

Each fragment uses the exact same header/schema as `methods.tsv`. Do not repeat a row already present in the base snapshot or an earlier fragment. When fragments become numerous, consolidate them into `methods.tsv` in one explicit commit, validate the consolidated file with `--no-fragments`, then delete the absorbed fragments in the same semantic maintenance change.

This split exists because the GitHub contents API replaces whole files on update. Append-only fragments keep small reconstruction passes small and auditable instead of rewriting an ever-growing TSV for every recovered method.
