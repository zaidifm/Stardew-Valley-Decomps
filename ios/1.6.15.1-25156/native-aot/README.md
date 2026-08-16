# Stardew Valley iOS 1.6.15.1 (build 25156) native AOT recovery

Target IPA app version: **16.15.5**. Embedded `StardewValley.dll` version: **1.6.15.1 / build 25156**.

This corpus bridges the managed metadata in the IPA to the ARM64 Ahead-of-Time implementations in the decrypted Mach-O executable, then decompiles the mobile/iOS-specific subset with Ghidra 12.1.2.

## Coverage

- **422 high-level mobile-core methods**: 421 bounded second-pass methods plus the very large `TapToMove.OnTap` recovered separately.
- **410 high-level iOS-only/platform methods** not already represented by the mobile-core set.
- **832 high-level native pseudocode methods total**.
- **3 complete ARM64 disassembly fallbacks** for functions whose Ghidra high-level decompiler could not complete reliably:
  - `StardewValley.Mobile.TapToMove.EndNodeBlocked` (7,349 instructions; 457 recorded call refs)
  - `StardewValley.Menus.MobileCustomizer.draw` (3,576 instructions; 186 call refs)
  - `StardewValley.Menus.MobileFarmChooser.draw` (1,982 instructions; 105 call refs)

Thus the selected mobile/iOS-specific target set has native implementation coverage for all **835** directly mapped methods: **832 high-level pseudocode + 3 raw ARM64 fallbacks**.

## Full AOT mapping

The separately persisted full AOT map covers all 66 managed DLLs in the IPA. Across **77,932 MethodDefs**, **67,896** have exact ARM64 addresses. The mapping follows Mono AOT's `MonoAotFileInfo.method_addresses` and uses MethodDef row index minus one for ordinary methods.

## Important caveat

The `.c` files are Ghidra decompiler pseudocode, not original C# and not source emitted by the Xamarin/Mono toolchain. The companion managed DLL preserves class/method/field/signature metadata but most method bodies are AOT stubs. Use the managed metadata for names and types, the Linux 1.6.15.24356 decompile for shared-game semantic context, and these files for the actual iOS-native implementation.
