/* 0x060065ec StardewValley.Mobile.MobileDisplay.get_IsiPhoneX @ 0x101f9e1b0 */

undefined1 SDV_StardewValley_Mobile_MobileDisplay_get_IsiPhoneX_060065ec(void)

{
  char cVar1;
  
  cVar1 = cRam00000001039113fb;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033244f4);
    cRam00000001039113fb = '\x01';
  }
  if (*(char *)(lRam00000001038d7890 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  return *puRam0000000103904270;
}

