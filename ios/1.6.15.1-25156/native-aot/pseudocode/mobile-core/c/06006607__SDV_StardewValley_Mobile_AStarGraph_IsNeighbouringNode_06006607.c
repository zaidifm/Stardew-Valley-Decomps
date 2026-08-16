/* 0x06006607 StardewValley.Mobile.AStarGraph.IsNeighbouringNode @ 0x101fa33f0 */

bool SDV_StardewValley_Mobile_AStarGraph_IsNeighbouringNode_06006607
               (undefined8 param_1,long param_2,long param_3)

{
  int iVar1;
  int iVar2;
  int iVar3;
  int iVar4;
  bool bVar5;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  bVar5 = false;
  if (param_2 != 0 && param_3 != 0) {
    bVar5 = false;
    iVar1 = *(int *)(param_2 + 0x34);
    iVar2 = *(int *)(param_3 + 0x34);
    if ((iVar1 + -1 <= iVar2) && (iVar2 <= iVar1 + 1)) {
      iVar3 = *(int *)(param_2 + 0x38);
      bVar5 = false;
      iVar4 = *(int *)(param_3 + 0x38);
      if ((iVar3 + -1 <= iVar4) && (iVar4 <= iVar3 + 1)) {
        bVar5 = iVar2 != iVar1 || iVar4 != iVar3;
      }
    }
  }
  return bVar5;
}

