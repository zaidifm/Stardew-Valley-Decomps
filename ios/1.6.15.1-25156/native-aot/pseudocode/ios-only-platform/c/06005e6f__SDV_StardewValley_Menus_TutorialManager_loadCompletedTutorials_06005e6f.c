/* 0x06005e6f StardewValley.Menus.TutorialManager.loadCompletedTutorials @ 0x101e1eb48 */

/* WARNING: Removing unreachable block (ram,0x000101e1ed54) */
/* WARNING: Removing unreachable block (ram,0x000101e1ec20) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialManager_loadCompletedTutorials_06005e6f
               (long param_1,long param_2)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined8 uVar4;
  int iVar5;
  undefined8 uStack_68;
  undefined8 uStack_60;
  ulong uStack_58;
  undefined8 uStack_50;
  undefined8 *puStack_48;
  long lStack_40;
  long lStack_38;
  
  cVar2 = cRam0000000103910c7e;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103317750);
    cRam0000000103910c7e = '\x01';
  }
  uStack_68 = 0;
  uStack_60 = 0;
  uStack_58 = 0;
  SDV_StardewValley_Menus_TutorialManager_initializeStartTutorials_06005e88(param_1);
  SDV_StardewValley_Menus_TutorialManager_initializeTutorials_06005e89(param_1);
  if ((param_2 != 0) && (*(long *)(param_1 + 0x68) != 0)) {
    func_0x000100377fdc(&uStack_68,param_2);
    while (cVar2 = func_0x000100377ff0(&uStack_68), cVar2 != '\0') {
      lVar3 = SDV_StardewValley_Menus_TutorialManager_GetTutorial_06005e6b
                        (param_1,uStack_58 & 0xffffffff);
      if (lVar3 != 0) {
        SDV_StardewValley_Menus_TutorialItem_setComplete_06005e56();
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
    }
    uStack_50 = 0;
    puStack_48 = &uStack_68;
    if (puStack_48 == (undefined8 *)0x0) {
      func_0x0001003316f4(0xee,_UNK_1036a2b40);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1ed70);
      (*pcVar1)();
    }
  }
  lStack_40 = lRam00000001038c4c88;
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0(lRam00000001038c4c88);
  }
  if (*piRam00000001038d5780 < 3) {
    uVar4 = StardewValley_StardewValley_Game1_get_currentSeason_06002fc4();
    cVar2 = func_0x00010035011c(uVar4,uRam00000001038ec7b0);
    if (cVar2 == '\0') {
      lStack_38 = lRam00000001038c4c88;
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0(lRam00000001038c4c88);
      }
      if (*piRam00000001038d5b10 < 2) goto LAB_101e1ec90;
    }
  }
  iVar5 = 0;
  do {
    lVar3 = SDV_StardewValley_Menus_TutorialManager_GetTutorial_06005e6b(param_1,iVar5);
    if (lVar3 != 0) {
      SDV_StardewValley_Menus_TutorialItem_setComplete_06005e56();
    }
    if (lRam0000000103976fb8 != 0) {
      func_0x00010119b8f8();
    }
    iVar5 = iVar5 + 1;
  } while (iVar5 != 0x2d);
LAB_101e1ec90:
  cVar2 = SDV_StardewValley_Game1_isGamePadConnected_06002f76();
  if (cVar2 == '\0') {
    *(undefined1 *)(param_1 + 0xce) = 0;
  }
  else {
    SDV_StardewValley_Menus_TutorialManager_set_gamePadHasBeenUsed_06005e6d(param_1,1);
  }
  return;
}

