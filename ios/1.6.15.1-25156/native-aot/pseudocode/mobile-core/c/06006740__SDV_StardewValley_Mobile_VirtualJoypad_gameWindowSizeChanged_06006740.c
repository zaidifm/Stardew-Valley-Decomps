/* 0x06006740 StardewValley.Mobile.VirtualJoypad.gameWindowSizeChanged @ 0x101fd30c0 */

void SDV_StardewValley_Mobile_VirtualJoypad_gameWindowSizeChanged_06006740(undefined8 param_1)

{
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  SDV_StardewValley_Mobile_VirtualJoypad_CheckToSetDefaults_0600673c(param_1);
  SDV_StardewValley_Mobile_VirtualJoypad_UpdateSettings_06006741(param_1);
  return;
}

