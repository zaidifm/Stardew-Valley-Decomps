# Stardew Valley iOS 1.6.15.1 / build 25156 metadata decompilation

Source: `Stardew Valley_16.15.5_13.0_LeTi.ipa`.

Observed package metadata:
- CFBundleShortVersionString: 16.15.5
- CFBundleVersion: 0.8
- minimum iOS: 13.0
- embedded Stardew assembly: 1.6.15.1, build 25156
- target framework: .NET 8.0 / iOS 13+
- native executable: ARM64 Mach-O, cryptid=0 (decrypted)

## Critical limitation
The iOS managed assemblies are AOT/reference-style assemblies. Their metadata is rich, but ordinary managed method bodies have been replaced by one-byte `ret` stubs. Therefore the generated C# files recover types, names, signatures, fields, properties, constants, attributes, and structure, but NOT the real method implementations.

Real implementation code lives in the ARM64 AOT/native deployment and must be recovered/correlated using the Mach-O executable, `.aotdata.arm64`, Ghidra, and Mono/Xamarin AOT metadata.

## Probe results
- StardewValley.dll: 2,876 total types; 30,122 methods; 18,896 fields; 1,445 properties.
- 1,898 top-level types decompiled as metadata skeletons with zero decompiler failures.
- Main executable imports successfully in Ghidra 12.1.2 as `AARCH64:LE:64:AppleSilicon:default` using the Mac OS X Mach-O loader.
