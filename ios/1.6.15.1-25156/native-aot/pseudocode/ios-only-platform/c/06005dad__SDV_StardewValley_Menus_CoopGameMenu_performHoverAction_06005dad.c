/* 0x06005dad StardewValley.Menus.CoopGameMenu.performHoverAction @ 0x101df7b94 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_performHoverAction_06005dad
               (long param_1,undefined4 param_2,undefined4 param_3)

{
  undefined8 uVar1;
  code *pcVar2;
  char cVar3;
  long *plVar4;
  undefined4 uVar5;
  
  if (lRam0000000103976fb8 == 0) {
    cVar3 = *(char *)(param_1 + 0x1b0);
  }
  else {
    func_0x00010119b8f8();
    cVar3 = *(char *)(param_1 + 0x1b0);
  }
  if (cVar3 != '\0') {
    plVar4 = *(long **)(param_1 + 0x180);
    uVar5 = 0;
    if (*(char *)((long)plVar4 + 0x4c) != '\0') {
      cVar3 = (**(code **)(*plVar4 + 0x90))(plVar4,param_2,param_3);
      plVar4 = *(long **)(param_1 + 0x180);
      uVar1 = _UNK_10369cf88;
      if (cVar3 != '\0') {
        uVar5 = 0x3f800000;
        uVar1 = _UNK_10369cf90;
      }
      if (plVar4 == (long *)0x0) {
        func_0x0001003316f4(0xee,uVar1);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101df7c64);
        (*pcVar2)();
      }
    }
    *(undefined4 *)(plVar4 + 9) = uVar5;
  }
  return;
}

