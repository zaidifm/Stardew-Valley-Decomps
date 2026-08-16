/* 0x0600666c StardewValley.Mobile.MobileKeyStates.ResetDirections @ 0x101faf004 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_MobileKeyStates_ResetDirections_0600666c(long param_1)

{
  code *pcVar1;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  SDV_StardewValley_Mobile_MobileKeyStates_StopMoving_0600666b(param_1);
  if (param_1 != 0) {
    *(undefined4 *)(param_1 + 0x1d) = 0x1010101;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d37b8);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101faf05c);
  (*pcVar1)();
}

