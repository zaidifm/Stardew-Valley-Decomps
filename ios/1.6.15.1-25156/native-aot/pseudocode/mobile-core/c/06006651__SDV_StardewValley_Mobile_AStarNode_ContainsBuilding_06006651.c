/* 0x06006651 StardewValley.Mobile.AStarNode.ContainsBuilding @ 0x101fac0ec */

/* WARNING: Removing unreachable block (ram,0x000101fac42c) */
/* WARNING: Removing unreachable block (ram,0x000101fac448) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_AStarNode_ContainsBuilding_06006651(long param_1)

{
  undefined8 uVar1;
  code *pcVar2;
  char cVar3;
  long lVar4;
  undefined8 uVar5;
  int iVar6;
  undefined8 uStack_a8;
  undefined8 uStack_a0;
  long *plStack_98;
  undefined1 uStack_89;
  undefined8 uStack_88;
  undefined8 *puStack_80;
  int iStack_74;
  long lStack_70;
  int iStack_64;
  long lStack_60;
  undefined8 uStack_58;
  undefined8 *puStack_50;
  int iStack_48;
  int iStack_44;
  long lStack_40;
  long lStack_38;
  
  cVar3 = cRam0000000103911460;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103324d5e);
    cRam0000000103911460 = '\x01';
  }
  uStack_a8 = 0;
  uStack_a0 = 0;
  plStack_98 = (long *)0x0;
  uStack_89 = 0;
  cVar3 = (**(code **)(**(long **)(*(long *)(param_1 + 0x18) + 0x10) + 0x510))();
  if (cVar3 != '\0') {
    uVar5 = _UNK_1036d3168;
    if (*(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0x20) == 0) goto LAB_101fac284;
    func_0x0001003432c8(&uStack_a8);
    do {
      while( true ) {
        cVar3 = func_0x000100354ba4(&uStack_a8);
        if (cVar3 == '\0') {
          iVar6 = 2;
          goto LAB_101fac40c;
        }
        if (((param_1 == 0) || (param_1 == 0)) || (plStack_98 == (long *)0x0)) {
          func_0x0001003316f4(0xee,_UNK_1036d3170);
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101fac200);
          (*pcVar2)();
        }
        cVar3 = (**(code **)(*plStack_98 + 0x100))
                          ((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38));
        if (lRam0000000103976fb8 == 0) break;
        func_0x00010119b8f8();
        if (cVar3 == '\0') goto LAB_101fac1dc;
      }
    } while (cVar3 != '\0');
LAB_101fac1dc:
    iVar6 = 1;
    uStack_89 = 1;
LAB_101fac40c:
    uStack_88 = 0;
    puStack_80 = &uStack_a8;
    uVar5 = _UNK_1036d3178;
    if (puStack_80 == (undefined8 *)0x0) goto LAB_101fac284;
    if (iVar6 == 1) {
      return (bool)uStack_89;
    }
    if (iVar6 != 2) {
      func_0x000100331c30();
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101fac458);
      (*pcVar2)();
    }
  }
  lVar4 = *(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0x88);
  uVar5 = _UNK_1036d3118;
  if (lVar4 != 0) {
    lStack_38 = func_0x00010035f1f8(lVar4,uRam00000001038cc720);
    iStack_74 = *(int *)(param_1 + 0x34);
    iStack_64 = *(int *)(param_1 + 0x38);
    puStack_50 = &uStack_58;
    iStack_48 = iStack_74 << 6;
    uStack_58 = 0;
    iStack_44 = iStack_64 << 6;
                    /* WARNING: Ignoring partial resolution of indirect */
    uStack_58._0_4_ = iStack_48;
    uVar5 = _UNK_1036d3138;
    lStack_70 = param_1;
    lStack_60 = param_1;
    if (puStack_50 != (undefined8 *)0x0) {
                    /* WARNING: Ignoring partial resolution of indirect */
      uStack_58._4_4_ = iStack_44;
      uVar1 = uStack_58;
      lStack_40 = lRam00000001038c4c88;
      uStack_58 = uVar1;
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0(lRam00000001038c4c88);
      }
      uVar5 = _UNK_1036d3148;
      if (lStack_38 != 0) {
        lVar4 = func_0x00010035c840(lStack_38,lStack_38,uVar1,
                                    *(undefined8 *)(lRam00000001038d5380 + 8));
        return lVar4 != 0;
      }
    }
  }
LAB_101fac284:
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fac290);
  (*pcVar2)();
}

