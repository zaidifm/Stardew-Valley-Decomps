/* 0x0600670a StardewValley.Mobile.TapToMoveUtils.isResourceClumpBoulderAt @ 0x101fce110 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_TapToMoveUtils_isResourceClumpBoulderAt_0600670a
          (long param_1,undefined4 param_2,undefined4 param_3)

{
  int iVar1;
  code *pcVar2;
  char cVar3;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (param_1 != 0) {
    cVar3 = func_0x000101a983a0(param_1,param_2,param_3);
    if (cVar3 != '\0') {
      iVar1 = *(int *)(*(long *)(param_1 + 0x48) + 0x68);
      if ((((iVar1 - 0x2f0U < 7) && ((1 << (ulong)(iVar1 - 0x2f0U & 0x1f) & 0x55U) != 0)) ||
          (iVar1 == 0x2a0)) || (iVar1 == 0x26e)) {
        return 1;
      }
    }
    return 0;
  }
  func_0x0001003316f4(0xee,_UNK_1036d7d98);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fce1d0);
  (*pcVar2)();
}

