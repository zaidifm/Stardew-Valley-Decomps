/* 0x0600660a StardewValley.Mobile.AStarGraph.IsSameNode @ 0x101fa3564 */

bool SDV_StardewValley_Mobile_AStarGraph_IsSameNode_0600660a
               (undefined8 param_1,long param_2,long param_3)

{
  bool bVar1;
  
  bVar1 = false;
  if ((param_2 != 0) && (param_3 != 0)) {
    if (*(int *)(param_3 + 0x34) != *(int *)(param_2 + 0x34)) {
      return false;
    }
    bVar1 = *(int *)(param_3 + 0x38) == *(int *)(param_2 + 0x38);
  }
  return bVar1;
}

