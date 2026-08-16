/* 0x06004b95 StardewValley.Network.LoopbackServer.set_Instance @ 0x101b42b94 */

void SDV_StardewValley_Network_LoopbackServer_set_Instance_06004b95(undefined8 param_1)

{
  if (cRam000000010390f9a4 == '\0') {
    func_0x00010119b908(&UNK_1032fa966);
    cRam000000010390f9a4 = '\x01';
  }
  DataMemoryBarrier(2,3);
  *puRam00000001038f5428 = param_1;
  return;
}

