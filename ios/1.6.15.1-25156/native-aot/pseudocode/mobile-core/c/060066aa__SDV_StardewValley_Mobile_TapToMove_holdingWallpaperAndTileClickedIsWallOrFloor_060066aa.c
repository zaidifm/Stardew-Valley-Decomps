/* 0x060066aa StardewValley.Mobile.TapToMove.holdingWallpaperAndTileClickedIsWallOrFloor @ 0x101fb979c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_TapToMove_holdingWallpaperAndTileClickedIsWallOrFloor_060066aa
          (long param_1)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  undefined8 *puVar4;
  undefined8 uVar5;
  
  cVar1 = cRam00000001039114b9;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033253e4);
    cRam00000001039114b9 = '\x01';
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  }
  else {
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  }
  uVar5 = _UNK_1036d4658;
  if (lVar3 != 0) {
    lVar3 = StardewValley_StardewValley_Farmer_get_CurrentItem_060035a2();
    if (lVar3 == 0) {
      return 0;
    }
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar5 = _UNK_1036d4660;
    if (lVar3 != 0) {
      puVar4 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentItem_060035a2();
      if (puVar4 == (undefined8 *)0x0) {
        return 0;
      }
      if (lRam00000001038c7518 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x18)) {
        return 0;
      }
      if (*(undefined8 **)(param_1 + 0x90) == (undefined8 *)0x0) {
        return 0;
      }
      if (lRam00000001038c6c08 !=
          *(long *)(*(long *)(*(long *)**(undefined8 **)(param_1 + 0x90) + 0x10) + 0x10)) {
        return 0;
      }
      lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar5 = _UNK_1036d4670;
      if (lVar3 != 0) {
        puVar4 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentItem_060035a2();
        if (((puVar4 != (undefined8 *)0x0) &&
            (uVar5 = _UNK_1036d4690,
            lRam00000001038c7518 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x18))) ||
           ((*(undefined8 **)(param_1 + 0x90) != (undefined8 *)0x0 &&
            (uVar5 = _UNK_1036d4688,
            lRam00000001038c6c08 !=
            *(long *)(*(long *)(*(long *)**(undefined8 **)(param_1 + 0x90) + 0x10) + 0x10))))) {
          func_0x0001003316f4(0xd3,uVar5);
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101fb9944);
          (*pcVar2)();
        }
        uVar5 = _UNK_1036d4678;
        if ((param_1 != -0x110) && (uVar5 = _UNK_1036d4680, puVar4 != (undefined8 *)0x0)) {
          uVar5 = func_0x000101b2a18c(*(undefined4 *)(param_1 + 0x110),
                                      *(undefined4 *)(param_1 + 0x114));
          return uVar5;
        }
      }
    }
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fb98f4);
  (*pcVar2)();
}

