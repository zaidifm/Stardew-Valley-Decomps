/* 0x06004ba4 StardewValley.Network.LoopbackServer.parseDataMessageFromClient @ 0x101b445d8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackServer_parseDataMessageFromClient_06004ba4
               (long param_1,undefined8 param_2,long param_3)

{
  long lVar1;
  undefined8 uVar2;
  code *pcVar3;
  char cVar4;
  long lVar5;
  long lVar6;
  long *plVar7;
  undefined8 uVar8;
  long lVar9;
  undefined8 uVar10;
  undefined8 uVar11;
  long lVar12;
  
  cVar4 = cRam000000010390f9b3;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_1032faac0);
    cRam000000010390f9b3 = '\x01';
  }
  lVar5 = func_0x000100331820(uRam00000001038f5560,0x20);
  lVar1 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(long *)(lVar5 + 0x10) = param_1;
  *(undefined1 *)(((ulong)(lVar5 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar5 + 0x18) = param_2;
  *(undefined1 *)(((ulong)(lVar5 + 0x18) >> 9 & 0x7fffff) + lVar1) = 1;
  uVar8 = _UNK_103654e78;
  if (((param_1 == 0) || (uVar8 = _UNK_103654e80, param_3 == 0)) ||
     (uVar8 = _UNK_103654e88, *(long *)(param_1 + 0x58) == 0)) goto LAB_101b448e8;
  cVar4 = func_0x00010036ce84(*(long *)(param_1 + 0x58),*(undefined8 *)(param_3 + 0x30));
  if (cVar4 != '\0') {
    uVar8 = _UNK_103654eb0;
    if (*(long *)(param_1 + 0x58) == 0) goto LAB_101b448e8;
    lVar6 = func_0x00010036ce98(*(long *)(param_1 + 0x58),*(undefined8 *)(param_3 + 0x30));
    if (*(long *)(lVar5 + 0x18) == lVar6) {
      plVar7 = *(long **)(param_1 + 0x10);
      uVar8 = _UNK_103654eb8;
      if (plVar7 != (long *)0x0) {
        (**(code **)(*plVar7 + -0x68))(plVar7,param_3);
        return;
      }
      goto LAB_101b448e8;
    }
  }
  if (*(char *)(param_3 + 0x28) != '\x02') {
    return;
  }
  lVar6 = func_0x000100331820(uRam00000001038f5568,0x20);
  DataMemoryBarrier(2,3);
  *(long *)(lVar6 + 0x18) = lVar5;
  *(undefined1 *)(((ulong)(lVar6 + 0x18) >> 9 & 0x7fffff) + lVar1) = 1;
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar8 = (**(code **)(*(long *)*puRam00000001038d5710 + 0x1d8))
                    ((long *)*puRam00000001038d5710,*(undefined8 *)(param_3 + 0x20));
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar6 + 0x10) = uVar8;
  *(undefined1 *)(((ulong)(lVar6 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
  uVar2 = uRam00000001038c4f58;
  lVar12 = *(long *)(lVar6 + 0x18);
  lVar5 = *(long *)(lVar12 + 0x18);
  uVar8 = _UNK_103654ea0;
  if (lVar5 != 0) {
    uVar10 = *(undefined8 *)(lVar5 + 0x50);
    plVar7 = *(long **)(param_1 + 0x10);
    uVar11 = *(undefined8 *)(lVar6 + 0x10);
    lVar9 = func_0x000100331820(uRam00000001038f5248,0x80);
    DataMemoryBarrier(2,3);
    *(long *)(lVar9 + 0x20U) = lVar12;
    *(undefined1 *)((lVar9 + 0x20U >> 9 & 0x7fffff) + lVar1) = 1;
    uVar8 = uRam00000001038f5578;
    lVar5 = lRam00000001038f5570;
    *(long *)(lVar9 + 0x40) = lRam00000001038f5570;
    *(undefined8 *)(lVar9 + 0x28) = uVar8;
    *(undefined8 *)(lVar9 + 0x18) = *(undefined8 *)(lVar5 + 0x30);
    uVar8 = uRam00000001038d3b88;
    *(undefined8 *)(lVar9 + 0x10) = *(undefined8 *)(lVar5 + 0x28);
    lVar5 = func_0x000100331820(uVar8,0x80);
    DataMemoryBarrier(2,3);
    *(long *)(lVar5 + 0x20) = lVar6;
    *(undefined1 *)(((ulong)(lVar5 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
    uVar8 = uRam00000001038f5588;
    lVar1 = lRam00000001038f5580;
    *(long *)(lVar5 + 0x40) = lRam00000001038f5580;
    *(undefined8 *)(lVar5 + 0x28) = uVar8;
    *(undefined8 *)(lVar5 + 0x18) = *(undefined8 *)(lVar1 + 0x30);
    *(undefined8 *)(lVar5 + 0x10) = *(undefined8 *)(lVar1 + 0x28);
    uVar8 = _UNK_103654ea8;
    if (plVar7 != (long *)0x0) {
      (**(code **)(*plVar7 + -0x30))(plVar7,uVar2,uVar10,uVar11,lVar9,lVar5);
      return;
    }
  }
LAB_101b448e8:
  func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101b448f4);
  (*pcVar3)();
}

