/* 0x06006714 StardewValley.Mobile.TapToMoveUtils.FetchNearestAStarLandNodePerpendicularToWaterSource @ 0x101fcef58 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_Mobile_TapToMoveUtils_FetchNearestAStarLandNodePerpendicularToWaterSource_06006714
               (long param_1,long param_2,long param_3)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  long lVar4;
  undefined8 uVar5;
  int iVar6;
  int iVar7;
  int iVar8;
  int iVar9;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar5 = _UNK_1036d7f40;
  if ((param_2 == 0) || (uVar5 = _UNK_1036d7f48, param_3 == 0)) goto LAB_101fcf25c;
  iVar8 = *(int *)(param_2 + 0x34);
  iVar9 = *(int *)(param_3 + 0x34);
  if (iVar9 == iVar8) {
LAB_101fcefa0:
    iVar9 = *(int *)(param_3 + 0x38);
    if (*(int *)(param_2 + 0x38) < iVar9) {
      uVar5 = _UNK_1036d7f58;
      lVar4 = param_3;
      if (param_1 == 0) {
LAB_101fcf25c:
        func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcf268);
        (*pcVar1)();
      }
      do {
        lVar3 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                          (param_1,*(undefined4 *)(param_3 + 0x34),iVar9);
        if (((lVar3 != 0) &&
            (cVar2 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(lVar3), cVar2 != '\0'
            )) && (cVar2 = SDV_StardewValley_Mobile_TapToMoveUtils_IsWateringCanFillingSource_060066ef
                                     ((float)*(int *)(lVar3 + 0x34),(float)*(int *)(lVar3 + 0x38)),
                  cVar2 == '\0')) {
          return lVar4;
        }
        iVar9 = iVar9 + -1;
        iVar8 = *(int *)(param_2 + 0x38);
        if (lRam0000000103976fb8 != 0) {
          func_0x00010119b8f8();
        }
        lVar4 = lVar3;
      } while (iVar8 <= iVar9);
    }
    else {
      uVar5 = _UNK_1036d7f50;
      lVar4 = param_3;
      if (param_1 == 0) goto LAB_101fcf25c;
      do {
        lVar3 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                          (param_1,*(undefined4 *)(param_3 + 0x34),iVar9);
        if (((lVar3 != 0) &&
            (cVar2 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(lVar3), cVar2 != '\0'
            )) && (cVar2 = SDV_StardewValley_Mobile_TapToMoveUtils_IsWateringCanFillingSource_060066ef
                                     ((float)*(int *)(lVar3 + 0x34),(float)*(int *)(lVar3 + 0x38)),
                  cVar2 == '\0')) {
          return lVar4;
        }
        iVar8 = *(int *)(param_2 + 0x38);
        if (lRam0000000103976fb8 != 0) {
          func_0x00010119b8f8();
        }
        iVar9 = iVar9 + 1;
        lVar4 = lVar3;
      } while (iVar9 <= iVar8);
    }
  }
  else {
    iVar7 = *(int *)(param_2 + 0x38);
    iVar6 = *(int *)(param_3 + 0x38);
    if (iVar7 != iVar6) {
      iVar9 = iVar9 - iVar8;
      if ((iVar9 < 0) && (iVar9 = -iVar9, iVar9 < 0)) {
        func_0x00010034fdc0();
        iVar6 = *(int *)(param_3 + 0x38);
        iVar9 = -0x80000000;
        iVar7 = *(int *)(param_2 + 0x38);
      }
      iVar6 = iVar6 - iVar7;
      if ((iVar6 < 0) && (iVar6 = -iVar6, iVar6 < 0)) {
        func_0x00010034fdc0();
        iVar6 = -0x80000000;
      }
      if (iVar6 < iVar9) goto LAB_101fcefa0;
      iVar9 = *(int *)(param_3 + 0x34);
      iVar8 = *(int *)(param_2 + 0x34);
    }
    if (iVar8 < iVar9) {
      uVar5 = _UNK_1036d7f68;
      lVar4 = param_3;
      if (param_1 == 0) goto LAB_101fcf25c;
      do {
        lVar3 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                          (param_1,iVar9,*(undefined4 *)(param_3 + 0x38));
        if (((lVar3 != 0) &&
            (cVar2 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(lVar3), cVar2 != '\0'
            )) && (cVar2 = SDV_StardewValley_Mobile_TapToMoveUtils_IsWateringCanFillingSource_060066ef
                                     ((float)*(int *)(lVar3 + 0x34),(float)*(int *)(lVar3 + 0x38)),
                  cVar2 == '\0')) {
          return lVar4;
        }
        iVar9 = iVar9 + -1;
        iVar8 = *(int *)(param_2 + 0x34);
        if (lRam0000000103976fb8 != 0) {
          func_0x00010119b8f8();
        }
        lVar4 = lVar3;
      } while (iVar8 <= iVar9);
    }
    else {
      uVar5 = _UNK_1036d7f60;
      lVar4 = param_3;
      if (param_1 == 0) goto LAB_101fcf25c;
      do {
        lVar3 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                          (param_1,iVar9,*(undefined4 *)(param_3 + 0x38));
        if (((lVar3 != 0) &&
            (cVar2 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(lVar3), cVar2 != '\0'
            )) && (cVar2 = SDV_StardewValley_Mobile_TapToMoveUtils_IsWateringCanFillingSource_060066ef
                                     ((float)*(int *)(lVar3 + 0x34),(float)*(int *)(lVar3 + 0x38)),
                  cVar2 == '\0')) {
          return lVar4;
        }
        iVar8 = *(int *)(param_2 + 0x34);
        if (lRam0000000103976fb8 != 0) {
          func_0x00010119b8f8();
        }
        iVar9 = iVar9 + 1;
        lVar4 = lVar3;
      } while (iVar9 <= iVar8);
    }
  }
  lVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_FetchAStarNodeNearestWaterSource_06006713
                    (param_1,param_3);
  if (lVar4 == 0) {
    lVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_FetchAStarNodeNearestWaterSource_06006713
                      (param_1,param_2);
  }
  return lVar4;
}

