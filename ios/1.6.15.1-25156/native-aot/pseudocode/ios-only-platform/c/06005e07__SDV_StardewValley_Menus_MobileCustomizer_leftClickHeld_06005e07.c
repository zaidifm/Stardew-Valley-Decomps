/* 0x06005e07 StardewValley.Menus.MobileCustomizer.leftClickHeld @ 0x101e0d2a8 */

/* WARNING: Type propagation algorithm not settling */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer_leftClickHeld_06005e07
               (long param_1,undefined4 param_2,undefined4 param_3)

{
  int *piVar1;
  uint uVar2;
  int iVar3;
  uint uVar4;
  uint uVar5;
  undefined8 uVar6;
  code *pcVar7;
  char cVar8;
  int iVar9;
  long *plVar10;
  long lVar11;
  long lVar12;
  undefined1 uVar13;
  long lVar14;
  long lVar15;
  undefined8 uVar16;
  uint uVar17;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  cVar8 = SDV_StardewValley_Menus_MobileCustomizer_get_InTutorial_06005dfc();
  if (cVar8 != '\0') {
    return;
  }
  if (*(char *)(param_1 + 0x332) == '\0') {
    return;
  }
  plVar10 = *(long **)(param_1 + 0x1a0);
  if (plVar10 != (long *)0x0) {
    (**(code **)(*plVar10 + 0xf0))(plVar10,param_2,param_3);
  }
  SDV_StardewValley_Menus_MobileCustomizer_resetAllButtons_06005e06(param_1);
  uVar16 = _UNK_10369ff60;
  if (*(long *)(param_1 + 0x88) == 0) goto LAB_101e0dc7c;
  cVar8 = func_0x000100356238(*(long *)(param_1 + 0x88) + 0x38,param_2,param_3);
  if (cVar8 == '\0') {
    uVar16 = _UNK_10369ff68;
    if (*(long *)(param_1 + 0x90) == 0) goto LAB_101e0dc7c;
    cVar8 = func_0x000100356238(*(long *)(param_1 + 0x90) + 0x38,param_2,param_3);
    if (cVar8 == '\0') {
      uVar16 = _UNK_10369ff70;
      if (*(long *)(param_1 + 0xc0) == 0) goto LAB_101e0dc7c;
      cVar8 = func_0x000100356238(*(long *)(param_1 + 0xc0) + 0x38,param_2,param_3);
      if (cVar8 != '\0') {
        *(undefined1 *)(*(long *)(param_1 + 0xc0) + 0xad) = 0;
        uVar16 = _UNK_1036a00f8;
        if (((*(long *)(param_1 + 0xc0) == 0) || (uVar16 = _UNK_1036a0100, param_1 == -600)) ||
           (piVar1 = (int *)(*(long *)(param_1 + 0xc0) + 0x38), uVar16 = _UNK_1036a0108,
           piVar1 == (int *)0x0)) goto LAB_101e0dc7c;
        *piVar1 = *(int *)(param_1 + 600) + -4;
        lVar15 = *(long *)(param_1 + 0xc0);
        uVar16 = _UNK_1036a0110;
        if ((lVar15 == 0) || (uVar16 = _UNK_1036a0118, lVar15 == -0x38)) goto LAB_101e0dc7c;
        *(int *)(lVar15 + 0x3c) = *(int *)(param_1 + 0x25c) + 4;
      }
      if ((6 < *(uint *)(param_1 + 0x1ec)) ||
         ((1 << (ulong)(*(uint *)(param_1 + 0x1ec) & 0x1f) & 100U) == 0)) {
        uVar16 = _UNK_1036a00b8;
        if (*(long *)(param_1 + 0xd0) == 0) goto LAB_101e0dc7c;
        cVar8 = func_0x000100356238(*(long *)(param_1 + 0xd0) + 0x38,param_2,param_3);
        if (cVar8 != '\0') {
          uVar16 = _UNK_1036a00c0;
          if (*(long *)(param_1 + 0xd0) == 0) goto LAB_101e0dc7c;
          *(undefined1 *)(*(long *)(param_1 + 0xd0) + 0xad) = 1;
          uVar16 = _UNK_1036a00c8;
          if (((*(long *)(param_1 + 0xd0) == 0) || (uVar16 = _UNK_1036a00d0, param_1 == -0x274)) ||
             (piVar1 = (int *)(*(long *)(param_1 + 0xd0) + 0x38), uVar16 = _UNK_1036a00d8,
             piVar1 == (int *)0x0)) goto LAB_101e0dc7c;
          *piVar1 = (int)(*(float *)(param_1 + 0x274) + -4.0);
          lVar15 = *(long *)(param_1 + 0xd0);
          uVar16 = _UNK_1036a00e0;
          if ((lVar15 == 0) || (uVar16 = _UNK_1036a00e8, lVar15 == -0x38)) goto LAB_101e0dc7c;
          *(int *)(lVar15 + 0x3c) = (int)(*(float *)(param_1 + 0x278) + 4.0);
        }
      }
      if (((*(long **)(param_1 + 0x170) != (long *)0x0) && (*(long *)(param_1 + 0x168) != 0)) &&
         (cVar8 = (**(code **)(**(long **)(param_1 + 0x170) + 0x58))(), cVar8 != '\0')) {
        lVar15 = func_0x000100377a28(param_1);
        uVar16 = _UNK_1036a0060;
        if ((*(long *)(param_1 + 0x168) == 0) ||
           (iVar9 = StardewValley_StardewValley_Menus_SliderBar_click_060064cd
                              (*(long *)(param_1 + 0x168),param_2,param_3,0,1),
           uVar16 = _UNK_1036a0068, lVar15 == 0)) goto LAB_101e0dc7c;
        uVar17 = (uint)(((float)iVar9 / 100.0) * (float)(int)(*(uint *)(lVar15 + 0x18) - 1));
        if (*(uint *)(lVar15 + 0x18) <= uVar17) {
LAB_101e0da54:
          func_0x000100331b90();
                    /* WARNING: Does not return */
          pcVar7 = (code *)SoftwareBreakpoint(1,0x101e0da5c);
          (*pcVar7)();
        }
        uVar16 = _UNK_1036a0078;
        if (*(uint *)(*(long *)(lVar15 + 0x10) + 0x18) <= uVar17) goto LAB_101e0dc50;
        lVar14 = (-(ulong)(uVar17 >> 0x1f) & 0xfffffff000000000 | (ulong)uVar17 << 4) + 0x20;
        uVar16 = *(undefined8 *)(lVar14 + *(long *)(lVar15 + 0x10) + 8);
        lVar11 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        cVar8 = func_0x00010035011c(uVar16,*(undefined8 *)(lVar11 + 0x328));
        if (cVar8 != '\0') {
          *(undefined1 *)(param_1 + 0x331) = 1;
          lVar12 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          lVar11 = lRam00000001038c4be0;
          if (*(uint *)(lVar15 + 0x18) <= uVar17) goto LAB_101e0da54;
          uVar16 = _UNK_1036a0090;
          if (*(uint *)(*(long *)(lVar15 + 0x10) + 0x18) <= uVar17) goto LAB_101e0dc50;
          uVar16 = _UNK_1036a0098;
          if (lVar12 == 0) goto LAB_101e0dc7c;
          DataMemoryBarrier(2,3);
          *(undefined8 *)(lVar12 + 0x328) = *(undefined8 *)(lVar14 + *(long *)(lVar15 + 0x10) + 8);
          *(undefined1 *)((lVar12 + 0x328U >> 9 & 0x7fffff) + lVar11) = 1;
          lVar12 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          if (*(uint *)(lVar15 + 0x18) <= uVar17) goto LAB_101e0da54;
          uVar16 = _UNK_1036a00a8;
          if (*(uint *)(*(long *)(lVar15 + 0x10) + 0x18) <= uVar17) goto LAB_101e0dc50;
          uVar16 = _UNK_1036a00b0;
          if (lVar12 == 0) goto LAB_101e0dc7c;
          DataMemoryBarrier(2,3);
          *(undefined8 *)(lVar12 + 800) = *(undefined8 *)(lVar14 + *(long *)(lVar15 + 0x10));
          *(undefined1 *)((lVar12 + 800U >> 9 & 0x7fffff) + lVar11) = 1;
        }
      }
      if (4 < *(int *)(param_1 + 500)) {
        plVar10 = *(long **)(param_1 + 0x128);
        if (plVar10 == (long *)0x0) {
          return;
        }
        cVar8 = (**(code **)(*plVar10 + 0x58))(plVar10,*(undefined8 *)(param_1 + 0x70));
        if (cVar8 == '\0') {
          cVar8 = (**(code **)(**(long **)(param_1 + 0x128) + 0x58))
                            (*(long **)(param_1 + 0x128),*(undefined8 *)(param_1 + 0x68));
          if (cVar8 == '\0') {
            cVar8 = (**(code **)(**(long **)(param_1 + 0x128) + 0x58))
                              (*(long **)(param_1 + 0x128),*(undefined8 *)(param_1 + 0x78));
            if (cVar8 == '\0') {
              return;
            }
            uVar16 = _UNK_10369ff90;
            if (*(long *)(param_1 + 0x78) != 0) {
              SDV_StardewValley_Menus_MobileColorPicker_click_06005def
                        (*(long *)(param_1 + 0x78),param_2,param_3,1);
              uVar16 = *(undefined8 *)(param_1 + 0x78);
              goto LAB_101e0d934;
            }
          }
          else {
            uVar16 = _UNK_10369ff98;
            if (*(long *)(param_1 + 0x68) != 0) {
              SDV_StardewValley_Menus_MobileColorPicker_click_06005def
                        (*(long *)(param_1 + 0x68),param_2,param_3,1);
              uVar16 = *(undefined8 *)(param_1 + 0x68);
LAB_101e0d934:
              lVar15 = lRam00000001038c4be0;
              DataMemoryBarrier(2,3);
              *(undefined8 *)(param_1 + 0x128) = uVar16;
              *(undefined1 *)((param_1 + 0x128U >> 9 & 0x7fffff) + lVar15) = 1;
              return;
            }
          }
        }
        else {
          uVar16 = _UNK_10369ffa0;
          if (*(long *)(param_1 + 0x70) != 0) {
            SDV_StardewValley_Menus_MobileColorPicker_click_06005def
                      (*(long *)(param_1 + 0x70),param_2,param_3,1);
            (**(code **)(*(long *)(param_1 + 0x148) + 0x18))();
            uVar16 = *(undefined8 *)(param_1 + 0x70);
            goto LAB_101e0d934;
          }
        }
        goto LAB_101e0dc7c;
      }
      plVar10 = *(long **)(param_1 + 0x170);
      if ((plVar10 == (long *)0x0) ||
         (cVar8 = (**(code **)(*plVar10 + 0x58))(plVar10,*(undefined8 *)(param_1 + 0x160)),
         cVar8 == '\0')) {
        uVar13 = 0;
      }
      else {
        uVar16 = _UNK_1036a0018;
        if (*(long *)(param_1 + 0x160) == 0) goto LAB_101e0dc7c;
        iVar9 = StardewValley_StardewValley_Menus_SliderBar_click_060064cd
                          (*(long *)(param_1 + 0x160),param_2,param_3,0,1);
        lVar15 = *(long *)(param_1 + 0x178);
        uVar16 = _UNK_1036a0020;
        if (lVar15 == 0) goto LAB_101e0dc7c;
        uVar17 = *(uint *)(param_1 + 500);
        uVar16 = _UNK_1036a0028;
        if (*(uint *)(lVar15 + 0x18) <= uVar17) {
LAB_101e0dc50:
          func_0x0001003316f4(0xcc,uVar16);
                    /* WARNING: Does not return */
          pcVar7 = (code *)SoftwareBreakpoint(1,0x101e0dc5c);
          (*pcVar7)();
        }
        lVar14 = (long)(int)uVar17 * 4 + 0x20;
        iVar3 = *(int *)(lVar14 + lVar15);
        uVar4 = iVar3 - 1;
        uVar2 = 0;
        if ((int)uVar4 < 0) {
          uVar2 = uVar4;
        }
        uVar4 = uVar4 & ((int)uVar4 >> 0x1f ^ 0xffffffffU);
        uVar5 = (int)(((float)iVar9 / 100.0) * (float)iVar3) - 1;
        if ((int)uVar5 <= (int)uVar2) {
          uVar5 = uVar2;
        }
        if ((int)uVar4 <= (int)uVar5) {
          uVar5 = uVar4;
        }
        uVar16 = _UNK_1036a0038;
        if (*(uint *)(*(long *)(param_1 + 0x180) + 0x18) <= uVar17) goto LAB_101e0dc50;
        iVar9 = uVar5 - *(int *)(lVar14 + *(long *)(param_1 + 0x180));
        if (iVar9 == 0) {
          uVar13 = 1;
        }
        else {
          SDV_StardewValley_Menus_MobileCustomizer_selectionClick_06005e11(param_1,iVar9);
          lVar15 = *(long *)(param_1 + 0x178);
          uVar16 = _UNK_1036a0040;
          if (lVar15 == 0) goto LAB_101e0dc7c;
          uVar17 = *(uint *)(param_1 + 500);
          uVar16 = _UNK_1036a0048;
          if (*(uint *)(lVar15 + 0x18) <= uVar17) goto LAB_101e0dc50;
          lVar14 = (long)(int)uVar17 * 4 + 0x20;
          uVar4 = *(int *)(lVar14 + lVar15) - 1;
          uVar2 = 0;
          if ((int)uVar4 < 0) {
            uVar2 = uVar4;
          }
          uVar4 = uVar4 & ((int)uVar4 >> 0x1f ^ 0xffffffffU);
          if ((int)uVar5 <= (int)uVar2) {
            uVar5 = uVar2;
          }
          if ((int)uVar4 <= (int)uVar5) {
            uVar5 = uVar4;
          }
          uVar16 = _UNK_1036a0058;
          if (*(uint *)(*(long *)(param_1 + 0x180) + 0x18) <= uVar17) goto LAB_101e0dc50;
          uVar13 = 1;
          *(uint *)(lVar14 + *(long *)(param_1 + 0x180)) = uVar5;
        }
      }
      *(undefined1 *)(param_1 + 0x2fc) = uVar13;
      uVar16 = _UNK_10369ff80;
      if (*(long *)(param_1 + 0x98) == 0) goto LAB_101e0dc7c;
      cVar8 = func_0x000100356238(*(long *)(param_1 + 0x98) + 0x38,param_2,param_3);
      if (cVar8 == '\0') {
        uVar16 = _UNK_10369ffb0;
        if (*(long *)(param_1 + 0xa0) == 0) goto LAB_101e0dc7c;
        cVar8 = func_0x000100356238(*(long *)(param_1 + 0xa0) + 0x38,param_2,param_3);
        if (cVar8 == '\0') {
          return;
        }
        *(undefined1 *)(*(long *)(param_1 + 0xa0) + 0xad) = 0;
        uVar16 = _UNK_10369ffc0;
        if (((*(long *)(param_1 + 0xa0) == 0) ||
            (lVar15 = param_1 + 0x2ec, uVar16 = _UNK_10369ffc8, lVar15 == 0)) ||
           (piVar1 = (int *)(*(long *)(param_1 + 0xa0) + 0x38), uVar16 = _UNK_10369ffd0,
           piVar1 == (int *)0x0)) goto LAB_101e0dc7c;
        *piVar1 = *(int *)(param_1 + 0x2ec) + -4;
        lVar14 = *(long *)(param_1 + 0xa0);
        uVar16 = _UNK_10369ffd8;
        uVar6 = _UNK_10369ffe0;
      }
      else {
        *(undefined1 *)(*(long *)(param_1 + 0x98) + 0xad) = 0;
        uVar16 = _UNK_10369fff0;
        if (((*(long *)(param_1 + 0x98) == 0) ||
            (lVar15 = param_1 + 0x2dc, uVar16 = _UNK_10369fff8, lVar15 == 0)) ||
           (piVar1 = (int *)(*(long *)(param_1 + 0x98) + 0x38), uVar16 = _UNK_1036a0000,
           piVar1 == (int *)0x0)) goto LAB_101e0dc7c;
        *piVar1 = *(int *)(param_1 + 0x2dc) + -4;
        lVar14 = *(long *)(param_1 + 0x98);
        uVar16 = _UNK_1036a0008;
        uVar6 = _UNK_1036a0010;
      }
    }
    else {
      *(undefined1 *)(*(long *)(param_1 + 0x90) + 0xad) = 0;
      uVar16 = _UNK_1036a0128;
      if (((*(long *)(param_1 + 0x90) == 0) ||
          (lVar15 = param_1 + 0x2cc, uVar16 = _UNK_1036a0130, lVar15 == 0)) ||
         (piVar1 = (int *)(*(long *)(param_1 + 0x90) + 0x38), uVar16 = _UNK_1036a0138,
         piVar1 == (int *)0x0)) goto LAB_101e0dc7c;
      *piVar1 = *(int *)(param_1 + 0x2cc) + -4;
      lVar14 = *(long *)(param_1 + 0x90);
      uVar16 = _UNK_1036a0140;
      uVar6 = _UNK_1036a0148;
    }
  }
  else {
    *(undefined1 *)(*(long *)(param_1 + 0x88) + 0xad) = 0;
    uVar16 = _UNK_1036a0158;
    if (((*(long *)(param_1 + 0x88) == 0) ||
        (lVar15 = param_1 + 700, uVar16 = _UNK_1036a0160, lVar15 == 0)) ||
       (piVar1 = (int *)(*(long *)(param_1 + 0x88) + 0x38), uVar16 = _UNK_1036a0168,
       piVar1 == (int *)0x0)) goto LAB_101e0dc7c;
    *piVar1 = *(int *)(param_1 + 700) + -4;
    lVar14 = *(long *)(param_1 + 0x88);
    uVar16 = _UNK_1036a0170;
    uVar6 = _UNK_1036a0178;
  }
  if ((lVar14 != 0) && (uVar16 = uVar6, lVar14 != -0x38)) {
    *(int *)(lVar14 + 0x3c) = *(int *)(lVar15 + 4) + 4;
    return;
  }
LAB_101e0dc7c:
  func_0x0001003316f4(0xee,uVar16);
                    /* WARNING: Does not return */
  pcVar7 = (code *)SoftwareBreakpoint(1,0x101e0dc88);
  (*pcVar7)();
}

