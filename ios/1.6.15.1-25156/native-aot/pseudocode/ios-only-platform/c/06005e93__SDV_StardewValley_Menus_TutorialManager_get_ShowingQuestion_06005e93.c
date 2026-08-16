/* 0x06005e93 StardewValley.Menus.TutorialManager.get_ShowingQuestion @ 0x101e2392c */

bool SDV_StardewValley_Menus_TutorialManager_get_ShowingQuestion_06005e93(long param_1)

{
  if ((*(int *)(param_1 + 0xa8) == 3) && (*(long *)(param_1 + 0xa0) != 0)) {
    return true;
  }
  if (*(char *)(param_1 + 0xcd) != '\0') {
    return *(long *)(param_1 + 0x98) != 0;
  }
  return false;
}

