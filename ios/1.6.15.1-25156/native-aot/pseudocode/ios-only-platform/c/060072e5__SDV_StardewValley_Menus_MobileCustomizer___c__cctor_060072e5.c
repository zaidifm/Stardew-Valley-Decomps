/* 0x060072e5 StardewValley.Menus.MobileCustomizer+<>c..cctor @ 0x1020a8200 */

void SDV_StardewValley_Menus_MobileCustomizer___c__cctor_060072e5(void)

{
  char cVar1;
  undefined8 uVar2;
  
  cVar1 = cRam00000001039120f4;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_10332fd38);
    cRam00000001039120f4 = '\x01';
  }
  uVar2 = func_0x000100331820(uRam0000000103909428,0x10);
  DataMemoryBarrier(2,3);
  *puRam0000000103900448 = uVar2;
  return;
}

