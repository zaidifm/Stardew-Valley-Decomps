/* 0x060065ef StardewValley.Mobile.MobileDisplay.set_DesktopScale @ 0x101f9e318 */

void SDV_StardewValley_Mobile_MobileDisplay_set_DesktopScale_060065ef(undefined4 param_1)

{
  char cVar1;
  
  cVar1 = cRam00000001039113fe;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_10332451e);
    cRam00000001039113fe = '\x01';
  }
  if (*(char *)(lRam00000001038d7890 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  *puRam0000000103904278 = param_1;
  return;
}

