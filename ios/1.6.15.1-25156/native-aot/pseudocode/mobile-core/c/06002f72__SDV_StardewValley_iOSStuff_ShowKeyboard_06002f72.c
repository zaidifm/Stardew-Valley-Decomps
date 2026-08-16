/* 0x06002f72 StardewValley.iOSStuff.ShowKeyboard @ 0x1017087ec */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_iOSStuff_ShowKeyboard_06002f72(undefined8 param_1,long param_2)

{
  long lVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  long lVar5;
  undefined8 uVar6;
  long *plVar7;
  long lVar8;
  
  cVar2 = cRam000000010390dd81;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1032cc240);
    cRam000000010390dd81 = '\x01';
  }
  lVar4 = func_0x000100331820(uRam00000001038d51c8,0x20);
  lVar1 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  plVar7 = (long *)(lVar4 + 0x18);
  *plVar7 = param_2;
  *(undefined1 *)(((ulong)plVar7 >> 9 & 0x7fffff) + lVar1) = 1;
  uVar6 = _UNK_1035e7d10;
  if (*plVar7 != 0) {
    lVar5 = func_0x0001003516c0(param_1,uRam00000001038c4f58,*(undefined8 *)(*plVar7 + 0x28),0);
    DataMemoryBarrier(2,3);
    plVar7 = (long *)(lVar4 + 0x10);
    *plVar7 = lVar5;
    *(undefined1 *)(((ulong)plVar7 >> 9 & 0x7fffff) + lVar1) = 1;
    lVar8 = *plVar7;
    lVar5 = func_0x000100331820(uRam00000001038d51d0,0x80);
    DataMemoryBarrier(2,3);
    *(long *)(lVar5 + 0x20) = lVar4;
    *(undefined1 *)(((ulong)(lVar5 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
    uVar6 = uRam00000001038d51e0;
    lVar1 = lRam00000001038d51d8;
    *(long *)(lVar5 + 0x40) = lRam00000001038d51d8;
    *(undefined8 *)(lVar5 + 0x28) = uVar6;
    *(undefined8 *)(lVar5 + 0x18) = *(undefined8 *)(lVar1 + 0x30);
    *(undefined8 *)(lVar5 + 0x10) = *(undefined8 *)(lVar1 + 0x28);
    uVar6 = _UNK_1035e7d18;
    if (lVar8 != 0) {
      func_0x0001003516d4(lVar8,lVar5);
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x10170893c);
  (*pcVar3)();
}

