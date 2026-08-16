/* 0x06004b8c StardewValley.Network.LoopbackClient.disconnect @ 0x101b42454 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackClient_disconnect_06004b8c(long *param_1,char param_2)

{
  int iVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  undefined8 uStack_60;
  undefined8 uStack_58;
  undefined8 uStack_50;
  undefined8 uStack_48;
  undefined8 uStack_40;
  undefined8 uStack_38;
  
  cVar2 = cRam000000010390f99b;
  if (lRam0000000103976fb8 == 0) {
    if (cRam000000010390f99b == '\0') goto LAB_101b42580;
LAB_101b42488:
    lVar4 = param_1[0xb];
  }
  else {
    func_0x00010119b8f8();
    if (cVar2 != '\0') goto LAB_101b42488;
LAB_101b42580:
    func_0x00010119b908(&UNK_1032fa93c);
    cRam000000010390f99b = '\x01';
    lVar4 = param_1[0xb];
  }
  if (lVar4 != 0) {
    if (param_2 != '\0') {
      lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      if (*(char *)(lRam00000001038e35e8 + 0x35) == '\0') {
        func_0x0001003319b0(lRam00000001038e35e8);
      }
      uVar6 = *puRam00000001038e35f0;
      uStack_40 = 0;
      uStack_38 = 0;
      uStack_48 = 0;
      uVar5 = _UNK_103654a98;
      if (*(long *)(lVar4 + 0x2e0) == 0) goto LAB_101b425e0;
      uStack_58 = *(undefined8 *)(*(long *)(lVar4 + 0x2e0) + 0x68);
      uStack_48 = 0x13;
      DataMemoryBarrier(2,3);
      *(undefined1 *)(((ulong)&uStack_38 >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
      uStack_60 = 0x13;
      uStack_50 = uVar6;
      uStack_40 = uStack_58;
      uStack_38 = uVar6;
      (**(code **)(*param_1 + 0x100))(param_1,&uStack_60);
      lVar4 = param_1[0xb];
      uVar5 = _UNK_103654a90;
      if (lVar4 == 0) goto LAB_101b425e0;
    }
    SDV_StardewValley_Network_LoopbackServer_clientDisconnect_06004baa(lVar4,param_1);
    param_1[0xb] = 0;
  }
  lVar4 = param_1[0xf];
  uVar5 = _UNK_103654a80;
  if (lVar4 != 0) {
    iVar1 = *(int *)(lVar4 + 0x18);
    *(undefined4 *)(lVar4 + 0x18) = 0;
    *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
    if (0 < iVar1) {
      func_0x000100331c80(*(undefined8 *)(lVar4 + 0x10),0);
    }
    param_1[3] = 0;
    return;
  }
LAB_101b425e0:
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101b425ec);
  (*pcVar3)();
}

