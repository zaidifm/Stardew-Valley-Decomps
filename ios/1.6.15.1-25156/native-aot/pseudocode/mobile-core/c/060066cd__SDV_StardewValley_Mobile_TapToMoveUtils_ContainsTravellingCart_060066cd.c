/* 0x060066cd StardewValley.Mobile.TapToMoveUtils.ContainsTravellingCart @ 0x101fc8764 */

/* WARNING: Removing unreachable block (ram,0x000101fc88e4) */
/* WARNING: Removing unreachable block (ram,0x000101fc88c8) */
/* WARNING: Type propagation algorithm not settling */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1
SDV_StardewValley_Mobile_TapToMoveUtils_ContainsTravellingCart_060066cd
          (undefined4 param_1,undefined4 param_2)

{
  code *pcVar1;
  char cVar2;
  undefined8 *puVar3;
  undefined8 uVar4;
  int iVar5;
  undefined8 uStack_90;
  undefined8 uStack_88;
  undefined8 uStack_80;
  undefined8 uStack_78;
  undefined8 uStack_70;
  undefined8 uStack_68;
  undefined1 uStack_51;
  undefined8 uStack_50;
  undefined8 *puStack_48;
  
  cVar2 = cRam00000001039114dc;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1033257f0);
    cRam00000001039114dc = '\x01';
  }
  uStack_70 = 0;
  uStack_68 = 0;
  uStack_51 = 0;
  uStack_88 = 0;
  uStack_90 = 0;
  uStack_78 = 0;
  uStack_80 = 0;
  puVar3 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  if ((puVar3 == (undefined8 *)0x0) ||
     (lRam00000001038c6c70 != *(long *)(*(long *)(*(long *)*puVar3 + 0x10) + 0x10))) {
    return 0;
  }
  puVar3 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  uVar4 = _UNK_1036d7458;
  if (puVar3 != (undefined8 *)0x0) {
    if (lRam00000001038c6c70 != *(long *)(*(long *)(*(long *)*puVar3 + 0x10) + 0x10)) {
      func_0x0001003316f4(0xd3,_UNK_1036d7450);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc892c);
      (*pcVar1)();
    }
    if (puVar3[0x60] == 0) {
      return 0;
    }
    func_0x000100371dbc(&uStack_90);
    do {
      while( true ) {
        cVar2 = func_0x000100371dd0(&uStack_90);
        if (cVar2 == '\0') {
          iVar5 = 2;
          goto LAB_101fc88a8;
        }
        uStack_68 = ((undefined8 *)((ulong)&uStack_90 | 0xc))[1];
        uStack_70 = *(undefined8 *)((ulong)&uStack_90 | 0xc);
        cVar2 = func_0x000100356238(&uStack_70,param_1,param_2);
        if (lRam0000000103976fb8 != 0) break;
        if (cVar2 != '\0') goto LAB_101fc8890;
      }
      func_0x00010119b8f8();
    } while (cVar2 == '\0');
LAB_101fc8890:
    iVar5 = 1;
    uStack_51 = 1;
LAB_101fc88a8:
    uStack_50 = 0;
    puStack_48 = &uStack_90;
    if (puStack_48 != (undefined8 *)0x0) {
      if (iVar5 == 1) {
        return uStack_51;
      }
      if (iVar5 != 2) {
        func_0x000100331c30();
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc8948);
        (*pcVar1)();
      }
      return 0;
    }
    puStack_48 = (undefined8 *)0x0;
    uVar4 = _UNK_1036d7460;
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc8940);
  (*pcVar1)();
}

