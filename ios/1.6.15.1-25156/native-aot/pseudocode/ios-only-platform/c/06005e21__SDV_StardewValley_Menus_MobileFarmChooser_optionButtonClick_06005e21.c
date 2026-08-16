/* 0x06005e21 StardewValley.Menus.MobileFarmChooser.optionButtonClick @ 0x100122720 */

undefined4 *
SDV_StardewValley_Menus_MobileFarmChooser_optionButtonClick_06005e21
          (undefined1 param_1 [16],undefined4 param_2,long param_3,undefined8 param_4)

{
  char cVar1;
  undefined8 *puVar2;
  long lVar3;
  long lVar4;
  undefined4 *puVar5;
  undefined8 uVar6;
  undefined8 extraout_x17;
  int iVar7;
  undefined4 uVar8;
  undefined8 uStack_1b0;
  undefined8 uStack_1a8;
  long lStack_1a0;
  undefined8 uStack_198;
  undefined8 uStack_190;
  undefined8 uStack_188;
  long lStack_180;
  long lStack_170;
  undefined4 uStack_118;
  undefined4 uStack_114;
  undefined4 uStack_110;
  undefined4 uStack_10c;
  undefined4 uStack_108;
  undefined4 uStack_104;
  undefined4 uStack_100;
  undefined4 uStack_fc;
  undefined4 uStack_f8;
  undefined4 uStack_f4;
  undefined8 uStack_f0;
  undefined8 uStack_e8;
  long lStack_e0;
  undefined8 uStack_d8;
  long lStack_d0;
  undefined8 uStack_c8;
  undefined8 uStack_c0;
  undefined8 uStack_b8;
  long lStack_b0;
  undefined8 uStack_a8;
  undefined8 uStack_a0;
  undefined8 uStack_98;
  long lStack_90;
  undefined4 uStack_88;
  undefined4 uStack_84;
  undefined4 *puStack_80;
  long lStack_78;
  long lStack_68;
  long lStack_58;
  long *plStack_10;
  long lStack_8;
  
  if (*plRam00000001037fff88 != 0) {
    func_0x0001003316e0();
  }
  uStack_88 = 0;
  uStack_84 = 0;
  uStack_a0 = 0;
  uStack_98 = 0;
  lStack_90 = 0;
  uStack_c8 = 0;
  uStack_c0 = 0;
  uStack_b8 = 0;
  lStack_b0 = 0;
  uStack_a8 = 0;
  uStack_d8 = 0;
  lStack_d0 = 0;
  uStack_f0 = 0;
  uStack_e8 = 0;
  lStack_e0 = 0;
  cVar1 = func_0x000100345aa0(param_4,uRam00000001038052f0);
  if (cVar1 == '\0') {
    cVar1 = func_0x000100345aa0(param_4,uRam00000001038016a0);
    if (cVar1 == '\0') {
      cVar1 = func_0x000100345aa0(param_4,uRam00000001038052f8);
      if (cVar1 == '\0') {
        cVar1 = func_0x000100345aa0(param_4,uRam0000000103805300);
        if (cVar1 == '\0') {
          func_0x000100377d98(&uStack_a0);
          do {
            cVar1 = func_0x000100377dac(&uStack_a0);
            if (cVar1 == '\0') {
              lStack_68 = 0;
              func_0x000100122fdc();
              if (lStack_68 != 0) {
                func_0x000100331ba4();
              }
              goto LAB_100123008;
            }
            if (*plRam00000001037fff88 != 0) {
              func_0x0001003316e0();
            }
            lVar4 = lStack_90;
            cVar1 = func_0x000100345aa0(*(undefined8 *)(lStack_90 + 0x10),param_4);
          } while (cVar1 == '\0');
          iVar7 = -1;
          func_0x000100384d18(&uStack_c8);
          do {
            cVar1 = func_0x000100384d2c(&uStack_c8);
            if (cVar1 == '\0') {
              lStack_78 = 0;
              func_0x000100122c5c();
              if (lStack_78 != 0) {
                func_0x000100331ba4();
              }
              goto LAB_100122c88;
            }
            if (*plRam00000001037fff88 != 0) {
              func_0x0001003316e0();
            }
            uStack_d8 = uStack_b8;
            uVar6 = uStack_d8;
            lStack_d0 = lStack_b0;
          } while (lStack_b0 != lVar4);
          uStack_d8._0_4_ = (int)uStack_b8;
          iVar7 = (int)uStack_d8;
          lStack_78 = 0;
          uStack_d8 = uVar6;
          func_0x000100122c5c();
          if (lStack_78 != 0) {
            func_0x000100331ba4();
          }
LAB_100122c88:
          if (-1 < iVar7) {
            if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
              func_0x0001003319b0();
            }
            *piRam0000000103802e60 = iVar7;
            if (iVar7 == 4) {
              func_0x000100352ad4(1);
            }
            else {
              func_0x000100352ad4(0);
            }
            lVar3 = func_0x000100352110(*(undefined8 *)(lVar4 + 0x80),0x5f,0);
            uVar6 = 0x100122cf8;
            if (*(int *)(lVar3 + 0x18) == 0) goto LAB_1001230e8;
            lStack_8 = *(long *)(lVar3 + 0x20);
            DataMemoryBarrier(2,3);
            *(long *)(param_3 + 0x70U) = lStack_8;
            *(undefined1 *)((param_3 + 0x70U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
            lVar4 = func_0x000100352110(*(undefined8 *)(lVar4 + 0x80),0x5f,0);
            uVar6 = 0x100122d64;
            if (*(uint *)(lVar4 + 0x18) < 2) goto LAB_1001230e8;
            plStack_10 = *(long **)(lVar4 + 0x28);
            DataMemoryBarrier(2,3);
            *(undefined8 *)(param_3 + 0x78) = plStack_10;
            *(undefined1 *)(((ulong)(param_3 + 0x78) >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
            uStack_88 = 0;
            uStack_84 = 0;
            uStack_108 = 0;
            uStack_104 = 0;
            func_0x000100352c14(uRam0000000103805350,0);
          }
          if (iVar7 == 7) {
            if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
              func_0x0001003319b0();
            }
            func_0x000100365968(*puRam00000001038007a8);
            uVar6 = uRam0000000103805358;
            func_0x000100365990(&uStack_f0);
            do {
              cVar1 = func_0x0001003659a4(&uStack_f0);
              if (cVar1 == '\0') {
                lStack_58 = 0;
                func_0x000100122f30();
                if (lStack_58 != 0) {
                  func_0x000100331ba4();
                }
                lStack_68 = 0;
                func_0x000100122fdc();
                if (lStack_68 != 0) {
                  func_0x000100331ba4();
                }
                goto LAB_100123008;
              }
              if (*plRam00000001037fff88 != 0) {
                func_0x0001003316e0();
              }
              lVar4 = lStack_e0;
              cVar1 = func_0x000100345aa0(*(undefined8 *)(lStack_e0 + 0x10),uVar6);
            } while (cVar1 == '\0');
            if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
              func_0x0001003319b0();
            }
            *piRam0000000103802e60 = 7;
            plStack_10 = plRam0000000103805368;
            DataMemoryBarrier(2,3);
            *plRam0000000103805368 = lVar4;
            func_0x000100352ad4(*(undefined1 *)(lVar4 + 0x48));
            lStack_58 = 0;
            func_0x000100122f30();
            if (lStack_58 != 0) {
              func_0x000100331ba4();
            }
            lStack_68 = 0;
            func_0x000100122fdc();
            if (lStack_68 != 0) {
              func_0x000100331ba4();
            }
          }
          else {
            if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
              func_0x0001003319b0();
            }
            plStack_10 = plRam0000000103805368;
            DataMemoryBarrier(2,3);
            *plRam0000000103805368 = 0;
            lStack_68 = 0;
            func_0x000100122fdc();
            if (lStack_68 != 0) {
              func_0x000100331ba4();
            }
          }
        }
        else {
          if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
            func_0x0001003319b0();
          }
          *puRam0000000103805330 = 1;
        }
      }
      else {
        if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        *puRam0000000103805330 = 0;
      }
    }
    else {
      puVar2 = (undefined8 *)func_0x0001003516e8();
      if ((puVar2 != (undefined8 *)0x0) &&
         (*(long *)(*(long *)(*(long *)*puVar2 + 0x10) + 0x10) != lRam0000000103805310)) {
        puVar2 = (undefined8 *)0x0;
      }
      if (puVar2 != (undefined8 *)0x0) {
        lStack_8 = (long)*(int *)(param_3 + 0x1d8);
        plStack_10 = (long *)func_0x000100331820(uRam0000000103805320,0xd8);
        func_0x0001003618cc(plStack_10,lStack_8,0,0);
        func_0x00010035688c(plStack_10);
        uStack_88 = 0;
        uStack_84 = 0;
        uStack_100 = 0;
        uStack_fc = 0;
        func_0x000100352c14(uRam0000000103805328,0);
      }
    }
  }
  else {
    uStack_88 = 0;
    uStack_84 = 0;
    uStack_f8 = 0;
    uStack_f4 = 0;
    func_0x000100352c14(uRam0000000103805308,0);
    if (*(long *)(param_3 + 0x80) != 0) {
      lVar4 = func_0x0001003518a0();
      plStack_10 = *(long **)(lVar4 + 0x2a0);
      uVar6 = func_0x000100352124(*(undefined8 *)(*(long *)(param_3 + 0x80) + 0x28));
      func_0x000100354118(plStack_10,uVar6);
    }
    lVar4 = func_0x0001003518a0();
    if (0xf < *(int *)(*(long *)(*(long *)(lVar4 + 0x2a0) + 0x60) + 0x10)) {
      lVar4 = func_0x0001003518a0();
      plStack_10 = *(long **)(lVar4 + 0x2a0);
      lVar4 = func_0x0001003518a0();
      uVar6 = func_0x00010035629c(*(undefined8 *)(*(long *)(lVar4 + 0x2a0) + 0x60),0,0xf);
      func_0x000100354118(plStack_10,uVar6);
    }
    puVar2 = (undefined8 *)func_0x0001003516e8();
    if ((puVar2 != (undefined8 *)0x0) &&
       (*(long *)(*(long *)(*(long *)*puVar2 + 0x10) + 0x10) != lRam0000000103805310)) {
      puVar2 = (undefined8 *)0x0;
    }
    if (puVar2 == (undefined8 *)0x0) {
      uVar6 = func_0x000100351918();
      func_0x0001003595c8(uVar6,0x2c);
      func_0x0001003519a4();
      lVar4 = func_0x0001003517d8();
      if (lVar4 != 0) {
        puVar2 = (undefined8 *)func_0x0001003517d8();
        if ((puVar2 != (undefined8 *)0x0) &&
           (*(long *)(*(long *)(*(long *)*puVar2 + 0x10) + 8) != lRam0000000103805318)) {
          puVar2 = (undefined8 *)0x0;
        }
        if (puVar2 != (undefined8 *)0x0) {
          puVar2 = (undefined8 *)func_0x0001003517d8();
          if ((puVar2 != (undefined8 *)0x0) &&
             (*(long *)(*(long *)(*(long *)*puVar2 + 0x10) + 8) != lRam0000000103805318)) {
            puVar2 = (undefined8 *)0x0;
          }
          func_0x000100377ba4(puVar2);
        }
      }
    }
    else {
      uVar6 = func_0x000100351918();
      func_0x0001003595c8(uVar6,0x2c);
      puVar2 = (undefined8 *)func_0x0001003516e8();
      if ((puVar2 != (undefined8 *)0x0) &&
         (*(long *)(*(long *)(*(long *)*puVar2 + 0x10) + 0x10) != lRam0000000103805310)) {
        puVar2 = (undefined8 *)0x0;
      }
      func_0x000100377bb8(puVar2,*(undefined1 *)(param_3 + 0x1fe));
    }
  }
