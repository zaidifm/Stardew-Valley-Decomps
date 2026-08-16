/* 0x060066d3 StardewValley.Mobile.TapToMoveUtils.getBestAvailableWeapon @ 0x101fc8f98 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long * SDV_StardewValley_Mobile_TapToMoveUtils_getBestAvailableWeapon_060066d3(void)

{
  code *pcVar1;
  char cVar2;
  int iVar3;
  int iVar4;
  long lVar5;
  undefined8 *puVar6;
  long *plVar7;
  undefined8 uVar8;
  int iVar9;
  long *plVar10;
  
  cVar2 = cRam00000001039114e2;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325820);
    cRam00000001039114e2 = '\x01';
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar8 = _UNK_1036d7560;
  }
  else {
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar8 = _UNK_1036d7560;
  }
  _UNK_1036d7560 = uVar8;
  if (lVar5 != 0) {
    plVar10 = (long *)0x0;
    iVar9 = 0;
    do {
      if (*(int *)(*(long *)(*(long *)(*(long *)(*(long *)(lVar5 + 0x1c0) + 0x60) + 0x10) + 0x50) +
                  0x68) <= iVar9) {
        return plVar10;
      }
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      lVar5 = *(long *)(*(long *)(lVar5 + 0x1c0) + 0x60);
      uVar8 = _UNK_1036d7590;
      if (lVar5 == 0) break;
      lVar5 = func_0x000101d32f2c(lVar5,iVar9);
      if (lVar5 != 0) {
        lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        lVar5 = *(long *)(*(long *)(lVar5 + 0x1c0) + 0x60);
        uVar8 = _UNK_1036d75a8;
        if (lVar5 == 0) break;
        puVar6 = (undefined8 *)func_0x000101d32f2c(lVar5,iVar9);
        if ((puVar6 != (undefined8 *)0x0) &&
           (lRam00000001038c7a50 == *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18))) {
          lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          if (plVar10 == (long *)0x0) {
            lVar5 = *(long *)(*(long *)(lVar5 + 0x1c0) + 0x60);
            uVar8 = _UNK_1036d75f8;
          }
          else {
            lVar5 = *(long *)(*(long *)(lVar5 + 0x1c0) + 0x60);
            uVar8 = _UNK_1036d75c0;
            if (((lVar5 == 0) ||
                (plVar7 = (long *)func_0x000101d32f2c(lVar5,iVar9), uVar8 = _UNK_1036d75c8,
                plVar7 == (long *)0x0)) ||
               (lRam00000001038c7a50 != *(long *)(*(long *)(*(long *)*plVar7 + 0x10) + 0x18)))
            break;
            iVar3 = (*(code *)((long *)*plVar7)[0x95])();
            iVar4 = (**(code **)(*plVar10 + 0x4a8))(plVar10);
            if (iVar3 <= iVar4) {
              uVar8 = (**(code **)(*plVar10 + 0x1e8))(plVar10);
              cVar2 = func_0x000100345aa0(uVar8,uRam00000001038f0c60);
              if (cVar2 == '\0') goto LAB_101fc911c;
            }
            lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
            lVar5 = *(long *)(*(long *)(lVar5 + 0x1c0) + 0x60);
            uVar8 = _UNK_1036d75e0;
          }
          if (lVar5 == 0) break;
          plVar10 = (long *)func_0x000101d32f2c(lVar5,iVar9);
          if ((plVar10 != (long *)0x0) &&
             (lRam00000001038c7a50 != *(long *)(*(long *)(*(long *)*plVar10 + 0x10) + 0x18))) {
            plVar10 = (long *)0x0;
          }
        }
      }
LAB_101fc911c:
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      iVar9 = iVar9 + 1;
      uVar8 = _UNK_1036d7560;
    } while (lVar5 != 0);
  }
  func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc9280);
  (*pcVar1)();
}

