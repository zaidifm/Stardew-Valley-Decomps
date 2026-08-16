/* 0x06006616 StardewValley.Mobile.AStarGraph.ResetBubbles @ 0x101fa6a70 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_AStarGraph_ResetBubbles_06006616
               (long param_1,char param_2,char param_3)

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
  
  cVar3 = cRam0000000103911425;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103324a20);
    cRam0000000103911425 = '\x01';
    lVar6 = *(long *)(param_1 + 0x18);
  }
  else {
    lVar6 = *(long *)(param_1 + 0x18);
  }
  if (lVar6 == 0) {
    return;
  }
  uVar5 = _UNK_1036d26c8;
  if ((((*(long *)(lVar6 + 0x48) != 0) &&
       (lVar6 = func_0x000100353ce0(*(long *)(lVar6 + 0x48),0), uVar5 = _UNK_1036d26d8,
       lVar6 != -0x68)) && (uVar5 = _UNK_1036d26d0, lVar6 != 0)) &&
     (lVar7 = *(long *)(*(long *)(param_1 + 0x18) + 0x48), uVar5 = _UNK_1036d26e8, lVar7 != 0)) {
    uVar1 = *(uint *)(lVar6 + 0x68);
    lVar6 = func_0x000100353ce0(lVar7,0);
    uVar5 = _UNK_1036d26f0;
    if ((lVar6 != 0) && (uVar5 = _UNK_1036d26f8, lVar6 != -0x68)) {
      if ((int)uVar1 < 1) {
        return;
      }
      uVar9 = 0;
      uVar2 = *(uint *)(lVar6 + 0x6c);
      do {
        if (0 < (int)uVar2) {
          uVar10 = 0;
          do {
            piVar8 = *(int **)(*(long *)(param_1 + 0x20) + 0x10);
            uVar5 = _UNK_1036d2708;
            if ((ulong)(long)*piVar8 <= uVar9 - (long)piVar8[1]) {
LAB_101fa6d08:
              func_0x0001003316f4(0xcc,uVar5);
                    /* WARNING: Does not return */
              pcVar4 = (code *)SoftwareBreakpoint(1,0x101fa6d14);
              (*pcVar4)();
            }
            uVar5 = _UNK_1036d2710;
            if ((ulong)(long)piVar8[2] <= uVar10 - (long)piVar8[3]) goto LAB_101fa6d08;
            lVar6 = *(long *)(*(long *)(param_1 + 0x20) +
                              (uVar10 + ((uVar9 - (long)piVar8[1]) * (long)piVar8[2] -
                                        (long)piVar8[3])) * 8 + 0x20);
            uVar5 = _UNK_1036d2718;
            if (lVar6 == 0) goto LAB_101fa6d1c;
            *(undefined1 *)(lVar6 + 0x44) = 0;
            if (param_2 != '\0') {
              piVar8 = *(int **)(*(long *)(param_1 + 0x20) + 0x10);
              uVar5 = _UNK_1036d2748;
              if ((ulong)(long)*piVar8 <= uVar9 - (long)piVar8[1]) goto LAB_101fa6d08;
              uVar5 = _UNK_1036d2750;
              if ((ulong)(long)piVar8[2] <= uVar10 - (long)piVar8[3]) goto LAB_101fa6d08;
              *(undefined4 *)
               (*(long *)(*(long *)(param_1 + 0x20) +
                          (uVar10 + ((uVar9 - (long)piVar8[1]) * (long)piVar8[2] - (long)piVar8[3]))
                          * 8 + 0x20) + 0x3c) = 0xffffffff;
            }
            if (param_3 != '\0') {
              piVar8 = *(int **)(*(long *)(param_1 + 0x20) + 0x10);
              uVar5 = _UNK_1036d2728;
              if ((ulong)(long)*piVar8 <= uVar9 - (long)piVar8[1]) goto LAB_101fa6d08;
              uVar5 = _UNK_1036d2730;
              if ((ulong)(long)piVar8[2] <= uVar10 - (long)piVar8[3]) goto LAB_101fa6d08;
              *(undefined4 *)
               (*(long *)(*(long *)(param_1 + 0x20) +
                          (uVar10 + ((uVar9 - (long)piVar8[1]) * (long)piVar8[2] - (long)piVar8[3]))
                          * 8 + 0x20) + 0x40) = 0xffffffff;
            }
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
        if (uVar9 == uVar1) {
          return;
        }
      } while( true );
    }
  }
LAB_101fa6d1c:
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101fa6d28);
  (*pcVar4)();
}

