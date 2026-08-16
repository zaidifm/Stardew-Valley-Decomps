/* 0x060032e4 StardewValley.CloudSync.DeleteSyncronizedState @ 0x10179efb0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync_DeleteSyncronizedState_060032e4(undefined8 param_1)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  undefined8 uVar4;
  
  cVar1 = cRam000000010390e0f3;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1032d3b5b);
    cRam000000010390e0f3 = '\x01';
  }
  lVar3 = func_0x0001003578cc();
  uVar4 = func_0x0001003323d8(param_1,uRam00000001038df870);
  if (lVar3 != 0) {
    func_0x000100357930(lVar3,uVar4);
    uVar4 = func_0x0001003323d8(param_1,uRam00000001038df878);
    func_0x000100357930(lVar3,uVar4);
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1035f55b0);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x10179f064);
  (*pcVar2)();
}

