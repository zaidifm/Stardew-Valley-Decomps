/* 0x06006f94 StardewValley.Network.LoopbackServer+<>c.<receiveMessages>b__27_1 @ 0x102069580 */

bool SDV_StardewValley_Network_LoopbackServer___c__receiveMessages_b__27_1_06006f94(void)

{
  char cVar1;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  cVar1 = StardewValley_StardewValley_Game1_get_gameMode_06002fda();
  return cVar1 != '\x06';
}

