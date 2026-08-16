/* 0x0600669b StardewValley.Mobile.TapToMove.OnCloseActiveMenu @ 0x101fb1774 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_OnCloseActiveMenu_0600669b(long param_1)

{
  code *pcVar1;
  
  if (param_1 != 0) {
    *(undefined1 *)(param_1 + 0x100) = 1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d3c00);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fb17a0);
  (*pcVar1)();
}

