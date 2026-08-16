/* 0x06005e1f StardewValley.Menus.MobileFarmChooser..ctor @ 0x101e14c0c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileFarmChooser__ctor_06005e1f
               (long param_1,int param_2,int param_3,int param_4,int param_5,int param_6,
               char param_7,undefined1 param_8)

{
  uint uVar1;
  int iVar2;
  int iVar3;
  undefined8 *puVar4;
  code *pcVar5;
  char cVar6;
  long lVar7;
  undefined8 uVar8;
  undefined8 uVar9;
  undefined8 uVar10;
  int iVar11;
  long *plVar12;
  long lVar13;
  long lVar14;
  undefined8 uVar15;
  undefined8 uVar16;
  undefined8 uVar17;
  float fVar18;
  float fVar19;
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
  undefined8 uStack_70;
  undefined8 uStack_68;
  
  cVar6 = cRam0000000103910c2e;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar6 == '\0') {
    func_0x00010119b908(&UNK_1033171c0);
    cRam0000000103910c2e = '\x01';
  }
  uStack_290 = 0;
  uStack_288 = 0;
  lVar7 = func_0x000100331820(uRam0000000103900640,0x20);
  lVar13 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar7 + 0x10) = *puRam0000000103900648;
  *(undefined1 *)(((ulong)(lVar7 + 0x10) >> 9 & 0x7fffff) + lVar13) = 1;
  uVar8 = _UNK_1036a1770;
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    plVar12 = (long *)(param_1 + 0x68);
    *plVar12 = lVar7;
    *(undefined1 *)(((ulong)plVar12 >> 9 & 0x7fffff) + lVar13) = 1;
    lVar7 = func_0x000100331820(uRam0000000103900358,0x20);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar7 + 0x10) = *puRam0000000103900360;
    *(undefined1 *)(((ulong)(lVar7 + 0x10) >> 9 & 0x7fffff) + lVar13) = 1;
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x108) = lVar7;
    *(undefined1 *)((param_1 + 0x108U >> 9 & 0x7fffff) + lVar13) = 1;
    lVar7 = func_0x000100331820(uRam0000000103900358,0x20);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar7 + 0x10) = *puRam0000000103900360;
    *(undefined1 *)(((ulong)(lVar7 + 0x10) >> 9 & 0x7fffff) + lVar13) = 1;
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x110) = lVar7;
    *(undefined1 *)((param_1 + 0x110U >> 9 & 0x7fffff) + lVar13) = 1;
    lVar7 = func_0x000100331820(uRam0000000103900358,0x20);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar7 + 0x10) = *puRam0000000103900360;
    *(undefined1 *)(((ulong)(lVar7 + 0x10) >> 9 & 0x7fffff) + lVar13) = 1;
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x118) = lVar7;
    *(undefined1 *)((param_1 + 0x118U >> 9 & 0x7fffff) + lVar13) = 1;
    lVar7 = func_0x000100331820(uRam0000000103900640,0x20);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar7 + 0x10) = *puRam0000000103900648;
    *(undefined1 *)(((ulong)(lVar7 + 0x10) >> 9 & 0x7fffff) + lVar13) = 1;
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x140) = lVar7;
    *(undefined1 *)((param_1 + 0x140U >> 9 & 0x7fffff) + lVar13) = 1;
    uVar8 = func_0x000100331820(uRam0000000103900650,0x50);
    func_0x000100377cf8();
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x148) = uVar8;
    *(undefined1 *)((param_1 + 0x148U >> 9 & 0x7fffff) + lVar13) = 1;
    StardewValley_StardewValley_Menus_IClickableMenu__ctor_06006162
              (param_1,param_2,param_3,param_4,param_5,0);
    *(int *)(param_1 + 0x1d8) = param_6;
    lVar7 = *plVar12;
    *(float *)(param_1 + 0x150) = (float)param_4 / 1280.0;
    *(float *)(param_1 + 0x154) = (float)param_5 / 720.0;
    uVar8 = _UNK_1036a1778;
    if (lVar7 != 0) {
      iVar11 = *(int *)(lVar7 + 0x18);
      *(undefined4 *)(lVar7 + 0x18) = 0;
      *(int *)(lVar7 + 0x1c) = *(int *)(lVar7 + 0x1c) + 1;
      if (0 < iVar11) {
        func_0x000100331c80(*(undefined8 *)(lVar7 + 0x10),0);
      }
      *(undefined8 *)(param_1 + 0x164) = 0x4c00000008;
      *(char *)(param_1 + 0x1c0) = param_7;
      *(undefined1 *)(param_1 + 0x1fe) = param_8;
      if (param_7 == '\0') {
        iVar11 = param_4 + -0x2b3;
        if (-1 < param_4 + -0x2b4) {
          iVar11 = param_4 + -0x2b4;
        }
        *(undefined4 *)(param_1 + 0x160) = 0xc;
        *(undefined4 *)(param_1 + 0x16c) = 0x4c;
        *(int *)(param_1 + 0x15c) = param_3 + 0x20;
        *(int *)(param_1 + 0x158) = param_2 + (iVar11 >> 1);
        uStack_1c0 = 0;
        uStack_1b8 = 0;
        func_0x00010034ede4(&uStack_1c0,param_2 + 0x10,param_3 + 0x7c,param_4 + -0x20,0x40);
        *(undefined8 *)(param_1 + 0x178) = uStack_1b8;
        *(undefined8 *)(param_1 + 0x170) = uStack_1c0;
        uVar8 = _UNK_1036a1780;
        if (param_1 == -0x170) goto LAB_101e16d60;
        uStack_1b0 = 0;
        uStack_1a8 = 0;
        func_0x00010034ede4(&uStack_1b0,param_2 + 0x10,
                            *(int *)(param_1 + 0x16c) + *(int *)(param_1 + 0x15c) + 0x38,
                            *(undefined4 *)(param_1 + 0x178),
                            (param_5 - *(int *)(param_1 + 0x16c)) + -0x38);
        if (param_4 < 0) {
          param_4 = param_4 + 1;
        }
        iVar11 = *(int *)(param_1 + 0x50) + (param_4 >> 1);
        *(undefined8 *)(param_1 + 0x188) = uStack_1a8;
        *(undefined8 *)(param_1 + 0x180) = uStack_1b0;
        uStack_1a0 = 0;
        uStack_198 = 0;
        func_0x00010034ede4(&uStack_1a0,iVar11 + -0x92,*(undefined4 *)(param_1 + 0x15c),0x50,0x4c);
        uVar15 = uRam0000000103900510;
        lVar7 = lRam00000001038c4c88;
        *(undefined8 *)(param_1 + 0x1e4) = uStack_198;
        *(undefined8 *)(param_1 + 0x1dc) = uStack_1a0;
        uVar9 = uRam00000001038c4f58;
        uVar8 = *(undefined8 *)(param_1 + 0x1dc);
        uVar10 = *(undefined8 *)(param_1 + 0x1e4);
        if (*(char *)(lVar7 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        uVar17 = *puRam00000001038d5350;
        uStack_190 = 0;
        uStack_188 = 0;
        func_0x00010034ede4(&uStack_190,0x50,0,0x14,0x13);
        uVar16 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
        StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                  (0x40800000,uVar16,uVar15,uVar8,uVar10,0,uVar9,uVar17);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 0xf8) = uVar16;
        *(undefined1 *)(((ulong)(param_1 + 0xf8) >> 9 & 0x7fffff) + lVar13) = 1;
        uStack_180 = 0;
        uStack_178 = 0;
        func_0x00010034ede4(&uStack_180,iVar11 + 0x4c,*(undefined4 *)(param_1 + 0x15c),0x50,0x4c);
        uVar10 = uRam0000000103900518;
        puVar4 = puRam00000001038d5350;
        *(undefined8 *)(param_1 + 500) = uStack_178;
        *(undefined8 *)(param_1 + 0x1ec) = uStack_180;
        uVar8 = uRam00000001038c4f58;
        uVar15 = *(undefined8 *)(param_1 + 0x1ec);
        uVar16 = *(undefined8 *)(param_1 + 500);
        uVar17 = *puVar4;
        uStack_170 = 0;
        uStack_168 = 0;
        func_0x00010034ede4(&uStack_170,100,0,0x14,0x13);
        uVar9 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
        StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                  (0x40800000,uVar9,uVar10,uVar15,uVar16,0,uVar8,uVar17);
        lVar7 = 0x100;
      }
      else {
        *(undefined1 *)(param_1 + 0x1fd) = 1;
        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        plVar12 = (long *)*plRam00000001038d5338;
        uVar8 = _UNK_1036a1968;
        if (plVar12 == (long *)0x0) goto LAB_101e16d60;
        uVar8 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam0000000103900548);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 0xa8) = uVar8;
        *(undefined1 *)(((ulong)(param_1 + 0xa8) >> 9 & 0x7fffff) + lVar13) = 1;
        uVar8 = _UNK_1036a1970;
        if (*plRam00000001038c4c90 == 0) goto LAB_101e16d60;
        fVar18 = (float)func_0x0001003560e4(*plRam00000001038c4c90,*(undefined8 *)(param_1 + 0xa8));
        fVar19 = *(float *)(param_1 + 0x154);
        *(undefined4 *)(param_1 + 0x16c) = 0x50;
        iVar2 = (*(int *)(param_1 + 0x168) + 0x20) * *(int *)(param_1 + 0x164);
        iVar3 = param_4 - iVar2;
        iVar11 = iVar3 + 0x20;
        *(undefined4 *)(param_1 + 0x160) = 0x20;
        iVar3 = iVar3 + 0x21;
        if (-1 < iVar11) {
          iVar3 = iVar11;
        }
        param_2 = param_2 + (iVar3 >> 1);
        *(int *)(param_1 + 0x1d4) = (int)fVar18;
        *(int *)(param_1 + 0x15c) = (int)(fVar19 * 124.0);
        *(int *)(param_1 + 0x158) = param_2;
        if (*(char *)(param_1 + 0x1fd) == '\0') {
          param_2 = param_2 + -0x40;
          iVar2 = iVar2 + 0x60;
        }
        else {
          iVar11 = param_4 * 3;
          param_2 = param_4 + 7;
          if (-1 < param_4) {
            param_2 = param_4;
          }
          iVar2 = iVar11 + 3;
          if (-1 < iVar11) {
            iVar2 = iVar11;
          }
          param_2 = param_2 >> 3;
          iVar2 = iVar2 >> 2;
        }
        uStack_280 = 0;
        uStack_278 = 0;
        func_0x00010034ede4(&uStack_280,param_2,(int)(fVar19 * 252.0),iVar2,(int)(fVar19 * 64.0));
        *(undefined8 *)(param_1 + 0x178) = uStack_278;
        *(undefined8 *)(param_1 + 0x170) = uStack_280;
        uVar8 = _UNK_1036a1978;
        if (param_1 == -0x170) goto LAB_101e16d60;
        uStack_270 = 0;
        uStack_268 = 0;
        iVar11 = (int)(*(float *)(param_1 + 0x154) * 336.0);
        func_0x00010034ede4(&uStack_270,*(undefined4 *)(param_1 + 0x170),iVar11,
                            *(undefined4 *)(param_1 + 0x178),iVar11);
        lVar7 = lRam00000001038c4c88;
        *(undefined8 *)(param_1 + 0x188) = uStack_268;
        *(undefined8 *)(param_1 + 0x180) = uStack_270;
        if (*(char *)(lVar7 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        plVar12 = (long *)*plRam00000001038d5338;
        uVar8 = _UNK_1036a1980;
        if ((plVar12 == (long *)0x0) ||
           (lVar7 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam0000000103900400),
           uVar8 = _UNK_1036a1988, lVar7 == 0)) goto LAB_101e16d60;
        uVar8 = func_0x000100331fdc(lVar7,uRam00000001038d7278,uRam00000001038c4d00);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 0xb0) = uVar8;
        *(undefined1 *)(((ulong)(param_1 + 0xb0) >> 9 & 0x7fffff) + lVar13) = 1;
        lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar8 = _UNK_1036a1998;
        if (*(long *)(lVar7 + 0x2a0) == 0) goto LAB_101e16d60;
        cVar6 = func_0x000100345aa0(*(undefined8 *)(*(long *)(lVar7 + 0x2a0) + 0x60),
                                    uRam00000001038c4f58);
        if (cVar6 != '\0') {
          lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          uVar8 = _UNK_1036a1a88;
          if (*(long *)(lVar7 + 0x2a0) == 0) goto LAB_101e16d60;
          func_0x000100354118(*(long *)(lVar7 + 0x2a0),*(undefined8 *)(param_1 + 0xb0));
        }
        uVar8 = _UNK_1036a19a8;
        if (param_1 == -0x180) goto LAB_101e16d60;
        iVar11 = param_4;
        if (param_4 < 0) {
          iVar11 = param_4 + 1;
        }
        uStack_260 = 0;
        uStack_258 = 0;
        func_0x00010034ede4(&uStack_260,(iVar11 >> 1) + -0xb4,
                            *(int *)(param_1 + 0x184) + *(int *)(param_1 + 0x18c) + 0x10,
                            0x168 - *(int *)(param_1 + 0x1d4),0x40);
        *(undefined8 *)(param_1 + 0x1cc) = uStack_258;
        *(undefined8 *)(param_1 + 0x1c4) = uStack_260;
        func_0x00010034ede4(&uStack_290,
                            *(int *)(param_1 + 0x50) + (int)(*(float *)(param_1 + 0x150) * 148.0),
                            (int)(*(float *)(param_1 + 0x154) * 572.0),
                            param_4 - (int)(*(float *)(param_1 + 0x150) * 296.0),
                            (int)(*(float *)(param_1 + 0x154) * 120.0));
        iVar11 = uStack_288._4_4_ + -0x4f;
        if (-1 < uStack_288._4_4_ + -0x50) {
          iVar11 = uStack_288._4_4_ + -0x50;
        }
        uStack_250 = 0;
        uStack_248 = 0;
        func_0x00010034ede4(&uStack_250,
                            (int)uStack_288 + (int)uStack_290 +
                            (int)(*(float *)(param_1 + 0x150) * 12.0),
                            uStack_290._4_4_ + (iVar11 >> 1),0x50,0x50);
        lVar7 = lRam00000001038c4c88;
        *(undefined8 *)(param_1 + 0x198) = uStack_248;
        *(undefined8 *)(param_1 + 400) = uStack_250;
        uVar9 = uRam00000001039004f0;
        uVar8 = *(undefined8 *)(param_1 + 400);
        uVar10 = *(undefined8 *)(param_1 + 0x198);
        if (*(char *)(lVar7 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        uVar15 = *puRam00000001038d5350;
        uStack_240 = 0;
        uStack_238 = 0;
        func_0x00010034ede4(&uStack_240,0,0,0x14,0x14);
        lVar7 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
        StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                  (0x40800000,lVar7,uVar9,uVar8,uVar10,0,0,uVar15);
        DataMemoryBarrier(2,3);
        plVar12 = (long *)(param_1 + 0x88);
        *plVar12 = lVar7;
        *(undefined1 *)(((ulong)plVar12 >> 9 & 0x7fffff) + lVar13) = 1;
        lVar7 = *plVar12;
        uVar8 = _UNK_1036a19b0;
        if ((lVar7 == 0) || (uVar8 = _UNK_1036a19b8, lVar7 == -0x38)) goto LAB_101e16d60;
        uStack_230 = 0;
        uStack_228 = 0;
        func_0x00010034ede4(&uStack_230,*(int *)(param_1 + 0x50) + 0x20,
                            *(undefined4 *)(lVar7 + 0x3c),0x50,0x4c);
        puVar4 = puRam00000001038d5350;
        *(undefined8 *)(param_1 + 0x1a8) = uStack_228;
        *(undefined8 *)(param_1 + 0x1a0) = uStack_230;
        uVar9 = uRam00000001038c90d0;
        uVar8 = *(undefined8 *)(param_1 + 0x1a0);
        uVar10 = *(undefined8 *)(param_1 + 0x1a8);
        uVar16 = *puVar4;
        uStack_220 = 0;
        uStack_218 = 0;
        func_0x00010034ede4(&uStack_220,0x50,0,0x14,0x13);
        uVar15 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
        StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                  (0x40800000,uVar15,uVar9,uVar8,uVar10,0,0,uVar16);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 0x90) = uVar15;
        *(undefined1 *)(((ulong)(param_1 + 0x90) >> 9 & 0x7fffff) + lVar13) = 1;
        *puRam00000001038d7c40 = (uint)(param_6 == 3);
        lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar8 = _UNK_1036a19c0;
        if (lVar7 == 0) goto LAB_101e16d60;
        *(undefined4 *)(lVar7 + 0x748) = 0x3f800000;
        lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar8 = _UNK_1036a19c8;
        if (lVar7 == 0) goto LAB_101e16d60;
        lVar7 = StardewValley_StardewValley_Farmer_get_team_06003559();
        uVar8 = _UNK_1036a19d8;
        if (*(long *)(lVar7 + 0x28) == 0) goto LAB_101e16d60;
        func_0x00010035197c(*(long *)(lVar7 + 0x28),0);
        plVar12 = (long *)*plRam00000001038d5338;
        uVar8 = _UNK_1036a19e0;
        if (plVar12 == (long *)0x0) goto LAB_101e16d60;
        uVar8 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam00000001039006d0);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 0xc0) = uVar8;
        *(undefined1 *)(((ulong)(param_1 + 0xc0) >> 9 & 0x7fffff) + lVar13) = 1;
        plVar12 = (long *)*plRam00000001038d5338;
        uVar8 = _UNK_1036a19e8;
        if (plVar12 == (long *)0x0) goto LAB_101e16d60;
        uVar8 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam00000001039006d8);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 200) = uVar8;
        *(undefined1 *)(((ulong)(param_1 + 200) >> 9 & 0x7fffff) + lVar13) = 1;
        plVar12 = (long *)*plRam00000001038d5338;
        uVar8 = _UNK_1036a19f0;
        if (plVar12 == (long *)0x0) goto LAB_101e16d60;
        uVar8 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam00000001039006e0);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 0xd0) = uVar8;
        *(undefined1 *)(((ulong)(param_1 + 0xd0) >> 9 & 0x7fffff) + lVar13) = 1;
        plVar12 = (long *)*plRam00000001038d5338;
        uVar8 = _UNK_1036a19f8;
        if (plVar12 == (long *)0x0) goto LAB_101e16d60;
        uVar8 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam00000001039006e8);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 0xd8) = uVar8;
        *(undefined1 *)(((ulong)(param_1 + 0xd8) >> 9 & 0x7fffff) + lVar13) = 1;
        plVar12 = (long *)*plRam00000001038d5338;
        uVar8 = _UNK_1036a1a00;
        if (plVar12 == (long *)0x0) goto LAB_101e16d60;
        uVar8 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam00000001039006f0);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 0xe0) = uVar8;
        *(undefined1 *)(((ulong)(param_1 + 0xe0) >> 9 & 0x7fffff) + lVar13) = 1;
        plVar12 = (long *)*plRam00000001038d5338;
        uVar8 = _UNK_1036a1a08;
        if (plVar12 == (long *)0x0) goto LAB_101e16d60;
        uVar8 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam00000001039006f8);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 0xf0) = uVar8;
        *(undefined1 *)(((ulong)(param_1 + 0xf0) >> 9 & 0x7fffff) + lVar13) = 1;
        plVar12 = (long *)*plRam00000001038d5338;
        uVar8 = _UNK_1036a1a10;
        if (plVar12 == (long *)0x0) goto LAB_101e16d60;
        uVar8 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam0000000103900700);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 0xe8) = uVar8;
        *(undefined1 *)(((ulong)(param_1 + 0xe8) >> 9 & 0x7fffff) + lVar13) = 1;
        uVar10 = uRam0000000103900708;
        plVar12 = (long *)*plRam00000001038d5338;
        uVar8 = _UNK_1036a1a18;
        if (plVar12 == (long *)0x0) goto LAB_101e16d60;
        uVar8 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam0000000103900710);
        uVar9 = func_0x000100331794(uRam00000001038c4f40,1);
        func_0x000100331f8c(uVar9,0,*(undefined8 *)(param_1 + 0xc0));
        uVar8 = SDV_StardewValley_Menus_MobileFarmChooser___ctor_g__AddCarousel_53_0_06005e2a
                          (param_1,uVar10,uVar8,0x2c,0x10,0,uVar9);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 0x120) = uVar8;
        *(undefined1 *)((param_1 + 0x120U >> 9 & 0x7fffff) + lVar13) = 1;
        plVar12 = (long *)*plRam00000001038d5338;
        uVar8 = _UNK_1036a1a20;
        if (plVar12 == (long *)0x0) goto LAB_101e16d60;
        lVar7 = *(long *)(param_1 + 0x108);
        iVar2 = *(int *)(param_1 + 0x180);
        lVar14 = *plRam00000001038d5f08;
        iVar11 = *(int *)(param_1 + 0x188);
        uVar10 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam0000000103900718);
        uVar8 = _UNK_1036a1a28;
        if (lVar14 == 0) goto LAB_101e16d60;
        fVar18 = (float)func_0x0001003560e4(lVar14,uVar10);
        iVar11 = iVar11 - (int)fVar18;
        uStack_210 = 0;
        uStack_208 = 0;
        if (iVar11 < 0) {
          iVar11 = iVar11 + 1;
        }
        func_0x00010034ede4(&uStack_210,iVar2 + (iVar11 >> 1),*(int *)(param_1 + 0x184) + 0x10,1,1);
        uVar9 = uStack_208;
        uVar10 = uStack_210;
        plVar12 = (long *)*plRam00000001038d5338;
        uVar8 = _UNK_1036a1a30;
        if (plVar12 == (long *)0x0) goto LAB_101e16d60;
        uVar8 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam0000000103900718);
        lVar14 = func_0x000100331820(uRam00000001038f6cb0,0x78);
        *(undefined1 *)(lVar14 + 0x4c) = 1;
        *(undefined8 *)(lVar14 + 0x38) = uVar10;
        *(undefined8 *)(lVar14 + 0x40) = uVar9;
        *(undefined4 *)(lVar14 + 0x48) = 0x3f800000;
        *(undefined8 *)(lVar14 + 0x54) = 0xfffffe0cfffffe0c;
        *(undefined8 *)(lVar14 + 0x5c) = 0xffffffffffffffff;
        *(undefined8 *)(lVar14 + 100) = 0xffffffffffffffff;
        DataMemoryBarrier(2,3);
        *(undefined8 *)(lVar14 + 0x10) = uVar8;
        *(undefined1 *)(((ulong)(lVar14 + 0x10) >> 9 & 0x7fffff) + lVar13) = 1;
        DataMemoryBarrier(2,3);
        *(long *)(param_1 + 0x128) = lVar14;
        *(undefined1 *)((param_1 + 0x128U >> 9 & 0x7fffff) + lVar13) = 1;
        uVar8 = _UNK_1036a1a38;
        if (lVar7 == 0) goto LAB_101e16d60;
        plVar12 = *(long **)(lVar7 + 0x10);
        *(int *)(lVar7 + 0x1c) = *(int *)(lVar7 + 0x1c) + 1;
        uVar8 = _UNK_1036a1a40;
        if (plVar12 == (long *)0x0) goto LAB_101e16d60;
        if (*(uint *)(lVar7 + 0x18) < *(uint *)(plVar12 + 3)) {
          *(uint *)(lVar7 + 0x18) = *(uint *)(lVar7 + 0x18) + 1;
          (**(code **)(*plVar12 + 0x110))();
        }
        else {
          func_0x000100377424(lVar7,lVar14);
        }
        uVar10 = uRam0000000103900720;
        iVar11 = *(int *)(param_1 + 0x188) + 0x40;
        iVar2 = *(int *)(param_1 + 0x188) + 0x41;
        if (-1 < iVar11) {
          iVar2 = iVar11;
        }
        lVar7 = *(long *)(param_1 + 0x140);
        uStack_200 = 0;
        uStack_1f8 = 0;
        func_0x00010034ede4(&uStack_200,*(int *)(param_1 + 0x180) + (iVar2 >> 1),
                            *(int *)(param_1 + 0x184) + 0x38,0x40,0x40);
        uVar15 = uStack_1f8;
        uVar9 = uStack_200;
        plVar12 = (long *)*plRam00000001038d5338;
        uVar8 = _UNK_1036a1a48;
        if (plVar12 == (long *)0x0) goto LAB_101e16d60;
        uVar8 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam0000000103900728);
        uVar17 = *puRam00000001038d53d0;
        uStack_1f0 = 0;
        uStack_1e8 = 0;
        func_0x00010034ede4(&uStack_1f0,0xd0,0xc0,0x10,0x10);
        uVar16 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
        StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                  (0x40800000,uVar16,uVar10,uVar9,uVar15,0,uVar8,uVar17);
        plVar12 = *(long **)(lVar7 + 0x10);
        *(int *)(lVar7 + 0x1c) = *(int *)(lVar7 + 0x1c) + 1;
        uVar8 = _UNK_1036a1a58;
        if (plVar12 == (long *)0x0) goto LAB_101e16d60;
        uVar1 = *(uint *)(lVar7 + 0x18);
        if (uVar1 < *(uint *)(plVar12 + 3)) {
          *(uint *)(lVar7 + 0x18) = uVar1 + 1;
          (**(code **)(*plVar12 + 0x110))(plVar12,(long)(int)uVar1,uVar16);
        }
        else {
          func_0x000100377d0c(lVar7,uVar16);
        }
        uVar10 = uRam0000000103900730;
        iVar2 = *(int *)(param_1 + 0x188) + -0xac;
        iVar11 = *(int *)(param_1 + 0x188) + -0xab;
        if (-1 < iVar2) {
          iVar11 = iVar2;
        }
        lVar7 = *(long *)(param_1 + 0x140);
        uStack_1e0 = 0;
        uStack_1d8 = 0;
        func_0x00010034ede4(&uStack_1e0,*(int *)(param_1 + 0x180) + (iVar11 >> 1),
                            *(int *)(param_1 + 0x184) + 0x38,0x40,0x40);
        uVar15 = uStack_1d8;
        uVar9 = uStack_1e0;
        plVar12 = (long *)*plRam00000001038d5338;
        uVar8 = _UNK_1036a1a60;
        if (plVar12 == (long *)0x0) goto LAB_101e16d60;
        uVar8 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam0000000103900738);
        uVar17 = *puRam00000001038d53d0;
        uStack_1d0 = 0;
        uStack_1c8 = 0;
        func_0x00010034ede4(&uStack_1d0,0xe0,0xc0,0x10,0x10);
        uVar16 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
        StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                  (0x40800000,uVar16,uVar10,uVar9,uVar15,0,uVar8,uVar17);
        plVar12 = *(long **)(lVar7 + 0x10);
        *(int *)(lVar7 + 0x1c) = *(int *)(lVar7 + 0x1c) + 1;
        uVar8 = _UNK_1036a1a70;
        if (plVar12 == (long *)0x0) goto LAB_101e16d60;
        uVar1 = *(uint *)(lVar7 + 0x18);
        if (uVar1 < *(uint *)(plVar12 + 3)) {
          *(uint *)(lVar7 + 0x18) = uVar1 + 1;
          (**(code **)(*plVar12 + 0x110))(plVar12,(long)(int)uVar1,uVar16);
        }
        else {
          func_0x000100377d0c(lVar7,uVar16);
        }
        uVar10 = uRam0000000103900740;
        plVar12 = (long *)*plRam00000001038d5338;
        uVar8 = _UNK_1036a1a78;
        if (plVar12 == (long *)0x0) goto LAB_101e16d60;
        uVar8 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam0000000103900748);
        uVar9 = func_0x000100331794(uRam00000001038c4f40,4);
        func_0x000100331f8c(uVar9,0,*(undefined8 *)(param_1 + 200));
        func_0x000100331f8c(uVar9,1,*(undefined8 *)(param_1 + 0xd0));
        func_0x000100331f8c(uVar9,2,*(undefined8 *)(param_1 + 0xd8));
        func_0x000100331f8c(uVar9,3,*(undefined8 *)(param_1 + 0xe0));
        uVar8 = SDV_StardewValley_Menus_MobileFarmChooser___ctor_g__AddCarousel_53_0_06005e2a
                          (param_1,uVar10,uVar8,0xffffffd4,0x10,2,uVar9);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 0x130) = uVar8;
        *(undefined1 *)((param_1 + 0x130U >> 9 & 0x7fffff) + lVar13) = 1;
        uVar10 = uRam0000000103900750;
        plVar12 = (long *)*plRam00000001038d5338;
        uVar8 = _UNK_1036a1a80;
        if (plVar12 == (long *)0x0) goto LAB_101e16d60;
        uVar8 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam0000000103900758);
        uVar9 = func_0x000100331794(uRam00000001038c4f40,2);
        func_0x000100331f8c(uVar9,0,*(undefined8 *)(param_1 + 0xf0));
        func_0x000100331f8c(uVar9,1,*(undefined8 *)(param_1 + 0xe8));
        uVar9 = SDV_StardewValley_Menus_MobileFarmChooser___ctor_g__AddCarousel_53_0_06005e2a
                          (param_1,uVar10,uVar8,0,0x9c,1,uVar9);
        lVar7 = 0x138;
      }
      DataMemoryBarrier(2,3);
      *(undefined8 *)(param_1 + lVar7) = uVar9;
      *(undefined1 *)(lVar13 + (ulong)((uint)((int)lVar7 + (int)param_1) >> 9)) = 1;
      uVar10 = uRam00000001038d7a50;
      uStack_160 = 0;
      uStack_158 = 0;
      lVar13 = *(long *)(param_1 + 0x68);
      func_0x00010034ede4(&uStack_160,*(undefined4 *)(param_1 + 0x158),
                          *(undefined4 *)(param_1 + 0x15c),0x4c,0x4c);
      uVar15 = uStack_158;
      uVar9 = uStack_160;
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      plVar12 = (long *)*plRam00000001038d5338;
      uVar8 = _UNK_1036a1788;
      if (plVar12 != (long *)0x0) {
        uVar8 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam0000000103900660);
        uVar17 = *puRam00000001038d53d0;
        uStack_150 = 0;
        uStack_148 = 0;
        func_0x00010034ede4(&uStack_150,0,0x144,0x16,0x14);
        uVar16 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
        StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                  (0x40800000,uVar16,uVar10,uVar9,uVar15,0,uVar8,uVar17);
        plVar12 = *(long **)(lVar13 + 0x10);
        *(int *)(lVar13 + 0x1c) = *(int *)(lVar13 + 0x1c) + 1;
        uVar8 = _UNK_1036a1798;
        if (plVar12 != (long *)0x0) {
          uVar1 = *(uint *)(lVar13 + 0x18);
          if (uVar1 < *(uint *)(plVar12 + 3)) {
            *(uint *)(lVar13 + 0x18) = uVar1 + 1;
            (**(code **)(*plVar12 + 0x110))(plVar12,(long)(int)uVar1,uVar16);
          }
          else {
            func_0x000100377d0c(lVar13,uVar16);
          }
          iVar11 = *(int *)(*(long *)(param_1 + 0x68) + 0x18);
          if (iVar11 == 0) {
LAB_101e168b0:
            func_0x000100331b90();
                    /* WARNING: Does not return */
            pcVar5 = (code *)SoftwareBreakpoint(1,0x101e168b8);
            (*pcVar5)();
          }
          lVar13 = *(long *)(*(long *)(param_1 + 0x68) + 0x10);
          uVar1 = iVar11 - 1;
          uVar8 = _UNK_1036a17b0;
          if (*(uint *)(lVar13 + 0x18) <= uVar1) {
LAB_101e16b6c:
            func_0x0001003316f4(0xcc,uVar8);
                    /* WARNING: Does not return */
            pcVar5 = (code *)SoftwareBreakpoint(1,0x101e16b78);
            (*pcVar5)();
          }
          uVar8 = _UNK_1036a17b8;
          if (*(long *)(param_1 + 0x148) != 0) {
            func_0x000100377d20(*(long *)(param_1 + 0x148),0,
                                *(undefined8 *)(lVar13 + (long)(int)uVar1 * 8 + 0x20));
            uVar10 = uRam00000001038e3000;
            lVar13 = *(long *)(param_1 + 0x68);
            uStack_140 = 0;
            uStack_138 = 0;
            func_0x00010034ede4(&uStack_140,
                                *(int *)(param_1 + 0x168) + *(int *)(param_1 + 0x158) +
                                *(int *)(param_1 + 0x160),*(undefined4 *)(param_1 + 0x15c),0x4c,0x4c
                               );
            uVar15 = uStack_138;
            uVar9 = uStack_140;
            plVar12 = (long *)*plRam00000001038d5338;
            uVar8 = _UNK_1036a17c0;
            if (plVar12 != (long *)0x0) {
              uVar8 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam0000000103900678);
              uVar17 = *puRam00000001038d53d0;
              uStack_130 = 0;
              uStack_128 = 0;
              func_0x00010034ede4(&uStack_130,0x16,0x144,0x16,0x14);
              uVar16 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
              StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                        (0x40800000,uVar16,uVar10,uVar9,uVar15,0,uVar8,uVar17);
              plVar12 = *(long **)(lVar13 + 0x10);
              *(int *)(lVar13 + 0x1c) = *(int *)(lVar13 + 0x1c) + 1;
              uVar8 = _UNK_1036a17d0;
              if (plVar12 != (long *)0x0) {
                uVar1 = *(uint *)(lVar13 + 0x18);
                if (uVar1 < *(uint *)(plVar12 + 3)) {
                  *(uint *)(lVar13 + 0x18) = uVar1 + 1;
                  (**(code **)(*plVar12 + 0x110))(plVar12,(long)(int)uVar1,uVar16);
                }
                else {
                  func_0x000100377d0c(lVar13,uVar16);
                }
                iVar11 = *(int *)(*(long *)(param_1 + 0x68) + 0x18);
                if (iVar11 == 0) goto LAB_101e168b0;
                lVar13 = *(long *)(*(long *)(param_1 + 0x68) + 0x10);
                uVar1 = iVar11 - 1;
                uVar8 = _UNK_1036a17e8;
                if (*(uint *)(lVar13 + 0x18) <= uVar1) goto LAB_101e16b6c;
                uVar8 = _UNK_1036a17f0;
                if (*(long *)(param_1 + 0x148) != 0) {
                  func_0x000100377d20(*(long *)(param_1 + 0x148),1,
                                      *(undefined8 *)(lVar13 + (long)(int)uVar1 * 8 + 0x20));
                  uVar10 = uRam00000001038e5368;
                  lVar13 = *(long *)(param_1 + 0x68);
                  uStack_120 = 0;
                  uStack_118 = 0;
                  func_0x00010034ede4(&uStack_120,
                                      *(int *)(param_1 + 0x158) +
                                      (*(int *)(param_1 + 0x160) + *(int *)(param_1 + 0x168)) * 2,
                                      *(undefined4 *)(param_1 + 0x15c),0x4c,0x4c);
                  uVar15 = uStack_118;
                  uVar9 = uStack_120;
                  plVar12 = (long *)*plRam00000001038d5338;
                  uVar8 = _UNK_1036a17f8;
                  if (plVar12 != (long *)0x0) {
                    uVar8 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam0000000103900680);
                    uVar17 = *puRam00000001038d53d0;
                    uStack_110 = 0;
                    uStack_108 = 0;
                    func_0x00010034ede4(&uStack_110,0x2c,0x144,0x16,0x14);
                    uVar16 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
                    StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                              (0x40800000,uVar16,uVar10,uVar9,uVar15,0,uVar8,uVar17);
                    plVar12 = *(long **)(lVar13 + 0x10);
                    *(int *)(lVar13 + 0x1c) = *(int *)(lVar13 + 0x1c) + 1;
                    uVar8 = _UNK_1036a1808;
                    if (plVar12 != (long *)0x0) {
                      uVar1 = *(uint *)(lVar13 + 0x18);
                      if (uVar1 < *(uint *)(plVar12 + 3)) {
                        *(uint *)(lVar13 + 0x18) = uVar1 + 1;
                        (**(code **)(*plVar12 + 0x110))(plVar12,(long)(int)uVar1,uVar16);
                      }
                      else {
                        func_0x000100377d0c(lVar13,uVar16);
                      }
                      iVar11 = *(int *)(*(long *)(param_1 + 0x68) + 0x18);
                      if (iVar11 == 0) goto LAB_101e168b0;
                      lVar13 = *(long *)(*(long *)(param_1 + 0x68) + 0x10);
                      uVar1 = iVar11 - 1;
                      uVar8 = _UNK_1036a1820;
                      if (*(uint *)(lVar13 + 0x18) <= uVar1) goto LAB_101e16b6c;
                      uVar8 = _UNK_1036a1828;
                      if (*(long *)(param_1 + 0x148) != 0) {
                        func_0x000100377d20(*(long *)(param_1 + 0x148),2,
                                            *(undefined8 *)(lVar13 + (long)(int)uVar1 * 8 + 0x20));
                        uVar10 = uRam00000001038e5370;
                        lVar13 = *(long *)(param_1 + 0x68);
                        uStack_100 = 0;
                        uStack_f8 = 0;
                        func_0x00010034ede4(&uStack_100,
                                            (*(int *)(param_1 + 0x160) + *(int *)(param_1 + 0x168))
                                            * 3 + *(int *)(param_1 + 0x158),
                                            *(undefined4 *)(param_1 + 0x15c),0x4c,0x4c);
                        uVar15 = uStack_f8;
                        uVar9 = uStack_100;
                        plVar12 = (long *)*plRam00000001038d5338;
                        uVar8 = _UNK_1036a1830;
                        if (plVar12 != (long *)0x0) {
                          uVar8 = (**(code **)(*plVar12 + 0x100))(plVar12,uRam0000000103900688);
                          uVar17 = *puRam00000001038d53d0;
                          uStack_f0 = 0;
                          uStack_e8 = 0;
                          func_0x00010034ede4(&uStack_f0,0x42,0x144,0x16,0x14);
                          uVar16 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
                          StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                                    (0x40800000,uVar16,uVar10,uVar9,uVar15,0,uVar8,uVar17);
                          plVar12 = *(long **)(lVar13 + 0x10);
                          *(int *)(lVar13 + 0x1c) = *(int *)(lVar13 + 0x1c) + 1;
                          uVar8 = _UNK_1036a1840;
                          if (plVar12 != (long *)0x0) {
                            uVar1 = *(uint *)(lVar13 + 0x18);
                            if (uVar1 < *(uint *)(plVar12 + 3)) {
                              *(uint *)(lVar13 + 0x18) = uVar1 + 1;
                              (**(code **)(*plVar12 + 0x110))(plVar12,(long)(int)uVar1,uVar16);
                            }
                            else {
                              func_0x000100377d0c(lVar13,uVar16);
                            }
                            iVar11 = *(int *)(*(long *)(param_1 + 0x68) + 0x18);
                            if (iVar11 == 0) goto LAB_101e168b0;
                            lVar13 = *(long *)(*(long *)(param_1 + 0x68) + 0x10);
                            uVar1 = iVar11 - 1;
                            uVar8 = _UNK_1036a1858;
                            if (*(uint *)(lVar13 + 0x18) <= uVar1) goto LAB_101e16b6c;
                            uVar8 = _UNK_1036a1860;
                            if (*(long *)(param_1 + 0x148) != 0) {
                              func_0x000100377d20(*(long *)(param_1 + 0x148),3,
                                                  *(undefined8 *)
                                                   (lVar13 + (long)(int)uVar1 * 8 + 0x20));
                              uVar10 = uRam00000001038e5378;
                              lVar13 = *(long *)(param_1 + 0x68);
                              uStack_e0 = 0;
                              uStack_d8 = 0;
                              func_0x00010034ede4(&uStack_e0,
                                                  *(int *)(param_1 + 0x158) +
                                                  (*(int *)(param_1 + 0x160) +
                                                  *(int *)(param_1 + 0x168)) * 4,
                                                  *(undefined4 *)(param_1 + 0x15c),0x4c,0x4c);
                              uVar15 = uStack_d8;
                              uVar9 = uStack_e0;
                              plVar12 = (long *)*plRam00000001038d5338;
                              uVar8 = _UNK_1036a1868;
                              if (plVar12 != (long *)0x0) {
                                uVar8 = (**(code **)(*plVar12 + 0x100))
                                                  (plVar12,uRam0000000103900690);
                                uVar17 = *puRam00000001038d53d0;
                                uStack_d0 = 0;
                                uStack_c8 = 0;
                                func_0x00010034ede4(&uStack_d0,0x58,0x144,0x16,0x14);
                                uVar16 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
                                StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                                          (0x40800000,uVar16,uVar10,uVar9,uVar15,0,uVar8,uVar17);
                                plVar12 = *(long **)(lVar13 + 0x10);
                                *(int *)(lVar13 + 0x1c) = *(int *)(lVar13 + 0x1c) + 1;
                                uVar8 = _UNK_1036a1878;
                                if (plVar12 != (long *)0x0) {
                                  uVar1 = *(uint *)(lVar13 + 0x18);
                                  if (uVar1 < *(uint *)(plVar12 + 3)) {
                                    *(uint *)(lVar13 + 0x18) = uVar1 + 1;
                                    (**(code **)(*plVar12 + 0x110))(plVar12,(long)(int)uVar1,uVar16)
                                    ;
                                  }
                                  else {
                                    func_0x000100377d0c(lVar13,uVar16);
                                  }
                                  iVar11 = *(int *)(*(long *)(param_1 + 0x68) + 0x18);
                                  if (iVar11 == 0) goto LAB_101e168b0;
                                  lVar13 = *(long *)(*(long *)(param_1 + 0x68) + 0x10);
                                  uVar1 = iVar11 - 1;
                                  uVar8 = _UNK_1036a1890;
                                  if (*(uint *)(lVar13 + 0x18) <= uVar1) goto LAB_101e16b6c;
                                  uVar8 = _UNK_1036a1898;
                                  if (*(long *)(param_1 + 0x148) != 0) {
                                    func_0x000100377d20(*(long *)(param_1 + 0x148),4,
                                                        *(undefined8 *)
                                                         (lVar13 + (long)(int)uVar1 * 8 + 0x20));
                                    uVar10 = uRam00000001038d7a70;
                                    lVar13 = *(long *)(param_1 + 0x68);
                                    uStack_b8 = 0;
                                    uStack_c0 = 0;
                                    func_0x00010034ede4(&uStack_c0,
                                                        (*(int *)(param_1 + 0x160) +
                                                        *(int *)(param_1 + 0x168)) * 5 +
                                                        *(int *)(param_1 + 0x158),
                                                        *(undefined4 *)(param_1 + 0x15c),0x4c,0x4c);
                                    uVar15 = uStack_b8;
                                    uVar9 = uStack_c0;
                                    plVar12 = (long *)*plRam00000001038d5338;
                                    uVar8 = _UNK_1036a18a0;
                                    if (plVar12 != (long *)0x0) {
                                      uVar8 = (**(code **)(*plVar12 + 0x100))
                                                        (plVar12,uRam0000000103900698);
                                      uVar17 = *puRam00000001038d53d0;
                                      uStack_b0 = 0;
                                      uStack_a8 = 0;
                                      func_0x00010034ede4(&uStack_b0,0,0x159,0x16,0x14);
                                      uVar16 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
                                      StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                                                (0x40800000,uVar16,uVar10,uVar9,uVar15,0,uVar8,
                                                 uVar17);
                                      plVar12 = *(long **)(lVar13 + 0x10);
                                      *(int *)(lVar13 + 0x1c) = *(int *)(lVar13 + 0x1c) + 1;
                                      uVar8 = _UNK_1036a18b0;
                                      if (plVar12 != (long *)0x0) {
                                        uVar1 = *(uint *)(lVar13 + 0x18);
                                        if (uVar1 < *(uint *)(plVar12 + 3)) {
                                          *(uint *)(lVar13 + 0x18) = uVar1 + 1;
                                          (**(code **)(*plVar12 + 0x110))
                                                    (plVar12,(long)(int)uVar1,uVar16);
                                        }
                                        else {
                                          func_0x000100377d0c(lVar13,uVar16);
                                        }
                                        iVar11 = *(int *)(*(long *)(param_1 + 0x68) + 0x18);
                                        if (iVar11 == 0) goto LAB_101e168b0;
                                        lVar13 = *(long *)(*(long *)(param_1 + 0x68) + 0x10);
                                        uVar1 = iVar11 - 1;
                                        uVar8 = _UNK_1036a18c8;
                                        if (*(uint *)(lVar13 + 0x18) <= uVar1) goto LAB_101e16b6c;
                                        uVar8 = _UNK_1036a18d0;
                                        if (*(long *)(param_1 + 0x148) != 0) {
                                          func_0x000100377d20(*(long *)(param_1 + 0x148),5,
                                                              *(undefined8 *)
                                                               (lVar13 + (long)(int)uVar1 * 8 + 0x20
                                                               ));
                                          uVar10 = uRam00000001038c6b58;
                                          lVar13 = *(long *)(param_1 + 0x68);
                                          uStack_98 = 0;
                                          uStack_a0 = 0;
                                          func_0x00010034ede4(&uStack_a0,
                                                              *(int *)(param_1 + 0x158) +
                                                              (*(int *)(param_1 + 0x160) +
                                                              *(int *)(param_1 + 0x168)) * 6,
                                                              *(undefined4 *)(param_1 + 0x15c),0x4c,
                                                              0x4c);
                                          uVar15 = uStack_98;
                                          uVar9 = uStack_a0;
                                          plVar12 = (long *)*plRam00000001038d5338;
                                          uVar8 = _UNK_1036a18d8;
                                          if (plVar12 != (long *)0x0) {
                                            uVar8 = (**(code **)(*plVar12 + 0x100))
                                                              (plVar12,uRam00000001039006a0);
                                            uVar17 = *puRam00000001038d53d0;
                                            uStack_90 = 0;
                                            uStack_88 = 0;
                                            func_0x00010034ede4(&uStack_90,0x16,0x159,0x16,0x14);
                                            uVar16 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
                                            StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                                                      (0x40800000,uVar16,uVar10,uVar9,uVar15,0,uVar8
                                                       ,uVar17);
                                            plVar12 = *(long **)(lVar13 + 0x10);
                                            *(int *)(lVar13 + 0x1c) = *(int *)(lVar13 + 0x1c) + 1;
                                            uVar8 = _UNK_1036a18e8;
                                            if (plVar12 != (long *)0x0) {
                                              uVar1 = *(uint *)(lVar13 + 0x18);
                                              if (uVar1 < *(uint *)(plVar12 + 3)) {
                                                *(uint *)(lVar13 + 0x18) = uVar1 + 1;
                                                (**(code **)(*plVar12 + 0x110))
                                                          (plVar12,(long)(int)uVar1,uVar16);
                                              }
                                              else {
                                                func_0x000100377d0c(lVar13,uVar16);
                                              }
                                              iVar11 = *(int *)(*(long *)(param_1 + 0x68) + 0x18);
                                              if (iVar11 == 0) goto LAB_101e168b0;
                                              lVar13 = *(long *)(*(long *)(param_1 + 0x68) + 0x10);
                                              uVar1 = iVar11 - 1;
                                              uVar8 = _UNK_1036a1900;
                                              if (*(uint *)(lVar13 + 0x18) <= uVar1)
                                              goto LAB_101e16b6c;
                                              uVar8 = _UNK_1036a1908;
                                              if (*(long *)(param_1 + 0x148) != 0) {
                                                func_0x000100377d20(*(long *)(param_1 + 0x148),6,
                                                                    *(undefined8 *)
                                                                     (lVar13 + (long)(int)uVar1 * 8
                                                                     + 0x20));
                                                uVar10 = uRam00000001039006a8;
                                                lVar13 = *(long *)(param_1 + 0x68);
                                                uStack_78 = 0;
                                                uStack_80 = 0;
                                                func_0x00010034ede4(&uStack_80,
                                                                    *(int *)(param_1 + 0x158) +
                                                                    (*(int *)(param_1 + 0x160) +
                                                                    *(int *)(param_1 + 0x168)) * 7,
                                                                    *(undefined4 *)(param_1 + 0x15c)
                                                                    ,0x4c,0x4c);
                                                uVar15 = uStack_78;
                                                uVar9 = uStack_80;
                                                plVar12 = (long *)*plRam00000001038d5338;
                                                uVar8 = _UNK_1036a1910;
                                                if (plVar12 != (long *)0x0) {
                                                  uVar16 = (**(code **)(*plVar12 + 0x100))
                                                                     (plVar12,uRam00000001039006b0);
                                                  plVar12 = (long *)*plRam00000001038d5338;
                                                  uVar8 = _UNK_1036a1918;
                                                  if (plVar12 != (long *)0x0) {
                                                    uVar8 = (**(code **)(*plVar12 + 0xa0))
                                                                      (plVar12,uRam00000001039006b8)
                                                    ;
                                                    uStack_68 = 0;
                                                    uStack_70 = 0;
                                                    func_0x00010034ede4(&uStack_70,0,0,0x16,0x14);
                                                    uVar17 = func_0x000100331820(
                                                  uRam00000001038f6ca0,0xb0);
                                                  StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                                                            (0x40800000,uVar17,uVar10,uVar9,uVar15,0
                                                             ,uVar16,uVar8);
                                                  plVar12 = *(long **)(lVar13 + 0x10);
                                                  *(int *)(lVar13 + 0x1c) =
                                                       *(int *)(lVar13 + 0x1c) + 1;
                                                  uVar8 = _UNK_1036a1928;
                                                  if (plVar12 != (long *)0x0) {
                                                    uVar1 = *(uint *)(lVar13 + 0x18);
                                                    if (uVar1 < *(uint *)(plVar12 + 3)) {
                                                      *(uint *)(lVar13 + 0x18) = uVar1 + 1;
                                                      (**(code **)(*plVar12 + 0x110))
                                                                (plVar12,(long)(int)uVar1,uVar17);
                                                    }
                                                    else {
                                                      func_0x000100377d0c(lVar13,uVar17);
                                                    }
                                                    iVar11 = *(int *)(*(long *)(param_1 + 0x68) +
                                                                     0x18);
                                                    if (iVar11 == 0) goto LAB_101e168b0;
                                                    lVar13 = *(long *)(*(long *)(param_1 + 0x68) +
                                                                      0x10);
                                                    uVar1 = iVar11 - 1;
                                                    uVar8 = _UNK_1036a1940;
                                                    if (*(uint *)(lVar13 + 0x18) <= uVar1)
                                                    goto LAB_101e16b6c;
                                                    uVar8 = _UNK_1036a1948;
                                                    if (*(long *)(param_1 + 0x148) != 0) {
                                                      func_0x000100377d20(*(long *)(param_1 + 0x148)
                                                                          ,7,*(undefined8 *)
                                                                              (lVar13 + (long)(int)
                                                  uVar1 * 8 + 0x20));
                                                  uVar8 = _UNK_1036a1950;
                                                  if (*(long *)(param_1 + 0x148) != 0) {
                                                    cVar6 = func_0x000100377d34(*(long *)(param_1 +
                                                                                         0x148),
                                                                                *
                                                  puRam00000001038d6430);
                                                  if (cVar6 != '\0') {
                                                    lVar13 = *(long *)(param_1 + 0x148);
                                                    uVar8 = _UNK_1036a1958;
                                                    if (*(char *)(lRam00000001038c4c88 + 0x35) ==
                                                        '\0') {
                                                      func_0x0001003319b0();
                                                      uVar8 = _UNK_1036a1958;
                                                    }
                                                    _UNK_1036a1958 = uVar8;
                                                    if (lVar13 == 0) goto LAB_101e16d60;
                                                    lVar13 = func_0x000100377d48(lVar13,*
                                                  puRam00000001038d6430);
                                                  func_0x000100377d5c(param_1,*(undefined8 *)
                                                                               (lVar13 + 0x10));
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
LAB_101e16d60:
  func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
  pcVar5 = (code *)SoftwareBreakpoint(1,0x101e16d6c);
  (*pcVar5)();
}

