/* 0x06005dab StardewValley.Menus.CoopGameMenu.enterInviteCodePressed @ 0x101df788c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_enterInviteCodePressed_06005dab(long *param_1)

{
  undefined8 uVar1;
  code *pcVar2;
  char cVar3;
  long *plVar4;
  long lVar5;
  undefined8 uVar6;
  long lVar7;
  undefined8 uVar8;
  
  cVar3 = cRam0000000103910bba;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103910bba != '\0') goto LAB_101df78bc;
LAB_101df7a0c:
    func_0x00010119b908(&UNK_103316590);
    cRam0000000103910bba = '\x01';
    plVar4 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
  }
  else {
    func_0x00010119b8f8();
    if (cVar3 == '\0') goto LAB_101df7a0c;
LAB_101df78bc:
    plVar4 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
  }
  uVar6 = _UNK_10369cf40;
  if (plVar4 == (long *)0x0) {
LAB_101df7a5c:
    func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x101df7a68);
    (*pcVar2)();
  }
  lVar5 = (**(code **)(*plVar4 + -0x38))();
  if (lVar5 != 0) {
    plVar4 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
    plVar4 = (long *)(**(code **)(*plVar4 + -0x38))();
    uVar6 = _UNK_10369cf50;
    if (plVar4 == (long *)0x0) goto LAB_101df7a5c;
    cVar3 = (**(code **)(*plVar4 + -0x58))();
    if (cVar3 != '\0') {
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      plVar4 = (long *)*plRam00000001038d5338;
      uVar6 = _UNK_10369cf58;
      if (plVar4 == (long *)0x0) goto LAB_101df7a5c;
      uVar6 = (**(code **)(*plVar4 + 0x100))(plVar4,uRam00000001039001a8);
      if (param_1 == (long *)0x0) {
        func_0x0001003316f4(0x69,_UNK_10369cf60);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101df7a7c);
        (*pcVar2)();
      }
      lVar7 = func_0x000100331820(uRam00000001038e3aa0,0x80);
      lVar5 = lRam00000001038c4be0;
      DataMemoryBarrier(2,3);
      *(long *)(lVar7 + 0x20) = (long)param_1;
      *(undefined1 *)(((ulong)(lVar7 + 0x20) >> 9 & 0x7fffff) + lVar5) = 1;
      uVar8 = uRam00000001039001b8;
      lVar5 = lRam00000001039001b0;
      uVar1 = uRam00000001038c4f58;
      *(long *)(lVar7 + 0x40) = lRam00000001039001b0;
      *(undefined8 *)(lVar7 + 0x28) = uVar8;
      *(undefined8 *)(lVar7 + 0x18) = *(undefined8 *)(lVar5 + 0x30);
      uVar8 = uRam00000001038ed808;
      *(undefined8 *)(lVar7 + 0x10) = *(undefined8 *)(lVar5 + 0x28);
      uVar8 = func_0x000100331820(uVar8,0xb0);
      StardewValley_StardewValley_Menus_TitleTextInputMenu__ctor_060065af
                (uVar8,uVar6,lVar7,uVar1,uVar1,1);
      (**(code **)(*param_1 + 0x220))(param_1,uVar8);
    }
  }
  return;
}

