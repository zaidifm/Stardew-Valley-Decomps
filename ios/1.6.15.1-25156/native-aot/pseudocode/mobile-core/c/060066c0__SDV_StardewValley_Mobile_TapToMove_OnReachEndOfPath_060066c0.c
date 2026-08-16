/* 0x060066c0 StardewValley.Mobile.TapToMove.OnReachEndOfPath @ 0x101fc61cc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_OnReachEndOfPath_060066c0
               (undefined1 param_1 [16],float param_2,long param_3)

{
  code *pcVar1;
  bool bVar2;
  bool bVar3;
  char cVar4;
  int iVar5;
  undefined8 *puVar6;
  undefined8 uVar7;
  long *plVar8;
  undefined1 uVar9;
  undefined4 uVar10;
  undefined1 uVar11;
  int iVar12;
  long lVar13;
  long lVar14;
  int iVar15;
  float fVar16;
  double dVar17;
  float fVar18;
  float fVar19;
  float fVar20;
  float fVar21;
  
  cVar4 = cRam00000001039114cf;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103325700);
    cRam00000001039114cf = '\x01';
  }
  SDV_StardewValley_Mobile_TapToMove_AutoSelectPendingTool_060066b1(param_3);
  if (*(long *)(param_3 + 0x48) == 0) {
    if (*(char *)(param_3 + 0xf5) == '\0') {
      cVar4 = SDV_StardewValley_Mobile_TapToMove_PerformAction_060066c9(param_3);
      if (cVar4 == '\0') {
        lVar13 = *(long *)(param_3 + 0x18);
        uVar7 = _UNK_1036d6fa0;
        if (lVar13 == 0) goto LAB_101fc6ab4;
        SDV_StardewValley_Mobile_MobileKeyStates_SetUp_06006672(lVar13,0);
        SDV_StardewValley_Mobile_MobileKeyStates_SetDown_06006673(lVar13,0);
        SDV_StardewValley_Mobile_MobileKeyStates_SetLeft_06006674(lVar13,0);
        SDV_StardewValley_Mobile_MobileKeyStates_SetRight_06006675(lVar13,0);
      }
    }
    else {
      lVar13 = *(long *)(param_3 + 0x18);
      *(undefined2 *)(lVar13 + 0x16) = 0x100;
      *(bool *)(lVar13 + 0x15) = *(char *)(lVar13 + 0x17) == '\0';
    }
    goto LAB_101fc690c;
  }
  if (*(char *)(param_3 + 0xf5) == '\0') {
    uVar7 = _UNK_1036d6fb8;
    if (*(long *)(param_3 + 0x28) == 0) goto LAB_101fc6ab4;
    uVar7 = SDV_StardewValley_Mobile_AStarGraph_get_FarmerAStarNode_060065fd();
    iVar12 = SDV_StardewValley_Mobile_AStarGraph_WalkDirectionToNextNode_0600660d
                       (uVar7,uVar7,*(undefined8 *)(param_3 + 0x48));
    if (iVar12 != 0) goto LAB_101fc66c0;
    lVar14 = *(long *)(param_3 + 0x28);
    fVar16 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
    lVar13 = *(long *)(param_3 + 0x48);
    uVar7 = _UNK_1036d6fc0;
    if ((lVar13 == 0) || (uVar7 = _UNK_1036d7038, lVar14 == 0)) goto LAB_101fc6ab4;
    fVar21 = (float)(*(int *)(lVar13 + 0x34) << 6) + 32.0;
    fVar20 = (float)(*(int *)(lVar13 + 0x38) << 6) + 32.0;
    fVar18 = ABS(fVar16 - fVar21);
    fVar19 = ABS(param_2 - fVar20);
    uVar7 = _UNK_1036d7040;
    if ((fVar16 <= fVar21) || (((param_2 <= fVar20 || (fVar18 < 16.0)) || (fVar19 < 16.0)))) {
      if ((((fVar21 <= fVar16) || (param_2 <= fVar20)) || (fVar18 < 16.0)) || (fVar19 < 16.0)) {
        if (((fVar16 <= fVar21) || (fVar20 <= param_2)) || ((fVar18 < 16.0 || (fVar19 < 16.0)))) {
          if ((((fVar21 <= fVar16) || (fVar20 <= param_2)) || (fVar18 < 16.0)) || (fVar19 < 16.0)) {
            if ((param_2 <= fVar20) || (fVar19 <= fVar18)) {
              iVar12 = (uint)(fVar16 < fVar21) << 2;
              if (fVar21 < fVar16) {
                iVar12 = 3;
              }
              if ((fVar20 <= param_2) || (fVar19 <= fVar18)) goto LAB_101fc66b4;
              iVar12 = 2;
              lVar13 = *(long *)(param_3 + 0x18);
            }
            else {
              iVar12 = 1;
              lVar13 = *(long *)(param_3 + 0x18);
            }
          }
          else {
            iVar12 = 8;
            lVar13 = *(long *)(param_3 + 0x18);
          }
        }
        else {
          iVar12 = 7;
          lVar13 = *(long *)(param_3 + 0x18);
        }
      }
      else {
        iVar12 = 6;
        lVar13 = *(long *)(param_3 + 0x18);
      }
    }
    else {
      iVar12 = 5;
      lVar13 = *(long *)(param_3 + 0x18);
    }
  }
  else {
    puVar6 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
    if ((puVar6 == (undefined8 *)0x0) ||
       (lRam00000001038d5370 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 8))) {
      lVar13 = *(long *)(param_3 + 0x28);
      fVar16 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
      uVar7 = _UNK_1036d6fb0;
      if (lVar13 == 0) goto LAB_101fc6ab4;
      fVar19 = *(float *)(param_3 + 0x108);
      fVar18 = *(float *)(param_3 + 0x10c);
      fVar20 = fVar16 - fVar19;
      fVar21 = param_2 - fVar18;
      if ((((fVar16 <= fVar19) || (NAN(fVar21))) || (param_2 <= fVar18)) || (NAN(fVar20))) {
        if (((fVar19 <= fVar16) || (NAN(fVar21))) || ((param_2 <= fVar18 || (NAN(fVar20))))) {
          if (((fVar16 <= fVar19) || (NAN(fVar21))) || ((fVar18 <= param_2 || (NAN(fVar20))))) {
            if ((((fVar19 <= fVar16) || (NAN(fVar21))) || (fVar18 <= param_2)) || (NAN(fVar20))) {
              if ((param_2 <= fVar18) || (ABS(param_2 - fVar18) <= ABS(fVar16 - fVar19))) {
                iVar12 = (uint)(fVar16 < fVar19) << 2;
                if (fVar19 < fVar16) {
                  iVar12 = 3;
                }
                bVar3 = false;
                if ((ABS(fVar16 - fVar19) < ABS(param_2 - fVar18)) &&
                   (bVar3 = false, !NAN(param_2) && !NAN(fVar18))) {
                  bVar3 = param_2 < fVar18;
                }
                if (bVar3) {
                  iVar12 = 2;
                }
              }
              else {
                iVar12 = 1;
              }
            }
            else {
              iVar12 = 8;
            }
          }
          else {
            iVar12 = 7;
          }
        }
        else {
          iVar12 = 6;
        }
      }
      else {
        iVar12 = 5;
      }
      lVar13 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar7 = _UNK_1036d7048;
      if (lVar13 == 0) goto LAB_101fc6ab4;
      lVar13 = StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
      if (lVar13 != 0) {
        lVar13 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar7 = _UNK_1036d7050;
        if (lVar13 == 0) goto LAB_101fc6ab4;
        puVar6 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
        if ((puVar6 == (undefined8 *)0x0) ||
           (lRam00000001038c7a00 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18))) {
          lVar13 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          uVar7 = _UNK_1036d7068;
          if (lVar13 == 0) goto LAB_101fc6ab4;
          puVar6 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
          if (((puVar6 == (undefined8 *)0x0) ||
              (lRam00000001038c7ad0 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18))) ||
             (*(char *)(param_3 + 0xfc) == '\0')) goto LAB_101fc66b4;
        }
        plVar8 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
        fVar18 = *(float *)(param_3 + 0x108);
        fVar19 = *(float *)(param_3 + 0x10c);
        fVar16 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
        dVar17 = (double)func_0x00010035d358((double)(fVar19 - param_2),(double)(fVar18 - fVar16));
        if ((dVar17 < _UNK_103333c70) || (_UNK_103333c78 < dVar17)) {
          if ((dVar17 < _UNK_103333c78) || (_UNK_103333c80 < dVar17)) {
            bVar3 = false;
            bVar2 = true;
            if (_UNK_103333c88 <= dVar17) {
              bVar3 = false;
              bVar2 = true;
              if (!NAN(dVar17) && !NAN(_UNK_103333c70)) {
                bVar3 = dVar17 == _UNK_103333c70;
                bVar2 = _UNK_103333c70 <= dVar17;
              }
            }
            uVar10 = 3;
            if (!bVar2 || bVar3) {
              uVar10 = 0;
            }
          }
          else {
            uVar10 = 2;
          }
        }
        else {
          uVar10 = 1;
        }
        (**(code **)(*plVar8 + 0x178))(plVar8,uVar10);
      }
LAB_101fc66b4:
      if (iVar12 == 0) {
        iVar12 = *(int *)(*(long *)(param_3 + 0x18) + 0x10);
      }
LAB_101fc66c0:
      lVar13 = *(long *)(param_3 + 0x18);
      uVar7 = _UNK_1036d7040;
    }
    else {
      fVar18 = *(float *)(param_3 + 0x108);
      fVar19 = *(float *)(param_3 + 0x10c);
      fVar16 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
      dVar17 = (double)func_0x00010035d358((double)(fVar19 - param_2),(double)(fVar18 - fVar16));
      if ((dVar17 < _UNK_103333c70) || (_UNK_103333c78 < dVar17)) {
        if ((dVar17 < _UNK_103333c78) || (_UNK_103333c80 < dVar17)) {
          bVar3 = false;
          bVar2 = true;
          if (_UNK_103333c88 <= dVar17) {
            bVar3 = false;
            bVar2 = true;
            if (!NAN(dVar17) && !NAN(_UNK_103333c70)) {
              bVar3 = dVar17 == _UNK_103333c70;
              bVar2 = _UNK_103333c70 <= dVar17;
            }
          }
          iVar12 = 3;
          if (!bVar2 || bVar3) {
            iVar12 = 1;
          }
        }
        else {
          iVar12 = 2;
        }
      }
      else {
        iVar12 = 4;
      }
      SDV_StardewValley_Mobile_TapToMove_faceTileClicked_060066c5(param_3,0,0xfffffc18,0xfffffc18);
      lVar13 = *(long *)(param_3 + 0x18);
      uVar7 = _UNK_1036d7040;
    }
  }
  _UNK_1036d7040 = uVar7;
  if (lVar13 == 0) goto LAB_101fc6ab4;
  SDV_StardewValley_Mobile_MobileKeyStates_SetMovePressed_06006670(lVar13,iVar12);
  if ((*(char *)(param_3 + 0xf5) == '\0') &&
     (cVar4 = SDV_StardewValley_Mobile_TapToMove_PerformAction_060066c9(param_3), cVar4 != '\0'))
  goto LAB_101fc690c;
  lVar13 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar7 = _UNK_1036d6fc8;
  if (lVar13 == 0) goto LAB_101fc6ab4;
  puVar6 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
  if ((puVar6 != (undefined8 *)0x0) &&
     (lRam00000001038c7ad0 == *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18))) {
    SDV_StardewValley_Mobile_TapToMove_faceTileClicked_060066c5(param_3,1,0xfffffc18,0xfffffc18);
  }
  lVar13 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar7 = _UNK_1036d6fd0;
  if (lVar13 == 0) goto LAB_101fc6ab4;
  puVar6 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
  if (((puVar6 != (undefined8 *)0x0) &&
      (lRam00000001038c7a00 == *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18))) &&
     (*(char *)(param_3 + 0xfc) == '\0')) goto LAB_101fc690c;
  *(undefined8 *)(param_3 + 0x158) = *(undefined8 *)(param_3 + 0x110);
  cVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_NodeContainsFurniture_060066e2
                    (*(undefined8 *)(param_3 + 0x48));
  if (cVar4 != '\0') {
    uVar7 = _UNK_1036d7008;
    if (param_3 == -0x108) goto LAB_101fc6ab4;
    lVar13 = SDV_StardewValley_Mobile_TapToMoveUtils_GetFurnitureClickedOn_060066e4
                       ((int)*(float *)(param_3 + 0x108),(int)*(float *)(param_3 + 0x10c));
    if (*(int *)(*(long *)(lVar13 + 0x208) + 0x68) < 4) {
      lVar13 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
      lVar13 = *(long *)(*(long *)(lVar13 + 0x238) + 0x18);
      uVar7 = _UNK_1036d7030;
      if (lVar13 == 0) goto LAB_101fc6ab4;
      *(undefined1 *)(lVar13 + 0x18) = 1;
    }
  }
  iVar12 = (int)*(float *)(param_3 + 0x110);
  iVar15 = (int)*(float *)(param_3 + 0x114);
  cVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_IsTreeAt_060066f7(iVar12,iVar15);
  if ((((cVar4 == '\0') &&
       (iVar5 = SDV_StardewValley_Mobile_TapToMoveUtils_TreeGrowthStage_060066f4(iVar12,iVar15),
       iVar5 < 1)) &&
      ((cVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_IsChoppableBushAtPoint_060066fd
                          (iVar12,iVar15), cVar4 == '\0' &&
       ((cVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_IsStumpAt_06006703(iVar12,iVar15),
        cVar4 == '\0' &&
        (cVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_IsBoulderAt_06006709(iVar12,iVar15),
        cVar4 == '\0')))))) && (*(long *)(param_3 + 0x88) == 0)) {
    uVar7 = _UNK_1036d7000;
    if ((float *)(param_3 + 0x110) == (float *)0x0) goto LAB_101fc6ab4;
    *(undefined8 *)(param_3 + 0x110) = 0xbf800000bf800000;
  }
  if ((*(char *)(param_3 + 0x105) != '\0') &&
     (lVar13 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd(), lVar13 != 0)) {
    lVar13 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
    uVar7 = _UNK_1036d6ff8;
    if (lVar13 != 0) {
      StardewValley_StardewValley_Event_receiveActionPress_060034a2(lVar13,0x35,8);
      *(undefined1 *)(param_3 + 0x105) = 0;
      goto LAB_101fc690c;
    }
    goto LAB_101fc6ab4;
  }
  lVar14 = *(long *)(param_3 + 0x18);
  lVar13 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar7 = _UNK_1036d6fe8;
  if (*(long *)(*(long *)(lVar13 + 0x5c0) + 0x60) == 0) {
    if (lVar14 == 0) goto LAB_101fc6ab4;
LAB_101fc68c8:
    uVar9 = 0;
    uVar11 = 1;
    bVar3 = *(char *)(lVar14 + 0x17) == '\0';
  }
  else {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
      uVar7 = _UNK_1036d6fe8;
    }
    _UNK_1036d6fe8 = uVar7;
    if (lVar14 == 0) goto LAB_101fc6ab4;
    if (*pcRam00000001038d53e0 != '\0') goto LAB_101fc68c8;
    uVar11 = 0;
    bVar3 = false;
    uVar9 = *(undefined1 *)(lVar14 + 0x17);
  }
  *(bool *)(lVar14 + 0x15) = bVar3;
  *(undefined1 *)(lVar14 + 0x16) = uVar9;
  *(undefined1 *)(lVar14 + 0x17) = uVar11;
  uVar7 = _UNK_1036d6ff0;
  if (param_3 == -0x158) {
LAB_101fc6ab4:
    func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc6ac0);
    (*pcVar1)();
  }
  SDV_StardewValley_Mobile_TapToMove_faceTileClicked_060066c5
            (param_3,0,(int)*(float *)(param_3 + 0x158),(int)*(float *)(param_3 + 0x15c));
LAB_101fc690c:
  *(undefined4 *)(param_3 + 0x124) = 3;
  return;
}

