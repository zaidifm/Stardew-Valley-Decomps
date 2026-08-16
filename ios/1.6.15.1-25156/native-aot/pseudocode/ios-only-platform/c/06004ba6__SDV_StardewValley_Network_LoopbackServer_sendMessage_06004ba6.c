/* 0x06004ba6 StardewValley.Network.LoopbackServer.sendMessage @ 0x101b449f4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackServer_sendMessage_06004ba6
               (undefined8 param_1,long param_2,undefined8 *param_3)

{
  code *pcVar1;
  undefined8 uStack_38;
  undefined8 uStack_30;
  undefined8 uStack_28;
  
  uStack_30 = param_3[1];
  uStack_38 = *param_3;
  uStack_28 = param_3[2];
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (param_2 == 0) {
    func_0x0001003316f4(0xee,_UNK_103654ed8);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101b44a60);
    (*pcVar1)();
  }
  SDV_StardewValley_Network_LoopbackClient_serverMessage_06004b90(param_2,&uStack_38);
  return;
}

