/* 0x060065f4 StardewValley.Mobile.MobileDisplay.CalculateZoomAndMenuScale @ 0x101fa0c00 */

void SDV_StardewValley_Mobile_MobileDisplay_CalculateZoomAndMenuScale_060065f4
               (undefined8 param_1,int param_2,int param_3)

{
  char cVar1;
  bool bVar2;
  float fVar3;
  float fVar4;
  float fVar5;
  float fVar6;
  
  cVar1 = cRam0000000103911403;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103324840);
    cRam0000000103911403 = '\x01';
  }
  fVar3 = (float)param_3;
  fVar5 = 1.5;
  fVar6 = (float)param_2 / fVar3;
  if ((fVar6 <= 5.0) && (fVar5 = 1.0, 4.0 < fVar6)) {
    fVar5 = 1.25;
  }
  fVar6 = fVar3 * 0.3 * fVar5;
  fVar5 = fVar3 * 0.225 * fVar5;
  if ((float)param_2 / fVar6 < 10.0) {
    fVar6 = fVar5;
  }
  fVar6 = fVar6 * 0.015625;
  fVar3 = 5.0;
  if (fVar6 != 5.0) {
    bVar2 = true;
    if ((!NAN(fVar6)) && (bVar2 = false, !NAN(fVar6))) {
      bVar2 = fVar6 < 5.0;
    }
    if ((bVar2) && (fVar4 = 0.5, fVar3 = fVar6, fVar6 == 0.5)) goto LAB_101fa0cd8;
  }
  fVar4 = fVar3;
LAB_101fa0cd8:
  SDV_StardewValley_Mobile_MobileDisplay_set_ZoomScale_060065e5(fVar4);
  SDV_StardewValley_Mobile_MobileDisplay_set_MenuButtonScale_060065e7(fVar5 * 0.015625);
  fVar5 = (float)SDV_StardewValley_Mobile_MobileDisplay_get_MenuButtonScale_060065e6();
  fVar3 = 5.0;
  if ((((fVar5 == 5.0) || (5.0 <= fVar5)) || (fVar3 = fVar5, fVar6 = 0.5, fVar5 != 0.5)) &&
     (fVar6 = fVar3, fVar3 <= 0.5)) {
    fVar6 = 0.5;
  }
  SDV_StardewValley_Mobile_MobileDisplay_set_MenuButtonScale_060065e7(fVar6);
  return;
}

