/* 0x060072c5 StardewValley.Menus.CoopGameMenu+LanSlot.Activate @ 0x1020a6c54 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_LanSlot_Activate_060072c5(long param_1)

{
  code *pcVar1;
  long lVar2;
  
  if (lRam0000000103976fb8 == 0) {
    lVar2 = *(long *)(param_1 + 0x28);
  }
  else {
    func_0x00010119b8f8();
    lVar2 = *(long *)(param_1 + 0x28);
  }
  if (lVar2 != 0) {
    SDV_StardewValley_Menus_CoopGameMenu_enterIPPressed_06005daa();
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036edb00);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x1020a6cb4);
  (*pcVar1)();
}

