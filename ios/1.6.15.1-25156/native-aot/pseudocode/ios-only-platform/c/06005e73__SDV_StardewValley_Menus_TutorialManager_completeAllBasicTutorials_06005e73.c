/* 0x06005e73 StardewValley.Menus.TutorialManager.completeAllBasicTutorials @ 0x101e1f14c */

void SDV_StardewValley_Menus_TutorialManager_completeAllBasicTutorials_06005e73(undefined8 param_1)

{
  long lVar1;
  int iVar2;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  iVar2 = 0;
  do {
    lVar1 = SDV_StardewValley_Menus_TutorialManager_GetTutorial_06005e6b(param_1,iVar2);
    if (lVar1 != 0) {
      SDV_StardewValley_Menus_TutorialItem_setComplete_06005e56();
    }
    if (lRam0000000103976fb8 != 0) {
      func_0x00010119b8f8();
    }
    iVar2 = iVar2 + 1;
  } while (iVar2 != 0x2d);
  return;
}

