/* 0x06006666 StardewValley.Mobile.AStarPath..ctor @ 0x101faedbc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_AStarPath_ctor_06006666(long param_1)

{
  long lVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  
  cVar2 = cRam0000000103911475;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103324e73);
    cRam0000000103911475 = '\x01';
  }
  lVar4 = func_0x000100331820(uRam00000001039045a8,0x20);
  lVar1 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar4 + 0x10U) = *puRam00000001039045b0;
  *(undefined1 *)((lVar4 + 0x10U >> 9 & 0x7fffff) + lVar1) = 1;
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x10) = lVar4;
    *(undefined1 *)(((ulong)(param_1 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d37a0);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101faee7c);
  (*pcVar3)();
}

