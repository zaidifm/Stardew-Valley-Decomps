/* 0x06006609 StardewValley.Mobile.AStarGraph.IsNeighbouringNodeOnDiagonal @ 0x101fa3504 */

bool SDV_StardewValley_Mobile_AStarGraph_IsNeighbouringNodeOnDiagonal_06006609
               (undefined8 param_1,long param_2,long param_3)

{
  bool bVar1;
  
  bVar1 = false;
  if ((param_2 != 0) && (param_3 != 0)) {
    if ((*(int *)(param_3 + 0x34) != *(int *)(param_2 + 0x34) + -1) &&
       (*(int *)(param_3 + 0x34) != *(int *)(param_2 + 0x34) + 1)) {
      return false;
    }
    if (*(int *)(param_3 + 0x38) == *(int *)(param_2 + 0x38) + -1) {
      return true;
    }
    bVar1 = *(int *)(param_3 + 0x38) == *(int *)(param_2 + 0x38) + 1;
  }
  return bVar1;
}

