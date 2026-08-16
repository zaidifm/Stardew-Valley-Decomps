/* 0x06005e0d StardewValley.Menus.MobileCustomizer.GetCurrentShirtIndex @ 0x101e0f214 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer_GetCurrentShirtIndex_06005e0d(undefined8 param_1)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  long lVar4;
  undefined8 uVar5;
  
  cVar1 = cRam0000000103910c1c;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103316ff1);
    cRam0000000103910c1c = '\x01';
  }
  lVar3 = SDV_StardewValley_Menus_MobileCustomizer_GetValidShirtIds_06005e18(param_1);
  lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar5 = _UNK_1036a05f8;
  if ((*(long *)(lVar4 + 0x370) != 0) && (uVar5 = _UNK_1036a0600, lVar3 != 0)) {
    func_0x00010035c55c(lVar3,*(undefined8 *)(*(long *)(lVar4 + 0x370) + 0x60));
    return;
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e0f2cc);
  (*pcVar2)();
}

