/* 0x06005e20 StardewValley.Menus.MobileFarmChooser.getNameOfDifficulty @ 0x101e16d6c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Menus_MobileFarmChooser_getNameOfDifficulty_06005e20(long param_1)

{
  code *pcVar1;
  long lVar2;
  undefined8 uVar3;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  lVar2 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  if (*(float *)(lVar2 + 0x748) < 0.5) {
    uVar3 = _UNK_1036a1ab8;
    if (param_1 == 0) goto LAB_101e16e58;
    lVar2 = 0x1c;
  }
  else {
    lVar2 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    if (*(float *)(lVar2 + 0x748) < 0.75) {
      uVar3 = _UNK_1036a1ab0;
      if (param_1 == 0) goto LAB_101e16e58;
      lVar2 = 0x1b;
    }
    else {
      lVar2 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      if (*(float *)(lVar2 + 0x748) < 1.0) {
        uVar3 = _UNK_1036a1aa8;
        if (param_1 == 0) goto LAB_101e16e58;
        lVar2 = 0x1a;
      }
      else {
        uVar3 = _UNK_1036a1ac0;
        if (param_1 == 0) {
LAB_101e16e58:
          func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
          pcVar1 = (code *)SoftwareBreakpoint(1,0x101e16e64);
          (*pcVar1)();
        }
        lVar2 = 0x19;
      }
    }
  }
  return *(undefined8 *)(param_1 + lVar2 * 8);
}

