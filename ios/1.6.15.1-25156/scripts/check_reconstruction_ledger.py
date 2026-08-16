#!/usr/bin/env python3
"""Validate and summarize the iOS semantic-reconstruction method ledger."""

from __future__ import annotations

import argparse
import csv
from collections import Counter
from pathlib import Path

ALLOWED_STATUSES = {
    "queued",
    "triaged",
    "reconstructing",
    "reconstructed",
    "verified",
    "blocked",
}
ALLOWED_CONFIDENCE = {"", "high", "medium", "low"}
KEY_FIELDS = ("assembly", "type", "method", "token")


def read_rows(path: Path) -> list[tuple[Path, int, dict[str, str]]]:
    rows: list[tuple[Path, int, dict[str, str]]] = []
    with path.open(newline="", encoding="utf-8") as handle:
        reader = csv.DictReader(handle, delimiter="\t")
        for line_no, row in enumerate(reader, start=2):
            rows.append((path, line_no, row))
    return rows


def main() -> int:
    parser = argparse.ArgumentParser()
    parser.add_argument(
        "ledger",
        nargs="?",
        type=Path,
        default=Path(__file__).parents[1] / "reconstruction" / "methods.tsv",
        help="consolidated base ledger TSV",
    )
    parser.add_argument(
        "--fragments",
        type=Path,
        default=None,
        help="append-only fragment directory; defaults to <ledger-dir>/ledger",
    )
    parser.add_argument(
        "--no-fragments",
        action="store_true",
        help="validate only the consolidated base ledger",
    )
    args = parser.parse_args()

    fragment_dir = args.fragments or args.ledger.parent / "ledger"
    paths = [args.ledger]
    if not args.no_fragments and fragment_dir.is_dir():
        paths.extend(sorted(fragment_dir.glob("*.tsv")))

    source_rows: list[tuple[Path, int, dict[str, str]]] = []
    for path in paths:
        source_rows.extend(read_rows(path))

    seen: dict[tuple[str, ...], tuple[Path, int]] = {}
    errors: list[str] = []
    statuses: Counter[str] = Counter()
    confidences: Counter[str] = Counter()

    for path, line_no, row in source_rows:
        key = tuple(row.get(field, "") for field in KEY_FIELDS)
        location = f"{path}:{line_no}"
        if not all(key):
            errors.append(f"{location}: incomplete key {key!r}")
        elif key in seen:
            prior_path, prior_line = seen[key]
            errors.append(
                f"{location}: duplicate key {key!r}; first seen at {prior_path}:{prior_line}"
            )
        else:
            seen[key] = (path, line_no)

        status = row.get("status", "")
        confidence = row.get("confidence", "")
        if status not in ALLOWED_STATUSES:
            errors.append(f"{location}: invalid status {status!r}")
        if confidence not in ALLOWED_CONFIDENCE:
            errors.append(f"{location}: invalid confidence {confidence!r}")
        statuses[status] += 1
        confidences[confidence or "unset"] += 1

    print("ledger files:")
    for path in paths:
        print(f"  {path}")
    print(f"rows: {len(source_rows)}")
    print("status: " + ", ".join(f"{k}={v}" for k, v in sorted(statuses.items())))
    print("confidence: " + ", ".join(f"{k}={v}" for k, v in sorted(confidences.items())))

    if errors:
        for error in errors:
            print(f"ERROR: {error}")
        return 1
    print("validation: OK")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
