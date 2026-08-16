/* 0x0600676f StardewValley.iOS.AppDelegate.FinishedLaunching @ 0x101fd8c50 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_iOS_AppDelegate_FinishedLaunching_0600676f(void)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  long lVar4;
  undefined8 uVar5;
  long lVar6;
  
  cVar1 = cRam000000010391157e;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103325ed0);
    cRam000000010391157e = '\x01';
  }
  *puRam00000001038ee1c0 = 1;
  if (*(char *)(lRam00000001038d4c58 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  lVar6 = *plRam00000001038d4c60;
  lVar3 = func_0x000100331820(uRam0000000103904b78,0x80);
  uVar5 = uRam0000000103904b88;
  lVar4 = lRam0000000103904b80;
  *(long *)(lVar3 + 0x40) = lRam0000000103904b80;
  *(undefined8 *)(lVar3 + 0x28) = uVar5;
  *(undefined8 *)(lVar3 + 0x18) = *(undefined8 *)(lVar4 + 0x30);
  *(undefined8 *)(lVar3 + 0x10) = *(undefined8 *)(lVar4 + 0x28);
  uVar5 = _UNK_1036d9578;
  if (lVar6 != 0) {
    func_0x00010037e5e4(lVar6,lVar3);
    lVar4 = func_0x0001003782fc();
    uVar5 = _UNK_1036d9580;
    if (lVar4 != 0) {
      func_0x00010037e5f8(lVar4,1);
      SDV_StardewValley_Mobile_MobileDisplay_SetupDisplaySettings_060065f1();
      lVar4 = func_0x000100331870(uRam00000001038c8f78);
      func_0x0001018af268();
      DataMemoryBarrier(2,3);
      *plRam00000001038c8f80 = lVar4;
      uVar5 = _UNK_1036d9588;
      if (lVar4 != 0) {
        func_0x00010037e634(lVar4);
        return 1;
      }
    }
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fd8d90);
  (*pcVar2)();
}

