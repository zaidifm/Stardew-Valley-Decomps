/* 0x06006716 StardewValley.Mobile.TapToMoveUtils.retargetToBedSpot @ 0x101fcf4b4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_TapToMoveUtils_retargetToBedSpot_06006716(long param_1,ulong param_2)

{
  uint uVar1;
  code *pcVar2;
  char cVar3;
  int iVar4;
  int iVar5;
  undefined8 *puVar6;
  long *plVar7;
  ulong uVar8;
  long lVar9;
  undefined8 uVar10;
  undefined8 *puVar11;
  int iVar12;
  int iVar13;
  float fVar14;
  float fVar15;
  undefined4 auStack_70 [2];
  undefined4 auStack_68 [2];
  
  cVar3 = cRam0000000103911525;
  puVar11 = (undefined8 *)auStack_70;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103911525 != '\0') goto LAB_101fcf4f8;
LAB_101fcf668:
    func_0x00010119b908(&UNK_103325b31);
    cRam0000000103911525 = '\x01';
    puVar6 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
  }
  else {
    func_0x00010119b8f8();
    if (cVar3 == '\0') goto LAB_101fcf668;
LAB_101fcf4f8:
    puVar6 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
  }
  if (((puVar6 != (undefined8 *)0x0) &&
      (lRam00000001038c6c08 == *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x10))) &&
     (plVar7 = (long *)func_0x000101add830(*(undefined8 *)(param_1 + 0x10),param_2 & 0xffffffff,
                                           param_2 >> 0x20), plVar7 != (long *)0x0)) {
    uVar8 = (**(code **)(*plVar7 + 0x798))();
    lVar9 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                      (param_1,param_2 & 0xffffffff,param_2 >> 0x20);
    uVar10 = _UNK_1036d7f98;
    if (lVar9 == 0) goto LAB_101fcf6b4;
    cVar3 = SDV_StardewValley_Mobile_AStarNode_isBlockingBedTile_0600663c();
    if (cVar3 != '\0') {
      iVar13 = (int)(uVar8 >> 0x20);
      iVar4 = func_0x000101adcdbc(plVar7);
      if (iVar4 == 0) {
        lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar10 = _UNK_1036d7fa0;
        if (lVar9 == 0) {
LAB_101fcf6b4:
          func_0x0001003316f4(0xee,uVar10);
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101fcf6c0);
          (*pcVar2)();
        }
        lVar9 = StardewValley_StardewValley_Character_get_StandingPixel_06003255();
        iVar5 = (int)lVar9;
        iVar4 = iVar5 + 0x3f;
        if (-1 < iVar5) {
          iVar4 = iVar5;
        }
        iVar12 = (int)((ulong)lVar9 >> 0x20);
        iVar5 = iVar12 + 0x3f;
        if (-1 < lVar9) {
          iVar5 = iVar12;
        }
        fVar14 = (float)func_0x000100354758((float)(int)uVar8,(float)iVar13,(float)(iVar4 >> 6),
                                            (float)(iVar5 >> 6));
        lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar10 = _UNK_1036d7fa8;
        if (lVar9 == 0) goto LAB_101fcf6b4;
        uVar1 = (int)uVar8 - 1;
        lVar9 = StardewValley_StardewValley_Character_get_StandingPixel_06003255();
        iVar5 = (int)lVar9;
        iVar4 = iVar5 + 0x3f;
        if (-1 < iVar5) {
          iVar4 = iVar5;
        }
        iVar12 = (int)((ulong)lVar9 >> 0x20);
        iVar5 = iVar12 + 0x3f;
        if (-1 < lVar9) {
          iVar5 = iVar12;
        }
        fVar15 = (float)func_0x000100354758((float)(int)uVar1,(float)iVar13,(float)(iVar4 >> 6),
                                            (float)(iVar5 >> 6));
        if (fVar14 < fVar15) {
          uVar8 = (ulong)uVar1;
        }
      }
      auStack_70[0] = (int)uVar8;
      goto LAB_101fcf528;
    }
  }
  iVar13 = (int)(param_2 >> 0x20);
  puVar11 = (undefined8 *)auStack_68;
  auStack_68[0] = (int)param_2;
LAB_101fcf528:
  *(int *)((long)puVar11 + 4) = iVar13;
  return *puVar11;
}

