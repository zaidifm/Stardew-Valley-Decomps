/* 0x0600673a StardewValley.Mobile.VirtualJoypad.OnClickSetToDefaults @ 0x101fd296c */

void SDV_StardewValley_Mobile_VirtualJoypad_OnClickSetToDefaults_0600673a(undefined8 param_1)

{
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  SDV_StardewValley_Mobile_VirtualJoypad_SetJoystickDefaults_0600673d(param_1);
  SDV_StardewValley_Mobile_VirtualJoypad_SetButtonBDefaults_0600673f(param_1);
  SDV_StardewValley_Mobile_VirtualJoypad_SetButtonADefaults_0600673e(param_1);
  SDV_StardewValley_Mobile_VirtualJoypad_UpdateSettings_06006741(param_1);
  return;
}

