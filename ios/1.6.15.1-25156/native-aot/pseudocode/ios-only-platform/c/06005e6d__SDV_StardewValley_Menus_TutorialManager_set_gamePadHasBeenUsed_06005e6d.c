/* 0x06005e6d StardewValley.Menus.TutorialManager.set_gamePadHasBeenUsed @ 0x101e1ea64 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialManager_set_gamePadHasBeenUsed_06005e6d
               (long param_1,byte param_2)

{
  code *pcVar1;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (param_1 == 0) {
    func_0x0001003316f4(0xee,_UNK_1036a2b20);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1ead8);
    (*pcVar1)();
  }
  if (((param_2 & 1) != 0) && (*(char *)(param_1 + 0xce) == '\0')) {
    SDV_StardewValley_Menus_TutorialManager_completeAllTutorials_06005e72(param_1);
    SDV_StardewValley_Menus_TutorialManager_showTutorials_06005e68(param_1,0);
  }
  *(byte *)(param_1 + 0xce) = param_2;
  return;
}

