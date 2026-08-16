/* 0x06004b96 StardewValley.Network.LoopbackServer..ctor @ 0x101b42be0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackServer__ctor_06004b96(long param_1,undefined8 param_2)

{
  long lVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  undefined8 *puVar7;
  
  cVar2 = cRam000000010390f9a5;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1032fa970);
    cRam000000010390f9a5 = '\x01';
  }
  lVar4 = func_0x000100331820(uRam00000001038f5458,0x20);
  lVar1 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar4 + 0x10) = *puRam00000001038f5460;
  *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x20) = lVar4;
    *(undefined1 *)(((ulong)(param_1 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
    lVar4 = func_0x000100331820(uRam00000001038f5468,0x20);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar4 + 0x10) = *puRam00000001038f5470;
    *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x40) = lVar4;
    *(undefined1 *)(((ulong)(param_1 + 0x40) >> 9 & 0x7fffff) + lVar1) = 1;
    lVar4 = func_0x000100331820(uRam00000001038f5468,0x20);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar4 + 0x10) = *puRam00000001038f5470;
    *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x48) = lVar4;
    *(undefined1 *)(((ulong)(param_1 + 0x48) >> 9 & 0x7fffff) + lVar1) = 1;
    lVar4 = func_0x000100331820(uRam00000001038f5468,0x20);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar4 + 0x10) = *puRam00000001038f5470;
    *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x50) = lVar4;
    *(undefined1 *)(((ulong)(param_1 + 0x50) >> 9 & 0x7fffff) + lVar1) = 1;
    uVar5 = func_0x000100331820(uRam00000001038f5478,0x20);
    func_0x00010036ce48();
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x58) = uVar5;
    *(undefined1 *)(((ulong)(param_1 + 0x58) >> 9 & 0x7fffff) + lVar1) = 1;
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x10) = param_2;
    *(undefined1 *)(((ulong)(param_1 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
    DataMemoryBarrier(2,3);
    *plRam00000001038f5428 = param_1;
    uVar5 = func_0x000100331820(uRam00000001038c4fc0,0x40);
    func_0x00010036cda8(uVar5,0x100000);
    DataMemoryBarrier(2,3);
    puVar7 = (undefined8 *)(param_1 + 0x38);
    *puVar7 = uVar5;
    *(undefined1 *)(((ulong)puVar7 >> 9 & 0x7fffff) + lVar1) = 1;
    uVar6 = *puVar7;
    uVar5 = func_0x000100331820(uRam00000001038f51e8,0x40);
    func_0x00010036c858(uVar5,uVar6);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x28) = uVar5;
    *(undefined1 *)(((ulong)(param_1 + 0x28) >> 9 & 0x7fffff) + lVar1) = 1;
    uVar6 = *puVar7;
    uVar5 = func_0x000100331820(uRam00000001038df888,0x28);
    func_0x000100357958(uVar5,uVar6);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x30) = uVar5;
    *(undefined1 *)(((ulong)(param_1 + 0x30) >> 9 & 0x7fffff) + lVar1) = 1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_103654b58);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101b42e58);
  (*pcVar3)();
}

