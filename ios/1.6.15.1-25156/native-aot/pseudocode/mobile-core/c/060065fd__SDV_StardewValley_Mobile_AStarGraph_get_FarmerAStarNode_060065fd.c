/* 0x060065fd StardewValley.Mobile.AStarGraph.get_FarmerAStarNode @ 0x101fa1828 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_AStarGraph_get_FarmerAStarNode_060065fd(undefined8 param_1)

{
  code *pcVar1;
  long lVar2;
  undefined8 uVar3;
  float fVar4;
  float fVar5;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  lVar2 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar3 = _UNK_1036d1700;
  if (*(long *)(lVar2 + 0x20) != 0) {
    fVar4 = (float)func_0x000101b4d600();
    lVar2 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar3 = _UNK_1036d1710;
    if (*(long *)(lVar2 + 0x20) != 0) {
      fVar5 = (float)func_0x000101b4d714();
      SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                (param_1,(int)(fVar4 * 0.015625),(int)(fVar5 * 0.015625));
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fa18e0);
  (*pcVar1)();
}

