/* 0x0600666a StardewValley.Mobile.MobileKeyStates.Reset @ 0x101faef70 */

void SDV_StardewValley_Mobile_MobileKeyStates_Reset_0600666a(long param_1)

{
  undefined4 uVar1;
  
  if (lRam0000000103976fb8 == 0) {
    *(undefined1 *)(param_1 + 0x18) = 0;
  }
  else {
    func_0x00010119b8f8();
    *(undefined1 *)(param_1 + 0x18) = 0;
  }
  *(undefined4 *)(param_1 + 0x19) = 0;
  uVar1 = *(undefined4 *)(param_1 + 0x21);
  *(undefined4 *)(param_1 + 0x21) = 0;
  *(undefined4 *)(param_1 + 0x14) = 0x10000;
  *(undefined4 *)(param_1 + 0x1d) = uVar1;
  return;
}

