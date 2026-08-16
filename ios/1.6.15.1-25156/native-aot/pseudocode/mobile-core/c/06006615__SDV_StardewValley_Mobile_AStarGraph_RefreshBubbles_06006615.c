/* 0x06006615 StardewValley.Mobile.AStarGraph.RefreshBubbles @ 0x101fa69b0 */

void SDV_StardewValley_Mobile_AStarGraph_RefreshBubbles_06006615(undefined8 param_1)

{
  char cVar1;
  long lVar2;
  
  cVar1 = cRam0000000103911424;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103324a17);
    cRam0000000103911424 = '\x01';
  }
  SDV_StardewValley_Mobile_AStarGraph_ResetBubbles_06006616(param_1,1,1);
  lVar2 = SDV_StardewValley_Mobile_AStarGraph_get_FarmerAStarNode_060065fd(param_1);
  if ((lVar2 != 0) &&
     (lVar2 = SDV_StardewValley_Mobile_AStarGraph_get_FarmerAStarNodeOffset_060065fe(param_1),
     lVar2 != 0)) {
    SDV_StardewValley_Mobile_AStarNode_SetBubbleIDRecursively_0600662c(lVar2,0,0);
  }
  return;
}

