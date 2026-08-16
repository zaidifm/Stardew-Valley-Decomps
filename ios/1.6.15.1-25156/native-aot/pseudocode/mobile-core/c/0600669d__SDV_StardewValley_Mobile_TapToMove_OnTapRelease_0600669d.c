/* 0x0600669d StardewValley.Mobile.TapToMove.OnTapRelease @ 0x101fb2394 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_OnTapRelease_0600669d
               (long param_1,int param_2,int param_3,int param_4,int param_5)

{
  int iVar1;
  code *pcVar2;
  char cVar3;
  long lVar4;
  undefined8 *puVar5;
  long *plVar6;
  undefined8 uVar7;
  undefined8 uVar8;
  
  cVar3 = cRam00000001039114ac;
  if (lRam0000000103976fb8 == 0) {
    if (cRam00000001039114ac != '\0') goto LAB_101fb23d8;
LAB_101fb2510:
    func_0x00010119b908(&UNK_103325180);
    cRam00000001039114ac = '\x01';
    *(undefined2 *)(param_1 + 0xfe) = 0;
  }
  else {
    func_0x00010119b8f8();
    if (cVar3 == '\0') goto LAB_101fb2510;
LAB_101fb23d8:
    *(undefined2 *)(param_1 + 0xfe) = 0;
  }
  lVar4 = SDV_StardewValley_Mobile_PinchZoom_get_Instance_06006679();
  if (*(char *)(lVar4 + 0x1c) != '\0') {
    return;
  }
  lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar7 = _UNK_1036d3db8;
  if (lVar4 == 0) goto LAB_101fb2988;
  lVar4 = StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
  if (lVar4 == 0) {
LAB_101fb2428:
    lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec();
    if (*(int *)(lVar4 + 0x178) == 2) {
      return;
    }
    lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec();
    if (*(int *)(lVar4 + 0x178) == 3) {
      return;
    }
    lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec();
    if (*(int *)(lVar4 + 0x178) == 8) {
      return;
    }
  }
  else {
    lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar7 = _UNK_1036d3ef0;
    if (lVar4 == 0) goto LAB_101fb2988;
    puVar5 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
    if ((puVar5 == (undefined8 *)0x0) ||
       (lRam00000001038c7ab0 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18)))
    goto LAB_101fb2428;
  }
  lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if ((*(int *)(lVar4 + 0x178) == 1) && (*(char *)(param_1 + 0xf7) != '\0')) {
    lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    if (*(char *)(*(long *)(lVar4 + 0x530) + 0x68) != '\0') {
      return;
    }
    *(undefined1 *)(param_1 + 0xf7) = 0;
  }
  if ((*(char *)(param_1 + 0x100) != '\0') || (*pcRam00000001038d6a30 != '\0')) {
    *(undefined1 *)(param_1 + 0x100) = 0;
    return;
  }
  cVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_get_inMiniGameWhereWeDontWantTaps_060066cc();
  if (cVar3 != '\0') {
    return;
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  lVar4 = *plRam00000001038d5360;
  if (*(char *)(lVar4 + 0x106) != '\0') {
    return;
  }
  if (*(char *)(lVar4 + 0xd8) != '\0') {
    return;
  }
  if (*(char *)(lVar4 + 0xd9) != '\0') {
    return;
  }
  if (*(char *)(param_1 + 0x104) != '\0') {
    *(undefined1 *)(param_1 + 0x104) = 0;
    return;
  }
  lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar7 = _UNK_1036d3de8;
  if (lVar4 == 0) goto LAB_101fb2988;
  puVar5 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
  if ((puVar5 == (undefined8 *)0x0) ||
     (lRam00000001038c7a00 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18))) {
    lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar7 = _UNK_1036d3ea8;
    if (lVar4 == 0) goto LAB_101fb2988;
    puVar5 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
    if ((puVar5 == (undefined8 *)0x0) ||
       (lRam00000001038c7ab0 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18))) {
      lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      if ((*(char *)(lVar4 + 0x76c) != '\0') &&
         (lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a(),
         *(char *)(*(long *)(lVar4 + 0x530) + 0x68) != '\0')) {
        StardewValley_StardewValley_Game1_get_player_06002f9a();
        func_0x00010185bb10();
      }
      *(undefined1 *)(*(long *)(param_1 + 0x18) + 0x14) = 0;
      *(undefined1 *)(*(long *)(param_1 + 0x18) + 0x18) = 0;
      uVar7 = _UNK_1036d3ec8;
      if (*(long *)(param_1 + 0x18) == 0) goto LAB_101fb2988;
      *(undefined1 *)(*(long *)(param_1 + 0x18) + 0x16) = 1;
    }
  }
  lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar7 = _UNK_1036d3df0;
  if (lVar4 == 0) goto LAB_101fb2988;
  puVar5 = (undefined8 *)StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
  if ((((puVar5 != (undefined8 *)0x0) &&
       (lRam00000001038c7420 == *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18))) &&
      (puVar5 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8(),
      puVar5 != (undefined8 *)0x0)) &&
     (lRam00000001038c6c08 == *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x10))) {
    plVar6 = (long *)SDV_StardewValley_Mobile_TapToMoveUtils_GetFurnitureClickedOn_060066e4
                               (param_4 + param_2,param_5 + param_3);
    if ((plVar6 == (long *)0x0) || (*(int *)(plVar6[0x41] + 0x68) == 0xc)) {
LAB_101fb2780:
      *(undefined4 *)(param_1 + 0x124) = 5;
      return;
    }
    lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar7 = _UNK_1036d3ea0;
    if (lVar4 != 0) {
      uVar7 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
      uVar8 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      (**(code **)(*plVar6 + 0x578))(plVar6,uVar7,0,uVar8,0);
      return;
    }
    goto LAB_101fb2988;
  }
  if (*(char *)(param_1 + 0xfb) == '\0') {
    lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar7 = _UNK_1036d3df8;
    if (lVar4 != 0) {
      lVar4 = StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
      if (lVar4 != 0) {
        lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar7 = _UNK_1036d3e28;
        if (lVar4 == 0) goto LAB_101fb2988;
        lVar4 = StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
        if ((0 < *(int *)(*(long *)(lVar4 + 0xd0) + 0x68)) &&
           (lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a(),
           *(char *)(*(long *)(lVar4 + 0x548) + 0x68) != '\0')) {
          lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          uVar7 = _UNK_1036d3e50;
          if (lVar4 == 0) goto LAB_101fb2988;
          puVar5 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
          if (((puVar5 == (undefined8 *)0x0) ||
              (lRam00000001038c7a00 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18))) &&
             (((*(uint *)(param_1 + 0x124) | 8) == 8 ||
              (lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a(),
              *(char *)(*(long *)(lVar4 + 0x530) + 0x68) != '\0')))) goto LAB_101fb2780;
        }
      }
      lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar7 = _UNK_1036d3e00;
      if (lVar4 != 0) {
        puVar5 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
        if (((puVar5 == (undefined8 *)0x0) ||
            (lRam00000001038c7ab0 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18))) ||
           (lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a(),
           *(char *)(lVar4 + 0x772) == '\0')) {
          if ((*(uint *)(param_1 + 0x124) | 4) != 0xc) {
            return;
          }
          SDV_StardewValley_Mobile_TapToMove_Reset_06006698(param_1,1);
          SDV_StardewValley_Mobile_TapToMove_CheckForQueuedReadyToHarvestTaps_060066c3(param_1);
          return;
        }
        *(undefined4 *)(param_1 + 0x124) = 6;
        lVar4 = StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
        if (((lVar4 != 0) &&
            (puVar5 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3()
            , puVar5 != (undefined8 *)0x0)) &&
           (lRam00000001038d5368 == *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 8))) {
          return;
        }
        lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec();
        uVar7 = _UNK_1036d3e10;
        if (lVar4 != 0) {
          if (*(int *)(lVar4 + 0x178) == 0) {
            if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
              func_0x0001003319b0();
            }
            uVar7 = _UNK_1036d3e20;
            if (*plRam00000001038d5360 != 0) {
              SDV_StardewValley_Mobile_VirtualJoypad_set_showJoypad_0600675d
                        (*plRam00000001038d5360,0);
              return;
            }
          }
          else {
            if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
              func_0x0001003319b0();
            }
            uVar7 = _UNK_1036d3e18;
            if (*plRam00000001038d5360 != 0) {
              SDV_StardewValley_Mobile_VirtualJoypad_set_showJoypad_0600675d
                        (*plRam00000001038d5360,*(undefined1 *)(param_1 + 0x14c));
              return;
            }
          }
        }
      }
    }
    goto LAB_101fb2988;
  }
  *(undefined1 *)(param_1 + 0xfb) = 0;
  if (((*(long *)(param_1 + 0x98) == 0) ||
      (lVar4 = StardewValley_StardewValley_Menus_TutorialManager_get_Instance_06005e62(),
      *(long *)(lVar4 + 0xa0) != 0)) ||
     ((*(long *)(lVar4 + 0x98) != 0 ||
      ((*(long *)(lVar4 + 0x90) != 0 && (*(long *)(*(long *)(lVar4 + 0x90) + 0x90) != 0)))))) {
LAB_101fb2634:
    uVar7 = _UNK_1036d3e68;
    if (*(long *)(param_1 + 0x18) == 0) {
LAB_101fb2988:
      func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101fb2994);
      (*pcVar2)();
    }
    *(undefined1 *)(*(long *)(param_1 + 0x18) + 0x18) = 1;
    *(undefined4 *)(param_1 + 0x124) = 4;
  }
  else {
    plVar6 = *(long **)(param_1 + 0x98);
    iVar1 = *(int *)(plVar6[0xb] + 0x68);
    if ((iVar1 != 0x4ca) &&
       (((iVar1 != 0x57a && (iVar1 != 0x51c)) && (*(int *)(plVar6[0x41] + 0x68) != 0xe)))) {
      lVar4 = *(long *)(*(long *)(*(long *)*plVar6 + 0x10) + 0x20);
      if ((lRam00000001038c74e8 != lVar4) && (lRam00000001038c7508 != lVar4)) {
        lVar4 = (*(code *)((long *)*plVar6)[0x3d])();
        uVar7 = _UNK_1036d3e90;
        if (lVar4 == 0) goto LAB_101fb2988;
        cVar3 = func_0x000100350144(lVar4,uRam00000001038f4150);
        if (cVar3 == '\0') goto LAB_101fb2634;
      }
    }
    *(undefined4 *)(param_1 + 0x124) = 10;
  }
  return;
}

