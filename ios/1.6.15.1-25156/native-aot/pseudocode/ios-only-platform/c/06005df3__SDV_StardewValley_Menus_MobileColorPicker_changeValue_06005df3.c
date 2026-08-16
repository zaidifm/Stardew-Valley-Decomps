/* 0x06005df3 StardewValley.Menus.MobileColorPicker.changeValue @ 0x101e04fa0 */

void SDV_StardewValley_Menus_MobileColorPicker_changeValue_06005df3(long param_1,int param_2)

{
  long lVar1;
  
  if (lRam0000000103976fb8 == 0) {
    lVar1 = *(long *)(param_1 + 0x70);
  }
  else {
    func_0x00010119b8f8();
    lVar1 = *(long *)(param_1 + 0x70);
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
  *(undefined8 *)(param_1 + 0x80) = *(undefined8 *)(param_1 + 0x70);
  *(undefined1 *)(((ulong)(param_1 + 0x80) >> 9 & 0x7fffff) + lVar1) = 1;
  return;
}

