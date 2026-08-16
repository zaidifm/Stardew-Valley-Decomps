/* 0x0600672b StardewValley.Mobile.VirtualJoypad.set_positionJoystick @ 0x101fd189c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_set_positionJoystick_0600672b
               (undefined8 param_1,ulong param_2)

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
    SDV_StardewValley_Options_SetPositionJoystick_06003f16
              (lVar2,param_2 & 0xffffffff,param_2 >> 0x20);
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d83c8);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd18f8);
  (*pcVar1)();
}

