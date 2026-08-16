/* 0x06006760 StardewValley.Mobile.VirtualJoypad.get_TouchingTwoOrMoreButtons @ 0x101fd6764 */

bool SDV_StardewValley_Mobile_VirtualJoypad_get_TouchingTwoOrMoreButtons_06006760(long param_1)

{
  byte bVar1;
  
  bVar1 = *(char *)(param_1 + 0x106) != '\0';
  if (*(char *)(param_1 + 0xd8) != '\0') {
    bVar1 = bVar1 + 1;
  }
  if (*(char *)(param_1 + 0xd9) != '\0') {
    bVar1 = bVar1 + 1;
  }
  return 1 < bVar1;
}

