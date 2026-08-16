/* 0x060065e9 StardewValley.Mobile.MobileDisplay.set_ScreenWidthPixels @ 0x101f9e03c */

void SDV_StardewValley_Mobile_MobileDisplay_set_ScreenWidthPixels_060065e9(undefined4 param_1)

{
  char cVar1;
  
  cVar1 = cRam00000001039113f8;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033244ca);
    cRam00000001039113f8 = '\x01';
  }
  if (*(char *)(lRam00000001038d7890 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  *puRam0000000103904260 = param_1;
  return;
}

