/* 0x06004b90 StardewValley.Network.LoopbackClient.serverMessage @ 0x101b428c0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackClient_serverMessage_06004b90
               (long param_1,undefined8 param_2)

{
  uint uVar1;
  char cVar2;
  code *pcVar3;
  long *plVar4;
  undefined8 uVar5;
  long lVar6;
  
  cVar2 = cRam000000010390f99f;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1032fa952);
    cRam000000010390f99f = '\x01';
    plVar4 = *(long **)(param_1 + 0x70);
  }
  else {
    plVar4 = *(long **)(param_1 + 0x70);
  }
  (**(code **)(*plVar4 + 0x148))(plVar4,0);
  StardewValley_StardewValley_Network_OutgoingMessage_Write_06004cd1
            (param_2,*(undefined8 *)(param_1 + 0x68));
  (**(code **)(**(long **)(param_1 + 0x68) + 0x118))();
  (**(code **)(**(long **)(param_1 + 0x70) + 0x148))(*(long **)(param_1 + 0x70),0);
  uVar5 = func_0x000100331820(uRam00000001038cf890,0x38);
  StardewValley_StardewValley_Network_IncomingMessage_Read_06004b46
            (uVar5,*(undefined8 *)(param_1 + 0x60));
  lVar6 = *(long *)(param_1 + 0x78);
  plVar4 = *(long **)(lVar6 + 0x10);
  *(int *)(lVar6 + 0x1c) = *(int *)(lVar6 + 0x1c) + 1;
  if (plVar4 != (long *)0x0) {
    uVar1 = *(uint *)(lVar6 + 0x18);
    if (uVar1 < *(uint *)(plVar4 + 3)) {
      *(uint *)(lVar6 + 0x18) = uVar1 + 1;
      (**(code **)(*plVar4 + 0x110))(plVar4,(long)(int)uVar1,uVar5);
    }
    else {
      func_0x00010036ce34(lVar6,uVar5);
    }
    return;
  }
  func_0x0001003316f4(0xee,_UNK_103654b28);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101b42a2c);
  (*pcVar3)();
}

