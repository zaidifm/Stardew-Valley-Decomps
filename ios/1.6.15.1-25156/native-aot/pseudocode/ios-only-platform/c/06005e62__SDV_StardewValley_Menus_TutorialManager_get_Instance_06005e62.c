/* 0x06005e62 StardewValley.Menus.TutorialManager.get_Instance @ 0x101e1e0f4 */

undefined8 SDV_StardewValley_Menus_TutorialManager_get_Instance_06005e62(void)

{
  char cVar1;
  
  cVar1 = cRam0000000103910c71;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033176a6);
    cRam0000000103910c71 = '\x01';
  }
  if (*(char *)(lRam0000000103900780 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  return *puRam00000001039007a0;
}

