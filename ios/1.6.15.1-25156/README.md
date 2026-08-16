# Stardew Valley iOS 1.6.15.1 / build 25156

Target IPA metadata:

- App version: `16.15.5`
- Embedded `StardewValley.dll`: `1.6.15.1`, build `25156`
- Main executable: decrypted ARM64 Mach-O (`cryptid=0`)

The iOS build is AOT-compiled. Managed assemblies provide rich metadata but most ordinary method implementations are one-byte AOT stubs. This directory therefore separates:

- `managed-metadata/` — recovered managed class/method/field/signature skeletons and metadata indexes;
- `native-aot/` — Ghidra C-like pseudocode for named ARM64 implementations plus raw ARM64 fallbacks;
- `mappings/` — Mono AOT managed MethodDef → native ARM64 address maps;
- `scripts/` — reproducibility tooling used for mapping and Ghidra extraction.

Current selected native recovery covers 835 directly mapped mobile/iOS-specific methods: **832 high-level pseudocode methods and 3 complete ARM64 fallbacks**.
