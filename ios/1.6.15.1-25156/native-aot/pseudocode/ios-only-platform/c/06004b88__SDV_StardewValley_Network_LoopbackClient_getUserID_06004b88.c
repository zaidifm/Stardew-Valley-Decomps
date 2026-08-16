/* 0x06004b88 StardewValley.Network.LoopbackClient.getUserID @ 0x101b422ac */

undefined8 SDV_StardewValley_Network_LoopbackClient_getUserID_06004b88(void)

{
  if (cRam000000010390f997 == '\0') {
    func_0x00010119b908(&UNK_1032fa921);
    cRam000000010390f997 = '\x01';
  }
  return uRam00000001038c4f58;
}

