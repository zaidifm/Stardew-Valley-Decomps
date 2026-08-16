/* 0x0600660d StardewValley.Mobile.AStarGraph.WalkDirectionToNextNode @ 0x101fa36b4 */

int SDV_StardewValley_Mobile_AStarGraph_WalkDirectionToNextNode_0600660d
              (undefined8 param_1,long param_2,long param_3)

{
  int iVar1;
  int iVar2;
  int iVar3;
  int iVar4;
  int iVar5;
  
  iVar3 = 0;
  if ((param_2 != 0) && (param_3 != 0)) {
    iVar4 = *(int *)(param_3 + 0x34);
    iVar1 = *(int *)(param_2 + 0x34);
    iVar3 = iVar4 + 1;
    if ((iVar1 == iVar3) && (*(int *)(param_2 + 0x38) == *(int *)(param_3 + 0x38) + 1)) {
      return 5;
    }
    iVar2 = iVar4 + -1;
    if ((iVar1 == iVar2) && (*(int *)(param_2 + 0x38) == *(int *)(param_3 + 0x38) + 1)) {
      return 6;
    }
    if ((iVar1 == iVar3) && (*(int *)(param_2 + 0x38) == *(int *)(param_3 + 0x38) + -1)) {
      return 7;
    }
    if ((iVar1 == iVar2) && (*(int *)(param_2 + 0x38) == *(int *)(param_3 + 0x38) + -1)) {
      return 8;
    }
    if (iVar1 == iVar4) {
      if (*(int *)(param_2 + 0x38) == *(int *)(param_3 + 0x38) + -1) {
        return 2;
      }
      if (*(int *)(param_2 + 0x38) == *(int *)(param_3 + 0x38) + 1) {
        return 1;
      }
    }
    if (iVar1 == iVar3) {
      iVar3 = *(int *)(param_2 + 0x38);
      iVar4 = *(int *)(param_3 + 0x38);
      iVar5 = 3;
      if (iVar3 != iVar4) {
        iVar5 = 0;
      }
      if (iVar1 != iVar2) {
        return iVar5;
      }
      if (iVar3 == iVar4) {
        return iVar5;
      }
    }
    else {
      if (iVar1 != iVar2) {
        return 0;
      }
      iVar3 = *(int *)(param_2 + 0x38);
      iVar4 = *(int *)(param_3 + 0x38);
    }
    iVar3 = (uint)(iVar3 == iVar4) << 2;
  }
  return iVar3;
}

