/* 0x06005dec StardewValley.Menus.MobileColorPicker..ctor @ 0x101e045b8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileColorPicker__ctor_06005dec
               (long param_1,undefined8 param_2,undefined8 param_3,long param_4)

{
  int iVar1;
  undefined4 uVar2;
  int iVar3;
  int iVar4;
  char cVar5;
  code *pcVar6;
  long lVar7;
  undefined8 uVar8;
  int iVar9;
  long *plVar10;
  long lVar11;
  int iVar12;
  int iVar13;
  int iVar14;
  undefined8 uStack_70;
  undefined8 uStack_68;
  
  cVar5 = cRam0000000103910bfb;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar5 == '\0') {
    func_0x00010119b908(&UNK_103316bf0);
    cRam0000000103910bfb = '\x01';
  }
  uVar8 = _UNK_10369eb98;
  if (param_1 != 0) {
    iVar14 = (int)param_4;
    iVar12 = (int)((ulong)param_4 >> 0x20);
    iVar3 = iVar12 + 3;
    if (-1 < param_4) {
      iVar3 = iVar12;
    }
    iVar4 = iVar14 / 0x11;
    DataMemoryBarrier(2,3);
    iVar13 = (int)param_3;
    *(undefined8 *)(param_1 + 0x20) = uRam00000001038d6940;
    lVar11 = lRam00000001038c4be0;
    iVar1 = iVar12;
    if (-1 >= param_4) {
      iVar1 = iVar12 + 1;
    }
    iVar9 = (int)((ulong)param_3 >> 0x20);
    *(undefined1 *)(((ulong)(param_1 + 0x20) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    *(long *)(param_1 + 0x9c) = param_4;
    *(undefined8 *)(param_1 + 0x94) = param_3;
    *(int *)(param_1 + 0xc0) = iVar1 >> 1;
    *(int *)(param_1 + 0xc4) = iVar9 + (iVar3 >> 2);
    *(int *)(param_1 + 0xbc) = ((iVar14 + iVar4 * -5) / 0x48) * 0x18;
    uStack_70 = 0;
    uStack_68 = 0;
    func_0x00010034ede4(&uStack_70,iVar13 + -0x10,iVar9 + -0xc,iVar14 + 0x20,iVar12 + 0x18);
    *(undefined8 *)(param_1 + 0xac) = uStack_68;
    *(undefined8 *)(param_1 + 0xa4) = uStack_70;
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x88) = param_2;
    *(undefined1 *)(((ulong)(param_1 + 0x88) >> 9 & 0x7fffff) + lVar11) = 1;
    uVar2 = *(undefined4 *)(param_1 + 0xc4);
    lVar7 = func_0x000100331820(uRam0000000103900280,0x3c);
    StardewValley_StardewValley_Menus_SliderBar__ctor_060064cb(lVar7,iVar4 + iVar13,uVar2,0x32);
    DataMemoryBarrier(2,3);
    plVar10 = (long *)(param_1 + 0x68);
    *plVar10 = lVar7;
    *(undefined1 *)(((ulong)plVar10 >> 9 & 0x7fffff) + lVar11) = 1;
    lVar7 = *plVar10;
    uVar8 = _UNK_10369eba0;
    if ((lVar7 != 0) && (uVar8 = _UNK_10369eba8, lVar7 != -0x1c)) {
      *(undefined4 *)(lVar7 + 0x24) = *(undefined4 *)(param_1 + 0xbc);
      lVar7 = *(long *)(param_1 + 0x68);
      uVar8 = _UNK_10369ebb0;
      if ((lVar7 != 0) && (uVar8 = _UNK_10369ebb8, lVar7 != -0x1c)) {
        *(undefined4 *)(lVar7 + 0x28) = *(undefined4 *)(param_1 + 0xc0);
        uVar8 = _UNK_10369ebc0;
        if (*(long *)(param_1 + 0x68) != 0) {
          *(undefined4 *)(*(long *)(param_1 + 0x68) + 0x14) = 0x10;
          uVar8 = _UNK_10369ebc8;
          if ((*(long *)(param_1 + 0x68) != 0) &&
             (*(undefined4 *)(*(long *)(param_1 + 0x68) + 0x18) = 0xc, uVar8 = _UNK_10369ebd0,
             *(long *)(param_1 + 0x68) != 0)) {
            StardewValley_StardewValley_Menus_SliderBar_updateExpandedBounds_060064cc();
            iVar3 = *(int *)(param_1 + 0xbc);
            uVar2 = *(undefined4 *)(param_1 + 0xc4);
            lVar7 = func_0x000100331820(uRam0000000103900280,0x3c);
            StardewValley_StardewValley_Menus_SliderBar__ctor_060064cb
                      (lVar7,iVar13 + iVar4 * 2 + iVar3,uVar2,0x32);
            DataMemoryBarrier(2,3);
            plVar10 = (long *)(param_1 + 0x78);
            *plVar10 = lVar7;
            *(undefined1 *)(((ulong)plVar10 >> 9 & 0x7fffff) + lVar11) = 1;
            lVar7 = *plVar10;
            uVar8 = _UNK_10369ebd8;
            if ((lVar7 != 0) && (uVar8 = _UNK_10369ebe0, lVar7 != -0x1c)) {
              *(undefined4 *)(lVar7 + 0x24) = *(undefined4 *)(param_1 + 0xbc);
              lVar7 = *(long *)(param_1 + 0x78);
              uVar8 = _UNK_10369ebe8;
              if ((lVar7 != 0) && (uVar8 = _UNK_10369ebf0, lVar7 != -0x1c)) {
                *(undefined4 *)(lVar7 + 0x28) = *(undefined4 *)(param_1 + 0xc0);
                uVar8 = _UNK_10369ebf8;
                if (*(long *)(param_1 + 0x78) != 0) {
                  *(undefined4 *)(*(long *)(param_1 + 0x78) + 0x14) = 0x10;
                  uVar8 = _UNK_10369ec00;
                  if ((*(long *)(param_1 + 0x78) != 0) &&
                     (*(undefined4 *)(*(long *)(param_1 + 0x78) + 0x18) = 0xc,
                     uVar8 = _UNK_10369ec08, *(long *)(param_1 + 0x78) != 0)) {
                    StardewValley_StardewValley_Menus_SliderBar_updateExpandedBounds_060064cc();
                    iVar3 = *(int *)(param_1 + 0xbc);
                    uVar2 = *(undefined4 *)(param_1 + 0xc4);
                    lVar7 = func_0x000100331820(uRam0000000103900280,0x3c);
                    StardewValley_StardewValley_Menus_SliderBar__ctor_060064cb
                              (lVar7,iVar4 * 3 + iVar13 + iVar3 * 2,uVar2,0x32);
                    DataMemoryBarrier(2,3);
                    plVar10 = (long *)(param_1 + 0x70);
                    *plVar10 = lVar7;
                    *(undefined1 *)(((ulong)plVar10 >> 9 & 0x7fffff) + lVar11) = 1;
                    lVar11 = *plVar10;
                    uVar8 = _UNK_10369ec10;
                    if ((lVar11 != 0) && (uVar8 = _UNK_10369ec18, lVar11 != -0x1c)) {
                      *(undefined4 *)(lVar11 + 0x24) = *(undefined4 *)(param_1 + 0xbc);
                      lVar11 = *(long *)(param_1 + 0x70);
                      uVar8 = _UNK_10369ec20;
                      if ((lVar11 != 0) && (uVar8 = _UNK_10369ec28, lVar11 != -0x1c)) {
                        *(undefined4 *)(lVar11 + 0x28) = *(undefined4 *)(param_1 + 0xc0);
                        uVar8 = _UNK_10369ec30;
                        if (*(long *)(param_1 + 0x70) != 0) {
                          *(undefined4 *)(*(long *)(param_1 + 0x70) + 0x14) = 0x10;
                          uVar8 = _UNK_10369ec38;
                          if ((*(long *)(param_1 + 0x70) != 0) &&
                             (*(undefined4 *)(*(long *)(param_1 + 0x70) + 0x18) = 0xc,
                             uVar8 = _UNK_10369ec40, *(long *)(param_1 + 0x70) != 0)) {
                            StardewValley_StardewValley_Menus_SliderBar_updateExpandedBounds_060064cc
                                      ();
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
  func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
  pcVar6 = (code *)SoftwareBreakpoint(1,0x101e04a0c);
  (*pcVar6)();
}

