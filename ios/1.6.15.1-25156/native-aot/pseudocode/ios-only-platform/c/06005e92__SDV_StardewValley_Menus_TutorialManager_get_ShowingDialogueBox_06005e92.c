/* 0x06005e92 StardewValley.Menus.TutorialManager.get_ShowingDialogueBox @ 0x101e238d0 */

bool SDV_StardewValley_Menus_TutorialManager_get_ShowingDialogueBox_06005e92(long param_1)

{
  if ((*(long *)(param_1 + 0xa0) == 0) && (*(long *)(param_1 + 0x98) == 0)) {
    if (*(long *)(param_1 + 0x90) != 0) {
      return *(long *)(*(long *)(param_1 + 0x90) + 0x90) != 0;
    }
    return false;
  }
  return true;
}

