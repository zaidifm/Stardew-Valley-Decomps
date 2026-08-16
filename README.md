# Stardew Valley Decomps

Reverse-engineering and decompilation corpus for Stardew Valley, currently covering a current Linux/Steam build and an iOS AOT build.

## Current targets

- **Linux / Steam:** Stardew Valley `1.6.15.24356` (`linux-x64`, .NET 6). The main game assembly is ordinary managed IL and is recovered as browsable C# with ILSpy.
- **iOS:** app version `16.15.5`, embedded Stardew assembly `1.6.15.1` build `25156`. The managed assemblies preserve names/types/signatures but most implementations are AOT stubs; native ARM64 implementations are mapped through Mono AOT metadata and selectively decompiled with Ghidra.

## Repository boundaries

This repository intentionally does **not** include original game distributions, IPAs, Steam depots, game DLLs, native libraries, XNB assets, maps, textures, music/audio banks, or other original game content. Those remain user-supplied inputs for reproduction and verification.

The checked-in material is organized by platform and exact build. Decompiled/recovered code is derived material for research and interoperability; Ghidra `.c` files are decompiler pseudocode, not original C or C# source.

## Layout

- `linux/1.6.15.24356/` — current Linux managed-code recovery, metadata indexes, and recovery reports.
- `ios/1.6.15.1-25156/` — iOS managed metadata skeletons, Mono AOT mappings, native pseudocode, ARM64 fallbacks, and recovery tooling.
- `docs/` — methodology and repository conventions.

## Purpose

The project exists to support technical investigation of Stardew Valley for research tooling, including save-state understanding, platform behavior, and experimental RL training gyms/harnesses.
