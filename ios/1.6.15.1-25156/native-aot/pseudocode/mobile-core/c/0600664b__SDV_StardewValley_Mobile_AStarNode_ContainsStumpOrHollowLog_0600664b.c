/* 0x0600664b StardewValley.Mobile.AStarNode.ContainsStumpOrHollowLog @ 0x101fab6dc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Mobile_AStarNode_ContainsStumpOrHollowLog_0600664b(long param_1)

{
  uint uVar1;
  code *pcVar2;
  char cVar3;
  undefined8 uVar4;
  long lVar5;
  uint uVar6;
  long lVar7;
  
  if (lRam0000000103976fb8 == 0) {
    lVar5 = *(long *)(param_1 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    lVar5 = *(long *)(param_1 + 0x18);
  }
  uVar4 = _UNK_1036d2fe8;
  if (lVar5 != 0) {
    uVar6 = 0xffffffff;
    lVar7 = 0x20;
    do {
      while( true ) {
        lVar5 = *(long *)(*(long *)(*(long *)(lVar5 + 0x10) + 0x100) + 0x58);
        uVar1 = *(uint *)(lVar5 + 0x18);
        if ((int)uVar1 <= (int)(uVar6 + 1)) {
          return 0;
        }
        if (uVar1 <= uVar6 + 1) {
          func_0x000100331b90();
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101fab820);
          (*pcVar2)();
        }
        lVar5 = *(long *)(lVar5 + 0x10);
        uVar6 = uVar6 + 1;
        if (*(uint *)(lVar5 + 0x18) <= uVar6) {
          func_0x0001003316f4(0xcc,_UNK_1036d2ff8);
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101fab834);
          (*pcVar2)();
        }
        lVar5 = *(long *)(lVar7 + lVar5);
        uVar4 = _UNK_1036d2fe0;
        if (lVar5 == 0) goto LAB_101fab83c;
        cVar3 = func_0x000101a983a0(lVar5,*(undefined4 *)(param_1 + 0x34),
                                    *(undefined4 *)(param_1 + 0x38));
        if ((cVar3 != '\0') && ((*(uint *)(*(long *)(lVar5 + 0x48) + 0x68) | 2) == 0x25a)) {
          return 1;
        }
        lVar5 = *(long *)(param_1 + 0x18);
        if (lRam0000000103976fb8 != 0) break;
        lVar7 = lVar7 + 8;
        uVar4 = _UNK_1036d2fe8;
        if (lVar5 == 0) goto LAB_101fab83c;
      }
      func_0x00010119b8f8();
      lVar7 = lVar7 + 8;
      uVar4 = _UNK_1036d2fe8;
    } while (lVar5 != 0);
  }
LAB_101fab83c:
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fab848);
  (*pcVar2)();
}

