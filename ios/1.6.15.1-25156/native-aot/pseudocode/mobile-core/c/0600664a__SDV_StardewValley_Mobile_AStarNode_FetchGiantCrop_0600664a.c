/* 0x0600664a StardewValley.Mobile.AStarNode.FetchGiantCrop @ 0x101fab530 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 * SDV_StardewValley_Mobile_AStarNode_FetchGiantCrop_0600664a(long param_1)

{
  uint uVar1;
  code *pcVar2;
  char cVar3;
  undefined8 uVar4;
  long lVar5;
  undefined8 *puVar6;
  undefined8 *puVar7;
  uint uVar8;
  long lVar9;
  
  cVar3 = cRam0000000103911459;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103324d24);
    cRam0000000103911459 = '\x01';
    lVar5 = *(long *)(param_1 + 0x18);
  }
  else {
    lVar5 = *(long *)(param_1 + 0x18);
  }
  puVar7 = *(undefined8 **)(lVar5 + 0x10);
  if ((puVar7 == (undefined8 *)0x0) ||
     (lRam00000001038c69d0 != *(long *)(*(long *)(*(long *)*puVar7 + 0x10) + 0x10))) {
    return (undefined8 *)0x0;
  }
  lVar5 = puVar7[0x20];
  uVar4 = _UNK_1036d2fa8;
  if (lVar5 != 0) {
    uVar8 = 0xffffffff;
    lVar9 = 0x20;
    do {
      while( true ) {
        uVar1 = *(uint *)(*(long *)(lVar5 + 0x58) + 0x18);
        if ((int)uVar1 <= (int)(uVar8 + 1)) {
          return (undefined8 *)0x0;
        }
        if (uVar1 <= uVar8 + 1) {
          func_0x000100331b90();
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101fab69c);
          (*pcVar2)();
        }
        lVar5 = *(long *)(*(long *)(lVar5 + 0x58) + 0x10);
        uVar8 = uVar8 + 1;
        if (*(uint *)(lVar5 + 0x18) <= uVar8) {
          func_0x0001003316f4(0xcc,_UNK_1036d2fb0);
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101fab6bc);
          (*pcVar2)();
        }
        puVar6 = *(undefined8 **)(lVar9 + lVar5);
        uVar4 = _UNK_1036d2fa0;
        if (puVar6 == (undefined8 *)0x0) goto LAB_101fab6c4;
        cVar3 = func_0x000101a983a0(puVar6,*(undefined4 *)(param_1 + 0x34),
                                    *(undefined4 *)(param_1 + 0x38));
        if ((cVar3 != '\0') &&
           (lRam00000001038c7920 == *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18))) {
          return puVar6;
        }
        lVar5 = puVar7[0x20];
        if (lRam0000000103976fb8 != 0) break;
        lVar9 = lVar9 + 8;
        uVar4 = _UNK_1036d2fa8;
        if (lVar5 == 0) goto LAB_101fab6c4;
      }
      func_0x00010119b8f8();
      lVar9 = lVar9 + 8;
      uVar4 = _UNK_1036d2fa8;
    } while (lVar5 != 0);
  }
LAB_101fab6c4:
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fab6d0);
  (*pcVar2)();
}

