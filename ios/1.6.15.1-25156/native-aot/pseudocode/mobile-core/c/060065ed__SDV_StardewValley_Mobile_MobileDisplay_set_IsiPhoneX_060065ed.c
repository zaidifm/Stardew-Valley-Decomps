/* 0x060065ed StardewValley.Mobile.MobileDisplay.set_IsiPhoneX @ 0x101f9e224 */

void SDV_StardewValley_Mobile_MobileDisplay_set_IsiPhoneX_060065ed(undefined1 param_1)

{
  char cVar1;
  
  cVar1 = cRam00000001039113fc;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103324502);
    cRam00000001039113fc = '\x01';
  }
  if (*(char *)(lRam00000001038d7890 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  *puRam0000000103904270 = param_1;
  return;
}

