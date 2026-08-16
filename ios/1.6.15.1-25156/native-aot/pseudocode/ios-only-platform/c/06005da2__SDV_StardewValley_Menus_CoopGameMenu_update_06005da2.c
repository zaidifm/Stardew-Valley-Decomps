/* 0x06005da2 StardewValley.Menus.CoopGameMenu.update @ 0x101df6da8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_update_06005da2(long *param_1,long param_2)

{
  code *pcVar1;
  char cVar2;
  long *plVar3;
  int iVar4;
  double dVar5;
  
  cVar2 = cRam0000000103910bb1;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103316487);
    cRam0000000103910bb1 = '\x01';
    iVar4 = *(int *)((long)param_1 + 0x1b4);
  }
  else {
    iVar4 = *(int *)((long)param_1 + 0x1b4);
  }
  *(int *)((long)param_1 + 0x1b4) = iVar4 + 1;
  if ((char)param_1[0x36] == '\0') {
    plVar3 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
    if (plVar3 == (long *)0x0) {
      func_0x0001003316f4(0xee,_UNK_10369ce70);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101df6ec0);
      (*pcVar1)();
    }
    cVar2 = (**(code **)(*plVar3 + -0x48))();
    if ((cVar2 != '\0') &&
       (dVar5 = (double)param_1[0x37] + (double)*(long *)(param_2 + 0x18) / 10000000.0,
       param_1[0x37] = (long)dVar5, 2.0 <= dVar5)) {
      (**(code **)(*param_1 + 0x240))(param_1);
    }
  }
  else {
    StardewValley_StardewValley_Menus_LoadGameMenu_update_060062da(param_1,param_2);
  }
  return;
}

