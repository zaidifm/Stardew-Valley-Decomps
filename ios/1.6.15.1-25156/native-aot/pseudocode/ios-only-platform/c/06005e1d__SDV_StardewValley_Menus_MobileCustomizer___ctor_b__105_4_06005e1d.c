/* 0x06005e1d StardewValley.Menus.MobileCustomizer.<.ctor>b__105_4 @ 0x101e1484c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer___ctor_b__105_4_06005e1d(long param_1)

{
  char cVar1;
  code *pcVar2;
  undefined4 uVar3;
  long lVar4;
  undefined8 uVar5;
  
  cVar1 = cRam0000000103910c2c;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033171a4);
    cRam0000000103910c2c = '\x01';
  }
  lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  if ((*(long *)(*(long *)(lVar4 + 0x400) + 0x60) != 0) &&
     (lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a(),
     *(char *)(*(long *)(*(long *)(*(long *)(lVar4 + 0x400) + 0x60) + 0xc0) + 0x68) != '\0')) {
    lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    lVar4 = *(long *)(*(long *)(lVar4 + 0x400) + 0x60);
    uVar5 = _UNK_1036a1690;
    if ((lVar4 != 0) && (uVar5 = _UNK_1036a16a0, *(long *)(param_1 + 0x70) != 0)) {
      lVar4 = *(long *)(lVar4 + 200);
      uVar3 = SDV_StardewValley_Menus_MobileColorPicker_getSelectedColor_06005dee();
      uVar5 = _UNK_1036a16a8;
      if (lVar4 != 0) {
        func_0x0001003503d8(lVar4,uVar3);
        lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        lVar4 = *(long *)(*(long *)(lVar4 + 0x348) + 0x60);
        uVar5 = _UNK_1036a16c0;
        if (lVar4 != 0) {
          *(undefined2 *)(lVar4 + 0x61) = 0x101;
          *(undefined1 *)(lVar4 + 0x67) = 1;
          *(undefined1 *)(lVar4 + 99) = 1;
          *(undefined2 *)(lVar4 + 0x65) = 0x101;
          lVar4 = *(long *)(*(long *)(*(long *)(param_1 + 0x1a8) + 0x348) + 0x60);
          *(undefined2 *)(lVar4 + 0x61) = 0x101;
          *(undefined1 *)(lVar4 + 0x67) = 1;
          *(undefined1 *)(lVar4 + 99) = 1;
          *(undefined2 *)(lVar4 + 0x65) = 0x101;
          return;
        }
      }
    }
    func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x101e14a2c);
    (*pcVar2)();
  }
  return;
}

