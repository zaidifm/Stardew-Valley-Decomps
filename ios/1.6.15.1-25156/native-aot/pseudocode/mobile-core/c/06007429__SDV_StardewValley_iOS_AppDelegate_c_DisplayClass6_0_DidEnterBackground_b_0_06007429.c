/* 0x06007429 StardewValley.iOS.AppDelegate+<>c__DisplayClass6_0.<DidEnterBackground>b__0 @ 0x1020b4a9c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_iOS_AppDelegate_c_DisplayClass6_0_DidEnterBackground_b_0_06007429
               (long param_1)

{
  code *pcVar1;
  long lVar2;
  undefined8 uVar3;
  
  if (lRam0000000103976fb8 == 0) {
    lVar2 = func_0x0001003782fc();
  }
  else {
    func_0x00010119b8f8();
    lVar2 = func_0x0001003782fc();
  }
  uVar3 = _UNK_1036ef788;
  if ((param_1 != 0) && (uVar3 = _UNK_1036ef790, lVar2 != 0)) {
    func_0x00010037e6e8(lVar2,*(undefined8 *)(param_1 + 0x18));
    return;
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x1020b4b04);
  (*pcVar1)();
}

