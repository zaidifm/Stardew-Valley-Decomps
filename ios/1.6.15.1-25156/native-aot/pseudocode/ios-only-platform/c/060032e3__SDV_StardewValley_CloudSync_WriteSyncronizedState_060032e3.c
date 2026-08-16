/* 0x060032e3 StardewValley.CloudSync.WriteSyncronizedState @ 0x10179eed0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync_WriteSyncronizedState_060032e3
               (undefined8 param_1,long param_2,int param_3)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  undefined8 uVar4;
  
  cVar1 = cRam000000010390e0f2;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1032d3b52);
    cRam000000010390e0f2 = '\x01';
  }
  if ((param_2 != 0) && (*(int *)(param_2 + 0x10) != 0)) {
    lVar3 = func_0x0001003578cc();
    uVar4 = func_0x0001003323d8(param_1,uRam00000001038df870);
    if (lVar3 == 0) {
      func_0x0001003316f4(0xee,_UNK_1035f55a8);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x10179efb0);
      (*pcVar2)();
    }
    func_0x000100357908(lVar3,param_2,uVar4);
    uVar4 = func_0x0001003323d8(param_1,uRam00000001038df878);
    func_0x00010035791c(lVar3,(long)param_3,uVar4);
  }
  return;
}

