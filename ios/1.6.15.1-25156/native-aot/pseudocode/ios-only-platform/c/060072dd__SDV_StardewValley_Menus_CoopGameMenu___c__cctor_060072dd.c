/* 0x060072dd StardewValley.Menus.CoopGameMenu+<>c..cctor @ 0x1020a7e20 */

void SDV_StardewValley_Menus_CoopGameMenu___c__cctor_060072dd(void)

{
  char cVar1;
  undefined8 uVar2;
  
  cVar1 = cRam00000001039120ec;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_10332fce3);
    cRam00000001039120ec = '\x01';
  }
  uVar2 = func_0x000100331820(uRam0000000103909418,0x10);
  DataMemoryBarrier(2,3);
  *puRam0000000103900160 = uVar2;
  return;
}

