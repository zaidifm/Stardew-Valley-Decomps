/* 0x06006732 StardewValley.Mobile.VirtualJoypad.SetPositionButtonB @ 0x101fd1b00 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_SetPositionButtonB_06006732
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
    SDV_StardewValley_Options_SetPositionButtonB_06003f1c(lVar2,param_2,param_3);
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d8400);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd1b60);
  (*pcVar1)();
}

