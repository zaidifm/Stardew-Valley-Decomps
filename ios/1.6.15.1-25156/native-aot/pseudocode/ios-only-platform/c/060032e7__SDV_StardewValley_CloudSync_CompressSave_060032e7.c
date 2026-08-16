/* 0x060032e7 StardewValley.CloudSync.CompressSave @ 0x10179f0d0 */

/* WARNING: Removing unreachable block (ram,0x00010179f3f8) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_CloudSync_CompressSave_060032e7(undefined8 param_1,long param_2)

{
  int iVar1;
  char cVar2;
  code *pcVar3;
  int iVar4;
  long *plVar5;
  long *plVar6;
  long *plVar7;
  long lVar8;
  undefined8 uVar9;
  undefined8 uStack_a0;
  undefined8 uStack_98;
  undefined8 uStack_90;
  undefined8 uStack_88;
  long *plStack_80;
  long *plStack_78;
  int iStack_6c;
  long lStack_68;
  long lStack_60;
  long lStack_58;
  long lStack_50;
  long lStack_48;
  long lStack_40;
  long lStack_38;
  
  cVar2 = cRam000000010390e0f6;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1032d3b70);
    cRam000000010390e0f6 = '\x01';
  }
  uStack_a0 = 0;
  uStack_98 = 0;
  uStack_90 = 0;
  uStack_88 = 0;
  plStack_80 = (long *)0x0;
  plStack_78 = (long *)0x0;
  iStack_6c = 0;
  plVar5 = (long *)func_0x000100331820(uRam00000001038c4fc0,0x40);
  func_0x0001003320a4();
  plVar6 = (long *)func_0x000100331820(uRam00000001038c5220,0x28);
  StardewValley_Ionic_Zlib_ZlibStream__ctor_060000ed(plVar6,plVar5,0,6,0);
  plVar7 = (long *)func_0x000100331820(uRam00000001038df888,0x28);
  func_0x000100357958(plVar7,plVar6);
  lVar8 = func_0x000100331794(uRam00000001038c4cd0,0x1000);
  SDV_StardewValley_CloudSync_GetSaveInfoAndFarmer_060032ef
            (*(undefined8 *)(param_2 + 0x28),&uStack_a0,&uStack_98,&uStack_90);
  plStack_80 = (long *)func_0x000100357980(uStack_98);
  if ((plStack_80 == (long *)0x0) ||
     (uVar9 = (**(code **)(*plStack_80 + 0x158))(), plVar7 == (long *)0x0)) {
LAB_10179f27c:
    func_0x0001003316f4(0xee,_UNK_1035f55c0);
LAB_10179f3e0:
                    /* WARNING: Does not return */
    pcVar3 = (code *)SoftwareBreakpoint(1,0x10179f3e4);
    (*pcVar3)();
  }
  (**(code **)(*plVar7 + 0x98))(plVar7,uVar9);
  do {
    while( true ) {
      if ((lVar8 == 0) || (plStack_80 == (long *)0x0)) goto LAB_10179f27c;
      iVar4 = (**(code **)(*plStack_80 + 0xa8))(plStack_80,lVar8,0,*(undefined4 *)(lVar8 + 0x18));
      if ((plVar7 == (long *)0x0) ||
         ((**(code **)(*plVar7 + 0xe8))(plVar7,lVar8,0,iVar4), lVar8 == 0)) goto LAB_10179f27c;
      iVar1 = *(int *)(lVar8 + 0x18);
      if (lRam0000000103976fb8 != 0) break;
      if (iVar4 < iVar1) goto LAB_10179f268;
    }
    func_0x00010119b8f8();
  } while (iVar1 <= iVar4);
