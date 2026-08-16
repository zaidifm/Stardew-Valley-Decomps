/* 0x06005e5b StardewValley.Menus.TutorialItem.drawDialogueBox @ 0x101e1d7b0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialItem_drawDialogueBox_06005e5b(long param_1,undefined8 param_2)

{
  char cVar1;
  code *pcVar2;
  int iVar3;
  long lVar4;
  undefined8 uVar5;
  int iVar6;
  long lVar7;
  float fVar8;
  
  cVar1 = cRam0000000103910c6a;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103317650);
    cRam0000000103910c6a = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  if (*pcRam00000001038d53e0 != '\0') {
    return;
  }
  if (*(long *)(param_1 + 0x90) == 0) {
    return;
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  if (((*(int *)(lRam00000001038d6278 + 8) < 0x500) || (*plRam00000001038e4ba8 == 0)) ||
     (lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec(),
     *(char *)(lVar4 + 0x168) == '\0')) {
LAB_101e1d8c0:
    lVar4 = *(long *)(param_1 + 0x90);
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    iVar3 = *(int *)(lRam00000001038d6278 + 8);
    fVar8 = (float)StardewValley_StardewValley_Game1_get_NativeZoomLevel_06002f79();
    uVar5 = _UNK_1036a2988;
    if (lVar4 == 0) goto LAB_101e1dae4;
    iVar6 = *piRam00000001038d57b0;
    iVar3 = (int)((float)iVar3 / fVar8) + -0x40;
  }
  else {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    if (*pcRam00000001038d5390 == '\0') goto LAB_101e1d8c0;
    lVar4 = *(long *)(param_1 + 0x90);
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    iVar3 = *(int *)(lRam00000001038d6278 + 8);
    fVar8 = (float)StardewValley_StardewValley_Game1_get_NativeZoomLevel_06002f79();
    uVar5 = _UNK_1036a29e8;
    if ((*plRam00000001038e4ba8 == 0) || (uVar5 = _UNK_1036a29f0, lVar4 == 0)) goto LAB_101e1dae4;
    iVar6 = *(int *)(*plRam00000001038e4ba8 + 0xa8);
    if (iVar6 < 2) {
      iVar6 = 1;
    }
    iVar6 = iVar6 + *piRam00000001038d57b8;
    iVar3 = (int)((float)iVar3 / fVar8) + -0x38;
  }
  *(int *)(lVar4 + 0x58) = iVar3 + iVar6 * -2;
  lVar7 = *(long *)(param_1 + 0x90);
  lVar4 = *(long *)(lVar7 + 0xa0);
  if ((lVar4 != 0) && (*(int *)(lVar4 + 0x10) != 0)) {
    iVar3 = StardewValley_StardewValley_BellsAndWhistles_SpriteText_getHeightOfString_06005d2b
                      (lVar4,*(int *)(lVar7 + 0x58) + -0x18);
    *(int *)(lVar7 + 0x5c) = iVar3 + 0x18;
    lVar7 = *(long *)(param_1 + 0x90);
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar5 = _UNK_1036a29a0;
  if ((((lRam00000001038d6bc0 != -8) && (uVar5 = _UNK_1036a2998, lRam00000001038d6bc0 != 0)) &&
      (uVar5 = _UNK_1036a29a8, *(long *)(param_1 + 0x90) != 0)) &&
     (uVar5 = _UNK_1036a29b0, lVar7 != 0)) {
    iVar3 = *(int *)(lRam00000001038d6bc0 + 8) - *(int *)(*(long *)(param_1 + 0x90) + 0x58);
    if (iVar3 < 0) {
      iVar3 = iVar3 + 1;
    }
    *(int *)(lVar7 + 0xcc) = iVar3 >> 1;
    uVar5 = _UNK_1036a29b8;
    if (((lRam00000001038d6bc0 != 0) && (uVar5 = _UNK_1036a29c0, lRam00000001038d6bc0 != -8)) &&
       (lVar4 = *(long *)(param_1 + 0x90), uVar5 = _UNK_1036a29c8, lVar4 != 0)) {
      *(int *)(lVar4 + 0xd0) =
           (*(int *)(lRam00000001038d6bc0 + 0xc) - *(int *)(lVar4 + 0x5c)) + -0x20;
      (**(code **)(**(long **)(param_1 + 0x90) + 0xa0))(*(long **)(param_1 + 0x90),param_2);
      return;
    }
  }
LAB_101e1dae4:
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e1daf0);
  (*pcVar2)();
}

