/* 0x0600669e StardewValley.Mobile.TapToMove.DoLeftClick @ 0x101fb2b14 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_DoLeftClick_0600669e(long param_1)

{
  code *pcVar1;
  
  if (param_1 != 0) {
    *(undefined4 *)(param_1 + 0x124) = 5;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d3ef8);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fb2b40);
  (*pcVar1)();
}

