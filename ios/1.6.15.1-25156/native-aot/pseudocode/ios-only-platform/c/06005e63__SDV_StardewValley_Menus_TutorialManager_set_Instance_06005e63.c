/* 0x06005e63 StardewValley.Menus.TutorialManager.set_Instance @ 0x101e1e168 */

void SDV_StardewValley_Menus_TutorialManager_set_Instance_06005e63(undefined8 param_1)

{
  char cVar1;
  
  cVar1 = cRam0000000103910c72;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033176b6);
    cRam0000000103910c72 = '\x01';
  }
  if (*(char *)(lRam0000000103900780 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  DataMemoryBarrier(2,3);
  *puRam00000001039007a0 = param_1;
  return;
}

