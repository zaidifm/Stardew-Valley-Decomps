/* 0x06005e1c StardewValley.Menus.MobileCustomizer.<.ctor>b__105_3 @ 0x101e147c4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer___ctor_b__105_3_06005e1c(long param_1)

{
  code *pcVar1;
  undefined4 uVar2;
  long lVar3;
  undefined8 uVar4;
  
  if (lRam0000000103976fb8 == 0) {
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  }
  else {
    func_0x00010119b8f8();
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  }
  uVar4 = _UNK_1036a1638;
  if (((param_1 != 0) && (uVar4 = _UNK_1036a1640, *(long *)(param_1 + 0x70) != 0)) &&
     (uVar2 = SDV_StardewValley_Menus_MobileColorPicker_getSelectedColor_06005dee(),
     uVar4 = _UNK_1036a1648, lVar3 != 0)) {
    StardewValley_StardewValley_Farmer_changeHairColor_0600365f(lVar3,uVar2);
    return;
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1484c);
  (*pcVar1)();
}

