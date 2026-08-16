/* 0x06005df2 StardewValley.Menus.MobileColorPicker.changeSaturation @ 0x101e04f04 */

void SDV_StardewValley_Menus_MobileColorPicker_changeSaturation_06005df2(long param_1,int param_2)

{
  long lVar1;
  
  if (lRam0000000103976fb8 == 0) {
    lVar1 = *(long *)(param_1 + 0x78);
  }
  else {
    func_0x00010119b8f8();
    lVar1 = *(long *)(param_1 + 0x78);
  }
  param_2 = *(int *)(lVar1 + 0x10) + param_2;
  if (99 < param_2) {
    param_2 = 100;
  }
  if (param_2 < 1) {
    param_2 = 0;
  }
  *(int *)(lVar1 + 0x10) = param_2;
  lVar1 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x80) = *(undefined8 *)(param_1 + 0x78);
  *(undefined1 *)(((ulong)(param_1 + 0x80) >> 9 & 0x7fffff) + lVar1) = 1;
  return;
}

