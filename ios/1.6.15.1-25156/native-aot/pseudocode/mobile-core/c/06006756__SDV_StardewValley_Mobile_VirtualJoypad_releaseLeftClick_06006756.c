/* 0x06006756 StardewValley.Mobile.VirtualJoypad.releaseLeftClick @ 0x101fd58b8 */

void SDV_StardewValley_Mobile_VirtualJoypad_releaseLeftClick_06006756
               (long param_1,undefined4 param_2,undefined4 param_3)

{
  char cVar1;
  
  cVar1 = cRam0000000103911565;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103325de2);
    cRam0000000103911565 = '\x01';
  }
  *puRam00000001038d6a30 = 0;
  *(undefined1 *)(param_1 + 0x14c) = 0;
  *(undefined8 *)(param_1 + 0x88) = 0;
  if (*(char *)(param_1 + 0x107) == '\0') {
    if ((*(char *)(param_1 + 0x105) != '\0') || (*(char *)(param_1 + 0x106) != '\0')) {
      *(undefined1 *)(param_1 + 0x105) = 0;
    }
  }
  else {
    (**(code **)(**(long **)(param_1 + 0xa0) + 0xf8))(*(long **)(param_1 + 0xa0),param_2,param_3);
    (**(code **)(**(long **)(param_1 + 0xa8) + 0xf8))(*(long **)(param_1 + 0xa8),param_2,param_3);
  }
  return;
}

