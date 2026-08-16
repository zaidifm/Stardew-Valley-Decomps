/* 0x060065eb StardewValley.Mobile.MobileDisplay.set_ScreenHeightPixels @ 0x101f9e130 */

void SDV_StardewValley_Mobile_MobileDisplay_set_ScreenHeightPixels_060065eb(undefined4 param_1)

{
  char cVar1;
  
  cVar1 = cRam00000001039113fa;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033244e6);
    cRam00000001039113fa = '\x01';
  }
  if (*(char *)(lRam00000001038d7890 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  *puRam0000000103904268 = param_1;
  return;
}

