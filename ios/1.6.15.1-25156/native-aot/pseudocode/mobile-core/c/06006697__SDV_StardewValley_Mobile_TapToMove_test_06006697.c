/* 0x06006697 StardewValley.Mobile.TapToMove.test @ 0x101fb152c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_test_06006697(long param_1)

{
  code *pcVar1;
  long lVar2;
  undefined8 uVar3;
  
  if (lRam0000000103976fb8 == 0) {
    lVar2 = *(long *)(param_1 + 0x28);
  }
  else {
    func_0x00010119b8f8();
    lVar2 = *(long *)(param_1 + 0x28);
  }
  uVar3 = _UNK_1036d3ba0;
  if ((lVar2 != 0) &&
     (lVar2 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc(lVar2,0x3c,0x12),
     uVar3 = _UNK_1036d3ba8, lVar2 != 0)) {
    SDV_StardewValley_Mobile_AStarNode_DebugObjectParentSheetIndexOnTile_06006642();
    SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(lVar2);
    return;
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fb15b4);
  (*pcVar1)();
}

