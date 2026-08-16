/* 0x06005e5d StardewValley.Menus.TutorialItem.drawButtonHands @ 0x101e1dc74 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialItem_drawButtonHands_06005e5d(long param_1,undefined8 param_2)

{
  code *pcVar1;
  char cVar2;
  
  cVar2 = cRam0000000103910c6c;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103317681);
    cRam0000000103910c6c = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  if ((((*pcRam00000001038d53e0 == '\0') && (*(long *)(param_1 + 0x78) != 0)) &&
      (*(long *)(param_1 + 0xa0) != 0)) &&
     (((*(uint *)(param_1 + 200) | 2) != 3 &&
      (cVar2 = StardewValley_StardewValley_Game1_get_globalFade_06002fbb(), cVar2 == '\0')))) {
    if (*(long *)(param_1 + 0x78) == 0) {
      func_0x0001003316f4(0xee,_UNK_1036a2a18);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1dd50);
      (*pcVar1)();
    }
    SDV_StardewValley_Menus_HandPointer_draw_06005dda(*(long *)(param_1 + 0x78),param_2);
  }
  return;
}

