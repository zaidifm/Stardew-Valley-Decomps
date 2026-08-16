/* 0x0600671a StardewValley.Mobile.TapToMoveUtils.TraceMap @ 0x101fcfba8 */

/* WARNING: Removing unreachable block (ram,0x000101fd049c) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* WARNING: Restarted to delay deadcode elimination for space: stack */

void SDV_StardewValley_Mobile_TapToMoveUtils_TraceMap_0600671a(long param_1)

{
  undefined8 *puVar1;
  undefined1 auVar2 [16];
  undefined1 auVar3 [16];
  undefined1 auVar4 [16];
  undefined1 auVar5 [16];
  undefined1 auVar6 [16];
  undefined1 auVar7 [16];
  undefined1 auVar8 [16];
  code *pcVar9;
  char cVar10;
  int iVar11;
  long lVar12;
  undefined8 uVar13;
  undefined8 uVar14;
  long *plVar15;
  undefined8 uVar16;
  undefined8 uVar17;
  int iVar18;
  undefined1 auVar19 [16];
  undefined8 uStack_260;
  long *plStack_258;
  int iStack_24c;
  long lStack_248;
  long lStack_240;
  char cStack_235;
  undefined4 uStack_234;
  undefined8 uStack_230;
  long *plStack_228;
  undefined1 auStack_220 [16];
  undefined1 auStack_210 [16];
  long lStack_200;
  long lStack_1f8;
  long lStack_1f0;
  long lStack_1e8;
  undefined8 uStack_1e0;
  undefined8 uStack_1d8;
  undefined8 uStack_1d0;
  undefined8 uStack_1c8;
  long lStack_1c0;
  undefined8 uStack_1b8;
  undefined8 uStack_1b0;
  undefined8 uStack_1a8;
  long lStack_1a0;
  undefined8 uStack_198;
  undefined8 uStack_190;
  char cStack_181;
  long lStack_180;
  undefined8 uStack_178;
  char *pcStack_170;
  long lStack_168;
  long lStack_160;
  long lStack_158;
  long lStack_150;
  undefined8 uStack_148;
  undefined8 uStack_140;
  undefined8 uStack_138;
  undefined8 uStack_130;
  undefined8 uStack_128;
  undefined8 uStack_120;
  long lStack_118;
  long lStack_110;
  undefined8 uStack_108;
  undefined8 uStack_100;
  undefined8 uStack_f8;
  undefined8 uStack_f0;
  undefined8 uStack_e8;
  undefined8 uStack_e0;
  undefined8 uStack_d8;
  undefined8 uStack_d0;
  undefined8 uStack_c8;
  undefined1 *puStack_c0;
  undefined8 uStack_b8;
  undefined1 *puStack_b0;
  undefined8 uStack_a8;
  undefined1 *puStack_a0;
  undefined8 uStack_98;
  undefined1 *puStack_90;
  long lStack_88;
  long lStack_80;
  undefined8 uStack_78;
  undefined8 uStack_70;
  undefined8 uStack_68;
  
  cVar10 = cRam0000000103911529;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar10 == '\0') {
    func_0x00010119b908(&UNK_103325b60);
    cRam0000000103911529 = '\x01';
  }
  uStack_260 = 0;
  plStack_258 = (long *)0x0;
  iStack_24c = 0;
  lStack_248 = 0;
  lStack_240 = 0;
  cStack_235 = '\0';
  uStack_234 = 0;
  uStack_230 = 0;
  plStack_228 = (long *)0x0;
  auStack_220._0_8_ = 0;
  auStack_220._8_8_ = 0;
  auStack_210._0_8_ = 0;
  auStack_210._8_8_ = 0;
  uVar14 = _UNK_1036d8040;
  auVar19 = ZEXT816(0);
  auVar5 = ZEXT816(0);
  if (*(long *)(param_1 + 0x48) != 0) {
    lVar12 = func_0x000100353ce0(*(long *)(param_1 + 0x48),0);
    auVar7._8_8_ = auStack_220._8_8_;
    auVar7._0_8_ = auStack_220._0_8_;
    auVar6._8_8_ = auStack_220._8_8_;
    auVar6._0_8_ = auStack_220._0_8_;
    auVar5._8_8_ = auStack_220._8_8_;
    auVar5._0_8_ = auStack_220._0_8_;
    auVar3._8_8_ = auStack_210._8_8_;
    auVar3._0_8_ = auStack_210._0_8_;
    auVar2._8_8_ = auStack_210._8_8_;
    auVar2._0_8_ = auStack_210._0_8_;
    auVar19._8_8_ = auStack_210._8_8_;
    auVar19._0_8_ = auStack_210._0_8_;
    uVar14 = _UNK_1036d8050;
    if ((lVar12 != -0x68) &&
       (uVar14 = _UNK_1036d8048, auVar19 = auVar2, auVar5 = auVar6, lVar12 != 0)) {
      uStack_260 = CONCAT44(uStack_260._4_4_,*(undefined4 *)(lVar12 + 0x68));
      uVar14 = _UNK_1036d8060;
      auVar19 = auVar3;
      auVar5 = auVar7;
      if (*(long *)(param_1 + 0x48) != 0) {
        lVar12 = func_0x000100353ce0(*(long *)(param_1 + 0x48),0);
        auVar8._8_8_ = auStack_220._8_8_;
        auVar8._0_8_ = auStack_220._0_8_;
        auVar5._8_8_ = auStack_220._8_8_;
        auVar5._0_8_ = auStack_220._0_8_;
        auVar4._8_8_ = auStack_210._8_8_;
        auVar4._0_8_ = auStack_210._0_8_;
        auVar19._8_8_ = auStack_210._8_8_;
        auVar19._0_8_ = auStack_210._0_8_;
        uVar14 = _UNK_1036d8068;
        if ((lVar12 != 0) &&
           (uVar14 = _UNK_1036d8070, auVar19 = auVar4, auVar5 = auVar8, lVar12 != -0x68)) {
          iStack_24c = 0;
          uStack_260 = CONCAT44(*(undefined4 *)(lVar12 + 0x6c),(int)uStack_260);
          iVar18 = 0;
          uVar14 = _UNK_1036d8118;
          lStack_80 = param_1;
          auVar19 = auStack_210;
          auVar5 = auStack_220;
          if (param_1 != 0) {
LAB_101fcfc94:
            do {
              lStack_88 = *(long *)(lStack_80 + 0x48);
              uVar14 = _UNK_1036d8080;
              auVar19 = auStack_210;
              auVar5 = auStack_220;
              if (lStack_88 == 0) break;
              iVar11 = func_0x00010035fc70();
              if (iVar11 <= iVar18) {
                return;
              }
              uVar14 = _UNK_1036d8088;
              lStack_1e8 = param_1;
              auVar19 = auStack_210;
              auVar5 = auStack_220;
              if ((param_1 == 0) ||
                 (lStack_1f0 = *(long *)(param_1 + 0x48), uVar14 = _UNK_1036d8098, lStack_1f0 == 0))
              break;
              lStack_248 = func_0x000100353ce0(lStack_1f0,iStack_24c);
              uVar13 = func_0x000100331794(uRam00000001038c4f40,7);
              uStack_1e0 = uVar13;
              uVar14 = func_0x00010034eec0(&iStack_24c);
              func_0x000100331f8c(uVar13,0,uVar14);
              uStack_1d8 = uVar13;
              func_0x000100331f8c(uVar13,1,uRam0000000103904ad0);
              lStack_1c0 = lStack_248;
              uVar14 = _UNK_1036d80a0;
              uStack_1d0 = uVar13;
              auVar19 = auStack_210;
              auVar5 = auStack_220;
              if (lStack_248 == 0) break;
              uStack_1c8 = *(undefined8 *)(lStack_248 + 0x10);
              func_0x000100331f8c(uVar13,2,uStack_1c8);
              uStack_1b8 = uVar13;
              func_0x000100331f8c(uVar13,3,uRam0000000103904ad8);
              lStack_1a0 = lStack_248;
              uVar14 = _UNK_1036d80b0;
              uStack_1b0 = uVar13;
              auVar19 = auStack_210;
              auVar5 = auStack_220;
              if (lStack_248 == 0) break;
              uStack_1a8 = *(undefined8 *)(lStack_248 + 0x20);
              func_0x000100331f8c(uVar13,4,uStack_1a8);
              uStack_198 = uVar13;
              func_0x000100331f8c(uVar13,5,uRam0000000103904ae0);
              uStack_70 = 6;
              lStack_180 = lStack_248;
              uVar14 = _UNK_1036d80c0;
              uStack_190 = uVar13;
              uStack_78 = uVar13;
              uStack_68 = uVar13;
              auVar19 = auStack_210;
              auVar5 = auStack_220;
              if (lStack_248 == 0) break;
              cStack_235 = *(char *)(lStack_248 + 0x70);
              pcStack_170 = &cStack_235;
              puVar1 = (undefined8 *)0x1038d6090;
              if (cStack_235 != '\0') {
                puVar1 = (undefined8 *)0x1038d6088;
              }
              uStack_178 = *puVar1;
              cStack_181 = cStack_235;
              func_0x000100331f8c(uVar13,6,uStack_178);
              func_0x000100351da0(uStack_68);
              func_0x00010033180c();
              uVar14 = _UNK_1036d80d8;
              lStack_160 = param_1;
              auVar19 = auStack_210;
              auVar5 = auStack_220;
              if ((param_1 == 0) ||
                 (lStack_168 = *(long *)(param_1 + 0x48), uVar14 = _UNK_1036d80e8, lStack_168 == 0))
              break;
              lStack_150 = func_0x000100353ce0(lStack_168,iStack_24c);
              uVar14 = _UNK_1036d80f0;
              auVar19 = auStack_210;
              auVar5 = auStack_220;
              if (lStack_150 == 0) break;
              lStack_240 = *(long *)(lStack_150 + 0x50);
              lStack_158 = lStack_240;
              uVar13 = func_0x000100331794(uRam00000001038c4f40,6);
              uStack_148 = uVar13;
              func_0x000100331f8c(uVar13,0,uRam0000000103904ae8);
              uStack_140 = uVar13;
              uVar14 = func_0x00010034eec0(&uStack_260);
              func_0x000100331f8c(uVar13,1,uVar14);
              uStack_138 = uVar13;
              func_0x000100331f8c(uVar13,2,uRam0000000103904af0);
              uStack_130 = uVar13;
              uVar14 = func_0x00010034eec0((long)&uStack_260 + 4);
              func_0x000100331f8c(uVar13,3,uVar14);
              uStack_128 = uVar13;
              func_0x000100331f8c(uVar13,4,uRam0000000103904af8);
              uVar14 = _UNK_1036d8100;
              uStack_120 = uVar13;
              lStack_110 = param_1;
              auVar19 = auStack_210;
              auVar5 = auStack_220;
              if ((param_1 == 0) ||
                 (lStack_118 = *(long *)(param_1 + 0x48), uVar14 = _UNK_1036d8110, lStack_118 == 0))
              break;
              uStack_234 = func_0x00010035fc70();
              uVar14 = func_0x00010034eec0(&uStack_234);
              func_0x000100331f8c(uVar13,5,uVar14);
              func_0x000100351da0(uVar13);
              func_0x00010033180c();
              uStack_230 = uStack_230 & 0xffffffff00000000;
              auVar19 = auStack_210;
              auVar5 = auStack_220;
              if (0 < (int)uStack_260) {
LAB_101fcffe8:
                do {
                  uStack_230 = uStack_230 & 0xffffffff;
                  if (0 < uStack_260._4_4_) {
LAB_101fcfffc:
                    uVar14 = _UNK_1036d8120;
                    auVar19 = auStack_210;
                    auVar5 = auStack_220;
                    if (lStack_240 != 0) {
                      plStack_258 = (long *)func_0x000100355ec8(lStack_240,uStack_230 & 0xffffffff,
                                                                uStack_230._4_4_);
                      if (plStack_258 == (long *)0x0) goto LAB_101fd03ac;
                      uVar14 = func_0x000100331794(uRam00000001038c4f40,8);
                      uStack_108 = uVar14;
                      func_0x000100331f8c(uVar14,0,uRam0000000103904b00);
                      uStack_100 = uVar14;
                      uVar13 = func_0x00010034eec0(&iStack_24c);
                      func_0x000100331f8c(uVar14,1,uVar13);
                      uStack_f8 = uVar14;
                      func_0x000100331f8c(uVar14,2,uRam0000000103904b08);
                      uStack_f0 = uVar14;
                      uVar13 = func_0x00010034eec0(&uStack_230);
                      func_0x000100331f8c(uVar14,3,uVar13);
                      uStack_e8 = uVar14;
                      func_0x000100331f8c(uVar14,4,uRam00000001038d7758);
                      uStack_e0 = uVar14;
                      uVar13 = func_0x00010034eec0((long)&uStack_230 + 4);
                      func_0x000100331f8c(uVar14,5,uVar13);
                      uStack_d8 = uVar14;
                      func_0x000100331f8c(uVar14,6,uRam0000000103904b10);
                      uStack_d0 = uVar14;
                      uVar13 = (**(code **)(*plStack_258 + 0x60))();
                      func_0x000100331f8c(uVar14,7,uVar13);
                      func_0x000100351da0(uVar14);
                      func_0x00010033180c();
                      uVar14 = _UNK_1036d8130;
                      auVar19 = auStack_210;
                      auVar5 = auStack_220;
                      if (plStack_258 != (long *)0x0) {
                        plVar15 = (long *)func_0x00010035c854();
                        plStack_228 = (long *)(**(code **)(*plVar15 + -0x10))();
                        do {
                          auVar19 = auStack_220;
                          if (plStack_228 == (long *)0x0) {
LAB_101fd0224:
                            auStack_220 = auVar19;
                            func_0x0001003316f4(0xee,_UNK_1036d8140);
                            goto LAB_101fd0508;
                          }
                          cVar10 = (**(code **)(*plStack_228 + -0x78))();
                          if (cVar10 == '\0') goto LAB_101fd0210;
                          auVar19 = auStack_220;
                          if (plStack_228 == (long *)0x0) goto LAB_101fd0224;
                          auVar19 = (**(code **)(*plStack_228 + -0x38))();
                          uVar13 = uRam0000000103904b20;
                          uVar14 = uRam00000001039047a0;
                          uVar17 = auVar19._0_8_;
                          puStack_c0 = auStack_220;
                          if ((auStack_220 == (undefined1 *)0x0) ||
                             (uStack_c8 = uVar17, puStack_b0 = auStack_220,
                             auStack_220 == (undefined1 *)0x0)) goto LAB_101fd0224;
                          uStack_b8 = auVar19._8_8_;
                          auStack_220 = auVar19;
                          uVar16 = func_0x000100374f30(auVar19._8_8_);
                          uVar14 = func_0x00010035048c(uVar13,uVar17,uVar14,uVar16);
                          if (lRam0000000103976fb8 != 0) {
                            func_0x00010119b8f8();
                          }
                          func_0x00010033180c(uVar14);
                        } while( true );
                      }
                    }
                    goto LAB_101fd0500;
                  }
LAB_101fd03e8:
                  iVar18 = (int)uStack_230 + 1;
                  uStack_230 = CONCAT44(uStack_230._4_4_,iVar18);
                  iVar11 = (int)uStack_260;
                  if (lRam0000000103976fb8 != 0) {
                    func_0x00010119b8f8();
                    auVar19 = auStack_210;
                    auVar5 = auStack_220;
                    if (iVar11 <= iVar18) break;
                    goto LAB_101fcffe8;
                  }
                  auVar19 = auStack_210;
                  auVar5 = auStack_220;
                } while (iVar18 < (int)uStack_260);
              }
              iVar18 = iStack_24c + 1;
              iStack_24c = iVar18;
              auStack_220 = auVar5;
              auStack_210 = auVar19;
              if (lRam0000000103976fb8 != 0) {
                lStack_80 = param_1;
                func_0x00010119b8f8();
                uVar14 = _UNK_1036d8118;
                auVar19 = auStack_210;
                auVar5 = auStack_220;
                if (param_1 == 0) break;
                goto LAB_101fcfc94;
              }
              uVar14 = _UNK_1036d8118;
              lStack_80 = param_1;
            } while (param_1 != 0);
          }
        }
      }
    }
  }
