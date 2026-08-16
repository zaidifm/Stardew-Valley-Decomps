/* 0x06005e15 StardewValley.Menus.MobileCustomizer.GetPetTypesAndBreeds @ 0x100122250 */

undefined4 *
SDV_StardewValley_Menus_MobileCustomizer_GetPetTypesAndBreeds_06005e15
          (undefined1 param_1 [16],undefined4 param_2,long param_3)

{
  uint uVar1;
  char cVar2;
  long lVar3;
  long lVar4;
  undefined8 *puVar5;
  long lVar6;
  undefined4 *puVar7;
  undefined8 uVar8;
  undefined8 extraout_x17;
  int iVar9;
  undefined4 uVar10;
  undefined1 auVar11 [16];
  undefined8 uStack_290;
  undefined8 uStack_288;
  long lStack_280;
  undefined8 uStack_278;
  undefined8 uStack_270;
  undefined8 uStack_268;
  long lStack_260;
  long lStack_250;
  undefined1 *puStack_220;
  undefined8 uStack_218;
  long lStack_210;
  undefined8 *puStack_208;
  long lStack_200;
  undefined4 uStack_1f8;
  undefined4 uStack_1f4;
  undefined4 uStack_1f0;
  undefined4 uStack_1ec;
  undefined4 uStack_1e8;
  undefined4 uStack_1e4;
  undefined4 uStack_1e0;
  undefined4 uStack_1dc;
  undefined4 uStack_1d8;
  undefined4 uStack_1d4;
  undefined8 uStack_1d0;
  undefined8 uStack_1c8;
  long lStack_1c0;
  undefined8 uStack_1b8;
  long lStack_1b0;
  undefined8 uStack_1a8;
  undefined8 uStack_1a0;
  undefined8 uStack_198;
  long lStack_190;
  undefined8 uStack_188;
  undefined8 uStack_180;
  undefined8 uStack_178;
  long lStack_170;
  undefined4 uStack_168;
  undefined4 uStack_164;
  undefined4 *puStack_160;
  long lStack_158;
  long lStack_148;
  long lStack_138;
  long *plStack_f0;
  long lStack_e8;
  undefined8 uStack_90;
  undefined8 uStack_88;
  undefined8 uStack_80;
  undefined8 uStack_78;
  long lStack_70;
  undefined8 uStack_68;
  undefined8 uStack_60;
  long *plStack_58;
  undefined1 (*pauStack_50) [16];
  long lStack_48;
  long lStack_38;
  undefined8 *puStack_10;
  undefined8 uStack_8;
  
  if (*plRam00000001037fff88 != 0) {
    func_0x0001003316e0();
  }
  plStack_58 = (long *)0x0;
  uStack_68 = 0;
  uStack_60 = 0;
  uStack_80 = 0;
  uStack_78 = 0;
  lStack_70 = 0;
  if (*(long *)(param_3 + 0x1d0) == 0) {
    puStack_10 = (undefined8 *)func_0x000100331820(uRam00000001038052a0,0x20);
    uStack_8 = *puRam00000001038052a8;
    DataMemoryBarrier(2,3);
    puStack_10[2] = uStack_8;
    *(undefined1 *)(((ulong)(puStack_10 + 2) >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
    DataMemoryBarrier(2,3);
    *(ulong *)(param_3 + 0x1d0U) = (ulong)puStack_10;
    *(undefined1 *)((param_3 + 0x1d0U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
    if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    plStack_58 = (long *)(**(code **)(*(long *)*puRam00000001038052b0 + -0x10))
                                   ((long *)*puRam00000001038052b0);
LAB_100122660:
    cVar2 = (**(code **)(*plStack_58 + -0x78))(plStack_58);
    if (cVar2 != '\0') {
      if (*plRam00000001037fff88 != 0) {
        func_0x0001003316e0();
      }
      pauStack_50 = (undefined1 (*) [16])&uStack_68;
      auVar11 = (**(code **)(*plStack_58 + -0x38))(plStack_58);
      *pauStack_50 = auVar11;
      if (*(char *)(param_3 + 0x330) != '\0') goto code_r0x000100122400;
      goto LAB_100122418;
    }
    lStack_38 = 0;
    func_0x0001001226a4();
    if (lStack_38 != 0) {
      func_0x000100331ba4();
    }
  }
  return *(undefined4 **)(param_3 + 0x1d0);
code_r0x000100122400:
  lVar3 = func_0x0001003518a0();
  cVar2 = func_0x00010035011c(*(undefined8 *)(lVar3 + 800),uStack_68);
  if (cVar2 == '\0') {
LAB_100122418:
    func_0x000100377c80(&uStack_80);
    while (cVar2 = func_0x000100377c94(&uStack_80), cVar2 != '\0') {
      if (*plRam00000001037fff88 != 0) {
        func_0x0001003316e0();
      }
      if (*(char *)(lStack_70 + 0x40) != '\0') {
        puStack_208 = *(undefined8 **)(param_3 + 0x1d0);
        uStack_8 = uStack_68;
        uStack_88 = *(undefined8 *)(lStack_70 + 0x10);
        DataMemoryBarrier(2,3);
        uStack_90 = uStack_68;
        *(undefined1 *)(((ulong)&uStack_90 >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
        DataMemoryBarrier(2,3);
        *(undefined1 *)(((ulong)&uStack_88 >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
        *(int *)((long)puStack_208 + 0x1c) = *(int *)((long)puStack_208 + 0x1c) + 1;
        lVar3 = puStack_208[2];
        uVar1 = *(uint *)(puStack_208 + 3);
        puStack_10 = puStack_208;
        if (uVar1 < *(uint *)(lVar3 + 0x18)) {
          *(uint *)(puStack_208 + 3) = uVar1 + 1;
          if ((ulong)(long)*(int *)(lVar3 + 0x18) <= (ulong)(long)(int)uVar1) {
            auVar11 = func_0x000100382ea0(0xcc,0x100122558);
            uVar8 = auVar11._8_8_;
            lVar4 = auVar11._0_8_;
            uStack_218 = 0x100122718;
            puStack_220 = &stack0xffffffffffffff20;
            lStack_210 = lVar3;
            lStack_200 = param_3;
            if (*plRam00000001037fff88 != 0) {
              puStack_220 = &stack0xffffffffffffff20;
              func_0x0001003316e0();
            }
            uStack_168 = 0;
            uStack_164 = 0;
            uStack_180 = 0;
            uStack_178 = 0;
            lStack_170 = 0;
            uStack_1a8 = 0;
            uStack_1a0 = 0;
            uStack_198 = 0;
            lStack_190 = 0;
            uStack_188 = 0;
            uStack_1b8 = 0;
            lStack_1b0 = 0;
            uStack_1d0 = 0;
            uStack_1c8 = 0;
            lStack_1c0 = 0;
            cVar2 = func_0x000100345aa0(uVar8,uRam00000001038052f0);
            if (cVar2 == '\0') {
              cVar2 = func_0x000100345aa0(uVar8,uRam00000001038016a0);
              if (cVar2 == '\0') {
                cVar2 = func_0x000100345aa0(uVar8,uRam00000001038052f8);
                if (cVar2 == '\0') {
                  cVar2 = func_0x000100345aa0(uVar8,uRam0000000103805300);
                  if (cVar2 == '\0') {
                    func_0x000100377d98(&uStack_180);
                    goto LAB_100122fa8;
                  }
                  if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
                    func_0x0001003319b0();
                  }
                  *puRam0000000103805330 = 1;
                }
                else {
                  if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
                    func_0x0001003319b0();
                  }
                  *puRam0000000103805330 = 0;
                }
              }
              else {
                puVar5 = (undefined8 *)func_0x0001003516e8();
                if ((puVar5 != (undefined8 *)0x0) &&
                   (*(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x10) != lRam0000000103805310)) {
                  puVar5 = (undefined8 *)0x0;
                }
                if (puVar5 != (undefined8 *)0x0) {
                  lStack_e8 = (long)*(int *)(lVar4 + 0x1d8);
                  plStack_f0 = (long *)func_0x000100331820(uRam0000000103805320,0xd8);
                  func_0x0001003618cc(plStack_f0,lStack_e8,0,0);
                  func_0x00010035688c(plStack_f0);
                  uStack_168 = 0;
                  uStack_164 = 0;
                  uStack_1e0 = 0;
                  uStack_1dc = 0;
                  func_0x000100352c14(uRam0000000103805328,0);
                }
              }
            }
            else {
              uStack_168 = 0;
              uStack_164 = 0;
              uStack_1d8 = 0;
              uStack_1d4 = 0;
              func_0x000100352c14(uRam0000000103805308,0);
              if (*(long *)(lVar4 + 0x80) != 0) {
                lVar3 = func_0x0001003518a0();
                plStack_f0 = *(long **)(lVar3 + 0x2a0);
                uVar8 = func_0x000100352124(*(undefined8 *)(*(long *)(lVar4 + 0x80) + 0x28));
                func_0x000100354118(plStack_f0,uVar8);
              }
              lVar3 = func_0x0001003518a0();
              if (0xf < *(int *)(*(long *)(*(long *)(lVar3 + 0x2a0) + 0x60) + 0x10)) {
                lVar3 = func_0x0001003518a0();
                plStack_f0 = *(long **)(lVar3 + 0x2a0);
                lVar3 = func_0x0001003518a0();
                uVar8 = func_0x00010035629c(*(undefined8 *)(*(long *)(lVar3 + 0x2a0) + 0x60),0,0xf);
                func_0x000100354118(plStack_f0,uVar8);
              }
              puVar5 = (undefined8 *)func_0x0001003516e8();
              if ((puVar5 != (undefined8 *)0x0) &&
                 (*(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x10) != lRam0000000103805310)) {
                puVar5 = (undefined8 *)0x0;
              }
              if (puVar5 == (undefined8 *)0x0) {
                uVar8 = func_0x000100351918();
                func_0x0001003595c8(uVar8,0x2c);
                func_0x0001003519a4();
                lVar3 = func_0x0001003517d8();
                if (lVar3 != 0) {
                  puVar5 = (undefined8 *)func_0x0001003517d8();
                  if ((puVar5 != (undefined8 *)0x0) &&
                     (*(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 8) != lRam0000000103805318)) {
                    puVar5 = (undefined8 *)0x0;
                  }
                  if (puVar5 != (undefined8 *)0x0) {
                    puVar5 = (undefined8 *)func_0x0001003517d8();
                    if ((puVar5 != (undefined8 *)0x0) &&
                       (*(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 8) != lRam0000000103805318))
                    {
                      puVar5 = (undefined8 *)0x0;
                    }
                    func_0x000100377ba4(puVar5);
                  }
                }
              }
              else {
                uVar8 = func_0x000100351918();
                func_0x0001003595c8(uVar8,0x2c);
                puVar5 = (undefined8 *)func_0x0001003516e8();
                if ((puVar5 != (undefined8 *)0x0) &&
                   (*(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x10) != lRam0000000103805310)) {
                  puVar5 = (undefined8 *)0x0;
                }
                func_0x000100377bb8(puVar5,*(undefined1 *)(lVar4 + 0x1fe));
              }
            }
            goto LAB_100123008;
          }
          lVar3 = lVar3 + (long)(int)uVar1 * 0x10;
          puStack_10 = (undefined8 *)(lVar3 + 0x20);
          DataMemoryBarrier(2,3);
          *puStack_10 = uStack_68;
          *(undefined1 *)(((ulong)puStack_10 >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
          puVar5 = (undefined8 *)(lVar3 + 0x28);
          *puVar5 = uStack_88;
          *(undefined1 *)(((ulong)puVar5 >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
        }
        else {
          func_0x0001003557ac(puStack_208,uStack_68,uStack_88);
        }
      }
    }
    lStack_48 = 0;
    func_0x000100122634();
    if (lStack_48 != 0) {
      func_0x000100331ba4();
    }
  }
  goto LAB_100122660;
  while( true ) {
    if (*plRam00000001037fff88 != 0) {
      func_0x0001003316e0();
    }
    lVar3 = lStack_170;
    cVar2 = func_0x000100345aa0(*(undefined8 *)(lStack_170 + 0x10),uVar8);
    if (cVar2 != '\0') break;
LAB_100122fa8:
    cVar2 = func_0x000100377dac(&uStack_180);
    if (cVar2 == '\0') {
      lStack_148 = 0;
      func_0x000100122fdc();
      if (lStack_148 != 0) {
        func_0x000100331ba4();
      }
      goto LAB_100123008;
    }
  }
  iVar9 = -1;
  func_0x000100384d18(&uStack_1a8);
  do {
    cVar2 = func_0x000100384d2c(&uStack_1a8);
    if (cVar2 == '\0') {
      lStack_158 = 0;
      func_0x000100122c5c();
      if (lStack_158 != 0) {
        func_0x000100331ba4();
      }
      goto LAB_100122c88;
    }
    if (*plRam00000001037fff88 != 0) {
      func_0x0001003316e0();
    }
    uStack_1b8 = uStack_198;
    uVar8 = uStack_1b8;
    lStack_1b0 = lStack_190;
  } while (lStack_190 != lVar3);
  uStack_1b8._0_4_ = (int)uStack_198;
  iVar9 = (int)uStack_1b8;
  lStack_158 = 0;
  uStack_1b8 = uVar8;
  func_0x000100122c5c();
  if (lStack_158 != 0) {
    func_0x000100331ba4();
  }
LAB_100122c88:
  if (-1 < iVar9) {
    if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    *piRam0000000103802e60 = iVar9;
    if (iVar9 == 4) {
      func_0x000100352ad4(1);
    }
    else {
      func_0x000100352ad4(0);
    }
    lVar6 = func_0x000100352110(*(undefined8 *)(lVar3 + 0x80),0x5f,0);
    uVar8 = 0x100122cf8;
    if (*(int *)(lVar6 + 0x18) == 0) goto LAB_1001230e8;
    lStack_e8 = *(long *)(lVar6 + 0x20);
    DataMemoryBarrier(2,3);
    *(long *)(lVar4 + 0x70U) = lStack_e8;
    *(undefined1 *)((lVar4 + 0x70U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
    lVar3 = func_0x000100352110(*(undefined8 *)(lVar3 + 0x80),0x5f,0);
    uVar8 = 0x100122d64;
    if (*(uint *)(lVar3 + 0x18) < 2) goto LAB_1001230e8;
    plStack_f0 = *(long **)(lVar3 + 0x28);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar4 + 0x78) = plStack_f0;
    *(undefined1 *)(((ulong)(lVar4 + 0x78) >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
    uStack_168 = 0;
    uStack_164 = 0;
    uStack_1e8 = 0;
    uStack_1e4 = 0;
    func_0x000100352c14(uRam0000000103805350,0);
  }
  if (iVar9 == 7) {
    if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    func_0x000100365968(*puRam00000001038007a8);
    uVar8 = uRam0000000103805358;
    func_0x000100365990(&uStack_1d0);
    do {
      cVar2 = func_0x0001003659a4(&uStack_1d0);
      if (cVar2 == '\0') {
        lStack_138 = 0;
        func_0x000100122f30();
        if (lStack_138 != 0) {
          func_0x000100331ba4();
        }
        lStack_148 = 0;
        func_0x000100122fdc();
        if (lStack_148 != 0) {
          func_0x000100331ba4();
        }
        goto LAB_100123008;
      }
      if (*plRam00000001037fff88 != 0) {
        func_0x0001003316e0();
      }
      lVar3 = lStack_1c0;
      cVar2 = func_0x000100345aa0(*(undefined8 *)(lStack_1c0 + 0x10),uVar8);
    } while (cVar2 == '\0');
    if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    *piRam0000000103802e60 = 7;
    plStack_f0 = plRam0000000103805368;
    DataMemoryBarrier(2,3);
    *plRam0000000103805368 = lVar3;
    func_0x000100352ad4(*(undefined1 *)(lVar3 + 0x48));
    lStack_138 = 0;
    func_0x000100122f30();
    if (lStack_138 != 0) {
      func_0x000100331ba4();
    }
    lStack_148 = 0;
    func_0x000100122fdc();
    if (lStack_148 != 0) {
      func_0x000100331ba4();
    }
  }
  else {
    if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    plStack_f0 = plRam0000000103805368;
    DataMemoryBarrier(2,3);
    *plRam0000000103805368 = 0;
    lStack_148 = 0;
    func_0x000100122fdc();
    if (lStack_148 != 0) {
      func_0x000100331ba4();
    }
  }
LAB_100123008:
  if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  puStack_160 = &uStack_1f0;
  uVar10 = func_0x0001003560e4(*puRam0000000103804740,*(undefined8 *)(lVar4 + 0x70));
  puVar7 = puStack_160;
  *puStack_160 = uVar10;
  puVar7[1] = param_2;
  uVar8 = 0x100123058;
  if (lVar4 != 0) {
    *(undefined4 *)(lVar4 + 0x1b0) = uStack_1f0;
    *(undefined4 *)(lVar4 + 0x1b4) = uStack_1ec;
    puStack_160 = &uStack_1f8;
    uVar10 = func_0x0001003560e4(*puRam0000000103804740,*(undefined8 *)(lVar4 + 0x78));
    puVar7 = puStack_160;
    *puStack_160 = uVar10;
    puVar7[1] = param_2;
    uVar8 = 0x1001230ac;
    if (lVar4 != 0) {
      *(undefined4 *)(lVar4 + 0x1b8) = uStack_1f8;
      *(undefined4 *)(lVar4 + 0x1bc) = uStack_1f4;
      return (undefined4 *)(lVar4 + 0x1b8);
    }
  }
  func_0x000100382ea0(0xee,uVar8);
  uVar8 = extraout_x17;
LAB_1001230e8:
  uVar8 = func_0x000100382ea0(0xcc,uVar8);
  if (*plRam00000001037fff88 != 0) {
    func_0x0001003316e0();
  }
  puVar7 = puRam0000000103805380;
  uStack_278 = 0;
  uStack_270 = 0;
  uStack_268 = 0;
  uStack_290 = 0;
  uStack_288 = 0;
  lStack_280 = 0;
  func_0x000100384d40(uVar8);
  func_0x000100384d54(&uStack_278);
  while (cVar2 = func_0x000100384d68(&uStack_278), cVar2 != '\0') {
    if (*plRam00000001037fff88 != 0) {
      func_0x0001003316e0();
    }
    func_0x00010035340c(&uStack_290);
    while (cVar2 = func_0x000100353470(&uStack_290), cVar2 != '\0') {
      if (*plRam00000001037fff88 != 0) {
        func_0x0001003316e0();
      }
      puVar7 = (undefined4 *)
               func_0x00010035048c(puVar7,uRam0000000103800c08,
                                   *(undefined8 *)(*(long *)(lStack_280 + 0x58) + 0x60),
                                   uRam0000000103805398);
    }
    lStack_260 = 0;
    func_0x000100123248();
    if (lStack_260 != 0) {
      func_0x000100331ba4();
    }
  }
  lStack_250 = 0;
  func_0x0001001232a8();
  if (lStack_250 != 0) {
    func_0x000100331ba4();
  }
  return puVar7;
}

