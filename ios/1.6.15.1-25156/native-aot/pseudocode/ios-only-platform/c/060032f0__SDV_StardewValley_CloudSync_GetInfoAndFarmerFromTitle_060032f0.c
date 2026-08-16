/* 0x060032f0 StardewValley.CloudSync.GetInfoAndFarmerFromTitle @ 0x1017a00bc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync_GetInfoAndFarmerFromTitle_060032f0
               (undefined8 param_1,undefined8 *param_2,undefined8 *param_3,undefined8 *param_4)

{
  long lVar1;
  char cVar2;
  code *pcVar3;
  undefined8 uVar4;
  undefined8 uVar5;
  
  cVar2 = cRam000000010390e0ff;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1032d3beb);
    cRam000000010390e0ff = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar4 = func_0x000100351760(*puRam00000001038d5308,param_1);
  DataMemoryBarrier(2,3);
  uVar5 = _UNK_1035f56e0;
  if (param_2 != (undefined8 *)0x0) {
    *param_2 = uVar4;
    lVar1 = lRam00000001038c4be0;
    *(undefined1 *)(((ulong)param_2 >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    uVar4 = func_0x000100351760(*param_2,uRam00000001038df940);
    DataMemoryBarrier(2,3);
    uVar5 = _UNK_1035f56e8;
    if (param_3 != (undefined8 *)0x0) {
      *param_3 = uVar4;
      *(undefined1 *)(((ulong)param_3 >> 9 & 0x7fffff) + lVar1) = 1;
      uVar4 = func_0x000100351760(*param_2,param_1);
      DataMemoryBarrier(2,3);
      uVar5 = _UNK_1035f56f0;
      if (param_4 != (undefined8 *)0x0) {
        *param_4 = uVar4;
        *(undefined1 *)(((ulong)param_4 >> 9 & 0x7fffff) + lVar1) = 1;
        return;
      }
    }
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x1017a01ec);
  (*pcVar3)();
}

