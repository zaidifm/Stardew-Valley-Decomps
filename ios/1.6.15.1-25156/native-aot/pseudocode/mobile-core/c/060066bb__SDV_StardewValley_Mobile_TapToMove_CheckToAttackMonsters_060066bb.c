/* 0x060066bb StardewValley.Mobile.TapToMove.CheckToAttackMonsters @ 0x101fc4274 */

/* WARNING: Removing unreachable block (ram,0x000101fc4cdc) */
/* WARNING: Removing unreachable block (ram,0x000101fc4cb4) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1 SDV_StardewValley_Mobile_TapToMove_CheckToAttackMonsters_060066bb(long param_1)

{
  undefined4 uVar1;
  code *pcVar2;
  char cVar3;
  int iVar4;
  int iVar5;
  undefined4 uVar6;
  long lVar7;
  ulong uVar8;
  long *plVar9;
  int extraout_var;
  long *plVar10;
  int extraout_var_00;
  long lVar11;
  undefined8 uVar12;
  int extraout_var_01;
  int extraout_var_02;
  float fVar13;
  float fVar14;
  undefined1 auVar15 [16];
  undefined1 auStack_170 [16];
  undefined8 uStack_158;
  undefined8 uStack_150;
  long *plStack_148;
  undefined1 auStack_140 [16];
  long *plStack_128;
  undefined8 uStack_120;
  undefined8 uStack_118;
  undefined8 uStack_110;
  undefined8 *puStack_108;
  undefined8 uStack_100;
  undefined8 *puStack_f8;
  float fStack_f0;
  float fStack_ec;
  undefined8 *puStack_e8;
  float fStack_e0;
  float fStack_dc;
  long lStack_d8;
  float fStack_cc;
  long lStack_c8;
  float fStack_bc;
  long lStack_b8;
  undefined4 uStack_ac;
  undefined8 *puStack_a8;
  undefined8 *puStack_a0;
  undefined8 *puStack_98;
  undefined8 *puStack_90;
  undefined8 *puStack_88;
  
  cVar3 = cRam00000001039114ca;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_1033256b0);
    cRam00000001039114ca = '\x01';
  }
  auStack_170._0_8_ = 0;
  auStack_170._8_8_ = 0;
  uStack_150 = 0;
  plStack_148 = (long *)0x0;
  uStack_158 = 0;
  auStack_140._0_8_ = 0;
  auStack_140._8_8_ = 0;
  plStack_128 = (long *)0x0;
  uStack_120 = 0;
  uStack_118 = 0;
  lVar7 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if ((*(int *)(lVar7 + 0x178) != 0) &&
     (lVar7 = StardewValley_StardewValley_Game1_get_options_06002fec(), *(int *)(lVar7 + 0x178) != 7
     )) {
    return 0;
  }
  if (*(char *)(param_1 + 0xfa) == '\0') {
    uVar8 = func_0x000100332090();
    if ((long)((uVar8 & 0x3fffffffffffffff) - *(long *)(param_1 + 0x140)) < 5000000) {
      return 0;
    }
    uVar12 = _UNK_1036d6c90;
    if (param_1 == 0) goto LAB_101fc4750;
    *(undefined1 *)(param_1 + 0xfa) = 1;
  }
  if (*(char *)(param_1 + 0xf7) != '\0') {
    *(undefined1 *)(param_1 + 0xf7) = 0;
    lVar7 = *(long *)(param_1 + 0x18);
    *(undefined1 *)(lVar7 + 0x18) = 0;
    uVar6 = *(undefined4 *)(lVar7 + 0x21);
    *(undefined4 *)(lVar7 + 0x19) = 0;
    *(undefined4 *)(lVar7 + 0x21) = 0;
    *(undefined4 *)(lVar7 + 0x1d) = uVar6;
    *(undefined4 *)(lVar7 + 0x14) = 0x10000;
    return 0;
  }
  if (*(int *)(param_1 + 0x124) == 1) {
    return 0;
  }
  if (*(int *)(param_1 + 0x124) == 2) {
    return 0;
  }
  lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  if (*(char *)(lVar7 + 0x76f) != '\0') {
    return 0;
  }
  lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  if (*(char *)(*(long *)(lVar7 + 0x530) + 0x68) != '\0') {
    return 0;
  }
  lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar12 = _UNK_1036d6b08;
  if (lVar7 == 0) goto LAB_101fc4750;
  lVar7 = StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
  if (lVar7 == 0) {
    lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar12 = _UNK_1036d6c68;
    if (lVar7 == 0) goto LAB_101fc4750;
    lVar7 = StardewValley_StardewValley_Farmer_get_CurrentItem_060035a2();
    if (lVar7 != 0) {
      return 0;
    }
  }
  *(undefined8 *)(param_1 + 0x70) = 0;
  plVar9 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
  auStack_170 = (**(code **)(*plVar9 + 0x110))();
  func_0x00010035741c(auStack_170,0x40,0x40);
  lVar7 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
  uVar12 = _UNK_1036d6b28;
  if (*(long *)(lVar7 + 0xa0) == 0) goto LAB_101fc4750;
  func_0x0001003432b4(&uStack_158);
  lVar7 = lRam00000001038c4be0;
  fVar14 = 3.4028235e+38;
  while( true ) {
    cVar3 = func_0x000100353470(&uStack_158);
    plVar9 = plStack_148;
    if (cVar3 == '\0') break;
    if ((plStack_148 == (long *)0x0) ||
       (lRam00000001038c7018 != *(long *)(*(long *)(*(long *)*plStack_148 + 0x10) + 0x18)))
    goto LAB_101fc444c;
    auVar15 = (*(code *)((long *)*plStack_148)[0x22])(plStack_148);
    auStack_140 = auVar15;
    iVar4 = func_0x00010035034c(auStack_140);
    auVar15 = (**(code **)(*plVar9 + 0x110))(plVar9);
    auStack_140 = auVar15;
    func_0x00010035034c(auStack_140);
    plVar10 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
    if (plVar10 == (long *)0x0) goto LAB_101fc4628;
    auVar15 = (**(code **)(*plVar10 + 0x110))();
    auStack_140 = auVar15;
    iVar5 = func_0x00010035034c(auStack_140);
    plVar10 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
    if (plVar10 == (long *)0x0) goto LAB_101fc4628;
    auVar15 = (**(code **)(*plVar10 + 0x110))();
    auStack_140 = auVar15;
    func_0x00010035034c(auStack_140);
    fVar13 = (float)func_0x000100354758((float)iVar4,(float)extraout_var,(float)iVar5,
                                        (float)extraout_var_00);
    if (fVar13 < fVar14) {
      auVar15 = (**(code **)(*plVar9 + 0x110))(plVar9);
      cVar3 = func_0x00010035a4b4(auStack_170,auVar15._0_8_,auVar15._8_8_);
      if (cVar3 == '\0') goto LAB_101fc444c;
      lVar11 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
      uVar12 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      if (lVar11 == 0) goto LAB_101fc4628;
      cVar3 = StardewValley_StardewValley_GameLocation_isMonsterDamageApplicable_06003a12
                        (lVar11,uVar12,plVar9,0);
      if (cVar3 == '\0') {
        lVar11 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
        uVar12 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        if (lVar11 == 0) goto LAB_101fc4628;
        cVar3 = StardewValley_StardewValley_GameLocation_isMonsterDamageApplicable_06003a12
                          (lVar11,uVar12,plVar9,1);
        if (cVar3 == '\0') goto LAB_101fc444c;
      }
      cVar3 = SDV_StardewValley_Mobile_TapToMove_IsObjectBlockingMonster_060066bc(param_1,plVar9);
      if (cVar3 != '\0') goto LAB_101fc444c;
      if (param_1 == 0) {
LAB_101fc4628:
        func_0x0001003316f4(0xee,_UNK_1036d6c58);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101fc463c);
        (*pcVar2)();
      }
      DataMemoryBarrier(2,3);
      *(undefined8 *)(param_1 + 0x70) = plVar9;
      *(undefined1 *)(((ulong)(param_1 + 0x70) >> 9 & 0x7fffff) + lVar7) = 1;
      fVar14 = fVar13;
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
    }
    else {
LAB_101fc444c:
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
    }
  }
  uStack_110 = 0;
  puStack_108 = &uStack_158;
  uVar12 = _UNK_1036d6c50;
  if (puStack_108 == (undefined8 *)0x0) goto LAB_101fc4750;
  uStack_110 = 0;
  if (*(long *)(param_1 + 0x70) == 0) {
    return 0;
  }
  lVar7 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if (*(int *)(lVar7 + 0x178) != 7) {
    auVar15 = (**(code **)(**(long **)(param_1 + 0x70) + 0x110))();
    auStack_140 = auVar15;
    iVar4 = func_0x00010035034c(auStack_140);
    auVar15 = (**(code **)(**(long **)(param_1 + 0x70) + 0x110))(*(long **)(param_1 + 0x70));
    auStack_140 = auVar15;
    func_0x00010035034c(auStack_140);
    puStack_f8 = &uStack_100;
    uStack_100 = 0;
    fStack_ec = (float)extraout_var_01;
                    /* WARNING: Ignoring partial resolution of indirect */
    uStack_100._0_4_ = (float)iVar4;
                    /* WARNING: Ignoring partial resolution of indirect */
    uStack_100._4_4_ = fStack_ec;
    uVar6 = (float)uStack_100;
    uVar1 = uStack_100._4_4_;
    fStack_f0 = (float)iVar4;
    plVar9 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
    auVar15 = (**(code **)(*plVar9 + 0x110))();
    auStack_140 = auVar15;
    iVar4 = func_0x00010035034c(auStack_140);
    plVar9 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
    auVar15 = (**(code **)(*plVar9 + 0x110))();
    auStack_140 = auVar15;
    func_0x00010035034c(auStack_140);
    puStack_e8 = &uStack_120;
    fStack_dc = (float)extraout_var_02;
                    /* WARNING: Ignoring partial resolution of indirect */
    uStack_120._0_4_ = (float)iVar4;
                    /* WARNING: Ignoring partial resolution of indirect */
    uStack_120._4_4_ = fStack_dc;
    fStack_e0 = (float)iVar4;
    SDV_StardewValley_Mobile_TapToMoveUtils_GetWalkDirectionFacing_06006710
              (uVar6,uVar1,(float)uStack_120,uStack_120._4_4_);
    uVar6 = SDV_StardewValley_Mobile_TapToMoveUtils_GetDirectionFacing_06006711
                      (uVar6,uVar1,(float)uStack_120,uStack_120._4_4_);
    uStack_118 = CONCAT44(uStack_118._4_4_,uVar6);
    plVar9 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
    iVar4 = (**(code **)(*plVar9 + 0x1f0))();
    if (iVar4 != (int)uStack_118) {
      plVar9 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
      (**(code **)(*plVar9 + 0x178))(plVar9,uStack_118 & 0xffffffff);
    }
  }
  plStack_128 = (long *)SDV_StardewValley_Mobile_TapToMove_chooseActiveWeapon_060066b3();
  puStack_a8 = *(undefined8 **)(param_1 + 0x70);
  puStack_90 = puStack_a8;
  if ((puStack_a8 != (undefined8 *)0x0) &&
     (lRam00000001038c7038 != *(long *)(*(long *)(*(long *)*puStack_a8 + 0x10) + 0x20))) {
    puStack_90 = (undefined8 *)0x0;
  }
  if (puStack_90 == (undefined8 *)0x0) {
LAB_101fc4994:
    plVar9 = plStack_128;
    if (plStack_128 != (long *)0x0) {
      lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar12 = _UNK_1036d6b98;
      if (lVar7 == 0) goto LAB_101fc4750;
      plVar10 = (long *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
      if (plVar9 != plVar10) {
        lStack_d8 = *(long *)(param_1 + 200);
        uVar12 = _UNK_1036d6ba8;
        if (((lStack_d8 == 0) || (uVar12 = _UNK_1036d6bb0, lStack_d8 == 0)) ||
           (uVar12 = _UNK_1036d6bb8, lStack_d8 == 0)) goto LAB_101fc4750;
        *(int *)(lStack_d8 + 0x1c) = *(int *)(lStack_d8 + 0x1c) + 1;
        *(undefined4 *)(lStack_d8 + 0x18) = 0;
        uVar12 = (**(code **)(*plStack_128 + 0x1e8))();
        goto LAB_101fc4a08;
      }
    }
  }
  else {
    puStack_a0 = *(undefined8 **)(param_1 + 0x70);
    if ((puStack_a0 != (undefined8 *)0x0) &&
       (lRam00000001038c7038 != *(long *)(*(long *)(*(long *)*puStack_a0 + 0x10) + 0x20))) {
      func_0x0001003316f4(0xd3,_UNK_1036d6be8);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101fc4c34);
      (*pcVar2)();
    }
    uVar12 = _UNK_1036d6bd8;
    if (puStack_a0 == (undefined8 *)0x0) goto LAB_101fc4750;
    cVar3 = StardewValley_StardewValley_Monsters_RockCrab_get_isHidingInShell_06004ef7();
    if (cVar3 == '\0') goto LAB_101fc4994;
    lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar12 = _UNK_1036d6be0;
    if (lVar7 == 0) goto LAB_101fc4750;
    puStack_98 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
    puStack_88 = puStack_98;
    if ((puStack_98 != (undefined8 *)0x0) &&
       (lRam00000001038c7a80 != *(long *)(*(long *)(*(long *)*puStack_98 + 0x10) + 0x18))) {
      puStack_88 = (undefined8 *)0x0;
    }
    uVar12 = uRam00000001038c7a78;
    if (puStack_88 != (undefined8 *)0x0) goto LAB_101fc4994;
LAB_101fc4a08:
    SDV_StardewValley_Mobile_TapToMoveUtils_SelectTool_060066d1(uVar12);
  }
  lStack_c8 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar12 = _UNK_1036d6b40;
  if ((lStack_c8 != 0) &&
     (lStack_b8 = *(long *)(lStack_c8 + 0x4e0), uVar12 = _UNK_1036d6b50, lStack_b8 != 0)) {
    fStack_cc = *(float *)(lStack_b8 + 0x68);
    if ((fStack_cc <= 0.0) && ((plStack_128 != (long *)0x0 && (plStack_128 == (long *)0x0)))) {
      return 0;
    }
    uVar12 = _UNK_1036d6b60;
    fStack_bc = fStack_cc;
    if (param_1 != 0) {
      *(undefined1 *)(param_1 + 0xf7) = 1;
      lVar7 = *(long *)(param_1 + 0x18);
      *(undefined2 *)(lVar7 + 0x16) = 0x100;
      *(bool *)(lVar7 + 0x15) = *(char *)(lVar7 + 0x17) == '\0';
      uVar12 = _UNK_1036d6b78;
      if ((param_1 != 0) && (uVar12 = _UNK_1036d6b80, param_1 != 0)) {
        uStack_ac = 0xbf800000;
        uStack_118 = CONCAT44(0xbf800000,(int)uStack_118);
        uVar12 = _UNK_1036d6b88;
        if (param_1 != -0xec) {
          *(undefined4 *)(param_1 + 0xf0) = 0xbf800000;
          uVar12 = _UNK_1036d6b90;
          if ((undefined4 *)(param_1 + 0xec) != (undefined4 *)0x0) {
            *(undefined4 *)(param_1 + 0xec) = 0xbf800000;
            return 1;
          }
        }
      }
    }
  }
LAB_101fc4750:
  func_0x0001003316f4(0xee,uVar12);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fc475c);
  (*pcVar2)();
}

