/* 0x060066e4 StardewValley.Mobile.TapToMoveUtils.GetFurnitureClickedOn @ 0x101fcad68 */

/* WARNING: Removing unreachable block (ram,0x000101fcb0e0) */
/* WARNING: Removing unreachable block (ram,0x000101fcb150) */
/* WARNING: Removing unreachable block (ram,0x000101fcb0f8) */
/* WARNING: Removing unreachable block (ram,0x000101fcb138) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* WARNING: Restarted to delay deadcode elimination for space: stack */

long SDV_StardewValley_Mobile_TapToMoveUtils_GetFurnitureClickedOn_060066e4
               (undefined4 param_1,undefined4 param_2)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined8 uVar4;
  int iVar5;
  long lVar6;
  undefined8 *puVar7;
  undefined8 uStack_140;
  undefined8 uStack_138;
  long lStack_130;
  undefined8 uStack_120;
  undefined8 uStack_118;
  long lStack_110;
  long lStack_108;
  undefined8 uStack_100;
  undefined8 uStack_f8;
  undefined8 uStack_f0;
  undefined8 uStack_e8;
  undefined8 *puStack_d8;
  undefined8 uStack_d0;
  undefined8 uStack_c8;
  long lStack_c0;
  long lStack_b8;
  undefined8 *puStack_b0;
  int iStack_a4;
  long lStack_a0;
  long lStack_98;
  undefined8 uStack_90;
  undefined8 uStack_88;
  long lStack_80;
  long lStack_78;
  undefined8 *puStack_70;
  long lStack_68;
  undefined8 uStack_60;
  undefined8 uStack_58;
  
  cVar2 = cRam00000001039114f3;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1033258d0);
    cRam00000001039114f3 = '\x01';
  }
  uStack_140 = 0;
  uStack_138 = 0;
  lStack_130 = 0;
  uStack_120 = 0;
  uStack_118 = 0;
  lStack_110 = 0;
  lStack_108 = 0;
  lVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  uVar4 = _UNK_1036d78b8;
  if (*(long *)(lVar3 + 0x248) != 0) {
    func_0x000100343278(&uStack_140);
    while (cVar2 = func_0x0001003598d4(&uStack_140), lVar3 = lStack_130, cVar2 != '\0') {
      if ((lStack_130 == 0) || (*(long *)(lStack_130 + 0x208) == 0)) {
LAB_101fcae8c:
        func_0x0001003316f4(0xee,_UNK_1036d78e0);
        goto LAB_101fcb08c;
      }
      if (*(int *)(*(long *)(lStack_130 + 0x208) + 0x68) != 0xc) {
        if (*(long *)(lStack_130 + 0x98) == 0) goto LAB_101fcae8c;
        if (*(char *)(lStack_130 + 0x1e0) == '\0') {
          lVar6 = *(long *)(lStack_130 + 0x150);
          if (lVar6 == 0) goto LAB_101fcae8c;
          puVar7 = &uStack_60;
          uStack_58 = *(undefined8 *)(lVar6 + 0x70);
          uStack_60 = *(undefined8 *)(lVar6 + 0x68);
        }
        else {
          if (*(char *)(lRam00000001038c7da0 + 0x35) == '\0') {
            func_0x0001003319b0();
          }
          puVar7 = &uStack_f0;
          uStack_e8 = puRam00000001038d5b38[1];
          uStack_f0 = *puRam00000001038d5b38;
        }
        uStack_118 = puVar7[1];
        uStack_120 = *puVar7;
        cVar2 = func_0x000100356238(&uStack_120,param_1,param_2);
        if (cVar2 != '\0') {
          iVar5 = 1;
          lStack_110 = lVar3;
          goto LAB_101fcb118;
        }
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
    }
    iVar5 = 2;
LAB_101fcb118:
    uStack_100 = 0;
    puStack_d8 = &uStack_140;
    uVar4 = _UNK_1036d78d8;
    if (puStack_d8 != (undefined8 *)0x0) {
      if (iVar5 == 1) {
        return lStack_110;
      }
      if (iVar5 != 2) {
LAB_101fcb16c:
        func_0x000100331c30();
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcb174);
        (*pcVar1)();
      }
      uStack_100 = 0;
      lVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
      uVar4 = _UNK_1036d78c0;
      if (*(long *)(lVar3 + 0x248) != 0) {
        func_0x000100343278(&uStack_d0);
        uStack_138 = uStack_c8;
        uStack_140 = uStack_d0;
        lStack_130 = lStack_c0;
        while (cVar2 = func_0x0001003598d4(&uStack_140), cVar2 != '\0') {
          puStack_b0 = &uStack_140;
          if ((((&uStack_140 == (undefined8 *)0x0) ||
               (lStack_108 = lStack_130, lStack_b8 = lStack_108, lStack_130 == 0)) ||
              (lStack_a0 = *(long *)(lStack_130 + 0x208), lStack_a0 == 0)) || (lStack_a0 == 0)) {
LAB_101fcb07c:
            func_0x0001003316f4(0xee,_UNK_1036d78d0);
LAB_101fcb08c:
                    /* WARNING: Does not return */
            pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcb090);
            (*pcVar1)();
          }
          iStack_a4 = *(int *)(lStack_a0 + 0x68);
          if (iStack_a4 == 0xc) {
            if (((lStack_130 == 0) || (lStack_98 = *(long *)(lStack_130 + 0x98), lStack_98 == 0)) ||
               ((lStack_98 == 0 || ((lStack_80 = lStack_108, lStack_130 == 0 || (lStack_130 == 0))))
               )) goto LAB_101fcb07c;
            if (*(char *)(lStack_130 + 0x1e0) == '\0') {
              if (((lStack_130 == 0) || (lStack_78 = *(long *)(lStack_130 + 0x150), lStack_78 == 0))
                 || (lStack_78 == 0)) goto LAB_101fcb07c;
              puVar7 = (undefined8 *)(lStack_78 + 0x68);
            }
            else {
              lStack_68 = lRam00000001038c7da0;
              puVar7 = puRam00000001038d5b38;
              if (*(char *)(lRam00000001038c7da0 + 0x35) == '\0') {
                func_0x0001003319b0(lRam00000001038c7da0);
                puVar7 = puRam00000001038d5b38;
              }
            }
            uStack_118 = puVar7[1];
            uStack_120 = *puVar7;
            uStack_90 = uStack_120;
            uStack_88 = uStack_118;
            cVar2 = func_0x000100356238(&uStack_120,param_1,param_2);
            if (cVar2 != '\0') {
              iVar5 = 1;
              lStack_110 = lStack_108;
              goto LAB_101fcb0c0;
            }
          }
          if (lRam0000000103976fb8 != 0) {
            func_0x00010119b8f8();
          }
        }
        iVar5 = 2;
LAB_101fcb0c0:
        uStack_f8 = 0;
        puStack_70 = &uStack_140;
        if (puStack_70 != (undefined8 *)0x0) {
          if (iVar5 == 1) {
            return lStack_110;
          }
          if (iVar5 == 2) {
            return 0;
          }
          goto LAB_101fcb16c;
        }
        puStack_70 = (undefined8 *)0x0;
        uVar4 = _UNK_1036d78c8;
      }
    }
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcaf04);
  (*pcVar1)();
}

