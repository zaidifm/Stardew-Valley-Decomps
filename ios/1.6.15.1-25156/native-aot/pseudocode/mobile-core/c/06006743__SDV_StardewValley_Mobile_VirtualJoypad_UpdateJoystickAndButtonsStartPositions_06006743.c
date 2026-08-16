/* 0x06006743 StardewValley.Mobile.VirtualJoypad.UpdateJoystickAndButtonsStartPositions @ 0x101fd3204 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_UpdateJoystickAndButtonsStartPositions_06006743
               (long param_1)

{
  code *pcVar1;
  undefined4 uVar2;
  undefined4 extraout_var;
  undefined4 extraout_var_00;
  undefined4 extraout_var_01;
  undefined8 uVar3;
  long lVar4;
  
  if (lRam0000000103976fb8 == 0) {
    lVar4 = *(long *)(param_1 + 0x70);
  }
  else {
    func_0x00010119b8f8();
    lVar4 = *(long *)(param_1 + 0x70);
  }
  if (lVar4 != 0) {
    uVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionJoystick_0600672a();
    uVar3 = _UNK_1036d85f0;
    if (param_1 == -0xe0) goto LAB_101fd3318;
    *(undefined4 *)(param_1 + 0xe0) = uVar2;
    SDV_StardewValley_Mobile_VirtualJoypad_get_positionJoystick_0600672a();
    *(undefined4 *)(param_1 + 0xe4) = extraout_var;
  }
  lVar4 = *(long *)(param_1 + 0x78);
  if (lVar4 != 0) {
    uVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonA_0600672d();
    *(undefined4 *)(lVar4 + 0x38) = uVar2;
    lVar4 = *(long *)(param_1 + 0x78);
    uVar3 = _UNK_1036d85e0;
    if ((lVar4 == 0) ||
       (SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonA_0600672d(),
       uVar3 = _UNK_1036d85e8, lVar4 == -0x38)) goto LAB_101fd3318;
    *(undefined4 *)(lVar4 + 0x3c) = extraout_var_00;
  }
  lVar4 = *(long *)(param_1 + 0x80);
  if (lVar4 != 0) {
    uVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonB_06006730();
    *(undefined4 *)(lVar4 + 0x38) = uVar2;
    lVar4 = *(long *)(param_1 + 0x80);
    uVar3 = _UNK_1036d85c8;
    if ((lVar4 == 0) ||
       (SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonB_06006730(),
       uVar3 = _UNK_1036d85d0, lVar4 == -0x38)) {
LAB_101fd3318:
      func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd3324);
      (*pcVar1)();
    }
    *(undefined4 *)(lVar4 + 0x3c) = extraout_var_01;
  }
  return;
}

