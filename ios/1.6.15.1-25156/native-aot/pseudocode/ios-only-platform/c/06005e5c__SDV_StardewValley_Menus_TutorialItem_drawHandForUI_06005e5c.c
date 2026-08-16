/* 0x06005e5c StardewValley.Menus.TutorialItem.drawHandForUI @ 0x101e1daf0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialItem_drawHandForUI_06005e5c(long param_1,long param_2)

{
  code *pcVar1;
  char cVar2;
  undefined8 extraout_x1;
  undefined8 extraout_x1_00;
  undefined8 uVar3;
  undefined8 uVar4;
  undefined8 uStack_80;
  undefined8 uStack_78;
  undefined8 uStack_70;
  undefined8 uStack_68;
  undefined8 uStack_60;
  undefined8 uStack_58;
  undefined8 uStack_50;
  undefined8 uStack_48;
  undefined4 uStack_40;
  
  cVar2 = cRam0000000103910c6b;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103317671);
    cRam0000000103910c6b = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  if ((((*pcRam00000001038d53e0 == '\0') && (*(long *)(param_1 + 0x78) != 0)) &&
      (*(long *)(param_1 + 0xa0) == 0)) &&
     (((*(uint *)(param_1 + 200) | 2) != 3 &&
      (cVar2 = StardewValley_StardewValley_Game1_get_globalFade_06002fbb(), cVar2 == '\0')))) {
    uVar3 = _UNK_1036a2a00;
    if (param_2 != 0) {
      func_0x00010033199c(param_2);
      uVar3 = extraout_x1;
      if (*(char *)(lRam00000001038d53e8 + 0x35) == '\0') {
        func_0x0001003319b0();
        uVar3 = extraout_x1_00;
      }
      uVar4 = *puRam00000001038d53f0;
      if (*(char *)(lRam00000001038d53f8 + 0x35) == '\0') {
        func_0x0001003319b0(lRam00000001038d53f8,uVar3,uVar4);
      }
      uStack_78 = 0;
      uStack_80 = 0;
      uStack_68 = 0;
      uStack_70 = 0;
      uStack_58 = 0;
      uStack_60 = 0;
      uStack_48 = 0;
      uStack_50 = 0;
      uStack_40 = 0;
      func_0x00010033194c(param_2,0,uVar4,*puRam00000001038d5400,0,0,0,&uStack_80);
      uVar3 = _UNK_1036a2a08;
      if (*(long *)(param_1 + 0x78) != 0) {
        SDV_StardewValley_Menus_HandPointer_draw_06005dda(*(long *)(param_1 + 0x78),param_2);
        return;
      }
    }
    func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1dc5c);
    (*pcVar1)();
  }
  return;
}

