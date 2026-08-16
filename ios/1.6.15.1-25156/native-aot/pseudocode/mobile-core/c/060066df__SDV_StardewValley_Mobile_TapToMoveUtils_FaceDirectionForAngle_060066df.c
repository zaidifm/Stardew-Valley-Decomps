/* 0x060066df StardewValley.Mobile.TapToMoveUtils.FaceDirectionForAngle @ 0x101fca2c0 */

undefined4 SDV_StardewValley_Mobile_TapToMoveUtils_FaceDirectionForAngle_060066df(float param_1)

{
  bool bVar1;
  bool bVar2;
  undefined4 uVar3;
  
  bVar1 = false;
  bVar2 = true;
  if (-135.0 < param_1) {
    bVar1 = false;
    bVar2 = true;
    if (!NAN(param_1)) {
      bVar1 = param_1 == -45.0;
      bVar2 = -45.0 <= param_1;
    }
  }
  if (bVar2 && !bVar1) {
    if ((45.0 <= param_1) && (param_1 <= 135.0)) {
      return 2;
    }
    bVar1 = true;
    bVar2 = false;
    if (param_1 <= 45.0) {
      bVar1 = false;
      bVar2 = true;
      if (!NAN(param_1)) {
        bVar1 = param_1 < -45.0;
        bVar2 = false;
      }
    }
    uVar3 = 3;
    if (bVar1 == bVar2) {
      uVar3 = 1;
    }
    return uVar3;
  }
  return 0;
}

