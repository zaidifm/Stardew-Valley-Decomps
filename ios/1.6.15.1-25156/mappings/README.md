# Full managed-to-native map — Stardew Valley iOS 1.6.15.1 / build 25156

This checkpoint maps the managed MethodDef tables from all 66 DLLs in the IPA to Mono AOT ARM64 implementation addresses in the app Mach-O.

- 66 managed assemblies
- 67 Mono AOT module-info structures (the extra module is the AOT-instances container)
- 77,932 managed MethodDefs total
- 67,896 mapped native ARM64 implementations
- 10,036 entries without a direct ordinary method body in their assembly call table
- 0 managed assemblies missing a matching AOT module-info structure

The combined TSV includes assembly, MethodDef row/index, token, declaring type, method name, stub RVA, attributes, call-table entry, encoded ARM64 branch, initial branch target, resolved native address, status, and branch-island chain.

The mapping rule follows the embedded Mono runtime: ordinary managed methods use MethodDef row index minus one as the AOT method index; Apple mobile AOT stores a linker-patchable branch table in `method_addresses`.
