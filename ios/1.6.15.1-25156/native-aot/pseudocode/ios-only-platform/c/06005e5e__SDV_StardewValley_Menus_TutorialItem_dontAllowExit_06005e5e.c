/* 0x06005e5e StardewValley.Menus.TutorialItem.dontAllowExit @ 0x101e1dd5c */

void SDV_StardewValley_Menus_TutorialItem_dontAllowExit_06005e5e(long param_1)

{
  long lVar1;
  
  if (lRam0000000103976fb8 == 0) {
    lVar1 = *(long *)(param_1 + 0x90);
  }
  else {
    func_0x00010119b8f8();
    lVar1 = *(long *)(param_1 + 0x90);
  }
  if (lVar1 != 0) {
    StardewValley_StardewValley_Menus_DialogueBox_isTransitioning_06006088();
  }
  return;
}

