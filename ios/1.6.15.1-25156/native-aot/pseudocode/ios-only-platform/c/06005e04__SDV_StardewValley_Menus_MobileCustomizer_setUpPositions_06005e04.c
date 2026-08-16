/* 0x06005e04 StardewValley.Menus.MobileCustomizer.setUpPositions @ 0x101e07e94 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer_setUpPositions_06005e04(long param_1)

{
  int iVar1;
  int iVar2;
  int iVar3;
  int iVar4;
  int iVar5;
  int iVar6;
  uint uVar7;
  int iVar8;
  long lVar9;
  char cVar10;
  code *pcVar11;
  undefined4 uVar12;
  int iVar13;
  undefined8 uVar14;
  long *plVar15;
  undefined8 uVar16;
  undefined8 uVar17;
  int iVar18;
  long lVar19;
  long *plVar20;
  uint uVar21;
  undefined8 uVar22;
  undefined8 uVar23;
  long lVar24;
  undefined8 uVar25;
  float fVar26;
  float fVar27;
  float fVar28;
  uint uStack_2e4;
  undefined8 uStack_2e0;
  undefined8 uStack_2d8;
  undefined8 uStack_2d0;
  undefined8 uStack_2c8;
  undefined8 uStack_2c0;
  undefined8 uStack_2b8;
  undefined8 uStack_2b0;
  undefined8 uStack_2a8;
  undefined8 uStack_2a0;
  undefined8 uStack_298;
  undefined8 uStack_290;
  undefined8 uStack_288;
  undefined8 uStack_280;
  undefined8 uStack_278;
  undefined8 uStack_270;
  undefined8 uStack_268;
  undefined8 uStack_260;
  undefined8 uStack_258;
  undefined8 uStack_250;
  undefined8 uStack_248;
  undefined8 uStack_240;
  undefined8 uStack_238;
  undefined8 uStack_230;
  undefined8 uStack_228;
  undefined8 uStack_220;
  undefined8 uStack_218;
  undefined8 uStack_210;
  undefined8 uStack_208;
  undefined8 uStack_200;
  undefined8 uStack_1f8;
  undefined8 uStack_1f0;
  undefined8 uStack_1e8;
  undefined8 uStack_1e0;
  undefined8 uStack_1d8;
  undefined8 uStack_1d0;
  undefined8 uStack_1c8;
  undefined8 uStack_1c0;
  undefined8 uStack_1b8;
  undefined8 uStack_1b0;
  undefined8 uStack_1a8;
  undefined8 uStack_1a0;
  undefined8 uStack_198;
  undefined8 uStack_190;
  undefined8 uStack_188;
  undefined8 uStack_180;
  undefined8 uStack_178;
  undefined8 uStack_170;
  undefined8 uStack_168;
  undefined8 uStack_160;
  undefined8 uStack_158;
  undefined8 uStack_150;
  undefined8 uStack_148;
  undefined8 uStack_140;
  undefined8 uStack_138;
  undefined8 uStack_130;
  undefined8 uStack_128;
  undefined8 uStack_120;
  undefined8 uStack_118;
  undefined8 uStack_110;
  undefined8 uStack_108;
  undefined8 uStack_100;
  undefined8 uStack_f8;
  undefined8 uStack_f0;
  undefined8 uStack_e8;
  undefined8 uStack_e0;
  undefined8 uStack_d8;
  undefined8 uStack_d0;
  undefined8 uStack_c8;
  undefined8 uStack_c0;
  undefined8 uStack_b8;
  undefined8 uStack_b0;
  undefined8 uStack_a8;
  undefined8 uStack_a0;
  undefined8 uStack_98;
  undefined8 uStack_90;
  undefined8 uStack_88;
  undefined8 uStack_80;
  undefined8 uStack_78;
  
  cVar10 = cRam0000000103910c13;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar10 == '\0') {
    func_0x00010119b908(&UNK_103316d70);
    cRam0000000103910c13 = '\x01';
  }
  uStack_2e4 = 0;
  iVar18 = *(int *)(param_1 + 0x1f0);
  uVar14 = _UNK_10369f220;
  if (iVar18 != 0) {
    iVar13 = *(int *)(param_1 + 0x58) + -0x20;
    if ((iVar18 == -1) && (iVar13 == -0x80000000)) {
      func_0x0001003316f4(0x101,_UNK_10369f5e0);
                    /* WARNING: Does not return */
      pcVar11 = (code *)SoftwareBreakpoint(1,0x101e0a614);
      (*pcVar11)();
    }
    iVar1 = *(int *)(param_1 + 0x50);
    iVar2 = *(int *)(param_1 + 0x54);
    fVar28 = *(float *)(param_1 + 0x204);
    uVar14 = func_0x000100331794(uRam00000001038c4dc0,5);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x180) = uVar14;
    lVar9 = lRam00000001038c4be0;
    *(undefined1 *)((param_1 + 0x180U >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    lVar19 = *(long *)(param_1 + 0x180);
    uStack_2e4 = 0;
    uVar14 = _UNK_10369f238;
    if (lVar19 != 0) {
      uVar21 = 0;
      iVar8 = 0;
      if (iVar18 != 0) {
        iVar8 = iVar13 / iVar18;
      }
LAB_101e07f8c:
      do {
        if ((int)*(uint *)(lVar19 + 0x18) <= (int)uVar21) {
          uVar21 = *(uint *)(param_1 + 0x1ec);
          if (uVar21 == 1) {
            StardewValley_StardewValley_Menus_IClickableMenu_initializeUpperRightCloseButton_06006182
                      (param_1);
            uVar21 = *(uint *)(param_1 + 0x1ec);
            *(undefined8 *)(param_1 + 0x38) = 0;
          }
          if (uVar21 < 7) {
            uVar7 = 1 << (ulong)(uVar21 & 0x1f);
            if ((uVar7 & 100) == 0) {
              if ((uVar7 & 9) == 0) goto LAB_101e09ec0;
              iVar18 = 0x10;
              if (uVar21 != 0) {
                iVar18 = 0xb4;
              }
              if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                func_0x0001003319b0();
              }
              uStack_280 = 0;
              uStack_278 = 0;
              func_0x00010034ede4(&uStack_280,
                                  *piRam00000001038d57b0 +
                                  (int)(*(float *)(param_1 + 0x200) * (float)iVar18) + 0x10,
                                  *(int *)(param_1 + 0x54) +
                                  (int)(*(float *)(param_1 + 0x204) * 72.0),0x118,0x140);
              *(undefined8 *)(param_1 + 0x210) = uStack_278;
              *(undefined8 *)(param_1 + 0x208) = uStack_280;
              uVar14 = _UNK_10369f228;
              if ((undefined8 *)(param_1 + 0x208) == (undefined8 *)0x0) break;
              iVar4 = *(int *)(param_1 + 0x210);
              iVar18 = iVar4 + 0x3c;
              iVar13 = iVar4 + -0x7f;
              if (-1 < iVar4 + -0x80) {
                iVar13 = iVar4 + -0x80;
              }
              iVar5 = iVar4 + *(int *)(param_1 + 0x208) + 0x10;
              *(float *)(param_1 + 0x270) = (float)(*(int *)(param_1 + 0x20c) + 0x20);
              *(float *)(param_1 + 0x26c) = (float)(*(int *)(param_1 + 0x208) + (iVar13 >> 1));
              if (*(int *)(param_1 + 0x1ec) == 0) {
                fVar26 = *(float *)(param_1 + 0x204);
                iVar13 = *(int *)(param_1 + 0x54);
                iVar3 = *(int *)(param_1 + 0x58);
                if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                  func_0x0001003319b0();
                  uVar12 = *(undefined4 *)(param_1 + 0x1ec);
                }
                else {
                  uVar12 = 0;
                }
                iVar6 = *piRam00000001038d57b0;
                uVar14 = func_0x000100331820(uRam0000000103900550,0x200);
                SDV_StardewValley_Menus_MobileFarmChooser__ctor_06005e1f
                          (uVar14,iVar5 + iVar18 + 0x10,iVar13 + (int)(fVar26 * 72.0),
                           (iVar3 - (iVar5 + iVar18)) + iVar6 + -0x34,0x140,uVar12,0,0);
                DataMemoryBarrier(2,3);
                *(undefined8 *)(param_1 + 0x1a0) = uVar14;
                *(undefined1 *)((param_1 + 0x1a0U >> 9 & 0x7fffff) + lVar9) = 1;
              }
              uVar14 = _UNK_10369f598;
              if (param_1 == -0x26c) break;
              iVar6 = *(int *)(param_1 + 0x208);
              iVar3 = *(int *)(param_1 + 0x210);
              fVar27 = *(float *)(param_1 + 0x204);
              fVar26 = *(float *)(param_1 + 0x270) + 78.0;
              iVar13 = iVar6 + iVar3;
              *(float *)(param_1 + 0x280) = fVar26;
              *(float *)(param_1 + 0x288) = fVar26;
              *(float *)(param_1 + 0x27c) = (float)(iVar6 + 0x20);
              *(float *)(param_1 + 0x29c) = (float)(int)(*(float *)(param_1 + 0x26c) + -4.0);
              if (iVar3 < 0) {
                iVar3 = iVar3 + 1;
              }
              fVar26 = (float)(int)(*(float *)(param_1 + 0x270) + 192.0 + 16.0);
              *(float *)(param_1 + 0x2a4) = (float)(int)(*(float *)(param_1 + 0x26c) + 64.0 + 4.0);
              *(float *)(param_1 + 0x284) = (float)(iVar13 + -0x40);
              *(float *)(param_1 + 0x2a0) = fVar26;
              *(float *)(param_1 + 0x2a8) = fVar26;
              *(float *)(param_1 + 0x278) = fVar27 * 32.0 + (float)*(int *)(param_1 + 0x54);
              *(float *)(param_1 + 0x274) = (float)(iVar6 + (iVar3 >> 1) + -0x1e);
              uStack_270 = 0;
              uStack_268 = 0;
              func_0x00010034ede4(&uStack_270,
                                  *(int *)(param_1 + 0x50) +
                                  (int)(*(float *)(param_1 + 0x200) * 148.0),
                                  *(int *)(param_1 + 0x54) + (int)(fVar27 * 582.0),
                                  *(int *)(param_1 + 0x58) -
                                  (int)(*(float *)(param_1 + 0x200) * 296.0),(int)(fVar27 * 100.0));
              lVar19 = lRam00000001038c4c88;
              *(undefined8 *)(param_1 + 0x250) = uStack_268;
              *(undefined8 *)(param_1 + 0x248) = uStack_270;
              if (*(char *)(lVar19 + 0x35) == '\0') {
                func_0x0001003319b0();
              }
              plVar20 = (long *)*plRam00000001038d5338;
              uVar14 = _UNK_10369f5a0;
              if (plVar20 == (long *)0x0) break;
              uVar14 = (**(code **)(*plVar20 + 0x100))(plVar20,uRam0000000103900548);
              DataMemoryBarrier(2,3);
              *(undefined8 *)(param_1 + 0x150) = uVar14;
              *(undefined1 *)((param_1 + 0x150U >> 9 & 0x7fffff) + lVar9) = 1;
              uVar14 = _UNK_10369f5a8;
              if (*plRam00000001038c4c90 == 0) break;
              fVar26 = (float)func_0x0001003560e4(*plRam00000001038c4c90,
                                                  *(undefined8 *)(param_1 + 0x150));
              *(int *)(param_1 + 0x268) = (int)fVar26;
              uVar14 = _UNK_10369f5b0;
              if ((undefined8 *)(param_1 + 0x248) == (undefined8 *)0x0) break;
              iVar3 = *(int *)(param_1 + 0x254) + -0x50;
              iVar13 = *(int *)(param_1 + 0x254) + -0x4f;
              if (-1 < iVar3) {
                iVar13 = iVar3;
              }
              uStack_260 = 0;
              uStack_258 = 0;
              func_0x00010034ede4(&uStack_260,
                                  *(int *)(param_1 + 0x250) + *(int *)(param_1 + 0x248) +
                                  (int)(*(float *)(param_1 + 0x200) * 12.0),
                                  *(int *)(param_1 + 0x24c) + (iVar13 >> 1),0x50,0x50);
              *(undefined8 *)(param_1 + 0x260) = uStack_258;
              *(undefined8 *)(param_1 + 600) = uStack_260;
              uStack_250 = 0;
              uStack_248 = 0;
              func_0x00010034ede4(&uStack_250,iVar5,*(undefined4 *)(param_1 + 0x20c),iVar18,0x40);
              *(undefined8 *)(param_1 + 0x220) = uStack_248;
              *(undefined8 *)(param_1 + 0x218) = uStack_250;
              iVar3 = *(int *)(param_1 + 0x214);
              uStack_240 = 0;
              uStack_238 = 0;
              iVar13 = iVar3 + 3;
              if (-1 < iVar3) {
                iVar13 = iVar3;
              }
              func_0x00010034ede4(&uStack_240,iVar5,*(int *)(param_1 + 0x20c) + (iVar13 >> 2),
                                  (iVar4 - *(int *)(param_1 + 0x268)) + 0x34,0x40);
              *(undefined8 *)(param_1 + 0x240) = uStack_238;
              *(undefined8 *)(param_1 + 0x238) = uStack_240;
              iVar13 = *(int *)(param_1 + 0x214);
              uStack_230 = 0;
              uStack_228 = 0;
              if (iVar13 < 0) {
                iVar13 = iVar13 + 1;
              }
              func_0x00010034ede4(&uStack_230,iVar5,*(int *)(param_1 + 0x20c) + (iVar13 >> 1),iVar18
                                  ,0x40);
              *(undefined8 *)(param_1 + 0x230) = uStack_228;
              *(undefined8 *)(param_1 + 0x228) = uStack_230;
              iVar13 = *(int *)(param_1 + 0x214) * 3;
              *(float *)(param_1 + 0x28c) = (float)iVar5;
              iVar18 = iVar13 + 3;
              if (-1 < iVar13) {
                iVar18 = iVar13;
              }
              *(float *)(param_1 + 0x290) = (float)(*(int *)(param_1 + 0x20c) + (iVar18 >> 2));
              uVar14 = _UNK_10369f5b8;
              if ((undefined8 *)(param_1 + 0x218) == (undefined8 *)0x0) break;
              iVar13 = *(int *)(param_1 + 0x214) * 3;
              iVar18 = iVar13 + 3;
              if (-1 < iVar13) {
                iVar18 = iVar13;
              }
              *(float *)(param_1 + 0x294) =
                   (float)(*(int *)(param_1 + 0x218) + *(int *)(param_1 + 0x220) + -0x88);
              *(float *)(param_1 + 0x298) = (float)(*(int *)(param_1 + 0x20c) + (iVar18 >> 2));
              *(int *)(param_1 + 0x31c) = iVar4 + -4;
              lVar19 = *(long *)(param_1 + 0xb0);
              uVar14 = _UNK_10369f2b8;
            }
            else {
              StardewValley_StardewValley_Menus_IClickableMenu_initializeUpperRightCloseButton_06006182
                        (param_1);
              if (*(int *)(param_1 + 0x1ec) == 2) {
                *(undefined8 *)(param_1 + 0x38) = 0;
              }
              uVar12 = SDV_StardewValley_Menus_MobileCustomizer_GetCurrentHairIndex_06005e0f();
              *(undefined4 *)(param_1 + 0x300) = uVar12;
              lVar19 = StardewValley_StardewValley_Game1_get_player_06002f9a();
              *(undefined4 *)(param_1 + 0x304) = *(undefined4 *)(*(long *)(lVar19 + 0x3c0) + 0x68);
              uVar12 = SDV_StardewValley_Menus_MobileCustomizer_GetCurrentShirtIndex_06005e0d
                                 (param_1);
              *(undefined4 *)(param_1 + 0x308) = uVar12;
              lVar19 = StardewValley_StardewValley_Game1_get_player_06002f9a();
              *(undefined4 *)(param_1 + 0x30c) = *(undefined4 *)(*(long *)(lVar19 + 0x390) + 0x68);
              lVar19 = StardewValley_StardewValley_Game1_get_player_06002f9a();
              *(undefined4 *)(param_1 + 0x310) = *(undefined4 *)(*(long *)(lVar19 + 0x3d8) + 0x68);
              lVar19 = StardewValley_StardewValley_Game1_get_player_06002f9a();
              *(undefined4 *)(param_1 + 0x314) = *(undefined4 *)(*(long *)(lVar19 + 0x3d0) + 0x68);
              lVar19 = StardewValley_StardewValley_Game1_get_player_06002f9a();
              *(undefined4 *)(param_1 + 0x318) = *(undefined4 *)(*(long *)(lVar19 + 0x380) + 0x68);
              if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                func_0x0001003319b0();
              }
              uVar14 = _UNK_10369f298;
              if ((lRam00000001038d6bc0 == -8) ||
                 (uVar14 = _UNK_10369f290, lRam00000001038d6bc0 == 0)) break;
              iVar18 = *(int *)(lRam00000001038d6bc0 + 8);
              uStack_2e0 = 0;
              uStack_2d8 = 0;
              if (iVar18 < 0) {
                iVar18 = iVar18 + 1;
              }
              func_0x00010034ede4(&uStack_2e0,(iVar18 >> 1) + -0xb4,
                                  *(int *)(param_1 + 0x54) +
                                  (int)(*(float *)(param_1 + 0x204) * 100.0),0x168,0x108);
              *(undefined8 *)(param_1 + 0x210) = uStack_2d8;
              *(undefined8 *)(param_1 + 0x208) = uStack_2e0;
              uVar14 = _UNK_10369f2a0;
              if ((undefined8 *)(param_1 + 0x208) == (undefined8 *)0x0) break;
              iVar13 = *(int *)(param_1 + 0x210);
              iVar4 = *(int *)(param_1 + 0x208);
              iVar18 = iVar13 + -0x7f;
              if (-1 < iVar13 + -0x80) {
                iVar18 = iVar13 + -0x80;
              }
              fVar26 = (float)(*(int *)(param_1 + 0x20c) + 0x20);
              *(float *)(param_1 + 0x270) = fVar26;
              *(float *)(param_1 + 0x26c) = (float)(iVar4 + (iVar18 >> 1));
              uVar14 = _UNK_10369f2a8;
              if (param_1 == -0x26c) break;
              iVar5 = *(int *)(param_1 + 0x210);
              iVar18 = *(int *)(param_1 + 0x208) + iVar5;
              *(float *)(param_1 + 0x27c) = (float)(iVar4 + 0x30);
              if (iVar5 < 0) {
                iVar5 = iVar5 + 1;
              }
              *(float *)(param_1 + 0x280) = fVar26 + 78.0;
              *(float *)(param_1 + 0x288) = *(float *)(param_1 + 0x270) + 78.0;
              *(float *)(param_1 + 0x284) = (float)(iVar18 + -0x50);
              fVar26 = (float)(int)(*(float *)(param_1 + 0x270) + 192.0 + 16.0);
              *(float *)(param_1 + 0x29c) = (float)(int)(*(float *)(param_1 + 0x26c) + -4.0);
              *(float *)(param_1 + 0x2a4) = (float)(int)(*(float *)(param_1 + 0x26c) + 64.0 + 4.0);
              *(float *)(param_1 + 0x2a0) = fVar26;
              *(float *)(param_1 + 0x2a8) = fVar26;
              iVar18 = iVar13 + iVar4 + 0x10;
              *(float *)(param_1 + 0x274) =
                   (float)(*(int *)(param_1 + 0x208) + (iVar5 >> 1) + -0x1e);
              *(float *)(param_1 + 0x278) =
                   *(float *)(param_1 + 0x204) * 32.0 + (float)*(int *)(param_1 + 0x54);
              uStack_2d0 = 0;
              uStack_2c8 = 0;
              func_0x00010034ede4(&uStack_2d0,
                                  (int)((float)(*(int *)(param_1 + 0x58) + *(int *)(param_1 + 0x50))
                                        + *(float *)(param_1 + 0x200) * -40.0 + -80.0),
                                  *(int *)(param_1 + 0x54) +
                                  (int)(*(float *)(param_1 + 0x204) * 592.0),0x50,0x50);
              *(undefined8 *)(param_1 + 0x260) = uStack_2c8;
              *(undefined8 *)(param_1 + 600) = uStack_2d0;
              uStack_2c0 = 0;
              uStack_2b8 = 0;
              func_0x00010034ede4(&uStack_2c0,
                                  *(int *)(param_1 + 0x50) +
                                  (int)(*(float *)(param_1 + 0x200) * 148.0),
                                  *(int *)(param_1 + 0x54) +
                                  (int)(*(float *)(param_1 + 0x204) * 582.0),
                                  *(int *)(param_1 + 0x58) -
                                  (int)(*(float *)(param_1 + 0x200) * 296.0),
                                  (int)(*(float *)(param_1 + 0x204) * 100.0));
              *(undefined8 *)(param_1 + 0x250) = uStack_2b8;
              *(undefined8 *)(param_1 + 0x248) = uStack_2c0;
              uStack_2b0 = 0;
              uStack_2a8 = 0;
              func_0x00010034ede4(&uStack_2b0,iVar18,*(undefined4 *)(param_1 + 0x20c),iVar13,0x40);
              *(undefined8 *)(param_1 + 0x220) = uStack_2a8;
              *(undefined8 *)(param_1 + 0x218) = uStack_2b0;
              iVar5 = *(int *)(param_1 + 0x214);
              uStack_2a0 = 0;
              uStack_298 = 0;
              iVar4 = iVar5 + 3;
              if (-1 < iVar5) {
                iVar4 = iVar5;
              }
              func_0x00010034ede4(&uStack_2a0,iVar18,*(int *)(param_1 + 0x20c) + (iVar4 >> 2),iVar13
                                  ,0x40);
              *(undefined8 *)(param_1 + 0x240) = uStack_298;
              *(undefined8 *)(param_1 + 0x238) = uStack_2a0;
              iVar4 = *(int *)(param_1 + 0x214);
              uStack_290 = 0;
              uStack_288 = 0;
              if (iVar4 < 0) {
                iVar4 = iVar4 + 1;
              }
              func_0x00010034ede4(&uStack_290,iVar18,*(int *)(param_1 + 0x20c) + (iVar4 >> 1),iVar13
                                  ,0x40);
              *(undefined8 *)(param_1 + 0x230) = uStack_288;
              *(undefined8 *)(param_1 + 0x228) = uStack_290;
              uVar14 = _UNK_10369f2b0;
              if ((undefined8 *)(param_1 + 0x238) == (undefined8 *)0x0) break;
              iVar4 = *(int *)(param_1 + 0x214);
              if (iVar4 < 0) {
                iVar4 = iVar4 + 1;
              }
              *(float *)(param_1 + 0x28c) = (float)iVar18;
              *(undefined4 *)(param_1 + 0x31c) = *(undefined4 *)(param_1 + 0x240);
              fVar26 = (float)(*(int *)(param_1 + 0x20c) + (iVar4 >> 1) + -0x20);
              *(float *)(param_1 + 0x294) = (float)(iVar13 + *(int *)(param_1 + 0x208) + 0x20);
              *(float *)(param_1 + 0x290) = fVar26;
              *(float *)(param_1 + 0x298) = fVar26;
              lVar19 = *(long *)(param_1 + 0xb0);
              uVar14 = _UNK_10369f2b8;
            }
          }
          else {
LAB_101e09ec0:
            if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
              func_0x0001003319b0();
            }
            uStack_220 = 0;
            uStack_218 = 0;
            func_0x00010034ede4(&uStack_220,
                                *piRam00000001038d57b0 + (int)(*(float *)(param_1 + 0x200) * 180.0),
                                *(int *)(param_1 + 0x54) + (int)(*(float *)(param_1 + 0x204) * 40.0)
                                ,0x168,0x108);
            *(undefined8 *)(param_1 + 0x210) = uStack_218;
            *(undefined8 *)(param_1 + 0x208) = uStack_220;
            uVar14 = _UNK_10369f5c0;
            if ((undefined8 *)(param_1 + 0x208) == (undefined8 *)0x0) break;
            iVar13 = *(int *)(param_1 + 0x210);
            iVar4 = *(int *)(param_1 + 0x208);
            iVar18 = iVar13 + -0x7f;
            if (-1 < iVar13 + -0x80) {
              iVar18 = iVar13 + -0x80;
            }
            fVar26 = (float)(*(int *)(param_1 + 0x20c) + 0x20);
            *(float *)(param_1 + 0x270) = fVar26;
            *(float *)(param_1 + 0x26c) = (float)(iVar4 + (iVar18 >> 1));
            uVar14 = _UNK_10369f5c8;
            if (param_1 == -0x26c) break;
            iVar5 = *(int *)(param_1 + 0x210);
            iVar18 = *(int *)(param_1 + 0x208) + iVar5;
            *(float *)(param_1 + 0x27c) = (float)(iVar4 + 0x30);
            fVar27 = (float)(*(int *)(param_1 + 0x20c) + -4);
            *(float *)(param_1 + 0x280) = fVar26 + 78.0;
            *(float *)(param_1 + 0x288) = *(float *)(param_1 + 0x270) + 78.0;
            *(float *)(param_1 + 0x284) = (float)(iVar18 + -0x50);
            *(float *)(param_1 + 0x29c) = (float)(iVar18 + 0xc);
            if (iVar5 < 0) {
              iVar5 = iVar5 + 1;
            }
            *(float *)(param_1 + 0x2a4) = (float)(iVar18 + 0x54);
            *(float *)(param_1 + 0x2a0) = fVar27;
            *(float *)(param_1 + 0x2a8) = fVar27;
            *(float *)(param_1 + 0x274) = (float)(*(int *)(param_1 + 0x208) + (iVar5 >> 1) + -0x1e);
            *(float *)(param_1 + 0x278) = (float)*(int *)(param_1 + 0x20c);
            uStack_210 = 0;
            uStack_208 = 0;
            func_0x00010034ede4(&uStack_210,
                                *(int *)(param_1 + 0x50) +
                                (int)(*(float *)(param_1 + 0x200) * 148.0),
                                *(int *)(param_1 + 0x54) +
                                (int)(*(float *)(param_1 + 0x204) * 572.0),
                                *(int *)(param_1 + 0x58) -
                                (int)(*(float *)(param_1 + 0x200) * 296.0),
                                (int)(*(float *)(param_1 + 0x204) * 120.0));
            *(undefined8 *)(param_1 + 0x250) = uStack_208;
            *(undefined8 *)(param_1 + 0x248) = uStack_210;
            uVar14 = _UNK_10369f5d0;
            if ((undefined8 *)(param_1 + 0x248) == (undefined8 *)0x0) break;
            iVar5 = *(int *)(param_1 + 0x254) + -0x50;
            iVar18 = *(int *)(param_1 + 0x254) + -0x4f;
            if (-1 < iVar5) {
              iVar18 = iVar5;
            }
            iVar4 = iVar13 + iVar4 + 0x10;
            uStack_200 = 0;
            uStack_1f8 = 0;
            func_0x00010034ede4(&uStack_200,
                                *(int *)(param_1 + 0x250) + *(int *)(param_1 + 0x248) +
                                (int)(*(float *)(param_1 + 0x200) * 12.0),
                                *(int *)(param_1 + 0x24c) + (iVar18 >> 1),0x50,0x50);
            *(undefined8 *)(param_1 + 0x260) = uStack_1f8;
            *(undefined8 *)(param_1 + 600) = uStack_200;
            iVar5 = *(int *)(param_1 + 0x214);
            uStack_1f0 = 0;
            uStack_1e8 = 0;
            iVar18 = iVar5 + 3;
            if (-1 < iVar5) {
              iVar18 = iVar5;
            }
            func_0x00010034ede4(&uStack_1f0,iVar4,*(int *)(param_1 + 0x20c) + (iVar18 >> 2) + 4,
                                iVar13,0x40);
            *(undefined8 *)(param_1 + 0x220) = uStack_1e8;
            *(undefined8 *)(param_1 + 0x218) = uStack_1f0;
            iVar18 = *(int *)(param_1 + 0x214);
            uStack_1e0 = 0;
            uStack_1d8 = 0;
            if (iVar18 < 0) {
              iVar18 = iVar18 + 1;
            }
            func_0x00010034ede4(&uStack_1e0,iVar4,*(int *)(param_1 + 0x20c) + (iVar18 >> 1) + 8,
                                iVar13,0x40);
            *(undefined8 *)(param_1 + 0x230) = uStack_1d8;
            *(undefined8 *)(param_1 + 0x228) = uStack_1e0;
            iVar5 = *(int *)(param_1 + 0x214) * 3;
            *(float *)(param_1 + 0x28c) = (float)iVar4;
            iVar18 = iVar5 + 3;
            if (-1 < iVar5) {
              iVar18 = iVar5;
            }
            *(float *)(param_1 + 0x290) = (float)(*(int *)(param_1 + 0x20c) + (iVar18 >> 2) + 0x10);
            uVar14 = _UNK_10369f5d8;
            if ((undefined8 *)(param_1 + 0x218) == (undefined8 *)0x0) break;
            iVar4 = *(int *)(param_1 + 0x214) * 3;
            iVar18 = iVar4 + 3;
            if (-1 < iVar4) {
              iVar18 = iVar4;
            }
            *(float *)(param_1 + 0x294) =
                 (float)(*(int *)(param_1 + 0x218) + *(int *)(param_1 + 0x220) + -0x98);
            *(int *)(param_1 + 0x31c) = iVar13 + -0x40;
            *(float *)(param_1 + 0x298) = (float)(*(int *)(param_1 + 0x20c) + (iVar18 >> 2) + 0x10);
            lVar19 = *(long *)(param_1 + 0xb0);
            uVar14 = _UNK_10369f2b8;
          }
          _UNK_10369f2b8 = uVar14;
          if (lVar19 != 0) {
            iVar18 = *(int *)(lVar19 + 0x18);
            *(undefined4 *)(lVar19 + 0x18) = 0;
            *(int *)(lVar19 + 0x1c) = *(int *)(lVar19 + 0x1c) + 1;
            if (0 < iVar18) {
              func_0x000100331c80(*(undefined8 *)(lVar19 + 0x10),0);
            }
            lVar19 = *(long *)(param_1 + 0x80);
            uVar14 = _UNK_10369f2c0;
            if (lVar19 != 0) {
              iVar18 = *(int *)(lVar19 + 0x18);
              *(undefined4 *)(lVar19 + 0x18) = 0;
              *(int *)(lVar19 + 0x1c) = *(int *)(lVar19 + 0x1c) + 1;
              if (0 < iVar18) {
                func_0x000100331c80(*(undefined8 *)(lVar19 + 0x10),0);
              }
              lVar19 = *(long *)(param_1 + 0xa8);
              uVar14 = _UNK_10369f2c8;
              if (lVar19 != 0) {
                iVar18 = *(int *)(lVar19 + 0x18);
                *(undefined4 *)(lVar19 + 0x18) = 0;
                *(int *)(lVar19 + 0x1c) = *(int *)(lVar19 + 0x1c) + 1;
                if (0 < iVar18) {
                  func_0x000100331c80(*(undefined8 *)(lVar19 + 0x10),0);
                }
                uVar14 = func_0x000100331794(uRam00000001038c4f40,(long)*(int *)(param_1 + 0x1f0));
                DataMemoryBarrier(2,3);
                *(undefined8 *)(param_1 + 0x158) = uVar14;
                *(undefined1 *)((param_1 + 0x158U >> 9 & 0x7fffff) + lVar9) = 1;
                plVar20 = *(long **)(param_1 + 0x158);
                if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                  func_0x0001003319b0();
                }
                plVar15 = (long *)*plRam00000001038d5338;
                uVar14 = _UNK_10369f2d0;
                if ((plVar15 != (long *)0x0) &&
                   (uVar16 = (**(code **)(*plVar15 + 0x100))(plVar15,uRam00000001039004a8),
                   uVar14 = _UNK_10369f2d8, plVar20 != (long *)0x0)) {
                  (**(code **)(*plVar20 + 0x110))(plVar20,0,uVar16);
                  plVar20 = (long *)*plRam00000001038d5338;
                  uVar14 = _UNK_10369f2e0;
                  if (plVar20 != (long *)0x0) {
                    plVar15 = *(long **)(param_1 + 0x158);
                    uVar16 = (**(code **)(*plVar20 + 0x100))(plVar20,uRam00000001039004b0);
                    uVar14 = _UNK_10369f2e8;
                    if (plVar15 != (long *)0x0) {
                      (**(code **)(*plVar15 + 0x110))(plVar15,1,uVar16);
                      plVar20 = (long *)*plRam00000001038d5338;
                      uVar14 = _UNK_10369f2f0;
                      if (plVar20 != (long *)0x0) {
                        plVar15 = *(long **)(param_1 + 0x158);
                        uVar16 = (**(code **)(*plVar20 + 0x100))(plVar20,uRam00000001039004b8);
                        uVar14 = _UNK_10369f2f8;
                        if (plVar15 != (long *)0x0) {
                          (**(code **)(*plVar15 + 0x110))(plVar15,2,uVar16);
                          plVar20 = (long *)*plRam00000001038d5338;
                          uVar14 = _UNK_10369f300;
                          if (plVar20 != (long *)0x0) {
                            plVar15 = *(long **)(param_1 + 0x158);
                            uVar16 = (**(code **)(*plVar20 + 0x100))(plVar20,uRam00000001039004c0);
                            uVar14 = _UNK_10369f308;
                            if (plVar15 != (long *)0x0) {
                              (**(code **)(*plVar15 + 0x110))(plVar15,3,uVar16);
                              plVar20 = (long *)*plRam00000001038d5338;
                              uVar14 = _UNK_10369f310;
                              if (plVar20 != (long *)0x0) {
                                plVar15 = *(long **)(param_1 + 0x158);
                                uVar16 = (**(code **)(*plVar20 + 0x100))
                                                   (plVar20,uRam00000001039004c8);
                                uVar14 = _UNK_10369f318;
                                if (plVar15 != (long *)0x0) {
                                  (**(code **)(*plVar15 + 0x110))(plVar15,4,uVar16);
                                  plVar20 = (long *)*plRam00000001038d5338;
                                  uVar14 = _UNK_10369f320;
                                  if (plVar20 != (long *)0x0) {
                                    plVar15 = *(long **)(param_1 + 0x158);
                                    uVar16 = (**(code **)(*plVar20 + 0x100))
                                                       (plVar20,uRam00000001039004d0);
                                    uVar14 = _UNK_10369f328;
                                    if (plVar15 != (long *)0x0) {
                                      (**(code **)(*plVar15 + 0x110))(plVar15,5,uVar16);
                                      uStack_2e4 = 0;
                                      if (*(int *)(param_1 + 0x1f0) < 1) goto LAB_101e08c3c;
                                      uVar21 = 0;
                                      goto LAB_101e08b1c;
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
          break;
        }
        uVar14 = _UNK_10369f230;
        if (*(uint *)(lVar19 + 0x18) <= uVar21) goto LAB_101e0a278;
        *(undefined4 *)(lVar19 + (long)(int)uVar21 * 4 + 0x20) = 0;
        lVar19 = *(long *)(param_1 + 0x180);
        uVar21 = uStack_2e4 + 1;
        uStack_2e4 = uVar21;
        if (lRam0000000103976fb8 == 0) {
          uVar14 = _UNK_10369f238;
          if (lVar19 == 0) break;
          goto LAB_101e07f8c;
        }
        func_0x00010119b8f8();
        uVar14 = _UNK_10369f238;
      } while (lVar19 != 0);
    }
    goto LAB_101e0a298;
  }
LAB_101e0a7b4:
  func_0x0001003316f4(0x95,uVar14);
                    /* WARNING: Does not return */
  pcVar11 = (code *)SoftwareBreakpoint(1,0x101e0a7c0);
  (*pcVar11)();
  while (func_0x00010119b8f8(), (int)uVar21 < iVar18) {
LAB_101e08b1c:
    lVar24 = *(long *)(param_1 + 0xb0);
    uStack_1d0 = 0;
    uStack_1c8 = 0;
    func_0x00010034ede4(&uStack_1d0,iVar1 + 0x18 + uVar21 * iVar8,
                        (int)(fVar28 * 465.0) + iVar2 + -0x10,iVar8 + -0x10,
                        (int)(fVar28 * 88.0) + 0x10);
    uVar22 = uStack_1c8;
    uVar16 = uStack_1d0;
    uVar14 = uRam00000001039004d8;
    uVar17 = func_0x00010034eec0(&uStack_2e4);
    uVar14 = func_0x0001003323d8(uVar14,uVar17);
    lVar19 = func_0x000100331820(uRam00000001038f6cb0,0x78);
    *(undefined4 *)(lVar19 + 0x48) = 0x3f800000;
    *(undefined1 *)(lVar19 + 0x4c) = 1;
    *(undefined8 *)(lVar19 + 0x54) = 0xfffffe0cfffffe0c;
    *(undefined8 *)(lVar19 + 0x5c) = 0xffffffffffffffff;
    *(undefined8 *)(lVar19 + 100) = 0xffffffffffffffff;
    *(undefined8 *)(lVar19 + 0x38) = uVar16;
    *(undefined8 *)(lVar19 + 0x40) = uVar22;
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar19 + 0x10) = uVar14;
    *(undefined1 *)(((ulong)(lVar19 + 0x10) >> 9 & 0x7fffff) + lVar9) = 1;
    uVar14 = _UNK_10369f330;
    if (lVar24 == 0) goto LAB_101e0a298;
    plVar20 = *(long **)(lVar24 + 0x10);
    *(int *)(lVar24 + 0x1c) = *(int *)(lVar24 + 0x1c) + 1;
    uVar14 = _UNK_10369f338;
    if (plVar20 == (long *)0x0) goto LAB_101e0a298;
    if (*(uint *)(lVar24 + 0x18) < *(uint *)(plVar20 + 3)) {
      *(uint *)(lVar24 + 0x18) = *(uint *)(lVar24 + 0x18) + 1;
      (**(code **)(*plVar20 + 0x110))();
    }
    else {
      func_0x000100377424(lVar24,lVar19);
    }
    uVar21 = uStack_2e4 + 1;
    iVar18 = *(int *)(param_1 + 0x1f0);
    uStack_2e4 = uVar21;
    if (lRam0000000103976fb8 == 0) {
      if (iVar18 <= (int)uVar21) break;
      goto LAB_101e08b1c;
    }
  }
LAB_101e08c3c:
  plVar20 = *(long **)(param_1 + 0x158);
  if (*(int *)(param_1 + 0x1ec) == 6) {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar16 = (**(code **)(*(long *)*plRam00000001038d5338 + 0x100))
                       ((long *)*plRam00000001038d5338,uRam00000001039004b8);
    uVar14 = _UNK_10369f530;
    if (plVar20 == (long *)0x0) goto LAB_101e0a298;
    (**(code **)(*plVar20 + 0x110))(plVar20,6,uVar16);
    plVar20 = *(long **)(param_1 + 0x158);
    uVar16 = (**(code **)(*(long *)*plRam00000001038d5338 + 0x100))
                       ((long *)*plRam00000001038d5338,uRam00000001039004c8);
    uVar14 = _UNK_10369f540;
    if (plVar20 == (long *)0x0) goto LAB_101e0a298;
    (**(code **)(*plVar20 + 0x110))(plVar20,7,uVar16);
    if (*(uint *)(*(long *)(param_1 + 0xb0) + 0x18) < 7) {
LAB_101e0a364:
      func_0x000100331b90();
                    /* WARNING: Does not return */
      pcVar11 = (code *)SoftwareBreakpoint(1,0x101e0a36c);
      (*pcVar11)();
    }
    lVar19 = *(long *)(*(long *)(param_1 + 0xb0) + 0x10);
    uVar14 = _UNK_10369f558;
    if (*(uint *)(lVar19 + 0x18) < 7) {
LAB_101e0a278:
      func_0x0001003316f4(0xcc,uVar14);
                    /* WARNING: Does not return */
      pcVar11 = (code *)SoftwareBreakpoint(1,0x101e0a284);
      (*pcVar11)();
    }
    lVar24 = *(long *)(lVar19 + 0x38);
    uVar14 = _UNK_10369f560;
    if ((lVar24 == 0) || (lVar19 = *(long *)(lVar19 + 0x50), uVar14 = _UNK_10369f568, lVar19 == 0))
    goto LAB_101e0a298;
    uVar14 = *(undefined8 *)(lVar24 + 0x38);
    *(undefined8 *)(lVar19 + 0x40) = *(undefined8 *)(lVar24 + 0x40);
    *(undefined8 *)(lVar19 + 0x38) = uVar14;
    if (*(uint *)(*(long *)(param_1 + 0xb0) + 0x18) < 8) goto LAB_101e0a364;
    lVar19 = *(long *)(*(long *)(param_1 + 0xb0) + 0x10);
    uVar14 = _UNK_10369f580;
    if (*(uint *)(lVar19 + 0x18) < 8) goto LAB_101e0a278;
    lVar24 = *(long *)(lVar19 + 0x40);
    uVar14 = _UNK_10369f588;
    if ((lVar24 == 0) || (lVar19 = *(long *)(lVar19 + 0x58), uVar14 = _UNK_10369f590, lVar19 == 0))
    goto LAB_101e0a298;
    uVar14 = *(undefined8 *)(lVar24 + 0x38);
    *(undefined8 *)(lVar19 + 0x40) = *(undefined8 *)(lVar24 + 0x40);
    *(undefined8 *)(lVar19 + 0x38) = uVar14;
  }
  else {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    plVar15 = (long *)*plRam00000001038d5338;
    uVar14 = _UNK_10369f340;
    if ((plVar15 == (long *)0x0) ||
       (uVar16 = (**(code **)(*plVar15 + 0x100))(plVar15,uRam00000001039004e0),
       uVar14 = _UNK_10369f348, plVar20 == (long *)0x0)) goto LAB_101e0a298;
    (**(code **)(*plVar20 + 0x110))(plVar20,6,uVar16);
    plVar20 = (long *)*plRam00000001038d5338;
    uVar14 = _UNK_10369f350;
    if (plVar20 == (long *)0x0) goto LAB_101e0a298;
    plVar15 = *(long **)(param_1 + 0x158);
    uVar16 = (**(code **)(*plVar20 + 0x100))(plVar20,uRam00000001039004e8);
    uVar14 = _UNK_10369f358;
    if (plVar15 == (long *)0x0) goto LAB_101e0a298;
    (**(code **)(*plVar15 + 0x110))(plVar15,7,uVar16);
  }
  uVar14 = uRam00000001039004f0;
  uVar16 = *(undefined8 *)(param_1 + 600);
  uVar22 = *(undefined8 *)(param_1 + 0x260);
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar25 = *puRam00000001038d5350;
  uStack_1c0 = 0;
  uStack_1b8 = 0;
  func_0x00010034ede4(&uStack_1c0,0,0,0x14,0x14);
  uVar17 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
  StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
            (0x40800000,uVar17,uVar14,uVar16,uVar22,0,0,uVar25);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0xc0) = uVar17;
  *(undefined1 *)(((ulong)(param_1 + 0xc0) >> 9 & 0x7fffff) + lVar9) = 1;
  uVar12 = *puRam00000001038d5c70;
  lVar24 = *plRam00000001038c4c90;
  lVar19 = func_0x000100331820(uRam00000001039004f8,0x78);
  StardewValley_StardewValley_Menus_TextBox__ctor_0600655b(lVar19,0,0,lVar24,uVar12,0,0);
  uVar14 = _UNK_10369f360;
  if (param_1 != -0x218) {
    uVar12 = *(undefined4 *)(param_1 + 0x224);
    uVar14 = *(undefined8 *)(param_1 + 0x21c);
    *(undefined4 *)(lVar19 + 0x58) = *(undefined4 *)(param_1 + 0x218);
    *(undefined4 *)(lVar19 + 100) = uVar12;
    *(undefined8 *)(lVar19 + 0x5c) = uVar14;
    lVar24 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    StardewValley_StardewValley_Menus_TextBox_set_Text_06006558
              (lVar19,*(undefined8 *)(*(long *)(lVar24 + 0x58) + 0x60));
    plVar20 = plRam00000001038d5338;
    *(undefined4 *)(lVar19 + 0x6c) = 0xf;
    plVar20 = (long *)*plVar20;
    uVar14 = _UNK_10369f378;
    if ((plVar20 != (long *)0x0) &&
       (lVar24 = (**(code **)(*plVar20 + 0x100))(plVar20,uRam00000001039003f0),
       uVar14 = _UNK_10369f380, lVar24 != 0)) {
      uVar14 = func_0x000100331fdc(lVar24,uRam00000001038d7278,uRam00000001038c4d00);
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lVar19 + 0x30) = uVar14;
      *(undefined1 *)(((ulong)(lVar19 + 0x30) >> 9 & 0x7fffff) + lVar9) = 1;
      DataMemoryBarrier(2,3);
      *(long *)(param_1 + 0xe0) = lVar19;
      *(undefined1 *)(((ulong)(param_1 + 0xe0) >> 9 & 0x7fffff) + lVar9) = 1;
      uVar14 = uRam00000001038c4f58;
      uVar16 = *(undefined8 *)(param_1 + 0x218);
      uVar22 = *(undefined8 *)(param_1 + 0x220);
      lVar19 = func_0x000100331820(uRam00000001038f6cb0,0x78);
      *(undefined1 *)(lVar19 + 0x4c) = 1;
      *(undefined8 *)(lVar19 + 0x38) = uVar16;
      *(undefined8 *)(lVar19 + 0x40) = uVar22;
      *(undefined4 *)(lVar19 + 0x48) = 0x3f800000;
      *(undefined8 *)(lVar19 + 0x54) = 0xfffffe0cfffffe0c;
      *(undefined8 *)(lVar19 + 0x5c) = 0xffffffffffffffff;
      *(undefined8 *)(lVar19 + 100) = 0xffffffffffffffff;
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lVar19 + 0x10) = uVar14;
      *(undefined1 *)(((ulong)(lVar19 + 0x10) >> 9 & 0x7fffff) + lVar9) = 1;
      *(undefined4 *)(lVar19 + 0x54) = 0x218;
      DataMemoryBarrier(2,3);
      *(long *)(param_1 + 0xf8) = lVar19;
      *(undefined1 *)(((ulong)(param_1 + 0xf8) >> 9 & 0x7fffff) + lVar9) = 1;
      if ((*(int *)(param_1 + 0x1ec) == 3) || (*(int *)(param_1 + 0x1ec) == 0)) {
        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        uVar12 = *puRam00000001038d5c70;
        lVar24 = *plRam00000001038c4c90;
        lVar19 = func_0x000100331820(uRam00000001039004f8,0x78);
        StardewValley_StardewValley_Menus_TextBox__ctor_0600655b(lVar19,0,0,lVar24,uVar12,0,0);
        uVar14 = _UNK_10369f388;
        if (param_1 == -0x238) goto LAB_101e0a298;
        uVar12 = *(undefined4 *)(param_1 + 0x244);
        uVar14 = *(undefined8 *)(param_1 + 0x23c);
        *(undefined4 *)(lVar19 + 0x58) = *(undefined4 *)(param_1 + 0x238);
        *(undefined4 *)(lVar19 + 100) = uVar12;
        *(undefined8 *)(lVar19 + 0x5c) = uVar14;
        lVar24 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        StardewValley_StardewValley_Menus_TextBox_set_Text_06006558
                  (lVar19,*(undefined8 *)(*(long *)(lVar24 + 0x2a0) + 0x60));
        plVar20 = plRam00000001038d5338;
        *(undefined4 *)(lVar19 + 0x6c) = 9;
        plVar20 = (long *)*plVar20;
        uVar14 = _UNK_10369f3a0;
        if ((plVar20 == (long *)0x0) ||
           (lVar24 = (**(code **)(*plVar20 + 0x100))(plVar20,uRam0000000103900400),
           uVar14 = _UNK_10369f3a8, lVar24 == 0)) goto LAB_101e0a298;
        uVar14 = func_0x000100331fdc(lVar24,uRam00000001038d7278,uRam00000001038c4d00);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(lVar19 + 0x30) = uVar14;
        *(undefined1 *)(((ulong)(lVar19 + 0x30) >> 9 & 0x7fffff) + lVar9) = 1;
        DataMemoryBarrier(2,3);
        *(long *)(param_1 + 0xe8) = lVar19;
        *(undefined1 *)(((ulong)(param_1 + 0xe8) >> 9 & 0x7fffff) + lVar9) = 1;
        uVar22 = uRam00000001038c4f58;
        uVar14 = *(undefined8 *)(param_1 + 0x238);
        uVar16 = *(undefined8 *)(param_1 + 0x240);
        lVar19 = func_0x000100331820(uRam00000001038f6cb0,0x78);
        *(undefined1 *)(lVar19 + 0x4c) = 1;
        *(undefined8 *)(lVar19 + 0x38) = uVar14;
        *(undefined8 *)(lVar19 + 0x40) = uVar16;
        *(undefined4 *)(lVar19 + 0x48) = 0x3f800000;
        *(undefined8 *)(lVar19 + 0x54) = 0xfffffe0cfffffe0c;
        *(undefined8 *)(lVar19 + 0x5c) = 0xffffffffffffffff;
        *(undefined8 *)(lVar19 + 100) = 0xffffffffffffffff;
        DataMemoryBarrier(2,3);
        *(undefined8 *)(lVar19 + 0x10) = uVar22;
        *(undefined1 *)(((ulong)(lVar19 + 0x10) >> 9 & 0x7fffff) + lVar9) = 1;
        *(undefined4 *)(lVar19 + 0x54) = 0x219;
        DataMemoryBarrier(2,3);
        *(long *)(param_1 + 0x100) = lVar19;
        *(undefined1 *)((param_1 + 0x100U >> 9 & 0x7fffff) + lVar9) = 1;
      }
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar12 = *puRam00000001038d5c70;
      lVar24 = *plRam00000001038c4c90;
      lVar19 = func_0x000100331820(uRam00000001039004f8,0x78);
      StardewValley_StardewValley_Menus_TextBox__ctor_0600655b(lVar19,0,0,lVar24,uVar12,0,0);
      uVar14 = _UNK_10369f3b0;
      if (param_1 != -0x228) {
        uVar12 = *(undefined4 *)(param_1 + 0x234);
        uVar14 = *(undefined8 *)(param_1 + 0x22c);
        *(undefined4 *)(lVar19 + 0x58) = *(undefined4 *)(param_1 + 0x228);
        *(undefined4 *)(lVar19 + 100) = uVar12;
        *(undefined8 *)(lVar19 + 0x5c) = uVar14;
        lVar24 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        StardewValley_StardewValley_Menus_TextBox_set_Text_06006558
                  (lVar19,*(undefined8 *)(*(long *)(lVar24 + 0x2a8) + 0x60));
        plVar20 = plRam00000001038d5338;
        *(undefined4 *)(lVar19 + 0x6c) = 0x14;
        plVar20 = (long *)*plVar20;
        uVar14 = _UNK_10369f3c8;
        if ((plVar20 != (long *)0x0) &&
           (lVar24 = (**(code **)(*plVar20 + 0x100))(plVar20,uRam00000001039003f8),
           uVar14 = _UNK_10369f3d0, lVar24 != 0)) {
          uVar14 = func_0x000100331fdc(lVar24,uRam00000001038d7278,uRam00000001038c4d00);
          DataMemoryBarrier(2,3);
          *(undefined8 *)(lVar19 + 0x30) = uVar14;
          *(undefined1 *)(((ulong)(lVar19 + 0x30) >> 9 & 0x7fffff) + lVar9) = 1;
          DataMemoryBarrier(2,3);
          *(long *)(param_1 + 0xf0) = lVar19;
          *(undefined1 *)(((ulong)(param_1 + 0xf0) >> 9 & 0x7fffff) + lVar9) = 1;
          uVar14 = uRam00000001038c4f58;
          uVar16 = *(undefined8 *)(param_1 + 0x228);
          uVar22 = *(undefined8 *)(param_1 + 0x230);
          lVar19 = func_0x000100331820(uRam00000001038f6cb0,0x78);
          *(undefined1 *)(lVar19 + 0x4c) = 1;
          *(undefined8 *)(lVar19 + 0x38) = uVar16;
          *(undefined8 *)(lVar19 + 0x40) = uVar22;
          *(undefined4 *)(lVar19 + 0x48) = 0x3f800000;
          *(undefined8 *)(lVar19 + 0x54) = 0xfffffe0cfffffe0c;
          *(undefined8 *)(lVar19 + 0x5c) = 0xffffffffffffffff;
          *(undefined8 *)(lVar19 + 100) = 0xffffffffffffffff;
          DataMemoryBarrier(2,3);
          *(undefined8 *)(lVar19 + 0x10) = uVar14;
          *(undefined1 *)(((ulong)(lVar19 + 0x10) >> 9 & 0x7fffff) + lVar9) = 1;
          DataMemoryBarrier(2,3);
          *(long *)(param_1 + 0x108) = lVar19;
          *(undefined1 *)((param_1 + 0x108U >> 9 & 0x7fffff) + lVar9) = 1;
          uVar14 = _UNK_10369f3d8;
          if (param_1 != -0x274) {
            uStack_1b0 = 0;
            uStack_1a8 = 0;
            func_0x00010034ede4(&uStack_1b0,(int)*(float *)(param_1 + 0x274),
                                (int)*(float *)(param_1 + 0x278),0x3c,0x3c);
            uVar16 = uStack_1a8;
            uVar14 = uStack_1b0;
            uVar23 = *puRam00000001038d5350;
            uStack_1a0 = 0;
            uStack_198 = 0;
            func_0x00010034ede4(&uStack_1a0,0x57,0x16,0x14,0x14);
            uVar17 = uStack_198;
            uVar22 = uStack_1a0;
            uVar25 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
            StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601b
                      (0x40400000,uVar25,uVar14,uVar16,uVar23,uVar22,uVar17,1);
            DataMemoryBarrier(2,3);
            *(undefined8 *)(param_1 + 0xd0) = uVar25;
            *(undefined1 *)(((ulong)(param_1 + 0xd0) >> 9 & 0x7fffff) + lVar9) = 1;
            uVar14 = _UNK_10369f3e0;
            if (param_1 != -0x27c) {
              uStack_190 = 0;
              uStack_188 = 0;
              func_0x00010034ede4(&uStack_190,(int)*(float *)(param_1 + 0x27c),
                                  (int)*(float *)(param_1 + 0x280),0x50,0x4c);
              *(undefined8 *)(param_1 + 0x2c4) = uStack_188;
              *(undefined8 *)(param_1 + 700) = uStack_190;
              uVar14 = _UNK_10369f3e8;
              if (param_1 != -0x284) {
                uStack_180 = 0;
                uStack_178 = 0;
                func_0x00010034ede4(&uStack_180,(int)*(float *)(param_1 + 0x284),
                                    (int)*(float *)(param_1 + 0x288),0x50,0x4c);
                uVar16 = uRam0000000103900500;
                *(undefined8 *)(param_1 + 0x2d4) = uStack_178;
                *(undefined8 *)(param_1 + 0x2cc) = uStack_180;
                uVar14 = uRam00000001038c4f58;
                uVar25 = *(undefined8 *)(param_1 + 0x2c4);
                uVar17 = *(undefined8 *)(param_1 + 700);
                uVar23 = *puRam00000001038d5350;
                uStack_170 = 0;
                uStack_168 = 0;
                func_0x00010034ede4(&uStack_170,0x6c,0x1a,8,0xb);
                uVar22 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
                StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                          (0x40800000,uVar22,uVar16,uVar17,uVar25,0,uVar14,uVar23);
                DataMemoryBarrier(2,3);
                *(undefined8 *)(param_1 + 0x88) = uVar22;
                *(undefined1 *)(((ulong)(param_1 + 0x88) >> 9 & 0x7fffff) + lVar9) = 1;
                uVar17 = uRam0000000103900508;
                uVar22 = uRam00000001038c4f58;
                uVar14 = *(undefined8 *)(param_1 + 0x2cc);
                uVar16 = *(undefined8 *)(param_1 + 0x2d4);
                uVar23 = *puRam00000001038d5350;
                uStack_160 = 0;
                uStack_158 = 0;
                func_0x00010034ede4(&uStack_160,0x77,0x1a,8,0xb);
                uVar25 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
                StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                          (0x40800000,uVar25,uVar17,uVar14,uVar16,0,uVar22,uVar23);
                DataMemoryBarrier(2,3);
                *(undefined8 *)(param_1 + 0x90) = uVar25;
                *(undefined1 *)(((ulong)(param_1 + 0x90) >> 9 & 0x7fffff) + lVar9) = 1;
                uVar14 = _UNK_10369f3f0;
                if (param_1 != -0x248) {
                  iVar18 = *(int *)(param_1 + 0x248);
                  uVar12 = *(undefined4 *)(param_1 + 0x24c);
                  uVar14 = func_0x000100331820(uRam0000000103900280,0x3c);
                  StardewValley_StardewValley_Menus_SliderBar__ctor_060064cb
                            (uVar14,iVar18 + 0xb4,uVar12,1);
                  DataMemoryBarrier(2,3);
                  *(undefined8 *)(param_1 + 0x160) = uVar14;
                  *(undefined1 *)((param_1 + 0x160U >> 9 & 0x7fffff) + lVar9) = 1;
                  lVar19 = *(long *)(param_1 + 0x160);
                  uVar14 = _UNK_10369f3f8;
                  if ((lVar19 != 0) && (uVar14 = _UNK_10369f400, lVar19 != -0x1c)) {
                    *(int *)(lVar19 + 0x24) = *(int *)(param_1 + 0x250) + -500;
                    lVar19 = *(long *)(param_1 + 0x160);
                    uVar14 = _UNK_10369f408;
                    if ((lVar19 != 0) && (uVar14 = _UNK_10369f410, lVar19 != -0x1c)) {
                      *(undefined4 *)(lVar19 + 0x28) = *(undefined4 *)(param_1 + 0x254);
                      uVar14 = _UNK_10369f418;
                      if (*(long *)(param_1 + 0x160) != 0) {
                        *(undefined4 *)(*(long *)(param_1 + 0x160) + 0x14) = 0x2c;
                        uVar14 = _UNK_10369f420;
                        if (*(long *)(param_1 + 0x160) != 0) {
                          *(undefined4 *)(*(long *)(param_1 + 0x160) + 0x18) = 10;
                          lVar19 = *(long *)(param_1 + 0x160);
                          uVar14 = _UNK_10369f428;
                          if ((lVar19 != 0) && (uVar14 = _UNK_10369f430, lVar19 != -0x1c)) {
                            uStack_150 = 0;
                            uStack_148 = 0;
                            func_0x00010034ede4(&uStack_150,
                                                *(int *)(lVar19 + 0x1c) - *(int *)(lVar19 + 0x14),
                                                *(int *)(lVar19 + 0x20) - *(int *)(lVar19 + 0x18),
                                                *(int *)(lVar19 + 0x24) +
                                                *(int *)(lVar19 + 0x14) * 2,
                                                *(int *)(lVar19 + 0x28) +
                                                *(int *)(lVar19 + 0x18) * 2);
                            *(undefined8 *)(lVar19 + 0x34) = uStack_148;
                            *(undefined8 *)(lVar19 + 0x2c) = uStack_150;
                            lVar19 = *(long *)(param_1 + 0x160);
                            uVar14 = _UNK_10369f438;
                            if ((lVar19 != 0) &&
                               (uVar14 = _UNK_10369f440, (int *)(lVar19 + 0x1c) != (int *)0x0)) {
                              iVar18 = *(int *)(param_1 + 0x254);
                              iVar13 = *(int *)(lVar19 + 0x20);
                              if (iVar18 < 0) {
                                iVar18 = iVar18 + 1;
                              }
                              lVar24 = *(long *)(param_1 + 0x160);
                              *(float *)(param_1 + 0x2ac) = (float)(*(int *)(lVar19 + 0x1c) + -0x40)
                              ;
                              *(float *)(param_1 + 0x2b0) = (float)(iVar13 + (iVar18 >> 1) + -0x10);
                              uVar14 = _UNK_10369f448;
                              if ((lVar24 != 0) &&
                                 (uVar14 = _UNK_10369f450, (int *)(lVar24 + 0x1c) != (int *)0x0)) {
                                iVar1 = *(int *)(param_1 + 0x254);
                                iVar13 = *(int *)(lVar24 + 0x20);
                                iVar18 = iVar1;
                                if (iVar1 < 0) {
                                  iVar18 = iVar1 + 1;
                                }
                                iVar2 = iVar1 + -0x4f;
                                if (-1 < iVar1 + -0x50) {
                                  iVar2 = iVar1 + -0x50;
                                }
                                *(float *)(param_1 + 0x2b4) =
                                     (float)(*(int *)(lVar24 + 0x1c) + *(int *)(lVar24 + 0x24) +
                                            0x28);
                                *(float *)(param_1 + 0x2b8) =
                                     (float)(iVar13 + (iVar18 >> 1) + -0x10);
                                uStack_140 = 0;
                                uStack_138 = 0;
                                func_0x00010034ede4(&uStack_140,*(int *)(param_1 + 0x248) + 8,
                                                    *(int *)(param_1 + 0x24c) + (iVar2 >> 1),0x50,
                                                    0x4c);
                                *(undefined8 *)(param_1 + 0x2e4) = uStack_138;
                                *(undefined8 *)(param_1 + 0x2dc) = uStack_140;
                                uVar14 = _UNK_10369f458;
                                if (param_1 != -0x2b4) {
                                  uStack_130 = 0;
                                  uStack_128 = 0;
                                  iVar13 = *(int *)(param_1 + 0x254) + -0x50;
                                  iVar18 = *(int *)(param_1 + 0x254) + -0x4f;
                                  if (-1 < iVar13) {
                                    iVar18 = iVar13;
                                  }
                                  func_0x00010034ede4(&uStack_130,
                                                      (int)(*(float *)(param_1 + 0x2b4) + 48.0),
                                                      *(int *)(param_1 + 0x24c) + (iVar18 >> 1),0x50
                                                      ,0x4c);
                                  uVar16 = uRam0000000103900510;
                                  *(undefined8 *)(param_1 + 0x2f4) = uStack_128;
                                  *(undefined8 *)(param_1 + 0x2ec) = uStack_130;
                                  uVar14 = uRam00000001038c4f58;
                                  uVar25 = *(undefined8 *)(param_1 + 0x2e4);
                                  uVar23 = *puRam00000001038d5350;
                                  uStack_120 = 0;
                                  uStack_118 = 0;
                                  uVar17 = *(undefined8 *)(param_1 + 0x2dc);
                                  func_0x00010034ede4(&uStack_120,0x50,0,0x14,0x13);
                                  uVar22 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
                                  StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                                            (0x40800000,uVar22,uVar16,uVar17,uVar25,0,uVar14,uVar23)
                                  ;
                                  DataMemoryBarrier(2,3);
                                  *(undefined8 *)(param_1 + 0x98) = uVar22;
                                  *(undefined1 *)(((ulong)(param_1 + 0x98) >> 9 & 0x7fffff) + lVar9)
                                       = 1;
                                  uVar17 = uRam0000000103900518;
                                  uVar22 = uRam00000001038c4f58;
                                  uVar14 = *(undefined8 *)(param_1 + 0x2ec);
                                  uVar16 = *(undefined8 *)(param_1 + 0x2f4);
                                  uVar23 = *puRam00000001038d5350;
                                  uStack_110 = 0;
                                  uStack_108 = 0;
                                  func_0x00010034ede4(&uStack_110,100,0,0x14,0x13);
                                  uVar25 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
                                  StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                                            (0x40800000,uVar25,uVar17,uVar14,uVar16,0,uVar22,uVar23)
                                  ;
                                  DataMemoryBarrier(2,3);
                                  *(undefined8 *)(param_1 + 0xa0) = uVar25;
                                  *(undefined1 *)(((ulong)(param_1 + 0xa0) >> 9 & 0x7fffff) + lVar9)
                                       = 1;
                                  uVar16 = uRam0000000103900520;
                                  uVar14 = _UNK_10369f460;
                                  if ((undefined8 *)(param_1 + 0x2dc) != (undefined8 *)0x0) {
                                    uStack_100 = 0;
                                    uStack_f8 = 0;
                                    func_0x00010034ede4(&uStack_100,*(int *)(param_1 + 0x50) + 0x28,
                                                        *(undefined4 *)(param_1 + 0x2e0),0x50,0x50);
                                    uVar22 = uStack_f8;
                                    uVar14 = uStack_100;
                                    uVar25 = *puRam00000001038d5f78;
                                    uStack_f0 = 0;
                                    uStack_e8 = 0;
                                    func_0x00010034ede4(&uStack_f0,0x9a,0x9a,0x14,0x14);
                                    uVar17 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
                                    StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                                              (0x40800000,uVar17,uVar16,uVar14,uVar22,0,0,uVar25);
                                    DataMemoryBarrier(2,3);
                                    *(undefined8 *)(param_1 + 0xd8) = uVar17;
                                    *(undefined1 *)
                                     (((ulong)(param_1 + 0xd8) >> 9 & 0x7fffff) + lVar9) = 1;
                                    if ((*(int *)(param_1 + 0x1ec) == 3) ||
                                       (*(int *)(param_1 + 0x1ec) == 0)) {
                                      lVar19 = func_0x000100377a28(param_1);
                                      lVar24 = StardewValley_StardewValley_Game1_get_player_06002f9a
                                                         ();
                                      uVar16 = *(undefined8 *)(lVar24 + 800);
                                      lVar24 = StardewValley_StardewValley_Game1_get_player_06002f9a
                                                         ();
                                      uStack_d8 = *(undefined8 *)(lVar24 + 0x328);
                                      DataMemoryBarrier(2,3);
                                      *(undefined1 *)(((ulong)&uStack_e0 >> 9 & 0x7fffff) + lVar9) =
                                           1;
                                      DataMemoryBarrier(2,3);
                                      *(undefined1 *)(((ulong)&uStack_d8 >> 9 & 0x7fffff) + lVar9) =
                                           1;
                                      uVar14 = _UNK_10369f478;
                                      uStack_e0 = uVar16;
                                      if (lVar19 == 0) goto LAB_101e0a298;
                                      iVar13 = func_0x000100377a3c(lVar19,uVar16,uStack_d8);
                                      uVar21 = *(uint *)(lVar19 + 0x18);
                                      iVar18 = 0;
                                      if (iVar13 != -1) {
                                        iVar18 = iVar13;
                                      }
                                      if (0 < (int)uVar21) {
                                        uVar14 = _UNK_10369f518;
                                        if (param_1 == -0x28c) goto LAB_101e0a298;
                                        uVar14 = _UNK_10369f520;
                                        if (uVar21 < 2) goto LAB_101e0a7b4;
                                        fVar28 = *(float *)(param_1 + 0x28c);
                                        uVar7 = 0;
                                        if (uVar21 >> 1 != 0) {
                                          uVar7 = 100 / (uVar21 >> 1);
                                        }
                                        fVar26 = *(float *)(param_1 + 0x290);
                                        uVar14 = func_0x000100331820(uRam0000000103900280,0x3c);
                                        StardewValley_StardewValley_Menus_SliderBar__ctor_060064cb
                                                  (uVar14,(int)(fVar28 + 64.0),(int)fVar26,
                                                   uVar7 * iVar18);
                                        DataMemoryBarrier(2,3);
                                        *(undefined8 *)(param_1 + 0x168) = uVar14;
                                        *(undefined1 *)((param_1 + 0x168U >> 9 & 0x7fffff) + lVar9)
                                             = 1;
                                      }
                                    }
                                    lVar19 = *(long *)(param_1 + 0x168);
                                    if (lVar19 != 0) {
                                      uVar14 = _UNK_10369f510;
                                      if (lVar19 == -0x1c) goto LAB_101e0a298;
                                      *(undefined4 *)(lVar19 + 0x24) =
                                           *(undefined4 *)(param_1 + 0x31c);
                                    }
                                    uVar16 = uRam00000001038c97f8;
                                    uVar14 = _UNK_10369f480;
                                    if (param_1 != -0x29c) {
                                      uStack_d0 = 0;
                                      uStack_c8 = 0;
                                      lVar19 = *(long *)(param_1 + 0xa8);
                                      func_0x00010034ede4(&uStack_d0,
                                                          (int)*(float *)(param_1 + 0x29c),
                                                          (int)*(float *)(param_1 + 0x2a0),0x3c,0x40
                                                         );
                                      uVar17 = uStack_c8;
                                      uVar22 = uStack_d0;
                                      uVar14 = uRam00000001038c97f8;
                                      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                                        func_0x0001003319b0();
                                      }
                                      uVar23 = *puRam00000001038d53d0;
                                      uStack_c0 = 0;
                                      uStack_b8 = 0;
                                      func_0x00010034ede4(&uStack_c0,0x81,0xc0,0x10,0x10);
                                      uVar25 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
                                      StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                                                (0x40800000,uVar25,uVar16,uVar22,uVar17,0,uVar14,
                                                 uVar23);
                                      plVar20 = *(long **)(lVar19 + 0x10);
                                      *(int *)(lVar19 + 0x1c) = *(int *)(lVar19 + 0x1c) + 1;
                                      uVar14 = _UNK_10369f490;
                                      if (plVar20 != (long *)0x0) {
                                        uVar21 = *(uint *)(lVar19 + 0x18);
                                        if (uVar21 < *(uint *)(plVar20 + 3)) {
                                          *(uint *)(lVar19 + 0x18) = uVar21 + 1;
                                          (**(code **)(*plVar20 + 0x110))
                                                    (plVar20,(long)(int)uVar21,uVar25);
                                        }
                                        else {
                                          func_0x000100377424(lVar19,uVar25);
                                        }
                                        uVar16 = uRam00000001038c9800;
                                        uVar14 = _UNK_10369f498;
                                        if (param_1 != -0x2a4) {
                                          uStack_b0 = 0;
                                          uStack_a8 = 0;
                                          lVar19 = *(long *)(param_1 + 0xa8);
                                          func_0x00010034ede4(&uStack_b0,
                                                              (int)*(float *)(param_1 + 0x2a4),
                                                              (int)*(float *)(param_1 + 0x2a8),0x40,
                                                              0x40);
                                          uVar17 = uStack_a8;
                                          uVar22 = uStack_b0;
                                          uVar14 = uRam00000001038c9800;
                                          uVar23 = *puRam00000001038d53d0;
                                          uStack_a0 = 0;
                                          uStack_98 = 0;
                                          func_0x00010034ede4(&uStack_a0,0x90,0xc0,0x10,0x10);
                                          uVar25 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
                                          StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                                                    (0x40800000,uVar25,uVar16,uVar22,uVar17,0,uVar14
                                                     ,uVar23);
                                          plVar20 = *(long **)(lVar19 + 0x10);
                                          *(int *)(lVar19 + 0x1c) = *(int *)(lVar19 + 0x1c) + 1;
                                          uVar14 = _UNK_10369f4a8;
                                          if (plVar20 != (long *)0x0) {
                                            uVar21 = *(uint *)(lVar19 + 0x18);
                                            if (uVar21 < *(uint *)(plVar20 + 3)) {
                                              *(uint *)(lVar19 + 0x18) = uVar21 + 1;
                                              (**(code **)(*plVar20 + 0x110))
                                                        (plVar20,(long)(int)uVar21,uVar25);
                                            }
                                            else {
                                              func_0x000100377424(lVar19,uVar25);
                                            }
                                            uVar14 = uRam00000001038cc6b0;
                                            uVar16 = *(undefined8 *)(param_1 + 0x248);
                                            uVar22 = *(undefined8 *)(param_1 + 0x250);
                                            lVar19 = func_0x000100331820(uRam0000000103900530,200);
                                            SDV_StardewValley_Menus_MobileColorPicker__ctor_06005dec
                                                      (lVar19,uVar14,uVar16,uVar22);
                                            DataMemoryBarrier(2,3);
                                            plVar20 = (long *)(param_1 + 0x78);
                                            *plVar20 = lVar19;
                                            *(undefined1 *)
                                             (((ulong)plVar20 >> 9 & 0x7fffff) + lVar9) = 1;
                                            lVar24 = *plVar20;
                                            lVar19 = 
                                                  StardewValley_StardewValley_Game1_get_player_06002f9a
                                                            ();
                                            uVar14 = _UNK_10369f4b8;
                                            if ((*(long *)(lVar19 + 0x3d8) != 0) &&
                                               (uVar14 = _UNK_10369f4c0, lVar24 != 0)) {
                                              SDV_StardewValley_Menus_MobileColorPicker_setColor_06005df8
                                                        (lVar24,*(undefined4 *)
                                                                 (*(long *)(lVar19 + 0x3d8) + 0x68))
                                              ;
                                              uVar14 = uRam00000001038cc6d8;
                                              uVar16 = *(undefined8 *)(param_1 + 0x248);
                                              uVar22 = *(undefined8 *)(param_1 + 0x250);
                                              lVar19 = func_0x000100331820(uRam0000000103900530,200)
                                              ;
                                              SDV_StardewValley_Menus_MobileColorPicker__ctor_06005dec
                                                        (lVar19,uVar14,uVar16,uVar22);
                                              DataMemoryBarrier(2,3);
                                              plVar20 = (long *)(param_1 + 0x70);
                                              *plVar20 = lVar19;
                                              *(undefined1 *)
                                               (((ulong)plVar20 >> 9 & 0x7fffff) + lVar9) = 1;
                                              lVar24 = *plVar20;
                                              lVar19 = 
                                                  StardewValley_StardewValley_Game1_get_player_06002f9a
                                                            ();
                                              uVar14 = _UNK_10369f4d0;
                                              if ((*(long *)(lVar19 + 0x3c0) != 0) &&
                                                 (uVar14 = _UNK_10369f4d8, lVar24 != 0)) {
                                                SDV_StardewValley_Menus_MobileColorPicker_setColor_06005df8
                                                          (lVar24,*(undefined4 *)
                                                                   (*(long *)(lVar19 + 0x3c0) + 0x68
                                                                   ));
                                                uVar14 = uRam00000001038cc6a0;
                                                uVar16 = *(undefined8 *)(param_1 + 0x248);
                                                uVar22 = *(undefined8 *)(param_1 + 0x250);
                                                lVar19 = func_0x000100331820(uRam0000000103900530,
                                                                             200);
                                                SDV_StardewValley_Menus_MobileColorPicker__ctor_06005dec
                                                          (lVar19,uVar14,uVar16,uVar22);
                                                DataMemoryBarrier(2,3);
                                                plVar20 = (long *)(param_1 + 0x68);
                                                *plVar20 = lVar19;
                                                *(undefined1 *)
                                                 (((ulong)plVar20 >> 9 & 0x7fffff) + lVar9) = 1;
                                                lVar24 = *plVar20;
                                                lVar19 = 
                                                  StardewValley_StardewValley_Game1_get_player_06002f9a
                                                            ();
                                                uVar14 = _UNK_10369f4e8;
                                                if ((*(long *)(lVar19 + 0x3d0) != 0) &&
                                                   (uVar14 = _UNK_10369f4f0, lVar24 != 0)) {
                                                  SDV_StardewValley_Menus_MobileColorPicker_setColor_06005df8
                                                            (lVar24,*(undefined4 *)
                                                                     (*(long *)(lVar19 + 0x3d0) +
                                                                     0x68));
                                                  uVar16 = uRam0000000103900538;
                                                  lVar19 = *(long *)(param_1 + 0xa0);
                                                  uVar14 = _UNK_10369f4f8;
                                                  if ((lVar19 != 0) &&
                                                     (uVar14 = _UNK_10369f500,
                                                     (int *)(lVar19 + 0x38) != (int *)0x0)) {
                                                    uStack_90 = 0;
                                                    uStack_88 = 0;
                                                    func_0x00010034ede4(&uStack_90,
                                                                        *(int *)(lVar19 + 0x38) +
                                                                        *(int *)(lVar19 + 0x40) +
                                                                        0x40,*(int *)(lVar19 + 0x3c)
                                                                             + 8,0x30,0x30);
                                                    uVar17 = uStack_88;
                                                    uVar22 = uStack_90;
                                                    plVar20 = (long *)*plRam00000001038d5338;
                                                    uVar14 = _UNK_10369f508;
                                                    if (plVar20 != (long *)0x0) {
                                                      uVar14 = (**(code **)(*plVar20 + 0x100))
                                                                         (plVar20,
                                                  uRam0000000103900540);
                                                  uVar23 = *puRam00000001038d53d0;
                                                  uStack_80 = 0;
                                                  uStack_78 = 0;
                                                  func_0x00010034ede4(&uStack_80,0xe3,0x1a9,9,9);
                                                  uVar25 = func_0x000100331820(uRam00000001038f6ca0,
                                                                               0xb0);
                                                  StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                                                            (0x40a00000,uVar25,uVar16,uVar22,uVar17,
                                                             0,uVar14,uVar23);
                                                  DataMemoryBarrier(2,3);
                                                  *(undefined8 *)(param_1 + 200) = uVar25;
                                                  *(undefined1 *)
                                                   (((ulong)(param_1 + 200) >> 9 & 0x7fffff) + lVar9
                                                   ) = 1;
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
                }
              }
            }
          }
        }
      }
    }
  }
LAB_101e0a298:
  func_0x0001003316f4(0xee,uVar14);
                    /* WARNING: Does not return */
  pcVar11 = (code *)SoftwareBreakpoint(1,0x101e0a2a4);
  (*pcVar11)();
}

