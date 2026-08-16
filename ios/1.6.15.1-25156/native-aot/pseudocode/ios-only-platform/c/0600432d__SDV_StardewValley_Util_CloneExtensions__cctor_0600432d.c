/* 0x0600432d StardewValley.Util.CloneExtensions..cctor @ 0x101a3d860 */

void SDV_StardewValley_Util_CloneExtensions__cctor_0600432d(void)

{
  char cVar1;
  undefined8 uVar2;
  
  cVar1 = cRam000000010390f13c;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1032eed00);
    cRam000000010390f13c = '\x01';
  }
  uVar2 = func_0x00010034067c(uRam00000001038c9fb0,uRam00000001038f0340,0x24);
  DataMemoryBarrier(2,3);
  *puRam00000001038f02c8 = uVar2;
  return;
}

