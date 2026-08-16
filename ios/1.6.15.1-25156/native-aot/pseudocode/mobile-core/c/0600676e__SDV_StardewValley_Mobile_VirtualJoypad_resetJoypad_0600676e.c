/* 0x0600676e StardewValley.Mobile.VirtualJoypad.resetJoypad @ 0x101fd8be8 */

void SDV_StardewValley_Mobile_VirtualJoypad_resetJoypad_0600676e(long param_1)

{
  char cVar1;
  
  if (lRam0000000103976fb8 == 0) {
    cVar1 = *(char *)(param_1 + 0x106);
  }
  else {
    func_0x00010119b8f8();
    cVar1 = *(char *)(param_1 + 0x106);
  }
  *(undefined2 *)(param_1 + 0x158) = 0;
  *(undefined1 *)(param_1 + 0x15a) = 0;
  if (cVar1 != '\0') {
    *(undefined1 *)(param_1 + 0x105) = 1;
  }
  *(undefined1 *)(param_1 + 0x106) = 0;
  *(undefined2 *)(param_1 + 0xd8) = 0;
  return;
}

