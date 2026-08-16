/* 0x060065f6 StardewValley.Mobile.MobileDisplay.Android_SetDisplaySettings @ 0x101fa0dec */

void SDV_StardewValley_Mobile_MobileDisplay_Android_SetDisplaySettings_060065f6
               (int param_1,int param_2,undefined4 param_3,int param_4)

{
  char cVar1;
  undefined8 uVar2;
  int iVar3;
  int iStack_38;
  int iStack_34;
  
  cVar1 = cRam0000000103911405;
  iStack_38 = param_1;
  iStack_34 = param_2;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103324850);
    cRam0000000103911405 = '\x01';
  }
  SDV_StardewValley_Mobile_MobileDisplay_EnsureLandscapeMode_060065f5(&iStack_38,&iStack_34);
  SDV_StardewValley_Mobile_MobileDisplay_set_ScreenWidthPixels_060065e9(iStack_38);
  uVar2 = SDV_StardewValley_Mobile_MobileDisplay_set_ScreenHeightPixels_060065eb(iStack_34);
  SDV_StardewValley_Mobile_MobileDisplay_CalculateZoomAndMenuScale_060065f4(uVar2,iStack_34,param_3)
  ;
  if (param_4 < 0) {
    if ((iStack_34 < 0x780) && (iStack_38 < 0x780)) {
      return;
    }
    iVar3 = 0x14;
    param_4 = 0x14;
    cVar1 = *(char *)(lRam00000001038c4c88 + 0x35);
  }
  else {
    iVar3 = param_4;
    if (0x59 < param_4) {
      iVar3 = 0x5a;
    }
    cVar1 = *(char *)(lRam00000001038c4c88 + 0x35);
  }
  if (cVar1 == '\0') {
    func_0x0001003319b0();
  }
  *piRam00000001038d57b0 = iVar3;
  *piRam00000001038d57b8 = param_4;
  return;
}

