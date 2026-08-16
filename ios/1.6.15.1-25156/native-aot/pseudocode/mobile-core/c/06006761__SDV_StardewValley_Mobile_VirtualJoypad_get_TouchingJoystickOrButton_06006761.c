/* 0x06006761 StardewValley.Mobile.VirtualJoypad.get_TouchingJoystickOrButton @ 0x101fd67b0 */

undefined1
SDV_StardewValley_Mobile_VirtualJoypad_get_TouchingJoystickOrButton_06006761(long param_1)

{
  if ((*(char *)(param_1 + 0x106) == '\0') && (*(char *)(param_1 + 0xd8) == '\0')) {
    return *(undefined1 *)(param_1 + 0xd9);
  }
  return 1;
}

