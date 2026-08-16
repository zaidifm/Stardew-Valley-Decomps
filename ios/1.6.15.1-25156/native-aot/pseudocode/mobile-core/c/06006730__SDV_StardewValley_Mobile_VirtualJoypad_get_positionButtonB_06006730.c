/* 0x06006730 StardewValley.Mobile.VirtualJoypad.get_positionButtonB @ 0x101fd1a5c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonB_06006730(void)

{
  code *pcVar1;
  long lVar2;
  
  if (lRam0000000103976fb8 == 0) {
    lVar2 = StardewValley_StardewValley_Game1_get_options_06002fec();
  }
  else {
    func_0x00010119b8f8();
    lVar2 = StardewValley_StardewValley_Game1_get_options_06002fec();
  }
  if (lVar2 != 0) {
    SDV_StardewValley_Options_get_buttonBPosition_06003f1a();
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d83f0);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd1aa4);
  (*pcVar1)();
}

