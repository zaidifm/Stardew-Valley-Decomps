/* 0x06007426 StardewValley.Mobile.AStarGraph+<>c__DisplayClass14_0.<GetShortestPathDijkstra>b__0 @ 0x1020b49d4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_AStarGraph_c_DisplayClass14_0_GetShortestPathDijkstra_b_0_06007426
               (long param_1,undefined8 param_2)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  
  cVar1 = cRam0000000103912235;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_10333042b);
    cRam0000000103912235 = '\x01';
    lVar3 = *(long *)(param_1 + 0x10);
  }
  else {
    lVar3 = *(long *)(param_1 + 0x10);
  }
  if (lVar3 != 0) {
    func_0x00010037d1e4(lVar3,param_2);
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036ef778);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x1020b4a70);
  (*pcVar2)();
}

