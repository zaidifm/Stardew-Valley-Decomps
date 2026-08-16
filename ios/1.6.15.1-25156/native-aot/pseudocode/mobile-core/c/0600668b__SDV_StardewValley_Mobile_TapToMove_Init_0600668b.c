/* 0x0600668b StardewValley.Mobile.TapToMove.Init @ 0x101fb1274 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_Init_0600668b(long param_1,undefined8 param_2)

{
  long lVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  long lVar5;
  undefined8 uVar6;
  long *plVar7;
  
  cVar2 = cRam000000010391149a;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325100);
    cRam000000010391149a = '\x01';
  }
  lVar4 = func_0x000100331820(uRam00000001039048c0,0x30);
  if (*(char *)(lRam00000001039045a8 + 0x35) == '\0') {
    func_0x0001003319b0(lRam00000001039045a8);
  }
  lVar5 = func_0x000100331820(lRam00000001039045a8,0x20);
  lVar1 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar5 + 0x10U) = *puRam00000001039045b0;
  *(undefined1 *)((lVar5 + 0x10U >> 9 & 0x7fffff) + lVar1) = 1;
  DataMemoryBarrier(2,3);
  *(long *)(lVar4 + 0x28) = lVar5;
  *(undefined1 *)(((ulong)(lVar4 + 0x28) >> 9 & 0x7fffff) + lVar1) = 1;
  uVar6 = _UNK_1036d3b38;
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    plVar7 = (long *)(param_1 + 0x28);
    *plVar7 = lVar4;
    *(undefined1 *)(((ulong)plVar7 >> 9 & 0x7fffff) + lVar1) = 1;
    uVar6 = _UNK_1036d3b40;
    if (*plVar7 != 0) {
      SDV_StardewValley_Mobile_AStarGraph_Init_060065fb(*plVar7,param_2);
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fb1398);
  (*pcVar3)();
}

