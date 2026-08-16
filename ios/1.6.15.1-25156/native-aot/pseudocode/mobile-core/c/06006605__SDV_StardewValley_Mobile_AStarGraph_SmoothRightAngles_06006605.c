/* 0x06006605 StardewValley.Mobile.AStarGraph.SmoothRightAngles @ 0x101fa3124 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long * SDV_StardewValley_Mobile_AStarGraph_SmoothRightAngles_06006605
                 (undefined8 param_1,long *param_2,uint param_3)

{
  uint uVar1;
  char cVar2;
  code *pcVar3;
  int iVar4;
  long lVar5;
  long lVar6;
  long lVar7;
  undefined8 uVar8;
  undefined8 uVar9;
  int iVar10;
  
  cVar2 = cRam0000000103911414;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103324a00);
    cRam0000000103911414 = '\x01';
  }
  lVar5 = func_0x000100331820(uRam00000001038ce878,0x20);
  lVar6 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar5 + 0x10) = *puRam00000001038ce880;
  *(undefined1 *)(((ulong)(lVar5 + 0x10) >> 9 & 0x7fffff) + lVar6) = 1;
  uVar8 = _UNK_1036d19d0;
  if ((param_2 != (long *)0x0) &&
     (lVar6 = (**(code **)(*param_2 + 0x88))(param_2), uVar8 = _UNK_1036d19c8, lVar6 != 0)) {
    iVar10 = 0;
    lVar7 = lVar6;
LAB_101fa31c4:
    do {
      if ((int)(*(int *)(lVar6 + 0x18) + ~param_3) <= iVar10) {
        if (0 < *(int *)(lVar5 + 0x18)) {
          uVar8 = (**(code **)(*param_2 + 0x88))(param_2);
          uVar9 = func_0x000100331820(uRam00000001039045a8,0x20);
          func_0x00010037d310(uVar9,uVar8);
          uVar1 = *(uint *)(lVar5 + 0x18);
          while (uVar1 = uVar1 - 1, -1 < (int)uVar1) {
            if (*(uint *)(lVar5 + 0x18) <= uVar1) {
              func_0x000100331b90();
                    /* WARNING: Does not return */
              pcVar3 = (code *)SoftwareBreakpoint(1,0x101fa3384);
              (*pcVar3)();
            }
            uVar8 = _UNK_1036d19f0;
            if ((ulong)(long)*(int *)(*(long *)(lVar5 + 0x10) + 0x18) <= (ulong)uVar1) {
LAB_101fa33ac:
              func_0x0001003316f4(0xcc,uVar8);
                    /* WARNING: Does not return */
              pcVar3 = (code *)SoftwareBreakpoint(1,0x101fa33b8);
              (*pcVar3)();
            }
            func_0x00010037d324(uVar9,*(undefined4 *)
                                       (*(long *)(lVar5 + 0x10) + (ulong)uVar1 * 4 + 0x20));
            if (lRam0000000103976fb8 != 0) {
              func_0x00010119b8f8();
            }
          }
          (**(code **)(*param_2 + 0x80))(param_2,uVar9);
        }
        return param_2;
      }
      iVar4 = SDV_StardewValley_Mobile_AStarGraph_DiagonalWalkDirection_06006614
                        (lVar7,param_2,iVar10);
      if (iVar4 != 0) {
        lVar6 = *(long *)(lVar5 + 0x10);
        *(int *)(lVar5 + 0x1c) = *(int *)(lVar5 + 0x1c) + 1;
        uVar8 = _UNK_1036d19d8;
        if (lVar6 == 0) break;
        uVar1 = *(uint *)(lVar5 + 0x18);
        iVar10 = iVar10 + 1;
        if (uVar1 < *(uint *)(lVar6 + 0x18)) {
          *(uint *)(lVar5 + 0x18) = uVar1 + 1;
          uVar8 = _UNK_1036d19e0;
          if (*(uint *)(lVar6 + 0x18) <= uVar1) goto LAB_101fa33ac;
          *(int *)(lVar6 + (long)(int)uVar1 * 4 + 0x20) = iVar10;
        }
        else {
          func_0x000100346bd0(lVar5,iVar10);
        }
      }
      lVar6 = (**(code **)(*param_2 + 0x88))(param_2);
      if (lRam0000000103976fb8 == 0) {
        iVar10 = iVar10 + 1;
        lVar7 = lVar6;
        uVar8 = _UNK_1036d19c8;
        if (lVar6 == 0) break;
        goto LAB_101fa31c4;
      }
      lVar7 = func_0x00010119b8f8();
      iVar10 = iVar10 + 1;
      uVar8 = _UNK_1036d19c8;
    } while (lVar6 != 0);
  }
  func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fa3398);
  (*pcVar3)();
}

