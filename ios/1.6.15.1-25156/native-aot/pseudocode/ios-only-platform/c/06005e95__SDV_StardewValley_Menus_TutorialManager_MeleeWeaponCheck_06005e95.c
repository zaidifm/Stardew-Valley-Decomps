/* 0x06005e95 StardewValley.Menus.TutorialManager.MeleeWeaponCheck @ 0x101e23a14 */

void SDV_StardewValley_Menus_TutorialManager_MeleeWeaponCheck_06005e95(long param_1)

{
  int iVar1;
  
  if (lRam0000000103976fb8 == 0) {
    iVar1 = *(int *)(param_1 + 0xbc);
  }
  else {
    func_0x00010119b8f8();
    iVar1 = *(int *)(param_1 + 0xbc);
  }
  if (iVar1 < 1) {
    SDV_StardewValley_Menus_TutorialManager_completeTutorial_06005e74(param_1,0xe);
    iVar1 = *(int *)(param_1 + 0xbc);
  }
  if ((iVar1 < 8) && (*(int *)(param_1 + 0xbc) = iVar1 + 1, iVar1 + 1 == 8)) {
    SDV_StardewValley_Menus_TutorialManager_completeTutorial_06005e74(param_1,0xf);
  }
  return;
}

