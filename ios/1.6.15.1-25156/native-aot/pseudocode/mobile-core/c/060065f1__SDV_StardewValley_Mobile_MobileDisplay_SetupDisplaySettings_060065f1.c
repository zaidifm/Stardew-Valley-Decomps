/* 0x060065f1 StardewValley.Mobile.MobileDisplay.SetupDisplaySettings @ 0x101f9ff60 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_MobileDisplay_SetupDisplaySettings_060065f1
               (undefined1 param_1 [16],undefined8 param_2,double param_3,double param_4)

{
  char cVar1;
  code *pcVar2;
  uint uVar3;
  undefined8 uVar4;
  long lVar5;
  undefined8 uVar6;
  int iStack_48;
  int iStack_44;
  undefined8 uStack_40;
  undefined8 uStack_38;
  double dStack_30;
  double dStack_28;
  
  cVar1 = cRam0000000103911400;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033247a5);
    cRam0000000103911400 = '\x01';
  }
  uVar4 = func_0x00010037cf14();
  lVar5 = func_0x00010037cf28();
  uVar6 = _UNK_1036d1500;
  if (lVar5 != 0) {
    uStack_40 = func_0x00010037cf3c();
    iStack_48 = (int)param_3;
    uStack_38 = param_2;
    dStack_30 = param_3;
    dStack_28 = param_4;
    lVar5 = func_0x00010037cf28();
    uVar6 = _UNK_1036d1508;
    if (lVar5 != 0) {
      uStack_40 = func_0x00010037cf3c();
      iStack_44 = (int)param_4;
      uStack_38 = param_2;
      dStack_30 = param_3;
      dStack_28 = param_4;
      SDV_StardewValley_Mobile_MobileDisplay_EnsureLandscapeMode_060065f5(&iStack_48,&iStack_44);
      uVar3 = SDV_StardewValley_Mobile_MobileDisplay_iOS_LookupPpi_060065f7(uVar4);
      SDV_StardewValley_Mobile_MobileDisplay_iOS_SetDisplaySettings_060065f9
                (uVar4,iStack_48,iStack_44,(ulong)uVar3 << 0x20 | 1);
      SDV_StardewValley_Mobile_MobileDisplay_PrintInfo_060065f3(0,iStack_48,iStack_44,uVar3);
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fa0054);
  (*pcVar2)();
}

