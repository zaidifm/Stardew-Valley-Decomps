/* 0x060066dd StardewValley.Mobile.TapToMoveUtils.WalkDirectionForAngle @ 0x101fca144 */

undefined4 SDV_StardewValley_Mobile_TapToMoveUtils_WalkDirectionForAngle_060066dd(float param_1)

{
  bool bVar1;
  undefined4 uVar2;
  
  bVar1 = false;
  if ((-22.5 <= param_1) && (bVar1 = false, !NAN(param_1))) {
    bVar1 = param_1 < 22.5;
  }
  if (bVar1) {
    return 4;
  }
  if ((22.5 <= param_1) && (param_1 < 67.5)) {
    return 8;
  }
  if ((67.5 <= param_1) && (param_1 < 112.5)) {
    return 2;
  }
  if ((112.5 <= param_1) && (param_1 < 157.5)) {
    return 7;
  }
  if ((param_1 < -112.5) && (-157.5 <= param_1)) {
    return 5;
  }
  if ((param_1 < -22.5) && (-67.5 <= param_1)) {
    return 6;
  }
  bVar1 = false;
  if ((-112.5 <= param_1) && (bVar1 = false, !NAN(param_1))) {
    bVar1 = param_1 < -67.5;
  }
  uVar2 = 3;
  if (bVar1) {
    uVar2 = 1;
  }
  return uVar2;
}

