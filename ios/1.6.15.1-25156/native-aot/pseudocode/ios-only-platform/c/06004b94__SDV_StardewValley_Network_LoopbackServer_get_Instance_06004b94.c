/* 0x06004b94 StardewValley.Network.LoopbackServer.get_Instance @ 0x101b42b50 */

undefined8 SDV_StardewValley_Network_LoopbackServer_get_Instance_06004b94(void)

{
  if (cRam000000010390f9a3 == '\0') {
    func_0x00010119b908(&UNK_1032fa95d);
    cRam000000010390f9a3 = '\x01';
  }
  return *puRam00000001038f5428;
}

