/* 0x060032f2 StardewValley.CloudSync..ctor @ 0x1017a0308 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync__ctor_060032f2(long param_1)

{
  long lVar1;
  char cVar2;
  code *pcVar3;
  undefined8 uVar4;
  long lVar5;
  
  cVar2 = cRam000000010390e101;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1032d3bfc);
    cRam000000010390e101 = '\x01';
  }
  uVar4 = func_0x000100331820(uRam00000001038c6120,0x10);
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x10) = uVar4;
    lVar1 = lRam00000001038c4be0;
    *(undefined1 *)(((ulong)(param_1 + 0x10) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    lVar5 = func_0x000100331820(uRam00000001038c59b8,0x20);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar5 + 0x10) = *puRam00000001038c59c0;
    *(undefined1 *)(((ulong)(lVar5 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x28) = lVar5;
    *(undefined1 *)(((ulong)(param_1 + 0x28) >> 9 & 0x7fffff) + lVar1) = 1;
    lVar5 = func_0x000100331820(uRam00000001038c59b8,0x20);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar5 + 0x10) = *puRam00000001038c59c0;
    *(undefined1 *)(((ulong)(lVar5 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x30) = lVar5;
    *(undefined1 *)(((ulong)(param_1 + 0x30) >> 9 & 0x7fffff) + lVar1) = 1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1035f5710);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x1017a0430);
  (*pcVar3)();
}

