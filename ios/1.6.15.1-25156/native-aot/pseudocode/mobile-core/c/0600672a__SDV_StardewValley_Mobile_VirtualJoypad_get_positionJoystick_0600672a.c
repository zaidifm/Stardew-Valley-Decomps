/* 0x0600672a StardewValley.Mobile.VirtualJoypad.get_positionJoystick @ 0x101fd1854 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_get_positionJoystick_0600672a(void)

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
    SDV_StardewValley_Options_get_joystickPosition_06003f14();
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d83c0);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd189c);
  (*pcVar1)();
}

