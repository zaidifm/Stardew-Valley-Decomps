/* 0x06005e80 StardewValley.Menus.TutorialManager.receiveLeftClick @ 0x101e20988 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialManager_receiveLeftClick_06005e80
               (long param_1,undefined4 param_2,undefined4 param_3,undefined4 param_4)

{
  code *pcVar1;
  char cVar2;
  long *plVar3;
  
  cVar2 = cRam0000000103910c8f;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1033178c1);
    cRam0000000103910c8f = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  if (*pcRam00000001038d59d8 == '\0') {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    if (*pcRam00000001038d53e0 != '\0') goto LAB_101e20a00;
    cVar2 = SDV_StardewValley_Menus_TutorialManager_shouldShowChallengeDialog_06005e8e(param_1);
    if ((cVar2 != '\0') && (plVar3 = *(long **)(param_1 + 0xa0), plVar3 != (long *)0x0))
    goto LAB_101e20a0c;
    cVar2 = SDV_StardewValley_Menus_TutorialManager_shouldShowAttackDialog_06005e8d(param_1);
    if (cVar2 == '\0') goto LAB_101e20a00;
    plVar3 = *(long **)(param_1 + 0x98);
    if (plVar3 != (long *)0x0) goto LAB_101e20a0c;
  }
  else {
LAB_101e20a00:
    if (param_1 == 0) {
      func_0x0001003316f4(0xee,_UNK_1036a2d88);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101e20ab0);
      (*pcVar1)();
    }
  }
  plVar3 = *(long **)(param_1 + 0x90);
  if (plVar3 == (long *)0x0) {
    return;
  }
LAB_101e20a0c:
  (**(code **)(*plVar3 + 0xe8))(plVar3,param_2,param_3,param_4);
  return;
}

