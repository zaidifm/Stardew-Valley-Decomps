/* 0x06004b91 StardewValley.Network.LoopbackClient.serverDisconnect @ 0x101b42a2c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackClient_serverDisconnect_06004b91(long param_1)

{
  int iVar1;
  code *pcVar2;
  undefined8 uVar3;
  long lVar4;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar3 = _UNK_103654b30;
  if (param_1 != 0) {
    lVar4 = *(long *)(param_1 + 0x78);
    *(undefined4 *)(param_1 + 0x3c) = 10;
    uVar3 = _UNK_103654b38;
    if (lVar4 != 0) {
      iVar1 = *(int *)(lVar4 + 0x18);
      *(undefined4 *)(lVar4 + 0x18) = 0;
      *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
      if (0 < iVar1) {
        func_0x000100331c80(*(undefined8 *)(lVar4 + 0x10),0);
      }
      *(undefined8 *)(param_1 + 0x58) = 0;
      *(undefined8 *)(param_1 + 0x18) = 0;
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101b42ab8);
  (*pcVar2)();
}

