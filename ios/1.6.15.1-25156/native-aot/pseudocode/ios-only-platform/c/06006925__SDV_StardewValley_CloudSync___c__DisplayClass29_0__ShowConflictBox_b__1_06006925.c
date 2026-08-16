/* 0x06006925 StardewValley.CloudSync+<>c__DisplayClass29_0.<ShowConflictBox>b__1 @ 0x101fefcd0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync___c__DisplayClass29_0__ShowConflictBox_b__1_06006925(long param_1)

{
  code *pcVar1;
  undefined8 uVar2;
  
  if (lRam0000000103976fb8 == 0) {
    uVar2 = *(undefined8 *)(param_1 + 0x28);
  }
  else {
    func_0x00010119b8f8();
    uVar2 = *(undefined8 *)(param_1 + 0x28);
  }
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x10) = uVar2;
  *(undefined1 *)(((ulong)(param_1 + 0x10) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
  if (*(long *)(param_1 + 0x20) != 0) {
    func_0x00010037f098();
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036dbb88);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fefd50);
  (*pcVar1)();
}

