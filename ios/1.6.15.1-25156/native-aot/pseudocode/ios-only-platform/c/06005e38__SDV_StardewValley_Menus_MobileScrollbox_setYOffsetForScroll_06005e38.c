/* 0x06005e38 StardewValley.Menus.MobileScrollbox.setYOffsetForScroll @ 0x101e1c08c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileScrollbox_setYOffsetForScroll_06005e38(long param_1,int param_2)

{
  int iVar1;
  int iVar2;
  code *pcVar3;
  long lVar4;
  
  if (lRam0000000103976fb8 == 0) {
    lVar4 = *(long *)(param_1 + 0x10);
  }
  else {
    func_0x00010119b8f8();
    lVar4 = *(long *)(param_1 + 0x10);
  }
  *(int *)(param_1 + 0x4c) = param_2;
  if (lVar4 != 0) {
    iVar1 = *(int *)(param_1 + 100);
    if (iVar1 == 0) {
      func_0x0001003316f4(0x95,_UNK_1036a2748);
                    /* WARNING: Does not return */
      pcVar3 = (code *)SoftwareBreakpoint(1,0x101e1c12c);
      (*pcVar3)();
    }
    if ((param_2 * 100 == -0x80000000) && (iVar1 == 1)) {
      func_0x0001003316f4(0x101,_UNK_1036a2750);
                    /* WARNING: Does not return */
      pcVar3 = (code *)SoftwareBreakpoint(1,0x101e1c140);
      (*pcVar3)();
    }
    iVar2 = 0;
    if (-iVar1 != 0) {
      iVar2 = (param_2 * 100) / -iVar1;
    }
    SDV_StardewValley_Menus_MobileScrollbar_setPercentage_06005e2d((float)iVar2);
  }
  return;
}

