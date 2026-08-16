/* 0x0600676d StardewValley.Mobile.VirtualJoypad.drawAdjusters @ 0x101fd8424 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_drawAdjusters_0600676d(long param_1,long param_2)

{
  int *piVar1;
  undefined4 *puVar2;
  undefined4 *puVar3;
  int *piVar4;
  int iVar5;
  int iVar6;
  char cVar7;
  undefined8 uVar8;
  code *pcVar9;
  undefined4 uVar10;
  undefined8 uVar11;
  int iVar12;
  long lVar13;
  undefined8 uVar14;
  undefined8 uVar15;
  undefined8 uStack_168;
  undefined8 uStack_160;
  undefined8 uStack_158;
  undefined8 uStack_150;
  undefined4 uStack_148;
  undefined4 uStack_144;
  undefined4 uStack_140;
  undefined4 uStack_13c;
  undefined4 uStack_138;
  undefined8 uStack_130;
  undefined8 uStack_128;
  undefined8 uStack_120;
  undefined8 uStack_118;
  undefined4 uStack_110;
  undefined4 uStack_10c;
  undefined4 uStack_108;
  undefined4 uStack_104;
  undefined4 uStack_100;
  undefined8 uStack_f8;
  undefined8 uStack_f0;
  undefined8 uStack_e8;
  undefined8 uStack_e0;
  undefined4 uStack_d8;
  undefined4 uStack_d4;
  undefined4 uStack_d0;
  undefined4 uStack_cc;
  undefined4 uStack_c8;
  undefined8 uStack_c0;
  undefined8 uStack_b8;
  undefined4 uStack_b0;
  undefined8 uStack_a0;
  undefined8 uStack_98;
  undefined4 uStack_90;
  undefined8 uStack_80;
  undefined8 uStack_78;
  undefined4 uStack_70;
  
  cVar7 = cRam000000010391157c;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar7 == '\0') {
    func_0x00010119b908(&UNK_103325ea0);
    cRam000000010391157c = '\x01';
    cVar7 = *(char *)(param_1 + 0x107);
  }
  else {
    cVar7 = *(char *)(param_1 + 0x107);
  }
  if (cVar7 == '\0') {
    return;
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
    iVar12 = *piRam00000001038d57b0;
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
  }
  else {
    iVar12 = *piRam00000001038d57b0;
  }
  uVar11 = _UNK_1036d9430;
  if ((lRam00000001038d6bc0 != -8) && (uVar11 = _UNK_1036d9428, lRam00000001038d6bc0 != 0)) {
    iVar5 = *(int *)(lRam00000001038d6bc0 + 8);
    iVar6 = *piRam00000001038d57b0;
    uVar10 = func_0x000100331988();
    func_0x000101ea2d6c(param_2,iVar12,0,iVar5 + iVar6 * -2,0xf4,uVar10);
    lVar13 = *(long *)(param_1 + 0x98);
    uVar11 = _UNK_1036d9438;
    if (lVar13 != 0) {
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar11 = _UNK_1036d9448;
      if (((lRam00000001038d6bc0 != -8) && (uVar11 = _UNK_1036d9440, lRam00000001038d6bc0 != 0)) &&
         (piVar1 = (int *)(lVar13 + 0x38), uVar11 = _UNK_1036d9450, piVar1 != (int *)0x0)) {
        *piVar1 = (*(int *)(lRam00000001038d6bc0 + 8) - *piRam00000001038d57b0) + -100;
        lVar13 = *(long *)(param_1 + 0x98);
        uVar11 = _UNK_1036d9458;
        if ((lVar13 != 0) && (uVar11 = _UNK_1036d9460, lVar13 != -0x38)) {
          *(undefined4 *)(lVar13 + 0x3c) = 0x14;
          (**(code **)(**(long **)(param_1 + 0x98) + 0xa8))(*(long **)(param_1 + 0x98),param_2);
          uVar11 = _UNK_1036d9470;
          if (((*(long *)(param_1 + 0x90) != 0) &&
              ((uVar11 = _UNK_1036d9478, *(long *)(param_1 + 0x98) != 0 &&
               (puVar2 = (undefined4 *)(*(long *)(param_1 + 0x98) + 0x38), uVar11 = _UNK_1036d9480,
               puVar2 != (undefined4 *)0x0)))) &&
             (puVar3 = (undefined4 *)(*(long *)(param_1 + 0x90) + 0x38), uVar11 = _UNK_1036d9488,
             puVar3 != (undefined4 *)0x0)) {
            *puVar3 = *puVar2;
            lVar13 = *(long *)(param_1 + 0x90);
            uVar11 = _UNK_1036d9490;
            if ((lVar13 != 0) && (uVar11 = _UNK_1036d9498, lVar13 != -0x38)) {
              *(undefined4 *)(lVar13 + 0x3c) = 0x90;
              (**(code **)(**(long **)(param_1 + 0x90) + 0xa8))(*(long **)(param_1 + 0x90),param_2);
              uVar14 = *puRam00000001038d53d0;
              uStack_168 = 0;
              uStack_160 = 0;
              func_0x00010034ede4(&uStack_168,*(undefined4 *)(param_1 + 0x140),0x10,0x52,0x4e);
              uVar15 = uStack_160;
              uVar8 = uStack_168;
              uStack_158 = 0;
              uStack_150 = 0;
              func_0x00010034ede4(&uStack_158,0x96,0x1d6,4,4);
              uStack_13c = (undefined4)uStack_150;
              uStack_138 = (undefined4)((ulong)uStack_150 >> 0x20);
              uStack_144 = (undefined4)uStack_158;
              uStack_140 = (undefined4)((ulong)uStack_158 >> 0x20);
              uStack_148 = 1;
              uStack_b8 = CONCAT44(uStack_13c,uStack_140);
              uStack_c0 = CONCAT44(uStack_144,1);
              uStack_b0 = uStack_138;
              uVar10 = func_0x000100353f24();
              uVar11 = _UNK_1036d94a8;
              if (*(char *)(lRam00000001038c7e00 + 0x35) == '\0') {
                func_0x0001003319b0(lRam00000001038c7e00);
                uVar11 = _UNK_1036d94a8;
              }
              _UNK_1036d94a8 = uVar11;
              if (param_2 != 0) {
                func_0x00010035615c(0,*puRam00000001038d4510,puRam00000001038d4510[1],0x358637bd,
                                    param_2,uVar14,uVar8,uVar15,&uStack_c0,uVar10,0);
                (**(code **)(**(long **)(param_1 + 0xb0) + 0xa8))
                          (*(long **)(param_1 + 0xb0),param_2);
                (**(code **)(**(long **)(param_1 + 0xb8) + 0xa8))
                          (*(long **)(param_1 + 0xb8),param_2);
                (**(code **)(**(long **)(param_1 + 0xc0) + 0xa8))
                          (*(long **)(param_1 + 0xc0),param_2);
                lVar13 = *(long *)(param_1 + 0xb8);
                uVar11 = _UNK_1036d94c8;
                if ((lVar13 != 0) && (uVar11 = _UNK_1036d94d0, (int *)(lVar13 + 0x38) != (int *)0x0)
                   ) {
                  uVar15 = *puRam00000001038d5fa8;
                  uStack_130 = 0;
                  uStack_128 = 0;
                  func_0x00010034ede4(&uStack_130,*(int *)(lVar13 + 0x38) + 0x18,
                                      *(int *)(lVar13 + 0x3c) + 0x1c,0x1a,0x1a);
                  uVar8 = uStack_128;
                  uVar11 = uStack_130;
                  uStack_120 = 0;
                  uStack_118 = 0;
                  func_0x00010034ede4(&uStack_120,0x23a,0x224,0x1a,0x1a);
                  uStack_104 = (undefined4)uStack_118;
                  uStack_100 = (undefined4)((ulong)uStack_118 >> 0x20);
                  uStack_10c = (undefined4)uStack_120;
                  uStack_108 = (undefined4)((ulong)uStack_120 >> 0x20);
                  uStack_110 = 1;
                  uStack_98 = CONCAT44(uStack_104,uStack_108);
                  uStack_a0 = CONCAT44(uStack_10c,1);
                  uStack_90 = uStack_100;
                  uVar10 = func_0x000100331988();
                  if (*(char *)(lRam00000001038c7e00 + 0x35) == '\0') {
                    func_0x0001003319b0(lRam00000001038c7e00);
                  }
                  func_0x00010035615c(0,*puRam00000001038d4510,puRam00000001038d4510[1],0x358637bd,
                                      param_2,uVar15,uVar11,uVar8,&uStack_a0,uVar10,0);
                  lVar13 = *(long *)(param_1 + 0xc0);
                  uVar11 = _UNK_1036d94d8;
                  if ((lVar13 != 0) &&
                     (uVar11 = _UNK_1036d94e0, (int *)(lVar13 + 0x38) != (int *)0x0)) {
                    uVar15 = *puRam00000001038d5fa8;
                    uStack_f8 = 0;
                    uStack_f0 = 0;
                    func_0x00010034ede4(&uStack_f8,*(int *)(lVar13 + 0x38) + 0x18,
                                        *(int *)(lVar13 + 0x3c) + 0x1c,0x1a,0x1a);
                    uVar8 = uStack_f0;
                    uVar11 = uStack_f8;
                    uStack_e8 = 0;
                    uStack_e0 = 0;
                    func_0x00010034ede4(&uStack_e8,0x23a,0x224,0x1a,0x1a);
                    uStack_cc = (undefined4)uStack_e0;
                    uStack_c8 = (undefined4)((ulong)uStack_e0 >> 0x20);
                    uStack_d4 = (undefined4)uStack_e8;
                    uStack_d0 = (undefined4)((ulong)uStack_e8 >> 0x20);
                    uStack_d8 = 1;
                    uStack_78 = CONCAT44(uStack_cc,uStack_d0);
                    uStack_80 = CONCAT44(uStack_d4,1);
                    uStack_70 = uStack_c8;
                    uVar10 = func_0x000100331988();
                    if (*(char *)(lRam00000001038c7e00 + 0x35) == '\0') {
                      func_0x0001003319b0(lRam00000001038c7e00);
                    }
                    func_0x00010035615c(0,*puRam00000001038d4510,puRam00000001038d4510[1],0x358637bd
                                        ,param_2,uVar15,uVar11,uVar8,&uStack_80,uVar10,0);
                    lVar13 = *(long *)(param_1 + 0xa8);
                    uVar11 = _UNK_1036d94f0;
                    if ((((*(long *)(lVar13 + 0x90) != 0) &&
                         (uVar11 = _UNK_1036d94f8, *(long *)(param_1 + 0x98) != 0)) &&
                        (piVar1 = (int *)(*(long *)(param_1 + 0x98) + 0x38), uVar11 = _UNK_1036d9500
                        , piVar1 != (int *)0x0)) &&
                       ((uVar11 = _UNK_1036d9508, (int *)(lVar13 + 0x70) != (int *)0x0 &&
                        (piVar4 = (int *)(*(long *)(lVar13 + 0x90) + 0x38), uVar11 = _UNK_1036d9510,
                        piVar4 != (int *)0x0)))) {
                      iVar12 = (*piVar1 - *(int *)(lVar13 + 0x78)) + -0x2c;
                      *piVar4 = iVar12;
                      *(int *)(lVar13 + 0x70) = iVar12;
                      (**(code **)(**(long **)(param_1 + 0xa8) + 0x1a8))
                                (*(long **)(param_1 + 0xa8),param_2,0,0);
                      lVar13 = *(long *)(param_1 + 0xa0);
                      uVar11 = _UNK_1036d9520;
                      if (lVar13 != 0) {
                        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                          func_0x0001003319b0();
                        }
                        uVar11 = _UNK_1036d9530;
                        if (((lRam00000001038d6bc0 != -8) &&
                            (uVar11 = _UNK_1036d9528, lRam00000001038d6bc0 != 0)) &&
                           (uVar11 = _UNK_1036d9538, lVar13 != -0x70)) {
                          *(int *)(lVar13 + 0x78) =
                               *(int *)(lRam00000001038d6bc0 + 8) + *piRam00000001038d57b0 * -2 +
                               -0xa4;
                          lVar13 = *(long *)(*(long *)(param_1 + 0xa0) + 0xa0);
                          uVar11 = _UNK_1036d9548;
                          if (lVar13 != 0) {
                            if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                              func_0x0001003319b0();
                            }
                            uVar11 = _UNK_1036d9558;
                            if (((lRam00000001038d6bc0 != -8) &&
                                (uVar11 = _UNK_1036d9550, lRam00000001038d6bc0 != 0)) &&
                               (piVar1 = (int *)(lVar13 + 0x38), uVar11 = _UNK_1036d9560,
                               piVar1 != (int *)0x0)) {
                              *piVar1 = (*(int *)(lRam00000001038d6bc0 + 8) - *piRam00000001038d57b0
                                        ) + -0x68;
                              (**(code **)(**(long **)(param_1 + 0xa0) + 0x1a8))
                                        (*(long **)(param_1 + 0xa0),param_2,0,0);
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
  func_0x0001003316f4(0xee,uVar11);
                    /* WARNING: Does not return */
  pcVar9 = (code *)SoftwareBreakpoint(1,0x101fd8be8);
  (*pcVar9)();
}

