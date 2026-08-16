/* 0x06006701 StardewValley.Mobile.TapToMoveUtils.IsStumpAt @ 0x101fcd904 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMoveUtils_IsStumpAt_06006701(long param_1)

{
  code *pcVar1;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (param_1 == 0) {
    func_0x0001003316f4(0xee,_UNK_1036d7c78);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcd954);
    (*pcVar1)();
  }
  SDV_StardewValley_Mobile_TapToMoveUtils_IsStumpAt_06006703
            (*(undefined4 *)(param_1 + 0x34),*(undefined4 *)(param_1 + 0x38));
  return;
}

