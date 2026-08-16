/* 0x06005daa StardewValley.Menus.CoopGameMenu.enterIPPressed @ 0x101df7708 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_enterIPPressed_06005daa(long *param_1)

{
  long lVar1;
  undefined8 uVar2;
  undefined8 uVar3;
  char cVar4;
  code *pcVar5;
  long *plVar6;
  undefined8 uVar7;
  long lVar8;
  undefined8 uVar9;
  
  cVar4 = cRam0000000103910bb9;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103316570);
    cRam0000000103910bb9 = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  plVar6 = (long *)*plRam00000001038d5338;
  if (plVar6 != (long *)0x0) {
    uVar7 = (**(code **)(*plVar6 + 0x100))(plVar6,uRam0000000103900188);
    if (param_1 != (long *)0x0) {
      lVar8 = func_0x000100331820(uRam00000001038e3aa0,0x80);
      lVar1 = lRam00000001038c4be0;
      DataMemoryBarrier(2,3);
      *(long *)(lVar8 + 0x20) = (long)param_1;
      *(undefined1 *)(((ulong)(lVar8 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
      uVar9 = uRam0000000103900198;
      lVar1 = lRam0000000103900190;
      uVar2 = uRam00000001038c4f58;
      *(long *)(lVar8 + 0x40) = lRam0000000103900190;
      uVar3 = uRam00000001039001a0;
      *(undefined8 *)(lVar8 + 0x28) = uVar9;
      *(undefined8 *)(lVar8 + 0x18) = *(undefined8 *)(lVar1 + 0x30);
      uVar9 = uRam00000001038ed808;
      *(undefined8 *)(lVar8 + 0x10) = *(undefined8 *)(lVar1 + 0x28);
      uVar9 = func_0x000100331820(uVar9,0xb0);
      StardewValley_StardewValley_Menus_TitleTextInputMenu__ctor_060065af
                (uVar9,uVar7,lVar8,uVar2,uVar3,1);
      StardewValley_StardewValley_Menus_IClickableMenu_initializeUpperRightCloseButton_06006182
                (uVar9);
      (**(code **)(*param_1 + 0x220))(param_1,uVar9);
      return;
    }
    func_0x0001003316f4(0x69,_UNK_10369cf38);
                    /* WARNING: Does not return */
    pcVar5 = (code *)SoftwareBreakpoint(1,0x101df788c);
    (*pcVar5)();
  }
  func_0x0001003316f4(0xee,_UNK_10369cf30);
                    /* WARNING: Does not return */
  pcVar5 = (code *)SoftwareBreakpoint(1,0x101df7878);
  (*pcVar5)();
}

