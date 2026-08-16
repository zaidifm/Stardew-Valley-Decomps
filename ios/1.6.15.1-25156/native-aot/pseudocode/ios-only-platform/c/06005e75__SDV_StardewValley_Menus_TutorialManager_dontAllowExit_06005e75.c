/* 0x06005e75 StardewValley.Menus.TutorialManager.dontAllowExit @ 0x101e1f384 */

undefined8 SDV_StardewValley_Menus_TutorialManager_dontAllowExit_06005e75(long param_1)

{
  undefined8 uVar1;
  long lVar2;
  
  if (lRam0000000103976fb8 == 0) {
    lVar2 = *(long *)(param_1 + 0x90);
  }
  else {
    func_0x00010119b8f8();
    lVar2 = *(long *)(param_1 + 0x90);
  }
  if (lVar2 == 0) {
    uVar1 = 0;
  }
  else {
    uVar1 = 0;
    if (*(long *)(lVar2 + 0x90) != 0) {
      uVar1 = StardewValley_StardewValley_Menus_DialogueBox_isTransitioning_06006088();
    }
  }
  return uVar1;
}

