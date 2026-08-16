/* 0x06006602 StardewValley.Mobile.AStarGraph.GetShortestPathDijkstra @ 0x101fa1c4c */

/* WARNING: Type propagation algorithm not settling */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long * SDV_StardewValley_Mobile_AStarGraph_GetShortestPathDijkstra_06006602
                 (long param_1,long param_2,long param_3)

{
  int iVar1;
  int iVar2;
  int iVar3;
  int iVar4;
  float fVar5;
  long lVar6;
  code *pcVar7;
  char cVar8;
  long lVar9;
  long *plVar10;
  long lVar11;
  undefined8 uVar12;
  undefined8 uVar13;
  long *plVar14;
  ulong uVar15;
  uint uVar16;
  long lVar17;
  long lVar18;
  undefined8 uVar19;
  long lVar20;
  float fVar21;
  float fVar22;
  
  cVar8 = cRam0000000103911411;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar8 == '\0') {
    func_0x00010119b908(&UNK_103324920);
    cRam0000000103911411 = '\x01';
  }
  lVar9 = func_0x000100331820(uRam0000000103904598,0x20);
  if ((param_2 == 0) || (param_3 == 0)) {
    func_0x00010033202c(0x200006a);
    func_0x000100331a50();
                    /* WARNING: Does not return */
    pcVar7 = (code *)SoftwareBreakpoint(1,0x101fa23b4);
    (*pcVar7)();
  }
  plVar10 = (long *)func_0x000100331820(uRam00000001039045a0,0x20);
  if (*(char *)(lRam00000001039045a8 + 0x35) == '\0') {
    func_0x0001003319b0(lRam00000001039045a8);
  }
  lVar11 = func_0x000100331820(lRam00000001039045a8,0x20);
  lVar6 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar11 + 0x10) = *puRam00000001039045b0;
  *(undefined1 *)(((ulong)(lVar11 + 0x10) >> 9 & 0x7fffff) + lVar6) = 1;
  DataMemoryBarrier(2,3);
  plVar10[2] = lVar11;
  *(undefined1 *)(((ulong)(plVar10 + 2) >> 9 & 0x7fffff) + lVar6) = 1;
  if (param_2 == param_3) {
    lVar9 = (**(code **)(*plVar10 + 0x88))(plVar10);
    plVar14 = *(long **)(lVar9 + 0x10);
    *(int *)(lVar9 + 0x1c) = *(int *)(lVar9 + 0x1c) + 1;
    uVar13 = _UNK_1036d1808;
    if (plVar14 != (long *)0x0) {
      uVar16 = *(uint *)(lVar9 + 0x18);
      if (uVar16 < *(uint *)(plVar14 + 3)) {
        *(uint *)(lVar9 + 0x18) = uVar16 + 1;
        (**(code **)(*plVar14 + 0x110))(plVar14,(long)(int)uVar16,param_2);
      }
      else {
        func_0x00010037d11c(lVar9,param_2);
      }
      return plVar10;
    }
  }
  else {
    lVar11 = func_0x000100331820(lRam00000001039045a8,0x20);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar11 + 0x10) = *puRam00000001039045b0;
    *(undefined1 *)(((ulong)(lVar11 + 0x10) >> 9 & 0x7fffff) + lVar6) = 1;
    uVar12 = func_0x000100331820(uRam00000001039045b8,0x50);
    func_0x00010037d130();
    uVar13 = func_0x000100331820(uRam00000001039045c8,0x50);
    func_0x00010037d144();
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar9 + 0x10) = uVar13;
    *(undefined1 *)(((ulong)(lVar9 + 0x10) >> 9 & 0x7fffff) + lVar6) = 1;
    lVar18 = *(long *)(param_1 + 0x28);
    uVar13 = _UNK_1036d1788;
    if (lVar18 != 0) {
      uVar15 = 0xffffffffffffffff;
      lVar17 = 0x20;
      do {
        if ((long)(int)*(uint *)(lVar18 + 0x18) <= (long)(uVar15 + 1)) {
          uVar13 = _UNK_1036d1758;
          if (*(long *)(lVar9 + 0x10) != 0) {
            func_0x00010037d16c(0,*(long *)(lVar9 + 0x10),param_2);
            if (*(int *)(lVar11 + 0x18) == 0) goto LAB_101fa2244;
            goto LAB_101fa1ed8;
          }
          break;
        }
        if ((ulong)*(uint *)(lVar18 + 0x18) <= uVar15 + 1) goto LAB_101fa22b0;
        uVar15 = uVar15 + 1;
        uVar13 = _UNK_1036d1770;
        if (*(uint *)(*(long *)(lVar18 + 0x10) + 0x18) <= uVar15) goto LAB_101fa22e4;
        uVar19 = *(undefined8 *)(lVar17 + *(long *)(lVar18 + 0x10));
        plVar14 = *(long **)(lVar11 + 0x10);
        *(int *)(lVar11 + 0x1c) = *(int *)(lVar11 + 0x1c) + 1;
        uVar13 = _UNK_1036d1778;
        if (plVar14 == (long *)0x0) break;
        uVar16 = *(uint *)(lVar11 + 0x18);
        if (uVar16 < *(uint *)(plVar14 + 3)) {
          *(uint *)(lVar11 + 0x18) = uVar16 + 1;
          (**(code **)(*plVar14 + 0x110))(plVar14,(long)(int)uVar16,uVar19);
        }
        else {
          func_0x00010037d11c(lVar11,uVar19);
        }
        uVar13 = _UNK_1036d1780;
        if (*(long *)(lVar9 + 0x10) == 0) break;
        func_0x00010037d158(0x7f7fffff,*(long *)(lVar9 + 0x10),uVar19);
        lVar18 = *(long *)(param_1 + 0x28);
        if (lRam0000000103976fb8 != 0) {
          func_0x00010119b8f8();
        }
        lVar17 = lVar17 + 8;
        uVar13 = _UNK_1036d1788;
      } while (lVar18 != 0);
    }
  }
