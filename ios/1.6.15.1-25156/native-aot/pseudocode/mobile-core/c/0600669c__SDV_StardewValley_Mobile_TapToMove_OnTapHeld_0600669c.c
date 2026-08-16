/* 0x0600669c StardewValley.Mobile.TapToMove.OnTapHeld @ 0x101fb17a0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_OnTapHeld_0600669c
               (long param_1,int param_2,int param_3,int param_4,int param_5)

{
  bool bVar1;
  code *pcVar2;
  char cVar3;
  undefined4 uVar4;
  long lVar5;
  undefined8 *puVar6;
  ulong uVar7;
  undefined8 uVar8;
  bool bVar9;
  float fVar10;
  float fVar11;
  int iVar12;
  float fVar13;
  double dVar14;
  float fVar15;
  undefined8 uStack_98;
  undefined8 uStack_90;
  undefined4 uStack_88;
  
  cVar3 = cRam00000001039114ab;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103325120);
    cRam00000001039114ab = '\x01';
  }
  uStack_98 = 0;
  uStack_90 = 0;
  uStack_88 = 0;
  lVar5 = SDV_StardewValley_Mobile_PinchZoom_get_Instance_06006679();
  if (*(char *)(lVar5 + 0x1c) != '\0') {
    return;
  }
  if (*pcRam00000001038d6a30 != '\0') {
    return;
  }
  lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if (*(int *)(lVar5 + 0x178) == 2) {
    return;
  }
  lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if (*(int *)(lVar5 + 0x178) == 3) {
    return;
  }
  lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if (*(int *)(lVar5 + 0x178) == 8) {
    return;
  }
  lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if ((*(int *)(lVar5 + 0x178) == 4) &&
     (lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a(),
     *(char *)(lVar5 + 0x772) != '\0')) {
    return;
  }
  lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if ((*(int *)(lVar5 + 0x178) == 1) && (*(char *)(param_1 + 0xf7) != '\0')) {
    return;
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  lVar5 = *plRam00000001038d5360;
  if (((*(char *)(lVar5 + 0x106) != '\0') || (*(char *)(lVar5 + 0xd8) != '\0')) ||
     (*(char *)(lVar5 + 0xd9) != '\0')) {
    uVar8 = _UNK_1036d3d90;
    if (param_1 != 0) {
      *(undefined1 *)(param_1 + 0x104) = 1;
      return;
    }
    goto LAB_101fb20c8;
  }
  if (*(char *)(param_1 + 0x104) != '\0') {
    return;
  }
  if (*(char *)(param_1 + 0x100) != '\0') {
    return;
  }
  if (*pcRam00000001038d6a30 != '\0') {
    return;
  }
  cVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_get_inMiniGameWhereWeDontWantTaps_060066cc();
  if (cVar3 != '\0') {
    return;
  }
  puVar6 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
  if ((puVar6 != (undefined8 *)0x0) &&
     (lRam00000001038d5370 == *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 8))) {
    return;
  }
  uVar7 = func_0x000100332090();
  if ((long)((uVar7 & 0x3fffffffffffffff) - *plRam00000001039048c8) < 3500000) {
    return;
  }
  *(undefined1 *)(param_1 + 0xfe) = 1;
  cVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_IsMatureTreeStumpOrBoulderAt_060066f0
                    (*(undefined4 *)(param_1 + 0x110),*(undefined4 *)(param_1 + 0x114));
  if (((cVar3 != '\0') || (*(long *)(param_1 + 0x88) != 0)) &&
     (*(char *)(*(long *)(param_1 + 0x18) + 0x14) != '\0')) {
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar8 = _UNK_1036d3d50;
    if (lVar5 == 0) goto LAB_101fb20c8;
    puVar6 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
    if ((puVar6 == (undefined8 *)0x0) ||
       (lRam00000001038c79e0 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18))) {
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar8 = _UNK_1036d3d80;
      if (lVar5 == 0) goto LAB_101fb20c8;
      puVar6 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
      if ((puVar6 == (undefined8 *)0x0) ||
         (lRam00000001038c7a80 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18))) {
        lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar8 = _UNK_1036d3d88;
        if (lVar5 == 0) goto LAB_101fb20c8;
        puVar6 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
        if ((puVar6 == (undefined8 *)0x0) ||
           (lRam00000001038c7a50 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18)))
        goto LAB_101fb1a4c;
      }
    }
    if (3 < *(int *)(param_1 + 0x124) - 1U) {
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      if (*(char *)(*(long *)(lVar5 + 0x530) + 0x68) != '\0') {
        lVar5 = *(long *)(param_1 + 0x18);
        *(undefined4 *)(param_1 + 0x124) = 0;
        *(undefined1 *)(lVar5 + 0x15) = 0;
        *(undefined1 *)(lVar5 + 0x16) = *(undefined1 *)(lVar5 + 0x17);
        *(undefined1 *)(lVar5 + 0x17) = 0;
        lVar5 = *(long *)(param_1 + 0x18);
        *(undefined4 *)(lVar5 + 0x19) = 0;
        *(undefined4 *)(lVar5 + 0x1d) = *(undefined4 *)(lVar5 + 0x21);
        *(undefined4 *)(lVar5 + 0x21) = 0;
        return;
      }
      *(undefined4 *)(param_1 + 0x124) = 5;
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar8 = _UNK_1036d3d68;
      if (lVar5 != 0) {
        puVar6 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
        if (puVar6 == (undefined8 *)0x0) {
          return;
        }
        if (lRam00000001038c7a50 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18)) {
          return;
        }
        cVar3 = SDV_StardewValley_Mobile_TapToMove_AutoSelectTool_060066b0
                          (param_1,uRam00000001038c79d8);
        if (cVar3 == '\0') {
          return;
        }
        SDV_StardewValley_Mobile_TapToMove_AutoSelectPendingTool_060066b1(param_1);
        return;
      }
      goto LAB_101fb20c8;
    }
  }
LAB_101fb1a4c:
  if ((*(char *)(param_1 + 0xfc) != '\0') && (*(char *)(*(long *)(param_1 + 0x18) + 0x14) != '\0'))
  {
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar8 = _UNK_1036d3d48;
    if (lVar5 == 0) goto LAB_101fb20c8;
    puVar6 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
    if ((puVar6 != (undefined8 *)0x0) &&
       (lRam00000001038c7a00 == *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18))) {
      if (*(int *)(param_1 + 0x124) != 4) {
        return;
      }
      goto LAB_101fb1dcc;
    }
  }
  lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar8 = _UNK_1036d3c50;
  if (lVar5 == 0) goto LAB_101fb20c8;
  puVar6 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentItem_060035a2();
  if ((puVar6 == (undefined8 *)0x0) ||
     (lRam00000001038c7420 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18))) {
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar8 = _UNK_1036d3d38;
    if (lVar5 == 0) goto LAB_101fb20c8;
    puVar6 = (undefined8 *)StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
    if ((puVar6 != (undefined8 *)0x0) &&
       (lRam00000001038c7420 == *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18)))
    goto LAB_101fb1aec;
  }
  else {
LAB_101fb1aec:
    puVar6 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    if ((puVar6 != (undefined8 *)0x0) &&
       (lRam00000001038c6c08 == *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x10))) {
      uVar8 = _UNK_1036d3d30;
      if (*(long *)(param_1 + 0x18) != 0) {
        SDV_StardewValley_Mobile_MobileKeyStates_SetMovePressed_06006670
                  (*(long *)(param_1 + 0x18),0);
        *(undefined4 *)(param_1 + 0x124) = 0;
        return;
      }
      goto LAB_101fb20c8;
    }
  }
  if (((((*(long *)(param_1 + 0x98) != 0) &&
        (uVar7 = func_0x000100332090(),
        3500000 < (long)((uVar7 & 0x3fffffffffffffff) - *plRam00000001039048c8))) &&
       (lVar5 = StardewValley_StardewValley_Menus_TutorialManager_get_Instance_06005e62(),
       *(long *)(lVar5 + 0xa0) == 0)) && (*(long *)(lVar5 + 0x98) == 0)) &&
     ((*(long *)(lVar5 + 0x90) == 0 || (*(long *)(*(long *)(lVar5 + 0x90) + 0x90) == 0)))) {
LAB_101fb1dcc:
    *(undefined4 *)(param_1 + 0x124) = 5;
    return;
  }
  lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  if (*(char *)(lVar5 + 0x76c) == '\0') {
    return;
  }
  if (*(char *)(param_1 + 0xf9) != '\0') {
    return;
  }
  fVar15 = *(float *)(param_1 + 0x114);
  cVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_IsMatureTreeStumpOrBoulderAt_060066f0
                    (*(undefined4 *)(param_1 + 0x110),fVar15);
  if (cVar3 != '\0') {
    return;
  }
  if (*(long *)(param_1 + 0x88) != 0) {
    return;
  }
  iVar12 = *(int *)(param_1 + 0x124);
  if ((iVar12 != 0xc) && (iVar12 != 0)) {
    SDV_StardewValley_Mobile_TapToMove_Reset_06006698(param_1,1);
    iVar12 = *(int *)(param_1 + 0x124);
  }
  if (iVar12 != 0xc) {
    *(undefined4 *)(param_1 + 0x124) = 0xc;
    uVar8 = _UNK_1036d3d18;
    if (param_1 == -0xec) goto LAB_101fb20c8;
    *(undefined8 *)(param_1 + 0xec) = 0xbf800000bf800000;
    lVar5 = StardewValley_StardewValley_Menus_TutorialManager_get_Instance_06005e62();
    uVar8 = _UNK_1036d3d20;
    if (lVar5 == 0) goto LAB_101fb20c8;
    func_0x000101e22b74();
  }
  fVar10 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  (**(code **)(*(long *)*puRam00000001038d5220 + 0x78))(&uStack_98);
  if (((float)*(int *)(lRam00000001038d6278 + 8) * 0.2 <= (float)(int)uStack_98) ||
     (fVar11 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerPositionOnScreen_060066d6(),
     192.0 <= fVar11)) {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    (**(code **)(*(long *)*puRam00000001038d5220 + 0x78))(&uStack_98);
    if ((float)(int)uStack_98 < (float)*(int *)(lRam00000001038d6278 + 8) * 0.2) {
      fVar11 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerPositionOnScreen_060066d6();
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar8 = _UNK_1036d3cf8;
      if ((piRam00000001038d5380 == (int *)0xfffffffffffffff8) ||
         (uVar8 = _UNK_1036d3cf0, piRam00000001038d5380 == (int *)0x0)) goto LAB_101fb20c8;
      if ((float)piRam00000001038d5380[2] + -192.0 < fVar11) {
        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        uVar8 = _UNK_1036d3d08;
        if ((piRam00000001038d5380 == (int *)0xfffffffffffffff8) ||
           (uVar8 = _UNK_1036d3d00, piRam00000001038d5380 == (int *)0x0)) goto LAB_101fb20c8;
        iVar12 = piRam00000001038d5380[2] + *piRam00000001038d5380;
        fVar10 = -192.0;
        goto LAB_101fb1e38;
      }
    }
    bVar9 = false;
  }
  else {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    iVar12 = *piRam00000001038d5380;
    fVar10 = 192.0;
LAB_101fb1e38:
    fVar10 = (float)iVar12 + fVar10;
    bVar9 = true;
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  (**(code **)(*(long *)*puRam00000001038d5220 + 0x78))(&uStack_98);
  fVar11 = (float)uStack_98._4_4_;
  if (((float)*(int *)(lRam00000001038d6278 + 0xc) * 0.2 <= fVar11) ||
     (SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerPositionOnScreen_060066d6(), 192.0 <= fVar11
     )) {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    (**(code **)(*(long *)*puRam00000001038d5220 + 0x78))(&uStack_98);
    fVar11 = (float)uStack_98._4_4_;
    if ((float)*(int *)(lRam00000001038d6278 + 0xc) * 0.8 < fVar11) {
      SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerPositionOnScreen_060066d6();
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar8 = _UNK_1036d3cc8;
      if ((piRam00000001038d5380 == (int *)0x0) ||
         (uVar8 = _UNK_1036d3cd0, piRam00000001038d5380 == (int *)0xfffffffffffffff8))
      goto LAB_101fb20c8;
      if ((float)piRam00000001038d5380[3] + -192.0 < fVar11) {
        if (((*(char *)(lRam00000001038c4c88 + 0x35) == '\0') &&
            (func_0x0001003319b0(), uVar8 = _UNK_1036d3cd8, piRam00000001038d5380 == (int *)0x0)) ||
           (uVar8 = _UNK_1036d3ce0, piRam00000001038d5380 == (int *)0xfffffffffffffff8))
        goto LAB_101fb20c8;
        iVar12 = piRam00000001038d5380[3] + piRam00000001038d5380[1];
        fVar15 = -192.0;
        goto LAB_101fb1fa0;
      }
    }
  }
  else {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    iVar12 = piRam00000001038d5380[1];
    fVar15 = 192.0;
LAB_101fb1fa0:
    fVar15 = (float)iVar12 + fVar15;
    bVar9 = true;
  }
  SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
  fVar11 = (float)func_0x000100354758();
  lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
  uVar8 = _UNK_1036d3ca0;
  if (lVar5 == 0) goto LAB_101fb20c8;
  fVar13 = (float)SDV_StardewValley_Options_get_zoomLevel_06003ee1();
  bVar1 = bVar9;
  if (16.0 / fVar13 < fVar11) {
    bVar1 = true;
  }
  if (bVar1) {
    dVar14 = (double)func_0x00010035d358((double)((float)(param_5 + param_3) - fVar15),
                                         (double)((float)(param_4 + param_2) - fVar10));
    if (32.0 < fVar11) {
      bVar9 = true;
    }
    if (bVar9) {
      uVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_WalkDirectionForAngle_060066dd
                        (((float)dVar14 / 6.2831855) * 360.0);
      goto LAB_101fb203c;
    }
  }
  else {
    uVar4 = 0;
LAB_101fb203c:
    *(undefined4 *)(param_1 + 0x148) = uVar4;
  }
  uVar8 = _UNK_1036d3ca8;
  if (*(long *)(param_1 + 0x18) != 0) {
    SDV_StardewValley_Mobile_MobileKeyStates_SetMovePressed_06006670
              (*(long *)(param_1 + 0x18),*(undefined4 *)(param_1 + 0x148));
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    if (*(char *)(*(long *)(lVar5 + 0x530) + 0x68) != '\0') {
      return;
    }
    if (*(char *)(param_1 + 0xf9) != '\0') {
      return;
    }
    SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
    cVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_InWarpRange_060066d7();
    if (cVar3 == '\0') {
      return;
    }
    cVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_InWarpRange_060066d7
                      ((float)(param_4 + param_2),(float)(param_5 + param_3));
    if (cVar3 == '\0') {
      return;
    }
    lVar5 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
    if ((lVar5 != 0) &&
       (lVar5 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd(),
       *(char *)(lVar5 + 0x118) != '\0')) {
      return;
    }
    SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
    SDV_StardewValley_Mobile_TapToMoveUtils_WarpIfInRange_060066d9();
    SDV_StardewValley_Mobile_TapToMove_Reset_06006698(param_1,1);
    *(undefined1 *)(param_1 + 0xf9) = 1;
    return;
  }
LAB_101fb20c8:
  func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fb20d4);
  (*pcVar2)();
}

