/* 0x06005e64 StardewValley.Menus.TutorialManager..cctor @ 0x101e1e1ec */

void SDV_StardewValley_Menus_TutorialManager__cctor_06005e64(void)

{
  char cVar1;
  undefined8 uVar2;
  
  cVar1 = cRam0000000103910c73;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033176d0);
    cRam0000000103910c73 = '\x01';
  }
  uVar2 = func_0x000100331820(uRam0000000103900780,0xd0);
  SDV_StardewValley_Menus_TutorialManager__ctor_06005e65();
  DataMemoryBarrier(2,3);
  *puRam00000001039007a0 = uVar2;
  *puRam0000000103900788 = 0;
  return;
}

