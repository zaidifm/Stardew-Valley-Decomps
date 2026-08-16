/* 0x060066b7 StardewValley.Mobile.TapToMove.Update @ 0x101fc38d0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_Update_060066b7(long param_1)

{
  undefined1 uVar1;
  code *pcVar2;
  char cVar3;
  undefined8 uVar4;
  undefined8 *puVar5;
  int iVar6;
  long lVar7;
  
  cVar3 = cRam00000001039114c6;
  if (lRam0000000103976fb8 == 0) {
    if (cRam00000001039114c6 == '\0') goto LAB_101fc3c10;
LAB_101fc38fc:
    lVar7 = *(long *)(param_1 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    if (cVar3 != '\0') goto LAB_101fc38fc;
LAB_101fc3c10:
    func_0x00010119b908(&UNK_103325650);
    cRam00000001039114c6 = '\x01';
    lVar7 = *(long *)(param_1 + 0x18);
  }
  if (*(char *)(lVar7 + 0x16) != '\0') {
    *(undefined1 *)(lVar7 + 0x16) = 0;
  }
  if (*(char *)(lVar7 + 0x1d) != '\0') {
    *(undefined1 *)(lVar7 + 0x1d) = 0;
  }
  if (*(char *)(lVar7 + 0x1f) != '\0') {
    *(undefined1 *)(lVar7 + 0x1f) = 0;
  }
  if (*(char *)(lVar7 + 0x20) != '\0') {
    *(undefined1 *)(lVar7 + 0x20) = 0;
  }
  if (*(char *)(lVar7 + 0x1e) != '\0') {
    *(undefined1 *)(lVar7 + 0x1e) = 0;
  }
  lVar7 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if (((*(int *)(lVar7 + 0x178) != 8) &&
      (lVar7 = StardewValley_StardewValley_Game1_get_options_06002fec(),
      *(int *)(lVar7 + 0x178) != 2)) &&
     (lVar7 = StardewValley_StardewValley_Game1_get_options_06002fec(), *(int *)(lVar7 + 0x178) != 2
     )) {
    lVar7 = SDV_StardewValley_Mobile_PinchZoom_get_Instance_06006679();
    uVar4 = _UNK_1036d69f8;
    if (lVar7 == 0) goto LAB_101fc3d20;
    cVar3 = SDV_StardewValley_Mobile_PinchZoom_CheckForPinchZoom_06006680();
    if (cVar3 != '\0') {
      return;
    }
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  if ((*pcRam00000001038d53e0 == '\0') ||
     (lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a(),
     *(char *)(lVar7 + 0x76c) != '\0')) {
LAB_101fc39c8:
    iVar6 = *(int *)(param_1 + 0x124);
    if (iVar6 == 1) {
      lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      if (*(char *)(lVar7 + 0x76c) != '\0') {
        SDV_StardewValley_Mobile_TapToMove_FollowAStarPathToNextNode_060066bd(param_1);
        goto LAB_101fc3a0c;
      }
      iVar6 = *(int *)(param_1 + 0x124);
    }
    if (iVar6 == 2) {
      lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      if (*(char *)(lVar7 + 0x76c) != '\0') {
        SDV_StardewValley_Mobile_TapToMove_MoveOnFinalTile_060066bf(param_1);
        goto LAB_101fc3a0c;
      }
      iVar6 = *(int *)(param_1 + 0x124);
    }
    switch(iVar6) {
    case 3:
      SDV_StardewValley_Mobile_TapToMove_StopMovingAfterReachingEndOfPath_060066c1(param_1);
      break;
    case 4:
      SDV_StardewValley_Mobile_TapToMove_OnTapToMoveComplete_060066c2(param_1);
      break;
    case 5:
      lVar7 = *(long *)(param_1 + 0x18);
      *(undefined2 *)(lVar7 + 0x16) = 0x100;
      *(bool *)(lVar7 + 0x15) = *(char *)(lVar7 + 0x17) == '\0';
      *(undefined4 *)(param_1 + 0x124) = 6;
      break;
    case 6:
      lVar7 = *(long *)(param_1 + 0x18);
      uVar1 = *(undefined1 *)(lVar7 + 0x17);
      *(undefined1 *)(lVar7 + 0x15) = 0;
      *(undefined1 *)(lVar7 + 0x17) = 0;
      *(undefined1 *)(lVar7 + 0x16) = uVar1;
      *(undefined4 *)(param_1 + 0x124) = 7;
      break;
    case 7:
      SDV_StardewValley_Mobile_TapToMove_Reset_06006698(param_1,1);
      SDV_StardewValley_Mobile_TapToMove_CheckForQueuedReadyToHarvestTaps_060066c3(param_1);
      break;
    case 10:
      uVar4 = _UNK_1036d69c0;
      if (*(long *)(param_1 + 0x18) == 0) goto LAB_101fc3d20;
      *(undefined1 *)(*(long *)(param_1 + 0x18) + 0x18) = 1;
      *(undefined4 *)(param_1 + 0x124) = 0xb;
      break;
    case 0xb:
      *(undefined1 *)(*(long *)(param_1 + 0x18) + 0x18) = 0;
      *(undefined4 *)(param_1 + 0x124) = 0;
      break;
    case 0xd:
      SDV_StardewValley_Mobile_TapToMove_attackInNewDirectionUpdate_060066b8(param_1);
    }
  }
  else {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    if ((*pcRam00000001038d59d8 != '\0') || (*(int *)(param_1 + 0x124) == 0)) goto LAB_101fc39c8;
    uVar4 = StardewValley_StardewValley_Game1_get_currentSeason_06002fc4();
    cVar3 = func_0x000100345aa0(uVar4,uRam00000001038ef200);
    if (cVar3 != '\0') {
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      if (*piRam00000001038d5780 == 8) goto LAB_101fc39c8;
    }
    puVar5 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
    if ((puVar5 != (undefined8 *)0x0) &&
       (lRam00000001038d5370 == *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 8)))
    goto LAB_101fc39c8;
    SDV_StardewValley_Mobile_TapToMove_Reset_06006698(param_1,1);
  }
LAB_101fc3a0c:
  cVar3 = SDV_StardewValley_Mobile_TapToMove_CheckToAttackMonsters_060066bb(param_1);
  if (cVar3 == '\0') {
    SDV_StardewValley_Mobile_TapToMove_CheckToRetargetNPC_060066b9(param_1);
    SDV_StardewValley_Mobile_TapToMove_CheckToRetargetFarmAnimal_060066ba(param_1);
    SDV_StardewValley_Mobile_TapToMove_CheckToOpenClosedGate_060066be(param_1);
    SDV_StardewValley_Mobile_TapToMove_CheckToWaterNextTile_060066c4(param_1);
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  lVar7 = *plRam00000001038d5360;
  if (*(char *)(lVar7 + 0x107) == '\0') {
    SDV_StardewValley_Mobile_VirtualJoypad_CheckForTapAttackJoystick_06006764(lVar7);
    SDV_StardewValley_Mobile_VirtualJoypad_CheckForTapJoystickAndButtons_06006765(lVar7);
  }
  lVar7 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if (((*(int *)(lVar7 + 0x178) == 8) ||
      (lVar7 = StardewValley_StardewValley_Game1_get_options_06002fec(),
      *(int *)(lVar7 + 0x178) == 2)) ||
     (lVar7 = StardewValley_StardewValley_Game1_get_options_06002fec(), *(int *)(lVar7 + 0x178) == 2
     )) {
    lVar7 = SDV_StardewValley_Mobile_PinchZoom_get_Instance_06006679();
    uVar4 = _UNK_1036d69a0;
    if (lVar7 == 0) {
LAB_101fc3d20:
      func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101fc3d2c);
      (*pcVar2)();
    }
    SDV_StardewValley_Mobile_PinchZoom_CheckForPinchZoom_06006680();
  }
  return;
}

