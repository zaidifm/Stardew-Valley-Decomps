/* 0x06005e29 StardewValley.Menus.MobileFarmChooser.canLeaveMenu @ 0x101e1a770 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Menus_MobileFarmChooser_canLeaveMenu_06005e29(long param_1)

{
  code *pcVar1;
  long lVar2;
  undefined8 uVar3;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  lVar2 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  if (*(int *)(*(long *)(*(long *)(lVar2 + 0x2a0) + 0x60) + 0x10) < 1) {
    uVar3 = 0;
  }
  else {
    lVar2 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar3 = _UNK_1036a2528;
    if ((*(long *)(lVar2 + 0x2a0) == 0) || (uVar3 = _UNK_1036a2530, param_1 == 0)) {
      func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1a82c);
      (*pcVar1)();
    }
    uVar3 = func_0x00010035011c(*(undefined8 *)(*(long *)(lVar2 + 0x2a0) + 0x60),
                                *(undefined8 *)(param_1 + 0xb0));
  }
  return uVar3;
}

