/* 0x060066bc StardewValley.Mobile.TapToMove.IsObjectBlockingMonster @ 0x101fc4ce8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_TapToMove_IsObjectBlockingMonster_060066bc(long param_1,long param_2)

{
  code *pcVar1;
  char cVar2;
  int iVar3;
  int iVar4;
  long lVar5;
  long lVar6;
  undefined8 uVar7;
  int iVar8;
  int iVar9;
  long *plStack_38;
  
  cVar2 = cRam00000001039114cb;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1033256c8);
    cRam00000001039114cb = '\x01';
  }
  plStack_38 = (long *)0x0;
  lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar7 = _UNK_1036d6ca0;
  if (lVar5 == 0) goto LAB_101fc4f50;
  iVar3 = StardewValley_StardewValley_Character_get_StandingPixel_06003255();
  iVar9 = iVar3 + 0x3f;
  if (-1 < iVar3) {
    iVar9 = iVar3;
  }
  uVar7 = _UNK_1036d6ca8;
  if (param_2 == 0) goto LAB_101fc4f50;
  iVar9 = iVar9 >> 6;
  iVar4 = StardewValley_StardewValley_Character_get_StandingPixel_06003255(param_2);
  iVar3 = iVar4 + 0x3f;
  if (-1 < iVar4) {
    iVar3 = iVar4;
  }
  iVar4 = iVar9 - (iVar3 >> 6);
  iVar3 = -iVar4;
  if (-1 < iVar4) {
    iVar3 = iVar4;
  }
  if (iVar3 == 2) {
    iVar4 = StardewValley_StardewValley_Character_get_StandingPixel_06003255(param_2);
    iVar3 = iVar4 + 0x3f;
    if (-1 < iVar4) {
      iVar3 = iVar4;
    }
    if (iVar3 >> 6 < iVar9) {
      iVar9 = iVar9 + -1;
    }
    else {
      iVar9 = iVar9 + 1;
    }
  }
  lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar7 = _UNK_1036d6cb0;
  if (lVar5 == 0) goto LAB_101fc4f50;
  lVar5 = StardewValley_StardewValley_Character_get_StandingPixel_06003255();
  lVar6 = StardewValley_StardewValley_Character_get_StandingPixel_06003255(param_2);
  iVar3 = (int)((int)((ulong)lVar5 >> 0x20) + (-(uint)(lVar5 < 0) >> 0x1a)) >> 6;
  iVar4 = iVar3 - ((int)((int)((ulong)lVar6 >> 0x20) + (-(uint)(lVar6 < 0) >> 0x1a)) >> 6);
  iVar8 = -iVar4;
  if (-1 < iVar4) {
    iVar8 = iVar4;
  }
  if (iVar8 == 2) {
    lVar5 = StardewValley_StardewValley_Character_get_StandingPixel_06003255(param_2);
    iVar8 = (int)((ulong)lVar5 >> 0x20);
    iVar4 = iVar8 + 0x3f;
    if (-1 < lVar5) {
      iVar4 = iVar8;
    }
    if (iVar4 >> 6 < iVar3) {
      iVar3 = iVar3 + -1;
    }
    else {
      iVar3 = iVar3 + 1;
    }
  }
  lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
  uVar7 = _UNK_1036d6cc0;
  if (*(long *)(lVar5 + 0xb8) == 0) goto LAB_101fc4f50;
  func_0x000101b560e8((float)iVar9,(float)iVar3,*(long *)(lVar5 + 0xb8),&plStack_38);
  if (plStack_38 == (long *)0x0) {
LAB_101fc4e98:
    uVar7 = _UNK_1036d6cd0;
    if (*(long *)(param_1 + 0x28) == 0) {
LAB_101fc4f50:
      func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc4f5c);
      (*pcVar1)();
    }
    lVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                      (*(long *)(param_1 + 0x28),iVar9,iVar3);
    uVar7 = 0;
    if (lVar5 != 0) {
      uVar7 = SDV_StardewValley_Mobile_AStarNode_ContainsStumpOrBoulder_06006647();
    }
  }
  else {
    if (7 < *(int *)(plStack_38[0xb] + 0x68) - 0x76U) {
      uVar7 = (**(code **)(*plStack_38 + 0x1e8))();
      cVar2 = func_0x000100345aa0(uVar7,uRam00000001038e5bd8);
      if (cVar2 == '\0') {
        uVar7 = (**(code **)(*plStack_38 + 0x1e8))();
        cVar2 = func_0x000100345aa0(uVar7,uRam00000001038ecef0);
        if (cVar2 == '\0') goto LAB_101fc4e98;
      }
    }
    uVar7 = 1;
  }
  return uVar7;
}

