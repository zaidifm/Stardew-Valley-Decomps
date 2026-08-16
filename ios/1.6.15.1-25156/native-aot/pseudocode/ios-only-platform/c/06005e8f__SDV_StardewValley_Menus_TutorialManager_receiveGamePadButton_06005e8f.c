/* 0x06005e8f StardewValley.Menus.TutorialManager.receiveGamePadButton @ 0x101e22e9c */

void SDV_StardewValley_Menus_TutorialManager_receiveGamePadButton_06005e8f(long param_1,int param_2)

{
  char cVar1;
  long *plVar2;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  cVar1 = SDV_StardewValley_Menus_TutorialManager_shouldShowChallengeDialog_06005e8e(param_1);
  if ((cVar1 == '\0') || (plVar2 = *(long **)(param_1 + 0xa0), plVar2 == (long *)0x0)) {
    cVar1 = SDV_StardewValley_Menus_TutorialManager_shouldShowAttackDialog_06005e8d(param_1);
    if ((cVar1 != '\0') &&
       ((plVar2 = *(long **)(param_1 + 0x98), plVar2 != (long *)0x0 &&
        ((**(code **)(*plVar2 + 400))(plVar2,param_2), param_2 == 0x1000)))) {
      SDV_StardewValley_Menus_TutorialManager_HandleAttackDialogueResponse_06005e78(param_1);
    }
  }
  else {
    (**(code **)(*plVar2 + 400))(plVar2,param_2);
    if (param_2 == 0x1000) {
      SDV_StardewValley_Menus_TutorialManager_HandleChallengeDialogueResponse_06005e7d(param_1);
    }
  }
  return;
}

