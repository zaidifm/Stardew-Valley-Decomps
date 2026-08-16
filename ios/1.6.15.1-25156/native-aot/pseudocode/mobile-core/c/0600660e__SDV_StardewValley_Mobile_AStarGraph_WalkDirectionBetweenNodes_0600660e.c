/* 0x0600660e StardewValley.Mobile.AStarGraph.WalkDirectionBetweenNodes @ 0x101fa37f0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined4
SDV_StardewValley_Mobile_AStarGraph_WalkDirectionBetweenNodes_0600660e
          (undefined8 param_1,long param_2,long param_3)

{
  int iVar1;
  int iVar2;
  code *pcVar3;
  undefined8 uVar4;
  undefined4 uVar5;
  
  uVar4 = _UNK_1036d19f8;
  if ((param_2 == 0) || (uVar4 = _UNK_1036d1a00, param_3 == 0)) {
    func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
    pcVar3 = (code *)SoftwareBreakpoint(1,0x101fa391c);
    (*pcVar3)();
  }
  iVar1 = *(int *)(param_2 + 0x34);
  iVar2 = *(int *)(param_3 + 0x34);
  if ((iVar2 < iVar1) && (*(int *)(param_3 + 0x38) < *(int *)(param_2 + 0x38))) {
    return 5;
  }
  if ((iVar1 < iVar2) && (*(int *)(param_3 + 0x38) < *(int *)(param_2 + 0x38))) {
    return 6;
  }
  if ((iVar2 < iVar1) && (*(int *)(param_2 + 0x38) < *(int *)(param_3 + 0x38))) {
    return 7;
  }
  if ((iVar1 < iVar2) && (*(int *)(param_2 + 0x38) < *(int *)(param_3 + 0x38))) {
    return 8;
  }
  if (iVar1 == iVar2) {
    if (*(int *)(param_2 + 0x38) < *(int *)(param_3 + 0x38)) {
      return 2;
    }
    if (*(int *)(param_3 + 0x38) < *(int *)(param_2 + 0x38)) {
      return 1;
    }
  }
  if (iVar1 != iVar2) {
    uVar5 = 3;
    if (iVar1 <= iVar2) {
      uVar5 = 4;
    }
    if (*(int *)(param_2 + 0x38) != *(int *)(param_3 + 0x38)) {
      uVar5 = 0;
    }
    return uVar5;
  }
  return 0;
}

