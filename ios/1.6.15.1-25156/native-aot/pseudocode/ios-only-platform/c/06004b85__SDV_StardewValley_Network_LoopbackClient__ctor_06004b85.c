/* 0x06004b85 StardewValley.Network.LoopbackClient..ctor @ 0x101b420a0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackClient__ctor_06004b85(long param_1)

{
  long lVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  undefined8 *puVar7;
  int iStack_44;
  
  cVar2 = cRam000000010390f994;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1032fa900);
    cRam000000010390f994 = '\x01';
  }
  iStack_44 = 0;
  lVar4 = func_0x000100331820(uRam00000001038f5408,0x20);
  lVar1 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar4 + 0x10) = *puRam00000001038f5410;
  *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x78) = lVar4;
    *(undefined1 *)(((ulong)(param_1 + 0x78) >> 9 & 0x7fffff) + lVar1) = 1;
    StardewValley_StardewValley_Network_Client__ctor_06004ad6(param_1);
    iStack_44 = *piRam00000001038f5418 + 1;
    *piRam00000001038f5418 = iStack_44;
    uVar6 = uRam00000001038f5420;
    uVar5 = func_0x00010035138c(&iStack_44);
    uVar6 = func_0x0001003323d8(uVar6,uVar5);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x50) = uVar6;
    *(undefined1 *)(((ulong)(param_1 + 0x50) >> 9 & 0x7fffff) + lVar1) = 1;
    uVar6 = func_0x000100331820(uRam00000001038c4fc0,0x40);
    func_0x00010036cda8(uVar6,0x100000);
    DataMemoryBarrier(2,3);
    puVar7 = (undefined8 *)(param_1 + 0x70);
    *puVar7 = uVar6;
    *(undefined1 *)(((ulong)puVar7 >> 9 & 0x7fffff) + lVar1) = 1;
    uVar5 = *puVar7;
    uVar6 = func_0x000100331820(uRam00000001038f51e8,0x40);
    func_0x00010036c858(uVar6,uVar5);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x60) = uVar6;
    *(undefined1 *)(((ulong)(param_1 + 0x60) >> 9 & 0x7fffff) + lVar1) = 1;
    uVar5 = *puVar7;
    uVar6 = func_0x000100331820(uRam00000001038df888,0x28);
    func_0x000100357958(uVar6,uVar5);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x68) = uVar6;
    *(undefined1 *)(((ulong)(param_1 + 0x68) >> 9 & 0x7fffff) + lVar1) = 1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_103654a40);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101b4225c);
  (*pcVar3)();
}

