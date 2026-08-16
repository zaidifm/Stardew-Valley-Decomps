/* 0x060065e7 StardewValley.Mobile.MobileDisplay.set_MenuButtonScale @ 0x101f9df48 */

void SDV_StardewValley_Mobile_MobileDisplay_set_MenuButtonScale_060065e7(undefined4 param_1)

{
  char cVar1;
  
  cVar1 = cRam00000001039113f6;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033244ae);
    cRam00000001039113f6 = '\x01';
  }
  if (*(char *)(lRam00000001038d7890 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  *puRam0000000103904258 = param_1;
  return;
}

