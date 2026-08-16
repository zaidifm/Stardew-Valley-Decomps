/* 0x06005db5 StardewValley.Menus.CoopGameMenu.<enterInviteCodePressed>b__39_0 @ 0x101df85c0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu__enterInviteCodePressed_b__39_0_06005db5
               (long *param_1,undefined8 param_2)

{
  char cVar1;
  code *pcVar2;
  long *plVar3;
  long lVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  
  cVar1 = cRam0000000103910bc4;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103910bc4 != '\0') goto LAB_101df85f0;
LAB_101df86a8:
    func_0x00010119b908(&UNK_103316640);
    cRam0000000103910bc4 = '\x01';
    plVar3 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
  }
  else {
    func_0x00010119b8f8();
    if (cVar1 == '\0') goto LAB_101df86a8;
LAB_101df85f0:
    plVar3 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
  }
  uVar5 = _UNK_10369d088;
  if ((plVar3 != (long *)0x0) &&
     (plVar3 = (long *)(**(code **)(*plVar3 + -0x38))(), uVar5 = _UNK_10369d090,
     plVar3 != (long *)0x0)) {
    lVar4 = (**(code **)(*plVar3 + -0x78))(plVar3,param_2);
    if (lVar4 != 0) {
      plVar3 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
      plVar3 = (long *)(**(code **)(*plVar3 + -0x38))();
      uVar5 = _UNK_10369d0a0;
      if (plVar3 == (long *)0x0) goto LAB_101df86fc;
      uVar5 = (**(code **)(*plVar3 + -0x50))(plVar3,lVar4);
      uVar6 = func_0x000100331870(uRam00000001039001f0);
      StardewValley_StardewValley_Menus_FarmhandMenu__ctor_060060f2(uVar6,uVar5);
      (**(code **)(*param_1 + 0x220))(param_1,uVar6);
    }
    return;
  }
LAB_101df86fc:
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101df8708);
  (*pcVar2)();
}

