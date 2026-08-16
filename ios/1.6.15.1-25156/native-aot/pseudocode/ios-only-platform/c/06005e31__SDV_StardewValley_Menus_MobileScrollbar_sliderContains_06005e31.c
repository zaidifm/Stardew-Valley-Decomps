/* 0x06005e31 StardewValley.Menus.MobileScrollbar.sliderContains @ 0x101e1b988 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Menus_MobileScrollbar_sliderContains_06005e31
               (long param_1,int param_2,int param_3)

{
  int iVar1;
  code *pcVar2;
  undefined8 uVar3;
  long lVar4;
  
  lVar4 = *(long *)(param_1 + 0x20);
  uVar3 = _UNK_1036a26c0;
  if ((lVar4 == 0) || (uVar3 = _UNK_1036a26c8, (int *)(lVar4 + 0x38) == (int *)0x0)) {
    func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x101e1ba24);
    (*pcVar2)();
  }
  iVar1 = *(int *)(lVar4 + 0x38);
  if ((iVar1 - *(int *)(param_1 + 0x6c) <= param_2) &&
     ((param_2 <= *(int *)(lVar4 + 0x40) + iVar1 + *(int *)(param_1 + 0x70) &&
      (*(int *)(lVar4 + 0x3c) <= param_3)))) {
    return param_3 <= *(int *)(lVar4 + 0x44) + *(int *)(lVar4 + 0x3c);
  }
  return false;
}

