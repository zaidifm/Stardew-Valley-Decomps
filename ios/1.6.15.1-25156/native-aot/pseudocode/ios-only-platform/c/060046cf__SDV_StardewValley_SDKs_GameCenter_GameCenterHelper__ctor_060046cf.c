/* 0x060046cf StardewValley.SDKs.GameCenter.GameCenterHelper..ctor @ 0x101ab4584 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_SDKs_GameCenter_GameCenterHelper__ctor_060046cf(long param_1)

{
  long lVar1;
  code *pcVar2;
  
  lVar1 = lRam00000001038c4be0;
  if (cRam000000010390f4de == '\0') {
    func_0x00010119b908(&UNK_1032f3e4b);
    cRam000000010390f4de = '\x01';
    lVar1 = lRam00000001038c4be0;
  }
  lRam00000001038c4be0 = lVar1;
  if (param_1 == 0) {
    func_0x0001003316f4(0xee,_UNK_103646340);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x101ab4600);
    (*pcVar2)();
  }
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x10) = uRam00000001038ee0d0;
  *(undefined1 *)(((ulong)(param_1 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
  *(undefined1 *)(param_1 + 0x20) = 1;
  return;
}

