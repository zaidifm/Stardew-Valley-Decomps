/* 0x06005e7e StardewValley.Menus.TutorialManager.releaseLeftClick @ 0x101e206f0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialManager_releaseLeftClick_06005e7e
               (long param_1,undefined4 param_2,undefined4 param_3)

{
  code *pcVar1;
  char cVar2;
  long *plVar3;
  
  cVar2 = cRam0000000103910c8d;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1033178a4);
    cRam0000000103910c8d = '\x01';
  }
  cVar2 = SDV_StardewValley_Menus_TutorialManager_shouldShowChallengeDialog_06005e8e(param_1);
  if ((cVar2 == '\0') || (*(long *)(param_1 + 0xa0) == 0)) {
    cVar2 = SDV_StardewValley_Menus_TutorialManager_shouldShowAttackDialog_06005e8d(param_1);
    if ((cVar2 != '\0') &&
       ((*(long *)(param_1 + 0x98) != 0 &&
        (cVar2 = SDV_StardewValley_Menus_TutorialManager_HandleAttackDialogueResponse_06005e78
                           (param_1), cVar2 != '\0')))) {
      (**(code **)(**(long **)(param_1 + 0x98) + 0xf8))(*(long **)(param_1 + 0x98),param_2,param_3);
      *(undefined8 *)(param_1 + 0x98) = 0;
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      plVar3 = (long *)*plRam00000001038d5338;
      if (plVar3 == (long *)0x0) {
        func_0x0001003316f4(0xee,_UNK_1036a2d60);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101e2086c);
        (*pcVar1)();
      }
      (**(code **)(*plVar3 + 0x100))(plVar3,uRam00000001039008a0);
      StardewValley_StardewValley_Game1_drawObjectDialogue_060030be();
    }
  }
  else {
    cVar2 = SDV_StardewValley_Menus_TutorialManager_HandleChallengeDialogueResponse_06005e7d
                      (param_1);
    if (cVar2 != '\0') {
      (**(code **)(**(long **)(param_1 + 0xa0) + 0xf8))(*(long **)(param_1 + 0xa0),param_2,param_3);
      StardewValley_StardewValley_Game1_ResetLinkedChallenge_06002f8d();
    }
  }
  return;
}

