/* 0x06005e7f StardewValley.Menus.TutorialManager.leftClickHeld @ 0x101e2086c */

void SDV_StardewValley_Menus_TutorialManager_leftClickHeld_06005e7f
               (long param_1,undefined4 param_2,undefined4 param_3)

{
  char cVar1;
  long *plVar2;
  
  cVar1 = cRam0000000103910c8e;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033178b3);
    cRam0000000103910c8e = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  if (*pcRam00000001038d59d8 == '\0') {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    if ((*pcRam00000001038d53e0 == '\0') &&
       (((cVar1 = SDV_StardewValley_Menus_TutorialManager_shouldShowChallengeDialog_06005e8e
                            (param_1), cVar1 != '\0' &&
         (plVar2 = *(long **)(param_1 + 0xa0), plVar2 != (long *)0x0)) ||
        ((cVar1 = SDV_StardewValley_Menus_TutorialManager_shouldShowAttackDialog_06005e8d(param_1),
         cVar1 != '\0' && (plVar2 = *(long **)(param_1 + 0x98), plVar2 != (long *)0x0)))))) {
      (**(code **)(*plVar2 + 0xf0))(plVar2,param_2,param_3);
    }
  }
  return;
}

