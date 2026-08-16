/* 0x06005e12 StardewValley.Menus.MobileCustomizer.canLeaveMenu @ 0x101e0fa30 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Menus_MobileCustomizer_canLeaveMenu_06005e12(long param_1)

{
  uint uVar1;
  code *pcVar2;
  char cVar3;
  undefined8 uVar4;
  long lVar5;
  
  if (lRam0000000103976fb8 == 0) {
    lVar5 = *(long *)(param_1 + 0xe8);
  }
  else {
    func_0x00010119b8f8();
    lVar5 = *(long *)(param_1 + 0xe8);
  }
  uVar1 = *(uint *)(param_1 + 0x1ec);
  if (lVar5 == 0) {
    if ((uVar1 < 7) && ((1 << (ulong)(uVar1 & 0x1f) & 100U) != 0)) {
      return 1;
    }
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    if ((0 < *(int *)(*(long *)(*(long *)(lVar5 + 0x58) + 0x60) + 0x10)) &&
       (lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a(),
       0 < *(int *)(*(long *)(*(long *)(lVar5 + 0x2a8) + 0x60) + 0x10))) {
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      cVar3 = func_0x00010035011c(*(undefined8 *)(*(long *)(lVar5 + 0x58) + 0x60),
                                  *(undefined8 *)(param_1 + 0x188));
      if (cVar3 != '\0') {
        lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        lVar5 = *(long *)(lVar5 + 0x2a8);
        uVar4 = _UNK_1036a07c8;
joined_r0x000101e0fb78:
        if (lVar5 != 0) {
          uVar4 = func_0x00010035011c(*(undefined8 *)(lVar5 + 0x60),*(undefined8 *)(param_1 + 400));
          return uVar4;
        }
        func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101e0fbbc);
        (*pcVar2)();
      }
    }
  }
  else {
    if ((uVar1 < 7) && ((1 << (ulong)(uVar1 & 0x1f) & 100U) != 0)) {
      return 1;
    }
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    if (((0 < *(int *)(*(long *)(*(long *)(lVar5 + 0x58) + 0x60) + 0x10)) &&
        (lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a(),
        0 < *(int *)(*(long *)(*(long *)(lVar5 + 0x2a0) + 0x60) + 0x10))) &&
       (lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a(),
       0 < *(int *)(*(long *)(*(long *)(lVar5 + 0x2a8) + 0x60) + 0x10))) {
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      cVar3 = func_0x00010035011c(*(undefined8 *)(*(long *)(lVar5 + 0x58) + 0x60),
                                  *(undefined8 *)(param_1 + 0x188));
      if (cVar3 != '\0') {
        lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        cVar3 = func_0x00010035011c(*(undefined8 *)(*(long *)(lVar5 + 0x2a0) + 0x60),
                                    *(undefined8 *)(param_1 + 0x198));
        if (cVar3 != '\0') {
          lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          lVar5 = *(long *)(lVar5 + 0x2a8);
          uVar4 = _UNK_1036a0838;
          goto joined_r0x000101e0fb78;
        }
      }
    }
  }
  return 0;
}

