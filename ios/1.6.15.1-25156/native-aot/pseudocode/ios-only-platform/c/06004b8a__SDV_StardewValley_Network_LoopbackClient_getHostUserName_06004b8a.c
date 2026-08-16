/* 0x06004b8a StardewValley.Network.LoopbackClient.getHostUserName @ 0x101b422f4 */

undefined8 SDV_StardewValley_Network_LoopbackClient_getHostUserName_06004b8a(void)

{
  if (cRam000000010390f999 == '\0') {
    func_0x00010119b908(&UNK_1032fa928);
    cRam000000010390f999 = '\x01';
  }
  return uRam00000001038cc5c0;
}

