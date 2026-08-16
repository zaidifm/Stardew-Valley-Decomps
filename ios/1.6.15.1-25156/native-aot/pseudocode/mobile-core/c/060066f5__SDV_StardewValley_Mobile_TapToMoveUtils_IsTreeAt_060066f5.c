/* 0x060066f5 StardewValley.Mobile.TapToMoveUtils.IsTreeAt @ 0x101fccac8 */

undefined8 SDV_StardewValley_Mobile_TapToMoveUtils_IsTreeAt_060066f5(long param_1)

{
  undefined8 uVar1;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (param_1 == 0) {
    uVar1 = 0;
  }
  else {
    uVar1 = SDV_StardewValley_Mobile_TapToMoveUtils_IsTreeAt_060066f7
                      (*(undefined4 *)(param_1 + 0x34),*(undefined4 *)(param_1 + 0x38));
  }
  return uVar1;
}

