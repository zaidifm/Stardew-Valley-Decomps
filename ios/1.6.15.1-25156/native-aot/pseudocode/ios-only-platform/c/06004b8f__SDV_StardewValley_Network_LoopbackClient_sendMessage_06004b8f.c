/* 0x06004b8f StardewValley.Network.LoopbackClient.sendMessage @ 0x101b42848 */

void SDV_StardewValley_Network_LoopbackClient_sendMessage_06004b8f(long param_1,undefined8 *param_2)

{
  long lVar1;
  undefined8 uStack_38;
  undefined8 uStack_30;
  undefined8 uStack_28;
  
  if (lRam0000000103976fb8 == 0) {
    lVar1 = *(long *)(param_1 + 0x58);
  }
  else {
    func_0x00010119b8f8();
    lVar1 = *(long *)(param_1 + 0x58);
  }
  if (lVar1 != 0) {
    uStack_30 = param_2[1];
    uStack_38 = *param_2;
    uStack_28 = param_2[2];
    SDV_StardewValley_Network_LoopbackServer_clientMessage_06004ba9(lVar1,param_1,&uStack_38);
  }
  return;
}

