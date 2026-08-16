# Methodology

## Linux

The Linux target is the Steam/Linux build `1.6.15.24356`. `Stardew Valley.dll` contains ordinary .NET IL, so source recovery uses ILSpy against the full local game directory for dependency resolution. Recovered C# is indexed independently from the source output so type/method/field provenance can be checked against compiled metadata.

## iOS

The iOS target is app version `16.15.5`, with embedded `StardewValley.dll` version `1.6.15.1` build `25156`. Managed assemblies retain class, method, field, property, signature, and token metadata, but ordinary method bodies are AOT stubs.

The native ARM64 implementation mapping is recovered from Mono AOT `MonoAotFileInfo.method_addresses` tables. For ordinary MethodDefs, the AOT method index is the MethodDef row index minus one; Apple mobile builds store linker-patchable ARM64 branch entries whose resolved targets are the native implementations.

Selected mobile/iOS-specific implementations are then labeled and decompiled with Ghidra. If Ghidra cannot produce high-level pseudocode reliably, complete ARM64 disassembly is retained as a fallback.
