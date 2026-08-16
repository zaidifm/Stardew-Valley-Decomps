/* 0x06004ba8 StardewValley.Network.LoopbackServer.clientConnect @ 0x101b44a64 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackServer_clientConnect_06004ba8
               (long param_1,undefined8 param_2)

{
  uint uVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  long *plVar5;
  
  cVar2 = cRam000000010390f9b7;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1032fab05);
    cRam000000010390f9b7 = '\x01';
    lVar4 = *(long *)(param_1 + 0x40);
  }
  else {
    lVar4 = *(long *)(param_1 + 0x40);
  }
  plVar5 = *(long **)(lVar4 + 0x10);
  *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
  if (plVar5 != (long *)0x0) {
    uVar1 = *(uint *)(lVar4 + 0x18);
    if (uVar1 < *(uint *)(plVar5 + 3)) {
      *(uint *)(lVar4 + 0x18) = uVar1 + 1;
      (**(code **)(*plVar5 + 0x110))(plVar5,(long)(int)uVar1,param_2);
    }
    else {
      func_0x00010036cdbc(lVar4,param_2);
    }
    return;
  }
  func_0x0001003316f4(0xee,_UNK_103654ef0);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101b44b4c);
  (*pcVar3)();
}

