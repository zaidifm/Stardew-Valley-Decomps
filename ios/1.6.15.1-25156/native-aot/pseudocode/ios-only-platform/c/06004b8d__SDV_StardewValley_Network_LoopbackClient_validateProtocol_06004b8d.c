/* 0x06004b8d StardewValley.Network.LoopbackClient.validateProtocol @ 0x101b425ec */

void SDV_StardewValley_Network_LoopbackClient_validateProtocol_06004b8d
               (undefined8 param_1,undefined8 param_2)

{
  undefined8 uVar1;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar1 = StardewValley_StardewValley_Multiplayer_get_protocolVersion_06003c1a();
  func_0x000100345aa0(param_2,uVar1);
  return;
}

