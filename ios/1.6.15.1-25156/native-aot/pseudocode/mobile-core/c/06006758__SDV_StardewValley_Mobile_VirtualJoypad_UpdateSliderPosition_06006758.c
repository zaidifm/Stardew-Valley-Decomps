/* 0x06006758 StardewValley.Mobile.VirtualJoypad.UpdateSliderPosition @ 0x101fd5c5c */

void SDV_StardewValley_Mobile_VirtualJoypad_UpdateSliderPosition_06006758
               (long param_1,undefined4 param_2,undefined4 param_3)

{
  char cVar1;
  
  if (lRam0000000103976fb8 == 0) {
    cVar1 = *(char *)(param_1 + 0x14c);
  }
  else {
    func_0x00010119b8f8();
    cVar1 = *(char *)(param_1 + 0x14c);
  }
  if (cVar1 != '\0') {
    (**(code **)(**(long **)(param_1 + 0xa0) + 0x1c0))(*(long **)(param_1 + 0xa0),param_2,param_3);
  }
  return;
}

