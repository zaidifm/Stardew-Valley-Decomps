/* 0x06005e10 StardewValley.Menus.MobileCustomizer.SetCurrentHairIndex @ 0x101e0f42c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer_SetCurrentHairIndex_06005e10
               (undefined8 param_1,uint param_2)

{
  char cVar1;
  code *pcVar2;
  int iVar3;
  long lVar4;
  long lVar5;
  undefined8 uVar6;
  
  cVar1 = cRam0000000103910c1f;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103317008);
    cRam0000000103910c1f = '\x01';
    lVar4 = StardewValley_StardewValley_Farmer_GetAllHairstyleIndices_06003659();
  }
  else {
    lVar4 = StardewValley_StardewValley_Farmer_GetAllHairstyleIndices_06003659();
  }
  uVar6 = _UNK_1036a0638;
  if (lVar4 != 0) {
    if ((int)param_2 < *(int *)(lVar4 + 0x18)) {
      if ((int)param_2 < 0) {
        iVar3 = func_0x000100377c08(lVar4);
        param_2 = iVar3 - 1;
      }
    }
    else {
      param_2 = 0;
    }
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    if (*(uint *)(lVar4 + 0x18) <= param_2) {
      func_0x000100331b90();
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101e0f508);
      (*pcVar2)();
    }
    if (*(uint *)(*(long *)(lVar4 + 0x10) + 0x18) <= param_2) {
      func_0x0001003316f4(0xcc,_UNK_1036a0650);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101e0f528);
      (*pcVar2)();
    }
    uVar6 = _UNK_1036a0648;
    if (lVar5 != 0) {
      StardewValley_StardewValley_Farmer_changeHairStyle_0600365b
                (lVar5,*(undefined4 *)(*(long *)(lVar4 + 0x10) + (long)(int)param_2 * 4 + 0x20));
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e0f53c);
  (*pcVar2)();
}

