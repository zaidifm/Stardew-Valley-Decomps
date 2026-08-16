/* 0x06006654 StardewValley.Mobile.AStarNode.FetchNPC @ 0x101facad0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_Mobile_AStarNode_FetchNPC_06006654(long param_1)

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
  
  cVar3 = cRam0000000103911463;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103911463 == '\0') goto LAB_101facde0;
LAB_101facafc:
    lVar7 = *(long *)(param_1 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    if (cVar3 != '\0') goto LAB_101facafc;
LAB_101facde0:
    func_0x00010119b908(&UNK_103324d84);
    cRam0000000103911463 = '\x01';
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
      lVar9 = StardewValley_StardewValley_Character_get_StandingPixel_06003255(lVar7);
      iVar5 = (int)((ulong)lVar9 >> 0x20);
      iVar1 = iVar5 + 0x3f;
      if (-1 < lVar9) {
        iVar1 = iVar5;
      }
      if (*(int *)(param_1 + 0x38) == iVar1 >> 6) {
        return lVar7;
      }
    }
  }
  lVar7 = *(long *)(param_1 + 0x18);
  uVar6 = _UNK_1036d32f8;
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
          goto LAB_101facc24;
        }
        if (uVar2 <= uVar10) goto LAB_101face08;
        lVar7 = *(long *)(lVar9 + 0x10);
        uVar6 = _UNK_1036d32e8;
        if (*(uint *)(lVar7 + 0x18) <= uVar10) goto LAB_101facf38;
        lVar9 = (-(uVar11 >> 0x1f) & 0xfffffff800000000 | uVar11 << 3) + 0x20;
        uVar6 = _UNK_1036d32f0;
        if (*(long *)(lVar9 + lVar7) == 0) goto LAB_101facfd0;
        iVar5 = StardewValley_StardewValley_Character_get_StandingPixel_06003255();
        iVar1 = iVar5 + 0x3f;
        if (-1 < iVar5) {
          iVar1 = iVar5;
        }
        if (*(int *)(param_1 + 0x34) == iVar1 >> 6) {
          lVar7 = *(long *)(*(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0xa0) + 0x58);
          if (*(uint *)(lVar7 + 0x18) <= uVar10) goto LAB_101face08;
          lVar7 = *(long *)(lVar7 + 0x10);
          uVar6 = _UNK_1036d3328;
          if (*(uint *)(lVar7 + 0x18) <= uVar10) goto LAB_101facf38;
          uVar6 = _UNK_1036d3330;
          if (*(long *)(lVar9 + lVar7) == 0) goto LAB_101facfd0;
          lVar7 = StardewValley_StardewValley_Character_get_StandingPixel_06003255();
          iVar5 = (int)((ulong)lVar7 >> 0x20);
          iVar1 = iVar5 + 0x3f;
          if (-1 < lVar7) {
            iVar1 = iVar5;
          }
          if (*(int *)(param_1 + 0x38) == iVar1 >> 6) {
            lVar7 = *(long *)(*(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0xa0) + 0x58);
            if (*(uint *)(lVar7 + 0x18) <= uVar10) goto LAB_101face08;
            lVar7 = *(long *)(lVar7 + 0x10);
            uVar6 = _UNK_1036d3360;
            if (*(uint *)(lVar7 + 0x18) <= uVar10) goto LAB_101facf38;
            goto LAB_101facdbc;
          }
        }
        lVar7 = *(long *)(param_1 + 0x18);
        if (lRam0000000103976fb8 != 0) break;
        uVar11 = (ulong)(uVar10 + 1);
        uVar6 = _UNK_1036d32f8;
        if (lVar7 == 0) goto LAB_101facfd0;
      }
      func_0x00010119b8f8();
      uVar11 = (ulong)(uVar10 + 1);
      uVar6 = _UNK_1036d32f8;
    } while (lVar7 != 0);
  }
LAB_101facfd0:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101facfdc);
  (*pcVar4)();
  while( true ) {
    lVar7 = *(long *)(param_1 + 0x18);
    uVar6 = _UNK_1036d3398;
    if (lRam0000000103976fb8 != 0) {
      func_0x00010119b8f8();
      uVar6 = _UNK_1036d3398;
    }
    uVar11 = (ulong)(uVar10 + 1);
    _UNK_1036d3398 = uVar6;
    if (lVar7 == 0) break;
LAB_101facc24:
    lVar7 = *(long *)(*(long *)(*(long *)(lVar7 + 0x10) + 0x1f0) + 0x80);
    uVar2 = *(uint *)(lVar7 + 0x18);
    uVar10 = (uint)uVar11;
    if ((int)uVar2 <= (int)uVar10) {
      return 0;
    }
    if (uVar2 <= uVar10) goto LAB_101face08;
    lVar7 = *(long *)(lVar7 + 0x10);
    uVar6 = _UNK_1036d3388;
    if (*(uint *)(lVar7 + 0x18) <= uVar10) goto LAB_101facf38;
    lVar9 = (-(uVar11 >> 0x1f) & 0xfffffff800000000 | uVar11 << 3) + 0x20;
    uVar6 = _UNK_1036d3390;
    if (*(long *)(lVar9 + lVar7) == 0) break;
    iVar5 = StardewValley_StardewValley_Character_get_StandingPixel_06003255();
    iVar1 = iVar5 + 0x3f;
    if (-1 < iVar5) {
      iVar1 = iVar5;
    }
    if (*(int *)(param_1 + 0x34) == iVar1 >> 6) {
      lVar7 = *(long *)(*(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0x1f0) + 0x80);
      if (*(uint *)(lVar7 + 0x18) <= uVar10) goto LAB_101face08;
      lVar7 = *(long *)(lVar7 + 0x10);
      uVar6 = _UNK_1036d33c8;
      if (*(uint *)(lVar7 + 0x18) <= uVar10) goto LAB_101facf38;
      uVar6 = _UNK_1036d33d0;
      if (*(long *)(lVar9 + lVar7) == 0) break;
      lVar7 = StardewValley_StardewValley_Character_get_StandingPixel_06003255();
      iVar5 = (int)((ulong)lVar7 >> 0x20);
      iVar1 = iVar5 + 0x3f;
      if (-1 < lVar7) {
        iVar1 = iVar5;
      }
      if (*(int *)(param_1 + 0x38) == iVar1 >> 6) {
        lVar7 = *(long *)(*(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0x1f0) + 0x80);
        if (uVar10 < *(uint *)(lVar7 + 0x18)) {
          lVar7 = *(long *)(lVar7 + 0x10);
          uVar6 = _UNK_1036d3400;
          if (uVar10 < *(uint *)(lVar7 + 0x18)) {
LAB_101facdbc:
            return *(long *)(lVar9 + lVar7);
          }
LAB_101facf38:
          func_0x0001003316f4(0xcc,uVar6);
                    /* WARNING: Does not return */
          pcVar4 = (code *)SoftwareBreakpoint(1,0x101facf44);
          (*pcVar4)();
        }
LAB_101face08:
        func_0x000100331b90();
                    /* WARNING: Does not return */
        pcVar4 = (code *)SoftwareBreakpoint(1,0x101face10);
        (*pcVar4)();
      }
    }
  }
  goto LAB_101facfd0;
}

