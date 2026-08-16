/* 0x06006772 StardewValley.iOS.AppDelegate.DidEnterBackground @ 0x101fd90a4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_iOS_AppDelegate_DidEnterBackground_06006772(undefined8 param_1)

{
  long lVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  long lVar5;
  long lVar6;
  undefined8 uVar7;
  long lVar8;
  
  cVar2 = cRam0000000103911581;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325f30);
    cRam0000000103911581 = '\x01';
  }
  lVar4 = func_0x000100331820(uRam0000000103904bc8,0x20);
  lVar1 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar4 + 0x10) = param_1;
  *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
  *(undefined8 *)(lVar4 + 0x18) = 0;
  lVar5 = func_0x0001003782fc();
  lVar6 = func_0x000100331820(uRam00000001038d3b88,0x80);
  DataMemoryBarrier(2,3);
  *(long *)(lVar6 + 0x20) = lVar4;
  *(undefined1 *)(((ulong)(lVar6 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
  uVar7 = uRam0000000103904bd8;
  lVar8 = lRam0000000103904bd0;
  *(long *)(lVar6 + 0x40) = lRam0000000103904bd0;
  *(undefined8 *)(lVar6 + 0x28) = uVar7;
  *(undefined8 *)(lVar6 + 0x18) = *(undefined8 *)(lVar8 + 0x30);
  *(undefined8 *)(lVar6 + 0x10) = *(undefined8 *)(lVar8 + 0x28);
  uVar7 = _UNK_1036d95a8;
  if (lVar5 != 0) {
    uVar7 = func_0x00010037e6c0(lVar5,lVar6);
    lVar8 = lRam00000001038d5518;
    *(undefined8 *)(lVar4 + 0x18) = uVar7;
    if (*(char *)(lVar8 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    lVar5 = *plRam0000000103904be0;
    lVar8 = func_0x000100331820(uRam00000001038d3b88,0x80);
    DataMemoryBarrier(2,3);
    *(long *)(lVar8 + 0x20) = lVar4;
    *(undefined1 *)(((ulong)(lVar8 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
    uVar7 = uRam0000000103904bf0;
    lVar1 = lRam0000000103904be8;
    *(long *)(lVar8 + 0x40) = lRam0000000103904be8;
    *(undefined8 *)(lVar8 + 0x28) = uVar7;
    *(undefined8 *)(lVar8 + 0x18) = *(undefined8 *)(lVar1 + 0x30);
    *(undefined8 *)(lVar8 + 0x10) = *(undefined8 *)(lVar1 + 0x28);
    uVar7 = _UNK_1036d95b0;
    if (lVar5 != 0) {
      func_0x00010037e6d4(lVar5,lVar8);
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fd924c);
  (*pcVar3)();
}

