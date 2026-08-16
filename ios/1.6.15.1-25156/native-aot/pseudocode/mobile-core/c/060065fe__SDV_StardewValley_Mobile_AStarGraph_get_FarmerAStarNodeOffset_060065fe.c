/* 0x060065fe StardewValley.Mobile.AStarGraph.get_FarmerAStarNodeOffset @ 0x101fa18e0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_Mobile_AStarGraph_get_FarmerAStarNodeOffset_060065fe(undefined8 param_1)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  undefined8 *puVar4;
  undefined8 uVar5;
  int iVar6;
  int iVar7;
  float fVar8;
  float fVar9;
  
  cVar1 = cRam000000010391140d;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103324901);
    cRam000000010391140d = '\x01';
  }
  lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar5 = _UNK_1036d1720;
  if (*(long *)(lVar3 + 0x20) != 0) {
    fVar8 = (float)func_0x000101b4d600();
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar5 = _UNK_1036d1730;
    if (*(long *)(lVar3 + 0x20) != 0) {
      fVar9 = (float)func_0x000101b4d714();
      iVar7 = (int)((fVar8 + 32.0) * 0.015625);
      iVar6 = (int)((fVar9 + 32.0) * 0.015625);
      lVar3 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc(param_1,iVar7,iVar6);
      if (lVar3 == 0) {
        puVar4 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
        lVar3 = 0;
        if (puVar4 != (undefined8 *)0x0) {
          if (lRam00000001038c6c50 == *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x18)) {
            lVar3 = SDV_StardewValley_Mobile_AStarGraph_FetchNeighbourNodeThatIsPassible_060065ff
                              (param_1,iVar7,iVar6);
          }
          else {
            lVar3 = 0;
          }
        }
      }
      return lVar3;
    }
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fa1a20);
  (*pcVar2)();
}

