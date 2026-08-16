/* 0x0600675f StardewValley.Mobile.VirtualJoypad.CheckForManualWeaponControlTaps @ 0x101fd6704 */

void SDV_StardewValley_Mobile_VirtualJoypad_CheckForManualWeaponControlTaps_0600675f(long param_1)

{
  char cVar1;
  
  if (lRam0000000103976fb8 == 0) {
    cVar1 = *(char *)(param_1 + 0x107);
  }
  else {
    func_0x00010119b8f8();
    cVar1 = *(char *)(param_1 + 0x107);
  }
  if (cVar1 == '\0') {
    SDV_StardewValley_Mobile_VirtualJoypad_CheckForTapAttackJoystick_06006764(param_1);
    SDV_StardewValley_Mobile_VirtualJoypad_CheckForTapJoystickAndButtons_06006765(param_1);
  }
  return;
}

