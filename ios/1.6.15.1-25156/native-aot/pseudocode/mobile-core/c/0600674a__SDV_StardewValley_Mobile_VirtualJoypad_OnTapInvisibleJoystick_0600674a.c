/* 0x0600674a StardewValley.Mobile.VirtualJoypad.OnTapInvisibleJoystick @ 0x101fd3e7c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_VirtualJoypad_OnTapInvisibleJoystick_0600674a
          (long param_1,int param_2,int param_3)

{
  int iVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  long *plVar5;
  undefined8 uVar6;
  float fVar7;
  double dVar8;
  
  cVar2 = cRam0000000103911559;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325da0);
    cRam0000000103911559 = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar6 = _UNK_1036d8828;
  if ((lRam00000001038d6bc0 == -8) || (uVar6 = _UNK_1036d8820, lRam00000001038d6bc0 == 0))
  goto LAB_101fd4258;
  iVar1 = *(int *)(lRam00000001038d6bc0 + 8);
  if (iVar1 < 0) {
    iVar1 = iVar1 + 1;
  }
  if (iVar1 >> 1 <= param_2) {
    return 0;
  }
  lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if (*(char *)(lVar4 + 0x168) == '\0') {
LAB_101fd3f48:
    if (*(char *)(param_1 + 0x106) == '\0') {
      lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec();
      if (*(char *)(lVar4 + 0x168) != '\0') {
        return 0;
      }
      iVar1 = *(int *)(*plRam00000001038e4ba8 + 0xa8);
      if (iVar1 < 2) {
        iVar1 = 1;
      }
      if (param_3 <= iVar1) {
        return 0;
      }
    }
  }
  else {
    iVar1 = *(int *)(*plRam00000001038e4ba8 + 0xa8);
    if (iVar1 < 2) {
      iVar1 = 1;
    }
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    if (param_2 <= *piRam00000001038d57b8 + iVar1) goto LAB_101fd3f48;
    uVar6 = _UNK_1036d88d8;
    if (param_1 == 0) goto LAB_101fd4258;
  }
  lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if ((*(char *)(lVar4 + 0x168) == '\0') && (*(char *)(*plRam00000001038e4ba8 + 0xc5) == '\0')) {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar6 = _UNK_1036d88a8;
    if ((lRam00000001038d6bc0 == 0) || (uVar6 = _UNK_1036d88b0, lRam00000001038d6bc0 == -8))
    goto LAB_101fd4258;
    iVar1 = *(int *)(*plRam00000001038e4ba8 + 0xa8);
    if (iVar1 < 2) {
      iVar1 = 1;
    }
    if (*(int *)(lRam00000001038d6bc0 + 0xc) - iVar1 < param_3) {
      return 0;
    }
  }
  if (*(char *)(param_1 + 0x106) == '\0') {
    uVar6 = _UNK_1036d8898;
    if ((param_1 == -0xf0) ||
       (*(int *)(param_1 + 0xf0) = param_2, uVar6 = _UNK_1036d88a0, param_1 == -0xe8))
    goto LAB_101fd4258;
    *(int *)(param_1 + 0xe8) = param_2;
    *(int *)(param_1 + 0xec) = param_3;
    *(int *)(param_1 + 0xf4) = param_3;
    *(undefined1 *)(param_1 + 0x106) = 1;
    *(undefined8 *)(param_1 + 0xe0) = *(undefined8 *)(param_1 + 0xe8);
    if (*(char *)(param_1 + 0xda) != '\0') {
      *(undefined1 *)(param_1 + 0xda) = 0;
    }
  }
  else if (*(char *)(param_1 + 0xda) != '\0') {
    lVar4 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    uVar6 = _UNK_1036d8890;
    if (*(long *)(lVar4 + 0x238) != 0) {
      SDV_StardewValley_Mobile_TapToMove_StopMoving_060066a1();
      return 0;
    }
    goto LAB_101fd4258;
  }
  uVar6 = _UNK_1036d8858;
  if (param_1 != -0xe0) {
    fVar7 = (float)func_0x000100354758((float)*(int *)(param_1 + 0xe0),
                                       (float)*(int *)(param_1 + 0xe4),(float)param_2,(float)param_3
                                      );
    if (20.0 <= fVar7) {
      dVar8 = (double)func_0x00010035d358((double)(param_3 - *(int *)(param_1 + 0xe4)),
                                          (double)(param_2 - *(int *)(param_1 + 0xe0)));
      lVar4 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
      uVar6 = _UNK_1036d8888;
      if (*(long *)(lVar4 + 0x238) == 0) goto LAB_101fd4258;
      SDV_StardewValley_Mobile_TapToMove_MoveJoystickHeld_060066a0
                (((float)dVar8 / 6.2831855) * 360.0);
    }
    else {
      lVar4 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
      uVar6 = _UNK_1036d8868;
      if (*(long *)(lVar4 + 0x238) == 0) goto LAB_101fd4258;
      SDV_StardewValley_Mobile_TapToMove_StopMoving_060066a1();
      plVar5 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
      (**(code **)(*plVar5 + 0x188))();
    }
    uVar6 = _UNK_1036d8878;
    if (param_1 != -0xf0) {
      *(int *)(param_1 + 0xf0) = param_2;
      *(int *)(param_1 + 0xf4) = param_3;
      return 1;
    }
  }
LAB_101fd4258:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fd4264);
  (*pcVar3)();
}

