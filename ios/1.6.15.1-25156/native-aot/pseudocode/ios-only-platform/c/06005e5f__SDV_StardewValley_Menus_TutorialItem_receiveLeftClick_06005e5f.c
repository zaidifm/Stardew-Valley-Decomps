/* 0x06005e5f StardewValley.Menus.TutorialItem.receiveLeftClick @ 0x101e1ddb0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialItem_receiveLeftClick_06005e5f(long param_1)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined8 uVar4;
  
  cVar2 = cRam0000000103910c6e;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103910c6e != '\0') goto LAB_101e1dddc;
LAB_101e1de64:
    func_0x00010119b908(&UNK_103317689);
    cRam0000000103910c6e = '\x01';
    lVar3 = *(long *)(param_1 + 0x90);
  }
  else {
    func_0x00010119b8f8();
    if (cVar2 == '\0') goto LAB_101e1de64;
LAB_101e1dddc:
    lVar3 = *(long *)(param_1 + 0x90);
  }
  if ((lVar3 == 0) ||
     (cVar2 = StardewValley_StardewValley_Menus_DialogueBox_hasFinishedTyping_0600607f(),
     cVar2 != '\0')) {
    if (500.0 < *(float *)(param_1 + 0xd8)) {
      if (*(char *)(param_1 + 0xb3) != '\0') {
        lVar3 = SDV_StardewValley_Menus_TutorialManager_get_Instance_06005e62();
        uVar4 = _UNK_1036a2a30;
        if (lVar3 == 0) goto LAB_101e1dea8;
        SDV_StardewValley_Menus_TutorialManager_completeTutorial_06005e74
                  (lVar3,*(undefined4 *)(param_1 + 0xcc));
      }
      *(undefined8 *)(param_1 + 0x90) = 0;
      if (*(char *)(lRam0000000103900780 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      *puRam0000000103900788 = 0;
    }
  }
  else {
    uVar4 = _UNK_1036a2a38;
    if (*(long *)(param_1 + 0x90) == 0) {
LAB_101e1dea8:
      func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1deb4);
      (*pcVar1)();
    }
    StardewValley_StardewValley_Menus_DialogueBox_finishTyping_0600607e();
  }
  return;
}

