/* 0x0600672d StardewValley.Mobile.VirtualJoypad.get_positionButtonA @ 0x101fd1958 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonA_0600672d(void)

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
    SDV_StardewValley_Options_get_buttonAPosition_06003f17();
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d83d8);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd19a0);
  (*pcVar1)();
}

