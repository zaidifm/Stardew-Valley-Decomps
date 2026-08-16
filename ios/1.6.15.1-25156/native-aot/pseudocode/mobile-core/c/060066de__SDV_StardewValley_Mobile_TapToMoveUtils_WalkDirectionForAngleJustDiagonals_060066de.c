/* 0x060066de StardewValley.Mobile.TapToMoveUtils.WalkDirectionForAngleJustDiagonals @ 0x101fca258 */

undefined4
SDV_StardewValley_Mobile_TapToMoveUtils_WalkDirectionForAngleJustDiagonals_060066de(float param_1)

{
  bool bVar1;
  bool bVar2;
  undefined4 uVar3;
  
  if ((0.0 <= param_1) && (param_1 < 90.0)) {
    return 8;
  }
  bVar1 = false;
  bVar2 = true;
  if (90.0 <= param_1) {
    bVar1 = false;
    bVar2 = true;
    if (!NAN(param_1)) {
      bVar1 = param_1 == 180.0;
      bVar2 = 180.0 <= param_1;
    }
  }
  if (bVar2 && !bVar1) {
    bVar1 = false;
    bVar2 = true;
    if (-180.0 <= param_1) {
      bVar1 = false;
      bVar2 = true;
      if (!NAN(param_1)) {
        bVar1 = param_1 == -90.0;
        bVar2 = -90.0 <= param_1;
      }
    }
    uVar3 = 5;
    if (bVar2 && !bVar1) {
      uVar3 = 6;
    }
    return uVar3;
  }
  return 7;
}

