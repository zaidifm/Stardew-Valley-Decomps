/* 0x06005e5a StardewValley.Menus.TutorialItem.draw @ 0x101e1d69c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialItem_draw_06005e5a(long param_1,undefined8 param_2)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  long *plVar4;
  undefined8 uVar5;
  
  cVar2 = cRam0000000103910c69;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103317639);
    cRam0000000103910c69 = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  if (((*pcRam00000001038d53e0 == '\0') && (*(long *)(param_1 + 0x78) != 0)) &&
     ((*(uint *)(param_1 + 200) | 2) == 3)) {
    lVar3 = SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1();
    if (lVar3 != 0) {
      plVar4 = (long *)SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1();
      uVar5 = _UNK_1036a2968;
      if (*(long *)(*plVar4 + 0x18) == 0) goto LAB_101e1d7a4;
      cVar2 = func_0x000100367628(*(long *)(*plVar4 + 0x18),*(undefined8 *)(param_1 + 0x98));
      if (cVar2 == '\0') {
        return;
      }
    }
    uVar5 = _UNK_1036a2958;
    if (*(long *)(param_1 + 0x78) == 0) {
LAB_101e1d7a4:
      func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1d7b0);
      (*pcVar1)();
    }
    SDV_StardewValley_Menus_HandPointer_draw_06005dda(*(long *)(param_1 + 0x78),param_2);
  }
  return;
}

