/* 0x060066f4 StardewValley.Mobile.TapToMoveUtils.TreeGrowthStage @ 0x101fcc95c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined4 SDV_StardewValley_Mobile_TapToMoveUtils_TreeGrowthStage_060066f4(int param_1,int param_2)

{
  char cVar1;
  code *pcVar2;
  undefined4 uVar3;
  long lVar4;
  undefined8 uVar5;
  long *plVar6;
  long *plStack_38;
  
  cVar1 = cRam0000000103911503;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103325a03);
    cRam0000000103911503 = '\x01';
  }
  plStack_38 = (long *)0x0;
  lVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  uVar5 = _UNK_1036d7b48;
  if (*(long *)(lVar4 + 0x120) == 0) goto LAB_101fcca90;
  func_0x0001003554a0((float)param_1,(float)param_2,*(long *)(lVar4 + 0x120),&plStack_38);
  if (plStack_38 == (long *)0x0) {
LAB_101fcc9e8:
    uVar3 = 0;
  }
  else {
    plVar6 = (long *)*plStack_38;
    if (lRam00000001038c89f8 == plVar6[3]) {
      uVar5 = _UNK_1036d7b60;
      if (lRam00000001038c7998 != *(long *)(*(long *)(*plVar6 + 0x10) + 0x10)) {
LAB_101fccab0:
        func_0x0001003316f4(0xd3,uVar5);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101fccabc);
        (*pcVar2)();
      }
      lVar4 = plStack_38[9];
      uVar5 = _UNK_1036d7b68;
    }
    else {
      if (lRam00000001038c8a38 != plVar6[3]) goto LAB_101fcc9e8;
      uVar5 = _UNK_1036d7b50;
      if (lRam00000001038c7910 != *(long *)(*(long *)(*plVar6 + 0x10) + 0x10)) goto LAB_101fccab0;
      lVar4 = plStack_38[9];
      uVar5 = _UNK_1036d7b58;
    }
    if (lVar4 == 0) {
LAB_101fcca90:
      func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101fcca9c);
      (*pcVar2)();
    }
    uVar3 = *(undefined4 *)(lVar4 + 0x68);
  }
  return uVar3;
}

