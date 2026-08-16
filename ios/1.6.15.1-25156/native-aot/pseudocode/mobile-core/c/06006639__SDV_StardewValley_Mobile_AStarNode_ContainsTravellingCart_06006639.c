/* 0x06006639 StardewValley.Mobile.AStarNode.ContainsTravellingCart @ 0x101fa8b20 */

/* WARNING: Removing unreachable block (ram,0x000101fa8c98) */
/* WARNING: Removing unreachable block (ram,0x000101fa8c7c) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

ulong SDV_StardewValley_Mobile_AStarNode_ContainsTravellingCart_06006639(long param_1)

{
  code *pcVar1;
  char cVar2;
  int iVar3;
  undefined8 *puVar4;
  undefined8 uStack_a0;
  undefined8 uStack_98;
  undefined8 uStack_90;
  undefined8 uStack_88;
  undefined8 uStack_80;
  undefined8 uStack_78;
  byte bStack_61;
  ulong uStack_60;
  undefined8 *puStack_58;
  undefined8 uStack_50;
  undefined8 uStack_48;
  
  cVar2 = cRam0000000103911448;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103324ae0);
    cRam0000000103911448 = '\x01';
  }
  uStack_80 = 0;
  uStack_78 = 0;
  bStack_61 = 0;
  uStack_98 = 0;
  uStack_a0 = 0;
  uStack_88 = 0;
  uStack_90 = 0;
  puVar4 = *(undefined8 **)(*(long *)(param_1 + 0x18) + 0x10);
  uStack_60 = 0;
  if (puVar4 != (undefined8 *)0x0) {
    if ((lRam00000001038c6c70 == *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x10)) &&
       (puVar4[0x60] != 0)) {
      func_0x000100371dbc(&uStack_a0);
      do {
        while( true ) {
          cVar2 = func_0x000100371dd0(&uStack_a0);
          if (cVar2 == '\0') {
            iVar3 = 2;
            goto LAB_101fa8c5c;
          }
          uStack_78 = ((undefined8 *)((ulong)&uStack_a0 | 0xc))[1];
          uStack_80 = *(undefined8 *)((ulong)&uStack_a0 | 0xc);
          uStack_50 = 0;
          uStack_48 = 0;
          func_0x00010034ede4(&uStack_50,*(int *)(param_1 + 0x34) << 6,*(int *)(param_1 + 0x38) << 6
                              ,0x40,0x40);
          cVar2 = func_0x00010035a4b4(&uStack_80,uStack_50,uStack_48);
          if (lRam0000000103976fb8 != 0) break;
          if (cVar2 != '\0') goto LAB_101fa8c44;
        }
        func_0x00010119b8f8();
      } while (cVar2 == '\0');
LAB_101fa8c44:
      iVar3 = 1;
      bStack_61 = 1;
LAB_101fa8c5c:
      uStack_60 = 0;
      puStack_58 = &uStack_a0;
      if (puStack_58 == (undefined8 *)0x0) {
        func_0x0001003316f4(0xee,_UNK_1036d2a38);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fa8ce0);
        (*pcVar1)();
      }
      if (iVar3 == 1) {
        uStack_60 = (ulong)bStack_61;
      }
      else if (iVar3 != 2) {
        func_0x000100331c30();
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fa8cf4);
        (*pcVar1)();
      }
    }
    else {
      uStack_60 = 0;
    }
  }
  return uStack_60;
}