LAB_101fa231c:
  func_0x0001003316f4(0xee,uVar13);
                    /* WARNING: Does not return */
  pcVar7 = (code *)SoftwareBreakpoint(1,0x101fa2328);
  (*pcVar7)();
LAB_101fa1ed8:
  lVar18 = *(long *)(lVar9 + 0x18);
  if (lVar18 == 0) {
    lVar18 = func_0x000100331820(uRam0000000103904628,0x80);
    DataMemoryBarrier(2,3);
    *(long *)(lVar18 + 0x20) = lVar9;
    *(undefined1 *)(((ulong)(lVar18 + 0x20) >> 9 & 0x7fffff) + lVar6) = 1;
    lVar17 = lRam0000000103904630;
    *(undefined8 *)(lVar18 + 0x28) = uRam0000000103904638;
    *(long *)(lVar18 + 0x40) = lVar17;
    *(undefined8 *)(lVar18 + 0x18) = *(undefined8 *)(lVar17 + 0x30);
    *(undefined8 *)(lVar18 + 0x10) = *(undefined8 *)(lVar17 + 0x28);
    DataMemoryBarrier(2,3);
    *(long *)(lVar9 + 0x18) = lVar18;
    *(undefined1 *)(lVar6 + (ulong)((int)lVar9 + 0x18U >> 9)) = 1;
  }
  func_0x00010037d180(lVar11,lVar18);
  lVar11 = func_0x00010037d194();
  if (*(int *)(lVar11 + 0x18) == 0) {
LAB_101fa22b0:
    func_0x000100331b90();
                    /* WARNING: Does not return */
    pcVar7 = (code *)SoftwareBreakpoint(1,0x101fa22b8);
    (*pcVar7)();
  }
  uVar13 = _UNK_1036d17a0;
  if (*(int *)(*(long *)(lVar11 + 0x10) + 0x18) == 0) {
LAB_101fa22e4:
    func_0x0001003316f4(0xcc,uVar13);
                    /* WARNING: Does not return */
    pcVar7 = (code *)SoftwareBreakpoint(1,0x101fa22f0);
    (*pcVar7)();
  }
  lVar18 = *(long *)(*(long *)(lVar11 + 0x10) + 0x20);
  func_0x00010037d1a8(lVar11,lVar18);
  if (lVar18 == param_3) {
    cVar8 = func_0x00010037d20c(uVar12,param_3);
    while (cVar8 != '\0') {
      while( true ) {
        lVar9 = (**(code **)(*plVar10 + 0x88))(plVar10);
        uVar13 = _UNK_1036d17f0;
        if (lVar9 == 0) goto LAB_101fa231c;
        func_0x00010037d220(lVar9,0,param_3);
        param_3 = func_0x00010037d234(uVar12,param_3);
        cVar8 = func_0x00010037d20c(uVar12,param_3);
        if (lRam0000000103976fb8 != 0) break;
        if (cVar8 == '\0') goto LAB_101fa221c;
      }
      func_0x00010119b8f8();
    }
LAB_101fa221c:
    lVar9 = (**(code **)(*plVar10 + 0x88))(plVar10);
    uVar13 = _UNK_1036d17f8;
    if (lVar9 == 0) goto LAB_101fa231c;
    func_0x00010037d220(lVar9,0,param_3);
  }
  else {
    uVar13 = _UNK_1036d17b0;
    if ((lVar18 == 0) ||
       (lVar17 = SDV_StardewValley_Mobile_AStarNode_GetNeighbouringNodeList_0600662d(lVar18,1),
       uVar13 = _UNK_1036d17e0, lVar17 == 0)) goto LAB_101fa231c;
    uVar16 = 0xffffffff;
    lVar20 = 0x20;
    while ((int)(uVar16 + 1) < *(int *)(lVar17 + 0x18)) {
      lVar17 = SDV_StardewValley_Mobile_AStarNode_GetNeighbouringNodeList_0600662d(lVar18,1);
      if (*(uint *)(lVar17 + 0x18) <= uVar16 + 1) goto LAB_101fa22b0;
      uVar16 = uVar16 + 1;
      uVar13 = _UNK_1036d17c0;
      if (*(uint *)(*(long *)(lVar17 + 0x10) + 0x18) <= uVar16) goto LAB_101fa22e4;
      lVar17 = *(long *)(lVar20 + *(long *)(lVar17 + 0x10));
      uVar13 = _UNK_1036d17c8;
      if ((lVar17 == 0) || (uVar13 = _UNK_1036d17d0, *(long *)(lVar9 + 0x10) == 0))
      goto LAB_101fa231c;
      iVar1 = *(int *)(lVar18 + 0x34);
      iVar3 = *(int *)(lVar18 + 0x38);
      iVar2 = *(int *)(lVar17 + 0x34);
      iVar4 = *(int *)(lVar17 + 0x38);
      fVar21 = (float)func_0x00010037d1e4(*(long *)(lVar9 + 0x10),lVar18);
      uVar13 = _UNK_1036d17d8;
      if (*(long *)(lVar9 + 0x10) == 0) goto LAB_101fa231c;
      fVar5 = (float)(iVar1 - iVar2);
      fVar22 = (float)(iVar3 - iVar4);
      fVar21 = fVar21 + fVar5 * fVar5 + fVar22 * fVar22;
      fVar22 = (float)func_0x00010037d1e4(*(long *)(lVar9 + 0x10),lVar17);
      if (fVar21 < fVar22) {
        uVar13 = _UNK_1036d17e8;
        if (*(long *)(lVar9 + 0x10) == 0) goto LAB_101fa231c;
        func_0x00010037d16c(fVar21,*(long *)(lVar9 + 0x10),lVar17);
        func_0x00010037d1f8(uVar12,lVar17,lVar18);
      }
      lVar17 = SDV_StardewValley_Mobile_AStarNode_GetNeighbouringNodeList_0600662d(lVar18,1);
      uVar13 = _UNK_1036d17e0;
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
        uVar13 = _UNK_1036d17e0;
      }
      lVar20 = lVar20 + 8;
      _UNK_1036d17e0 = uVar13;
      if (lVar17 == 0) goto LAB_101fa231c;
    }
    iVar1 = *(int *)(lVar11 + 0x18);
    if (lRam0000000103976fb8 != 0) {
      func_0x00010119b8f8();
    }
    if (iVar1 != 0) goto LAB_101fa1ed8;
  }
LAB_101fa2244:
  (**(code **)(*plVar10 + 0x70))(plVar10);
  return plVar10;
}

