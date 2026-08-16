/* 0x06005e2b StardewValley.Menus.MobileScrollbar..ctor @ 0x101e1ad5c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileScrollbar__ctor_06005e2b
               (long param_1,int param_2,int param_3,undefined4 param_4,int param_5,
               undefined4 param_6,undefined4 param_7,char param_8)

{
  int iVar1;
  undefined8 uVar2;
  undefined8 uVar3;
  undefined8 uVar4;
  undefined4 uVar5;
  char cVar6;
  code *pcVar7;
  undefined8 uVar8;
  long lVar9;
  undefined8 uVar10;
  long *plVar11;
  undefined8 *puVar12;
  undefined8 *puVar13;
  undefined8 uVar14;
  long lVar15;
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
  undefined8 auStack_e0 [2];
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
  undefined8 auStack_70 [2];
  
  cVar6 = cRam0000000103910c3a;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar6 == '\0') {
    func_0x00010119b908(&UNK_103317520);
    cRam0000000103910c3a = '\x01';
  }
  uVar10 = _UNK_1036a2590;
  if ((param_1 != 0) && (uVar10 = _UNK_1036a2598, param_1 != -0x40)) {
    *(undefined4 *)(param_1 + 0x48) = param_4;
    *(int *)(param_1 + 0x4c) = param_5;
    *(int *)(param_1 + 0x40) = param_2;
    *(int *)(param_1 + 0x44) = param_3;
    *(undefined4 *)(param_1 + 0x68) = 0;
    *(undefined4 *)(param_1 + 0x6c) = param_6;
    *(undefined4 *)(param_1 + 0x70) = param_7;
    *(char *)(param_1 + 0x74) = param_8;
    if (param_8 == '\0') {
      uStack_d0 = 0;
      uStack_c8 = 0;
      func_0x00010034ede4(&uStack_d0,param_2,param_3,0x30,0x18);
      uVar2 = uStack_c8;
      uVar10 = uStack_d0;
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar14 = *puRam00000001038d5350;
      uStack_c0 = 0;
      uStack_b8 = 0;
      func_0x00010034ede4(&uStack_c0,0x28,0x58,0xc,6);
      uVar4 = uStack_b8;
      uVar3 = uStack_c0;
      uVar8 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
      StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601b
                (0x40800000,uVar8,uVar10,uVar2,uVar14,uVar3,uVar4,0);
      DataMemoryBarrier(2,3);
      *(undefined8 *)(param_1 + 0x28) = uVar8;
      lVar15 = lRam00000001038c4be0;
      *(undefined1 *)(((ulong)(param_1 + 0x28) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
      uStack_b0 = 0;
      uStack_a8 = 0;
      func_0x00010034ede4(&uStack_b0,param_2,param_5 + param_3 + -0x14,0x30,0x18);
      uVar2 = uStack_a8;
      uVar10 = uStack_b0;
      uVar8 = *puRam00000001038d5350;
      uStack_a0 = 0;
      uStack_98 = 0;
      func_0x00010034ede4(&uStack_a0,0x34,0x4f,0xc,6);
      uVar4 = uStack_98;
      uVar3 = uStack_a0;
      lVar9 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
      StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601b
                (0x40800000,lVar9,uVar10,uVar2,uVar8,uVar3,uVar4,0);
      DataMemoryBarrier(2,3);
      plVar11 = (long *)(param_1 + 0x30);
      *plVar11 = lVar9;
      *(undefined1 *)(((ulong)plVar11 >> 9 & 0x7fffff) + lVar15) = 1;
      lVar9 = *plVar11;
      uVar10 = _UNK_1036a25a0;
      if ((lVar9 != 0) && (uVar10 = _UNK_1036a25a8, lVar9 != -0x38)) {
        uStack_90 = 0;
        uStack_88 = 0;
        func_0x00010034ede4(&uStack_90,param_2,param_3 + 0x18,0x30,
                            (*(int *)(lVar9 + 0x3c) - param_3) + -0x18);
        lVar9 = *(long *)(param_1 + 0x28);
        *(undefined8 *)(param_1 + 0x58) = uStack_88;
        *(undefined8 *)(param_1 + 0x50) = uStack_90;
        uVar10 = _UNK_1036a25b0;
        if ((lVar9 != 0) && (uVar10 = _UNK_1036a25b8, lVar9 != -0x38)) {
          uVar5 = *(undefined4 *)(lVar9 + 0x3c);
          lVar9 = *(long *)(param_1 + 0x30);
          *(undefined4 *)(param_1 + 0x60) = uVar5;
          uVar10 = _UNK_1036a25c0;
          if (((lVar9 != 0) && (uVar10 = _UNK_1036a25c8, lVar9 != -0x38)) &&
             (*(int *)(param_1 + 100) = *(int *)(lVar9 + 0x3c) + -0x38, uVar10 = _UNK_1036a25d0,
             param_1 != -0x50)) {
            uStack_80 = 0;
            uStack_78 = 0;
            puVar13 = &uStack_80;
            func_0x00010034ede4(&uStack_80,*(int *)(param_1 + 0x50) + 4,uVar5,0x28,0x4c);
            puVar12 = auStack_70;
            goto LAB_101e1b314;
          }
        }
      }
    }
    else {
      uStack_180 = 0;
      uStack_178 = 0;
      func_0x00010034ede4(&uStack_180,param_2 + 4,param_3,0x28,0x28);
      uVar2 = uStack_178;
      uVar10 = uStack_180;
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar14 = *puRam00000001038d5350;
      uStack_170 = 0;
      uStack_168 = 0;
      func_0x00010034ede4(&uStack_170,0x1e,0x4c,10,10);
      uVar4 = uStack_168;
      uVar3 = uStack_170;
      uVar8 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
      StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601b
                (0x40800000,uVar8,uVar10,uVar2,uVar14,uVar3,uVar4,0);
      DataMemoryBarrier(2,3);
      *(undefined8 *)(param_1 + 0x10) = uVar8;
      lVar15 = lRam00000001038c4be0;
      *(undefined1 *)(((ulong)(param_1 + 0x10) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
      uStack_160 = 0;
      uStack_158 = 0;
      func_0x00010034ede4(&uStack_160,param_2 + 4,param_5 + param_3 + -0x28,0x28,0x28);
      uVar2 = uStack_158;
      uVar10 = uStack_160;
      uVar14 = *puRam00000001038d5350;
      uStack_150 = 0;
      uStack_148 = 0;
      func_0x00010034ede4(&uStack_150,0x1e,0x56,10,10);
      uVar4 = uStack_148;
      uVar3 = uStack_150;
      uVar8 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
      StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601b
                (0x40800000,uVar8,uVar10,uVar2,uVar14,uVar3,uVar4,0);
      DataMemoryBarrier(2,3);
      *(undefined8 *)(param_1 + 0x18) = uVar8;
      *(undefined1 *)(((ulong)(param_1 + 0x18) >> 9 & 0x7fffff) + lVar15) = 1;
      uStack_140 = 0;
      uStack_138 = 0;
      func_0x00010034ede4(&uStack_140,param_2,param_3,0x30,0x3c);
      uVar2 = uStack_138;
      uVar10 = uStack_140;
      uVar14 = *puRam00000001038d5350;
      uStack_130 = 0;
      uStack_128 = 0;
      func_0x00010034ede4(&uStack_130,0x28,0x4e,0xc,0xf);
      uVar4 = uStack_128;
      uVar3 = uStack_130;
      uVar8 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
      StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601b
                (0x40800000,uVar8,uVar10,uVar2,uVar14,uVar3,uVar4,0);
      DataMemoryBarrier(2,3);
      *(undefined8 *)(param_1 + 0x28) = uVar8;
      *(undefined1 *)(((ulong)(param_1 + 0x28) >> 9 & 0x7fffff) + lVar15) = 1;
      uStack_120 = 0;
      uStack_118 = 0;
      func_0x00010034ede4(&uStack_120,param_2,param_5 + param_3 + -0x3c,0x30,0x3c);
      uVar2 = uStack_118;
      uVar10 = uStack_120;
      uVar8 = *puRam00000001038d5350;
      uStack_110 = 0;
      uStack_108 = 0;
      func_0x00010034ede4(&uStack_110,0x34,0x4f,0xc,0x10);
      uVar4 = uStack_108;
      uVar3 = uStack_110;
      lVar9 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
      StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601b
                (0x40800000,lVar9,uVar10,uVar2,uVar8,uVar3,uVar4,0);
      DataMemoryBarrier(2,3);
      plVar11 = (long *)(param_1 + 0x30);
      *plVar11 = lVar9;
      *(undefined1 *)(((ulong)plVar11 >> 9 & 0x7fffff) + lVar15) = 1;
      lVar9 = *plVar11;
      uVar10 = _UNK_1036a25d8;
      if ((lVar9 != 0) && (uVar10 = _UNK_1036a25e0, lVar9 != -0x38)) {
        uStack_100 = 0;
        uStack_f8 = 0;
        func_0x00010034ede4(&uStack_100,param_2,param_3 + 0x3c,0x30,
                            (*(int *)(lVar9 + 0x3c) - param_3) + -0x3c);
        lVar9 = *(long *)(param_1 + 0x10);
        *(undefined8 *)(param_1 + 0x58) = uStack_f8;
        *(undefined8 *)(param_1 + 0x50) = uStack_100;
        uVar10 = _UNK_1036a25e8;
        if ((lVar9 != 0) && (uVar10 = _UNK_1036a25f0, lVar9 != -0x38)) {
          iVar1 = *(int *)(lVar9 + 0x3c) + *(int *)(lVar9 + 0x44) + 8;
          lVar9 = *(long *)(param_1 + 0x18);
          *(int *)(param_1 + 0x60) = iVar1;
          uVar10 = _UNK_1036a25f8;
          if (((lVar9 != 0) && (uVar10 = _UNK_1036a2600, lVar9 != -0x38)) &&
             (*(int *)(param_1 + 100) = *(int *)(lVar9 + 0x3c) + -0x58, uVar10 = _UNK_1036a2608,
             param_1 != -0x50)) {
            uStack_f0 = 0;
            uStack_e8 = 0;
            puVar13 = &uStack_f0;
            func_0x00010034ede4(&uStack_f0,*(int *)(param_1 + 0x50) + 4,iVar1,0x28,0x4c);
            puVar12 = auStack_e0;
LAB_101e1b314:
            uVar10 = *puVar13;
            uVar3 = puVar13[1];
            uVar14 = *puRam00000001038d5350;
            *puVar12 = 0;
            puVar12[1] = 0;
            func_0x00010034ede4(puVar12,0x14,0x4c,10,0x14);
            uVar2 = *puVar12;
            uVar4 = puVar12[1];
            uVar8 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
            StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601b
                      (0x40800000,uVar8,uVar10,uVar3,uVar14,uVar2,uVar4,0);
            DataMemoryBarrier(2,3);
            *(undefined8 *)(param_1 + 0x20) = uVar8;
            *(undefined1 *)(((ulong)(param_1 + 0x20) >> 9 & 0x7fffff) + lVar15) = 1;
            return;
          }
        }
      }
    }
  }
  func_0x0001003316f4(0xee,uVar10);
                    /* WARNING: Does not return */
  pcVar7 = (code *)SoftwareBreakpoint(1,0x101e1b4a0);
  (*pcVar7)();
}