LAB_10179f268:
  lStack_68 = 0;
  if (plStack_80 != (long *)0x0) {
    uVar9 = _UNK_1035f5630;
    if (plStack_80 == (long *)0x0) goto LAB_10179f2c0;
    (**(code **)(*plStack_80 + -0x28))();
  }
  if (lStack_68 != 0) {
    func_0x000100331ba4();
  }
  plStack_78 = (long *)func_0x000100357980(uStack_90);
  if ((plStack_78 == (long *)0x0) ||
     (uVar9 = (**(code **)(*plStack_78 + 0x158))(), plVar7 == (long *)0x0)) {
LAB_10179f3d0:
    func_0x0001003316f4(0xee,_UNK_1035f5628);
    goto LAB_10179f3e0;
  }
  (**(code **)(*plVar7 + 0x98))(plVar7,uVar9);
  do {
    while( true ) {
      if ((((lVar8 == 0) || (plStack_78 == (long *)0x0)) ||
          (iStack_6c = (**(code **)(*plStack_78 + 0xa8))
                                 (plStack_78,lVar8,0,*(undefined4 *)(lVar8 + 0x18)),
          plVar7 == (long *)0x0)) ||
         ((**(code **)(*plVar7 + 0xe8))(plVar7,lVar8,0,iStack_6c), iVar4 = iStack_6c, lVar8 == 0))
      goto LAB_10179f3d0;
      iVar1 = *(int *)(lVar8 + 0x18);
      if (lRam0000000103976fb8 != 0) break;
      if (iStack_6c < iVar1) goto LAB_10179f3bc;
    }
    func_0x00010119b8f8();
  } while (iVar1 <= iVar4);
LAB_10179f3bc:
  lStack_60 = 0;
  if (plStack_78 != (long *)0x0) {
    uVar9 = _UNK_1035f5638;
    if (plStack_78 == (long *)0x0) goto LAB_10179f2c0;
    (**(code **)(*plStack_78 + -0x28))();
  }
  if (lStack_60 != 0) {
    func_0x000100331ba4();
  }
  (**(code **)(*plVar7 + 0x130))();
  (**(code **)(*plVar6 + 0x120))();
  uVar9 = _UNK_1035f55d8;
  if (plVar5 != (long *)0x0) {
    uStack_88 = func_0x0001003320e0();
    (**(code **)(*plVar5 + 0x120))();
    lStack_58 = func_0x000100331820(uRam00000001038df890,0x48);
    uVar9 = _UNK_1035f55e8;
    if (lStack_58 != 0) {
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lStack_58 + 0x18U) = uStack_a0;
      lVar8 = lRam00000001038c4be0;
      *(undefined1 *)((lStack_58 + 0x18U >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
      uVar9 = _UNK_1035f55f0;
      lStack_50 = lStack_58;
      if (lStack_58 != 0) {
        DataMemoryBarrier(2,3);
        *(undefined8 *)(lStack_58 + 0x30U) = uStack_88;
        *(undefined1 *)((lStack_58 + 0x30U >> 9 & 0x7fffff) + lVar8) = 1;
        uVar9 = _UNK_1035f55f8;
        lStack_48 = lStack_58;
        if (((param_2 != 0) && (uVar9 = _UNK_1035f5600, lStack_58 != 0)) &&
           ((*(undefined8 *)(lStack_58 + 0x38) = *(undefined8 *)(param_2 + 0x38),
            uVar9 = _UNK_1035f5608, lStack_40 = lStack_58, param_2 != 0 &&
            (uVar9 = _UNK_1035f5610, lStack_58 != 0)))) {
          DataMemoryBarrier(2,3);
          *(undefined8 *)(lStack_58 + 0x20U) = *(undefined8 *)(param_2 + 0x20);
          *(undefined1 *)((lStack_58 + 0x20U >> 9 & 0x7fffff) + lVar8) = 1;
          uVar9 = _UNK_1035f5618;
          lStack_38 = lStack_58;
          if ((param_2 != 0) && (uVar9 = _UNK_1035f5620, lStack_58 != 0)) {
            *(undefined4 *)(lStack_58 + 0x40) = *(undefined4 *)(param_2 + 0x40);
            return lStack_58;
          }
        }
      }
    }
  }
LAB_10179f2c0:
  func_0x0001003316f4(0xee,uVar9);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x10179f2cc);
  (*pcVar3)();
}

