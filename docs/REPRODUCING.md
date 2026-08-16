# Reproducing the recovery

This repository does not redistribute original Stardew Valley binaries or content. Reproduction therefore starts from a locally owned installation/package matching the documented version and hashes.

## Linux

Use a matching Linux/Steam Stardew Valley installation. The recovery tools under `linux/1.6.15.24356/tools/` expect access to the shipped managed assemblies and their dependency directory. The checked-in `manifests/` files document the original inputs and recovered metadata.

## iOS

Use a matching decrypted IPA/app package for app version `16.15.5` whose embedded `StardewValley.dll` identifies as `1.6.15.1` build `25156`. The managed metadata indexes, Mono AOT maps, and Ghidra scripts are checked in; the IPA and Mach-O executable are not.

The iOS high-level `.c` files are Ghidra pseudocode, not original C# source. Managed metadata should be used for names/types/signatures and the native output for implementation behavior.
