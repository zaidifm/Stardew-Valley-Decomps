/* 0x06005e78 StardewValley.Menus.TutorialManager.HandleAttackDialogueResponse @ 0x101e1f718 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Menus_TutorialManager_HandleAttackDialogueResponse_06005e78(long param_1)

{
  int iVar1;
  int iVar2;
  char cVar3;
  code *pcVar4;
  long lVar5;
  undefined8 uVar6;
  undefined4 uVar7;
  
  cVar3 = cRam0000000103910c87;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_1033177c2);
    cRam0000000103910c87 = '\x01';
  }
  *puRam00000001038d6a30 = 0;
  iVar1 = *(int *)(*(long *)(param_1 + 0x98) + 0xf4);
  if (iVar1 == -1) {
    uVar6 = 0;
  }
  else {
    lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
    iVar2 = *(int *)(lVar5 + 0x178);
    lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
    uVar6 = _UNK_1036a2c28;
    if (lVar5 == 0) {
LAB_101e1f878:
      func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
      pcVar4 = (code *)SoftwareBreakpoint(1,0x101e1f884);
      (*pcVar4)();
    }
    uVar7 = 0;
    if (iVar1 != 0) {
      uVar7 = 6;
    }
    *(undefined4 *)(lVar5 + 0x178) = uVar7;
    lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
    if (*(int *)(lVar5 + 0x178) != iVar2) {
      lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
      if (*(int *)(lVar5 + 0x178) != 0) {
        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        lVar5 = *plRam00000001038d5360;
        uVar6 = _UNK_1036a2c40;
        if (lVar5 == 0) goto LAB_101e1f878;
        SDV_StardewValley_Mobile_VirtualJoypad_SetJoystickDefaults_0600673d(lVar5);
        SDV_StardewValley_Mobile_VirtualJoypad_SetButtonBDefaults_0600673f(lVar5);
        SDV_StardewValley_Mobile_VirtualJoypad_SetButtonADefaults_0600673e(lVar5);
        SDV_StardewValley_Mobile_VirtualJoypad_UpdateSettings_06006741(lVar5);
      }
      StardewValley_StardewValley_Menus_OptionsPage_SaveStartupPreferences_060063aa();
    }
    uVar6 = 1;
    *(undefined1 *)(param_1 + 0xcd) = 0;
  }
  return uVar6;
}

