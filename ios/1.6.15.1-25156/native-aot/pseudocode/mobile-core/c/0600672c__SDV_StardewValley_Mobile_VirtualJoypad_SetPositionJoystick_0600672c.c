/* 0x0600672c StardewValley.Mobile.VirtualJoypad.SetPositionJoystick @ 0x101fd18f8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_SetPositionJoystick_0600672c
               (undefined8 param_1,undefined4 param_2,undefined4 param_3)

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
    SDV_StardewValley_Options_SetPositionJoystick_06003f16(lVar2,param_2,param_3);
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d83d0);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd1958);
  (*pcVar1)();
}

