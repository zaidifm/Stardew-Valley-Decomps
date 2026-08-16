/* 0x06006f9b StardewValley.Network.LoopbackServer+<>c__DisplayClass30_1.<parseDataMessageFromClient>b__1 @ 0x1020697f0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackServer___c__DisplayClass30_1__parseDataMessageFromClient_b__1_06006f9b
               (long param_1)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  undefined8 uVar4;
  long lVar5;
  long lVar6;
  
  cVar1 = cRam0000000103911daa;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_10332da47);
    cRam0000000103911daa = '\x01';
    lVar5 = *(long *)(param_1 + 0x18);
  }
  else {
    lVar5 = *(long *)(param_1 + 0x18);
  }
  uVar4 = _UNK_1036e6948;
  if (((*(long *)(lVar5 + 0x10) != 0) &&
      (lVar6 = *(long *)(*(long *)(*(long *)(param_1 + 0x10) + 0x60) + 0x2e0),
      uVar4 = _UNK_1036e6960, lVar6 != 0)) &&
     (lVar3 = *(long *)(*(long *)(lVar5 + 0x10) + 0x58), uVar4 = _UNK_1036e6968, lVar3 != 0)) {
    func_0x000100380588(lVar3,*(undefined8 *)(lVar6 + 0x68),*(undefined8 *)(lVar5 + 0x18));
    return;
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x1020698e4);
  (*pcVar2)();
}

