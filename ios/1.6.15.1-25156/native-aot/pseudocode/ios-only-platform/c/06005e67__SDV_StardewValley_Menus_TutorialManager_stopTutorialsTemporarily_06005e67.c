/* 0x06005e67 StardewValley.Menus.TutorialManager.stopTutorialsTemporarily @ 0x101e1e404 */

void SDV_StardewValley_Menus_TutorialManager_stopTutorialsTemporarily_06005e67(long param_1)

{
  char cVar1;
  long lVar2;
  
  cVar1 = cRam0000000103910c76;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103317707);
    cRam0000000103910c76 = '\x01';
    lVar2 = *(long *)(param_1 + 0x90);
  }
  else {
    lVar2 = *(long *)(param_1 + 0x90);
  }
  if ((lVar2 != 0) && (*(char *)(lVar2 + 0xb2) != '\0')) {
    *(undefined1 *)(lVar2 + 0xb2) = 0;
    if (*(char *)(lRam0000000103900780 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    *puRam0000000103900788 = 0;
    *(undefined8 *)(lVar2 + 0x90) = 0;
  }
  *(undefined8 *)(param_1 + 0x90) = 0;
  return;
}

