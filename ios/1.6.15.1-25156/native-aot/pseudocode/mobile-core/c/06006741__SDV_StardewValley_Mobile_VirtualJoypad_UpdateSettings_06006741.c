/* 0x06006741 StardewValley.Mobile.VirtualJoypad.UpdateSettings @ 0x101fd3100 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_UpdateSettings_06006741(long param_1)

{
  code *pcVar1;
  undefined4 uVar2;
  undefined4 extraout_var;
  undefined8 uVar3;
  long lVar4;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  SDV_StardewValley_Mobile_VirtualJoypad_UpdateButtonSizes_06006759(param_1);
  SDV_StardewValley_Mobile_VirtualJoypad_UpdateJoystickAndButtonsStartPositions_06006743(param_1);
  SDV_StardewValley_Mobile_VirtualJoypad_UpdateButtonScales_0600675a(param_1);
  lVar4 = *(long *)(param_1 + 0x70);
  uVar3 = _UNK_1036d8598;
  if (lVar4 != 0) {
    uVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionJoystick_0600672a();
    *(undefined4 *)(lVar4 + 0x38) = uVar2;
    lVar4 = *(long *)(param_1 + 0x70);
    uVar3 = _UNK_1036d85a8;
    if ((lVar4 != 0) &&
       (SDV_StardewValley_Mobile_VirtualJoypad_get_positionJoystick_0600672a(),
       uVar3 = _UNK_1036d85b0, lVar4 != -0x38)) {
      *(undefined4 *)(lVar4 + 0x3c) = extraout_var;
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd31bc);
  (*pcVar1)();
}

