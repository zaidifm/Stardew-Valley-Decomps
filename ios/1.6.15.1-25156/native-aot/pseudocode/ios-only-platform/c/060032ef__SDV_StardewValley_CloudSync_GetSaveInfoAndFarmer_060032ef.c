/* 0x060032ef StardewValley.CloudSync.GetSaveInfoAndFarmer @ 0x10179ff84 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync_GetSaveInfoAndFarmer_060032ef
               (long param_1,undefined8 *param_2,undefined8 *param_3,undefined8 *param_4)

{
  long lVar1;
  char cVar2;
  code *pcVar3;
  undefined8 uVar4;
  undefined8 uVar5;
  
  cVar2 = cRam000000010390e0fe;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1032d3be0);
    cRam000000010390e0fe = '\x01';
  }
  uVar5 = _UNK_1035f56c0;
  if (param_1 != 0) {
    func_0x000100352110(param_1,*puRam00000001038df938,0);
    uVar4 = func_0x000100356418();
    DataMemoryBarrier(2,3);
    uVar5 = _UNK_1035f56c8;
    if (param_2 != (undefined8 *)0x0) {
      *param_2 = uVar4;
      lVar1 = lRam00000001038c4be0;
      *(undefined1 *)(((ulong)param_2 >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
      uVar4 = func_0x000100351760(param_1,uRam00000001038df940);
      DataMemoryBarrier(2,3);
      uVar5 = _UNK_1035f56d0;
      if (param_3 != (undefined8 *)0x0) {
        *param_3 = uVar4;
        *(undefined1 *)(((ulong)param_3 >> 9 & 0x7fffff) + lVar1) = 1;
        uVar4 = func_0x000100351760(param_1,*param_2);
        DataMemoryBarrier(2,3);
        uVar5 = _UNK_1035f56d8;
        if (param_4 != (undefined8 *)0x0) {
          *param_4 = uVar4;
          *(undefined1 *)(((ulong)param_4 >> 9 & 0x7fffff) + lVar1) = 1;
          return;
        }
      }
    }
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x1017a00bc);
  (*pcVar3)();
}

