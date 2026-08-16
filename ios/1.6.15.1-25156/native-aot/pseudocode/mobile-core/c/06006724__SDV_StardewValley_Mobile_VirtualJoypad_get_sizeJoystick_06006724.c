/* 0x06006724 StardewValley.Mobile.VirtualJoypad.get_sizeJoystick @ 0x101fd1674 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724(void)

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
    SDV_StardewValley_Options_get_joystickSize_06003f0e();
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d8390);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd16bc);
  (*pcVar1)();
}

