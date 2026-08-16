/* 0x06005e08 StardewValley.Menus.MobileCustomizer.petHasChanges @ 0x101e0dc88 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Menus_MobileCustomizer_petHasChanges_06005e08
               (undefined8 param_1,long param_2)

{
  code *pcVar1;
  bool bVar2;
  char cVar3;
  long lVar4;
  undefined8 uVar5;
  
  if (lRam0000000103976fb8 == 0) {
    lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  }
  else {
    func_0x00010119b8f8();
    lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  }
  uVar5 = _UNK_1036a0180;
  if (lVar4 != 0) {
    cVar3 = StardewValley_StardewValley_Farmer_get_catPerson_06003552();
    if ((cVar3 == '\0') || (param_2 != 0)) {
      lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar5 = _UNK_1036a0188;
      if ((lVar4 == 0) || (uVar5 = _UNK_1036a0198, *(long *)(param_2 + 0x438) == 0))
      goto LAB_101e0dd2c;
      cVar3 = func_0x00010035011c(*(undefined8 *)(lVar4 + 0x328),
                                  *(undefined8 *)(*(long *)(param_2 + 0x438) + 0x60));
      bVar2 = cVar3 != '\0';
    }
    else {
      bVar2 = true;
    }
    return bVar2;
  }
LAB_101e0dd2c:
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e0dd38);
  (*pcVar1)();
}

