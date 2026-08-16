/* 0x06006617 StardewValley.Mobile.AStarGraph.mergeBubbleID2IntoBubbleID @ 0x101fa6d7c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_AStarGraph_mergeBubbleID2IntoBubbleID_06006617(long param_1)

{
  uint uVar1;
  uint uVar2;
  char cVar3;
  code *pcVar4;
  undefined8 uVar5;
  long lVar6;
  long lVar7;
  int *piVar8;
  ulong uVar9;
  ulong uVar10;
  
  cVar3 = cRam0000000103911426;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103324a29);
    cRam0000000103911426 = '\x01';
    lVar6 = *(long *)(param_1 + 0x18);
  }
  else {
    lVar6 = *(long *)(param_1 + 0x18);
  }
  uVar5 = _UNK_1036d2770;
  if ((((*(long *)(lVar6 + 0x48) != 0) &&
       (lVar6 = func_0x000100353ce0(*(long *)(lVar6 + 0x48),0), uVar5 = _UNK_1036d2780,
       lVar6 != -0x68)) && (uVar5 = _UNK_1036d2778, lVar6 != 0)) &&
     (lVar7 = *(long *)(*(long *)(param_1 + 0x18) + 0x48), uVar5 = _UNK_1036d2790, lVar7 != 0)) {
    uVar1 = *(uint *)(lVar6 + 0x68);
    lVar6 = func_0x000100353ce0(lVar7,0);
    uVar5 = _UNK_1036d2798;
    if ((lVar6 != 0) && (uVar5 = _UNK_1036d27a0, lVar6 != -0x68)) {
      if (0 < (int)uVar1) {
        uVar9 = 0;
        uVar2 = *(uint *)(lVar6 + 0x6c);
        do {
          if (0 < (int)uVar2) {
            uVar10 = 0;
            do {
              lVar6 = *(long *)(param_1 + 0x20);
              piVar8 = *(int **)(lVar6 + 0x10);
              uVar5 = _UNK_1036d27b0;
              if ((ulong)(long)*piVar8 <= uVar9 - (long)piVar8[1]) {
LAB_101fa6fec:
                func_0x0001003316f4(0xcc,uVar5);
                    /* WARNING: Does not return */
                pcVar4 = (code *)SoftwareBreakpoint(1,0x101fa6ff8);
                (*pcVar4)();
              }
              uVar5 = _UNK_1036d27b8;
              if ((ulong)(long)piVar8[2] <= uVar10 - (long)piVar8[3]) goto LAB_101fa6fec;
              lVar7 = *(long *)(lVar6 + (uVar10 + ((uVar9 - (long)piVar8[1]) * (long)piVar8[2] -
                                                  (long)piVar8[3])) * 8 + 0x20);
              if (*(int *)(lVar7 + 0x40) == 0) {
                *(undefined4 *)(lVar7 + 0x3c) = 0;
                piVar8 = *(int **)(*(long *)(param_1 + 0x20) + 0x10);
                uVar5 = _UNK_1036d27f0;
                if ((ulong)(long)*piVar8 <= uVar9 - (long)piVar8[1]) goto LAB_101fa6fec;
                uVar5 = _UNK_1036d27f8;
                if ((ulong)(long)piVar8[2] <= uVar10 - (long)piVar8[3]) goto LAB_101fa6fec;
                *(undefined4 *)
                 (*(long *)(*(long *)(param_1 + 0x20) +
                            (uVar10 + ((uVar9 - (long)piVar8[1]) * (long)piVar8[2] - (long)piVar8[3]
                                      )) * 8 + 0x20) + 0x40) = 0xffffffff;
                lVar6 = *(long *)(param_1 + 0x20);
                uVar5 = _UNK_1036d27c8;
                if (lVar6 == 0) goto LAB_101fa700c;
              }
              piVar8 = *(int **)(lVar6 + 0x10);
              uVar5 = _UNK_1036d27d0;
              if ((ulong)(long)*piVar8 <= uVar9 - (long)piVar8[1]) goto LAB_101fa6fec;
              uVar5 = _UNK_1036d27d8;
              if ((ulong)(long)piVar8[2] <= uVar10 - (long)piVar8[3]) goto LAB_101fa6fec;
              *(undefined1 *)
               (*(long *)(lVar6 + (uVar10 + ((uVar9 - (long)piVar8[1]) * (long)piVar8[2] -
                                            (long)piVar8[3])) * 8 + 0x20) + 0x44) = 0;
              if (lRam0000000103976fb8 != 0) {
                func_0x00010119b8f8();
              }
              uVar10 = uVar10 + 1;
            } while (uVar2 != uVar10);
          }
          if (lRam0000000103976fb8 != 0) {
            func_0x00010119b8f8();
          }
          uVar9 = uVar9 + 1;
        } while (uVar9 != uVar1);
      }
      return;
    }
  }
LAB_101fa700c:
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101fa7018);
  (*pcVar4)();
}

