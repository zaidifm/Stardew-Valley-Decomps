/* 0x06004b8b StardewValley.Network.LoopbackClient.connectImpl @ 0x101b42334 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackClient_connectImpl_06004b8b(long param_1)

{
  uint uVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  undefined8 uVar5;
  long *plVar6;
  
  cVar2 = cRam000000010390f99a;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  lVar4 = lRam00000001038c4be0;
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1032fa92f);
    cRam000000010390f99a = '\x01';
    lVar4 = lRam00000001038c4be0;
  }
  uVar5 = _UNK_103654a58;
  lRam00000001038c4be0 = lVar4;
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    plVar6 = (long *)(param_1 + 0x58);
    *plVar6 = *plRam00000001038f5428;
    *(undefined1 *)(((ulong)plVar6 >> 9 & 0x7fffff) + lVar4) = 1;
    lVar4 = *(long *)(*plVar6 + 0x40);
    plVar6 = *(long **)(lVar4 + 0x10);
    *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
    uVar5 = _UNK_103654a70;
    if (plVar6 != (long *)0x0) {
      uVar1 = *(uint *)(lVar4 + 0x18);
      if (uVar1 < *(uint *)(plVar6 + 3)) {
        *(uint *)(lVar4 + 0x18) = uVar1 + 1;
        (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,param_1);
      }
      else {
        func_0x00010036cdbc(lVar4,param_1);
      }
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101b42454);
  (*pcVar3)();
}

