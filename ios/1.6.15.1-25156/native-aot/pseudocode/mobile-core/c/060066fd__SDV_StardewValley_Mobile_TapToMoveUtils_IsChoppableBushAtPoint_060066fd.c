/* 0x060066fd StardewValley.Mobile.TapToMoveUtils.IsChoppableBushAtPoint @ 0x101fcd240 */

/* WARNING: Removing unreachable block (ram,0x000101fcd400) */
/* WARNING: Removing unreachable block (ram,0x000101fcd3e4) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1
SDV_StardewValley_Mobile_TapToMoveUtils_IsChoppableBushAtPoint_060066fd
          (undefined4 param_1,undefined4 param_2)

{
  long *plVar1;
  code *pcVar2;
  char cVar3;
  long lVar4;
  undefined8 uVar5;
  int iVar6;
  undefined1 auVar7 [16];
  undefined8 uStack_88;
  undefined8 uStack_80;
  long *plStack_78;
  undefined1 auStack_70 [16];
  undefined1 uStack_51;
  undefined8 uStack_50;
  undefined8 *puStack_48;
  
  cVar3 = cRam000000010391150c;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103325a60);
    cRam000000010391150c = '\x01';
  }
  uStack_88 = 0;
  uStack_80 = 0;
  plStack_78 = (long *)0x0;
  auStack_70._0_8_ = 0;
  auStack_70._8_8_ = 0;
  uStack_51 = 0;
  lVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  uVar5 = _UNK_1036d7bf8;
  if (*(long *)(lVar4 + 0x108) != 0) {
    func_0x00010034328c(&uStack_88);
    while( true ) {
      cVar3 = func_0x00010035f784(&uStack_88);
      plVar1 = plStack_78;
      if (cVar3 == '\0') break;
      if ((plStack_78 != (long *)0x0) &&
         (lRam00000001038c78e0 == *(long *)(*(long *)(*(long *)*plStack_78 + 0x10) + 0x18))) {
        auVar7 = (*(code *)((long *)*plStack_78)[0x20])(plStack_78);
        auStack_70 = auVar7;
        cVar3 = func_0x000100356238(auStack_70,param_1,param_2);
        if (cVar3 != '\0') {
          if (lRam00000001038c78e0 != *(long *)(*(long *)(*(long *)*plVar1 + 0x10) + 0x18)) {
            func_0x0001003316f4(0xd3,_UNK_1036d7c08);
                    /* WARNING: Does not return */
            pcVar2 = (code *)SoftwareBreakpoint(1,0x101fcd360);
            (*pcVar2)();
          }
          uStack_51 = func_0x000101a7ce58(plVar1);
          iVar6 = 1;
          goto LAB_101fcd3c4;
        }
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
    }
    iVar6 = 2;
LAB_101fcd3c4:
    uStack_50 = 0;
    puStack_48 = &uStack_88;
    if (puStack_48 != (undefined8 *)0x0) {
      if (iVar6 != 1) {
        if (iVar6 != 2) {
          func_0x000100331c30();
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101fcd430);
          (*pcVar2)();
        }
        uStack_51 = 0;
      }
      return uStack_51;
    }
    puStack_48 = (undefined8 *)0x0;
    uVar5 = _UNK_1036d7c00;
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fcd3c0);
  (*pcVar2)();
}