LAB_100123008:
  if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  puStack_80 = &uStack_110;
  uVar8 = func_0x0001003560e4(*puRam0000000103804740,*(undefined8 *)(param_3 + 0x70));
  puVar5 = puStack_80;
  *puStack_80 = uVar8;
  puVar5[1] = param_2;
  uVar6 = 0x100123058;
  if (param_3 != 0) {
    *(undefined4 *)(param_3 + 0x1b0) = uStack_110;
    *(undefined4 *)(param_3 + 0x1b4) = uStack_10c;
    puStack_80 = &uStack_118;
    uVar8 = func_0x0001003560e4(*puRam0000000103804740,*(undefined8 *)(param_3 + 0x78));
    puVar5 = puStack_80;
    *puStack_80 = uVar8;
    puVar5[1] = param_2;
    uVar6 = 0x1001230ac;
    if (param_3 != 0) {
      *(undefined4 *)(param_3 + 0x1b8) = uStack_118;
      *(undefined4 *)(param_3 + 0x1bc) = uStack_114;
      return (undefined4 *)(param_3 + 0x1b8);
    }
  }
  func_0x000100382ea0(0xee,uVar6);
  uVar6 = extraout_x17;
LAB_1001230e8:
  uVar6 = func_0x000100382ea0(0xcc,uVar6);
  if (*plRam00000001037fff88 != 0) {
    func_0x0001003316e0();
  }
  puVar5 = puRam0000000103805380;
  uStack_198 = 0;
  uStack_190 = 0;
  uStack_188 = 0;
  uStack_1b0 = 0;
  uStack_1a8 = 0;
  lStack_1a0 = 0;
  func_0x000100384d40(uVar6);
  func_0x000100384d54(&uStack_198);
  while (cVar1 = func_0x000100384d68(&uStack_198), cVar1 != '\0') {
    if (*plRam00000001037fff88 != 0) {
      func_0x0001003316e0();
    }
    func_0x00010035340c(&uStack_1b0);
    while (cVar1 = func_0x000100353470(&uStack_1b0), cVar1 != '\0') {
      if (*plRam00000001037fff88 != 0) {
        func_0x0001003316e0();
      }
      puVar5 = (undefined4 *)
               func_0x00010035048c(puVar5,uRam0000000103800c08,
                                   *(undefined8 *)(*(long *)(lStack_1a0 + 0x58) + 0x60),
                                   uRam0000000103805398);
    }
    lStack_180 = 0;
    func_0x000100123248();
    if (lStack_180 != 0) {
      func_0x000100331ba4();
    }
  }
  lStack_170 = 0;
  func_0x0001001232a8();
  if (lStack_170 != 0) {
    func_0x000100331ba4();
  }
  return puVar5;
}

