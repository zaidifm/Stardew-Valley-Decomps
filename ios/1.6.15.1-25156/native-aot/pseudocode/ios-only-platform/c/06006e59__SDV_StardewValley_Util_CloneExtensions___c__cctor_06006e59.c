/* 0x06006e59 StardewValley.Util.CloneExtensions+<>c..cctor @ 0x1020566b8 */

void SDV_StardewValley_Util_CloneExtensions___c__cctor_06006e59(void)

{
  char cVar1;
  undefined8 uVar2;
  
  cVar1 = cRam0000000103911c68;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_10332c897);
    cRam0000000103911c68 = '\x01';
  }
  uVar2 = func_0x000100331820(uRam0000000103908318,0x10);
  DataMemoryBarrier(2,3);
  *puRam00000001038f0308 = uVar2;
  return;
}

