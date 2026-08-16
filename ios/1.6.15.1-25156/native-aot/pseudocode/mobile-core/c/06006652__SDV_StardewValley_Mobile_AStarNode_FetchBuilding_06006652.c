/* 0x06006652 StardewValley.Mobile.AStarNode.FetchBuilding @ 0x101fac468 */

/* WARNING: Removing unreachable block (ram,0x000101fac648) */
/* WARNING: Removing unreachable block (ram,0x000101fac62c) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long * SDV_StardewValley_Mobile_AStarNode_FetchBuilding_06006652(long param_1)

{
  long *plVar1;
  code *pcVar2;
  char cVar3;
  undefined8 uVar4;
  int iVar5;
  undefined8 uStack_70;
  undefined8 uStack_68;
  long *plStack_60;
  long *plStack_58;
  undefined8 uStack_50;
  undefined8 *puStack_48;
  
  cVar3 = cRam0000000103911461;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103324d6c);
    cRam0000000103911461 = '\x01';
  }
  uStack_70 = 0;
  uStack_68 = 0;
  plStack_60 = (long *)0x0;
  plStack_58 = (long *)0x0;
  cVar3 = (**(code **)(**(long **)(*(long *)(param_1 + 0x18) + 0x10) + 0x510))();
  if (cVar3 == '\0') {
    return (long *)0x0;
  }
  uVar4 = _UNK_1036d31a8;
  if (*(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0x20) != 0) {
    func_0x0001003432c8(&uStack_70);
    do {
      while( true ) {
        cVar3 = func_0x000100354ba4(&uStack_70);
        plVar1 = plStack_60;
        if (cVar3 == '\0') {
          iVar5 = 2;
          goto LAB_101fac60c;
        }
        if (plStack_60 == (long *)0x0) {
          func_0x0001003316f4(0xee,_UNK_1036d31b0);
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101fac56c);
          (*pcVar2)();
        }
        cVar3 = (**(code **)(*plStack_60 + 0x100))
                          ((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38),
                           plStack_60);
        if (lRam0000000103976fb8 != 0) break;
        if (cVar3 == '\0') goto LAB_101fac540;
      }
      func_0x00010119b8f8();
    } while (cVar3 != '\0');
LAB_101fac540:
    iVar5 = 1;
    plStack_58 = plVar1;
LAB_101fac60c:
    uStack_50 = 0;
    puStack_48 = &uStack_70;
    if (puStack_48 != (undefined8 *)0x0) {
      if (iVar5 == 1) {
        return plStack_58;
      }
      if (iVar5 == 2) {
        return (long *)0x0;
      }
      func_0x000100331c30();
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101fac658);
      (*pcVar2)();
    }
    puStack_48 = (undefined8 *)0x0;
    uVar4 = _UNK_1036d31b8;
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fac5e4);
  (*pcVar2)();
}

