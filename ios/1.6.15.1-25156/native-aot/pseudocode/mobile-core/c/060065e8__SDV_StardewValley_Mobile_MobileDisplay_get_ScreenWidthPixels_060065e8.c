/* 0x060065e8 StardewValley.Mobile.MobileDisplay.get_ScreenWidthPixels @ 0x101f9dfc8 */

undefined4 SDV_StardewValley_Mobile_MobileDisplay_get_ScreenWidthPixels_060065e8(void)

{
  char cVar1;
  
  cVar1 = cRam00000001039113f7;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033244bc);
    cRam00000001039113f7 = '\x01';
  }
  if (*(char *)(lRam00000001038d7890 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  return *puRam0000000103904260;
}

