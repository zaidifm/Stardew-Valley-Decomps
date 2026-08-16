/* 0x06006648 StardewValley.Mobile.AStarNode.ContainsGiantWeed @ 0x101fab1dc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Mobile_AStarNode_ContainsGiantWeed_06006648(long param_1)

{
  code *pcVar1;
  char cVar2;
  undefined8 uVar3;
  long lVar4;
  uint uVar5;
  long lVar6;
  long lVar7;
  
  if (lRam0000000103976fb8 == 0) {
    lVar4 = *(long *)(param_1 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    lVar4 = *(long *)(param_1 + 0x18);
  }
  lVar4 = *(long *)(*(long *)(lVar4 + 0x10) + 0x100);
  lVar7 = *(long *)(lVar4 + 0x58);
  uVar3 = _UNK_1036d2f18;
  if (lVar7 != 0) {
    uVar5 = 0;
    lVar6 = 0x20;
    do {
      if ((int)*(uint *)(lVar7 + 0x18) <= (int)uVar5) {
        return 0;
      }
      if (*(uint *)(lVar7 + 0x18) <= uVar5) {
LAB_101fab2e8:
        func_0x000100331b90();
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fab2f0);
        (*pcVar1)();
      }
      uVar3 = _UNK_1036d2f08;
      if (*(uint *)(*(long *)(lVar7 + 0x10) + 0x18) <= uVar5) {
LAB_101fab340:
        func_0x0001003316f4(0xcc,uVar3);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fab34c);
        (*pcVar1)();
      }
      lVar7 = *(long *)(lVar6 + *(long *)(lVar7 + 0x10));
      uVar3 = _UNK_1036d2f10;
      if (lVar7 == 0) break;
      cVar2 = func_0x000101a983a0(lVar7,*(undefined4 *)(param_1 + 0x34),
                                  *(undefined4 *)(param_1 + 0x38));
      if (cVar2 != '\0') {
        if (*(uint *)(*(long *)(lVar4 + 0x58) + 0x18) <= uVar5) goto LAB_101fab2e8;
        lVar7 = *(long *)(*(long *)(lVar4 + 0x58) + 0x10);
        uVar3 = _UNK_1036d2f30;
        if (*(uint *)(lVar7 + 0x18) <= uVar5) goto LAB_101fab340;
        if ((*(uint *)(*(long *)(*(long *)(lVar6 + lVar7) + 0x48) + 0x68) | 2) == 0x2e) {
          return 1;
        }
      }
      lVar7 = *(long *)(lVar4 + 0x58);
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      lVar6 = lVar6 + 8;
      uVar5 = uVar5 + 1;
      uVar3 = _UNK_1036d2f18;
    } while (lVar7 != 0);
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fab36c);
  (*pcVar1)();
}

