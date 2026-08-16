/* 0x0600661b StardewValley.Mobile.AStarGraph.PathBetweenNodesExists @ 0x101fa7410 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_AStarGraph_PathBetweenNodesExists_0600661b
               (undefined8 param_1,long param_2,long param_3)

{
  code *pcVar1;
  long lVar2;
  undefined8 uVar3;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar3 = _UNK_1036d2830;
  if ((param_2 == 0) || (uVar3 = _UNK_1036d2838, param_3 == 0)) {
    func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101fa7538);
    (*pcVar1)();
  }
  if (*(int *)(param_2 + 0x3c) != *(int *)(param_3 + 0x3c)) {
    if ((*(int *)(param_3 + 0x3c) != -1) || (*(char *)(param_3 + 0x45) == '\0')) {
      return false;
    }
    lVar2 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                      (param_1,*(int *)(param_3 + 0x34) + -1,*(undefined4 *)(param_3 + 0x38));
    if ((((lVar2 == 0) || (*(int *)(lVar2 + 0x3c) != *(int *)(param_2 + 0x3c))) &&
        ((lVar2 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                            (param_1,*(int *)(param_3 + 0x34) + 1,*(undefined4 *)(param_3 + 0x38)),
         lVar2 == 0 || (*(int *)(lVar2 + 0x3c) != *(int *)(param_2 + 0x3c))))) &&
       ((lVar2 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                           (param_1,*(undefined4 *)(param_3 + 0x34),*(int *)(param_3 + 0x38) + -1),
        lVar2 == 0 || (*(int *)(lVar2 + 0x3c) != *(int *)(param_2 + 0x3c))))) {
      lVar2 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                        (param_1,*(undefined4 *)(param_3 + 0x34),*(int *)(param_3 + 0x38) + 1);
      if (lVar2 == 0) {
        return false;
      }
      return *(int *)(lVar2 + 0x3c) == *(int *)(param_2 + 0x3c);
    }
  }
  return true;
}

