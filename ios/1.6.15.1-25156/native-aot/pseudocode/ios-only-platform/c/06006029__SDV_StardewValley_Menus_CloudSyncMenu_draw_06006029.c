/* 0x06006029 StardewValley.Menus.CloudSyncMenu.draw @ 0x101e6088c */

/* WARNING: Removing unreachable block (ram,0x000101e6143c) */
/* WARNING: Removing unreachable block (ram,0x000101e60cc0) */
/* WARNING: Removing unreachable block (ram,0x000101e610ac) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* WARNING: Restarted to delay deadcode elimination for space: stack */

void SDV_StardewValley_Menus_CloudSyncMenu_draw_06006029
               (undefined1 param_1 [16],float param_2,long param_3,long param_4)

{
  undefined4 *puVar1;
  undefined4 uVar2;
  ulong uVar3;
  ulong uVar4;
  code *pcVar5;
  char cVar6;
  undefined4 uVar7;
  undefined4 uVar8;
  undefined4 uVar9;
  undefined4 uVar10;
  int iVar11;
  long *plVar12;
  int extraout_var;
  long lVar13;
  undefined8 uVar14;
  undefined8 uVar15;
  undefined8 uVar16;
  long lVar17;
  float fVar18;
  float fVar19;
  float fVar20;
  undefined1 auVar21 [16];
  undefined8 uStack_360;
  undefined8 uStack_358;
  undefined8 uStack_350;
  undefined8 uStack_348;
  undefined8 uStack_340;
  undefined8 uStack_338;
  undefined8 uStack_330;
  long lStack_328;
  undefined8 uStack_320;
  undefined8 uStack_318;
  undefined8 uStack_310;
  undefined8 uStack_308;
  undefined8 uStack_300;
  undefined4 uStack_2f8;
  undefined4 uStack_2f4;
  undefined8 uStack_2f0;
  undefined8 uStack_2e8;
  undefined8 uStack_2e0;
  undefined8 uStack_2d8;
  undefined8 uStack_2d0;
  undefined8 *puStack_2c8;
  undefined8 uStack_2c0;
  undefined8 uStack_2b8;
  undefined8 uStack_2b0;
  undefined8 uStack_2a8;
  undefined8 uStack_2a0;
  undefined8 uStack_298;
  undefined4 uStack_290;
  undefined8 *puStack_288;
  undefined8 uStack_280;
  undefined8 uStack_278;
  undefined8 uStack_270;
  undefined8 uStack_268;
  undefined8 uStack_260;
  undefined8 uStack_258;
  undefined4 uStack_250;
  undefined8 *puStack_248;
  int iStack_23c;
  undefined8 *puStack_238;
  undefined8 uStack_230;
  undefined8 uStack_228;
  int iStack_21c;
  undefined8 *puStack_218;
  undefined8 uStack_210;
  undefined8 uStack_208;
  undefined8 uStack_200;
  undefined8 uStack_1f8;
  undefined4 uStack_1f0;
  undefined8 *puStack_1e8;
  int iStack_1dc;
  long lStack_1d8;
  int iStack_1d0;
  int iStack_1cc;
  int iStack_1c8;
  int iStack_1c4;
  float fStack_1c0;
  float fStack_1bc;
  undefined4 uStack_1b8;
  undefined4 uStack_1b4;
  float fStack_1b0;
  float fStack_1ac;
  undefined8 *puStack_1a8;
  undefined8 *puStack_1a0;
  int *piStack_198;
  long lStack_190;
  undefined8 *puStack_188;
  long lStack_180;
  long lStack_178;
  long lStack_170;
  undefined8 uStack_168;
  undefined8 uStack_160;
  undefined8 uStack_158;
  undefined4 uStack_150;
  double dStack_140;
  long lStack_138;
  long lStack_130;
  undefined8 uStack_128;
  undefined8 uStack_120;
  undefined8 uStack_118;
  undefined4 uStack_110;
  double dStack_100;
  long lStack_f8;
  long lStack_f0;
  undefined8 uStack_e8;
  undefined8 uStack_e0;
  undefined8 uStack_d8;
  undefined4 uStack_d0;
  double dStack_c8;
  long lStack_c0;
  long lStack_b8;
  undefined8 uStack_b0;
  undefined8 uStack_a8;
  undefined8 uStack_a0;
  undefined4 uStack_98;
  double dStack_90;
  undefined8 *puStack_88;
  
  cVar6 = cRam0000000103910e38;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar6 == '\0') {
    func_0x00010119b908(&UNK_10331a080);
    cRam0000000103910e38 = '\x01';
  }
  uStack_360 = 0;
  uStack_358 = 0;
  uStack_348 = 0;
  uStack_340 = 0;
  uStack_350 = 0;
  uStack_330 = 0;
  lStack_328 = 0;
  uStack_338 = 0;
  uStack_320 = 0;
  uStack_318 = 0;
  uStack_310 = 0;
  uStack_308 = 0;
  uStack_300 = 0;
  uStack_2f8 = 0;
  uStack_2f4 = 0;
  uStack_2f0 = 0;
  uStack_2e8 = 0;
  fVar18 = (float)StardewValley_StardewValley_Utility_getTopLeftPositionForCenteringOnScreen_06004276
                            (800,0x104,0,0);
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  lVar13 = *(long *)(*plRam00000001038d5630 + 0x18);
  uVar16 = _UNK_1036aa9a0;
  uVar7 = uStack_2f8;
  if (lVar13 != 0) {
    uStack_340 = *(undefined8 *)(lVar13 + 0x1d4);
    uStack_348 = *(undefined8 *)(lVar13 + 0x1cc);
    uStack_350 = *(undefined8 *)(lVar13 + 0x1c4);
    uVar14 = *puRam00000001038d7800;
    auVar21 = func_0x000100355dec(&uStack_350);
    uVar7 = func_0x000100331960();
    uVar8 = func_0x0001003519f4(0x3f19999a,uVar7);
    uVar16 = _UNK_1036aa9a8;
    uVar7 = uStack_2f8;
    if (param_4 != 0) {
      func_0x000100355d38(param_4,uVar14,auVar21._0_8_,auVar21._8_8_,uVar8);
      func_0x00010034ede4(&uStack_360,(int)fVar18 + 0x20,(int)param_2 + -0x37,0x2e0,0x15e);
      uVar4 = uStack_358;
      uVar3 = uStack_360;
      uVar7 = uStack_360._4_4_;
      uVar8 = uStack_358._4_4_;
      uVar9 = func_0x000100331988();
      StardewValley_StardewValley_Menus_IClickableMenu_drawTextureBox_060061a5
                (param_4,uVar3 & 0xffffffff,uVar7,uVar4 & 0xffffffff,uVar8,uVar9);
      plVar12 = (long *)*plRam00000001038d5338;
      uVar16 = _UNK_1036aa9b0;
      uVar7 = uStack_2f8;
      if (plVar12 != (long *)0x0) {
        uVar14 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam0000000103901928);
        lVar13 = *plRam00000001038c4c90;
        uVar16 = _UNK_1036aa9b8;
        uVar7 = uStack_2f8;
        if (lVar13 != 0) {
          fVar20 = 400.0;
          fVar19 = (float)func_0x0001003560e4(lVar13,uVar14);
          func_0x0001003501e4(fVar18 + 400.0,param_2 + 0.0,fVar19 * 0.5,fVar20 * 0.5);
          StardewValley_StardewValley_Utility_drawTextWithShadow_06004232
                    (param_4,uVar14,lVar13,*puRam00000001038d5c70,0xffffffff,0xffffffff,3);
          uVar16 = _UNK_1036aa9c0;
          uVar7 = uStack_2f8;
          if ((param_3 != 0) && (uVar16 = _UNK_1036aa9c8, *(long *)(param_3 + 0x68) != 0)) {
            func_0x00010037744c(&uStack_338);
            while (cVar6 = func_0x000100377460(&uStack_338), lVar13 = lStack_328, cVar6 != '\0') {
              if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                func_0x0001003319b0();
              }
              uVar15 = *puRam00000001038d53d0;
              uStack_2d8 = 0;
              uStack_2d0 = 0;
              func_0x00010034ede4(&uStack_2d8,0x1b0,0x1b7,9,9);
              uVar14 = uStack_2d0;
              uVar16 = uStack_2d8;
              if (((lVar13 == 0) ||
                  (puVar1 = (undefined4 *)(lVar13 + 0x38), puVar1 == (undefined4 *)0x0)) ||
                 (*plRam00000001038d57f8 == 0)) {
LAB_101e60c80:
                func_0x0001003316f4(0xee,_UNK_1036aaaa0);
                    /* WARNING: Does not return */
                pcVar5 = (code *)SoftwareBreakpoint(1,0x101e60c98);
                (*pcVar5)();
              }
              uVar7 = *puVar1;
              uVar9 = *(undefined4 *)(lVar13 + 0x3c);
              uVar8 = *(undefined4 *)(lVar13 + 0x40);
              uVar2 = *(undefined4 *)(lVar13 + 0x44);
              if (*(char *)(*plRam00000001038d57f8 + 0x3c) == '\0') {
                uVar10 = func_0x0001003773ac();
              }
              else {
                uVar10 = func_0x000100331988();
              }
              fVar18 = -1.0;
              StardewValley_StardewValley_Menus_IClickableMenu_drawTextureBox_060061a8
                        (0x40800000,0xbf800000,param_4,uVar15,uVar16,uVar14,uVar7,uVar9,uVar8,uVar2,
                         uVar10,1);
              uVar16 = *(undefined8 *)(lVar13 + 0x18);
              if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                func_0x0001003319b0();
              }
              lVar17 = *plRam00000001038c4c90;
              iVar11 = func_0x00010035034c(puVar1);
              func_0x00010035034c(puVar1);
              if (*plRam00000001038c4c90 == 0) goto LAB_101e60c80;
              fVar20 = (float)func_0x0001003560e4(*plRam00000001038c4c90,
                                                  *(undefined8 *)(lVar13 + 0x18));
              fVar19 = (float)(extraout_var + 4);
              uVar8 = func_0x0001003501e4((float)iVar11,fVar19,fVar20 * 0.5,fVar18 * 0.5);
              uVar7 = *puRam00000001038d5c70;
              if (lRam0000000103976fb8 != 0) {
                func_0x00010119b8f8();
              }
              StardewValley_StardewValley_Utility_drawTextWithShadow_06004232
                        (uVar8,fVar19,0x3f800000,0xbf800000,0,param_4,uVar16,lVar17,uVar7,0xffffffff
                         ,0xffffffff,3);
            }
            uStack_2e0 = 0;
            puStack_2c8 = &uStack_338;
            uVar16 = _UNK_1036aaa98;
            uVar7 = uStack_2f8;
            if (puStack_2c8 != (undefined8 *)0x0) {
              uStack_2e0 = 0;
              func_0x00010034ede4(&uStack_320,0,0xe0,0x2f,0xc);
              func_0x00010034ede4(&uStack_310,(int)uStack_360 + 0x40,(int)param_2 + 0x50,
                                  (int)uStack_358 + -0x80,uStack_318._4_4_ << 2);
              uStack_300 = CONCAT44(uStack_300._4_4_,5);
              lStack_180 = lRam00000001038c4c88;
              lStack_170 = param_4;
              if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                func_0x0001003319b0(lRam00000001038c4c88);
              }
              uStack_168 = *puRam00000001038d5f78;
              uStack_2c0 = 0;
              uStack_2b8 = 0;
              func_0x00010034ede4(&uStack_2c0,uStack_310 & 0xffffffff,uStack_310._4_4_,
                                  (int)uStack_300 << 2,uStack_308._4_4_);
              uVar15 = uStack_2b8;
              uVar14 = uStack_2c0;
              uStack_2b0 = 0;
              uStack_2a8 = 0;
              func_0x00010034ede4(&uStack_2b0,uStack_320 & 0xffffffff,uStack_320._4_4_,
                                  uStack_300 & 0xffffffff,uStack_318._4_4_);
              puStack_288 = &uStack_2a0;
              uStack_2a0 = 0;
              uStack_298 = 0;
              uStack_290 = 0;
              uVar16 = _UNK_1036aaaa8;
              uVar7 = uStack_2f8;
              if ((puStack_288 != (undefined8 *)0x0) &&
                 (uVar16 = _UNK_1036aa9d0, puStack_288 != (undefined8 *)0x0)) {
                    /* WARNING: Ignoring partial resolution of indirect */
                uStack_2a0._0_1_ = 1;
                uStack_158 = 0;
                uStack_160 = uStack_2a0;
                uStack_150 = 0;
                uVar8 = func_0x000100331988();
                dStack_140 = 0.0;
                lStack_178 = lRam00000001038c7e00;
                if (*(char *)(lRam00000001038c7e00 + 0x35) == '\0') {
                  func_0x0001003319b0(lRam00000001038c7e00);
                }
                uVar16 = _UNK_1036aa9d8;
                uVar7 = uStack_2f8;
                if (lStack_170 != 0) {
                  func_0x00010035615c(lStack_170,(float)dStack_140,*puRam00000001038d4510,
                                      puRam00000001038d4510[1],0x3f000000,lStack_170,uStack_168,
                                      uVar14,uVar15,&uStack_160,uVar8,0);
                  uStack_128 = *puRam00000001038d5f78;
                  uStack_280 = 0;
                  uStack_278 = 0;
                  lStack_130 = param_4;
                  func_0x00010034ede4(&uStack_280,(int)uStack_310 + (int)uStack_300 * 4,
                                      uStack_310._4_4_,(int)uStack_308 + (int)uStack_300 * -8,
                                      uStack_308._4_4_);
                  uVar15 = uStack_278;
                  uVar14 = uStack_280;
                  uStack_270 = 0;
                  uStack_268 = 0;
                  func_0x00010034ede4(&uStack_270,(int)uStack_300 + (int)uStack_320,uStack_320._4_4_
                                      ,(int)uStack_318 + (int)uStack_300 * -2,uStack_318._4_4_);
                  puStack_248 = &uStack_260;
                  uStack_260 = 0;
                  uStack_258 = 0;
                  uStack_250 = 0;
                  uVar16 = _UNK_1036aa9e0;
                  uVar7 = uStack_2f8;
                  if ((puStack_248 != (undefined8 *)0x0) &&
                     (uVar16 = _UNK_1036aa9e8, puStack_248 != (undefined8 *)0x0)) {
                    /* WARNING: Ignoring partial resolution of indirect */
                    uStack_260._0_1_ = 1;
                    uStack_118 = 0;
                    uStack_120 = uStack_260;
                    uStack_110 = 0;
                    uVar8 = func_0x000100331988();
                    dStack_100 = 0.0;
                    lStack_138 = lRam00000001038c7e00;
                    if (*(char *)(lRam00000001038c7e00 + 0x35) == '\0') {
                      func_0x0001003319b0(lRam00000001038c7e00);
                    }
                    uVar16 = _UNK_1036aa9f0;
                    uVar7 = uStack_2f8;
                    if (lStack_130 != 0) {
                      func_0x00010035615c(lStack_130,(float)dStack_100,*puRam00000001038d4510,
                                          puRam00000001038d4510[1],0x3f000000,lStack_130,uStack_128,
                                          uVar14,uVar15,&uStack_120,uVar8,0);
                      uStack_e8 = *puRam00000001038d5f78;
                      puStack_238 = &uStack_310;
                      iStack_23c = (int)uStack_308 + (int)uStack_310;
                      uStack_230 = 0;
                      uStack_228 = 0;
                      lStack_f0 = param_4;
                      func_0x00010034ede4(&uStack_230,iStack_23c + (int)uStack_300 * -4,
                                          uStack_310._4_4_,(int)uStack_300 << 2,uStack_308._4_4_);
                      uVar15 = uStack_228;
                      uVar14 = uStack_230;
                      puStack_218 = &uStack_320;
                      iStack_21c = (int)uStack_318 + (int)uStack_320;
                      uStack_210 = 0;
                      uStack_208 = 0;
                      func_0x00010034ede4(&uStack_210,iStack_21c - (int)uStack_300,uStack_320._4_4_,
                                          uStack_300 & 0xffffffff,uStack_318._4_4_);
                      puStack_1e8 = &uStack_200;
                      uStack_200 = 0;
                      uStack_1f8 = 0;
                      uStack_1f0 = 0;
                      uVar16 = _UNK_1036aaa18;
                      uVar7 = uStack_2f8;
                      if ((puStack_1e8 != (undefined8 *)0x0) &&
                         (uVar16 = _UNK_1036aaa20, puStack_1e8 != (undefined8 *)0x0)) {
                    /* WARNING: Ignoring partial resolution of indirect */
                        uStack_200._0_1_ = 1;
                        uStack_d8 = 0;
                        uStack_e0 = uStack_200;
                        uStack_d0 = 0;
                        uVar8 = func_0x000100331988();
                        dStack_c8 = 0.0;
                        lStack_f8 = lRam00000001038c7e00;
                        if (*(char *)(lRam00000001038c7e00 + 0x35) == '\0') {
                          func_0x0001003319b0(lRam00000001038c7e00);
                        }
                        uVar16 = _UNK_1036aaa28;
                        uVar7 = uStack_2f8;
                        if (lStack_f0 != 0) {
                          func_0x00010035615c(lStack_f0,(float)dStack_c8,*puRam00000001038d4510,
                                              puRam00000001038d4510[1],0x3f000000,lStack_f0,
                                              uStack_e8,uVar14,uVar15,&uStack_e0,uVar8,0);
                          lStack_1d8 = *plRam00000001038d57f8;
                          uVar16 = _UNK_1036aaa30;
                          uVar7 = uStack_2f8;
                          if (lStack_1d8 != 0) {
                            iStack_1cc = (int)*(float *)(lStack_1d8 + 0x38);
                            iStack_1c4 = 100;
                            iStack_1c8 = 0;
                            iStack_1dc = iStack_1c8;
                            if ((-1 < iStack_1cc) && (iStack_1dc = iStack_1cc, 100 < iStack_1cc)) {
                              iStack_1dc = iStack_1c4;
                            }
                            uStack_1b8 = 0;
                            uStack_1b4 = 0x3f800000;
                            fStack_1b0 = (float)iStack_1dc / 100.0;
                            if (1.0 < fStack_1b0) {
                              fStack_1b0 = 1.0;
                            }
                            fStack_1c0 = fStack_1b0;
                            if (fStack_1b0 < 0.0) {
                              fStack_1c0 = 0.0;
                            }
                            puStack_1a8 = &uStack_310;
                            uStack_2f8 = 3;
                            uVar7 = uStack_2f8;
                            uStack_2f8 = 3;
                            uStack_2f4 = 3;
                            uStack_300 = CONCAT44(fStack_1c0,(int)uStack_300);
                            uVar16 = _UNK_1036aaa48;
                            iStack_1d0 = iStack_1dc;
                            fStack_1bc = fStack_1c0;
                            fStack_1ac = fStack_1c0;
                            if (puStack_1a8 != (undefined8 *)0x0) {
                              puStack_1a0 = &uStack_308;
                    /* WARNING: Ignoring partial resolution of indirect */
                              uStack_310._0_4_ = (int)uStack_310 + 0xc;
                              uVar16 = _UNK_1036aaa58;
                              uVar7 = uStack_2f8;
                              if (puStack_1a0 != (undefined8 *)0x0) {
                                piStack_198 = (int *)((ulong)&uStack_310 | 4);
                                iVar11 = uStack_308._4_4_;
                    /* WARNING: Ignoring partial resolution of indirect */
                                uStack_308._0_4_ = (int)uStack_308 + -0x18;
                                uVar16 = _UNK_1036aaa68;
                                if (piStack_198 != (int *)0x0) {
                                  lStack_190 = (long)&uStack_308 + 4;
                                  *piStack_198 = *piStack_198 + 0xc;
                                  uVar16 = _UNK_1036aaa78;
                                  if (lStack_190 != 0) {
                    /* WARNING: Ignoring partial resolution of indirect */
                                    uStack_308._4_4_ = iVar11 + -0x18;
                                    func_0x00010034ede4(&uStack_2f0,uStack_310 & 0xffffffff,
                                                        uStack_310._4_4_,
                                                        (int)(fStack_1c0 * (float)(int)uStack_308) +
                                                        -4,uStack_308._4_4_);
                                    uVar15 = uStack_2e8;
                                    uVar14 = uStack_2f0;
                                    uStack_b0 = *puRam00000001038d77a8;
                                    uStack_a0 = 0;
                                    uStack_a8 = 0;
                                    uStack_98 = 0;
                                    lStack_b8 = param_4;
                                    uVar8 = func_0x000100356044();
                                    dStack_90 = 0.0;
                                    lStack_c0 = lRam00000001038c7e00;
                                    if (*(char *)(lRam00000001038c7e00 + 0x35) == '\0') {
                                      func_0x0001003319b0(lRam00000001038c7e00);
                                    }
                                    uVar16 = _UNK_1036aaa80;
                                    uVar7 = uStack_2f8;
                                    if ((lStack_b8 != 0) &&
                                       (func_0x00010035615c(lStack_b8,(float)dStack_90,
                                                            *puRam00000001038d4510,
                                                            puRam00000001038d4510[1],
                                                            (float)uStack_2f0._4_4_ / 10000.0,
                                                            lStack_b8,uStack_b0,uVar14,uVar15,
                                                            &uStack_a8,uVar8,0),
                                       uVar16 = _UNK_1036aaa88, uVar7 = uStack_2f8,
                                       *plRam00000001038d57f8 != 0)) {
                                      cVar6 = SDV_StardewValley_CloudSync_get_IsSyncing_060032d7();
                                      if (cVar6 == '\0') {
                                        puStack_188 = (undefined8 *)
                                                                                                            
                                                  SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1
                                                            ();
                                        puStack_88 = puStack_188;
                                        if ((puStack_188 != (undefined8 *)0x0) &&
                                           (lRam00000001038d67d8 !=
                                            *(long *)(*(long *)(*(long *)*puStack_188 + 0x10) + 0x10
                                                     ))) {
                                          puStack_88 = (undefined8 *)0x0;
                                        }
                                        if (puStack_88 == (undefined8 *)0x0) {
                                          puStack_88 = (undefined8 *)0x0;
                                          uVar16 = _UNK_1036aaa90;
                                          uVar7 = uStack_2f8;
                                          goto LAB_101e61578;
                                        }
                                        StardewValley_StardewValley_Menus_TitleMenu_backButtonPressed_06006598
                                                  ();
                                      }
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
              }
            }
          }
        }
      }
    }
  }
LAB_101e61578:
  uStack_2f8 = uVar7;
  func_0x0001003316f4(0xee,uVar16);
                    /* WARNING: Does not return */
  pcVar5 = (code *)SoftwareBreakpoint(1,0x101e61584);
  (*pcVar5)();
}

