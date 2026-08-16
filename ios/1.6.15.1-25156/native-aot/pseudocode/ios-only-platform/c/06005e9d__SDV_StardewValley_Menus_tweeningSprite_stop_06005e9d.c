/* 0x06005e9d StardewValley.Menus.tweeningSprite.stop @ 0x101e243e4 */

void SDV_StardewValley_Menus_tweeningSprite_stop_06005e9d(long param_1)

{
  char cVar1;
  long lVar2;
  
  cVar1 = cRam0000000103910cac;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103317bf1);
    cRam0000000103910cac = '\x01';
    lVar2 = *(long *)(param_1 + 0x10);
  }
  else {
    lVar2 = *(long *)(param_1 + 0x10);
  }
  *(undefined1 *)(param_1 + 0x30) = 0;
  if (lVar2 != 0) {
    func_0x000100378298(lVar2,0);
  }
  return;
}

