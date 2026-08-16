/* 0x060066e2 StardewValley.Mobile.TapToMoveUtils.NodeContainsFurniture @ 0x101fca9d8 */

/* WARNING: Removing unreachable block (ram,0x000101fcabd4) */
/* WARNING: Removing unreachable block (ram,0x000101fcabb4) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1 SDV_StardewValley_Mobile_TapToMoveUtils_NodeContainsFurniture_060066e2(long param_1)

{
  undefined8 uVar1;
  undefined8 uVar2;
  code *pcVar3;
  char cVar4;
  long lVar5;
  undefined8 uVar6;
  int iVar7;
  undefined8 *puVar8;
  undefined8 uStack_c8;
  undefined8 uStack_c0;
  long lStack_b8;
  undefined8 uStack_b0;
  undefined8 uStack_a8;
  undefined1 uStack_99;
  undefined8 uStack_98;
  undefined8 uStack_90;
  undefined8 uStack_88;
  undefined8 *puStack_78;
  undefined8 uStack_70;
  undefined8 uStack_68;
  undefined8 uStack_60;
  undefined8 uStack_58;
  
  cVar4 = cRam00000001039114f1;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_1033258b5);
    cRam00000001039114f1 = '\x01';
  }
  uStack_c8 = 0;
  uStack_c0 = 0;
  lStack_b8 = 0;
  uStack_b0 = 0;
  uStack_a8 = 0;
  uStack_99 = 0;
  if (param_1 == 0) {
    return 0;
  }
  uStack_60 = 0;
  uStack_58 = 0;
  func_0x00010034ede4(&uStack_60,*(int *)(param_1 + 0x34) << 6,*(int *)(param_1 + 0x38) << 6,0x40,
                      0x40);
  uVar2 = uStack_58;
  uVar1 = uStack_60;
  lVar5 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  uVar6 = _UNK_1036d7868;
  if (*(long *)(lVar5 + 0x248) != 0) {
    func_0x000100343278(&uStack_c8);
LAB_101fcaa70:
    do {
      cVar4 = func_0x0001003598d4(&uStack_c8);
      if (cVar4 == '\0') {
        iVar7 = 2;
        goto LAB_101fcab94;
      }
      if ((lStack_b8 == 0) || (*(long *)(lStack_b8 + 0x98) == 0)) {
LAB_101fcab18:
        func_0x0001003316f4(0xee,_UNK_1036d7870);
                    /* WARNING: Does not return */
        pcVar3 = (code *)SoftwareBreakpoint(1,0x101fcab2c);
        (*pcVar3)();
      }
      if (*(char *)(lStack_b8 + 0x1e0) == '\0') {
        lVar5 = *(long *)(lStack_b8 + 0x150);
        if (lVar5 == 0) goto LAB_101fcab18;
        puVar8 = &uStack_70;
        uStack_68 = *(undefined8 *)(lVar5 + 0x70);
        uStack_70 = *(undefined8 *)(lVar5 + 0x68);
      }
      else {
        if (*(char *)(lRam00000001038c7da0 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        puVar8 = &uStack_90;
        uStack_88 = puRam00000001038d5b38[1];
        uStack_90 = *puRam00000001038d5b38;
      }
      uStack_a8 = puVar8[1];
      uStack_b0 = *puVar8;
      cVar4 = func_0x00010035a4b4(&uStack_b0,uVar1,uVar2);
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
        if (cVar4 != '\0') break;
        goto LAB_101fcaa70;
      }
    } while (cVar4 == '\0');
    iVar7 = 1;
    uStack_99 = 1;
LAB_101fcab94:
    uStack_98 = 0;
    puStack_78 = &uStack_c8;
    if (puStack_78 != (undefined8 *)0x0) {
      if (iVar7 == 1) {
        return uStack_99;
      }
      if (iVar7 == 2) {
        return 0;
      }
      func_0x000100331c30();
                    /* WARNING: Does not return */
      pcVar3 = (code *)SoftwareBreakpoint(1,0x101fcac04);
      (*pcVar3)();
    }
    puStack_78 = (undefined8 *)0x0;
    uVar6 = _UNK_1036d7878;
  }
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fcab90);
  (*pcVar3)();
}

