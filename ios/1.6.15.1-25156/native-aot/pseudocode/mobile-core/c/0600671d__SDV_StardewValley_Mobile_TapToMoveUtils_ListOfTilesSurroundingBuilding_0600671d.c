/* 0x0600671d StardewValley.Mobile.TapToMoveUtils.ListOfTilesSurroundingBuilding @ 0x101fd0f9c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_Mobile_TapToMoveUtils_ListOfTilesSurroundingBuilding_0600671d(long param_1)

{
  int iVar1;
  int iVar2;
  uint uVar3;
  char cVar4;
  code *pcVar5;
  long lVar6;
  undefined8 uVar7;
  int iVar8;
  int iVar9;
  long lVar10;
  int iVar11;
  int iVar12;
  
  cVar4 = cRam000000010391152c;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103325c00);
    cRam000000010391152c = '\x01';
  }
  lVar6 = func_0x000100331820(uRam00000001038e2098,0x20);
  lVar10 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar6 + 0x10) = *puRam00000001038e20a0;
  *(undefined1 *)(((ulong)(lVar6 + 0x10) >> 9 & 0x7fffff) + lVar10) = 1;
  lVar10 = *(long *)(param_1 + 0x50);
  uVar7 = _UNK_1036d82b8;
  if (lVar10 != 0) {
    iVar8 = 0;
    do {
      while( true ) {
        if (*(int *)(lVar10 + 0x68) + -1 < iVar8) {
          lVar10 = *(long *)(param_1 + 0x58);
          uVar7 = _UNK_1036d82e8;
          if (lVar10 != 0) {
            iVar8 = 1;
            goto LAB_101fd10e4;
          }
          goto LAB_101fd1434;
        }
        uVar7 = _UNK_1036d82a0;
        if ((*(long *)(param_1 + 0x40) == 0) ||
           (uVar7 = _UNK_1036d82a8, *(long *)(param_1 + 0x48) == 0)) goto LAB_101fd1434;
        iVar9 = *(int *)(*(long *)(param_1 + 0x40) + 0x68);
        lVar10 = *(long *)(lVar6 + 0x10);
        iVar12 = *(int *)(*(long *)(param_1 + 0x48) + 0x68);
        *(int *)(lVar6 + 0x1c) = *(int *)(lVar6 + 0x1c) + 1;
        uVar7 = _UNK_1036d82b0;
        if (lVar10 == 0) goto LAB_101fd1434;
        uVar3 = *(uint *)(lVar6 + 0x18);
        if (uVar3 < *(uint *)(lVar10 + 0x18)) {
          *(uint *)(lVar6 + 0x18) = uVar3 + 1;
          uVar7 = _UNK_1036d82c0;
          if (*(uint *)(lVar10 + 0x18) <= uVar3) goto LAB_101fd146c;
          lVar10 = lVar10 + (long)(int)uVar3 * 8;
          *(float *)(lVar10 + 0x20) = (float)(iVar8 + iVar9);
          *(float *)(lVar10 + 0x24) = (float)iVar12;
        }
        else {
          func_0x000100359820(lVar6);
        }
        lVar10 = *(long *)(param_1 + 0x50);
        if (lRam0000000103976fb8 != 0) break;
        iVar8 = iVar8 + 1;
        uVar7 = _UNK_1036d82b8;
        if (lVar10 == 0) goto LAB_101fd1434;
      }
      func_0x00010119b8f8();
      iVar8 = iVar8 + 1;
      uVar7 = _UNK_1036d82b8;
    } while (lVar10 != 0);
  }
  goto LAB_101fd1434;
LAB_101fd10e4:
  if (*(int *)(lVar10 + 0x68) + -1 < iVar8) {
    lVar10 = *(long *)(param_1 + 0x50);
    uVar7 = _UNK_1036d8318;
    if (lVar10 != 0) {
      iVar8 = 1;
      iVar9 = -2;
      goto LAB_101fd11c0;
    }
    goto LAB_101fd1434;
  }
  uVar7 = _UNK_1036d82c8;
  if (((*(long *)(param_1 + 0x40) == 0) || (uVar7 = _UNK_1036d82d0, *(long *)(param_1 + 0x50) == 0))
     || (uVar7 = _UNK_1036d82d8, *(long *)(param_1 + 0x48) == 0)) goto LAB_101fd1434;
  iVar9 = *(int *)(*(long *)(param_1 + 0x40) + 0x68);
  iVar12 = *(int *)(*(long *)(param_1 + 0x50) + 0x68);
  lVar10 = *(long *)(lVar6 + 0x10);
  iVar1 = *(int *)(*(long *)(param_1 + 0x48) + 0x68);
  *(int *)(lVar6 + 0x1c) = *(int *)(lVar6 + 0x1c) + 1;
  uVar7 = _UNK_1036d82e0;
  if (lVar10 == 0) goto LAB_101fd1434;
  uVar3 = *(uint *)(lVar6 + 0x18);
  if (uVar3 < *(uint *)(lVar10 + 0x18)) {
    *(uint *)(lVar6 + 0x18) = uVar3 + 1;
    uVar7 = _UNK_1036d82f0;
    if (*(uint *)(lVar10 + 0x18) <= uVar3) goto LAB_101fd146c;
    lVar10 = lVar10 + (long)(int)uVar3 * 8;
    *(float *)(lVar10 + 0x20) = (float)(iVar9 + iVar12 + -1);
    *(float *)(lVar10 + 0x24) = (float)(iVar8 + iVar1);
  }
  else {
    func_0x000100359820(lVar6);
  }
  lVar10 = *(long *)(param_1 + 0x58);
  uVar7 = _UNK_1036d82e8;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
    uVar7 = _UNK_1036d82e8;
  }
  iVar8 = iVar8 + 1;
  _UNK_1036d82e8 = uVar7;
  if (lVar10 == 0) goto LAB_101fd1434;
  goto LAB_101fd10e4;
LAB_101fd11c0:
  iVar12 = *(int *)(lVar10 + 0x68);
  if (iVar12 + -1 < iVar8) {
    lVar10 = *(long *)(param_1 + 0x58);
    uVar7 = _UNK_1036d8338;
    if (lVar10 != 0) {
      iVar8 = 1;
      iVar9 = -2;
      goto LAB_101fd1290;
    }
    goto LAB_101fd1434;
  }
  uVar7 = _UNK_1036d82f8;
  if (((*(long *)(param_1 + 0x40) == 0) || (uVar7 = _UNK_1036d8300, *(long *)(param_1 + 0x48) == 0))
     || (uVar7 = _UNK_1036d8308, *(long *)(param_1 + 0x58) == 0)) goto LAB_101fd1434;
  iVar1 = *(int *)(*(long *)(param_1 + 0x40) + 0x68);
  iVar11 = *(int *)(*(long *)(param_1 + 0x48) + 0x68);
  lVar10 = *(long *)(lVar6 + 0x10);
  iVar2 = *(int *)(*(long *)(param_1 + 0x58) + 0x68);
  *(int *)(lVar6 + 0x1c) = *(int *)(lVar6 + 0x1c) + 1;
  uVar7 = _UNK_1036d8310;
  if (lVar10 == 0) goto LAB_101fd1434;
  uVar3 = *(uint *)(lVar6 + 0x18);
  if (uVar3 < *(uint *)(lVar10 + 0x18)) {
    *(uint *)(lVar6 + 0x18) = uVar3 + 1;
    uVar7 = _UNK_1036d8320;
    if (*(uint *)(lVar10 + 0x18) <= uVar3) goto LAB_101fd146c;
    lVar10 = lVar10 + (long)(int)uVar3 * 8;
    *(float *)(lVar10 + 0x20) = (float)(iVar9 + iVar12 + iVar1);
    *(float *)(lVar10 + 0x24) = (float)(iVar11 + iVar2 + -1);
  }
  else {
    func_0x000100359820(lVar6);
  }
  lVar10 = *(long *)(param_1 + 0x50);
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  iVar9 = iVar9 + -1;
  iVar8 = iVar8 + 1;
  uVar7 = _UNK_1036d8318;
  if (lVar10 == 0) goto LAB_101fd1434;
  goto LAB_101fd11c0;
LAB_101fd1290:
  do {
    iVar12 = *(int *)(lVar10 + 0x68);
    if (iVar12 + -1 <= iVar8) {
      return lVar6;
    }
    uVar7 = _UNK_1036d8290;
    if ((*(long *)(param_1 + 0x40) == 0) || (uVar7 = _UNK_1036d8328, *(long *)(param_1 + 0x48) == 0)
       ) break;
    iVar11 = *(int *)(*(long *)(param_1 + 0x40) + 0x68);
    lVar10 = *(long *)(lVar6 + 0x10);
    iVar1 = *(int *)(*(long *)(param_1 + 0x48) + 0x68);
    *(int *)(lVar6 + 0x1c) = *(int *)(lVar6 + 0x1c) + 1;
    uVar7 = _UNK_1036d8330;
    if (lVar10 == 0) break;
    uVar3 = *(uint *)(lVar6 + 0x18);
    if (uVar3 < *(uint *)(lVar10 + 0x18)) {
      *(uint *)(lVar6 + 0x18) = uVar3 + 1;
      uVar7 = _UNK_1036d8340;
      if (*(uint *)(lVar10 + 0x18) <= uVar3) {
LAB_101fd146c:
        func_0x0001003316f4(0xcc,uVar7);
                    /* WARNING: Does not return */
        pcVar5 = (code *)SoftwareBreakpoint(1,0x101fd1478);
        (*pcVar5)();
      }
      lVar10 = lVar10 + (long)(int)uVar3 * 8;
      *(float *)(lVar10 + 0x20) = (float)iVar11;
      *(float *)(lVar10 + 0x24) = (float)(iVar9 + iVar12 + iVar1);
    }
    else {
      func_0x000100359820(lVar6);
    }
    lVar10 = *(long *)(param_1 + 0x58);
    if (lRam0000000103976fb8 != 0) {
      func_0x00010119b8f8();
    }
    iVar9 = iVar9 + -1;
    iVar8 = iVar8 + 1;
    uVar7 = _UNK_1036d8338;
  } while (lVar10 != 0);
LAB_101fd1434:
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar5 = (code *)SoftwareBreakpoint(1,0x101fd1440);
  (*pcVar5)();
}

