/* 0x06005e05 StardewValley.Menus.MobileCustomizer.receiveLeftClick @ 0x101e0a838 */

/* WARNING: Removing unreachable block (ram,0x000101e0cf14) */
/* WARNING: Removing unreachable block (ram,0x000101e0ceec) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer_receiveLeftClick_06005e05
               (long param_1,undefined4 param_2,undefined4 param_3,undefined4 param_4)

{
  uint uVar1;
  code *pcVar2;
  bool bVar3;
  char cVar4;
  int iVar5;
  undefined4 uVar6;
  undefined4 uVar7;
  undefined4 uVar8;
  uint uVar9;
  ulong uVar10;
  long lVar11;
  long *plVar12;
  long *plVar13;
  undefined8 uVar14;
  long lVar15;
  double dVar16;
  int iVar17;
  undefined8 uStack_2c0;
  undefined8 uStack_2b8;
  long *plStack_2b0;
  undefined8 uStack_2a8;
  undefined4 auStack_2a0 [2];
  undefined4 auStack_298 [2];
  long lStack_290;
  undefined4 auStack_288 [2];
  undefined8 uStack_280;
  undefined8 *puStack_278;
  undefined1 uStack_269;
  long lStack_268;
  int iStack_25c;
  long lStack_258;
  undefined1 uStack_249;
  long lStack_248;
  int iStack_23c;
  long lStack_238;
  undefined4 uStack_22c;
  long lStack_228;
  undefined8 uStack_220;
  long lStack_218;
  uint uStack_20c;
  long lStack_208;
  long lStack_200;
  long lStack_1f8;
  long lStack_1f0;
  long lStack_1e8;
  long lStack_1e0;
  long lStack_1d8;
  long lStack_1d0;
  long lStack_1c8;
  long lStack_1c0;
  long lStack_1b8;
  long lStack_1b0;
  long lStack_1a8;
  long lStack_1a0;
  long lStack_198;
  undefined4 *puStack_190;
  long lStack_188;
  long lStack_180;
  undefined4 *puStack_178;
  long lStack_170;
  long lStack_168;
  undefined4 *puStack_160;
  long lStack_158;
  long lStack_150;
  undefined4 *puStack_148;
  long lStack_140;
  long lStack_138;
  long lStack_130;
  long lStack_128;
  long lStack_120;
  long lStack_118;
  long lStack_110;
  long lStack_108;
  long lStack_100;
  undefined4 *puStack_f8;
  long lStack_f0;
  long lStack_e8;
  undefined4 *puStack_e0;
  long lStack_d8;
  long lStack_d0;
  undefined4 *puStack_c8;
  long lStack_c0;
  undefined4 *puStack_b8;
  long lStack_b0;
  undefined4 *puStack_a8;
  long lStack_a0;
  long lStack_98;
  undefined4 *puStack_90;
  long lStack_88;
  long lStack_80;
  undefined4 *puStack_78;
  
  cVar4 = cRam0000000103910c14;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103316ec0);
    cRam0000000103910c14 = '\x01';
  }
  uStack_2b8 = 0;
  plStack_2b0 = (long *)0x0;
  uStack_2c0 = 0;
  uStack_2a8 = 0;
  auStack_2a0[0] = 0;
  auStack_298[0] = 0;
  lStack_290 = 0;
  auStack_288[0] = 0;
  cVar4 = SDV_StardewValley_Menus_MobileCustomizer_get_InTutorial_06005dfc(param_1);
  if (cVar4 != '\0') {
    return;
  }
  uVar14 = _UNK_10369f5e8;
  if (param_1 == 0) goto LAB_101e0b680;
  *(undefined1 *)(param_1 + 0x332) = 1;
  if (((*(int *)(param_1 + 0x1ec) == 5) && (*(long *)(param_1 + 0x38) != 0)) &&
     (cVar4 = (**(code **)(**(long **)(param_1 + 0x38) + 0x90))
                        (*(long **)(param_1 + 0x38),param_2,param_3), cVar4 != '\0')) {
    SDV_StardewValley_Menus_MobileCustomizer_optionButtonClick_06005e0a
              (param_1,uRam00000001039004f0);
    return;
  }
  if (((*(long *)(param_1 + 0x38) != 0) &&
      (uVar10 = (**(code **)(**(long **)(param_1 + 0x38) + 0x90))
                          (*(long **)(param_1 + 0x38),param_2,param_3), (uVar10 & 0xff) != 0)) &&
     (*(int *)(param_1 + 0x1ec) == 2)) {
    SDV_StardewValley_Menus_MobileCustomizer_SetCurrentHairIndex_06005e10
              (uVar10,*(undefined4 *)(param_1 + 0x300));
    lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar14 = _UNK_10369fde0;
    if ((param_1 == 0) || (uVar14 = _UNK_10369fde8, lVar11 == 0)) goto LAB_101e0b680;
    func_0x000101854648(lVar11,*(undefined4 *)(param_1 + 0x304));
    lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar14 = _UNK_10369fdf0;
    if ((param_1 == 0) || (uVar14 = _UNK_10369fdf8, lVar11 == 0)) goto LAB_101e0b680;
    func_0x0001018548bc(lVar11,*(undefined4 *)(param_1 + 0x30c));
    lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar14 = _UNK_10369fe00;
    if ((param_1 == 0) || (uVar14 = _UNK_10369fe08, lVar11 == 0)) goto LAB_101e0b680;
    func_0x000101854aac(lVar11,*(undefined4 *)(param_1 + 0x310));
    lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar14 = _UNK_10369fe10;
    if ((param_1 == 0) || (uVar14 = _UNK_10369fe18, lVar11 == 0)) goto LAB_101e0b680;
    func_0x000101854970(lVar11,*(undefined4 *)(param_1 + 0x318),0);
    func_0x000101ea186c(param_1,1);
  }
  lVar11 = SDV_StardewValley_Menus_TutorialManager_get_Instance_06005e62();
  uVar14 = _UNK_10369f600;
  if (lVar11 == 0) goto LAB_101e0b680;
  cVar4 = SDV_StardewValley_Menus_TutorialManager_isInDialogBounds_06005e69(lVar11,param_2,param_3);
  if (cVar4 != '\0') {
    return;
  }
  if (*(long *)(param_1 + 0x1a0) != 0) {
    (**(code **)(**(long **)(param_1 + 0x1a0) + 0xe8))
              (*(long **)(param_1 + 0x1a0),param_2,param_3,param_4);
  }
  if (*(int *)(param_1 + 500) < 5) {
    cVar4 = (**(code **)(**(long **)(param_1 + 0xa0) + 0x90))
                      (*(long **)(param_1 + 0xa0),param_2,param_3);
    if (cVar4 != '\0') {
      lVar11 = *(long *)(param_1 + 0x180);
      uVar14 = _UNK_10369fd88;
      if ((param_1 == 0) || (uVar14 = _UNK_10369fd90, lVar11 == 0)) goto LAB_101e0b680;
      uVar14 = _UNK_10369fd98;
      if (*(uint *)(lVar11 + 0x18) <= *(uint *)(param_1 + 500)) goto LAB_101e0b0b8;
      lVar15 = *(long *)(param_1 + 0x178);
      uVar14 = _UNK_10369fda8;
      if ((param_1 == 0) || (uVar14 = _UNK_10369fdb0, lVar15 == 0)) goto LAB_101e0b680;
      uVar14 = _UNK_10369fdb8;
      if (*(uint *)(lVar15 + 0x18) <= *(uint *)(param_1 + 500)) goto LAB_101e0b0b8;
      if (*(int *)(lVar11 + (long)(int)*(uint *)(param_1 + 500) * 4 + 0x20) <
          *(int *)(lVar15 + (long)(int)*(uint *)(param_1 + 500) * 4 + 0x20) + -1) {
        SDV_StardewValley_Menus_MobileCustomizer_selectionClick_06005e11(param_1,1);
      }
    }
    cVar4 = (**(code **)(**(long **)(param_1 + 0x98) + 0x90))
                      (*(long **)(param_1 + 0x98),param_2,param_3);
    if (cVar4 != '\0') {
      lVar11 = *(long *)(param_1 + 0x180);
      uVar14 = _UNK_10369fd70;
      if ((param_1 == 0) || (uVar14 = _UNK_10369fd78, lVar11 == 0)) goto LAB_101e0b680;
      uVar14 = _UNK_10369fd80;
      if (*(uint *)(lVar11 + 0x18) <= *(uint *)(param_1 + 500)) goto LAB_101e0b0b8;
      if (0 < *(int *)(lVar11 + (long)(int)*(uint *)(param_1 + 500) * 4 + 0x20)) {
        SDV_StardewValley_Menus_MobileCustomizer_selectionClick_06005e11(param_1,0xffffffff);
      }
    }
  }
  if ((*(long *)(param_1 + 0x168) == 0) ||
     (cVar4 = func_0x000100356238(*(long *)(param_1 + 0x168) + 0x1c,param_2,param_3), cVar4 == '\0')
     ) {
    uVar14 = _UNK_10369f628;
    if (*(long *)(param_1 + 0x160) == 0) goto LAB_101e0b680;
    cVar4 = func_0x000100356238(*(long *)(param_1 + 0x160) + 0x2c,param_2,param_3);
    if (cVar4 != '\0') {
      uVar14 = _UNK_10369f638;
      if ((param_1 == 0) || (uVar14 = _UNK_10369fb08, param_1 == 0)) goto LAB_101e0b680;
      lVar11 = 0x2c;
      goto LAB_101e0ab9c;
    }
  }
  else {
    uVar14 = _UNK_10369fb10;
    if ((param_1 == 0) || (uVar14 = _UNK_10369fb18, param_1 == 0)) goto LAB_101e0b680;
    lVar11 = 0x2d;
LAB_101e0ab9c:
    lVar15 = lRam00000001038c4be0;
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x170) = *(undefined8 *)(param_1 + lVar11 * 8);
    *(undefined1 *)((param_1 + 0x170U >> 9 & 0x7fffff) + lVar15) = 1;
  }
  cVar4 = (**(code **)(**(long **)(param_1 + 0xc0) + 0x90))
                    (*(long **)(param_1 + 0xc0),param_2,param_3);
  if ((cVar4 != '\0') &&
     (cVar4 = SDV_StardewValley_Menus_MobileCustomizer_canLeaveMenu_06005e12(param_1), cVar4 != '\0'
     )) {
    func_0x0001017188e0(uRam00000001038d7418,0);
  }
  if (*(int *)(param_1 + 0x1ec) != 5) {
    uVar9 = *(uint *)(param_1 + 0x1ec);
    uVar14 = _UNK_10369f688;
    if (param_1 != 0) {
      if (uVar9 != 6) {
        uVar9 = 0;
      }
LAB_101e0acd8:
      do {
        if (*(int *)(*(long *)(param_1 + 0xb0) + 0x18) <= (int)uVar9) goto LAB_101e0ac20;
        if (*(uint *)(*(long *)(param_1 + 0xb0) + 0x18) <= uVar9) goto LAB_101e0c858;
        lVar11 = *(long *)(*(long *)(param_1 + 0xb0) + 0x10);
        uVar14 = _UNK_10369f678;
        if (*(uint *)(lVar11 + 0x18) <= uVar9) goto LAB_101e0b0b8;
        plVar12 = *(long **)(lVar11 + (long)(int)uVar9 * 8 + 0x20);
        cVar4 = (**(code **)(*plVar12 + 0x90))(plVar12,param_2,param_3);
        if (cVar4 == '\0') goto LAB_101e0b040;
        func_0x0001017188e0(uRam00000001038d7418,0);
        if (*(int *)(param_1 + 0x1ec) == 2) {
          if ((7 < uVar9) || ((1 << (ulong)(uVar9 & 0x1f) & 0x94U) == 0)) {
            uVar14 = _UNK_10369f890;
            if (param_1 != 0) goto LAB_101e0ad74;
            break;
          }
        }
        else {
          uVar14 = _UNK_10369f698;
          if (param_1 == 0) break;
LAB_101e0ad74:
          *(uint *)(param_1 + 500) = uVar9;
        }
        switch(*(undefined4 *)(param_1 + 500)) {
        case 0:
          lVar15 = *(long *)(param_1 + 0x160);
          lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          uVar14 = _UNK_10369f6d0;
          if (*(int *)(*(long *)(param_1 + 0x178) + 0x18) == 0) goto LAB_101e0b0b8;
          uVar14 = _UNK_10369f6d8;
          if (lVar15 != 0) {
            *(int *)(lVar15 + 0x10) =
                 (int)(((float)*(int *)(*(long *)(lVar11 + 0x380) + 0x68) * 100.0) /
                      (float)*(int *)(*(long *)(param_1 + 0x178) + 0x20));
            lVar15 = *(long *)(param_1 + 0x180);
            uVar1 = *(uint *)(param_1 + 500);
            lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
            uVar14 = _UNK_10369f6f8;
            if (*(long *)(lVar11 + 0x380) != 0) {
              uVar14 = _UNK_10369f708;
              if (uVar1 < *(uint *)(lVar15 + 0x18)) {
                iVar5 = *(int *)(*(long *)(lVar11 + 0x380) + 0x68);
                goto code_r0x000101e0afc0;
              }
              goto LAB_101e0b0b8;
            }
          }
          goto LAB_101e0b680;
        case 1:
          lVar11 = *(long *)(param_1 + 0x160);
          iVar5 = SDV_StardewValley_Menus_MobileCustomizer_GetCurrentHairIndex_06005e0f(param_1);
          uVar14 = _UNK_10369f728;
          if (*(uint *)(*(long *)(param_1 + 0x178) + 0x18) < 2) goto LAB_101e0b0b8;
          uVar14 = _UNK_10369f730;
          if (lVar11 == 0) goto LAB_101e0b680;
          *(int *)(lVar11 + 0x10) =
               (int)(((float)iVar5 * 100.0) / (float)*(int *)(*(long *)(param_1 + 0x178) + 0x24));
          lVar11 = *(long *)(param_1 + 0x180);
          uVar1 = *(uint *)(param_1 + 500);
          uVar6 = SDV_StardewValley_Menus_MobileCustomizer_GetCurrentHairIndex_06005e0f(param_1);
          uVar14 = _UNK_10369f750;
          if (*(uint *)(lVar11 + 0x18) <= uVar1) goto LAB_101e0b0b8;
          *(undefined4 *)(lVar11 + (long)(int)uVar1 * 4 + 0x20) = uVar6;
          break;
        case 2:
          lVar11 = *(long *)(param_1 + 0x180);
          uVar1 = *(uint *)(param_1 + 500);
          uVar6 = SDV_StardewValley_Menus_MobileCustomizer_GetCurrentShirtIndex_06005e0d(param_1);
          uVar14 = _UNK_10369f770;
          if (*(uint *)(lVar11 + 0x18) <= uVar1) goto LAB_101e0b0b8;
          *(undefined4 *)(lVar11 + (long)(int)uVar1 * 4 + 0x20) = uVar6;
          lVar11 = *(long *)(param_1 + 0x160);
          lVar15 = *(long *)(param_1 + 0x180);
          uVar14 = _UNK_10369f788;
          if ((param_1 != 0) && (uVar14 = _UNK_10369f790, lVar15 != 0)) {
            uVar14 = _UNK_10369f798;
            if (*(uint *)(lVar15 + 0x18) <= *(uint *)(param_1 + 500)) goto LAB_101e0b0b8;
            iVar5 = *(int *)(lVar15 + (long)(int)*(uint *)(param_1 + 500) * 4 + 0x20);
            uVar14 = _UNK_10369f7b0;
            if (*(uint *)(*(long *)(param_1 + 0x178) + 0x18) < 3) goto LAB_101e0b0b8;
            uVar14 = _UNK_10369f7b8;
            if (lVar11 != 0) {
              iVar17 = *(int *)(*(long *)(param_1 + 0x178) + 0x28);
              goto code_r0x000101e0af24;
            }
          }
          goto LAB_101e0b680;
        case 3:
          lVar15 = *(long *)(param_1 + 0x160);
          lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          iVar5 = *(int *)(*(long *)(lVar11 + 0x390) + 0x68);
          if (iVar5 < 1) {
            iVar5 = 0;
          }
          uVar14 = _UNK_10369f7e8;
          if (*(uint *)(*(long *)(param_1 + 0x178) + 0x18) < 4) goto LAB_101e0b0b8;
          uVar14 = _UNK_10369f7f0;
          if (lVar15 == 0) goto LAB_101e0b680;
          *(int *)(lVar15 + 0x10) =
               (int)(((float)iVar5 * 100.0) / (float)*(int *)(*(long *)(param_1 + 0x178) + 0x2c));
          lVar15 = *(long *)(param_1 + 0x180);
          uVar1 = *(uint *)(param_1 + 500);
          lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          uVar14 = _UNK_10369f810;
          if (*(long *)(lVar11 + 0x390) == 0) goto LAB_101e0b680;
          uVar14 = _UNK_10369f820;
          if (*(uint *)(lVar15 + 0x18) <= uVar1) goto LAB_101e0b0b8;
          iVar5 = *(int *)(*(long *)(lVar11 + 0x390) + 0x68) + 1;
code_r0x000101e0afc0:
          *(int *)(lVar15 + (long)(int)uVar1 * 4 + 0x20) = iVar5;
          break;
        case 4:
          lVar11 = *(long *)(param_1 + 0x180);
          uVar1 = *(uint *)(param_1 + 500);
          uVar6 = SDV_StardewValley_Menus_MobileCustomizer_GetCurrentPantIndex_06005e0e(param_1);
          uVar14 = _UNK_10369f840;
          if (*(uint *)(lVar11 + 0x18) <= uVar1) goto LAB_101e0b0b8;
          *(undefined4 *)(lVar11 + (long)(int)uVar1 * 4 + 0x20) = uVar6;
          lVar11 = *(long *)(param_1 + 0x160);
          lVar15 = *(long *)(param_1 + 0x180);
          uVar14 = _UNK_10369f858;
          if ((param_1 == 0) || (uVar14 = _UNK_10369f860, lVar15 == 0)) goto LAB_101e0b680;
          uVar14 = _UNK_10369f868;
          if (*(uint *)(lVar15 + 0x18) <= *(uint *)(param_1 + 500)) goto LAB_101e0b0b8;
          iVar5 = *(int *)(lVar15 + (long)(int)*(uint *)(param_1 + 500) * 4 + 0x20);
          uVar14 = _UNK_10369f880;
          if (*(uint *)(*(long *)(param_1 + 0x178) + 0x18) < 5) goto LAB_101e0b0b8;
          uVar14 = _UNK_10369f888;
          if (lVar11 == 0) goto LAB_101e0b680;
          iVar17 = *(int *)(*(long *)(param_1 + 0x178) + 0x30);
code_r0x000101e0af24:
          *(int *)(lVar11 + 0x10) = (int)(((float)iVar5 * 100.0) / (float)iVar17);
        }
LAB_101e0b040:
        if (lRam0000000103976fb8 == 0) {
          uVar9 = uVar9 + 1;
          uVar14 = _UNK_10369f688;
          if (param_1 == 0) break;
          goto LAB_101e0acd8;
        }
        func_0x00010119b8f8();
        uVar9 = uVar9 + 1;
        uVar14 = _UNK_10369f688;
      } while (param_1 != 0);
    }
    goto LAB_101e0b680;
  }
  uVar14 = _UNK_10369faf8;
  if (param_1 == 0) goto LAB_101e0b680;
  *(undefined4 *)(param_1 + 500) = 7;
LAB_101e0ac20:
  uVar14 = _UNK_10369f898;
  if (*(long *)(param_1 + 0xa8) == 0) goto LAB_101e0b680;
  func_0x00010037744c(&uStack_2c0);
  while (cVar4 = func_0x000100377460(&uStack_2c0), plVar12 = plStack_2b0, cVar4 != '\0') {
    if (plStack_2b0 == (long *)0x0) {
      func_0x0001003316f4(0xee,_UNK_10369f8a0,param_3);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101e0b084);
      (*pcVar2)();
    }
    cVar4 = (**(code **)(*plStack_2b0 + 0x90))(plStack_2b0,param_2);
    if (cVar4 != '\0') {
      SDV_StardewValley_Menus_MobileCustomizer_optionButtonClick_06005e0a(param_1,plVar12[2]);
    }
    if (lRam0000000103976fb8 != 0) {
      func_0x00010119b8f8();
    }
  }
  uStack_280 = 0;
  puStack_278 = &uStack_2c0;
  uVar14 = _UNK_10369fae8;
  if (puStack_278 == (undefined8 *)0x0) goto LAB_101e0b680;
  uStack_280 = 0;
  cVar4 = (**(code **)(**(long **)(param_1 + 0x88) + 0x90))
                    (*(long **)(param_1 + 0x88),param_2,param_3);
  if (cVar4 != '\0') {
    plVar12 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
    plVar13 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
    iVar5 = (**(code **)(*plVar13 + 0x1f0))();
    uVar14 = _UNK_10369fd30;
    if (plVar12 == (long *)0x0) goto LAB_101e0b680;
    (**(code **)(*plVar12 + 0x178))(plVar12,(iVar5 + 5) % 4);
    lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar14 = _UNK_10369fd38;
    if (lVar11 == 0) goto LAB_101e0b680;
    plVar12 = (long *)func_0x00010183a070();
    (**(code **)(*plVar12 + 0x108))();
    lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar14 = _UNK_10369fd48;
    if (lVar11 == 0) goto LAB_101e0b680;
    StardewValley_StardewValley_Farmer_completelyStopAnimatingOrDoingAction_060036da();
    func_0x0001017188e0(uRam00000001038e56f0,0);
  }
  cVar4 = (**(code **)(**(long **)(param_1 + 0x90) + 0x90))
                    (*(long **)(param_1 + 0x90),param_2,param_3);
  if (cVar4 != '\0') {
    plVar12 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
    plVar13 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
    iVar5 = (**(code **)(*plVar13 + 0x1f0))();
    uVar14 = _UNK_10369fd10;
    if (plVar12 == (long *)0x0) goto LAB_101e0b680;
    (**(code **)(*plVar12 + 0x178))(plVar12,(iVar5 + 3) % 4);
    lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar14 = _UNK_10369fd18;
    if (lVar11 == 0) goto LAB_101e0b680;
    plVar12 = (long *)func_0x00010183a070();
    (**(code **)(*plVar12 + 0x108))();
    lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar14 = _UNK_10369fd28;
    if (lVar11 == 0) goto LAB_101e0b680;
    StardewValley_StardewValley_Farmer_completelyStopAnimatingOrDoingAction_060036da();
    func_0x0001017188e0(uRam00000001038e56f0,0);
  }
  if (*(int *)(param_1 + 500) == 6) {
    uVar14 = _UNK_10369fce0;
    if (*(long *)(param_1 + 0x70) == 0) goto LAB_101e0b680;
    cVar4 = func_0x000100356238(*(long *)(param_1 + 0x70) + 0xa4,param_2,param_3);
    if (cVar4 == '\0') goto LAB_101e0b830;
    uVar14 = _UNK_10369fcf0;
    if (*(long *)(param_1 + 0x70) == 0) goto LAB_101e0b680;
    SDV_StardewValley_Menus_MobileColorPicker_click_06005def
              (*(long *)(param_1 + 0x70),param_2,param_3,0);
    (**(code **)(*(long *)(param_1 + 0x148) + 0x18))();
    uVar14 = _UNK_10369fd08;
    if ((param_1 == 0) || (uVar14 = _UNK_10369fad0, param_1 == 0)) goto LAB_101e0b680;
    lVar11 = 0xe;
LAB_101e0b8fc:
    lVar15 = lRam00000001038c4be0;
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x128) = *(undefined8 *)(param_1 + lVar11 * 8);
    *(undefined1 *)((param_1 + 0x128U >> 9 & 0x7fffff) + lVar15) = 1;
  }
  else {
LAB_101e0b830:
    if (*(int *)(param_1 + 500) == 7) {
      uVar14 = _UNK_10369fcc0;
      if (*(long *)(param_1 + 0x68) == 0) goto LAB_101e0b680;
      cVar4 = func_0x000100356238(*(long *)(param_1 + 0x68) + 0xa4,param_2,param_3);
      if (cVar4 != '\0') {
        uVar14 = _UNK_10369fcd0;
        if (((*(long *)(param_1 + 0x68) == 0) ||
            (SDV_StardewValley_Menus_MobileColorPicker_click_06005def
                       (*(long *)(param_1 + 0x68),param_2,param_3,0), uVar14 = _UNK_10369fcd8,
            param_1 == 0)) || (uVar14 = _UNK_10369fac0, param_1 == 0)) goto LAB_101e0b680;
        lVar11 = 0xd;
        goto LAB_101e0b8fc;
      }
    }
    if (*(int *)(param_1 + 500) == 5) {
      uVar14 = _UNK_10369fca0;
      if (*(long *)(param_1 + 0x78) == 0) goto LAB_101e0b680;
      cVar4 = func_0x000100356238(*(long *)(param_1 + 0x78) + 0xa4,param_2,param_3);
      if (cVar4 != '\0') {
        uVar14 = _UNK_10369fcb0;
        if (((*(long *)(param_1 + 0x78) == 0) ||
            (SDV_StardewValley_Menus_MobileColorPicker_click_06005def
                       (*(long *)(param_1 + 0x78),param_2,param_3,0), uVar14 = _UNK_10369fcb8,
            param_1 == 0)) || (uVar14 = _UNK_10369fab0, param_1 == 0)) goto LAB_101e0b680;
        lVar11 = 0xf;
        goto LAB_101e0b8fc;
      }
    }
  }
  if ((*(int *)(param_1 + 0x1ec) == 6) || (*(int *)(param_1 + 0x1ec) == 5)) {
    return;
  }
  (**(code **)(**(long **)(param_1 + 0xe0) + 0xc0))();
  if (*(long *)(param_1 + 0xe8) != 0) {
    (**(code **)(**(long **)(param_1 + 0xe8) + 0xc0))();
  }
  (**(code **)(**(long **)(param_1 + 0xf0) + 0xc0))();
  if (*(int *)(param_1 + 0x1ec) != 2) {
    cVar4 = (**(code **)(**(long **)(param_1 + 200) + 0x90))
                      (*(long **)(param_1 + 200),param_2,param_3);
    if (cVar4 != '\0') {
      func_0x0001017188e0(uRam00000001038e2ef0,0);
      uVar14 = _UNK_10369faa0;
      if ((param_1 == 0) || (uVar14 = _UNK_10369fc90, param_1 == 0)) goto LAB_101e0b680;
      *(bool *)(param_1 + 0x1e8) = *(char *)(param_1 + 0x1e8) == '\0';
    }
    if ((*(long *)(param_1 + 0xd8) != 0) &&
       (cVar4 = (**(code **)(**(long **)(param_1 + 0xd8) + 0x90))
                          (*(long **)(param_1 + 0xd8),param_2,param_3), cVar4 != '\0')) {
      *puRam0000000103900570 = 0;
      func_0x0001017188e0(uRam00000001038e2ef0,0);
      SDV_StardewValley_Menus_MobileCustomizer_ShowAdvancedOptions_06005e14(param_1);
    }
  }
  cVar4 = (**(code **)(**(long **)(param_1 + 0xd0) + 0x90))
                    (*(long **)(param_1 + 0xd0),param_2,param_3);
  if (cVar4 == '\0') {
    return;
  }
  uStack_2a8 = uRam00000001038e2ef0;
  if (0 < *(int *)(param_1 + 0x334)) {
    lStack_1f0 = lRam00000001038c4c88;
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0(lRam00000001038c4c88);
    }
    iVar5 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x90))
                      ((long *)*plRam00000001038d5b58,0xf);
    lStack_1e8 = (long)iVar5;
    switch(iVar5) {
    case 0:
      uStack_2a8 = uRam0000000103900558;
      break;
    case 1:
      uStack_2a8 = uRam00000001038dfce8;
      break;
    case 2:
      uStack_2a8 = uRam00000001038ecae8;
      break;
    case 3:
      uStack_2a8 = uRam00000001038ecf08;
      break;
    case 4:
      uStack_2a8 = uRam00000001038e2600;
      break;
    case 5:
    case 7:
      uStack_2a8 = uRam00000001038e2ef0;
      break;
    case 6:
      uStack_2a8 = uRam00000001038e2628;
      break;
    case 8:
      uStack_2a8 = uRam00000001038f7628;
      break;
    case 9:
      uStack_2a8 = uRam00000001038dfd20;
      break;
    case 10:
      uStack_2a8 = uRam00000001038ecc88;
      break;
    case 0xb:
      uStack_2a8 = uRam00000001038d74a8;
      break;
    case 0xc:
      uStack_2a8 = uRam00000001038ed028;
      break;
    case 0xd:
      uStack_2a8 = uRam0000000103900560;
      break;
    case 0xe:
      uStack_2a8 = uRam0000000103900568;
    }
  }
  func_0x0001017188e0(uStack_2a8,0);
  uVar14 = _UNK_10369f938;
  if ((param_1 == 0) || (uVar14 = _UNK_10369f940, param_1 == 0)) goto LAB_101e0b680;
  *(int *)(param_1 + 0x334) = *(int *)(param_1 + 0x334) + 1;
  lStack_1e0 = lRam00000001038c4c88;
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0(lRam00000001038c4c88);
  }
  dVar16 = (double)(**(code **)(*(long *)*plRam00000001038d5b58 + 0x80))();
  lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  if (dVar16 < _UNK_1033337a0) {
    uVar14 = _UNK_10369fa90;
    lStack_268 = lVar11;
    if ((lVar11 == 0) ||
       (lStack_258 = *(long *)(lVar11 + 0x528), uVar14 = _UNK_10369fc38, lStack_258 == 0))
    goto LAB_101e0b680;
    iStack_25c = *(int *)(lStack_258 + 0x68);
    bVar3 = iStack_25c == 0;
    uStack_269 = bVar3;
    lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    if (bVar3) {
      lStack_1d8 = lRam00000001038c4c88;
      lStack_1d0 = lVar11;
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0(lRam00000001038c4c88);
      }
      uVar6 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x90))
                        ((long *)*plRam00000001038d5b58,0x13);
      uVar14 = _UNK_10369fc60;
      lVar11 = lStack_1d0;
    }
    else {
      lStack_1c8 = lRam00000001038c4c88;
      lStack_1c0 = lVar11;
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0(lRam00000001038c4c88);
      }
      uVar6 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x88))
                        ((long *)*plRam00000001038d5b58,6,0x13);
      uVar14 = _UNK_10369fc50;
      lVar11 = lStack_1c0;
    }
    if (lVar11 == 0) goto LAB_101e0b680;
  }
  else {
    uVar14 = _UNK_10369f950;
    if (lVar11 == 0) goto LAB_101e0b680;
    uVar6 = 0xffffffff;
  }
  func_0x0001018548bc(lVar11,uVar6);
  lStack_248 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar14 = _UNK_10369f958;
  if ((lStack_248 != 0) &&
     (lStack_238 = *(long *)(lStack_248 + 0x528), uVar14 = _UNK_10369f968, lStack_238 != 0)) {
    iStack_23c = *(int *)(lStack_238 + 0x68);
    uStack_249 = iStack_23c == 0;
    if ((bool)uStack_249) {
      lStack_1b8 = lRam00000001038c4c88;
      lStack_1b0 = param_1;
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0(lRam00000001038c4c88);
      }
      uVar10 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x90))
                         ((long *)*plRam00000001038d5b58,0x10);
      lVar11 = lStack_1b0;
    }
    else {
      lStack_1a8 = lRam00000001038c4c88;
      lStack_1a0 = param_1;
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0(lRam00000001038c4c88);
      }
      uVar10 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x88))
                         ((long *)*plRam00000001038d5b58,0x10,0x20);
      lVar11 = lStack_1a0;
    }
    SDV_StardewValley_Menus_MobileCustomizer_SetCurrentHairIndex_06005e10
              (lVar11,uVar10,uVar10 & 0xffffffff);
    puStack_190 = auStack_2a0;
    lStack_198 = lRam00000001038c4c88;
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0(lRam00000001038c4c88);
    }
    uVar6 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x88))
                      ((long *)*plRam00000001038d5b58,0x19,0xfe);
    plVar12 = (long *)*plRam00000001038d5b58;
    uVar14 = _UNK_10369f988;
    if (plVar12 != (long *)0x0) {
      uVar7 = (**(code **)(*plVar12 + 0x88))(plVar12,0x19,0xfe);
      plVar12 = (long *)*plRam00000001038d5b58;
      uVar14 = _UNK_10369f990;
      if (plVar12 != (long *)0x0) {
        uVar8 = (**(code **)(*plVar12 + 0x88))(plVar12,0x19,0xfe);
        func_0x00010035205c(puStack_190,uVar6,uVar7,uVar8);
        dVar16 = (double)(**(code **)(*(long *)*plRam00000001038d5b58 + 0x80))();
        if (dVar16 < 0.5) {
          uVar9 = func_0x000100342a44(auStack_2a0);
          func_0x000100355c34(auStack_2a0,uVar9 >> 1 & 0x7f);
          uVar9 = func_0x000100342a30(auStack_2a0);
          func_0x000100355c48(auStack_2a0,uVar9 >> 1 & 0x7f);
          uVar9 = func_0x000100342a1c(auStack_2a0);
          func_0x000100355c5c(auStack_2a0,uVar9 >> 1 & 0x7f);
        }
        lStack_188 = lRam00000001038c4c88;
        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
          func_0x0001003319b0(lRam00000001038c4c88);
        }
        dVar16 = (double)(**(code **)(*(long *)*plRam00000001038d5b58 + 0x80))();
        if (dVar16 < 0.5) {
          puStack_178 = auStack_2a0;
          lStack_180 = lRam00000001038c4c88;
          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
            func_0x0001003319b0(lRam00000001038c4c88);
          }
          uVar6 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x88))
                            ((long *)*plRam00000001038d5b58,0xf,0x32);
          func_0x000100355c34(puStack_178,uVar6);
        }
        lStack_170 = lRam00000001038c4c88;
        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
          func_0x0001003319b0(lRam00000001038c4c88);
        }
        dVar16 = (double)(**(code **)(*(long *)*plRam00000001038d5b58 + 0x80))();
        if (dVar16 < 0.5) {
          puStack_160 = auStack_2a0;
          lStack_168 = lRam00000001038c4c88;
          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
            func_0x0001003319b0(lRam00000001038c4c88);
          }
          uVar6 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x88))
                            ((long *)*plRam00000001038d5b58,0xf,0x32);
          func_0x000100355c48(puStack_160,uVar6);
        }
        lStack_158 = lRam00000001038c4c88;
        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
          func_0x0001003319b0(lRam00000001038c4c88);
        }
        dVar16 = (double)(**(code **)(*(long *)*plRam00000001038d5b58 + 0x80))();
        if (dVar16 < 0.5) {
          puStack_148 = auStack_2a0;
          lStack_150 = lRam00000001038c4c88;
          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
            func_0x0001003319b0(lRam00000001038c4c88);
          }
          uVar6 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x88))
                            ((long *)*plRam00000001038d5b58,0xf,0x32);
          func_0x000100355c5c(puStack_148,uVar6);
        }
        lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar14 = _UNK_10369f9b8;
        if (lVar11 != 0) {
          func_0x000101854648(lVar11,auStack_2a0[0]);
          lStack_138 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          lStack_140 = lRam00000001038c4c88;
          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
            func_0x0001003319b0(lRam00000001038c4c88);
          }
          uVar6 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x90))
                            ((long *)*plRam00000001038d5b58,6);
          uVar14 = _UNK_10369f9c8;
          if (lStack_138 != 0) {
            func_0x000101854970(lStack_138,uVar6,0);
            dVar16 = (double)(**(code **)(*(long *)*plRam00000001038d5b58 + 0x80))();
            if (dVar16 < 0.25) {
              lStack_128 = StardewValley_StardewValley_Game1_get_player_06002f9a();
              lStack_130 = lRam00000001038c4c88;
              if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                func_0x0001003319b0(lRam00000001038c4c88);
              }
              uVar6 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x90))
                                ((long *)*plRam00000001038d5b58,0x18);
              uVar14 = _UNK_10369fc08;
              if (lStack_128 == 0) goto LAB_101e0b680;
              func_0x000101854970(lStack_128,uVar6,0);
            }
            if (*(int *)(param_1 + 0x1ec) != 2) {
              lStack_290 = SDV_StardewValley_Menus_MobileCustomizer_GetValidShirtIds_06005e18
                                     (param_1);
              lStack_110 = StardewValley_StardewValley_Game1_get_player_06002f9a();
              lStack_118 = lStack_290;
              lStack_120 = lRam00000001038c4c88;
              if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                func_0x0001003319b0(lRam00000001038c4c88);
              }
              lStack_228 = lStack_290;
              uVar14 = _UNK_10369fb60;
              if (lStack_290 == 0) goto LAB_101e0b680;
              uStack_22c = *(undefined4 *)(lStack_290 + 0x18);
              uStack_20c = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x90))
                                     ((long *)*plRam00000001038d5b58,uStack_22c);
              lStack_218 = lStack_118;
              uVar14 = _UNK_10369fb78;
              if (lStack_118 == 0) goto LAB_101e0b680;
              if (*(uint *)(lStack_118 + 0x18) <= uStack_20c) {
LAB_101e0c858:
                func_0x000100331b90();
                    /* WARNING: Does not return */
                pcVar2 = (code *)SoftwareBreakpoint(1,0x101e0c860);
                (*pcVar2)();
              }
              uVar14 = _UNK_10369fb98;
              if (*(uint *)(*(long *)(lStack_118 + 0x10) + 0x18) <= uStack_20c) {
LAB_101e0b0b8:
                func_0x0001003316f4(0xcc,uVar14);
                    /* WARNING: Does not return */
                pcVar2 = (code *)SoftwareBreakpoint(1,0x101e0b0c4);
                (*pcVar2)();
              }
              uStack_220 = *(undefined8 *)
                            (*(long *)(lStack_118 + 0x10) + (long)(int)uStack_20c * 8 + 0x20);
              uVar14 = _UNK_10369fba0;
              if (lStack_110 == 0) goto LAB_101e0b680;
              func_0x0001018534f8(lStack_110,lStack_110,uStack_220);
              uVar6 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x88))
                                ((long *)*plRam00000001038d5b58,0x19,0xfe);
              plVar12 = (long *)*plRam00000001038d5b58;
              uVar14 = _UNK_10369fbb0;
              if (plVar12 == (long *)0x0) goto LAB_101e0b680;
              uVar7 = (**(code **)(*plVar12 + 0x88))(plVar12,0x19,0xfe);
              plVar12 = (long *)*plRam00000001038d5b58;
              uVar14 = _UNK_10369fbb8;
              if (plVar12 == (long *)0x0) goto LAB_101e0b680;
              uVar8 = (**(code **)(*plVar12 + 0x88))(plVar12,0x19,0xfe);
              func_0x00010035205c(auStack_288,uVar6,uVar7,uVar8);
              dVar16 = (double)(**(code **)(*(long *)*plRam00000001038d5b58 + 0x80))();
              if (dVar16 < 0.5) {
                uVar9 = func_0x000100342a44(auStack_288);
                func_0x000100355c34(auStack_288,uVar9 >> 1 & 0x7f);
                uVar9 = func_0x000100342a30(auStack_288);
                func_0x000100355c48(auStack_288,uVar9 >> 1 & 0x7f);
                uVar9 = func_0x000100342a1c(auStack_288);
                func_0x000100355c5c(auStack_288,uVar9 >> 1 & 0x7f);
              }
              lStack_108 = lRam00000001038c4c88;
              if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                func_0x0001003319b0(lRam00000001038c4c88);
              }
              dVar16 = (double)(**(code **)(*(long *)*plRam00000001038d5b58 + 0x80))();
              if (dVar16 < 0.5) {
                puStack_f8 = auStack_288;
                lStack_100 = lRam00000001038c4c88;
                if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                  func_0x0001003319b0(lRam00000001038c4c88);
                }
                uVar6 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x88))
                                  ((long *)*plRam00000001038d5b58,0xf,0x32);
                func_0x000100355c34(puStack_f8,uVar6);
              }
              lStack_f0 = lRam00000001038c4c88;
              if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                func_0x0001003319b0(lRam00000001038c4c88);
              }
              dVar16 = (double)(**(code **)(*(long *)*plRam00000001038d5b58 + 0x80))();
              if (dVar16 < 0.5) {
                puStack_e0 = auStack_288;
                lStack_e8 = lRam00000001038c4c88;
                if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                  func_0x0001003319b0(lRam00000001038c4c88);
                }
                uVar6 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x88))
                                  ((long *)*plRam00000001038d5b58,0xf,0x32);
                func_0x000100355c48(puStack_e0,uVar6);
              }
              lStack_d8 = lRam00000001038c4c88;
              if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                func_0x0001003319b0(lRam00000001038c4c88);
              }
              dVar16 = (double)(**(code **)(*(long *)*plRam00000001038d5b58 + 0x80))();
              if (dVar16 < 0.5) {
                puStack_c8 = auStack_288;
                lStack_d0 = lRam00000001038c4c88;
                if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                  func_0x0001003319b0(lRam00000001038c4c88);
                }
                uVar6 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x88))
                                  ((long *)*plRam00000001038d5b58,0xf,0x32);
                func_0x000100355c5c(puStack_c8,uVar6);
              }
              lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
              uVar14 = _UNK_10369fbe0;
              if (lVar11 == 0) goto LAB_101e0b680;
              func_0x0001018546ec(lVar11,auStack_288[0]);
            }
            puStack_b8 = auStack_298;
            lStack_c0 = lRam00000001038c4c88;
            if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
              func_0x0001003319b0(lRam00000001038c4c88);
            }
            uVar6 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x88))
                              ((long *)*plRam00000001038d5b58,0x19,0xfe);
            plVar12 = (long *)*plRam00000001038d5b58;
            uVar14 = _UNK_10369f9e8;
            if (plVar12 != (long *)0x0) {
              uVar7 = (**(code **)(*plVar12 + 0x88))(plVar12,0x19,0xfe);
              plVar12 = (long *)*plRam00000001038d5b58;
              uVar14 = _UNK_10369f9f0;
              if (plVar12 != (long *)0x0) {
                uVar8 = (**(code **)(*plVar12 + 0x88))(plVar12,0x19,0xfe);
                func_0x00010035205c(puStack_b8,uVar6,uVar7,uVar8);
                uVar9 = func_0x000100342a44(auStack_298);
                func_0x000100355c34(auStack_298,uVar9 >> 1 & 0x7f);
                uVar9 = func_0x000100342a30(auStack_298);
                func_0x000100355c48(auStack_298,uVar9 >> 1 & 0x7f);
                uVar9 = func_0x000100342a1c(auStack_298);
                func_0x000100355c5c(auStack_298,uVar9 >> 1 & 0x7f);
                dVar16 = (double)(**(code **)(*(long *)*plRam00000001038d5b58 + 0x80))();
                if (dVar16 < 0.5) {
                  puStack_a8 = auStack_298;
                  lStack_b0 = lRam00000001038c4c88;
                  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                    func_0x0001003319b0(lRam00000001038c4c88);
                  }
                  uVar6 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x88))
                                    ((long *)*plRam00000001038d5b58,0xf,0x32);
                  func_0x000100355c34(puStack_a8,uVar6);
                }
                lStack_a0 = lRam00000001038c4c88;
                if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                  func_0x0001003319b0(lRam00000001038c4c88);
                }
                dVar16 = (double)(**(code **)(*(long *)*plRam00000001038d5b58 + 0x80))();
                if (dVar16 < 0.5) {
                  puStack_90 = auStack_298;
                  lStack_98 = lRam00000001038c4c88;
                  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                    func_0x0001003319b0(lRam00000001038c4c88);
                  }
                  uVar6 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x88))
                                    ((long *)*plRam00000001038d5b58,0xf,0x32);
                  func_0x000100355c48(puStack_90,uVar6);
                }
                lStack_88 = lRam00000001038c4c88;
                if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                  func_0x0001003319b0(lRam00000001038c4c88);
                }
                dVar16 = (double)(**(code **)(*(long *)*plRam00000001038d5b58 + 0x80))();
                if (dVar16 < 0.5) {
                  puStack_78 = auStack_298;
                  lStack_80 = lRam00000001038c4c88;
                  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                    func_0x0001003319b0(lRam00000001038c4c88);
                  }
                  uVar6 = (**(code **)(*(long *)*plRam00000001038d5b58 + 0x88))
                                    ((long *)*plRam00000001038d5b58,0xf,0x32);
                  func_0x000100355c5c(puStack_78,uVar6);
                }
                lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                uVar14 = _UNK_10369fa10;
                if (lVar11 != 0) {
                  func_0x000101854aac(lVar11,auStack_298[0]);
                  lVar15 = *(long *)(param_1 + 0x68);
                  lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                  lStack_208 = *(long *)(lVar11 + 0x3d0);
                  uVar14 = _UNK_10369fa28;
                  if (((lStack_208 != 0) && (uVar14 = _UNK_10369fa30, lStack_208 != 0)) &&
                     (uVar14 = _UNK_10369fa38, lVar15 != 0)) {
                    SDV_StardewValley_Menus_MobileColorPicker_setColor_06005df8
                              (lVar15,*(undefined4 *)(lStack_208 + 0x68));
                    lVar15 = *(long *)(param_1 + 0x78);
                    lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                    lStack_200 = *(long *)(lVar11 + 0x3d8);
                    uVar14 = _UNK_10369fa50;
                    if (((lStack_200 != 0) && (uVar14 = _UNK_10369fa58, lStack_200 != 0)) &&
                       (uVar14 = _UNK_10369fa60, lVar15 != 0)) {
                      SDV_StardewValley_Menus_MobileColorPicker_setColor_06005df8
                                (lVar15,*(undefined4 *)(lStack_200 + 0x68));
                      lVar15 = *(long *)(param_1 + 0x70);
                      lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                      lStack_1f8 = *(long *)(lVar11 + 0x3c0);
                      uVar14 = _UNK_10369fa78;
                      if (((lStack_1f8 != 0) && (uVar14 = _UNK_10369fa80, lStack_1f8 != 0)) &&
                         (uVar14 = _UNK_10369fa88, lVar15 != 0)) {
                        SDV_StardewValley_Menus_MobileColorPicker_setColor_06005df8
                                  (lVar15,*(undefined4 *)(lStack_1f8 + 0x68));
                        SDV_StardewValley_Menus_MobileCustomizer_setSliderPositions_06005e0c
                                  (param_1);
                        return;
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
  }
LAB_101e0b680:
  func_0x0001003316f4(0xee,uVar14);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e0b68c);
  (*pcVar2)();
}

