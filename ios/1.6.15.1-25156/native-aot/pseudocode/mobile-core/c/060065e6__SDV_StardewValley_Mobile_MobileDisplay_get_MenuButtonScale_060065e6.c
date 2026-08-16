/* 0x060065e6 StardewValley.Mobile.MobileDisplay.get_MenuButtonScale @ 0x101f9ded4 */

undefined4 SDV_StardewValley_Mobile_MobileDisplay_get_MenuButtonScale_060065e6(void)

{
  char cVar1;
  
  cVar1 = cRam00000001039113f5;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033244a0);
    cRam00000001039113f5 = '\x01';
  }
  if (*(char *)(lRam00000001038d7890 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  return *puRam0000000103904258;
}

