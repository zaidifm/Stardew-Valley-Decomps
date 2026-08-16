/* 0x06006646 StardewValley.Mobile.AStarNode.ContainsSomeKindOfWarp @ 0x101faa99c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1 SDV_StardewValley_Mobile_AStarNode_ContainsSomeKindOfWarp_06006646(long param_1)

{
  int iVar1;
  code *pcVar2;
  char cVar3;
  long lVar4;
  long *plVar5;
  long *plVar6;
  undefined8 extraout_x1;
  undefined8 uVar7;
  int iVar8;
  undefined8 uStack_70;
  long *plStack_68;
  undefined1 uStack_59;
  long lStack_58;
  
  cVar3 = cRam0000000103911455;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103324cc0);
    cRam0000000103911455 = '\x01';
  }
  uStack_70 = 0;
  uStack_59 = 0;
  lVar4 = *(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0x88);
  uVar7 = _UNK_1036d2db0;
  if (lVar4 != 0) {
    lVar4 = func_0x00010035f1f8(lVar4,uRam00000001038cc720);
    iVar8 = *(int *)(param_1 + 0x34);
    iVar1 = *(int *)(param_1 + 0x38);
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar7 = _UNK_1036d2db8;
    if ((lRam00000001038d5380 != 0) && (uVar7 = _UNK_1036d2dc0, lVar4 != 0)) {
      plVar5 = (long *)func_0x00010035c840(lVar4,CONCAT44(iVar1 << 6,iVar8 << 6),
                                           *(undefined8 *)(lRam00000001038d5380 + 8));
      if (plVar5 == (long *)0x0) {
        return 0;
      }
      plVar6 = (long *)func_0x00010035c854();
      uVar7 = _UNK_1036d2dc8;
      if (plVar6 != (long *)0x0) {
        (**(code **)(*plVar6 + -0x28))(plVar6,uRam00000001038e0408,&uStack_70);
        plVar5 = (long *)(**(code **)(*plVar5 + 0x70))(plVar5);
        uVar7 = _UNK_1036d2dd0;
        if (plVar5 != (long *)0x0) {
          plStack_68 = (long *)(**(code **)(*plVar5 + -0x10))();
          do {
            if (plStack_68 == (long *)0x0) goto LAB_101faab74;
            cVar3 = (**(code **)(*plStack_68 + -0x78))();
            if (cVar3 == '\0') {
              iVar8 = 2;
              uVar7 = _UNK_1036d2de0;
              goto joined_r0x000101faab94;
            }
            if (plStack_68 == (long *)0x0) {
LAB_101faab74:
              func_0x0001003316f4(0xee,_UNK_1036d2dd8);
                    /* WARNING: Does not return */
              pcVar2 = (code *)SoftwareBreakpoint(1,0x101faab88);
              (*pcVar2)();
            }
            (**(code **)(*plStack_68 + -0x38))();
            lVar4 = func_0x000100374f30(extraout_x1);
            if (lVar4 == 0) goto LAB_101faab74;
            cVar3 = func_0x000100350144(lVar4,uRam00000001038e7e10);
            if (((cVar3 != '\0') ||
                (cVar3 = func_0x000100350144(lVar4,uRam00000001038c7b38), cVar3 != '\0')) ||
               (cVar3 = func_0x000100350144(lVar4,uRam00000001038e7e08), cVar3 != '\0')) break;
            cVar3 = func_0x000100350144(lVar4,uRam00000001038e7e18);
            if (lRam0000000103976fb8 != 0) {
              func_0x00010119b8f8();
            }
          } while (cVar3 == '\0');
          iVar8 = 1;
          uStack_59 = 1;
          uVar7 = _UNK_1036d2de0;
joined_r0x000101faab94:
          _UNK_1036d2de0 = uVar7;
          if (plStack_68 == (long *)0x0) {
            lStack_58 = 0;
          }
          else {
            lStack_58 = 0;
            if (plStack_68 == (long *)0x0) goto LAB_101faac40;
            (**(code **)(*plStack_68 + -0x28))();
          }
          if (iVar8 == 1) {
            if (lStack_58 == 0) {
              return uStack_59;
            }
            func_0x000100331ba4();
            return uStack_59;
          }
          if (iVar8 == 2) {
            if (lStack_58 != 0) {
              func_0x000100331ba4();
              return 0;
            }
            return 0;
          }
          func_0x000100331c30();
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101faacd0);
          (*pcVar2)();
        }
      }
    }
  }
LAB_101faac40:
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101faac4c);
  (*pcVar2)();
}

