/* 0x060072cb StardewValley.Menus.CoopGameMenu+HostFileSlot.Activate @ 0x1020a6fd8 */

void SDV_StardewValley_Menus_CoopGameMenu_HostFileSlot_Activate_060072cb(undefined8 param_1)

{
  char cVar1;
  
  cVar1 = cRam00000001039120da;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_10332fc83);
    cRam00000001039120da = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  *puRam00000001038d57d0 = 2;
  StardewValley_StardewValley_Menus_LoadGameMenu_SaveFileSlot_Activate_060073b7(param_1);
  return;
}

