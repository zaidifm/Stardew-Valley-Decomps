/* 0x060065fb StardewValley.Mobile.AStarGraph.Init @ 0x101fa1424 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_AStarGraph_Init_060065fb(long param_1,long param_2)

{
  uint uVar1;
  uint uVar2;
  long lVar3;
  char cVar4;
  code *pcVar5;
  long lVar6;
  undefined8 uVar7;
  long lVar8;
  int *piVar9;
  long *plVar10;
  ulong uVar11;
  ulong uVar12;
  
  cVar4 = cRam000000010391140a;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_1033248f0);
    cRam000000010391140a = '\x01';
  }
  uVar7 = _UNK_1036d1660;
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x10) = param_2;
    lVar3 = lRam00000001038c4be0;
    *(undefined1 *)(((ulong)(param_1 + 0x10) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    DataMemoryBarrier(2,3);
    plVar10 = (long *)(param_1 + 0x18);
    *plVar10 = *(long *)(param_2 + 0x88);
    *(undefined1 *)(((ulong)plVar10 >> 9 & 0x7fffff) + lVar3) = 1;
    uVar7 = _UNK_1036d1678;
    if ((((*(long *)(*plVar10 + 0x48) != 0) &&
         (lVar6 = func_0x000100353ce0(*(long *)(*plVar10 + 0x48),0), uVar7 = _UNK_1036d1688,
         lVar6 != -0x68)) && (uVar7 = _UNK_1036d1680, lVar6 != 0)) &&
       (lVar8 = *(long *)(*(long *)(param_1 + 0x18) + 0x48), uVar7 = _UNK_1036d1698, lVar8 != 0)) {
      uVar1 = *(uint *)(lVar6 + 0x68);
      lVar6 = func_0x000100353ce0(lVar8,0);
      uVar7 = _UNK_1036d16a0;
      if ((lVar6 != 0) && (uVar7 = _UNK_1036d16a8, lVar6 != -0x68)) {
        uVar2 = *(uint *)(lVar6 + 0x6c);
        uVar7 = func_0x000100356468(uRam0000000103904580,(ulong)uVar1,(ulong)uVar2);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 0x20) = uVar7;
        *(undefined1 *)(((ulong)(param_1 + 0x20) >> 9 & 0x7fffff) + lVar3) = 1;
        if (0 < (int)uVar1) {
          uVar12 = 0;
          do {
            if (0 < (int)uVar2) {
              uVar11 = 0;
              do {
                lVar6 = func_0x000100331820(uRam0000000103904588,0x48);
                *(undefined8 *)(lVar6 + 0x3c) = 0xffffffffffffffff;
                DataMemoryBarrier(2,3);
                *(long *)(lVar6 + 0x18) = param_1;
                *(undefined1 *)(((ulong)(lVar6 + 0x18) >> 9 & 0x7fffff) + lVar3) = 1;
                lVar8 = *(long *)(param_1 + 0x20);
                *(int *)(lVar6 + 0x34) = (int)uVar12;
                *(int *)(lVar6 + 0x38) = (int)uVar11;
                func_0x00010037753c(lVar8,lVar6);
                piVar9 = *(int **)(lVar8 + 0x10);
                uVar7 = _UNK_1036d16b8;
                if ((ulong)(long)*piVar9 <= uVar12 - (long)piVar9[1]) {
LAB_101fa1694:
                  func_0x0001003316f4(0xcc,uVar7);
                    /* WARNING: Does not return */
                  pcVar5 = (code *)SoftwareBreakpoint(1,0x101fa16a0);
                  (*pcVar5)();
                }
                uVar7 = _UNK_1036d16c0;
                if ((ulong)(long)piVar9[2] <= uVar11 - (long)piVar9[3]) goto LAB_101fa1694;
                DataMemoryBarrier(2,3);
                plVar10 = (long *)(lVar8 + (uVar11 + ((uVar12 - (long)piVar9[1]) * (long)piVar9[2] -
                                                     (long)piVar9[3])) * 8 + 0x20);
                *plVar10 = lVar6;
                *(undefined1 *)(((ulong)plVar10 >> 9 & 0x7fffff) + lVar3) = 1;
                if (lRam0000000103976fb8 != 0) {
                  func_0x00010119b8f8();
                }
                uVar11 = uVar11 + 1;
              } while (uVar2 != uVar11);
            }
            if (lRam0000000103976fb8 != 0) {
              func_0x00010119b8f8();
            }
            uVar12 = uVar12 + 1;
          } while (uVar12 != uVar1);
        }
        return;
      }
    }
  }
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar5 = (code *)SoftwareBreakpoint(1,0x101fa1680);
  (*pcVar5)();
}

