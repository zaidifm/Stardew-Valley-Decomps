/* 0x06005e30 StardewValley.Menus.MobileScrollbar.downArrowContains @ 0x101e1b8e4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Menus_MobileScrollbar_downArrowContains_06005e30
               (long param_1,int param_2,int param_3)

{
  int iVar1;
  code *pcVar2;
  undefined8 uVar3;
  long lVar4;
  
  if (*(char *)(param_1 + 0x74) != '\0') {
    lVar4 = *(long *)(param_1 + 0x18);
    uVar3 = _UNK_1036a26a8;
    if ((lVar4 == 0) || (uVar3 = _UNK_1036a26b0, (int *)(lVar4 + 0x38) == (int *)0x0)) {
      func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101e1b988);
      (*pcVar2)();
    }
    iVar1 = *(int *)(lVar4 + 0x38);
    if ((iVar1 - *(int *)(param_1 + 0x6c) <= param_2) &&
       ((param_2 <= *(int *)(lVar4 + 0x40) + iVar1 + *(int *)(param_1 + 0x70) &&
        (*(int *)(lVar4 + 0x3c) <= param_3)))) {
      return param_3 <= *(int *)(lVar4 + 0x44) + *(int *)(lVar4 + 0x3c);
    }
  }
  return false;
}

