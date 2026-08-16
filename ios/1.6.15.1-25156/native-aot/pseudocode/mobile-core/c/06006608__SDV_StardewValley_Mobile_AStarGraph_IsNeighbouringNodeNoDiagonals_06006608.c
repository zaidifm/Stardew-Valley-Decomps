/* 0x06006608 StardewValley.Mobile.AStarGraph.IsNeighbouringNodeNoDiagonals @ 0x101fa3498 */

bool SDV_StardewValley_Mobile_AStarGraph_IsNeighbouringNodeNoDiagonals_06006608
               (undefined8 param_1,long param_2,long param_3)

{
  int iVar1;
  int iVar2;
  int iVar3;
  int iVar4;
  bool bVar5;
  
  bVar5 = false;
  if ((param_2 != 0) && (param_3 != 0)) {
    iVar1 = *(int *)(param_2 + 0x34);
    iVar3 = *(int *)(param_2 + 0x38);
    iVar2 = *(int *)(param_3 + 0x34);
    iVar4 = *(int *)(param_3 + 0x38);
    if ((iVar2 != iVar1) || ((bVar5 = true, iVar4 != iVar3 + 1 && (iVar4 != iVar3 + -1)))) {
      if (iVar4 != iVar3) {
        return false;
      }
      if (iVar2 == iVar1 + 1) {
        return true;
      }
      bVar5 = iVar2 == iVar1 + -1;
    }
  }
  return bVar5;
}

