/* 0x060065ee StardewValley.Mobile.MobileDisplay.get_DesktopScale @ 0x101f9e2a4 */

undefined4 SDV_StardewValley_Mobile_MobileDisplay_get_DesktopScale_060065ee(void)

{
  char cVar1;
  
  cVar1 = cRam00000001039113fd;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103324510);
    cRam00000001039113fd = '\x01';
  }
  if (*(char *)(lRam00000001038d7890 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  return *puRam0000000103904278;
}

