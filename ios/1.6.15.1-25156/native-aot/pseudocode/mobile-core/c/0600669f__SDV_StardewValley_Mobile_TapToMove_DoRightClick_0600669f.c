/* 0x0600669f StardewValley.Mobile.TapToMove.DoRightClick @ 0x101fb2b40 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_DoRightClick_0600669f(long param_1)

{
  code *pcVar1;
  
  if (param_1 != 0) {
    *(undefined4 *)(param_1 + 0x124) = 10;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d3f00);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fb2b6c);
  (*pcVar1)();
}

