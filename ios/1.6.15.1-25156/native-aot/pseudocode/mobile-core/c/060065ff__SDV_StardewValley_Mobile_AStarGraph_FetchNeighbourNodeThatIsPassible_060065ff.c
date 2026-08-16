/* 0x060065ff StardewValley.Mobile.AStarGraph.FetchNeighbourNodeThatIsPassible @ 0x101fa1a20 */

long SDV_StardewValley_Mobile_AStarGraph_FetchNeighbourNodeThatIsPassible_060065ff
               (undefined8 param_1,int param_2,int param_3)

{
  char cVar1;
  long lVar2;
  long lVar3;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  lVar2 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc(param_1,param_2 + 1,param_3);
  if (((((lVar2 == 0) ||
        (cVar1 = SDV_StardewValley_Mobile_AStarNode_isTilePassable_06006643(), cVar1 == '\0')) ||
       (cVar1 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(lVar2), cVar1 == '\0')) &&
      (((lVar2 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                           (param_1,param_2 + -1,param_3), lVar2 == 0 ||
        (cVar1 = SDV_StardewValley_Mobile_AStarNode_isTilePassable_06006643(), cVar1 == '\0')) ||
       (cVar1 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(lVar2), cVar1 == '\0'))))
     && (((lVar2 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                             (param_1,param_2,param_3 + 1), lVar2 == 0 ||
          (cVar1 = SDV_StardewValley_Mobile_AStarNode_isTilePassable_06006643(), cVar1 == '\0')) ||
         (cVar1 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(lVar2), cVar1 == '\0')))
     ) {
    lVar3 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                      (param_1,param_2,param_3 + -1);
    if ((lVar3 == 0) ||
       (cVar1 = SDV_StardewValley_Mobile_AStarNode_isTilePassable_06006643(), cVar1 == '\0')) {
      lVar2 = 0;
    }
    else {
      cVar1 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(lVar3);
      lVar2 = 0;
      if (cVar1 != '\0') {
        lVar2 = lVar3;
      }
    }
  }
  return lVar2;
}

