/* 0x06006643 StardewValley.Mobile.AStarNode.isTilePassable @ 0x101fa9730 */

void SDV_StardewValley_Mobile_AStarNode_isTilePassable_06006643(long param_1)

{
  long lVar1;
  
  if (lRam0000000103976fb8 == 0) {
    lVar1 = *(long *)(param_1 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    lVar1 = *(long *)(param_1 + 0x18);
  }
  SDV_StardewValley_Mobile_TapToMoveUtils_IsTilePassable_060066ee
            (*(undefined8 *)(lVar1 + 0x10),*(undefined4 *)(param_1 + 0x34),
             *(undefined4 *)(param_1 + 0x38));
  return;
}

