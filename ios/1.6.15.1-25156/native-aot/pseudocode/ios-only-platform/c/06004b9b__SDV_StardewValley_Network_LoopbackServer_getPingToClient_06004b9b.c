/* 0x06004b9b StardewValley.Network.LoopbackServer.getPingToClient @ 0x101b4340c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined4
SDV_StardewValley_Network_LoopbackServer_getPingToClient_06004b9b(long param_1,undefined8 param_2)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined4 uVar4;
  
  cVar2 = cRam000000010390f9aa;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1032fa9fa);
    cRam000000010390f9aa = '\x01';
    lVar3 = *(long *)(param_1 + 0x58);
  }
  else {
    lVar3 = *(long *)(param_1 + 0x58);
  }
  if (lVar3 != 0) {
    cVar2 = func_0x00010036ce84(lVar3,param_2);
    uVar4 = 0xbf800000;
    if (cVar2 != '\0') {
      uVar4 = 0;
    }
    return uVar4;
  }
  func_0x0001003316f4(0xee,_UNK_103654bf0);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101b434b8);
  (*pcVar1)();
}

