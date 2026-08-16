/* 0x06006644 StardewValley.Mobile.AStarNode.IsBuildingPassable @ 0x101fa9794 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_AStarNode_IsBuildingPassable_06006644(long param_1)

{
  int iVar1;
  int iVar2;
  code *pcVar3;
  char cVar4;
  long lVar5;
  long *plVar6;
  long *plVar7;
  undefined8 uVar8;
  long *plStack_48;
  long *plStack_40;
  long lStack_38;
  
  cVar4 = cRam0000000103911453;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103324b40);
    cRam0000000103911453 = '\x01';
  }
  plStack_48 = (long *)0x0;
  lStack_38 = 0;
  lVar5 = *(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0x88);
  uVar8 = _UNK_1036d2be0;
  if (lVar5 != 0) {
    lVar5 = func_0x00010035f1f8(lVar5,uRam00000001038cc720);
    iVar1 = *(int *)(param_1 + 0x34);
    iVar2 = *(int *)(param_1 + 0x38);
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar8 = _UNK_1036d2be8;
    if ((lRam00000001038d5380 != 0) && (uVar8 = _UNK_1036d2bf0, lVar5 != 0)) {
      plVar6 = (long *)func_0x00010035c840(lVar5,CONCAT44(iVar2 << 6,iVar1 << 6),
                                           *(undefined8 *)(lRam00000001038d5380 + 8));
      if (plVar6 == (long *)0x0) {
        return false;
      }
      plVar7 = (long *)func_0x00010035c854();
      uVar8 = _UNK_1036d2bf8;
      if (plVar7 != (long *)0x0) {
        (**(code **)(*plVar7 + -0x28))(plVar7,uRam00000001038e0408,&plStack_48);
        if (plStack_48 != (long *)0x0) {
          lVar5 = (**(code **)(*plStack_48 + 0x60))();
          uVar8 = _UNK_1036d2c28;
          if (lVar5 == 0) goto LAB_101fa9a68;
          uVar8 = func_0x000100357d54();
          cVar4 = func_0x000100345aa0(uVar8,uRam00000001038e0e88);
          if (cVar4 != '\0') {
            return true;
          }
          lVar5 = (**(code **)(*plStack_48 + 0x60))();
          uVar8 = _UNK_1036d2c38;
          if (lVar5 == 0) goto LAB_101fa9a68;
          uVar8 = func_0x000100357d54();
          cVar4 = func_0x000100345aa0(uVar8,uRam00000001038e5138);
          if (cVar4 != '\0') {
            return true;
          }
        }
        plStack_40 = (long *)0x0;
        plVar7 = (long *)(**(code **)(*plVar6 + 0x70))(plVar6);
        (**(code **)(*plVar7 + -0x28))(plVar7,uRam00000001038e0408,&plStack_40);
        if (plStack_40 != (long *)0x0) {
          lVar5 = (**(code **)(*plStack_40 + 0x60))();
          uVar8 = _UNK_1036d2c10;
          if (lVar5 == 0) goto LAB_101fa9a68;
          uVar8 = func_0x000100357d54();
          cVar4 = func_0x000100345aa0(uVar8,uRam00000001038e0e88);
          if (cVar4 != '\0') {
            return true;
          }
          lVar5 = (**(code **)(*plStack_40 + 0x60))();
          uVar8 = _UNK_1036d2c20;
          if (lVar5 == 0) goto LAB_101fa9a68;
          uVar8 = func_0x000100357d54();
          cVar4 = func_0x000100345aa0(uVar8,uRam00000001038e5138);
          if (cVar4 != '\0') {
            return true;
          }
        }
        lStack_38 = 0;
        plVar6 = (long *)func_0x00010035c854(plVar6);
        uVar8 = _UNK_1036d2c08;
        if (plVar6 != (long *)0x0) {
          (**(code **)(*plVar6 + -0x28))(plVar6,uRam00000001038e5238,&lStack_38);
          return lStack_38 != 0;
        }
      }
    }
  }
LAB_101fa9a68:
  func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fa9a74);
  (*pcVar3)();
}

