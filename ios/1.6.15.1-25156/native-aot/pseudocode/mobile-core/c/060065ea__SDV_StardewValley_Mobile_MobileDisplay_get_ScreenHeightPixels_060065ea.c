/* 0x060065ea StardewValley.Mobile.MobileDisplay.get_ScreenHeightPixels @ 0x101f9e0bc */

undefined4 SDV_StardewValley_Mobile_MobileDisplay_get_ScreenHeightPixels_060065ea(void)

{
  char cVar1;
  
  cVar1 = cRam00000001039113f9;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033244d8);
    cRam00000001039113f9 = '\x01';
  }
  if (*(char *)(lRam00000001038d7890 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  return *puRam0000000103904268;
}

