/* 0x060066d9 StardewValley.Mobile.TapToMoveUtils.WarpIfInRange @ 0x101fc9a6c */

/* WARNING: Removing unreachable block (ram,0x000101fc9d9c) */
/* WARNING: Removing unreachable block (ram,0x000101fc9d7c) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1 SDV_StardewValley_Mobile_TapToMoveUtils_WarpIfInRange_060066d9(void)

{
  undefined4 uVar1;
  undefined4 uVar2;
  undefined4 uVar3;
  code *pcVar4;
  char cVar5;
  long lVar6;
  long lVar7;
  undefined8 *puVar8;
  undefined8 uVar9;
  int iVar10;
  long lVar11;
  float fVar12;
  undefined4 uVar13;
  float fVar14;
  float fVar15;
  float fVar16;
  undefined8 uStack_d0;
  undefined8 uStack_c8;
  long lStack_c0;
  undefined8 uStack_b8;
  undefined1 uStack_a1;
  undefined8 uStack_a0;
  undefined8 *puStack_98;
  
  cVar5 = cRam00000001039114e8;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar5 == '\0') {
    func_0x00010119b908(&UNK_103325850);
    cRam00000001039114e8 = '\x01';
  }
  uStack_a1 = 0;
  uStack_c8 = 0;
  uStack_d0 = 0;
  uStack_b8 = 0;
  lStack_c0 = 0;
  lVar6 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  if ((*(char *)(lVar6 + 0x2c4) != '\0') ||
     (lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a(),
     *(char *)(lVar6 + 0x76c) == '\0')) {
    return 0;
  }
  lVar6 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  uVar9 = _UNK_1036d7738;
  if (*(long *)(lVar6 + 0xd8) != 0) {
    func_0x000100355e78(&uStack_d0);
    while (cVar5 = func_0x000100355e8c(&uStack_d0), lVar6 = lStack_c0, cVar5 != '\0') {
      if ((lStack_c0 == 0) || (*(long *)(lStack_c0 + 0x38) == 0)) goto LAB_101fc9dc4;
      cVar5 = func_0x000100345aa0(*(undefined8 *)(*(long *)(lStack_c0 + 0x38) + 0x60),
                                  uRam00000001038e7db0);
      uVar9 = uRam0000000103904a98;
      if (cVar5 == '\0') {
        lVar11 = *(long *)(lVar6 + 0x10);
        lVar7 = lVar6;
      }
      else {
        if ((((*(long *)(lVar6 + 0x10) == 0) || (*(long *)(lVar6 + 0x18) == 0)) ||
            (*(long *)(lVar6 + 0x20) == 0)) || (*(long *)(lVar6 + 0x28) == 0)) goto LAB_101fc9dc4;
        uVar13 = *(undefined4 *)(*(long *)(lVar6 + 0x10) + 0x68);
        uVar1 = *(undefined4 *)(*(long *)(lVar6 + 0x18) + 0x68);
        uVar2 = *(undefined4 *)(*(long *)(lVar6 + 0x20) + 0x68);
        uVar3 = *(undefined4 *)(*(long *)(lVar6 + 0x28) + 0x68);
        lVar7 = func_0x000100331820(uRam00000001038ce0e0,0x50);
        func_0x000101a354ac(lVar7,uVar13,uVar1,uVar9,uVar2,uVar3,0,0);
        lVar11 = *(long *)(lVar7 + 0x10);
      }
      if ((lVar11 == 0) || (*(long *)(lVar7 + 0x18) == 0)) goto LAB_101fc9dc4;
      fVar16 = (float)(*(int *)(lVar11 + 0x68) << 6);
      fVar15 = (float)(*(int *)(*(long *)(lVar7 + 0x18) + 0x68) << 6);
      fVar14 = fVar15;
      func_0x00010035025c(fVar16,fVar15,0x4200000042000000,0x4200000042000000);
      fVar12 = (float)func_0x000100354758();
      lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      if ((lVar11 == 0) || (*(long *)(lVar11 + 0x20) == 0)) goto LAB_101fc9dc4;
      uVar13 = func_0x0001003436c4();
      fVar14 = (float)func_0x000100354758(fVar16,fVar15,uVar13,fVar14);
      if (*(long *)(lVar6 + 0x38) == 0) goto LAB_101fc9dc4;
      cVar5 = func_0x000100345aa0(*(undefined8 *)(*(long *)(lVar6 + 0x38) + 0x60),
                                  uRam00000001038c6d28);
      if (((cVar5 != '\0') &&
          (puVar8 = (undefined8 *)
                    SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb(),
          puVar8 != (undefined8 *)0x0)) &&
         (lRam00000001038c6d20 == *(long *)(*(long *)(*(long *)*puVar8 + 0x10) + 0x18))) {
        if (puVar8[0x6b] == 0) goto LAB_101fc9dc4;
        if ((*(char *)(puVar8[0x6b] + 0x68) == '\0') && (125.0 < fVar14)) {
          iVar10 = 2;
          uStack_a1 = 0;
          goto LAB_101fc9d50;
        }
      }
      puVar8 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
      if ((puVar8 == (undefined8 *)0x0) ||
         (lRam00000001038c6ba8 != *(long *)(*(long *)(*(long *)*puVar8 + 0x10) + 0x10))) {
LAB_101fc9d04:
        fVar15 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_get_WarpRange_060066da();
        if ((fVar12 < fVar15) &&
           (fVar12 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_get_WarpRange_060066da(),
           fVar14 < fVar12)) {
          lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          if (lVar6 == 0) {
LAB_101fc9dc4:
            func_0x0001003316f4(0xee,_UNK_1036d7748);
                    /* WARNING: Does not return */
            pcVar4 = (code *)SoftwareBreakpoint(1,0x101fc9dd8);
            (*pcVar4)();
          }
          func_0x000101856288(lVar6,lVar7,0xffffffff);
          iVar10 = 1;
          uStack_a1 = 1;
          goto LAB_101fc9d50;
        }
      }
      else {
        if (*(long *)(lVar6 + 0x38) == 0) goto LAB_101fc9dc4;
        cVar5 = func_0x000100345aa0(*(undefined8 *)(*(long *)(lVar6 + 0x38) + 0x60),
                                    uRam00000001038c6c10);
        if (cVar5 == '\0') goto LAB_101fc9d04;
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
    }
    iVar10 = 3;
LAB_101fc9d50:
    uStack_a0 = 0;
    puStack_98 = &uStack_d0;
    if (puStack_98 != (undefined8 *)0x0) {
      if ((iVar10 != 1) && (iVar10 != 2)) {
        if (iVar10 == 3) {
          return 0;
        }
        func_0x000100331c30();
                    /* WARNING: Does not return */
        pcVar4 = (code *)SoftwareBreakpoint(1,0x101fc9e50);
        (*pcVar4)();
      }
      return uStack_a1;
    }
    puStack_98 = (undefined8 *)0x0;
    uVar9 = _UNK_1036d7740;
  }
  func_0x0001003316f4(0xee,uVar9);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101fc9e48);
  (*pcVar4)();
}

