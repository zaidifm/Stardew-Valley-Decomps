/* 0x06005e8b StardewValley.Menus.TutorialManager.CheckTapAndHold @ 0x101e22b74 */

void SDV_StardewValley_Menus_TutorialManager_CheckTapAndHold_06005e8b(long param_1)

{
  char cVar1;
  undefined1 uVar2;
  long lVar3;
  
  if (lRam0000000103976fb8 == 0) {
    cVar1 = *(char *)(param_1 + 200);
  }
  else {
    func_0x00010119b8f8();
    cVar1 = *(char *)(param_1 + 200);
  }
  if (cVar1 != '\0') {
    uVar2 = 1;
    goto LAB_101e22bd4;
  }
  if (*(char *)(param_1 + 0xac) != '\0') {
    lVar3 = SDV_StardewValley_Menus_TutorialManager_GetTutorial_06005e6b(param_1,10);
    uVar2 = 0;
    if (lVar3 == 0) goto LAB_101e22bd4;
    if (*(char *)(lVar3 + 0xb1) != '\0') {
      uVar2 = SDV_StardewValley_Menus_TutorialManager_completeTutorial_06005e74(param_1,10);
      goto LAB_101e22bd4;
    }
  }
  uVar2 = 0;
LAB_101e22bd4:
  *(undefined1 *)(param_1 + 200) = uVar2;
  return;
}

