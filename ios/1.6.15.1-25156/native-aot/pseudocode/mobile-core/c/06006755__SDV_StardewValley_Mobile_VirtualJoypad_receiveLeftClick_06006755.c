/* 0x06006755 StardewValley.Mobile.VirtualJoypad.receiveLeftClick @ 0x101fd50cc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_receiveLeftClick_06006755
               (long param_1,undefined4 param_2,undefined4 param_3)

{
  int *piVar1;
  code *pcVar2;
  char cVar3;
  int iVar4;
  undefined4 uVar5;
  long *plVar6;
  undefined8 *puVar7;
  long lVar8;
  undefined8 uVar9;
  double dVar10;
  
  cVar3 = cRam0000000103911564;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103911564 == '\0') goto LAB_101fd55e8;
LAB_101fd5108:
    cVar3 = *(char *)(param_1 + 0x107);
  }
  else {
    func_0x00010119b8f8();
    if (cVar3 != '\0') goto LAB_101fd5108;
LAB_101fd55e8:
    func_0x00010119b908(&UNK_103325dd0);
    cRam0000000103911564 = '\x01';
    cVar3 = *(char *)(param_1 + 0x107);
  }
  if (cVar3 == '\0') {
    lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec();
    if ((*(char *)(lVar8 + 0x17c) != '\0') &&
       (cVar3 = (**(code **)(**(long **)(param_1 + 0x68) + 0x90))
                          (*(long **)(param_1 + 0x68),param_2,param_3), cVar3 != '\0')) {
      *puRam00000001038d6a30 = 1;
      SDV_StardewValley_Mobile_VirtualJoypad_set_showJoypad_0600675d
                (param_1,*(char *)(param_1 + 0x104) == '\0');
    }
    if (*(char *)(param_1 + 0x106) != '\0') {
      return;
    }
    if (*(char *)(param_1 + 0x105) != '\0') {
      return;
    }
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    if (*pcRam00000001038d5390 == '\0') {
      return;
    }
    lVar8 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    if (*(char *)(lVar8 + 0x76f) != '\0') {
      return;
    }
    lVar8 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    if ((((*(char *)(*(long *)(lVar8 + 0x238) + 0xfe) == '\0') ||
         (lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec(),
         *(int *)(lVar8 + 0x178) == 4)) ||
        (lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec(),
        *(int *)(lVar8 + 0x178) == 7)) ||
       ((lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec(),
        *(int *)(lVar8 + 0x178) == 6 ||
        (lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec(),
        *(int *)(lVar8 + 0x178) == 8)))) {
LAB_101fd546c:
      lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec();
      if (*(int *)(lVar8 + 0x178) == 2) {
        SDV_StardewValley_Mobile_VirtualJoypad_SetInvisbleJoystickBounds_06006745(param_1);
        return;
      }
      lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec();
      if (*(int *)(lVar8 + 0x178) != 3) {
        return;
      }
      SDV_StardewValley_Mobile_VirtualJoypad_SetInvisbleJoystickBoundsOneButton_06006746(param_1);
      return;
    }
    lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec();
    if (*(int *)(lVar8 + 0x178) != 5) {
      return;
    }
    lVar8 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar9 = _UNK_1036d8bb8;
    if (lVar8 != 0) {
      puVar7 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
      if (puVar7 == (undefined8 *)0x0) {
        return;
      }
      if (lRam00000001038c7a50 != *(long *)(*(long *)(*(long *)*puVar7 + 0x10) + 0x18)) {
        return;
      }
      lVar8 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar9 = _UNK_1036d8bc0;
      if (lVar8 != 0) {
        plVar6 = (long *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
        cVar3 = (**(code **)(*plVar6 + 0x3f8))();
        if (cVar3 != '\0') {
          return;
        }
        goto LAB_101fd546c;
      }
    }
    goto LAB_101fd5894;
  }
  *(undefined4 *)(param_1 + 0x144) = param_2;
  *(undefined4 *)(param_1 + 0x148) = param_3;
  *(undefined1 *)(param_1 + 0x14c) = 1;
  *puRam00000001038d6a30 = 1;
  cVar3 = (**(code **)(**(long **)(param_1 + 0xb0) + 0x90))
                    (*(long **)(param_1 + 0xb0),param_2,param_3);
  if (cVar3 == '\0') {
    lVar8 = *(long *)(param_1 + 0x70);
    uVar9 = _UNK_1036d8c18;
    if ((lVar8 == 0) || (uVar9 = _UNK_1036d8c20, (undefined4 *)(lVar8 + 0x38) == (undefined4 *)0x0))
    goto LAB_101fd5894;
    dVar10 = (double)StardewValley_StardewValley_Utility_Distance_060042a9
                               (*(undefined4 *)(lVar8 + 0x38),*(undefined4 *)(lVar8 + 0x3c),param_2,
                                param_3);
    iVar4 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
    if (iVar4 < 0) {
      iVar4 = iVar4 + 1;
    }
    if (dVar10 < (double)(iVar4 >> 1)) goto LAB_101fd52b0;
    cVar3 = (**(code **)(**(long **)(param_1 + 0xb8) + 0x90))
                      (*(long **)(param_1 + 0xb8),param_2,param_3);
    if (cVar3 == '\0') {
      lVar8 = *(long *)(param_1 + 0x78);
      uVar9 = _UNK_1036d8cc8;
      if ((lVar8 == 0) ||
         (uVar9 = _UNK_1036d8cd0, (undefined4 *)(lVar8 + 0x38) == (undefined4 *)0x0))
      goto LAB_101fd5894;
      dVar10 = (double)StardewValley_StardewValley_Utility_Distance_060042a9
                                 (*(undefined4 *)(lVar8 + 0x38),*(undefined4 *)(lVar8 + 0x3c),
                                  param_2,param_3);
      iVar4 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonA_06006726();
      if (iVar4 < 0) {
        iVar4 = iVar4 + 1;
      }
      if (dVar10 < (double)(iVar4 >> 1)) goto LAB_101fd51ec;
    }
    else {
LAB_101fd51ec:
      lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec();
      if (*(int *)(lVar8 + 0x178) != 1) {
        uVar9 = _UNK_1036d8ca8;
        if ((*(long *)(param_1 + 0xb8) == 0) ||
           (piVar1 = (int *)(*(long *)(param_1 + 0xb8) + 0x38), uVar9 = _UNK_1036d8cb0,
           piVar1 == (int *)0x0)) goto LAB_101fd5894;
        *(int *)(param_1 + 0x140) = *piVar1 + -4;
        uVar9 = _UNK_1036d8cb8;
        if (*(long *)(param_1 + 0xa0) == 0) goto LAB_101fd5894;
        *(undefined4 *)(*(long *)(param_1 + 0xa0) + 0x80) = 0x90;
        lVar8 = *(long *)(param_1 + 0xa0);
        uVar5 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonA_06006726();
        uVar9 = _UNK_1036d8cc0;
        if (lVar8 == 0) goto LAB_101fd5894;
        func_0x000101f10d44(lVar8,uVar5);
        uVar9 = *(undefined8 *)(param_1 + 0x78);
        goto LAB_101fd52f8;
      }
    }
    cVar3 = (**(code **)(**(long **)(param_1 + 0xc0) + 0x90))
                      (*(long **)(param_1 + 0xc0),param_2,param_3);
    if (cVar3 == '\0') {
      lVar8 = *(long *)(param_1 + 0x80);
      uVar9 = _UNK_1036d8c98;
      if ((lVar8 == 0) ||
         (uVar9 = _UNK_1036d8ca0, (undefined4 *)(lVar8 + 0x38) == (undefined4 *)0x0))
      goto LAB_101fd5894;
      dVar10 = (double)StardewValley_StardewValley_Utility_Distance_060042a9
                                 (*(undefined4 *)(lVar8 + 0x38),*(undefined4 *)(lVar8 + 0x3c),
                                  param_2,param_3);
      iVar4 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonB_06006728();
      if (iVar4 < 0) {
        iVar4 = iVar4 + 1;
      }
      if (dVar10 < (double)(iVar4 >> 1)) goto LAB_101fd525c;
    }
    else {
LAB_101fd525c:
      lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec();
      if (*(int *)(lVar8 + 0x178) != 1) {
        uVar9 = _UNK_1036d8c78;
        if ((*(long *)(param_1 + 0xc0) == 0) ||
           (piVar1 = (int *)(*(long *)(param_1 + 0xc0) + 0x38), uVar9 = _UNK_1036d8c80,
           piVar1 == (int *)0x0)) {
LAB_101fd5894:
          func_0x0001003316f4(0xee,uVar9);
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101fd58a0);
          (*pcVar2)();
        }
        *(int *)(param_1 + 0x140) = *piVar1 + -4;
        uVar9 = _UNK_1036d8c88;
        if (*(long *)(param_1 + 0xa0) == 0) goto LAB_101fd5894;
        *(undefined4 *)(*(long *)(param_1 + 0xa0) + 0x80) = 0x91;
        lVar8 = *(long *)(param_1 + 0xa0);
        uVar5 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonB_06006728();
        uVar9 = _UNK_1036d8c90;
        if (lVar8 == 0) goto LAB_101fd5894;
        func_0x000101f10d44(lVar8,uVar5);
        uVar9 = *(undefined8 *)(param_1 + 0x80);
        goto LAB_101fd52f8;
      }
    }
    cVar3 = (**(code **)(**(long **)(param_1 + 0x98) + 0x90))
                      (*(long **)(param_1 + 0x98),param_2,param_3);
    if (cVar3 == '\0') {
      cVar3 = (**(code **)(**(long **)(param_1 + 0x90) + 0x90))
                        (*(long **)(param_1 + 0x90),param_2,param_3);
      if (cVar3 == '\0') {
        plVar6 = *(long **)(*(long *)(param_1 + 0xa8) + 0x90);
        cVar3 = (**(code **)(*plVar6 + 0x90))(plVar6,param_2,param_3);
        if (cVar3 == '\0') {
          (**(code **)(**(long **)(param_1 + 0xa0) + 0x1c8))
                    (*(long **)(param_1 + 0xa0),param_2,param_3);
        }
        else {
          (**(code **)(**(long **)(param_1 + 0xa8) + 0x1c8))
                    (*(long **)(param_1 + 0xa8),param_2,param_3);
          SDV_StardewValley_Mobile_VirtualJoypad_OnClickSetToDefaults_0600673a(param_1);
        }
      }
      else {
        SDV_StardewValley_Mobile_VirtualJoypad_set_adjustmentMode_06006723(param_1,0);
        *puRam00000001038d6a30 = 0;
        func_0x000101f177cc();
        func_0x000101729ed8();
      }
    }
    else {
      SDV_StardewValley_Mobile_VirtualJoypad_set_adjustmentMode_06006723(param_1,0);
      *puRam00000001038d6a30 = 0;
      SDV_StardewValley_Mobile_VirtualJoypad_RevertSizeAndPositions_06006754(param_1);
      func_0x000101729ed8();
    }
  }
  else {
LAB_101fd52b0:
    uVar9 = _UNK_1036d8be0;
    if ((*(long *)(param_1 + 0xb0) == 0) ||
       (piVar1 = (int *)(*(long *)(param_1 + 0xb0) + 0x38), uVar9 = _UNK_1036d8be8,
       piVar1 == (int *)0x0)) goto LAB_101fd5894;
    *(int *)(param_1 + 0x140) = *piVar1 + -4;
    uVar9 = _UNK_1036d8bf0;
    if (*(long *)(param_1 + 0xa0) == 0) goto LAB_101fd5894;
    *(undefined4 *)(*(long *)(param_1 + 0xa0) + 0x80) = 0x8f;
    lVar8 = *(long *)(param_1 + 0xa0);
    uVar5 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
    uVar9 = _UNK_1036d8bf8;
    if (lVar8 == 0) goto LAB_101fd5894;
    func_0x000101f10d44(lVar8,uVar5);
    uVar9 = *(undefined8 *)(param_1 + 0x70);
LAB_101fd52f8:
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x88) = uVar9;
    *(undefined1 *)(((ulong)(param_1 + 0x88) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
  }
  plVar6 = *(long **)(*(long *)(param_1 + 0xa8) + 0x90);
  cVar3 = (**(code **)(*plVar6 + 0x90))(plVar6,param_2,param_3);
  if (cVar3 != '\0') {
    (**(code **)(**(long **)(param_1 + 0xa8) + 0x1c8))(*(long **)(param_1 + 0xa8),param_2,param_3);
    SDV_StardewValley_Mobile_VirtualJoypad_SetJoystickDefaults_0600673d(param_1);
    SDV_StardewValley_Mobile_VirtualJoypad_SetButtonBDefaults_0600673f(param_1);
    SDV_StardewValley_Mobile_VirtualJoypad_SetButtonADefaults_0600673e(param_1);
    SDV_StardewValley_Mobile_VirtualJoypad_UpdateSettings_06006741(param_1);
  }
  return;
}

