/* 0x0600672f StardewValley.Mobile.VirtualJoypad.SetPositionButtonA @ 0x101fd19fc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_SetPositionButtonA_0600672f
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
    SDV_StardewValley_Options_SetPositionButtonA_06003f19(lVar2,param_2,param_3);
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d83e8);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd1a5c);
  (*pcVar1)();
}

