/* 0x06006713 StardewValley.Mobile.TapToMoveUtils.FetchAStarNodeNearestWaterSource @ 0x101fcea78 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_TapToMoveUtils_FetchAStarNodeNearestWaterSource_06006713
          (long param_1,long param_2)

{
  int iVar1;
  int iVar2;
  int iVar3;
  code *pcVar4;
  bool bVar5;
  char cVar6;
  long lVar7;
  long lVar8;
  long *plVar9;
  undefined8 uVar10;
  float fVar11;
  uint uVar12;
  uint uVar13;
  int iVar14;
  uint uVar15;
  float fVar16;
  
  cVar6 = cRam0000000103911522;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar6 == '\0') {
    func_0x00010119b908(&UNK_103325b00);
    cRam0000000103911522 = '\x01';
  }
  lVar7 = func_0x000100331820(uRam00000001039045a8,0x20);
  lVar8 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar7 + 0x10) = *puRam00000001039045b0;
  *(undefined1 *)(((ulong)(lVar7 + 0x10) >> 9 & 0x7fffff) + lVar8) = 1;
  uVar10 = _UNK_1036d7ee0;
  if ((param_2 == 0) || (uVar10 = _UNK_1036d7ee8, param_1 == 0)) {
LAB_101fcef10:
    func_0x0001003316f4(0xee,uVar10);
                    /* WARNING: Does not return */
    pcVar4 = (code *)SoftwareBreakpoint(1,0x101fcef1c);
    (*pcVar4)();
  }
  uVar12 = 1;
  iVar14 = -1;
  do {
    lVar8 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                      (param_1,uVar12 + *(int *)(param_2 + 0x34),*(undefined4 *)(param_2 + 0x38));
    if (((lVar8 != 0) &&
        (cVar6 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(), cVar6 != '\0')) &&
       (cVar6 = SDV_StardewValley_Mobile_TapToMoveUtils_IsWateringCanFillingSource_060066ef
                          ((float)*(int *)(lVar8 + 0x34),(float)*(int *)(lVar8 + 0x38)),
       cVar6 == '\0')) {
      plVar9 = *(long **)(lVar7 + 0x10);
      *(int *)(lVar7 + 0x1c) = *(int *)(lVar7 + 0x1c) + 1;
      uVar10 = _UNK_1036d7f38;
      if (plVar9 == (long *)0x0) goto LAB_101fcef10;
      uVar15 = *(uint *)(lVar7 + 0x18);
      if (uVar15 < *(uint *)(plVar9 + 3)) {
        *(uint *)(lVar7 + 0x18) = uVar15 + 1;
        (**(code **)(*plVar9 + 0x110))(plVar9,(long)(int)uVar15,lVar8);
      }
      else {
        func_0x00010037d11c(lVar7,lVar8);
      }
    }
    lVar8 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                      (param_1,iVar14 + *(int *)(param_2 + 0x34),*(undefined4 *)(param_2 + 0x38));
    if (((lVar8 != 0) &&
        (cVar6 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(), cVar6 != '\0')) &&
       (cVar6 = SDV_StardewValley_Mobile_TapToMoveUtils_IsWateringCanFillingSource_060066ef
                          ((float)*(int *)(lVar8 + 0x34),(float)*(int *)(lVar8 + 0x38)),
       cVar6 == '\0')) {
      plVar9 = *(long **)(lVar7 + 0x10);
      *(int *)(lVar7 + 0x1c) = *(int *)(lVar7 + 0x1c) + 1;
      uVar10 = _UNK_1036d7f30;
      if (plVar9 == (long *)0x0) goto LAB_101fcef10;
      uVar15 = *(uint *)(lVar7 + 0x18);
      if (uVar15 < *(uint *)(plVar9 + 3)) {
        *(uint *)(lVar7 + 0x18) = uVar15 + 1;
        (**(code **)(*plVar9 + 0x110))(plVar9,(long)(int)uVar15,lVar8);
      }
      else {
        func_0x00010037d11c(lVar7,lVar8);
      }
    }
    lVar8 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                      (param_1,*(undefined4 *)(param_2 + 0x34),uVar12 + *(int *)(param_2 + 0x38));
    if (((lVar8 != 0) &&
        (cVar6 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(), cVar6 != '\0')) &&
       (cVar6 = SDV_StardewValley_Mobile_TapToMoveUtils_IsWateringCanFillingSource_060066ef
                          ((float)*(int *)(lVar8 + 0x34),(float)*(int *)(lVar8 + 0x38)),
       cVar6 == '\0')) {
      plVar9 = *(long **)(lVar7 + 0x10);
      *(int *)(lVar7 + 0x1c) = *(int *)(lVar7 + 0x1c) + 1;
      uVar10 = _UNK_1036d7f28;
      if (plVar9 == (long *)0x0) goto LAB_101fcef10;
      uVar15 = *(uint *)(lVar7 + 0x18);
      if (uVar15 < *(uint *)(plVar9 + 3)) {
        *(uint *)(lVar7 + 0x18) = uVar15 + 1;
        (**(code **)(*plVar9 + 0x110))(plVar9,(long)(int)uVar15,lVar8);
      }
      else {
        func_0x00010037d11c(lVar7,lVar8);
      }
    }
    lVar8 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                      (param_1,*(undefined4 *)(param_2 + 0x34),iVar14 + *(int *)(param_2 + 0x38));
    if (((lVar8 != 0) &&
        (cVar6 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(), cVar6 != '\0')) &&
       (cVar6 = SDV_StardewValley_Mobile_TapToMoveUtils_IsWateringCanFillingSource_060066ef
                          ((float)*(int *)(lVar8 + 0x34),(float)*(int *)(lVar8 + 0x38)),
       cVar6 == '\0')) {
      plVar9 = *(long **)(lVar7 + 0x10);
      *(int *)(lVar7 + 0x1c) = *(int *)(lVar7 + 0x1c) + 1;
      uVar10 = _UNK_1036d7f20;
      if (plVar9 == (long *)0x0) goto LAB_101fcef10;
      uVar15 = *(uint *)(lVar7 + 0x18);
      if (uVar15 < *(uint *)(plVar9 + 3)) {
        *(uint *)(lVar7 + 0x18) = uVar15 + 1;
        (**(code **)(*plVar9 + 0x110))(plVar9,(long)(int)uVar15,lVar8);
      }
      else {
        func_0x00010037d11c(lVar7,lVar8);
      }
    }
    uVar15 = *(uint *)(lVar7 + 0x18);
    bVar5 = uVar12 < 0x1d;
    if (lRam0000000103976fb8 != 0) {
      func_0x00010119b8f8();
    }
    iVar14 = iVar14 + -1;
    uVar12 = uVar12 + 1;
  } while ((int)uVar15 < 1 && bVar5);
  if (uVar15 == 0) {
    uVar10 = 0;
  }
  else {
    if ((int)uVar15 < 2) {
      uVar12 = 0;
    }
    else {
      uVar12 = 0;
      uVar13 = 1;
      lVar8 = 0x28;
      fVar11 = 3.4028235e+38;
      do {
        SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
        if (*(uint *)(lVar7 + 0x18) <= uVar13) goto LAB_101fceeb0;
        uVar10 = _UNK_1036d7ef8;
        if (*(uint *)(*(long *)(lVar7 + 0x10) + 0x18) <= uVar13) goto LAB_101fceecc;
        uVar10 = _UNK_1036d7f00;
        if (*(long *)(lVar8 + *(long *)(lVar7 + 0x10)) == 0) goto LAB_101fcef10;
        fVar16 = (float)func_0x000100354758();
        uVar15 = *(uint *)(lVar7 + 0x18);
        if (fVar16 < fVar11) {
          uVar12 = uVar13;
          fVar11 = fVar16;
        }
        if (lRam0000000103976fb8 != 0) {
          func_0x00010119b8f8();
        }
        uVar13 = uVar13 + 1;
        lVar8 = lVar8 + 8;
      } while ((int)uVar13 < (int)uVar15);
    }
    if (uVar15 <= uVar12) {
LAB_101fceeb0:
      func_0x000100331b90();
                    /* WARNING: Does not return */
      pcVar4 = (code *)SoftwareBreakpoint(1,0x101fceeb8);
      (*pcVar4)();
    }
    uVar10 = _UNK_1036d7f10;
    if (*(uint *)(*(long *)(lVar7 + 0x10) + 0x18) <= uVar12) {
LAB_101fceecc:
      func_0x0001003316f4(0xcc,uVar10);
                    /* WARNING: Does not return */
      pcVar4 = (code *)SoftwareBreakpoint(1,0x101fceed8);
      (*pcVar4)();
    }
    lVar8 = *(long *)(*(long *)(lVar7 + 0x10) + (long)(int)uVar12 * 8 + 0x20);
    iVar2 = *(int *)(lVar8 + 0x34);
    iVar14 = *(int *)(param_2 + 0x34);
    iVar1 = *(int *)(param_2 + 0x38);
    if (iVar2 == iVar14) {
      iVar2 = *(int *)(lVar8 + 0x38);
      iVar3 = iVar2 + -1;
      if (iVar2 <= iVar1) {
        iVar3 = iVar2 + 1;
      }
    }
    else {
      bVar5 = iVar2 <= iVar14;
      iVar14 = iVar2 + -1;
      iVar3 = iVar1;
      if (bVar5) {
        iVar14 = iVar2 + 1;
      }
    }
    uVar10 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc(param_1,iVar14,iVar3);
  }
  return uVar10;
}

