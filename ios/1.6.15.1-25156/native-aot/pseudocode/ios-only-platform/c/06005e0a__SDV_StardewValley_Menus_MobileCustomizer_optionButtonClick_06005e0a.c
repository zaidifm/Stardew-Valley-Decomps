/* 0x06005e0a StardewValley.Menus.MobileCustomizer.optionButtonClick @ 0x101e0e0a0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer_optionButtonClick_06005e0a
               (long param_1,undefined8 param_2)

{
  undefined4 uVar1;
  undefined4 uVar2;
  undefined4 uVar3;
  undefined4 uVar4;
  undefined4 uVar5;
  undefined1 uVar6;
  code *pcVar7;
  char cVar8;
  int iVar9;
  long lVar10;
  long *plVar11;
  undefined8 uVar12;
  long *plVar13;
  undefined8 *puVar14;
  undefined8 uVar15;
  uint uVar16;
  long lVar17;
  
  cVar8 = cRam0000000103910c19;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103910c19 == '\0') goto LAB_101e0e61c;
LAB_101e0e0d8:
    iVar9 = *(int *)(param_1 + 500);
  }
  else {
    func_0x00010119b8f8();
    if (cVar8 != '\0') goto LAB_101e0e0d8;
LAB_101e0e61c:
    func_0x00010119b908(&UNK_103316f90);
    cRam0000000103910c19 = '\x01';
    iVar9 = *(int *)(param_1 + 500);
  }
  if (iVar9 < 0) {
    *(undefined4 *)(param_1 + 500) = 0;
  }
  cVar8 = func_0x000100345aa0(param_2,uRam00000001038c97f8);
  if (cVar8 == '\0') {
    cVar8 = func_0x000100345aa0(param_2,uRam00000001038c9800);
    if (cVar8 == '\0') {
      cVar8 = func_0x000100345aa0(param_2,uRam00000001038c6620);
      if (cVar8 == '\0') {
        cVar8 = func_0x000100345aa0(param_2,uRam00000001038c6640);
        if (cVar8 == '\0') {
          cVar8 = func_0x000100345aa0(param_2,uRam00000001039004f0);
          if (cVar8 != '\0') {
            cVar8 = SDV_StardewValley_Menus_MobileCustomizer_canLeaveMenu_06005e12(param_1);
            if (cVar8 == '\0') {
              return;
            }
            if (*(long *)(param_1 + 0x1b0) != 0) {
              lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
              uVar15 = _UNK_1036a0448;
              if (lVar10 == 0) goto LAB_101e0e8fc;
              cVar8 = StardewValley_StardewValley_Farmer_IsEquippedItem_0600362e
                                (lVar10,*(undefined8 *)(param_1 + 0x1b0));
              if (cVar8 == '\0') {
                StardewValley_StardewValley_Utility_CollectOrDrop_060041a3
                          (*(undefined8 *)(param_1 + 0x1b0));
              }
              *(undefined8 *)(param_1 + 0x1b0) = 0;
            }
            if (*(int *)(param_1 + 0x1ec) != 5) {
              lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
              plVar11 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
              uVar15 = _UNK_1036a0290;
              if ((((*(long *)(param_1 + 0xe0) != 0) &&
                   (uVar15 = _UNK_1036a0298, *(long *)(*(long *)(param_1 + 0xe0) + 0x28) != 0)) &&
                  (uVar12 = func_0x000100352124(), uVar15 = _UNK_1036a02a0, plVar11 != (long *)0x0))
                 && (uVar12 = (**(code **)(*plVar11 + -0x78))(plVar11,uVar12),
                    uVar15 = _UNK_1036a02a8, lVar10 != 0)) {
                StardewValley_StardewValley_Character_set_Name_0600325d(lVar10,uVar12);
                plVar11 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
                plVar13 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
                lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                uVar15 = _UNK_1036a02b8;
                if ((*(long *)(lVar10 + 0x58) != 0) &&
                   (uVar12 = (**(code **)(*plVar13 + -0x78))
                                       (plVar13,*(undefined8 *)(*(long *)(lVar10 + 0x58) + 0x60)),
                   uVar15 = _UNK_1036a02c8, plVar11 != (long *)0x0)) {
                  (**(code **)(*plVar11 + 0x208))(plVar11,uVar12);
                  lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                  lVar10 = *(long *)(lVar10 + 0x2a8);
                  plVar11 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
                  uVar15 = _UNK_1036a02d8;
                  if (((*(long *)(param_1 + 0xf0) != 0) &&
                      ((uVar15 = _UNK_1036a02e0, *(long *)(*(long *)(param_1 + 0xf0) + 0x28) != 0 &&
                       (uVar12 = func_0x000100352124(), uVar15 = _UNK_1036a02e8,
                       plVar11 != (long *)0x0)))) &&
                     (uVar12 = (**(code **)(*plVar11 + -0x78))(plVar11,uVar12),
                     uVar15 = _UNK_1036a02f0, lVar10 != 0)) {
                    func_0x000100354118(lVar10,uVar12);
                    lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                    uVar15 = _UNK_1036a0300;
                    if (*(long *)(lVar10 + 0x680) != 0) {
                      func_0x00010035197c(*(long *)(lVar10 + 0x680),1);
                      if (*(long *)(param_1 + 0xe8) != 0) {
                        lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                        uVar15 = _UNK_1036a03e8;
                        if ((lVar10 == 0) ||
                           (lVar17 = *(long *)(*(long *)(param_1 + 0xe8) + 0x28),
                           uVar15 = _UNK_1036a03f8, lVar17 == 0)) goto LAB_101e0e8fc;
                        lVar10 = *(long *)(lVar10 + 0x2a0);
                        uVar12 = func_0x000100352124(lVar17);
                        uVar15 = _UNK_1036a0400;
                        if (lVar10 == 0) goto LAB_101e0e8fc;
                        func_0x000100354118(lVar10,uVar12);
                        lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                        if (0xf < *(int *)(*(long *)(*(long *)(lVar10 + 0x2a0) + 0x60) + 0x10)) {
                          lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                          lVar17 = *(long *)(lVar10 + 0x2a0);
                          lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                          lVar10 = *(long *)(*(long *)(lVar10 + 0x2a0) + 0x60);
                          uVar15 = _UNK_1036a0438;
                          if ((lVar10 == 0) ||
                             (uVar12 = func_0x00010035629c(lVar10,0,0xf), uVar15 = _UNK_1036a0440,
                             lVar17 == 0)) goto LAB_101e0e8fc;
                          func_0x000100354118(lVar17,uVar12);
                        }
                      }
                      lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                      if (0xf < *(int *)(*(long *)(*(long *)(lVar10 + 0x58) + 0x60) + 0x10)) {
                        lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                        lVar17 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                        lVar17 = *(long *)(*(long *)(lVar17 + 0x58) + 0x60);
                        uVar15 = _UNK_1036a03d8;
                        if ((lVar17 == 0) ||
                           (uVar12 = func_0x00010035629c(lVar17,0,0xf), uVar15 = _UNK_1036a03e0,
                           lVar10 == 0)) goto LAB_101e0e8fc;
                        StardewValley_StardewValley_Character_set_Name_0600325d(lVar10,uVar12);
                      }
                      lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                      if (0xf < *(int *)(*(long *)(*(long *)(lVar10 + 0x2a8) + 0x60) + 0x10)) {
                        lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                        lVar17 = *(long *)(lVar10 + 0x2a8);
                        lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                        lVar10 = *(long *)(*(long *)(lVar10 + 0x2a8) + 0x60);
                        uVar15 = _UNK_1036a03b8;
                        if ((lVar10 == 0) ||
                           (uVar12 = func_0x00010035629c(lVar10,0,0xf), uVar15 = _UNK_1036a03c0,
                           lVar17 == 0)) goto LAB_101e0e8fc;
                        func_0x000100354118(lVar17,uVar12);
                      }
                      uVar16 = *(uint *)(param_1 + 0x1ec);
                      if (uVar16 == 3) {
                        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                          func_0x0001003319b0();
                        }
                        *puRam00000001038d57d0 = 2;
                        uVar16 = *(uint *)(param_1 + 0x1ec);
                      }
                      if ((uVar16 < 7) && ((1 << (ulong)(uVar16 & 0x1f) & 100U) != 0)) {
                        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                          func_0x0001003319b0();
                        }
                        *puRam00000001038d59c8 = 0x3f800000;
                        StardewValley_StardewValley_Game1_playSound_0600301b(uRam00000001038e2988,0)
                        ;
                        StardewValley_StardewValley_Game1_exitActiveMenu_06003073();
                        lVar10 = StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
                        if (((lVar10 == 0) ||
                            (puVar14 = (undefined8 *)
                                       StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3
                                                 (), puVar14 == (undefined8 *)0x0)) ||
                           (lRam00000001038d54e8 !=
                            *(long *)(*(long *)(*(long *)*puVar14 + 0x10) + 8))) goto LAB_101e0e1dc;
                        puVar14 = (undefined8 *)
                                  StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
                        uVar15 = _UNK_1036a0338;
                        if ((puVar14 == (undefined8 *)0x0) ||
                           (lRam00000001038d54e8 !=
                            *(long *)(*(long *)(*(long *)*puVar14 + 0x10) + 8))) goto LAB_101e0e8fc;
                      }
                      else if (*(long *)(param_1 + 0x1a0) == 0) {
                        puVar14 = (undefined8 *)
                                  SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1();
                        if ((puVar14 != (undefined8 *)0x0) &&
                           (lRam00000001038d67d8 ==
                            *(long *)(*(long *)(*(long *)*puVar14 + 0x10) + 0x10))) {
                          uVar1 = *(undefined4 *)(param_1 + 0x50);
                          uVar3 = *(undefined4 *)(param_1 + 0x54);
                          uVar2 = *(undefined4 *)(param_1 + 0x58);
                          uVar4 = *(undefined4 *)(param_1 + 0x5c);
                          uVar5 = *(undefined4 *)(param_1 + 0x1ec);
                          uVar6 = *(undefined1 *)(param_1 + 0x1e8);
                          uVar15 = func_0x000100331820(uRam0000000103900550,0x200);
                          SDV_StardewValley_Menus_MobileFarmChooser__ctor_06005e1f
                                    (uVar15,uVar1,uVar3,uVar2,uVar4,uVar5,1,uVar6);
                          StardewValley_StardewValley_Menus_TitleMenu_set_subMenu_06006581(uVar15);
                          goto LAB_101e0e1dc;
                        }
                        lVar10 = SDV_StardewValley_Menus_TutorialManager_get_Instance_06005e62();
                        uVar15 = _UNK_1036a0340;
                        if (lVar10 == 0) goto LAB_101e0e8fc;
                        SDV_StardewValley_Menus_TutorialManager_completeTutorial_06005e74
                                  (lVar10,0x2c);
                        StardewValley_StardewValley_Game1_exitActiveMenu_06003073();
                        lVar10 = StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
                        if (((lVar10 == 0) ||
                            (puVar14 = (undefined8 *)
                                       StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3
                                                 (), puVar14 == (undefined8 *)0x0)) ||
                           (lRam00000001038d54e8 !=
                            *(long *)(*(long *)(*(long *)*puVar14 + 0x10) + 8))) goto LAB_101e0e1dc;
                        puVar14 = (undefined8 *)
                                  StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
                        uVar15 = _UNK_1036a0348;
                        if ((puVar14 == (undefined8 *)0x0) ||
                           (lRam00000001038d54e8 !=
                            *(long *)(*(long *)(*(long *)*puVar14 + 0x10) + 8))) goto LAB_101e0e8fc;
                      }
                      else {
                        lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                        uVar15 = _UNK_1036a0350;
                        if (((*(long *)(param_1 + 0xe0) == 0) ||
                            (uVar15 = _UNK_1036a0358,
                            *(long *)(*(long *)(param_1 + 0xe0) + 0x28) == 0)) ||
                           (uVar12 = func_0x000100352124(), uVar15 = _UNK_1036a0360, lVar10 == 0))
                        goto LAB_101e0e8fc;
                        StardewValley_StardewValley_Character_set_Name_0600325d(lVar10,uVar12);
                        lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                        uVar15 = _UNK_1036a0368;
                        if ((lVar10 == 0) ||
                           (lVar17 = *(long *)(*(long *)(param_1 + 0xe8) + 0x28),
                           uVar15 = _UNK_1036a0378, lVar17 == 0)) goto LAB_101e0e8fc;
                        lVar10 = *(long *)(lVar10 + 0x2a0);
                        uVar12 = func_0x000100352124(lVar17);
                        uVar15 = _UNK_1036a0380;
                        if (lVar10 == 0) goto LAB_101e0e8fc;
                        func_0x000100354118(lVar10,uVar12);
                        lVar10 = SDV_StardewValley_Menus_TutorialManager_get_Instance_06005e62();
                        uVar15 = _UNK_1036a0388;
                        if (lVar10 == 0) goto LAB_101e0e8fc;
                        SDV_StardewValley_Menus_TutorialManager_completeTutorial_06005e74
                                  (lVar10,0x2c);
                        puVar14 = (undefined8 *)
                                  SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1();
                        if ((puVar14 != (undefined8 *)0x0) &&
                           (lRam00000001038d67d8 ==
                            *(long *)(*(long *)(*(long *)*puVar14 + 0x10) + 0x10))) {
                          puVar14 = (undefined8 *)
                                    SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1();
                          uVar15 = _UNK_1036a0398;
                          if ((puVar14 == (undefined8 *)0x0) ||
                             (lRam00000001038d67d8 !=
                              *(long *)(*(long *)(*(long *)*puVar14 + 0x10) + 0x10)))
                          goto LAB_101e0e8fc;
                          StardewValley_StardewValley_Menus_TitleMenu_createdNewCharacter_060065a0
                                    (puVar14,*(undefined1 *)(param_1 + 0x1e8));
                          goto LAB_101e0e1dc;
                        }
                        StardewValley_StardewValley_Game1_exitActiveMenu_06003073();
                        lVar10 = StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
                        if ((lVar10 == 0) ||
                           ((puVar14 = (undefined8 *)
                                       StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3
                                                 (), puVar14 == (undefined8 *)0x0 ||
                            (lRam00000001038d54e8 !=
                             *(long *)(*(long *)(*(long *)*puVar14 + 0x10) + 8)))))
                        goto LAB_101e0e1dc;
                        puVar14 = (undefined8 *)
                                  StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
                        uVar15 = _UNK_1036a0390;
                        if ((puVar14 == (undefined8 *)0x0) ||
                           (lRam00000001038d54e8 !=
                            *(long *)(*(long *)(*(long *)*puVar14 + 0x10) + 8))) goto LAB_101e0e8fc;
                      }
                      StardewValley_StardewValley_Minigames_Intro_doneCreatingCharacter_06005094();
                      goto LAB_101e0e1dc;
                    }
                  }
                }
              }
              goto LAB_101e0e8fc;
            }
            StardewValley_StardewValley_Game1_exitActiveMenu_06003073();
          }
          goto LAB_101e0e1dc;
        }
        if ((*(int *)(param_1 + 0x1ec) != 0) && (*(int *)(param_1 + 0x1ec) != 3))
        goto LAB_101e0e1dc;
        lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar15 = _UNK_1036a0288;
        lVar17 = lRam00000001038c4be0;
        uVar12 = uRam00000001038c6640;
      }
      else {
        if ((*(int *)(param_1 + 0x1ec) != 0) && (*(int *)(param_1 + 0x1ec) != 3))
        goto LAB_101e0e1dc;
        lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar15 = _UNK_1036a0280;
        lVar17 = lRam00000001038c4be0;
        uVar12 = uRam00000001038c6620;
      }
      lRam00000001038c4be0 = lVar17;
      if (lVar10 == 0) goto LAB_101e0e8fc;
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lVar10 + 800) = uVar12;
      *(undefined1 *)((lVar10 + 800U >> 9 & 0x7fffff) + lVar17) = 1;
      goto LAB_101e0e1dc;
    }
    if (*(int *)(param_1 + 0x1ec) - 5U < 2) goto LAB_101e0e1dc;
    lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar15 = _UNK_1036a0258;
    if (lVar10 == 0) goto LAB_101e0e8fc;
    StardewValley_StardewValley_Farmer_changeGender_06003667(lVar10,0);
    lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar15 = _UNK_1036a0260;
    if (lVar10 == 0) goto LAB_101e0e8fc;
    StardewValley_StardewValley_Farmer_changeHairStyle_0600365b(lVar10,0x10);
    lVar10 = *(long *)(param_1 + 0x160);
    iVar9 = SDV_StardewValley_Menus_MobileCustomizer_GetCurrentHairIndex_06005e0f();
    lVar17 = *(long *)(param_1 + 0x178);
    uVar16 = *(uint *)(lVar17 + 0x18);
    uVar12 = _UNK_1036a0270;
    uVar15 = _UNK_1036a0278;
  }
  else {
    if (*(int *)(param_1 + 0x1ec) - 5U < 2) goto LAB_101e0e1dc;
    lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar15 = _UNK_1036a0230;
    if (lVar10 == 0) goto LAB_101e0e8fc;
    StardewValley_StardewValley_Farmer_changeGender_06003667(lVar10,1);
    lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar15 = _UNK_1036a0238;
    if (lVar10 == 0) goto LAB_101e0e8fc;
    StardewValley_StardewValley_Farmer_changeHairStyle_0600365b(lVar10,0);
    lVar10 = *(long *)(param_1 + 0x160);
    iVar9 = SDV_StardewValley_Menus_MobileCustomizer_GetCurrentHairIndex_06005e0f();
    lVar17 = *(long *)(param_1 + 0x178);
    uVar16 = *(uint *)(lVar17 + 0x18);
    uVar12 = _UNK_1036a0248;
    uVar15 = _UNK_1036a0250;
  }
  if (uVar16 < 2) {
    func_0x0001003316f4(0xcc,uVar12);
                    /* WARNING: Does not return */
    pcVar7 = (code *)SoftwareBreakpoint(1,0x101e0e8dc);
    (*pcVar7)();
  }
  if (lVar10 == 0) {
LAB_101e0e8fc:
    func_0x0001003316f4(0xee,uVar15);
                    /* WARNING: Does not return */
    pcVar7 = (code *)SoftwareBreakpoint(1,0x101e0e908);
    (*pcVar7)();
  }
  *(int *)(lVar10 + 0x10) = (int)(((float)iVar9 * 100.0) / (float)*(int *)(lVar17 + 0x24));
LAB_101e0e1dc:
  StardewValley_StardewValley_Game1_playSound_0600301b(uRam00000001038dfd20,0);
  return;
}

