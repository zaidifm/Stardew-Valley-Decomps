/* 0x06006647 StardewValley.Mobile.AStarNode.ContainsStumpOrBoulder @ 0x101faacd4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_AStarNode_ContainsStumpOrBoulder_06006647(long param_1)

{
  uint uVar1;
  code *pcVar2;
  char cVar3;
  undefined8 uVar4;
  long lVar5;
  undefined8 *puVar6;
  uint uVar7;
  long lVar8;
  long lVar9;
  long *plStack_48;
  
  cVar3 = cRam0000000103911456;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103324d00);
    cRam0000000103911456 = '\x01';
  }
  plStack_48 = (long *)0x0;
  puVar6 = *(undefined8 **)(*(long *)(param_1 + 0x18) + 0x10);
  uVar4 = _UNK_1036d2ed8;
  if (puVar6 != (undefined8 *)0x0) {
    lVar5 = *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x10);
    if (lRam00000001038c69d0 == lVar5) {
      lVar5 = puVar6[0x20];
      uVar4 = _UNK_1036d2eb8;
      if (lVar5 != 0) {
        uVar7 = 0xffffffff;
        lVar9 = 0x20;
        do {
          while( true ) {
            uVar1 = *(uint *)(*(long *)(lVar5 + 0x58) + 0x18);
            if ((int)uVar1 <= (int)(uVar7 + 1)) goto LAB_101fab000;
            if (uVar1 <= uVar7 + 1) goto LAB_101fab08c;
            lVar5 = *(long *)(*(long *)(lVar5 + 0x58) + 0x10);
            uVar7 = uVar7 + 1;
            uVar4 = _UNK_1036d2ec8;
            if (*(uint *)(lVar5 + 0x18) <= uVar7) goto LAB_101fab168;
            lVar5 = *(long *)(lVar9 + lVar5);
            uVar4 = _UNK_1036d2ed0;
            if (lVar5 == 0) goto LAB_101fab1d0;
            cVar3 = func_0x000101a983a0(lVar5,*(undefined4 *)(param_1 + 0x34),
                                        *(undefined4 *)(param_1 + 0x38));
            if (cVar3 != '\0') {
              return true;
            }
            lVar5 = puVar6[0x20];
            if (lRam0000000103976fb8 != 0) break;
            lVar9 = lVar9 + 8;
            uVar4 = _UNK_1036d2eb8;
            if (lVar5 == 0) goto LAB_101fab1d0;
          }
          func_0x00010119b8f8();
          lVar9 = lVar9 + 8;
          uVar4 = _UNK_1036d2eb8;
        } while (lVar5 != 0);
      }
    }
    else if (lRam00000001038c6de0 == lVar5) {
      lVar5 = puVar6[0x20];
      uVar4 = _UNK_1036d2e90;
      if (lVar5 != 0) {
        uVar7 = 0xffffffff;
        lVar9 = 0x20;
        do {
          while( true ) {
            uVar1 = *(uint *)(*(long *)(lVar5 + 0x58) + 0x18);
            if ((int)uVar1 <= (int)(uVar7 + 1)) goto LAB_101fab000;
            if (uVar1 <= uVar7 + 1) goto LAB_101fab08c;
            lVar5 = *(long *)(*(long *)(lVar5 + 0x58) + 0x10);
            uVar7 = uVar7 + 1;
            uVar4 = _UNK_1036d2ea0;
            if (*(uint *)(lVar5 + 0x18) <= uVar7) goto LAB_101fab168;
            lVar5 = *(long *)(lVar9 + lVar5);
            uVar4 = _UNK_1036d2ea8;
            if (lVar5 == 0) goto LAB_101fab1d0;
            cVar3 = func_0x000101a983a0(lVar5,*(undefined4 *)(param_1 + 0x34),
                                        *(undefined4 *)(param_1 + 0x38));
            if (cVar3 != '\0') {
              return true;
            }
            lVar5 = puVar6[0x20];
            if (lRam0000000103976fb8 != 0) break;
            lVar9 = lVar9 + 8;
            uVar4 = _UNK_1036d2e90;
            if (lVar5 == 0) goto LAB_101fab1d0;
          }
          func_0x00010119b8f8();
          lVar9 = lVar9 + 8;
          uVar4 = _UNK_1036d2e90;
        } while (lVar5 != 0);
      }
    }
    else if (lRam00000001038c6ea8 == lVar5) {
      lVar5 = puVar6[0x20];
      uVar4 = _UNK_1036d2e68;
      if (lVar5 != 0) {
        uVar7 = 0xffffffff;
        lVar9 = 0x20;
        do {
          while( true ) {
            uVar1 = *(uint *)(*(long *)(lVar5 + 0x58) + 0x18);
            if ((int)uVar1 <= (int)(uVar7 + 1)) goto LAB_101fab000;
            if (uVar1 <= uVar7 + 1) goto LAB_101fab08c;
            lVar5 = *(long *)(*(long *)(lVar5 + 0x58) + 0x10);
            uVar7 = uVar7 + 1;
            uVar4 = _UNK_1036d2e78;
            if (*(uint *)(lVar5 + 0x18) <= uVar7) goto LAB_101fab168;
            lVar5 = *(long *)(lVar9 + lVar5);
            uVar4 = _UNK_1036d2e80;
            if (lVar5 == 0) goto LAB_101fab1d0;
            cVar3 = func_0x000101a983a0(lVar5,*(undefined4 *)(param_1 + 0x34),
                                        *(undefined4 *)(param_1 + 0x38));
            if (cVar3 != '\0') {
              return true;
            }
            lVar5 = puVar6[0x20];
            if (lRam0000000103976fb8 != 0) break;
            lVar9 = lVar9 + 8;
            uVar4 = _UNK_1036d2e68;
            if (lVar5 == 0) goto LAB_101fab1d0;
          }
          func_0x00010119b8f8();
          lVar9 = lVar9 + 8;
          uVar4 = _UNK_1036d2e68;
        } while (lVar5 != 0);
      }
    }
    else if (lRam00000001038c6d50 == *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18)) {
      lVar5 = puVar6[0x20];
      uVar4 = _UNK_1036d2e40;
      if (lVar5 != 0) {
        uVar7 = 0xffffffff;
        lVar9 = 0x20;
        do {
          while( true ) {
            uVar1 = *(uint *)(*(long *)(lVar5 + 0x58) + 0x18);
            if ((int)uVar1 <= (int)(uVar7 + 1)) goto LAB_101fab000;
            if (uVar1 <= uVar7 + 1) goto LAB_101fab08c;
            lVar5 = *(long *)(*(long *)(lVar5 + 0x58) + 0x10);
            uVar7 = uVar7 + 1;
            uVar4 = _UNK_1036d2e50;
            if (*(uint *)(lVar5 + 0x18) <= uVar7) goto LAB_101fab168;
            lVar5 = *(long *)(lVar9 + lVar5);
            uVar4 = _UNK_1036d2e58;
            if (lVar5 == 0) goto LAB_101fab1d0;
            cVar3 = func_0x000101a983a0(lVar5,*(undefined4 *)(param_1 + 0x34),
                                        *(undefined4 *)(param_1 + 0x38));
            if (cVar3 != '\0') {
              return true;
            }
            lVar5 = puVar6[0x20];
            if (lRam0000000103976fb8 != 0) break;
            lVar9 = lVar9 + 8;
            uVar4 = _UNK_1036d2e40;
            if (lVar5 == 0) goto LAB_101fab1d0;
          }
          func_0x00010119b8f8();
          lVar9 = lVar9 + 8;
          uVar4 = _UNK_1036d2e40;
        } while (lVar5 != 0);
      }
    }
    else {
      lVar5 = puVar6[0x20];
      lVar9 = *(long *)(lVar5 + 0x58);
      uVar4 = _UNK_1036d2e08;
      if (lVar9 != 0) {
        uVar7 = 0xffffffff;
        lVar8 = 0x20;
LAB_101faad80:
        do {
          if ((int)*(uint *)(lVar9 + 0x18) <= (int)(uVar7 + 1)) goto LAB_101fab000;
          if (*(uint *)(lVar9 + 0x18) <= uVar7 + 1) {
LAB_101fab08c:
            func_0x000100331b90();
                    /* WARNING: Does not return */
            pcVar2 = (code *)SoftwareBreakpoint(1,0x101fab094);
            (*pcVar2)();
          }
          uVar7 = uVar7 + 1;
          uVar4 = _UNK_1036d2e18;
          if (*(uint *)(*(long *)(lVar9 + 0x10) + 0x18) <= uVar7) {
LAB_101fab168:
            func_0x0001003316f4(0xcc,uVar4);
                    /* WARNING: Does not return */
            pcVar2 = (code *)SoftwareBreakpoint(1,0x101fab174);
            (*pcVar2)();
          }
          lVar9 = *(long *)(lVar8 + *(long *)(lVar9 + 0x10));
          uVar4 = _UNK_1036d2e20;
          if (lVar9 == 0) break;
          cVar3 = func_0x000101a983a0(lVar9,*(undefined4 *)(param_1 + 0x34),
                                      *(undefined4 *)(param_1 + 0x38));
          if (cVar3 != '\0') {
            return true;
          }
          lVar9 = *(long *)(lVar5 + 0x58);
          if (lRam0000000103976fb8 == 0) {
            lVar8 = lVar8 + 8;
            uVar4 = _UNK_1036d2e08;
            if (lVar9 == 0) break;
            goto LAB_101faad80;
          }
          func_0x00010119b8f8();
          lVar8 = lVar8 + 8;
          uVar4 = _UNK_1036d2e08;
        } while (lVar9 != 0);
      }
    }
  }
LAB_101fab1d0:
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fab1dc);
  (*pcVar2)();
LAB_101fab000:
  lVar5 = *(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0xb8);
  uVar4 = _UNK_1036d2e30;
  if (lVar5 != 0) {
    func_0x000101b560e8((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38),lVar5,
                        &plStack_48);
    if (plStack_48 != (long *)0x0) {
      uVar4 = (**(code **)(*plStack_48 + 0x1e8))();
      cVar3 = func_0x000100345aa0(uVar4,uRam00000001038ecef0);
      return cVar3 != '\0';
    }
    return false;
  }
  goto LAB_101fab1d0;
}

