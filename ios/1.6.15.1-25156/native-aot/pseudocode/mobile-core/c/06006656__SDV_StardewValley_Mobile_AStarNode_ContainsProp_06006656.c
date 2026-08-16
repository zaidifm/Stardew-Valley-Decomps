/* 0x06006656 StardewValley.Mobile.AStarNode.ContainsProp @ 0x101fad38c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Mobile_AStarNode_ContainsProp_06006656(long param_1)

{
  code *pcVar1;
  long lVar2;
  long *plVar3;
  uint uVar4;
  float fVar5;
  float fVar6;
  
  if (lRam0000000103976fb8 == 0) {
    lVar2 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
  }
  else {
    func_0x00010119b8f8();
    lVar2 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
  }
  if (lVar2 == 0) {
    return 0;
  }
  lVar2 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
  if (lVar2 != 0) {
    uVar4 = 0;
    do {
      if (*(int *)(*(long *)(lVar2 + 0x88) + 0x18) <= (int)uVar4) {
        return 0;
      }
      lVar2 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
      if (*(uint *)(*(long *)(lVar2 + 0x88) + 0x18) <= uVar4) {
        func_0x000100331b90();
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fad4bc);
        (*pcVar1)();
      }
      lVar2 = *(long *)(*(long *)(lVar2 + 0x88) + 0x10);
      if (*(uint *)(lVar2 + 0x18) <= uVar4) {
        func_0x0001003316f4(0xcc,_UNK_1036d3480);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fad4dc);
        (*pcVar1)();
      }
      plVar3 = *(long **)(lVar2 + (long)(int)uVar4 * 8 + 0x20);
      fVar5 = (float)(**(code **)(*plVar3 + 0x5f8))(plVar3);
      fVar6 = (float)*(int *)(param_1 + 0x34);
      if ((fVar5 == fVar6) &&
         ((**(code **)(*plVar3 + 0x5f8))(plVar3), fVar6 == (float)*(int *)(param_1 + 0x38))) {
        return 1;
      }
      lVar2 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      uVar4 = uVar4 + 1;
    } while (lVar2 != 0);
  }
  func_0x0001003316f4(0xee,_UNK_1036d3450);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fad508);
  (*pcVar1)();
}

