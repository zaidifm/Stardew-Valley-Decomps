/* 0x06006773 StardewValley.iOS.AppDelegate.FinishLongRunningTask @ 0x101fd924c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_iOS_AppDelegate_FinishLongRunningTask_06006773
               (undefined8 param_1,undefined8 param_2)

{
  code *pcVar1;
  long lVar2;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  func_0x00010170bf40();
  lVar2 = func_0x0001003782fc();
  if (lVar2 != 0) {
    func_0x00010037e6e8(lVar2,param_2);
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d95b8);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd92a4);
  (*pcVar1)();
}

