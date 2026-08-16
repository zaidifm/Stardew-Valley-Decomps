/* 0x06005e2a StardewValley.Menus.MobileFarmChooser.<.ctor>g__AddCarousel|53_0 @ 0x101e1a82c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_Menus_MobileFarmChooser___ctor_g__AddCarousel_53_0_06005e2a
               (long param_1,undefined8 param_2,undefined8 param_3,int param_4,int param_5,
               int param_6,long param_7,undefined8 param_8)

{
  uint uVar1;
  int iVar2;
  char cVar3;
  undefined8 uVar4;
  undefined8 uVar5;
  code *pcVar6;
  long lVar7;
  long lVar8;
  undefined8 uVar9;
  undefined8 uVar10;
  long *plVar11;
  int iVar12;
  int iVar13;
  undefined8 *puVar14;
  ulong uVar15;
  int iVar16;
  undefined8 uVar17;
  float fVar18;
  float fVar19;
  undefined1 auVar20 [16];
  undefined8 uStack_a0;
  undefined8 uStack_98;
  undefined8 uStack_90;
  undefined8 uStack_88;
  undefined8 uStack_80;
  undefined8 uStack_78;
  
  cVar3 = cRam0000000103910c39;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_1033174f0);
    cRam0000000103910c39 = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar10 = _UNK_1036a2538;
  if ((*plRam00000001038d5f08 != 0) &&
     (fVar18 = (float)func_0x0001003560e4(*plRam00000001038d5f08,param_3), uVar10 = _UNK_1036a2540,
     param_7 != 0)) {
    uVar15 = (ulong)*(uint *)(param_7 + 0x18);
    if ((int)*(uint *)(param_7 + 0x18) < 1) {
      iVar16 = 0;
    }
    else {
      iVar16 = 0;
      puVar14 = (undefined8 *)(param_7 + 0x20);
      do {
        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        uVar10 = _UNK_1036a2548;
        if (*plRam00000001038d5f08 == 0) goto LAB_101e1acd8;
        fVar19 = (float)func_0x0001003560e4(*plRam00000001038d5f08,*puVar14);
        if (iVar16 <= (int)fVar19) {
          iVar16 = (int)fVar19;
        }
        if (lRam0000000103976fb8 != 0) {
          func_0x00010119b8f8();
        }
        puVar14 = puVar14 + 1;
        uVar15 = uVar15 - 1;
      } while (uVar15 != 0);
    }
    iVar12 = (int)fVar18;
    iVar13 = (iVar16 - iVar12) + 0x40;
    iVar16 = (iVar16 - iVar12) + 0x41;
    if (-1 < iVar13) {
      iVar16 = iVar13;
    }
    iVar16 = iVar16 >> 1;
    if (iVar13 < -1) {
      iVar16 = 0;
    }
    iVar13 = -iVar16;
    if (param_6 == 0) {
      iVar13 = iVar16;
    }
    iVar2 = 0;
    if (param_6 != 1 && 0 < iVar16) {
      iVar2 = iVar13;
    }
    uVar10 = _UNK_1036a2550;
    if ((param_1 != 0) && (uVar10 = _UNK_1036a2558, param_1 != -0x180)) {
      iVar13 = iVar2 + param_4 + *(int *)(param_1 + 0x180);
      param_5 = *(int *)(param_1 + 0x184) + param_5;
      if (param_6 == 2) {
        iVar13 = (iVar13 - iVar12) + *(int *)(param_1 + 0x188);
      }
      else if (param_6 == 1) {
        iVar2 = *(int *)(param_1 + 0x188) - iVar12;
        if (iVar2 < 0) {
          iVar2 = iVar2 + 1;
        }
        iVar13 = iVar13 + (iVar2 >> 1);
      }
      uStack_a0 = 0;
      uStack_98 = 0;
      func_0x00010034ede4(&uStack_a0,iVar13,param_5,1,1);
      uVar4 = uStack_98;
      uVar10 = uStack_a0;
      lVar7 = func_0x000100331820(uRam00000001038f6cb0,0x78);
      *(undefined1 *)(lVar7 + 0x4c) = 1;
      *(undefined8 *)(lVar7 + 0x38) = uVar10;
      *(undefined8 *)(lVar7 + 0x40) = uVar4;
      *(undefined4 *)(lVar7 + 0x48) = 0x3f800000;
      *(undefined8 *)(lVar7 + 0x54) = 0xfffffe0cfffffe0c;
      *(undefined8 *)(lVar7 + 0x5c) = 0xffffffffffffffff;
      *(undefined8 *)(lVar7 + 100) = 0xffffffffffffffff;
      lVar8 = lRam00000001038c4be0;
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lVar7 + 0x10) = param_3;
      *(undefined1 *)(((ulong)(lVar7 + 0x10) >> 9 & 0x7fffff) + lVar8) = 1;
      lVar8 = *(long *)(param_1 + 0x108);
      plVar11 = *(long **)(lVar8 + 0x10);
      *(int *)(lVar8 + 0x1c) = *(int *)(lVar8 + 0x1c) + 1;
      uVar10 = _UNK_1036a2568;
      if (plVar11 != (long *)0x0) {
        uVar1 = *(uint *)(lVar8 + 0x18);
        if (uVar1 < *(uint *)(plVar11 + 3)) {
          *(uint *)(lVar8 + 0x18) = uVar1 + 1;
          (**(code **)(*plVar11 + 0x110))(plVar11,(long)(int)uVar1,lVar7);
        }
        else {
          func_0x000100377424(lVar8,lVar7);
        }
        param_5 = param_5 + 0x28;
        lVar8 = *(long *)(param_1 + 0x110);
        uStack_90 = 0;
        uStack_88 = 0;
        func_0x00010034ede4(&uStack_90,(iVar13 + -0x20) - iVar16,param_5,0x40,0x40);
        uVar5 = uStack_88;
        uVar4 = uStack_90;
        uVar10 = uRam00000001038c4f58;
        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        uVar17 = *puRam00000001038d53d0;
        auVar20 = StardewValley_StardewValley_Game1_getSourceRectForStandardTileSheet_06003181
                            (uVar17,0x2c,0xffffffff,0xffffffff);
        uVar9 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
        StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                  (0x3f800000,uVar9,param_2,uVar4,uVar5,0,uVar10,uVar17,param_8,auVar20,0);
        plVar11 = *(long **)(lVar8 + 0x10);
        *(int *)(lVar8 + 0x1c) = *(int *)(lVar8 + 0x1c) + 1;
        uVar10 = _UNK_1036a2578;
        if (plVar11 != (long *)0x0) {
          uVar1 = *(uint *)(lVar8 + 0x18);
          if (uVar1 < *(uint *)(plVar11 + 3)) {
            *(uint *)(lVar8 + 0x18) = uVar1 + 1;
            (**(code **)(*plVar11 + 0x110))(plVar11,(long)(int)uVar1,uVar9);
          }
          else {
            func_0x000100377424(lVar8,uVar9);
          }
          uStack_80 = 0;
          uStack_78 = 0;
          lVar8 = *(long *)(param_1 + 0x118);
          func_0x00010034ede4(&uStack_80,iVar16 + iVar12 + iVar13 + -0x20,param_5,0x40,0x40);
          uVar5 = uStack_78;
          uVar4 = uStack_80;
          uVar10 = uRam00000001038c4f58;
          uVar17 = *puRam00000001038d53d0;
          auVar20 = StardewValley_StardewValley_Game1_getSourceRectForStandardTileSheet_06003181
                              (uVar17,0x21,0xffffffff,0xffffffff);
          uVar9 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
          StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601a
                    (0x3f800000,uVar9,param_2,uVar4,uVar5,0,uVar10,uVar17,param_8,auVar20,0);
          plVar11 = *(long **)(lVar8 + 0x10);
          *(int *)(lVar8 + 0x1c) = *(int *)(lVar8 + 0x1c) + 1;
          uVar10 = _UNK_1036a2588;
          if (plVar11 != (long *)0x0) {
            uVar1 = *(uint *)(lVar8 + 0x18);
            if (uVar1 < *(uint *)(plVar11 + 3)) {
              *(uint *)(lVar8 + 0x18) = uVar1 + 1;
              (**(code **)(*plVar11 + 0x110))(plVar11,(long)(int)uVar1,uVar9);
            }
            else {
              func_0x000100377424(lVar8,uVar9);
            }
            return lVar7;
          }
        }
      }
    }
  }
LAB_101e1acd8:
  func_0x0001003316f4(0xee,uVar10);
                    /* WARNING: Does not return */
  pcVar6 = (code *)SoftwareBreakpoint(1,0x101e1ace4);
  (*pcVar6)();
}

