/* 0x06005e3e StardewValley.Menus.MobileScrollbox.receiveScrollWheelAction @ 0x101e1c7e4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileScrollbox_receiveScrollWheelAction_06005e3e
               (long param_1,int param_2)

{
  int iVar1;
  int iVar2;
  code *pcVar3;
  int iVar4;
  
  if (lRam0000000103976fb8 == 0) {
    iVar4 = *(int *)(param_1 + 0x4c);
  }
  else {
    func_0x00010119b8f8();
    iVar4 = *(int *)(param_1 + 0x4c);
  }
  iVar1 = *(int *)(param_1 + 100);
  iVar4 = iVar4 + param_2;
  iVar2 = -iVar1;
  if (iVar4 <= iVar2) {
    iVar4 = -iVar1;
  }
  if (-1 < iVar4) {
    iVar4 = 0;
  }
  *(int *)(param_1 + 0x4c) = iVar4;
  if (*(long *)(param_1 + 0x10) != 0) {
    if (iVar1 == 0) {
      func_0x0001003316f4(0x95,_UNK_1036a27e0);
                    /* WARNING: Does not return */
      pcVar3 = (code *)SoftwareBreakpoint(1,0x101e1c89c);
      (*pcVar3)();
    }
    if ((iVar1 == 1) && (iVar4 * 100 == -0x80000000)) {
      func_0x0001003316f4(0x101,_UNK_1036a27e8);
                    /* WARNING: Does not return */
      pcVar3 = (code *)SoftwareBreakpoint(1,0x101e1c8b0);
      (*pcVar3)();
    }
    iVar1 = 0;
    if (iVar2 != 0) {
      iVar1 = (iVar4 * 100) / iVar2;
    }
    SDV_StardewValley_Menus_MobileScrollbar_setPercentage_06005e2d((float)iVar1);
  }
  return;
}

