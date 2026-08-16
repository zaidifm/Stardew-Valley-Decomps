/* 0x06006721 StardewValley.Mobile.VirtualJoypad.set_joystickHeld @ 0x101fd14d0 */

void SDV_StardewValley_Mobile_VirtualJoypad_set_joystickHeld_06006721(long param_1,char param_2)

{
  char *pcVar1;
  
  pcVar1 = (char *)(param_1 + 0x106);
  if ((*(char *)(param_1 + 0x106) == '\0') || (param_2 != '\0')) {
    *pcVar1 = param_2;
    if (param_2 == '\0') {
      return;
    }
    pcVar1 = (char *)(param_1 + 0xda);
    if (*pcVar1 == '\0') {
      return;
    }
  }
  else {
    *(undefined1 *)(param_1 + 0x105) = 1;
  }
  *pcVar1 = '\0';
  return;
}

