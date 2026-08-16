/* 0x0600667c StardewValley.Mobile.PinchZoom.set_ZoomLevel @ 0x101fb0060 */

void SDV_StardewValley_Mobile_PinchZoom_set_ZoomLevel_0600667c(float param_1,long param_2)

{
  char cVar1;
  float fVar2;
  float fVar3;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  cVar1 = SDV_StardewValley_Mobile_PinchZoom_get_ZoomingAllowed_0600667f(param_2);
  if (cVar1 != '\0') {
    fVar2 = (float)SDV_StardewValley_Mobile_PinchZoom_get_MinZoom_0600667a();
    fVar3 = 4.0;
    if ((param_1 != 4.0) && (fVar3 = param_1, !NAN(param_1))) {
      fVar3 = (float)NEON_fminnm(param_1,0x40800000);
    }
    if (fVar2 == fVar3) {
      if (-1 < (int)fVar3) {
        fVar2 = fVar3;
      }
    }
    else if (fVar2 <= fVar3) {
      fVar2 = fVar3;
    }
    *(float *)(param_2 + 0x18) = fVar2;
    return;
  }
  return;
}

