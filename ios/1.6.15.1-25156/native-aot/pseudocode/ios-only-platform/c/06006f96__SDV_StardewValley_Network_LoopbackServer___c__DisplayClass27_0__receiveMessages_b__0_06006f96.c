/* 0x06006f96 StardewValley.Network.LoopbackServer+<>c__DisplayClass27_0.<receiveMessages>b__0 @ 0x1020695b8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackServer___c__DisplayClass27_0__receiveMessages_b__0_06006f96
               (long param_1)

{
  long lVar1;
  undefined8 uVar2;
  long lVar3;
  char cVar4;
  code *pcVar5;
  undefined8 uVar6;
  long lVar7;
  long *plVar8;
  undefined8 uVar9;
  
  cVar4 = cRam0000000103911da5;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_10332da30);
    cRam0000000103911da5 = '\x01';
    lVar7 = *(long *)(param_1 + 0x18);
  }
  else {
    lVar7 = *(long *)(param_1 + 0x18);
  }
  uVar2 = uRam00000001038c4f58;
  uVar6 = _UNK_1036e6910;
  if ((lVar7 != 0) && (uVar6 = _UNK_1036e6918, *(long *)(param_1 + 0x10) != 0)) {
    plVar8 = *(long **)(lVar7 + 0x10);
    lVar7 = *(long *)(param_1 + 0x20);
    uVar9 = *(undefined8 *)(*(long *)(param_1 + 0x10) + 0x50);
    if (lVar7 == 0) {
      lVar7 = func_0x000100331820(uRam00000001038f5248,0x80);
      lVar1 = lRam00000001038c4be0;
      DataMemoryBarrier(2,3);
      *(long *)(lVar7 + 0x20) = param_1;
      *(undefined1 *)(((ulong)(lVar7 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
      uVar6 = uRam0000000103908a88;
      lVar3 = lRam0000000103908a80;
      *(long *)(lVar7 + 0x40) = lRam0000000103908a80;
      *(undefined8 *)(lVar7 + 0x28) = uVar6;
      *(undefined8 *)(lVar7 + 0x18) = *(undefined8 *)(lVar3 + 0x30);
      *(undefined8 *)(lVar7 + 0x10) = *(undefined8 *)(lVar3 + 0x28);
      DataMemoryBarrier(2,3);
      *(long *)(param_1 + 0x20) = lVar7;
      *(undefined1 *)(((ulong)(param_1 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
    }
    uVar6 = _UNK_1036e6920;
    if (plVar8 != (long *)0x0) {
      (**(code **)(*plVar8 + -0x20))(plVar8,uVar2,uVar9,lVar7);
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar5 = (code *)SoftwareBreakpoint(1,0x102069708);
  (*pcVar5)();
}

