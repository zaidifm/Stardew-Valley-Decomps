/* 0x06006f92 StardewValley.Network.LoopbackServer+<>c..cctor @ 0x1020694d8 */

void SDV_StardewValley_Network_LoopbackServer___c__cctor_06006f92(void)

{
  char cVar1;
  undefined8 uVar2;
  
  cVar1 = cRam0000000103911da1;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_10332da0d);
    cRam0000000103911da1 = '\x01';
  }
  uVar2 = func_0x000100331820(uRam0000000103908a78,0x10);
  DataMemoryBarrier(2,3);
  *puRam00000001038f5530 = uVar2;
  return;
}

