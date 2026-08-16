/* 0x060072c7 StardewValley.Menus.CoopGameMenu+InviteCodeSlot.Activate @ 0x1020a6d74 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_InviteCodeSlot_Activate_060072c7(long param_1)

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
    SDV_StardewValley_Menus_CoopGameMenu_enterInviteCodePressed_06005dab();
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036edb18);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x1020a6dd4);
  (*pcVar1)();
}

