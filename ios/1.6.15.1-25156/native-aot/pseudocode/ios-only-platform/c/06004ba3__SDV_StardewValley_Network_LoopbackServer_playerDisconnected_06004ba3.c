/* 0x06004ba3 StardewValley.Network.LoopbackServer.playerDisconnected @ 0x101b444a0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackServer_playerDisconnected_06004ba3
               (long *param_1,undefined8 param_2)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  undefined8 uVar4;
  
  cVar1 = cRam000000010390f9b2;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1032faaa0);
    cRam000000010390f9b2 = '\x01';
  }
  StardewValley_StardewValley_Network_Server_playerDisconnected_06004d1a(param_1,param_2);
  uVar4 = _UNK_103654e50;
  if (param_1[0xb] != 0) {
    lVar3 = func_0x00010036ce98(param_1[0xb],param_2);
    uVar4 = _UNK_103654e58;
    if ((param_1[0xb] != 0) &&
       (func_0x00010036cf74(param_1[0xb],param_2), uVar4 = _UNK_103654e60, lVar3 != 0)) {
      (**(code **)(*param_1 + 0xa8))(param_1,*(undefined8 *)(lVar3 + 0x50));
      uVar4 = _UNK_103654e68;
      if (param_1[8] != 0) {
        func_0x00010036cf10(param_1[8],lVar3);
        uVar4 = _UNK_103654e70;
        if (param_1[9] != 0) {
          func_0x00010036cf10(param_1[9],lVar3);
          return;
        }
      }
    }
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101b445d8);
  (*pcVar2)();
}

