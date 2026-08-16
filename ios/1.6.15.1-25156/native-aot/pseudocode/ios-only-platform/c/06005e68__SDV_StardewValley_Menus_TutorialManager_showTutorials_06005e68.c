/* 0x06005e68 StardewValley.Menus.TutorialManager.showTutorials @ 0x101e1e4b8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialManager_showTutorials_06005e68(long param_1,byte param_2)

{
  char cVar1;
  code *pcVar2;
  
  cVar1 = cRam0000000103910c77;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103317717);
    cRam0000000103910c77 = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  if (param_1 == 0) {
    func_0x0001003316f4(0xee,_UNK_1036a2a78);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x101e1e564);
    (*pcVar2)();
  }
  *(byte *)(param_1 + 0xac) = *pcRam00000001038d5800 == '\0' & param_2;
  return;
}

