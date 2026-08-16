/* 0x060066d4 StardewValley.Mobile.TapToMoveUtils.FetchItemInInventoryByName @ 0x101fc9280 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_TapToMoveUtils_FetchItemInInventoryByName_060066d4(undefined8 param_1)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  long *plVar4;
  undefined8 uVar5;
  int iVar6;
  
  if (lRam0000000103976fb8 == 0) {
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar5 = _UNK_1036d7608;
  }
  else {
    func_0x00010119b8f8();
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar5 = _UNK_1036d7608;
  }
  _UNK_1036d7608 = uVar5;
  if (lVar3 != 0) {
    iVar6 = 0;
    do {
      if (*(int *)(*(long *)(*(long *)(*(long *)(*(long *)(lVar3 + 0x1c0) + 0x60) + 0x10) + 0x50) +
                  0x68) <= iVar6) {
        return 0;
      }
      lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      lVar3 = *(long *)(*(long *)(lVar3 + 0x1c0) + 0x60);
      uVar5 = _UNK_1036d7638;
      if (lVar3 == 0) break;
      lVar3 = func_0x000101d32f2c(lVar3,iVar6);
      if (lVar3 != 0) {
        lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        lVar3 = *(long *)(*(long *)(lVar3 + 0x1c0) + 0x60);
        uVar5 = _UNK_1036d7650;
        if (lVar3 == 0) break;
        plVar4 = (long *)func_0x000101d32f2c(lVar3,iVar6);
        lVar3 = (**(code **)(*plVar4 + 0x1e8))();
        uVar5 = _UNK_1036d7660;
        if (lVar3 == 0) break;
        cVar2 = func_0x000100350144(lVar3,param_1);
        if (cVar2 != '\0') {
          lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          lVar3 = *(long *)(*(long *)(lVar3 + 0x1c0) + 0x60);
          uVar5 = _UNK_1036d7678;
          if (lVar3 != 0) {
            uVar5 = func_0x000101d32f2c(lVar3,iVar6);
            return uVar5;
          }
          break;
        }
      }
      lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      iVar6 = iVar6 + 1;
      uVar5 = _UNK_1036d7608;
    } while (lVar3 != 0);
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc9424);
  (*pcVar1)();
}

