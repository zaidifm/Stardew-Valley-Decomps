/* 0x060065fc StardewValley.Mobile.AStarGraph.FetchAStarNode @ 0x101fa170c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc(long param_1,uint param_2,uint param_3)

{
  code *pcVar1;
  int iVar2;
  undefined8 uVar3;
  int *piVar4;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if ((int)param_2 < 0) {
    return 0;
  }
  uVar3 = _UNK_1036d16d0;
  if (*(long *)(param_1 + 0x20) != 0) {
    iVar2 = func_0x0001003324b4(*(long *)(param_1 + 0x20),0);
    if (iVar2 <= (int)param_2) {
      return 0;
    }
    if ((int)param_3 < 0) {
      return 0;
    }
    uVar3 = _UNK_1036d16d8;
    if (*(long *)(param_1 + 0x20) != 0) {
      iVar2 = func_0x0001003324b4(*(long *)(param_1 + 0x20),1);
      if (iVar2 <= (int)param_3) {
        return 0;
      }
      piVar4 = *(int **)(*(long *)(param_1 + 0x20) + 0x10);
      uVar3 = _UNK_1036d16e8;
      if ((ulong)param_2 - (long)piVar4[1] < (ulong)(long)*piVar4) {
        uVar3 = _UNK_1036d16f0;
        if ((ulong)param_3 - (long)piVar4[3] < (ulong)(long)piVar4[2]) {
          return *(undefined8 *)
                  (*(long *)(param_1 + 0x20) +
                   (((ulong)param_3 - (long)piVar4[3]) +
                   ((ulong)param_2 - (long)piVar4[1]) * (long)piVar4[2]) * 8 + 0x20);
        }
      }
      func_0x0001003316f4(0xcc,uVar3);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101fa1828);
      (*pcVar1)();
    }
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fa1808);
  (*pcVar1)();
}

