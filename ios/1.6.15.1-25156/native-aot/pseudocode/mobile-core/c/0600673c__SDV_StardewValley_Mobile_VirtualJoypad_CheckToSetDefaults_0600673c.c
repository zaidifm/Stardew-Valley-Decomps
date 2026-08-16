/* 0x0600673c StardewValley.Mobile.VirtualJoypad.CheckToSetDefaults @ 0x101fd2cac */

void SDV_StardewValley_Mobile_VirtualJoypad_CheckToSetDefaults_0600673c(undefined8 param_1)

{
  int iVar1;
  ulong uVar2;
  
  if (lRam0000000103976fb8 == 0) {
    iVar1 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
  }
  else {
    func_0x00010119b8f8();
    iVar1 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
  }
  if ((iVar1 == 0) ||
     ((iVar1 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionJoystick_0600672a(), iVar1 == 0 &&
      (uVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionJoystick_0600672a(),
      uVar2 >> 0x20 == 0)))) {
    SDV_StardewValley_Mobile_VirtualJoypad_SetJoystickDefaults_0600673d(param_1);
  }
  iVar1 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonB_06006728();
  if ((iVar1 == 0) ||
     ((iVar1 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonB_06006730(), iVar1 == 0 &&
      (uVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonB_06006730(),
      uVar2 >> 0x20 == 0)))) {
    SDV_StardewValley_Mobile_VirtualJoypad_SetButtonBDefaults_0600673f(param_1);
  }
  iVar1 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonA_06006726();
  if ((iVar1 == 0) ||
     ((iVar1 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonA_0600672d(), iVar1 == 0 &&
      (uVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonA_0600672d(),
      uVar2 >> 0x20 == 0)))) {
    SDV_StardewValley_Mobile_VirtualJoypad_SetButtonADefaults_0600673e(param_1);
  }
  return;
}