LAB_101fd0500:
  auStack_220 = auVar5;
  auStack_210 = auVar19;
  func_0x0001003316f4(0xee,uVar14);
LAB_101fd0508:
                    /* WARNING: Does not return */
  pcVar9 = (code *)SoftwareBreakpoint(1,0x101fd050c);
  (*pcVar9)();
LAB_101fd0210:
  lStack_200 = 0;
  if (plStack_228 != (long *)0x0) {
    uVar14 = _UNK_1036d8160;
    auVar19 = auStack_210;
    auVar5 = auStack_220;
    if (plStack_228 == (long *)0x0) goto LAB_101fd0500;
    (**(code **)(*plStack_228 + -0x28))();
  }
  if (lStack_200 != 0) {
    func_0x000100331ba4();
  }
  plVar15 = (long *)(**(code **)(*plStack_258 + 0x70))();
  plStack_228 = (long *)(**(code **)(*plVar15 + -0x10))();
  do {
    auVar19 = auStack_210;
    if (plStack_228 == (long *)0x0) {
LAB_101fd035c:
      auStack_210 = auVar19;
      func_0x0001003316f4(0xee,_UNK_1036d8150);
      goto LAB_101fd0508;
    }
    cVar10 = (**(code **)(*plStack_228 + -0x78))();
    if (cVar10 == '\0') break;
    auVar19 = auStack_210;
    if (plStack_228 == (long *)0x0) goto LAB_101fd035c;
    auVar19 = (**(code **)(*plStack_228 + -0x38))();
    uVar13 = uRam0000000103904b18;
    uVar14 = uRam00000001039047a0;
    uVar17 = auVar19._0_8_;
    puStack_a0 = auStack_210;
    if ((auStack_210 == (undefined1 *)0x0) ||
       (uStack_a8 = uVar17, puStack_90 = auStack_210, auStack_210 == (undefined1 *)0x0))
    goto LAB_101fd035c;
    uStack_98 = auVar19._8_8_;
    auStack_210 = auVar19;
    uVar16 = func_0x000100374f30(auVar19._8_8_);
    uVar14 = func_0x00010035048c(uVar13,uVar17,uVar14,uVar16);
    if (lRam0000000103976fb8 != 0) {
      func_0x00010119b8f8();
    }
    func_0x00010033180c(uVar14);
  } while( true );
  lStack_1f8 = 0;
  if (plStack_228 != (long *)0x0) {
    uVar14 = _UNK_1036d8168;
    auVar19 = auStack_210;
    auVar5 = auStack_220;
    if (plStack_228 == (long *)0x0) goto LAB_101fd0500;
    (**(code **)(*plStack_228 + -0x28))();
  }
  if (lStack_1f8 != 0) {
    func_0x000100331ba4();
  }
LAB_101fd03ac:
  iVar18 = uStack_230._4_4_ + 1;
  uStack_230 = CONCAT44(iVar18,(int)uStack_230);
  iVar11 = uStack_260._4_4_;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (iVar11 <= iVar18) goto LAB_101fd03e8;
  goto LAB_101fcfffc;
}

