/* 0x060066c9 StardewValley.Mobile.TapToMove.PerformAction @ 0x101fc7cb0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_TapToMove_PerformAction_060066c9(long param_1)

{
  code *pcVar1;
  char cVar2;
  undefined8 uVar3;
  undefined8 uVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  undefined8 *puVar7;
  undefined8 uVar8;
  long lVar9;
  long lVar10;
  long *plVar11;
  int iVar12;
  float fVar13;
  int iVar14;
  float fVar15;
  
  cVar2 = cRam00000001039114d8;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325790);
    cRam00000001039114d8 = '\x01';
  }
  cVar2 = SDV_StardewValley_Mobile_TapToMove_PerformCrabPotAction_060066c8(param_1);
  if (cVar2 != '\0') {
    return true;
  }
  plVar11 = *(long **)(param_1 + 0xb8);
  if (plVar11 != (long *)0x0) {
    uVar3 = _UNK_1036d7430;
    if ((plVar11[8] != 0) && (uVar3 = _UNK_1036d7438, plVar11[9] != 0)) {
      iVar12 = *(int *)(plVar11[8] + 0x68);
      iVar14 = *(int *)(plVar11[9] + 0x68);
      uVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      (**(code **)(*plVar11 + 0x1f8))((float)iVar12,(float)iVar14,plVar11,uVar3);
      return true;
    }
    goto LAB_101fc84a8;
  }
  if (*(char *)(param_1 + 0x102) != '\0') {
    *(undefined1 *)(param_1 + 0x102) = 0;
    plVar11 = (long *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0(lRam00000001038c4c88);
    }
    uVar6 = *puRam00000001038d5380;
    uVar8 = puRam00000001038d5380[1];
    uVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar3 = _UNK_1036d7428;
    if (plVar11 != (long *)0x0) {
      lVar9 = *plVar11;
      uVar3 = 0x1400000037;
LAB_101fc7dd8:
      (**(code **)(lVar9 + 0x3b0))(plVar11,uVar3,uVar6,uVar8,uVar4);
      return true;
    }
    goto LAB_101fc84a8;
  }
  if (*(char *)(param_1 + 0x103) != '\0') {
    *(undefined1 *)(param_1 + 0x103) = 0;
    plVar11 = (long *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0(lRam00000001038c4c88);
    }
    uVar6 = *puRam00000001038d5380;
    uVar8 = puRam00000001038d5380[1];
    uVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar3 = _UNK_1036d7420;
    if (plVar11 != (long *)0x0) {
      lVar9 = *plVar11;
      uVar3 = 0x1300000035;
      goto LAB_101fc7dd8;
    }
    goto LAB_101fc84a8;
  }
  if ((((*(char *)(param_1 + 0xf6) != '\0') || (*(char *)(param_1 + 0xf8) != '\0')) &&
      (lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a(),
      *(long *)(*(long *)(lVar9 + 0x5c0) + 0x60) != 0)) && (*(long *)(param_1 + 0xb0) != 0)) {
    plVar11 = (long *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    uVar3 = _UNK_1036d7410;
    if (*(long *)(param_1 + 0x40) != 0) {
      uVar6 = *(undefined8 *)(*(long *)(param_1 + 0x40) + 0x34);
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar8 = *puRam00000001038d5380;
      uVar4 = puRam00000001038d5380[1];
      uVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar3 = _UNK_1036d7418;
      if (plVar11 != (long *)0x0) {
        (**(code **)(*plVar11 + 0x3b0))(plVar11,uVar6,uVar8,uVar4,uVar5);
        *(undefined8 *)(param_1 + 0xb0) = 0;
        return true;
      }
    }
    goto LAB_101fc84a8;
  }
  plVar11 = *(long **)(param_1 + 0x20);
  lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  if (plVar11 != (long *)0x0) {
    uVar3 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    lVar10 = *plVar11;
    goto LAB_101fc7eb4;
  }
  if ((*(long *)(*(long *)(lVar9 + 0x5c0) + 0x60) != 0) && (*(long *)(param_1 + 0x20) == 0)) {
    lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    *(undefined1 *)(*(long *)(*(long *)(lVar9 + 0x5c0) + 0x60) + 0x476) = 0;
  }
  if (*(long **)(param_1 + 0x98) != (long *)0x0) {
    lVar9 = (**(code **)(**(long **)(param_1 + 0x98) + 0x1e8))();
    uVar3 = _UNK_1036d73e8;
    if (lVar9 == 0) goto LAB_101fc84a8;
    cVar2 = func_0x000100350144(lVar9,uRam00000001038f4150);
    if (cVar2 == '\0') {
      plVar11 = *(long **)(param_1 + 0x98);
      if (plVar11 == (long *)0x0) {
        StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar3 = _UNK_1036d73f0;
        goto LAB_101fc84a8;
      }
      if (lRam00000001038c7508 != *(long *)(*(long *)(*(long *)*plVar11 + 0x10) + 0x20)) {
        uVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        cVar2 = (**(code **)(*plVar11 + 0x4f0))(plVar11,uVar3,0);
        if (cVar2 != '\0') {
          return true;
        }
      }
    }
  }
  if (((*(char *)(*(long *)(param_1 + 0x18) + 0x14) != '\0') && (*(long *)(param_1 + 0x98) != 0)) &&
     (*(long *)(param_1 + 0xb0) == 0)) {
    *(undefined1 *)(param_1 + 0xfb) = 1;
    return true;
  }
  if (*(int *)(param_1 + 0xe0) == 2) {
    lVar9 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    uVar3 = _UNK_1036d73c0;
    if (*(long *)(lVar9 + 0x178) == 0) goto LAB_101fc84a8;
    cVar2 = func_0x000100345aa0(*(undefined8 *)(*(long *)(lVar9 + 0x178) + 0x60),
                                uRam00000001038cb1f0);
    if (cVar2 == '\0') goto LAB_101fc7fac;
    uVar3 = _UNK_1036d73c8;
    if (param_1 == -0x110) goto LAB_101fc84a8;
    if ((*(float *)(param_1 + 0x110) != 3.0) ||
       (((fVar13 = *(float *)(param_1 + 0x114), fVar13 != 14.0 && (fVar13 != 12.0)) &&
        (fVar13 != 13.0)))) goto LAB_101fc7fac;
    plVar11 = (long *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    uVar6 = uRam00000001038cb1f0;
    uVar8 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar3 = _UNK_1036d73d0;
    if (plVar11 == (long *)0x0) goto LAB_101fc84a8;
    (**(code **)(*plVar11 + 0x340))(plVar11,uVar6,uVar8,0xe00000003);
    lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    if (0 < *(int *)(lVar9 + 0x79c)) {
      return true;
    }
    plVar11 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar3 = _UNK_1036d73e0;
joined_r0x000101fc827c:
    if (plVar11 != (long *)0x0) {
      (**(code **)(*plVar11 + 0x188))();
      return false;
    }
  }
  else {
LAB_101fc7fac:
    plVar11 = (long *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    uVar3 = _UNK_1036d7350;
    if ((undefined4 *)(param_1 + 0x110) == (undefined4 *)0x0) goto LAB_101fc84a8;
    fVar13 = *(float *)(param_1 + 0x110);
    fVar15 = *(float *)(param_1 + 0x114);
    uVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar3 = _UNK_1036d7358;
    if (plVar11 == (long *)0x0) goto LAB_101fc84a8;
    cVar2 = (**(code **)(*plVar11 + 0x1f8))(plVar11,(int)fVar13,(int)fVar15,uVar6);
    if (cVar2 == '\0') {
LAB_101fc8004:
      if (((*(long *)(param_1 + 0x48) != 0) && (*(char *)(param_1 + 0xf6) == '\0')) &&
         (*(char *)(param_1 + 0xf8) == '\0')) {
        return *(long *)(param_1 + 0x98) != 0;
      }
      puVar7 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
      if ((puVar7 != (undefined8 *)0x0) &&
         (lRam00000001038c69d0 == *(long *)(*(long *)(*(long *)*puVar7 + 0x10) + 0x10))) {
        plVar11 = (long *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
        fVar13 = *(float *)(param_1 + 0x110);
        fVar15 = *(float *)(param_1 + 0x114);
        uVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar3 = _UNK_1036d7378;
        if (plVar11 == (long *)0x0) goto LAB_101fc84a8;
        cVar2 = (**(code **)(*plVar11 + 0x1f8))(plVar11,(int)fVar13,(int)fVar15 + 1,uVar6);
        if (cVar2 != '\0') {
          uVar3 = _UNK_1036d7380;
          if (*(long *)(param_1 + 0x40) == 0) goto LAB_101fc84a8;
          cVar2 = SDV_StardewValley_Mobile_AStarNode_ContainsGate_06006658();
          if (cVar2 == '\0') {
            uVar3 = _UNK_1036d7388;
            if (*(long *)(param_1 + 0x18) == 0) goto LAB_101fc84a8;
            SDV_StardewValley_Mobile_MobileKeyStates_SetMovePressed_06006670
                      (*(long *)(param_1 + 0x18),2);
            lVar9 = *(long *)(param_1 + 0x18);
            uVar3 = _UNK_1036d7390;
            goto joined_r0x000101fc81a0;
          }
        }
      }
      plVar11 = *(long **)(param_1 + 0x78);
      if ((plVar11 != (long *)0x0) &&
         (lRam00000001038c6638 == *(long *)(*(long *)(*(long *)*plVar11 + 0x10) + 0x18))) {
        lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar3 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
        lVar10 = *plVar11;
LAB_101fc7eb4:
        (**(code **)(lVar10 + 0x350))(plVar11,lVar9,uVar3);
        SDV_StardewValley_Mobile_TapToMove_Reset_06006698(param_1,1);
        return false;
      }
      if ((*(char *)(param_1 + 0xf6) == '\0') && (*(char *)(param_1 + 0xf8) == '\0')) {
        plVar11 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar3 = _UNK_1036d7370;
        goto joined_r0x000101fc827c;
      }
      *(undefined8 *)(param_1 + 0x60) = 0;
      if (*(long *)(param_1 + 0x68) != 0) {
        *(undefined8 *)(param_1 + 0x68) = 0;
        return false;
      }
      SDV_StardewValley_Mobile_TapToMove_faceTileClicked_060066c5(param_1,0,0xfffffc18,0xfffffc18);
      plVar11 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
      (**(code **)(*plVar11 + 0x188))();
      lVar9 = *(long *)(param_1 + 0x18);
      uVar3 = _UNK_1036d7368;
    }
    else {
      uVar3 = _UNK_1036d7398;
      if (*(long *)(param_1 + 0x40) == 0) goto LAB_101fc84a8;
      cVar2 = SDV_StardewValley_Mobile_AStarNode_ContainsGate_06006658();
      if (cVar2 != '\0') goto LAB_101fc8004;
      cVar2 = SDV_StardewValley_Mobile_TapToMoveUtils_IsMatureTreeStumpOrBoulderAt_060066f0
                        (*(undefined4 *)(param_1 + 0x110),*(undefined4 *)(param_1 + 0x114));
      if ((cVar2 != '\0') || (*(long *)(param_1 + 0x88) != 0)) {
        if (*(char *)(param_1 + 0xfe) != '\0') {
          return false;
        }
        SDV_StardewValley_Mobile_TapToMove_SwitchBackToLastTool_060066b2(param_1);
        lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        func_0x00010035025c(*(float *)(param_1 + 0x110) * 64.0,*(float *)(param_1 + 0x114) * 64.0,
                            0x4200000042000000,0x4200000042000000);
        uVar3 = _UNK_1036d73a0;
        if (lVar9 == 0) goto LAB_101fc84a8;
        StardewValley_StardewValley_Character_faceGeneralDirection_0600329c(lVar9,0,0,1);
      }
      plVar11 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
      (**(code **)(*plVar11 + 0x188))();
      lVar9 = *(long *)(param_1 + 0x18);
      uVar3 = _UNK_1036d73b0;
    }
joined_r0x000101fc81a0:
    if (lVar9 != 0) {
      *(undefined1 *)(lVar9 + 0x18) = 1;
      return true;
    }
  }
LAB_101fc84a8:
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc84b4);
  (*pcVar1)();
}

