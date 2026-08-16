/* 0x060065f9 StardewValley.Mobile.MobileDisplay.iOS_SetDisplaySettings @ 0x101fa1230 */

void SDV_StardewValley_Mobile_MobileDisplay_iOS_SetDisplaySettings_060065f9
               (undefined8 param_1,undefined4 param_2,undefined4 param_3,ulong param_4)

{
  char cVar1;
  ulong uVar2;
  long lVar3;
  undefined4 uVar4;
  ulong uVar5;
  undefined4 uStack_48;
  undefined4 uStack_44;
  
  cVar1 = cRam0000000103911408;
  uStack_48 = param_2;
  uStack_44 = param_3;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033248b0);
    cRam0000000103911408 = '\x01';
  }
  uVar5 = param_4 >> 0x20;
  SDV_StardewValley_Mobile_MobileDisplay_EnsureLandscapeMode_060065f5(&uStack_48,&uStack_44);
  SDV_StardewValley_Mobile_MobileDisplay_set_ScreenWidthPixels_060065e9(uStack_48);
  uVar2 = SDV_StardewValley_Mobile_MobileDisplay_set_ScreenHeightPixels_060065eb(uStack_44);
  if ((param_4 & 0xff) == 0) {
    uVar2 = SDV_StardewValley_Mobile_MobileDisplay_iOS_LookupPpi_060065f7(param_1);
    uVar5 = uVar2 & 0xffffffff;
  }
  SDV_StardewValley_Mobile_MobileDisplay_CalculateZoomAndMenuScale_060065f4(uVar2,uStack_44,uVar5);
  lVar3 = func_0x000100331794(uRam0000000103904570,2);
  *(undefined8 *)(lVar3 + 0x20) = 0xe0000000b;
  cVar1 = SDV_StardewValley_Mobile_MobileDisplay_IsDevice_060065f8(param_1,lVar3);
  if (cVar1 == '\0') {
    lVar3 = func_0x000100331794(uRam0000000103904570,0x11);
    func_0x0001003321f8(lVar3 + 0x20,uRam0000000103904578,0x44);
    cVar1 = SDV_StardewValley_Mobile_MobileDisplay_IsDevice_060065f8(param_1,lVar3);
    if (cVar1 == '\0') {
      lVar3 = func_0x000100331794(uRam0000000103904570,2);
      *(undefined8 *)(lVar3 + 0x20) = 0x1c0000001b;
      cVar1 = SDV_StardewValley_Mobile_MobileDisplay_IsDevice_060065f8(param_1,lVar3);
      if (cVar1 == '\0') goto LAB_101fa1350;
      goto LAB_101fa12dc;
    }
    uVar4 = 0x48;
  }
  else {
LAB_101fa12dc:
    uVar4 = 0x52;
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  *puRam00000001038d57b0 = 0x40;
  *puRam00000001038d57b8 = uVar4;
LAB_101fa1350:
  lVar3 = func_0x000100331794(uRam0000000103904570,2);
  *(undefined8 *)(lVar3 + 0x20) = 0xe0000000b;
  SDV_StardewValley_Mobile_MobileDisplay_IsDevice_060065f8(param_1,lVar3);
  SDV_StardewValley_Mobile_MobileDisplay_set_IsiPhoneX_060065ed();
  return;
}

