/* 0x06005e0e StardewValley.Menus.MobileCustomizer.GetCurrentPantIndex @ 0x101e0f2cc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer_GetCurrentPantIndex_06005e0e(undefined8 param_1)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  long lVar4;
  undefined8 uVar5;
  
  cVar1 = cRam0000000103910c1d;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103316ff8);
    cRam0000000103910c1d = '\x01';
  }
  lVar3 = SDV_StardewValley_Menus_MobileCustomizer_GetValidPantsIds_06005e17(param_1);
  lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar5 = _UNK_1036a0610;
  if ((*(long *)(lVar4 + 0x3a0) != 0) && (uVar5 = _UNK_1036a0618, lVar3 != 0)) {
    func_0x00010035c55c(lVar3,*(undefined8 *)(*(long *)(lVar4 + 0x3a0) + 0x60));
    return;
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e0f384);
  (*pcVar2)();
}

