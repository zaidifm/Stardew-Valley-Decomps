/* 0x06006729 StardewValley.Mobile.VirtualJoypad.set_sizeButtonB @ 0x101fd17fc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_set_sizeButtonB_06006729
               (undefined8 param_1,undefined4 param_2)

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
    SDV_StardewValley_Options_set_buttonBSize_06003f13(lVar2,param_2);
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d83b8);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd1854);
  (*pcVar1)();
}

