/* 0x06004ba9 StardewValley.Network.LoopbackServer.clientMessage @ 0x101b44b4c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackServer_clientMessage_06004ba9
               (long param_1,undefined8 param_2,undefined8 param_3)

{
  uint uVar1;
  long lVar2;
  char cVar3;
  code *pcVar4;
  long *plVar5;
  undefined8 uVar6;
  long lVar7;
  long lVar8;
  undefined8 *puVar9;
  undefined8 uStack_50;
  undefined8 uStack_48;
  
  cVar3 = cRam000000010390f9b8;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_1032fab0e);
    cRam000000010390f9b8 = '\x01';
    plVar5 = *(long **)(param_1 + 0x38);
  }
  else {
    plVar5 = *(long **)(param_1 + 0x38);
  }
  (**(code **)(*plVar5 + 0x148))(plVar5,0);
  StardewValley_StardewValley_Network_OutgoingMessage_Write_06004cd1
            (param_3,*(undefined8 *)(param_1 + 0x30));
  (**(code **)(**(long **)(param_1 + 0x30) + 0x118))();
  (**(code **)(**(long **)(param_1 + 0x38) + 0x148))(*(long **)(param_1 + 0x38),0);
  uVar6 = func_0x000100331820(uRam00000001038cf890,0x38);
  StardewValley_StardewValley_Network_IncomingMessage_Read_06004b46
            (uVar6,*(undefined8 *)(param_1 + 0x28));
  lVar2 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined1 *)(((ulong)&uStack_50 >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
  DataMemoryBarrier(2,3);
  *(undefined1 *)(((ulong)&uStack_48 >> 9 & 0x7fffff) + lVar2) = 1;
  lVar7 = *(long *)(param_1 + 0x20);
  lVar8 = *(long *)(lVar7 + 0x10);
  *(int *)(lVar7 + 0x1c) = *(int *)(lVar7 + 0x1c) + 1;
  uStack_50 = param_2;
  uStack_48 = uVar6;
  if (lVar8 == 0) {
    func_0x0001003316f4(0xee,_UNK_103654f20);
                    /* WARNING: Does not return */
    pcVar4 = (code *)SoftwareBreakpoint(1,0x101b44d24);
    (*pcVar4)();
  }
  uVar1 = *(uint *)(lVar7 + 0x18);
  if (uVar1 < *(uint *)(lVar8 + 0x18)) {
    *(uint *)(lVar7 + 0x18) = uVar1 + 1;
    if (*(uint *)(lVar8 + 0x18) <= uVar1) {
      func_0x0001003316f4(0xcc,_UNK_103654f28);
                    /* WARNING: Does not return */
      pcVar4 = (code *)SoftwareBreakpoint(1,0x101b44d38);
      (*pcVar4)();
    }
    lVar8 = lVar8 + (long)(int)uVar1 * 0x10;
    DataMemoryBarrier(2,3);
    puVar9 = (undefined8 *)(lVar8 + 0x20);
    *puVar9 = param_2;
    *(undefined1 *)(((ulong)puVar9 >> 9 & 0x7fffff) + lVar2) = 1;
    puVar9 = (undefined8 *)(lVar8 + 0x28);
    *puVar9 = uVar6;
    *(undefined1 *)(((ulong)puVar9 >> 9 & 0x7fffff) + lVar2) = 1;
  }
  else {
    func_0x00010036cf9c();
  }
  return;
}

