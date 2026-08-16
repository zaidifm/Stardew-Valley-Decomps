/* 0x060072c9 StardewValley.Menus.CoopGameMenu+HostNewFarmSlot.Activate @ 0x1020a6eac */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_HostNewFarmSlot_Activate_060072c9(void)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  undefined8 uVar4;
  
  cVar1 = cRam00000001039120d8;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_10332fc7a);
    cRam00000001039120d8 = '\x01';
    lVar3 = SDV_StardewValley_Menus_TutorialManager_get_Instance_06005e62();
  }
  else {
    lVar3 = SDV_StardewValley_Menus_TutorialManager_get_Instance_06005e62();
  }
  if (lVar3 == 0) {
    func_0x0001003316f4(0xee,_UNK_1036edb30);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x1020a6f50);
    (*pcVar2)();
  }
  SDV_StardewValley_Menus_TutorialManager_initializeStartTutorials_06005e88();
  StardewValley_StardewValley_Game1_resetPlayer_06003019();
  uVar4 = func_0x000100331820(uRam00000001038e9fd0,0xd8);
  StardewValley_StardewValley_Menus_CharacterCustomization__ctor_06005faf(uVar4,3,0,0);
  StardewValley_StardewValley_Menus_TitleMenu_set_subMenu_06006581(uVar4);
  return;
}

