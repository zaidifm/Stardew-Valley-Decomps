/* 0x060032e2 StardewValley.CloudSync.ReadSyncronizedState @ 0x10179edd0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync_ReadSyncronizedState_060032e2
               (undefined8 param_1,undefined8 *param_2,undefined4 *param_3)

{
  char cVar1;
  code *pcVar2;
  undefined4 uVar3;
  long lVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  
  cVar1 = cRam000000010390e0f1;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1032d3b49);
    cRam000000010390e0f1 = '\x01';
  }
  lVar4 = func_0x0001003578cc();
  uVar5 = func_0x0001003323d8(param_1,uRam00000001038df870);
  uVar6 = _UNK_1035f5590;
  if (lVar4 != 0) {
    uVar5 = func_0x0001003578e0(lVar4,uVar5);
    DataMemoryBarrier(2,3);
    uVar6 = _UNK_1035f5598;
    if (param_2 != (undefined8 *)0x0) {
      *param_2 = uVar5;
      *(undefined1 *)(((ulong)param_2 >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
      uVar6 = func_0x0001003323d8(param_1,uRam00000001038df878);
      uVar3 = func_0x0001003578f4(lVar4,uVar6);
      *param_3 = uVar3;
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x10179eed0);
  (*pcVar2)();
}

