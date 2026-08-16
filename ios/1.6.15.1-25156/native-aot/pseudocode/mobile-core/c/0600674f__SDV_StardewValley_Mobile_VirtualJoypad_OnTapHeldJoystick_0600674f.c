/* 0x0600674f StardewValley.Mobile.VirtualJoypad.OnTapHeldJoystick @ 0x101fd4650 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_OnTapHeldJoystick_0600674f
               (long param_1,int param_2,int param_3)

{
  int *piVar1;
  int iVar2;
  code *pcVar3;
  char cVar4;
  long lVar5;
  long *plVar6;
  undefined8 *puVar7;
  undefined8 uVar8;
  float fVar9;
  float fVar10;
  double dVar11;
  double dVar12;
  
  cVar4 = cRam000000010391155e;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103325db6);
    cRam000000010391155e = '\x01';
  }
  cVar4 = SDV_StardewValley_Mobile_VirtualJoypad_get_showJoystick_06006750();
  if (cVar4 == '\0') {
    return;
  }
  uVar8 = _UNK_1036d8980;
  if ((param_1 == 0) || (uVar8 = _UNK_1036d8988, param_1 == -0xe8)) goto LAB_101fd4ad8;
  fVar9 = (float)func_0x000100354758((float)*(int *)(param_1 + 0xe8),(float)*(int *)(param_1 + 0xec)
                                     ,(float)param_2,(float)param_3);
  uVar8 = _UNK_1036d8990;
  if (param_1 == -0xf0) goto LAB_101fd4ad8;
  fVar10 = (float)func_0x000100354758((float)*(int *)(param_1 + 0xf0),
                                      (float)*(int *)(param_1 + 0xf4),(float)param_2,(float)param_3)
  ;
  if ((fVar9 < 20.0) || ((float)*(int *)(param_1 + 0xdc) < fVar10)) {
    if (20.0 <= fVar9) {
      return;
    }
    lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    uVar8 = _UNK_1036d89a0;
    if (*(long *)(lVar5 + 0x238) != 0) {
      SDV_StardewValley_Mobile_TapToMove_StopMoving_060066a1();
      plVar6 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
      (**(code **)(*plVar6 + 0x188))();
      return;
    }
    goto LAB_101fd4ad8;
  }
  dVar11 = (double)func_0x00010035d358((double)(param_3 - *(int *)(param_1 + 0xec)),
                                       (double)(param_2 - *(int *)(param_1 + 0xe8)));
  puVar7 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
  if (((puVar7 == (undefined8 *)0x0) ||
      (lRam00000001038d5368 != *(long *)(*(long *)(*(long *)*puVar7 + 0x10) + 8))) &&
     (*(char *)(param_1 + 0xda) != '\0')) {
    lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    uVar8 = _UNK_1036d8a48;
    if (*(long *)(lVar5 + 0x238) != 0) {
      SDV_StardewValley_Mobile_TapToMove_StopMoving_060066a1();
      return;
    }
    goto LAB_101fd4ad8;
  }
  lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
  uVar8 = _UNK_1036d89b0;
  if (lVar5 == 0) goto LAB_101fd4ad8;
  fVar10 = ((float)dVar11 / 6.2831855) * 360.0;
  if (*(int *)(lVar5 + 0x178) == 1) {
    lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    uVar8 = _UNK_1036d8a38;
    if (*(long *)(lVar5 + 0x238) == 0) goto LAB_101fd4ad8;
    SDV_StardewValley_Mobile_TapToMove_OnButtonAHeld_060066a2(fVar10);
  }
  else {
    lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
    if (((*(int *)(lVar5 + 0x178) == 4) ||
        (lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec(),
        *(int *)(lVar5 + 0x178) == 7)) ||
       ((lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec(),
        *(int *)(lVar5 + 0x178) == 6 ||
        (lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec(),
        *(int *)(lVar5 + 0x178) == 8)))) {
LAB_101fd4820:
      lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
      uVar8 = _UNK_1036d89c8;
      if (*(long *)(lVar5 + 0x238) == 0) goto LAB_101fd4ad8;
      SDV_StardewValley_Mobile_TapToMove_MoveJoystickHeld_060066a0(fVar10);
    }
    else {
      lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
      if (*(int *)(lVar5 + 0x178) == 5) {
        lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar8 = _UNK_1036d8a18;
        if (lVar5 == 0) goto LAB_101fd4ad8;
        puVar7 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
        if ((puVar7 != (undefined8 *)0x0) &&
           (lRam00000001038c7a50 == *(long *)(*(long *)(*(long *)*puVar7 + 0x10) + 0x18))) {
          lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          uVar8 = _UNK_1036d8a20;
          if (lVar5 == 0) goto LAB_101fd4ad8;
          plVar6 = (long *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
          cVar4 = (**(code **)(*plVar6 + 0x3f8))();
          if (cVar4 == '\0') goto LAB_101fd4820;
        }
      }
    }
  }
  fVar10 = (float)*(int *)(param_1 + 0xdc) * 0.6;
  if (fVar9 == fVar10) {
    if (-1 < (int)fVar9) {
      fVar9 = fVar10;
    }
  }
  else if (fVar10 <= fVar9) {
    fVar9 = fVar10;
  }
  dVar11 = (double)func_0x00010035d358((double)(*(int *)(param_1 + 0xec) - param_3),
                                       (double)(*(int *)(param_1 + 0xe8) - param_2));
  uVar8 = _UNK_1036d89d0;
  if (((*(long *)(param_1 + 0x70) != 0) && (uVar8 = _UNK_1036d89d8, param_1 != -0xe0)) &&
     (piVar1 = (int *)(*(long *)(param_1 + 0x70) + 0x38), uVar8 = _UNK_1036d89e0,
     piVar1 != (int *)0x0)) {
    iVar2 = *(int *)(param_1 + 0xe0);
    dVar12 = (double)(float)dVar11;
    dVar11 = (double)_cos(dVar12);
    *piVar1 = iVar2 - (int)(dVar11 * (double)fVar9);
    lVar5 = *(long *)(param_1 + 0x70);
    uVar8 = _UNK_1036d89e8;
    if ((lVar5 != 0) && (uVar8 = _UNK_1036d89f0, lVar5 != -0x38)) {
      iVar2 = *(int *)(param_1 + 0xe4);
      dVar11 = (double)_sin(dVar12);
      *(int *)(lVar5 + 0x3c) = iVar2 - (int)(dVar11 * (double)fVar9);
      *(double *)(param_1 + 0x150) = dVar12;
      *(undefined4 *)(param_1 + 200) = 2;
      return;
    }
  }
LAB_101fd4ad8:
  func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fd4ae4);
  (*pcVar3)();
}

