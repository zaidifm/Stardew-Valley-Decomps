/* 0x06005db2 StardewValley.Menus.CoopGameMenu.Dispose @ 0x101df82c8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_Dispose_06005db2(long param_1,undefined4 param_2)

{
  char cVar1;
  code *pcVar2;
  long *plVar3;
  undefined8 uVar4;
  long lVar5;
  
  cVar1 = cRam0000000103910bc1;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103910bc1 == '\0') goto LAB_101df8378;
LAB_101df82f8:
    lVar5 = *(long *)(param_1 + 0x198);
  }
  else {
    func_0x00010119b8f8();
    if (cVar1 != '\0') goto LAB_101df82f8;
LAB_101df8378:
    func_0x00010119b908(&UNK_103316600);
    cRam0000000103910bc1 = '\x01';
    lVar5 = *(long *)(param_1 + 0x198);
  }
  if (lVar5 != 0) {
    plVar3 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
    uVar4 = _UNK_10369d060;
    if (plVar3 == (long *)0x0) {
LAB_101df83c0:
      func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101df83cc);
      (*pcVar2)();
    }
    lVar5 = (**(code **)(*plVar3 + -0x38))();
    if (lVar5 != 0) {
      plVar3 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
      plVar3 = (long *)(**(code **)(*plVar3 + -0x38))();
      uVar4 = _UNK_10369d070;
      if (plVar3 == (long *)0x0) goto LAB_101df83c0;
      (**(code **)(*plVar3 + -0x68))(plVar3,*(undefined8 *)(param_1 + 0x198));
    }
  }
  *(undefined8 *)(param_1 + 0x198) = 0;
  StardewValley_StardewValley_Menus_LoadGameMenu_Dispose_060062e9(param_1,param_2);
  return;
}

