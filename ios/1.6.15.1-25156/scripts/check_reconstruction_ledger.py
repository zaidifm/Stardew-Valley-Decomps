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


def main() -> int:
    parser = argparse.ArgumentParser()
    parser.add_argument(
        "ledger",
        nargs="?",
        type=Path,
        default=Path(__file__).parents[1] / "reconstruction" / "methods.tsv",
    )
    args = parser.parse_args()

    with args.ledger.open(newline="", encoding="utf-8") as handle:
        rows = list(csv.DictReader(handle, delimiter="\t"))

    seen: set[tuple[str, ...]] = set()
    errors: list[str] = []
    statuses: Counter[str] = Counter()
    confidences: Counter[str] = Counter()

    for line_no, row in enumerate(rows, start=2):
        key = tuple(row.get(field, "") for field in KEY_FIELDS)
        if not all(key):
            errors.append(f"line {line_no}: incomplete key {key!r}")
        elif key in seen:
            errors.append(f"line {line_no}: duplicate key {key!r}")
        seen.add(key)

        status = row.get("status", "")
        confidence = row.get("confidence", "")
        if status not in ALLOWED_STATUSES:
            errors.append(f"line {line_no}: invalid status {status!r}")
        if confidence not in ALLOWED_CONFIDENCE:
            errors.append(f"line {line_no}: invalid confidence {confidence!r}")
        statuses[status] += 1
        confidences[confidence or "unset"] += 1

    print(f"ledger: {args.ledger}")
    print(f"rows: {len(rows)}")
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
