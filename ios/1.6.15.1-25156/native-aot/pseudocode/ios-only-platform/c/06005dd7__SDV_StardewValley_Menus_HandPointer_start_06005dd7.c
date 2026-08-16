/* 0x06005dd7 StardewValley.Menus.HandPointer.start @ 0x101e01204 */

void SDV_StardewValley_Menus_HandPointer_start_06005dd7(long param_1)

{
  long lVar1;
  
  if (lRam0000000103976fb8 == 0) {
    lVar1 = *(long *)(param_1 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    lVar1 = *(long *)(param_1 + 0x18);
  }
  *(undefined1 *)(param_1 + 0x38) = 0;
  if (lVar1 != 0) {
    SDV_StardewValley_Menus_tweeningSprite_start_06005e9c();
  }
  return;
}

