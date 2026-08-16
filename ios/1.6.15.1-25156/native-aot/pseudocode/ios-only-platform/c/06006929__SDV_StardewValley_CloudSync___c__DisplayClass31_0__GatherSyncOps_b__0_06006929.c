/* 0x06006929 StardewValley.CloudSync+<>c__DisplayClass31_0.<GatherSyncOps>b__0 @ 0x101feff04 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync___c__DisplayClass31_0__GatherSyncOps_b__0_06006929
               (long param_1,long param_2)

{
  code *pcVar1;
  undefined8 uVar2;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar2 = _UNK_1036dbbc8;
  if ((param_2 != 0) && (uVar2 = _UNK_1036dbbd8, *(long *)(param_1 + 0x10) != 0)) {
    func_0x000100345aa0(*(undefined8 *)(param_2 + 0x18),
                        *(undefined8 *)(*(long *)(param_1 + 0x10) + 0x18));
    return;
  }
  func_0x0001003316f4(0xee,uVar2);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101feff7c);
  (*pcVar1)();
}

