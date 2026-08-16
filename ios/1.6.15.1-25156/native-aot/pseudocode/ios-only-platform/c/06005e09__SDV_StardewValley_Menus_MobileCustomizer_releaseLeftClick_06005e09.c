/* 0x06005e09 StardewValley.Menus.MobileCustomizer.releaseLeftClick @ 0x101e0dd38 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer_releaseLeftClick_06005e09
               (long param_1,undefined4 param_2,undefined4 param_3)

{
  uint uVar1;
  code *pcVar2;
  char cVar3;
  undefined8 uVar4;
  long *plVar5;
  long lVar6;
  long lVar7;
  
  cVar3 = cRam0000000103910c18;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103910c18 != '\0') goto LAB_101e0dd70;
LAB_101e0dfb8:
    func_0x00010119b908(&UNK_103316f7f);
    cRam0000000103910c18 = '\x01';
    lVar6 = *(long *)(param_1 + 0x168);
  }
  else {
    func_0x00010119b8f8();
    if (cVar3 == '\0') goto LAB_101e0dfb8;
LAB_101e0dd70:
    lVar6 = *(long *)(param_1 + 0x168);
  }
  *(undefined8 *)(param_1 + 0x170) = 0;
  if (((lVar6 != 0) && (*(char *)(param_1 + 0x331) != '\0')) &&
     (cVar3 = StardewValley_StardewValley_Game1_get_IsMasterGame_06002ff6(), cVar3 != '\0')) {
    cVar3 = StardewValley_StardewValley_Game1_get_gameMode_06002fda();
    if ((cVar3 == '\x03') &&
       (lVar6 = StardewValley_StardewValley_Game1_get_locations_06002fa7(), lVar6 != 0)) {
      lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar4 = _UNK_1036a0208;
      if (lVar6 == 0) goto LAB_101e0dfdc;
      uVar4 = func_0x00010035d8d0();
      lVar6 = func_0x00010035d8e4(uVar4,0,0);
      if ((lVar6 != 0) &&
         (cVar3 = SDV_StardewValley_Menus_MobileCustomizer_petHasChanges_06005e08(lVar6,lVar6),
         cVar3 != '\0')) {
        lVar7 = *(long *)(lVar6 + 0x438);
        lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar4 = _UNK_1036a0210;
        if ((lVar6 == 0) || (uVar4 = _UNK_1036a0218, lVar7 == 0)) goto LAB_101e0dfdc;
        func_0x000100354118(lVar7,*(undefined8 *)(lVar6 + 0x328));
      }
    }
    *(undefined1 *)(param_1 + 0x331) = 0;
  }
  switch(*(undefined4 *)(param_1 + 500)) {
  case 0:
    lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar4 = _UNK_1036a01f8;
    if (lVar6 == 0) goto LAB_101e0dfdc;
    StardewValley_StardewValley_Farmer_changeSkinColor_06003663
              (lVar6,*(undefined4 *)(param_1 + 0x324),0);
    break;
  case 2:
    if (-1 < *(int *)(param_1 + 0x328)) {
      lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      lVar7 = SDV_StardewValley_Menus_MobileCustomizer_GetValidShirtIds_06005e18(param_1);
      uVar4 = _UNK_1036a01e0;
      if (lVar7 == 0) goto LAB_101e0dfdc;
      uVar1 = *(uint *)(param_1 + 0x328);
      if (*(uint *)(lVar7 + 0x18) <= uVar1) {
        func_0x000100331b90();
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101e0e044);
        (*pcVar2)();
      }
      if (*(uint *)(*(long *)(lVar7 + 0x10) + 0x18) <= uVar1) {
        func_0x0001003316f4(0xcc,_UNK_1036a0220);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101e0e064);
        (*pcVar2)();
      }
      uVar4 = _UNK_1036a01f0;
      if (lVar6 == 0) goto LAB_101e0dfdc;
      StardewValley_StardewValley_Farmer_changeShirt_06003653
                (lVar6,*(undefined8 *)(*(long *)(lVar7 + 0x10) + (long)(int)uVar1 * 8 + 0x20));
    }
    break;
  case 5:
    lVar6 = *(long *)(param_1 + 0x138);
    uVar4 = _UNK_1036a0200;
    goto joined_r0x000101e0ded0;
  case 6:
    if (*(int *)(param_1 + 0x1ec) == 6) {
      lVar6 = *(long *)(param_1 + 0x148);
      uVar4 = _UNK_1036a01d0;
      goto joined_r0x000101e0ded0;
    }
    break;
  case 7:
    lVar6 = *(long *)(param_1 + 0x140);
    uVar4 = _UNK_1036a01d8;
joined_r0x000101e0ded0:
    if (lVar6 == 0) goto LAB_101e0dfdc;
    (**(code **)(lVar6 + 0x18))();
  }
  cVar3 = SDV_StardewValley_Menus_MobileCustomizer_get_InTutorial_06005dfc();
  if ((cVar3 == '\0') && (*(char *)(param_1 + 0x332) != '\0')) {
    plVar5 = *(long **)(param_1 + 0x1a0);
    *(undefined1 *)(param_1 + 0x332) = 0;
    if (plVar5 != (long *)0x0) {
      (**(code **)(*plVar5 + 0xf8))(plVar5,param_2,param_3);
    }
    SDV_StardewValley_Menus_MobileCustomizer_resetAllButtons_06005e06(param_1);
    *(undefined1 *)(param_1 + 0x2fc) = 0;
    uVar4 = _UNK_1036a01a8;
    if (((*(long *)(param_1 + 0x70) == 0) ||
        (SDV_StardewValley_Menus_MobileColorPicker_releaseClick_06005df5(), uVar4 = _UNK_1036a01b0,
        *(long *)(param_1 + 0x68) == 0)) ||
       (SDV_StardewValley_Menus_MobileColorPicker_releaseClick_06005df5(), uVar4 = _UNK_1036a01b8,
       *(long *)(param_1 + 0x78) == 0)) {
LAB_101e0dfdc:
      func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101e0dfe8);
      (*pcVar2)();
    }
    SDV_StardewValley_Menus_MobileColorPicker_releaseClick_06005df5();
    *(undefined8 *)(param_1 + 0x128) = 0;
    cVar3 = (**(code **)(**(long **)(param_1 + 0xc0) + 0x90))
                      (*(long **)(param_1 + 0xc0),param_2,param_3);
    if ((cVar3 != '\0') &&
       (cVar3 = SDV_StardewValley_Menus_MobileCustomizer_canLeaveMenu_06005e12(param_1),
       cVar3 != '\0')) {
      StardewValley_StardewValley_Game1_playSound_0600301b(uRam00000001038d6930,0);
      SDV_StardewValley_Menus_MobileCustomizer_optionButtonClick_06005e0a
                (param_1,*(undefined8 *)(*(long *)(param_1 + 0xc0) + 0x10));
      *(undefined1 *)(param_1 + 0x1f8) = 0;
    }
  }
  return;
}

