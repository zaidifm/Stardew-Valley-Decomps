/* 0x06006618 StardewValley.Mobile.AStarGraph.GetShortestPathToNeighbouringDiagonalAStarWithBubbleCheck @ 0x101fa7078 */

long SDV_StardewValley_Mobile_AStarGraph_GetShortestPathToNeighbouringDiagonalAStarWithBubbleCheck_06006618
               (undefined8 param_1,long param_2,long param_3)

{
  char cVar1;
  long lVar2;
  long lVar3;
  long lVar4;
  long lVar5;
  double dVar6;
  undefined1 auVar7 [16];
  undefined1 auVar8 [16];
  undefined1 auVar9 [16];
  undefined1 auVar10 [16];
  double dVar11;
  double dVar12;
  double dVar13;
  double dVar14;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  lVar2 = SDV_StardewValley_Mobile_AStarGraph_GetShortestPathAStarWithBubbleCheck_0600661a
                    (param_1,param_2,param_3);
  if (lVar2 != 0) {
    return lVar2;
  }
  if (*(char *)(param_3 + 0x45) == '\0') {
LAB_101fa72a4:
    lVar2 = 0;
  }
  else {
    lVar2 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                      (param_1,*(int *)(param_3 + 0x34) + -1,*(int *)(param_3 + 0x38) + -1);
    lVar3 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                      (param_1,*(int *)(param_3 + 0x34) + 1,*(int *)(param_3 + 0x38) + -1);
    lVar4 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                      (param_1,*(int *)(param_3 + 0x34) + -1,*(int *)(param_3 + 0x38) + 1);
    lVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                      (param_1,*(int *)(param_3 + 0x34) + 1,*(int *)(param_3 + 0x38) + 1);
    if (lVar2 == 0) {
      dVar6 = 1.79769313486232e+308;
      dVar11 = 1.79769313486232e+308;
      if (lVar3 != 0) goto LAB_101fa7150;
LAB_101fa71cc:
      dVar6 = 1.79769313486232e+308;
      dVar12 = 1.79769313486232e+308;
      if (lVar4 != 0) goto LAB_101fa7174;
LAB_101fa71d8:
      dVar6 = 1.79769313486232e+308;
      dVar13 = 1.79769313486232e+308;
      if (lVar5 != 0) goto LAB_101fa7198;
LAB_101fa71e4:
      dVar14 = 1.79769313486232e+308;
      dVar6 = dVar13;
      if (lVar2 == 0) goto LAB_101fa7218;
LAB_101fa71f0:
      cVar1 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(lVar2);
      dVar6 = dVar13;
      if ((((cVar1 == '\0') || (dVar12 <= dVar11)) || (dVar13 <= dVar11)) || (dVar14 <= dVar11))
      goto LAB_101fa7218;
    }
    else {
      auVar7._0_8_ = (long)((int)*(undefined8 *)(param_2 + 0x34) -
                           (int)*(undefined8 *)(lVar2 + 0x34));
      auVar7._8_8_ = (long)((int)((ulong)*(undefined8 *)(param_2 + 0x34) >> 0x20) -
                           (int)((ulong)*(undefined8 *)(lVar2 + 0x34) >> 0x20));
      auVar7 = NEON_scvtf(auVar7,8);
      dVar11 = SQRT(auVar7._0_8_ * auVar7._0_8_ + auVar7._8_8_ * auVar7._8_8_);
      dVar6 = dVar11;
      if (lVar3 == 0) goto LAB_101fa71cc;
LAB_101fa7150:
      auVar8._0_8_ = (long)((int)*(undefined8 *)(param_2 + 0x34) -
                           (int)*(undefined8 *)(lVar3 + 0x34));
      auVar8._8_8_ = (long)((int)((ulong)*(undefined8 *)(param_2 + 0x34) >> 0x20) -
                           (int)((ulong)*(undefined8 *)(lVar3 + 0x34) >> 0x20));
      auVar7 = NEON_scvtf(auVar8,8);
      dVar12 = SQRT(auVar7._0_8_ * auVar7._0_8_ + auVar7._8_8_ * auVar7._8_8_);
      dVar11 = dVar6;
      dVar6 = dVar12;
      if (lVar4 == 0) goto LAB_101fa71d8;
LAB_101fa7174:
      auVar9._0_8_ = (long)((int)*(undefined8 *)(param_2 + 0x34) -
                           (int)*(undefined8 *)(lVar4 + 0x34));
      auVar9._8_8_ = (long)((int)((ulong)*(undefined8 *)(param_2 + 0x34) >> 0x20) -
                           (int)((ulong)*(undefined8 *)(lVar4 + 0x34) >> 0x20));
      auVar7 = NEON_scvtf(auVar9,8);
      dVar13 = SQRT(auVar7._0_8_ * auVar7._0_8_ + auVar7._8_8_ * auVar7._8_8_);
      dVar12 = dVar6;
      dVar6 = dVar13;
      if (lVar5 == 0) goto LAB_101fa71e4;
LAB_101fa7198:
      auVar10._0_8_ =
           (long)((int)*(undefined8 *)(param_2 + 0x34) - (int)*(undefined8 *)(lVar5 + 0x34));
      auVar10._8_8_ =
           (long)((int)((ulong)*(undefined8 *)(param_2 + 0x34) >> 0x20) -
                 (int)((ulong)*(undefined8 *)(lVar5 + 0x34) >> 0x20));
      auVar7 = NEON_scvtf(auVar10,8);
      dVar14 = SQRT(auVar7._0_8_ * auVar7._0_8_ + auVar7._8_8_ * auVar7._8_8_);
      dVar13 = dVar6;
      if (lVar2 != 0) goto LAB_101fa71f0;
LAB_101fa7218:
      if (((((lVar3 == 0) ||
            (cVar1 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(lVar3), cVar1 == '\0'
            )) || ((dVar11 <= dVar12 || ((dVar6 <= dVar12 || (lVar2 = lVar3, dVar14 <= dVar12))))))
          && ((lVar4 == 0 ||
              ((((cVar1 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(lVar4),
                 cVar1 == '\0' || (dVar11 <= dVar6)) || (dVar12 <= dVar6)) ||
               (lVar2 = lVar4, dVar14 <= dVar6)))))) &&
         ((lVar5 == 0 ||
          (cVar1 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(lVar5), lVar2 = lVar5,
          cVar1 == '\0')))) goto LAB_101fa72a4;
    }
    lVar2 = SDV_StardewValley_Mobile_AStarGraph_GetShortestPathAStarWithBubbleCheck_0600661a
                      (param_1,param_2,lVar2);
  }
  return lVar2;
}

