/* 0x06005dfc StardewValley.Menus.MobileCustomizer.get_InTutorial @ 0x101e069d4 */

bool SDV_StardewValley_Menus_MobileCustomizer_get_InTutorial_06005dfc(void)

{
  long lVar1;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  lVar1 = SDV_StardewValley_Menus_TutorialManager_get_Instance_06005e62();
  if (*(long *)(lVar1 + 0x90) != 0) {
    return *(char *)(lVar1 + 0xac) != '\0';
  }
  return false;
}

