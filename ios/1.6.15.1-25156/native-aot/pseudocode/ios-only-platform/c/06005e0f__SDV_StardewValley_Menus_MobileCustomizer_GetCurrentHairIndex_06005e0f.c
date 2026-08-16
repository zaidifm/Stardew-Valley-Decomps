/* 0x06005e0f StardewValley.Menus.MobileCustomizer.GetCurrentHairIndex @ 0x101e0f384 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer_GetCurrentHairIndex_06005e0f(void)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  long lVar4;
  undefined8 uVar5;
  
  cVar1 = cRam0000000103910c1e;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103316fff);
    cRam0000000103910c1e = '\x01';
  }
  lVar3 = StardewValley_StardewValley_Farmer_GetAllHairstyleIndices_06003659();
  lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar5 = _UNK_1036a0628;
  if ((*(long *)(lVar4 + 0x378) != 0) && (uVar5 = _UNK_1036a0630, lVar3 != 0)) {
    func_0x000100377bf4(lVar3,*(undefined4 *)(*(long *)(lVar4 + 0x378) + 0x68));
    return;
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e0f42c);
  (*pcVar2)();
}

