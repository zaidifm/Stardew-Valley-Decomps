/* 0x06006604 StardewValley.Mobile.AStarGraph.RetracePath @ 0x101fa2f4c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long * SDV_StardewValley_Mobile_AStarGraph_RetracePath_06006604
                 (undefined8 param_1,long param_2,long param_3)

{
  uint uVar1;
  char cVar2;
  code *pcVar3;
  long *plVar4;
  long lVar5;
  long lVar6;
  undefined8 uVar7;
  long *plVar8;
  
  cVar2 = cRam0000000103911413;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1033249e0);
    cRam0000000103911413 = '\x01';
  }
  plVar4 = (long *)func_0x000100331820(uRam00000001039045a0,0x20);
  if (*(char *)(lRam00000001039045a8 + 0x35) == '\0') {
    func_0x0001003319b0(lRam00000001039045a8);
  }
  lVar5 = func_0x000100331820(lRam00000001039045a8,0x20);
  lVar6 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar5 + 0x10) = *puRam00000001039045b0;
  *(undefined1 *)(((ulong)(lVar5 + 0x10) >> 9 & 0x7fffff) + lVar6) = 1;
  DataMemoryBarrier(2,3);
  plVar4[2] = lVar5;
  *(undefined1 *)(((ulong)(plVar4 + 2) >> 9 & 0x7fffff) + lVar6) = 1;
  while (param_3 != param_2) {
    while( true ) {
      lVar6 = (**(code **)(*plVar4 + 0x88))(plVar4);
      plVar8 = *(long **)(lVar6 + 0x10);
      *(int *)(lVar6 + 0x1c) = *(int *)(lVar6 + 0x1c) + 1;
      uVar7 = _UNK_1036d19b0;
      if (plVar8 == (long *)0x0) goto LAB_101fa310c;
      uVar1 = *(uint *)(lVar6 + 0x18);
      if (uVar1 < *(uint *)(plVar8 + 3)) {
        *(uint *)(lVar6 + 0x18) = uVar1 + 1;
        (**(code **)(*plVar8 + 0x110))(plVar8,(long)(int)uVar1,param_3);
      }
      else {
        func_0x00010037d11c(lVar6,param_3);
      }
      uVar7 = _UNK_1036d19b8;
      if (param_3 == 0) goto LAB_101fa310c;
      param_3 = *(long *)(param_3 + 0x10);
      if (lRam0000000103976fb8 != 0) break;
      if (param_3 == param_2) goto LAB_101fa3084;
    }
    func_0x00010119b8f8();
  }
LAB_101fa3084:
  lVar6 = (**(code **)(*plVar4 + 0x88))(plVar4);
  uVar7 = _UNK_1036d19c0;
  if (lVar6 != 0) {
    func_0x00010037d2e8();
    return plVar4;
  }
LAB_101fa310c:
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fa3118);
  (*pcVar3)();
}

