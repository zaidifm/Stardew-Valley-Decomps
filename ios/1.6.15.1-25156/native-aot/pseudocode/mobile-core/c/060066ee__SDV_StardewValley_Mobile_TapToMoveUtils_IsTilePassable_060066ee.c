/* 0x060066ee StardewValley.Mobile.TapToMoveUtils.IsTilePassable @ 0x101fcbff8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_TapToMoveUtils_IsTilePassable_060066ee
               (long *param_1,int param_2,int param_3)

{
  code *pcVar1;
  bool bVar2;
  char cVar3;
  long lVar4;
  long *plVar5;
  long *plVar6;
  long lVar7;
  undefined8 uVar8;
  undefined8 uVar9;
  long *plStack_68;
  long *plStack_60;
  long lStack_58;
  
  cVar3 = cRam00000001039114fd;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103325990);
    cRam00000001039114fd = '\x01';
  }
  plStack_68 = (long *)0x0;
  uVar8 = _UNK_1036d7a50;
  if (param_1[0x11] == 0) goto LAB_101fcc484;
  lVar4 = func_0x00010035f1f8(param_1[0x11],uRam00000001038cc720);
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0(lRam00000001038c4c88);
  }
  uVar8 = _UNK_1036d7a58;
  if ((lRam00000001038d5380 == 0) || (uVar8 = _UNK_1036d7a60, lVar4 == 0)) goto LAB_101fcc484;
  uVar9 = CONCAT44(param_3 << 6,param_2 << 6);
  plVar5 = (long *)func_0x00010035c840(lVar4,uVar9,*(undefined8 *)(lRam00000001038d5380 + 8));
  if (plVar5 == (long *)0x0) {
    uVar8 = _UNK_1036d7a68;
    if (param_1[0x11] == 0) goto LAB_101fcc484;
    lVar4 = func_0x00010035f1f8(param_1[0x11],uRam00000001038c90d0);
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0(lRam00000001038c4c88);
    }
    uVar8 = _UNK_1036d7a70;
    if ((lRam00000001038d5380 == 0) || (uVar8 = _UNK_1036d7a78, lVar4 == 0)) goto LAB_101fcc484;
    lVar4 = func_0x00010035c840(lVar4,uVar9,*(undefined8 *)(lRam00000001038d5380 + 8));
    if (lVar4 == 0) {
      return false;
    }
    plVar5 = (long *)func_0x00010035c854();
    uVar8 = _UNK_1036d7a80;
    if (plVar5 == (long *)0x0) goto LAB_101fcc484;
    (**(code **)(*plVar5 + -0x28))(plVar5,uRam00000001038e0408,&plStack_68);
    if (plStack_68 != (long *)0x0) {
      lVar7 = (**(code **)(*plStack_68 + 0x60))();
      uVar8 = _UNK_1036d7a98;
      if (lVar7 == 0) goto LAB_101fcc484;
      lVar7 = func_0x000100357d54();
      uVar8 = _UNK_1036d7aa8;
      if (*(int *)(lVar7 + 0x10) == 0) goto LAB_101fcc44c;
      if (*(short *)(lVar7 + 0x14) == 0x66) {
        return false;
      }
      uVar8 = (**(code **)(*plStack_68 + 0x60))();
      cVar3 = func_0x000100345aa0(uVar8,uRam00000001038d72c0);
      if (cVar3 != '\0') {
        return false;
      }
    }
    plVar5 = (long *)func_0x00010035c854(lVar4);
    uVar8 = _UNK_1036d7a88;
    if (plVar5 != (long *)0x0) {
      (**(code **)(*plVar5 + -0x28))(plVar5,uRam00000001038e7d30,&plStack_68);
      if ((plStack_68 != (long *)0x0) &&
         ((lRam00000001038d7950 != *(long *)(*(long *)(*(long *)*param_1 + 0x10) + 0x18) ||
          (cVar3 = (*(code *)((long *)*param_1)[0xe0])(param_1,param_2,param_3), cVar3 == '\0')))) {
        return false;
      }
      plVar5 = (long *)func_0x00010035c854(lVar4);
      uVar8 = _UNK_1036d7a90;
      if (plVar5 != (long *)0x0) {
        (**(code **)(*plVar5 + -0x28))(plVar5,uRam00000001038e7e60,&plStack_68);
        return plStack_68 == (long *)0x0;
      }
    }
    goto LAB_101fcc484;
  }
  plStack_60 = (long *)0x0;
  lStack_58 = 0;
  plVar6 = (long *)func_0x00010035c854();
  uVar8 = _UNK_1036d7ab8;
  if (plVar6 == (long *)0x0) goto LAB_101fcc484;
  (**(code **)(*plVar6 + -0x28))(plVar6,uRam00000001038e0408,&plStack_68);
  if (plStack_68 == (long *)0x0) {
    plVar6 = (long *)(**(code **)(*plVar5 + 0x70))(plVar5);
    (**(code **)(*plVar6 + -0x28))(plVar6,uRam00000001038e0408,&plStack_60);
    if (plStack_60 == (long *)0x0) {
      plVar5 = (long *)func_0x00010035c854(plVar5);
      uVar8 = _UNK_1036d7af8;
      if (plVar5 == (long *)0x0) goto LAB_101fcc484;
      (**(code **)(*plVar5 + -0x28))(plVar5,uRam00000001038e5238,&lStack_58);
    }
    if (plStack_68 != (long *)0x0) goto LAB_101fcc254;
LAB_101fcc27c:
    if (plStack_60 != (long *)0x0) {
      lVar4 = (**(code **)(*plStack_60 + 0x60))();
      uVar8 = _UNK_1036d7ac8;
      if (lVar4 == 0) {
LAB_101fcc484:
        func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcc490);
        (*pcVar1)();
      }
      lVar4 = func_0x000100357d54();
      uVar8 = _UNK_1036d7ad8;
      if (*(int *)(lVar4 + 0x10) == 0) {
LAB_101fcc44c:
        func_0x0001003316f4(0xcc,uVar8);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcc458);
        (*pcVar1)();
      }
      if (*(short *)(lVar4 + 0x14) == 0x74) goto LAB_101fcc2ac;
    }
    bVar2 = lStack_58 != 0;
  }
  else {
LAB_101fcc254:
    lVar4 = (**(code **)(*plStack_68 + 0x60))();
    uVar8 = _UNK_1036d7ae0;
    if (lVar4 == 0) goto LAB_101fcc484;
    lVar4 = func_0x000100357d54();
    uVar8 = _UNK_1036d7af0;
    if (*(int *)(lVar4 + 0x10) == 0) goto LAB_101fcc44c;
    if (*(short *)(lVar4 + 0x14) != 0x74) goto LAB_101fcc27c;
LAB_101fcc2ac:
    bVar2 = true;
  }
  return bVar2;
}

