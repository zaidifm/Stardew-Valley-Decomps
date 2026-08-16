/* 0x060066fc StardewValley.Mobile.TapToMoveUtils.IsBushAtPoint @ 0x101fcd084 */

/* WARNING: Removing unreachable block (ram,0x000101fcd1a8) */
/* WARNING: Removing unreachable block (ram,0x000101fcd18c) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1
SDV_StardewValley_Mobile_TapToMoveUtils_IsBushAtPoint_060066fc
          (undefined4 param_1,undefined4 param_2)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined8 uVar4;
  int iVar5;
  undefined1 auVar6 [16];
  undefined8 uStack_88;
  undefined8 uStack_80;
  long *plStack_78;
  undefined1 auStack_70 [16];
  undefined1 uStack_51;
  undefined8 uStack_50;
  undefined8 *puStack_48;
  
  cVar2 = cRam000000010391150b;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325a4c);
    cRam000000010391150b = '\x01';
  }
  uStack_88 = 0;
  uStack_80 = 0;
  plStack_78 = (long *)0x0;
  auStack_70._0_8_ = 0;
  auStack_70._8_8_ = 0;
  uStack_51 = 0;
  lVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  uVar4 = _UNK_1036d7be0;
  if (*(long *)(lVar3 + 0x108) != 0) {
    func_0x00010034328c(&uStack_88);
    while( true ) {
      cVar2 = func_0x00010035f784(&uStack_88);
      if (cVar2 == '\0') break;
      if ((plStack_78 != (long *)0x0) &&
         (lRam00000001038c78e0 == *(long *)(*(long *)(*(long *)*plStack_78 + 0x10) + 0x18))) {
        auVar6 = (*(code *)((long *)*plStack_78)[0x20])();
        auStack_70 = auVar6;
        cVar2 = func_0x000100356238(auStack_70,param_1,param_2);
        if (cVar2 != '\0') {
          iVar5 = 1;
          uStack_51 = 1;
          goto LAB_101fcd16c;
        }
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
    }
    iVar5 = 2;
LAB_101fcd16c:
    uStack_50 = 0;
    puStack_48 = &uStack_88;
    if (puStack_48 != (undefined8 *)0x0) {
      if (iVar5 != 1) {
        if (iVar5 != 2) {
          func_0x000100331c30();
                    /* WARNING: Does not return */
          pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcd234);
          (*pcVar1)();
        }
        uStack_51 = 0;
      }
      return uStack_51;
    }
    puStack_48 = (undefined8 *)0x0;
    uVar4 = _UNK_1036d7be8;
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcd22c);
  (*pcVar1)();
}

