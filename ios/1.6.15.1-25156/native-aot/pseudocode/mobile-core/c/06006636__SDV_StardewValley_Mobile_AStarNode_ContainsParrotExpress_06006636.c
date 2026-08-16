/* 0x06006636 StardewValley.Mobile.AStarNode.ContainsParrotExpress @ 0x101fa8688 */

/* WARNING: Removing unreachable block (ram,0x000101fa88c0) */
/* WARNING: Removing unreachable block (ram,0x000101fa88a4) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1 SDV_StardewValley_Mobile_AStarNode_ContainsParrotExpress_06006636(long param_1)

{
  long *plVar1;
  code *pcVar2;
  char cVar3;
  undefined8 uVar4;
  int iVar5;
  undefined8 *puVar6;
  undefined8 uStack_70;
  undefined8 uStack_68;
  long *plStack_60;
  undefined1 uStack_51;
  undefined8 uStack_50;
  undefined8 *puStack_48;
  
  cVar3 = cRam0000000103911445;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103324a90);
    cRam0000000103911445 = '\x01';
  }
  uStack_70 = 0;
  uStack_68 = 0;
  plStack_60 = (long *)0x0;
  uStack_51 = 0;
  puVar6 = *(undefined8 **)(*(long *)(param_1 + 0x18) + 0x10);
  if ((puVar6 == (undefined8 *)0x0) ||
     (lRam00000001038c6ce0 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x10))) {
    return 0;
  }
  uVar4 = _UNK_1036d2a08;
  if (puVar6[0x5f] != 0) {
    func_0x00010037226c(&uStack_70);
    while (cVar3 = func_0x0001003722a8(&uStack_70), plVar1 = plStack_60, cVar3 != '\0') {
      if (plStack_60 == (long *)0x0) {
        func_0x0001003316f4(0xee,_UNK_1036d2a10);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101fa87f4);
        (*pcVar2)();
      }
      cVar3 = (**(code **)(*plStack_60 + 0x80))
                        ((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38),plStack_60)
      ;
      if (cVar3 != '\0') {
        func_0x00010035025c(*(float *)(plVar1 + 9) * 0.015625,
                            *(float *)((long)plVar1 + 0x4c) * 0.015625,0x3f800000,0x3f800000);
        cVar3 = func_0x0001003501d0();
        if (cVar3 != '\0') {
          func_0x00010035025c(*(float *)(plVar1 + 9) * 0.015625,
                              *(float *)((long)plVar1 + 0x4c) * 0.015625,0x3f800000,0);
          cVar3 = func_0x0001003501d0();
          if (cVar3 != '\0') {
            iVar5 = 1;
            uStack_51 = 1;
            goto LAB_101fa8884;
          }
        }
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
    }
    iVar5 = 2;
LAB_101fa8884:
    uStack_50 = 0;
    puStack_48 = &uStack_70;
    if (puStack_48 != (undefined8 *)0x0) {
      if (iVar5 == 1) {
        return uStack_51;
      }
      if (iVar5 != 2) {
        func_0x000100331c30();
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101fa88d0);
        (*pcVar2)();
      }
      return 0;
    }
    puStack_48 = (undefined8 *)0x0;
    uVar4 = _UNK_1036d2a18;
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fa885c);
  (*pcVar2)();
}

