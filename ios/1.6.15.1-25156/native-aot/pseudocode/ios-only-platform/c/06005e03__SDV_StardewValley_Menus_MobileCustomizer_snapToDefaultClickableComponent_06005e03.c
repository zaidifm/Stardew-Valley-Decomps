/* 0x06005e03 StardewValley.Menus.MobileCustomizer.snapToDefaultClickableComponent @ 0x101e07e18 */

void SDV_StardewValley_Menus_MobileCustomizer_snapToDefaultClickableComponent_06005e03
               (long *param_1)

{
  long lVar1;
  
  if (lRam0000000103976fb8 == 0) {
    lVar1 = param_1[0x1f];
  }
  else {
    func_0x00010119b8f8();
    lVar1 = param_1[0x1f];
  }
  DataMemoryBarrier(2,3);
  param_1[9] = lVar1;
  *(undefined1 *)(((ulong)(param_1 + 9) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
  (**(code **)(*param_1 + 0x168))(param_1);
  return;
}

