/* 0x060066eb StardewValley.Mobile.TapToMoveUtils.getPathOnIslandNorthBridge @ 0x101fcb6cc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long * SDV_StardewValley_Mobile_TapToMoveUtils_getPathOnIslandNorthBridge_060066eb
                 (float param_1,float param_2,float param_3,long param_4)

{
  char cVar1;
  code *pcVar2;
  long *plVar3;
  long lVar4;
  long lVar5;
  undefined8 uVar6;
  long *plVar7;
  undefined8 uVar8;
  int iVar9;
  uint uVar10;
  uint uVar11;
  int iVar12;
  
  cVar1 = cRam00000001039114fa;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103325910);
    cRam00000001039114fa = '\x01';
  }
  plVar3 = (long *)func_0x000100331820(uRam00000001039045a0,0x20);
  if (*(char *)(lRam00000001039045a8 + 0x35) == '\0') {
    func_0x0001003319b0(lRam00000001039045a8);
  }
  lVar4 = func_0x000100331820(lRam00000001039045a8,0x20);
  lVar5 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar4 + 0x10) = *puRam00000001039045b0;
  *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar5) = 1;
  DataMemoryBarrier(2,3);
  plVar3[2] = lVar4;
  *(undefined1 *)(((ulong)(plVar3 + 2) >> 9 & 0x7fffff) + lVar5) = 1;
  if (param_2 == 41.0) {
    lVar5 = (**(code **)(*plVar3 + 0x88))(plVar3);
    uVar8 = _UNK_1036d79c8;
    if ((param_4 == 0) ||
       (uVar6 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc(param_4,0x25,0x28),
       uVar8 = _UNK_1036d79d0, lVar5 == 0)) goto LAB_101fcbaf8;
    plVar7 = *(long **)(lVar5 + 0x10);
    *(int *)(lVar5 + 0x1c) = *(int *)(lVar5 + 0x1c) + 1;
    uVar8 = _UNK_1036d79d8;
    if (plVar7 == (long *)0x0) goto LAB_101fcbaf8;
    if (*(uint *)(lVar5 + 0x18) < *(uint *)(plVar7 + 3)) {
      *(uint *)(lVar5 + 0x18) = *(uint *)(lVar5 + 0x18) + 1;
      (**(code **)(*plVar7 + 0x110))();
    }
    else {
      func_0x00010037d11c(lVar5,uVar6);
    }
    lVar5 = (**(code **)(*plVar3 + 0x88))(plVar3);
    uVar6 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc(param_4,0x25,0x27);
    uVar8 = _UNK_1036d79e0;
    if (lVar5 == 0) goto LAB_101fcbaf8;
    plVar7 = *(long **)(lVar5 + 0x10);
    *(int *)(lVar5 + 0x1c) = *(int *)(lVar5 + 0x1c) + 1;
    uVar8 = _UNK_1036d79e8;
joined_r0x000101fcb8b4:
    if (plVar7 == (long *)0x0) goto LAB_101fcbaf8;
    if (*(uint *)(lVar5 + 0x18) < *(uint *)(plVar7 + 3)) {
      *(uint *)(lVar5 + 0x18) = *(uint *)(lVar5 + 0x18) + 1;
      (**(code **)(*plVar7 + 0x110))();
    }
    else {
      func_0x00010037d11c(lVar5,uVar6);
    }
  }
  else if (param_2 == 40.0) {
    lVar5 = (**(code **)(*plVar3 + 0x88))(plVar3);
    uVar8 = _UNK_1036d79b0;
    if ((param_4 == 0) ||
       (uVar6 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc(param_4,0x25,0x27),
       uVar8 = _UNK_1036d79b8, lVar5 == 0)) goto LAB_101fcbaf8;
    plVar7 = *(long **)(lVar5 + 0x10);
    *(int *)(lVar5 + 0x1c) = *(int *)(lVar5 + 0x1c) + 1;
    uVar8 = _UNK_1036d79c0;
    goto joined_r0x000101fcb8b4;
  }
  uVar11 = (uint)(param_3 - param_1);
  if ((int)uVar11 < 1) {
    if ((int)uVar11 < 0) {
      iVar9 = (int)param_1;
      iVar12 = 1;
      while( true ) {
        iVar9 = iVar9 + -1;
        uVar10 = -uVar11;
        if ((int)(uVar11 & -uVar11) < 0) {
          func_0x00010034fdc0();
          uVar10 = 0x80000000;
        }
        if ((int)uVar10 < iVar12) {
          return plVar3;
        }
        lVar5 = (**(code **)(*plVar3 + 0x88))(plVar3);
        uVar8 = _UNK_1036d7988;
        if ((param_4 == 0) ||
           (uVar6 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc(param_4,iVar9,0x27),
           uVar8 = _UNK_1036d7990, lVar5 == 0)) break;
        plVar7 = *(long **)(lVar5 + 0x10);
        *(int *)(lVar5 + 0x1c) = *(int *)(lVar5 + 0x1c) + 1;
        uVar8 = _UNK_1036d7998;
        if (plVar7 == (long *)0x0) break;
        if (*(uint *)(lVar5 + 0x18) < *(uint *)(plVar7 + 3)) {
          *(uint *)(lVar5 + 0x18) = *(uint *)(lVar5 + 0x18) + 1;
          (**(code **)(*plVar7 + 0x110))();
        }
        else {
          func_0x00010037d11c(lVar5,uVar6);
        }
        if (lRam0000000103976fb8 != 0) {
          func_0x00010119b8f8();
        }
        iVar12 = iVar12 + 1;
      }
LAB_101fcbaf8:
      func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101fcbb04);
      (*pcVar2)();
    }
  }
  else {
    iVar12 = 1;
    do {
      lVar5 = (**(code **)(*plVar3 + 0x88))(plVar3);
      uVar8 = _UNK_1036d7980;
      if ((param_4 == 0) ||
         (uVar6 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                            (param_4,(int)param_1 + iVar12,0x27), uVar8 = _UNK_1036d79a0, lVar5 == 0
         )) goto LAB_101fcbaf8;
      plVar7 = *(long **)(lVar5 + 0x10);
      *(int *)(lVar5 + 0x1c) = *(int *)(lVar5 + 0x1c) + 1;
      uVar8 = _UNK_1036d79a8;
      if (plVar7 == (long *)0x0) goto LAB_101fcbaf8;
      if (*(uint *)(lVar5 + 0x18) < *(uint *)(plVar7 + 3)) {
        *(uint *)(lVar5 + 0x18) = *(uint *)(lVar5 + 0x18) + 1;
        (**(code **)(*plVar7 + 0x110))();
      }
      else {
        func_0x00010037d11c(lVar5,uVar6);
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      iVar12 = iVar12 + 1;
    } while (iVar12 <= (int)uVar11);
  }
  return plVar3;
}

