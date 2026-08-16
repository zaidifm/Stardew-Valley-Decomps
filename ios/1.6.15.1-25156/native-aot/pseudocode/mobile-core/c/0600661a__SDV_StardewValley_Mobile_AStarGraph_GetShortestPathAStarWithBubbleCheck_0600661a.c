/* 0x0600661a StardewValley.Mobile.AStarGraph.GetShortestPathAStarWithBubbleCheck @ 0x101fa733c */

undefined8
SDV_StardewValley_Mobile_AStarGraph_GetShortestPathAStarWithBubbleCheck_0600661a
          (undefined8 param_1,long param_2,long param_3)

{
  char cVar1;
  undefined8 uVar2;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (param_2 == 0 || param_3 == 0) {
LAB_101fa73fc:
    uVar2 = 0;
  }
  else {
    if ((*(int *)(param_3 + 0x3c) != 0) &&
       ((*(undefined4 *)(param_2 + 0x3c) = 0, *(int *)(param_3 + 0x3c) != -1 ||
        (cVar1 = SDV_StardewValley_Mobile_AStarGraph_PathBetweenNodesExists_0600661b
                           (param_1,param_2,param_3), cVar1 == '\0')))) {
      SDV_StardewValley_Mobile_AStarGraph_ResetBubbles_06006616(param_1,0,1);
      SDV_StardewValley_Mobile_AStarNode_SetBubbleIDRecursively_0600662c(param_3,0,1);
      if (*(int *)(param_2 + 0x40) != *(int *)(param_3 + 0x40)) goto LAB_101fa73fc;
      SDV_StardewValley_Mobile_AStarGraph_mergeBubbleID2IntoBubbleID_06006617(param_1);
    }
    uVar2 = SDV_StardewValley_Mobile_AStarGraph_GetShortestPathAStar_06006603
                      (param_1,param_2,param_3);
  }
  return uVar2;
}

