/* 0x060066bd StardewValley.Mobile.TapToMove.FollowAStarPathToNextNode @ 0x101fc4f5c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_FollowAStarPathToNextNode_060066bd(long param_1)

{
  undefined4 uVar1;
  undefined4 uVar2;
  undefined4 uVar3;
  code *pcVar4;
  bool bVar5;
  char cVar6;
  int iVar7;
  long *plVar8;
  long lVar9;
  long lVar10;
  undefined8 *puVar11;
  undefined8 uVar12;
  undefined8 uVar13;
  int iVar14;
  undefined8 uVar15;
  float fVar16;
  float fVar17;
  float fVar18;
  float fVar19;
  float fVar20;
  float fVar21;
  float fVar22;
  
  cVar6 = cRam00000001039114cc;
  if (lRam0000000103976fb8 == 0) {
    if (cRam00000001039114cc == '\0') goto LAB_101fc54f0;
LAB_101fc4f90:
    plVar8 = *(long **)(param_1 + 0x30);
  }
  else {
    func_0x00010119b8f8();
    if (cVar6 != '\0') goto LAB_101fc4f90;
LAB_101fc54f0:
    func_0x00010119b908(&UNK_1033256e0);
    cRam00000001039114cc = '\x01';
    plVar8 = *(long **)(param_1 + 0x30);
  }
  lVar9 = (**(code **)(*plVar8 + 0x88))();
  if (*(int *)(lVar9 + 0x18) < 1) goto LAB_101fc5454;
  lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  *(undefined1 *)(lVar9 + 0x76f) = 0;
  uVar12 = _UNK_1036d6d18;
  if (*(long *)(param_1 + 0x28) == 0) goto LAB_101fc57fc;
  lVar10 = SDV_StardewValley_Mobile_AStarGraph_get_FarmerAStarNodeOffset_060065fe();
  lVar9 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  plVar8 = (long *)(param_1 + 0x50);
  *plVar8 = lVar10;
  *(undefined1 *)(((ulong)plVar8 >> 9 & 0x7fffff) + lVar9) = 1;
  if (*plVar8 == 0) goto LAB_101fc5434;
  lVar9 = (**(code **)(**(long **)(param_1 + 0x30) + 0x88))();
  if (*(int *)(lVar9 + 0x18) == 0) goto LAB_101fc55a4;
  uVar12 = _UNK_1036d6d38;
  if (*(int *)(*(long *)(lVar9 + 0x10) + 0x18) == 0) goto LAB_101fc57a0;
  if (*(long *)(*(long *)(lVar9 + 0x10) + 0x20) == *(long *)(param_1 + 0x50)) {
    lVar9 = (**(code **)(**(long **)(param_1 + 0x30) + 0x88))();
    uVar12 = _UNK_1036d6ea0;
    if (lVar9 == 0) goto LAB_101fc57fc;
    func_0x00010037d324(lVar9,0);
    *(undefined8 *)(param_1 + 0x118) = 0;
    *(undefined4 *)(param_1 + 0x120) = 0;
  }
  lVar9 = (**(code **)(**(long **)(param_1 + 0x30) + 0x88))();
  if (*(int *)(lVar9 + 0x18) < 1) goto LAB_101fc5454;
  lVar9 = (**(code **)(**(long **)(param_1 + 0x30) + 0x88))();
  if (*(int *)(lVar9 + 0x18) == 0) goto LAB_101fc55a4;
  uVar12 = _UNK_1036d6d68;
  if (*(int *)(*(long *)(lVar9 + 0x10) + 0x18) == 0) goto LAB_101fc57a0;
  uVar12 = _UNK_1036d6d70;
  if (*(long *)(*(long *)(lVar9 + 0x10) + 0x20) == 0) goto LAB_101fc57fc;
  cVar6 = SDV_StardewValley_Mobile_AStarNode_ContainsAnimals_06006655();
  if (cVar6 != '\0') {
LAB_101fc509c:
    uVar1 = *(undefined4 *)(param_1 + 0x128);
    uVar2 = *(undefined4 *)(param_1 + 300);
    iVar14 = 0;
    uVar3 = *(undefined4 *)(param_1 + 0x130);
LAB_101fc50b0:
    SDV_StardewValley_Mobile_TapToMove_OnTap_060066a5
              (param_1,uVar1,uVar2,uVar3,*(undefined4 *)(param_1 + 0x134),iVar14);
    return;
  }
  lVar9 = (**(code **)(**(long **)(param_1 + 0x30) + 0x88))();
  if (*(int *)(lVar9 + 0x18) == 0) goto LAB_101fc55a4;
  uVar12 = _UNK_1036d6d90;
  if (*(int *)(*(long *)(lVar9 + 0x10) + 0x18) == 0) goto LAB_101fc57a0;
  uVar12 = _UNK_1036d6d98;
  if (*(long *)(*(long *)(lVar9 + 0x10) + 0x20) == 0) goto LAB_101fc57fc;
  cVar6 = SDV_StardewValley_Mobile_AStarNode_ContainsNPC_06006653();
  if (cVar6 != '\0') {
    lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    if (*(long *)(*(long *)(lVar9 + 0x5c0) + 0x60) != 0) {
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      if (*pcRam00000001038d53e0 == '\0') goto LAB_101fc5178;
    }
    lVar9 = (**(code **)(**(long **)(param_1 + 0x30) + 0x88))();
    if (*(int *)(lVar9 + 0x18) == 0) goto LAB_101fc55a4;
    uVar12 = _UNK_1036d6e88;
    if (*(int *)(*(long *)(lVar9 + 0x10) + 0x18) == 0) goto LAB_101fc57a0;
    uVar12 = _UNK_1036d6e90;
    if (*(long *)(*(long *)(lVar9 + 0x10) + 0x20) == 0) goto LAB_101fc57fc;
    puVar11 = (undefined8 *)SDV_StardewValley_Mobile_AStarNode_FetchNPC_06006654();
    if ((puVar11 == (undefined8 *)0x0) ||
       (lRam00000001038c6658 != *(long *)(*(long *)(*(long *)*puVar11 + 0x10) + 0x18)))
    goto LAB_101fc509c;
  }
LAB_101fc5178:
  lVar9 = (**(code **)(**(long **)(param_1 + 0x30) + 0x88))();
  if (*(int *)(lVar9 + 0x18) == 0) {
LAB_101fc55a4:
    func_0x000100331b90();
                    /* WARNING: Does not return */
    pcVar4 = (code *)SoftwareBreakpoint(1,0x101fc55ac);
    (*pcVar4)();
  }
  uVar12 = _UNK_1036d6db8;
  if (*(int *)(*(long *)(lVar9 + 0x10) + 0x18) == 0) {
LAB_101fc57a0:
    func_0x0001003316f4(0xcc,uVar12);
                    /* WARNING: Does not return */
    pcVar4 = (code *)SoftwareBreakpoint(1,0x101fc57ac);
    (*pcVar4)();
  }
  lVar9 = *(long *)(*(long *)(lVar9 + 0x10) + 0x20);
  uVar12 = _UNK_1036d6dc0;
  if (lVar9 == 0) goto LAB_101fc57fc;
  iVar14 = *(int *)(lVar9 + 0x38);
  lVar10 = *(long *)(param_1 + 0x28);
  fVar18 = (float)(*(int *)(lVar9 + 0x34) << 6) + 32.0;
  *(float *)(param_1 + 0xe4) = fVar18;
  *(float *)(param_1 + 0xe8) = (float)(iVar14 << 6) + 32.0;
  fVar16 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
  fVar22 = *(float *)(param_1 + 0xe4);
  fVar21 = *(float *)(param_1 + 0xe8);
  lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar12 = _UNK_1036d6dc8;
  if ((lVar9 == 0) ||
     (fVar17 = (float)StardewValley_StardewValley_Farmer_getMovementSpeed_060036c1(),
     uVar12 = _UNK_1036d6dd0, lVar10 == 0)) goto LAB_101fc57fc;
  fVar19 = ABS(fVar16 - fVar22);
  fVar20 = ABS(fVar18 - fVar21);
  if ((fVar16 <= fVar22) || (((fVar18 <= fVar21 || (fVar19 < fVar17)) || (fVar20 < fVar17)))) {
    if ((((fVar22 <= fVar16) || (fVar18 <= fVar21)) || (fVar19 < fVar17)) || (fVar20 < fVar17)) {
      if (((fVar16 <= fVar22) || (fVar21 <= fVar18)) || ((fVar19 < fVar17 || (fVar20 < fVar17)))) {
        if ((((fVar22 <= fVar16) || (fVar21 <= fVar18)) || (fVar19 < fVar17)) || (fVar20 < fVar17))
        {
          if ((fVar18 <= fVar21) || (fVar20 <= fVar19)) {
            iVar14 = (uint)(fVar16 < fVar22) << 2;
            if (fVar22 < fVar16) {
              iVar14 = 3;
            }
            bVar5 = false;
            if ((fVar19 < fVar20) && (bVar5 = false, !NAN(fVar18) && !NAN(fVar21))) {
              bVar5 = fVar18 < fVar21;
            }
            if (bVar5) {
              iVar14 = 2;
            }
          }
          else {
            iVar14 = 1;
          }
        }
        else {
          iVar14 = 8;
        }
      }
      else {
        iVar14 = 7;
      }
    }
    else {
      iVar14 = 6;
    }
  }
  else {
    iVar14 = 5;
  }
  SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
  fVar16 = (float)func_0x000100354758();
  if (*(float *)(param_1 + 0x118) <= fVar16) {
    *(int *)(param_1 + 0x11c) = *(int *)(param_1 + 0x11c) + 1;
  }
  *(float *)(param_1 + 0x118) = fVar16;
  lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar12 = _UNK_1036d6dd8;
  if (lVar9 == 0) goto LAB_101fc57fc;
  fVar18 = (float)StardewValley_StardewValley_Farmer_getMovementSpeed_060036c1();
  if ((fVar16 < fVar18) || (3 < *(int *)(param_1 + 0x11c))) {
    lVar9 = *(long *)(param_1 + 0x28);
    if (*(int *)(param_1 + 0x120) < 2) {
      uVar15 = *(undefined8 *)(param_1 + 0x50);
      lVar10 = (**(code **)(**(long **)(param_1 + 0x30) + 0x88))();
      if (*(int *)(lVar10 + 0x18) == 0) goto LAB_101fc55a4;
      uVar12 = _UNK_1036d6df8;
      if (*(int *)(*(long *)(lVar10 + 0x10) + 0x18) == 0) goto LAB_101fc57a0;
      uVar12 = _UNK_1036d6e00;
      if (lVar9 == 0) goto LAB_101fc57fc;
      iVar7 = SDV_StardewValley_Mobile_AStarGraph_WalkDirectionToNextNode_0600660d
                        (lVar10,uVar15,*(undefined8 *)(*(long *)(lVar10 + 0x10) + 0x20));
      if (iVar7 == iVar14) {
        lVar9 = *(long *)(param_1 + 0x28);
        SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
        uVar12 = _UNK_1036d6e08;
        if (lVar9 == 0) goto LAB_101fc57fc;
        iVar7 = SDV_StardewValley_Mobile_AStarGraph_WalkDirectionBetweenTwoPoints_0600660f();
        if (iVar7 != iVar14) goto LAB_101fc538c;
      }
      else {
LAB_101fc538c:
        iVar14 = iVar7;
        *(int *)(param_1 + 0x120) = *(int *)(param_1 + 0x120) + 1;
      }
      *(undefined4 *)(param_1 + 0x11c) = 0;
    }
    else {
      uVar12 = _UNK_1036d6e18;
      if (lVar9 == 0) goto LAB_101fc57fc;
      if (iVar14 - 1U < 8) {
        iVar14 = *(int *)(&UNK_103333500 + (long)(int)(iVar14 - 1U) * 4);
      }
      else {
        iVar14 = 0;
      }
      iVar7 = *(int *)(param_1 + 0x120) + 1;
      *(int *)(param_1 + 0x120) = iVar7;
      if (iVar7 == 8) {
        lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        if (*(long *)(*(long *)(lVar9 + 0x5c0) + 0x60) != 0) {
          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
            func_0x0001003319b0();
          }
          if (*pcRam00000001038d53e0 == '\0') goto LAB_101fc5434;
        }
        plVar8 = *(long **)(param_1 + 0x20);
        if (plVar8 != (long *)0x0) {
          uVar12 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          uVar15 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
          (**(code **)(*plVar8 + 0x350))(plVar8,uVar12,uVar15);
LAB_101fc5434:
          SDV_StardewValley_Mobile_TapToMove_Reset_06006698(param_1,1);
          return;
        }
        uVar12 = _UNK_1036d6e58;
        if ((*(long *)(param_1 + 0x28) != 0) &&
           (lVar9 = SDV_StardewValley_Mobile_AStarGraph_get_FarmerAStarNodeOffset_060065fe(),
           uVar12 = _UNK_1036d6e30, lVar9 != 0)) {
          puVar11 = (undefined8 *)SDV_StardewValley_Mobile_AStarNode_FetchNPC_06006654();
          if ((puVar11 == (undefined8 *)0x0) ||
             (lRam00000001038c6658 != *(long *)(*(long *)(*(long *)*puVar11 + 0x10) + 0x18))) {
            uVar1 = *(undefined4 *)(param_1 + 0x128);
            uVar2 = *(undefined4 *)(param_1 + 300);
            uVar3 = *(undefined4 *)(param_1 + 0x130);
            iVar14 = *(int *)(param_1 + 0x138) + 1;
            goto LAB_101fc50b0;
          }
          uVar12 = _UNK_1036d6e38;
          if ((*(long *)(param_1 + 0x28) != 0) &&
             (lVar9 = SDV_StardewValley_Mobile_AStarGraph_get_FarmerAStarNodeOffset_060065fe(),
             uVar12 = _UNK_1036d6e40, lVar9 != 0)) {
            plVar8 = (long *)SDV_StardewValley_Mobile_AStarNode_FetchNPC_06006654();
            if ((plVar8 != (long *)0x0) &&
               (lRam00000001038c6658 != *(long *)(*(long *)(*(long *)*plVar8 + 0x10) + 0x18))) {
              func_0x0001003316f4(0xd3,_UNK_1036d6e50);
                    /* WARNING: Does not return */
              pcVar4 = (code *)SoftwareBreakpoint(1,0x101fc5840);
              (*pcVar4)();
            }
            uVar15 = StardewValley_StardewValley_Game1_get_player_06002f9a();
            uVar13 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
            uVar12 = _UNK_1036d6e48;
            if (plVar8 != (long *)0x0) {
              (**(code **)(*plVar8 + 0x350))(plVar8,uVar15,uVar13);
              return;
            }
          }
        }
        goto LAB_101fc57fc;
      }
    }
  }
  uVar12 = _UNK_1036d6e10;
  if (*(long *)(param_1 + 0x18) != 0) {
    SDV_StardewValley_Mobile_MobileKeyStates_SetMovePressed_06006670
              (*(long *)(param_1 + 0x18),iVar14);
LAB_101fc5454:
    lVar9 = (**(code **)(**(long **)(param_1 + 0x30) + 0x88))();
    if (*(int *)(lVar9 + 0x18) == 0) {
      *(undefined8 *)(param_1 + 0x30) = 0;
      *(undefined4 *)(param_1 + 0x11c) = 0;
      *(undefined4 *)(param_1 + 0x124) = 2;
    }
    return;
  }
LAB_101fc57fc:
  func_0x0001003316f4(0xee,uVar12);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101fc5808);
  (*pcVar4)();
}

