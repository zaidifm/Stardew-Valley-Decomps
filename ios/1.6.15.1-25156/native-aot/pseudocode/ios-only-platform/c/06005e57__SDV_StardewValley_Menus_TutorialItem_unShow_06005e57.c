/* 0x06005e57 StardewValley.Menus.TutorialItem.unShow @ 0x101e1d15c */

void SDV_StardewValley_Menus_TutorialItem_unShow_06005e57(long param_1)

{
  char cVar1;
  
  cVar1 = cRam0000000103910c66;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033175f8);
    cRam0000000103910c66 = '\x01';
    cVar1 = *(char *)(param_1 + 0xb2);
  }
  else {
    cVar1 = *(char *)(param_1 + 0xb2);
  }
  if (cVar1 != '\0') {
    *(undefined1 *)(param_1 + 0xb2) = 0;
    if (*(char *)(lRam0000000103900780 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    *puRam0000000103900788 = 0;
    *(undefined8 *)(param_1 + 0x90) = 0;
  }
  return;
}

