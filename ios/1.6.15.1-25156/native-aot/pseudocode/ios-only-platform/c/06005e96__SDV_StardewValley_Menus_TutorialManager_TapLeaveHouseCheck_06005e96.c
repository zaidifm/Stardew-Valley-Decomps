/* 0x06005e96 StardewValley.Menus.TutorialManager.TapLeaveHouseCheck @ 0x101e23aa8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialManager_TapLeaveHouseCheck_06005e96(long param_1)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  undefined8 *puVar4;
  
  cVar1 = cRam0000000103910ca5;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103317b68);
    cRam0000000103910ca5 = '\x01';
    cVar1 = *(char *)(param_1 + 0xcb);
  }
  else {
    cVar1 = *(char *)(param_1 + 0xcb);
  }
  if (((cVar1 == '\0') &&
      (lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a(), lVar3 != 0)) &&
     (lVar3 = StardewValley_StardewValley_Character_get_currentLocation_0600326b(), lVar3 != 0)) {
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    if (lVar3 == 0) {
      func_0x0001003316f4(0xee,_UNK_1036a3140);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101e23b9c);
      (*pcVar2)();
    }
    puVar4 = (undefined8 *)StardewValley_StardewValley_Character_get_currentLocation_0600326b();
    if (((puVar4 == (undefined8 *)0x0) ||
        (lRam00000001038c6c50 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x18))) &&
       ((*(char *)(param_1 + 0xac) != '\0' &&
        ((lVar3 = SDV_StardewValley_Menus_TutorialManager_GetTutorial_06005e6b(param_1,2),
         lVar3 != 0 && (*(char *)(lVar3 + 0xb0) != '\0')))))) {
      *(undefined1 *)(param_1 + 0xcb) = 1;
      SDV_StardewValley_Menus_TutorialManager_completeTutorial_06005e74(param_1,6);
    }
  }
  return;
}

