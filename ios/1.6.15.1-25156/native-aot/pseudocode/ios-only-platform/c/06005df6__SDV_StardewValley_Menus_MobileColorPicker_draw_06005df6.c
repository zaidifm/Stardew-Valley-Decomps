/* 0x06005df6 StardewValley.Menus.MobileColorPicker.draw @ 0x101e05240 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileColorPicker_draw_06005df6(long param_1,long param_2)

{
  int iVar1;
  int iVar2;
  code *pcVar3;
  char cVar4;
  undefined4 uVar5;
  undefined4 uVar6;
  undefined4 uVar7;
  long *plVar8;
  undefined8 uVar9;
  long lVar10;
  undefined8 uVar11;
  undefined8 uVar12;
  undefined8 uVar13;
  int iVar14;
  int iVar15;
  int iVar16;
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
  
  cVar4 = cRam0000000103910c05;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103316c30);
    cRam0000000103910c05 = '\x01';
  }
  uVar13 = _UNK_103279560;
  iVar14 = 0;
  do {
    uVar5 = SDV_StardewValley_Menus_MobileColorPicker_HsvToRgb_06005dfa
                      (((double)iVar14 / 24.0) * 360.0,uVar13,uVar13);
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0(lRam00000001038c4c88);
      lVar10 = *(long *)(param_1 + 0x68);
    }
    else {
      lVar10 = *(long *)(param_1 + 0x68);
    }
    uVar9 = _UNK_10369ed40;
    if ((lVar10 == 0) || (uVar9 = _UNK_10369ed48, (int *)(lVar10 + 0x1c) == (int *)0x0))
    goto LAB_101e06168;
    uVar12 = *puRam00000001038d77a8;
    uStack_190 = 0;
    uStack_188 = 0;
    func_0x00010034ede4(&uStack_190,
                        *(int *)(lVar10 + 0x1c) + (*(int *)(param_1 + 0xbc) / 0x18) * iVar14,
                        *(int *)(param_1 + 0xc4) + 4,*(int *)(lVar10 + 0x24) / 0x18,
                        *(int *)(param_1 + 0xc0) + -8);
    uVar9 = _UNK_10369ed50;
    if (param_2 == 0) goto LAB_101e06168;
    func_0x000100355d38(param_2,uVar12,uStack_190,uStack_188,uVar5);
    if (lRam0000000103976fb8 != 0) {
      func_0x00010119b8f8();
    }
    iVar14 = iVar14 + 1;
  } while (iVar14 != 0x18);
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar11 = *puRam00000001038d5350;
  uStack_180 = 0;
  uStack_178 = 0;
  func_0x00010034ede4(&uStack_180,0x38,0x65,0xf,0xf);
  uVar12 = uStack_178;
  uVar13 = uStack_180;
  lVar10 = *(long *)(param_1 + 0x68);
  uVar9 = _UNK_10369ed58;
  if ((lVar10 != 0) && (uVar9 = _UNK_10369ed60, (int *)(lVar10 + 0x1c) != (int *)0x0)) {
    iVar14 = *(int *)(lVar10 + 0x1c);
    uVar5 = *(undefined4 *)(lVar10 + 0x20);
    iVar1 = *(int *)(lVar10 + 0x24);
    uVar7 = *(undefined4 *)(lVar10 + 0x28);
    uVar6 = func_0x000100331988();
    StardewValley_StardewValley_Menus_IClickableMenu_drawTextureBox_060061a8
              (0x40800000,0xbf800000,param_2,uVar11,uVar13,uVar12,iVar14 + -0xc,uVar5,iVar1 + 0x18,
               uVar7,uVar6,0);
    uVar5 = SDV_StardewValley_Menus_MobileColorPicker_HsvToRgb_06005dfa
                      ((double)(((float)*(int *)(*(long *)(param_1 + 0x68) + 0x10) / 100.0) * 360.0)
                       ,0x3ff0000000000000,0x3ff0000000000000);
    lVar10 = *(long *)(param_1 + 0x68);
    uVar9 = _UNK_10369ed70;
    if ((lVar10 != 0) && (uVar9 = _UNK_10369ed78, lVar10 != -0x1c)) {
      uVar13 = *puRam00000001038d77a8;
      uStack_170 = 0;
      uStack_168 = 0;
      func_0x00010034ede4(&uStack_170,
                          *(int *)(lVar10 + 0x1c) +
                          (int)(((float)*(int *)(lVar10 + 0x10) / 100.0) *
                               (float)*(int *)(lVar10 + 0x24)) + -0xc,*(int *)(param_1 + 0xc4) + -8,
                          0x18,*(int *)(param_1 + 0xc0) + 0x10);
      func_0x000100355d38(param_2,uVar13,uStack_170,uStack_168,uVar5);
      uVar11 = *puRam00000001038d5350;
      uStack_160 = 0;
      uStack_158 = 0;
      func_0x00010034ede4(&uStack_160,0x38,0x65,0xf,0xf);
      uVar12 = uStack_158;
      uVar13 = uStack_160;
      lVar10 = *(long *)(param_1 + 0x68);
      uVar9 = _UNK_10369ed80;
      if ((lVar10 != 0) && (uVar9 = _UNK_10369ed88, lVar10 != -0x1c)) {
        iVar15 = *(int *)(lVar10 + 0x10);
        iVar14 = *(int *)(param_1 + 0xc0);
        iVar1 = *(int *)(param_1 + 0xc4);
        iVar16 = *(int *)(lVar10 + 0x24);
        iVar2 = *(int *)(lVar10 + 0x1c);
        uVar7 = func_0x000100331988();
        StardewValley_StardewValley_Menus_IClickableMenu_drawTextureBox_060061a8
                  (0x40800000,0xbf800000,param_2,uVar11,uVar13,uVar12,
                   iVar2 + (int)(((float)iVar15 / 100.0) * (float)iVar16) + -0x12,iVar1 + -0xc,0x24,
                   iVar14 + 0x18,uVar7,0);
        plVar8 = *(long **)(param_1 + 0x80);
        if ((plVar8 != (long *)0x0) &&
           (cVar4 = (**(code **)(*plVar8 + 0x58))(plVar8,*(undefined8 *)(param_1 + 0x68)),
           cVar4 != '\0')) {
          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
            func_0x0001003319b0();
            lVar10 = *(long *)(param_1 + 0x68);
          }
          else {
            lVar10 = *(long *)(param_1 + 0x68);
          }
          uVar9 = _UNK_10369eea0;
          if ((lVar10 == 0) || (uVar9 = _UNK_10369eea8, lVar10 == -0x1c)) goto LAB_101e06168;
          iVar14 = *(int *)(param_1 + 0xc0) + 0x10;
          uVar13 = *puRam00000001038d77a8;
          uStack_150 = 0;
          uStack_148 = 0;
          func_0x00010034ede4(&uStack_150,
                              *(int *)(lVar10 + 0x1c) +
                              (int)(((float)*(int *)(lVar10 + 0x10) / 100.0) *
                                   (float)*(int *)(lVar10 + 0x24)) + -0x20,
                              *(int *)(param_1 + 0xc4) + -0x68,iVar14,iVar14);
          func_0x000100355d38(param_2,uVar13,uStack_150,uStack_148,uVar5);
          uVar11 = *puRam00000001038d5350;
          uStack_140 = 0;
          uStack_138 = 0;
          func_0x00010034ede4(&uStack_140,0x38,0x65,0xf,0xf);
          uVar12 = uStack_138;
          uVar13 = uStack_140;
          lVar10 = *(long *)(param_1 + 0x68);
          uVar9 = _UNK_10369eeb0;
          if ((lVar10 == 0) || (uVar9 = _UNK_10369eeb8, lVar10 == -0x1c)) goto LAB_101e06168;
          iVar15 = *(int *)(lVar10 + 0x10);
          iVar1 = *(int *)(param_1 + 0xc4);
          iVar14 = *(int *)(param_1 + 0xc0) + 0x18;
          iVar16 = *(int *)(lVar10 + 0x24);
          iVar2 = *(int *)(lVar10 + 0x1c);
          uVar5 = func_0x000100331988();
          StardewValley_StardewValley_Menus_IClickableMenu_drawTextureBox_060061a8
                    (0x40800000,0xbf800000,param_2,uVar11,uVar13,uVar12,
                     iVar2 + (int)(((float)iVar15 / 100.0) * (float)iVar16) + -0x24,iVar1 + -0x6c,
                     iVar14,iVar14,uVar5,0);
        }
        iVar14 = 0;
        do {
          uVar9 = _UNK_10369ed90;
          if ((*(long *)(param_1 + 0x68) == 0) ||
             (uVar9 = _UNK_10369ed98, *(long *)(param_1 + 0x70) == 0)) goto LAB_101e06168;
          uVar5 = SDV_StardewValley_Menus_MobileColorPicker_HsvToRgb_06005dfa
                            (((double)*(int *)(*(long *)(param_1 + 0x68) + 0x10) / 100.0) * 360.0,
                             (double)iVar14 / 24.0,
                             (double)*(int *)(*(long *)(param_1 + 0x70) + 0x10) / 100.0);
          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
            func_0x0001003319b0(lRam00000001038c4c88);
            lVar10 = *(long *)(param_1 + 0x78);
          }
          else {
            lVar10 = *(long *)(param_1 + 0x78);
          }
          uVar9 = _UNK_10369eda0;
          if ((lVar10 == 0) || (uVar9 = _UNK_10369eda8, (int *)(lVar10 + 0x1c) == (int *)0x0))
          goto LAB_101e06168;
          uVar13 = *puRam00000001038d77a8;
          uStack_130 = 0;
          uStack_128 = 0;
          func_0x00010034ede4(&uStack_130,
                              *(int *)(lVar10 + 0x1c) + (*(int *)(param_1 + 0xbc) / 0x18) * iVar14,
                              *(int *)(param_1 + 0xc4) + 4,*(int *)(lVar10 + 0x24) / 0x18,
                              *(int *)(param_1 + 0xc0) + -8);
          func_0x000100355d38(param_2,uVar13,uStack_130,uStack_128,uVar5);
          if (lRam0000000103976fb8 != 0) {
            func_0x00010119b8f8();
          }
          iVar14 = iVar14 + 1;
        } while (iVar14 != 0x18);
        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        uVar11 = *puRam00000001038d5350;
        uStack_120 = 0;
        uStack_118 = 0;
        func_0x00010034ede4(&uStack_120,0x38,0x65,0xf,0xf);
        uVar12 = uStack_118;
        uVar13 = uStack_120;
        lVar10 = *(long *)(param_1 + 0x78);
        uVar9 = _UNK_10369edb0;
        if ((lVar10 != 0) && (uVar9 = _UNK_10369edb8, (int *)(lVar10 + 0x1c) != (int *)0x0)) {
          iVar14 = *(int *)(lVar10 + 0x1c);
          uVar5 = *(undefined4 *)(lVar10 + 0x20);
          iVar1 = *(int *)(lVar10 + 0x24);
          uVar7 = *(undefined4 *)(lVar10 + 0x28);
          uVar6 = func_0x000100331988();
          StardewValley_StardewValley_Menus_IClickableMenu_drawTextureBox_060061a8
                    (0x40800000,0xbf800000,param_2,uVar11,uVar13,uVar12,iVar14 + -0xc,uVar5,
                     iVar1 + 0x18,uVar7,uVar6,0);
          uVar9 = _UNK_10369edc0;
          if ((*(long *)(param_1 + 0x68) != 0) &&
             ((uVar9 = _UNK_10369edc8, *(long *)(param_1 + 0x78) != 0 &&
              (uVar9 = _UNK_10369edd0, *(long *)(param_1 + 0x70) != 0)))) {
            uVar5 = SDV_StardewValley_Menus_MobileColorPicker_HsvToRgb_06005dfa
                              ((double)(((float)*(int *)(*(long *)(param_1 + 0x68) + 0x10) / 100.0)
                                       * 360.0),
                               (double)((float)*(int *)(*(long *)(param_1 + 0x78) + 0x10) / 100.0),
                               (double)((float)*(int *)(*(long *)(param_1 + 0x70) + 0x10) / 100.0));
            lVar10 = *(long *)(param_1 + 0x78);
            uVar9 = _UNK_10369edd8;
            if ((lVar10 != 0) && (uVar9 = _UNK_10369ede0, lVar10 != -0x1c)) {
              uVar13 = *puRam00000001038d77a8;
              uStack_110 = 0;
              uStack_108 = 0;
              func_0x00010034ede4(&uStack_110,
                                  *(int *)(lVar10 + 0x1c) +
                                  (int)(((float)*(int *)(lVar10 + 0x10) / 100.0) *
                                       (float)*(int *)(lVar10 + 0x24)) + -0xc,
                                  *(int *)(param_1 + 0xc4) + -8,0x18,*(int *)(param_1 + 0xc0) + 0x10
                                 );
              func_0x000100355d38(param_2,uVar13,uStack_110,uStack_108,uVar5);
              uVar11 = *puRam00000001038d5350;
              uStack_100 = 0;
              uStack_f8 = 0;
              func_0x00010034ede4(&uStack_100,0x38,0x65,0xf,0xf);
              uVar12 = uStack_f8;
              uVar13 = uStack_100;
              lVar10 = *(long *)(param_1 + 0x78);
              uVar9 = _UNK_10369ede8;
              if ((lVar10 != 0) && (uVar9 = _UNK_10369edf0, lVar10 != -0x1c)) {
                iVar15 = *(int *)(lVar10 + 0x10);
                iVar14 = *(int *)(param_1 + 0xc0);
                iVar1 = *(int *)(param_1 + 0xc4);
                iVar16 = *(int *)(lVar10 + 0x24);
                iVar2 = *(int *)(lVar10 + 0x1c);
                uVar7 = func_0x000100331988();
                StardewValley_StardewValley_Menus_IClickableMenu_drawTextureBox_060061a8
                          (0x40800000,0xbf800000,param_2,uVar11,uVar13,uVar12,
                           iVar2 + (int)(((float)iVar15 / 100.0) * (float)iVar16) + -0x12,
                           iVar1 + -0xc,0x24,iVar14 + 0x18,uVar7,0);
                plVar8 = *(long **)(param_1 + 0x80);
                if ((plVar8 != (long *)0x0) &&
                   (cVar4 = (**(code **)(*plVar8 + 0x58))(plVar8,*(undefined8 *)(param_1 + 0x78)),
                   cVar4 != '\0')) {
                  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                    func_0x0001003319b0();
                    lVar10 = *(long *)(param_1 + 0x78);
                  }
                  else {
                    lVar10 = *(long *)(param_1 + 0x78);
                  }
                  uVar9 = _UNK_10369ee80;
                  if ((lVar10 == 0) || (uVar9 = _UNK_10369ee88, lVar10 == -0x1c))
                  goto LAB_101e06168;
                  iVar14 = *(int *)(param_1 + 0xc0) + 0x10;
                  uVar13 = *puRam00000001038d77a8;
                  uStack_f0 = 0;
                  uStack_e8 = 0;
                  func_0x00010034ede4(&uStack_f0,
                                      *(int *)(lVar10 + 0x1c) +
                                      (int)(((float)*(int *)(lVar10 + 0x10) / 100.0) *
                                           (float)*(int *)(lVar10 + 0x24)) + -0x20,
                                      *(int *)(param_1 + 0xc4) + -0x68,iVar14,iVar14);
                  func_0x000100355d38(param_2,uVar13,uStack_f0,uStack_e8,uVar5);
                  uVar11 = *puRam00000001038d5350;
                  uStack_e0 = 0;
                  uStack_d8 = 0;
                  func_0x00010034ede4(&uStack_e0,0x38,0x65,0xf,0xf);
                  uVar12 = uStack_d8;
                  uVar13 = uStack_e0;
                  lVar10 = *(long *)(param_1 + 0x78);
                  uVar9 = _UNK_10369ee90;
                  if ((lVar10 == 0) || (uVar9 = _UNK_10369ee98, lVar10 == -0x1c))
                  goto LAB_101e06168;
                  iVar15 = *(int *)(lVar10 + 0x10);
                  iVar1 = *(int *)(param_1 + 0xc4);
                  iVar14 = *(int *)(param_1 + 0xc0) + 0x18;
                  iVar16 = *(int *)(lVar10 + 0x24);
                  iVar2 = *(int *)(lVar10 + 0x1c);
                  uVar5 = func_0x000100331988();
                  StardewValley_StardewValley_Menus_IClickableMenu_drawTextureBox_060061a8
                            (0x40800000,0xbf800000,param_2,uVar11,uVar13,uVar12,
                             iVar2 + (int)(((float)iVar15 / 100.0) * (float)iVar16) + -0x24,
                             iVar1 + -0x6c,iVar14,iVar14,uVar5,0);
                }
                iVar14 = 0;
                do {
                  uVar9 = _UNK_10369edf8;
                  if ((*(long *)(param_1 + 0x68) == 0) ||
                     (uVar9 = _UNK_10369ee00, *(long *)(param_1 + 0x78) == 0)) goto LAB_101e06168;
                  uVar5 = SDV_StardewValley_Menus_MobileColorPicker_HsvToRgb_06005dfa
                                    (((double)*(int *)(*(long *)(param_1 + 0x68) + 0x10) / 100.0) *
                                     360.0,(double)*(int *)(*(long *)(param_1 + 0x78) + 0x10) /
                                           100.0,(double)iVar14 / 24.0);
                  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                    func_0x0001003319b0(lRam00000001038c4c88);
                    lVar10 = *(long *)(param_1 + 0x70);
                  }
                  else {
                    lVar10 = *(long *)(param_1 + 0x70);
                  }
                  uVar9 = _UNK_10369ee08;
                  if ((lVar10 == 0) ||
                     (uVar9 = _UNK_10369ee10, (int *)(lVar10 + 0x1c) == (int *)0x0))
                  goto LAB_101e06168;
                  uVar13 = *puRam00000001038d77a8;
                  uStack_d0 = 0;
                  uStack_c8 = 0;
                  func_0x00010034ede4(&uStack_d0,
                                      *(int *)(lVar10 + 0x1c) +
                                      (*(int *)(param_1 + 0xbc) / 0x18) * iVar14,
                                      *(int *)(param_1 + 0xc4) + 4,*(int *)(lVar10 + 0x24) / 0x18,
                                      *(int *)(param_1 + 0xc0) + -8);
                  func_0x000100355d38(param_2,uVar13,uStack_d0,uStack_c8,uVar5);
                  if (lRam0000000103976fb8 != 0) {
                    func_0x00010119b8f8();
                  }
                  iVar14 = iVar14 + 1;
                } while (iVar14 != 0x18);
                if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                  func_0x0001003319b0();
                }
                uVar11 = *puRam00000001038d5350;
                uStack_c0 = 0;
                uStack_b8 = 0;
                func_0x00010034ede4(&uStack_c0,0x38,0x65,0xf,0xf);
                uVar12 = uStack_b8;
                uVar13 = uStack_c0;
                lVar10 = *(long *)(param_1 + 0x70);
                uVar9 = _UNK_10369ee18;
                if ((lVar10 != 0) && (uVar9 = _UNK_10369ee20, (int *)(lVar10 + 0x1c) != (int *)0x0))
                {
                  iVar14 = *(int *)(lVar10 + 0x1c);
                  uVar5 = *(undefined4 *)(lVar10 + 0x20);
                  iVar1 = *(int *)(lVar10 + 0x24);
                  uVar7 = *(undefined4 *)(lVar10 + 0x28);
                  uVar6 = func_0x000100331988();
                  StardewValley_StardewValley_Menus_IClickableMenu_drawTextureBox_060061a8
                            (0x40800000,0xbf800000,param_2,uVar11,uVar13,uVar12,iVar14 + -0xc,uVar5,
                             iVar1 + 0x18,uVar7,uVar6,0);
                  uVar9 = _UNK_10369ee28;
                  if ((*(long *)(param_1 + 0x68) != 0) &&
                     ((uVar9 = _UNK_10369ee30, *(long *)(param_1 + 0x78) != 0 &&
                      (uVar9 = _UNK_10369ee38, *(long *)(param_1 + 0x70) != 0)))) {
                    uVar5 = SDV_StardewValley_Menus_MobileColorPicker_HsvToRgb_06005dfa
                                      ((double)(((float)*(int *)(*(long *)(param_1 + 0x68) + 0x10) /
                                                100.0) * 360.0),
                                       (double)((float)*(int *)(*(long *)(param_1 + 0x78) + 0x10) /
                                               100.0),
                                       (double)((float)*(int *)(*(long *)(param_1 + 0x70) + 0x10) /
                                               100.0));
                    lVar10 = *(long *)(param_1 + 0x70);
                    uVar9 = _UNK_10369ee40;
                    if ((lVar10 != 0) && (uVar9 = _UNK_10369ee48, lVar10 != -0x1c)) {
                      uVar13 = *puRam00000001038d77a8;
                      uStack_b0 = 0;
                      uStack_a8 = 0;
                      func_0x00010034ede4(&uStack_b0,
                                          *(int *)(lVar10 + 0x1c) +
                                          (int)(((float)*(int *)(lVar10 + 0x10) / 100.0) *
                                               (float)*(int *)(lVar10 + 0x24)) + -0xc,
                                          *(int *)(param_1 + 0xc4) + -8,0x18,
                                          *(int *)(param_1 + 0xc0) + 0x10);
                      func_0x000100355d38(param_2,uVar13,uStack_b0,uStack_a8,uVar5);
                      uVar11 = *puRam00000001038d5350;
                      uStack_a0 = 0;
                      uStack_98 = 0;
                      func_0x00010034ede4(&uStack_a0,0x38,0x65,0xf,0xf);
                      uVar12 = uStack_98;
                      uVar13 = uStack_a0;
                      lVar10 = *(long *)(param_1 + 0x70);
                      uVar9 = _UNK_10369ee50;
                      if ((lVar10 != 0) && (uVar9 = _UNK_10369ee58, lVar10 != -0x1c)) {
                        iVar15 = *(int *)(lVar10 + 0x10);
                        iVar14 = *(int *)(param_1 + 0xc0);
                        iVar1 = *(int *)(param_1 + 0xc4);
                        iVar16 = *(int *)(lVar10 + 0x24);
                        iVar2 = *(int *)(lVar10 + 0x1c);
                        uVar7 = func_0x000100331988();
                        StardewValley_StardewValley_Menus_IClickableMenu_drawTextureBox_060061a8
                                  (0x40800000,0xbf800000,param_2,uVar11,uVar13,uVar12,
                                   iVar2 + (int)(((float)iVar15 / 100.0) * (float)iVar16) + -0x12,
                                   iVar1 + -0xc,0x24,iVar14 + 0x18,uVar7,0);
                        plVar8 = *(long **)(param_1 + 0x80);
                        if ((plVar8 == (long *)0x0) ||
                           (cVar4 = (**(code **)(*plVar8 + 0x58))
                                              (plVar8,*(undefined8 *)(param_1 + 0x70)),
                           cVar4 == '\0')) {
                          return;
                        }
                        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                          func_0x0001003319b0();
                        }
                        lVar10 = *(long *)(param_1 + 0x70);
                        uVar9 = _UNK_10369ee60;
                        if ((lVar10 != 0) && (uVar9 = _UNK_10369ee68, lVar10 != -0x1c)) {
                          iVar14 = *(int *)(param_1 + 0xc0) + 0x10;
                          uVar13 = *puRam00000001038d77a8;
                          uStack_90 = 0;
                          uStack_88 = 0;
                          func_0x00010034ede4(&uStack_90,
                                              *(int *)(lVar10 + 0x1c) +
                                              (int)(((float)*(int *)(lVar10 + 0x10) / 100.0) *
                                                   (float)*(int *)(lVar10 + 0x24)) + -0x20,
                                              *(int *)(param_1 + 0xc4) + -0x68,iVar14,iVar14);
                          func_0x000100355d38(param_2,uVar13,uStack_90,uStack_88,uVar5);
                          uVar11 = *puRam00000001038d5350;
                          uStack_80 = 0;
                          uStack_78 = 0;
                          func_0x00010034ede4(&uStack_80,0x38,0x65,0xf,0xf);
                          uVar12 = uStack_78;
                          uVar13 = uStack_80;
                          lVar10 = *(long *)(param_1 + 0x70);
                          uVar9 = _UNK_10369ee70;
                          if ((lVar10 != 0) && (uVar9 = _UNK_10369ee78, lVar10 != -0x1c)) {
                            iVar15 = *(int *)(lVar10 + 0x10);
                            iVar1 = *(int *)(param_1 + 0xc4);
                            iVar14 = *(int *)(param_1 + 0xc0) + 0x18;
                            iVar16 = *(int *)(lVar10 + 0x24);
                            iVar2 = *(int *)(lVar10 + 0x1c);
                            uVar5 = func_0x000100331988();
                            StardewValley_StardewValley_Menus_IClickableMenu_drawTextureBox_060061a8
                                      (0x40800000,0xbf800000,param_2,uVar11,uVar13,uVar12,
                                       iVar2 + (int)(((float)iVar15 / 100.0) * (float)iVar16) +
                                       -0x24,iVar1 + -0x6c,iVar14,iVar14,uVar5,0);
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
LAB_101e06168:
  func_0x0001003316f4(0xee,uVar9);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101e06174);
  (*pcVar3)();
}

