/* 0x060032eb StardewValley.CloudSync.GetDbAndZoneId @ 0x10179f9c0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync_GetDbAndZoneId_060032eb(undefined8 *param_1,undefined8 *param_2)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  undefined8 uVar4;
  long lVar5;
  undefined8 uVar6;
  
  cVar1 = cRam000000010390e0fa;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1032d3ba6);
    cRam000000010390e0fa = '\x01';
  }
  lVar3 = func_0x000100357a48(uRam00000001038df8b0);
  uVar6 = _UNK_1035f5658;
  if (lVar3 != 0) {
    uVar4 = func_0x000100357a5c();
    DataMemoryBarrier(2,3);
    uVar6 = _UNK_1035f5660;
    if (param_1 != (undefined8 *)0x0) {
      *param_1 = uVar4;
      lVar3 = lRam00000001038c4be0;
      *(undefined1 *)(((ulong)param_1 >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
      lVar5 = func_0x000100357a70();
      uVar6 = _UNK_1035f5668;
      if (lVar5 != 0) {
        uVar4 = func_0x000100357a84();
        DataMemoryBarrier(2,3);
        uVar6 = _UNK_1035f5670;
        if (param_2 != (undefined8 *)0x0) {
          *param_2 = uVar4;
          *(undefined1 *)(((ulong)param_2 >> 9 & 0x7fffff) + lVar3) = 1;
          return;
        }
      }
    }
  }
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x10179fab0);
  (*pcVar2)();
}

