/* 0x06006653 StardewValley.Mobile.AStarNode.ContainsNPC @ 0x101fac668 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Mobile_AStarNode_ContainsNPC_06006653(long param_1)

{
  int iVar1;
  uint uVar2;
  char cVar3;
  code *pcVar4;
  int iVar5;
  undefined8 uVar6;
  long lVar7;
  undefined8 *puVar8;
  long lVar9;
  uint uVar10;
  ulong uVar11;
  
  cVar3 = cRam0000000103911462;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103911462 == '\0') goto LAB_101fac940;
LAB_101fac698:
    lVar7 = *(long *)(param_1 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    if (cVar3 != '\0') goto LAB_101fac698;
LAB_101fac940:
    func_0x00010119b908(&UNK_103324d75);
    cRam0000000103911462 = '\x01';
    lVar7 = *(long *)(param_1 + 0x18);
  }
  puVar8 = *(undefined8 **)(lVar7 + 0x10);
  if (((puVar8 != (undefined8 *)0x0) &&
      (lRam00000001038c6b60 == *(long *)(*(long *)(*(long *)*puVar8 + 0x10) + 0x10))) &&
     (lVar7 = puVar8[0x5f], lVar7 != 0)) {
    iVar5 = StardewValley_StardewValley_Character_get_StandingPixel_06003255(lVar7);
    iVar1 = iVar5 + 0x3f;
    if (-1 < iVar5) {
      iVar1 = iVar5;
    }
    if (*(int *)(param_1 + 0x34) == iVar1 >> 6) {
      lVar7 = StardewValley_StardewValley_Character_get_StandingPixel_06003255(lVar7);
      iVar5 = (int)((ulong)lVar7 >> 0x20);
      iVar1 = iVar5 + 0x3f;
      if (-1 < lVar7) {
        iVar1 = iVar5;
      }
      if (*(int *)(param_1 + 0x38) == iVar1 >> 6) {
        return 1;
      }
    }
  }
  lVar7 = *(long *)(param_1 + 0x18);
  uVar6 = _UNK_1036d31f8;
  if (lVar7 != 0) {
    uVar11 = 0;
    do {
      while( true ) {
        lVar9 = *(long *)(*(long *)(*(long *)(lVar7 + 0x10) + 0xa0) + 0x58);
        uVar2 = *(uint *)(lVar9 + 0x18);
        uVar10 = (uint)uVar11;
        if ((int)uVar2 <= (int)uVar10) {
          lVar9 = *(long *)(*(long *)(lVar7 + 0x10) + 0x1f0);
          if (lVar9 == 0) {
            return 0;
          }
          if (*(long *)(lVar9 + 0x80) == 0) {
            return 0;
          }
          uVar11 = 0;
          goto LAB_101fac7f0;
        }
        if (uVar2 <= uVar10) goto LAB_101fac968;
        lVar7 = *(long *)(lVar9 + 0x10);
        uVar6 = _UNK_1036d31f0;
        if (*(uint *)(lVar7 + 0x18) <= uVar10) goto LAB_101facaa4;
        lVar9 = (-(uVar11 >> 0x1f) & 0xfffffff800000000 | uVar11 << 3) + 0x20;
        puVar8 = *(undefined8 **)(lVar9 + lVar7);
        uVar6 = _UNK_1036d32b0;
        if (puVar8 == (undefined8 *)0x0) goto LAB_101facac4;
        if ((lRam00000001038c6688 != *(long *)(*(long *)(*(long *)*puVar8 + 0x10) + 0x18)) ||
           (*(char *)(puVar8[0x91] + 0x68) == '\0')) {
          iVar5 = StardewValley_StardewValley_Character_get_StandingPixel_06003255();
          iVar1 = iVar5 + 0x3f;
          if (-1 < iVar5) {
            iVar1 = iVar5;
          }
          if (*(int *)(param_1 + 0x34) == iVar1 >> 6) {
            lVar7 = *(long *)(*(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0xa0) + 0x58);
            if (*(uint *)(lVar7 + 0x18) <= uVar10) goto LAB_101fac968;
            lVar7 = *(long *)(lVar7 + 0x10);
            uVar6 = _UNK_1036d3228;
            if (*(uint *)(lVar7 + 0x18) <= uVar10) goto LAB_101facaa4;
            uVar6 = _UNK_1036d3230;
            if (*(long *)(lVar9 + lVar7) == 0) goto LAB_101facac4;
            lVar7 = StardewValley_StardewValley_Character_get_StandingPixel_06003255();
            iVar5 = (int)((ulong)lVar7 >> 0x20);
            iVar1 = iVar5 + 0x3f;
            if (-1 < lVar7) {
              iVar1 = iVar5;
            }
            if (*(int *)(param_1 + 0x38) == iVar1 >> 6) {
              return 1;
            }
          }
        }
        lVar7 = *(long *)(param_1 + 0x18);
        if (lRam0000000103976fb8 != 0) break;
        uVar11 = (ulong)(uVar10 + 1);
        uVar6 = _UNK_1036d31f8;
        if (lVar7 == 0) goto LAB_101facac4;
      }
      func_0x00010119b8f8();
      uVar11 = (ulong)(uVar10 + 1);
      uVar6 = _UNK_1036d31f8;
    } while (lVar7 != 0);
  }
LAB_101facac4:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101facad0);
  (*pcVar4)();
  while( true ) {
    lVar7 = *(long *)(param_1 + 0x18);
    uVar6 = _UNK_1036d3270;
    if (lRam0000000103976fb8 != 0) {
      func_0x00010119b8f8();
      uVar6 = _UNK_1036d3270;
    }
    uVar11 = (ulong)(uVar10 + 1);
    _UNK_1036d3270 = uVar6;
    if (lVar7 == 0) break;
LAB_101fac7f0:
    lVar7 = *(long *)(*(long *)(*(long *)(lVar7 + 0x10) + 0x1f0) + 0x80);
    uVar2 = *(uint *)(lVar7 + 0x18);
    uVar10 = (uint)uVar11;
    if ((int)uVar2 <= (int)uVar10) {
      return 0;
    }
    if (uVar2 <= uVar10) goto LAB_101fac968;
    lVar7 = *(long *)(lVar7 + 0x10);
    uVar6 = _UNK_1036d3260;
    if (*(uint *)(lVar7 + 0x18) <= uVar10) goto LAB_101facaa4;
    lVar9 = (-(uVar11 >> 0x1f) & 0xfffffff800000000 | uVar11 << 3) + 0x20;
    uVar6 = _UNK_1036d3268;
    if (*(long *)(lVar9 + lVar7) == 0) break;
    iVar5 = StardewValley_StardewValley_Character_get_StandingPixel_06003255();
    iVar1 = iVar5 + 0x3f;
    if (-1 < iVar5) {
      iVar1 = iVar5;
    }
    if (*(int *)(param_1 + 0x34) == iVar1 >> 6) {
      lVar7 = *(long *)(*(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0x1f0) + 0x80);
      if (*(uint *)(lVar7 + 0x18) <= uVar10) {
LAB_101fac968:
        func_0x000100331b90();
                    /* WARNING: Does not return */
        pcVar4 = (code *)SoftwareBreakpoint(1,0x101fac970);
        (*pcVar4)();
      }
      lVar7 = *(long *)(lVar7 + 0x10);
      uVar6 = _UNK_1036d32a0;
      if (*(uint *)(lVar7 + 0x18) <= uVar10) {
LAB_101facaa4:
        func_0x0001003316f4(0xcc,uVar6);
                    /* WARNING: Does not return */
        pcVar4 = (code *)SoftwareBreakpoint(1,0x101facab0);
        (*pcVar4)();
      }
      uVar6 = _UNK_1036d32a8;
      if (*(long *)(lVar9 + lVar7) == 0) break;
      lVar7 = StardewValley_StardewValley_Character_get_StandingPixel_06003255();
      iVar5 = (int)((ulong)lVar7 >> 0x20);
      iVar1 = iVar5 + 0x3f;
      if (-1 < lVar7) {
        iVar1 = iVar5;
      }
      if (*(int *)(param_1 + 0x38) == iVar1 >> 6) {
        return 1;
      }
    }
  }
  goto LAB_101facac4;
}

