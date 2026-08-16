/* 0x06005e85 StardewValley.Menus.TutorialManager.drawUI @ 0x101e2103c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialManager_drawUI_06005e85(long param_1,undefined8 param_2)

{
  undefined8 uVar1;
  code *pcVar2;
  char cVar3;
  long lVar4;
  long *plVar5;
  
  cVar3 = cRam0000000103910c94;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103317910);
    cRam0000000103910c94 = '\x01';
    lVar4 = *(long *)(param_1 + 0x80);
  }
  else {
    lVar4 = *(long *)(param_1 + 0x80);
  }
  if ((lVar4 == 0) || (*(char *)(lVar4 + 0xb0) != '\0')) {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    if (*pcRam00000001038d59d8 == '\0') {
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      if ((*pcRam00000001038d53e0 == '\0') &&
         (((cVar3 = SDV_StardewValley_Menus_TutorialManager_shouldShowChallengeDialog_06005e8e
                              (param_1), cVar3 != '\0' &&
           (plVar5 = *(long **)(param_1 + 0xa0), plVar5 != (long *)0x0)) ||
          ((cVar3 = SDV_StardewValley_Menus_TutorialManager_shouldShowAttackDialog_06005e8d(param_1)
           , cVar3 != '\0' && (plVar5 = *(long **)(param_1 + 0x98), plVar5 != (long *)0x0)))))) {
        (**(code **)(*plVar5 + 0xa0))(plVar5,param_2);
        return;
      }
    }
    if (*(char *)(param_1 + 0xac) == '\0') {
      return;
    }
    lVar4 = *(long *)(param_1 + 0x90);
    if (lVar4 == 0) {
      return;
    }
    if (*(char *)(lVar4 + 0xb0) != '\0') {
      return;
    }
    SDV_StardewValley_Menus_TutorialItem_drawDialogueBox_06005e5b(lVar4,param_2);
    lVar4 = *(long *)(param_1 + 0x90);
    uVar1 = _UNK_1036a2dc8;
  }
  else {
    SDV_StardewValley_Menus_TutorialItem_drawDialogueBox_06005e5b(lVar4,param_2);
    lVar4 = *(long *)(param_1 + 0x80);
    uVar1 = _UNK_1036a2dd0;
  }
  if (lVar4 != 0) {
    SDV_StardewValley_Menus_TutorialItem_drawHandForUI_06005e5c(lVar4,param_2);
    return;
  }
  func_0x0001003316f4(0xee,uVar1);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e21190);
  (*pcVar2)();
}

