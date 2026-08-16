/* 0x06006661 StardewValley.Mobile.AStarPath.Bake @ 0x101fae3d8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_AStarPath_Bake_06006661(long param_1)

{
  uint uVar1;
  code *pcVar2;
  char cVar3;
  long lVar4;
  long lVar5;
  long *plVar6;
  undefined8 uVar7;
  long lVar8;
  ulong uVar9;
  ulong uVar10;
  long lVar11;
  undefined1 auVar12 [16];
  
  cVar3 = cRam0000000103911470;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103324e30);
    cRam0000000103911470 = '\x01';
  }
  lVar4 = func_0x000100331820(uRam00000001039045a8,0x20);
  lVar8 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar4 + 0x10) = *puRam00000001039045b0;
  *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar8) = 1;
  lVar8 = *(long *)(param_1 + 0x10);
  *(undefined4 *)(param_1 + 0x18) = 0;
  uVar7 = _UNK_1036d36e0;
  if (lVar8 != 0) {
    uVar9 = 0;
LAB_101fae468:
    do {
      if ((long)(int)*(uint *)(lVar8 + 0x18) <= (long)uVar9) {
        return;
      }
      if (*(uint *)(lVar8 + 0x18) <= uVar9) {
LAB_101fae658:
        func_0x000100331b90();
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101fae660);
        (*pcVar2)();
      }
      uVar7 = _UNK_1036d3698;
      if (*(uint *)(*(long *)(lVar8 + 0x10) + 0x18) <= uVar9) {
LAB_101fae680:
        func_0x0001003316f4(0xcc,uVar7);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101fae68c);
        (*pcVar2)();
      }
      lVar8 = *(long *)(*(long *)(lVar8 + 0x10) + uVar9 * 8 + 0x20);
      uVar7 = _UNK_1036d36a8;
      if ((lVar8 == 0) ||
         (lVar5 = SDV_StardewValley_Mobile_AStarNode_GetNeighbouringNodeList_0600662d(lVar8,1),
         uVar7 = _UNK_1036d36c8, lVar5 == 0)) break;
      uVar10 = 0xffffffffffffffff;
      lVar11 = 0x20;
      while ((long)(uVar10 + 1) < (long)*(int *)(lVar5 + 0x18)) {
        lVar5 = SDV_StardewValley_Mobile_AStarNode_GetNeighbouringNodeList_0600662d(lVar8,1);
        if ((ulong)*(uint *)(lVar5 + 0x18) <= uVar10 + 1) goto LAB_101fae658;
        uVar10 = uVar10 + 1;
        uVar7 = _UNK_1036d36b8;
        if (*(uint *)(*(long *)(lVar5 + 0x10) + 0x18) <= uVar10) goto LAB_101fae680;
        uVar7 = _UNK_1036d36c0;
        if (*(long *)(param_1 + 0x10) == 0) goto LAB_101fae6a0;
        lVar5 = *(long *)(lVar11 + *(long *)(lVar5 + 0x10));
        cVar3 = func_0x00010037d2ac(*(long *)(param_1 + 0x10),lVar5);
        if ((cVar3 != '\0') && (cVar3 = func_0x00010037d2ac(lVar4,lVar5), cVar3 == '\0')) {
          uVar7 = _UNK_1036d36d0;
          if (lVar5 == 0) goto LAB_101fae6a0;
          auVar12._0_8_ =
               (long)((int)*(undefined8 *)(lVar8 + 0x34) - (int)*(undefined8 *)(lVar5 + 0x34));
          auVar12._8_8_ =
               (long)((int)((ulong)*(undefined8 *)(lVar8 + 0x34) >> 0x20) -
                     (int)((ulong)*(undefined8 *)(lVar5 + 0x34) >> 0x20));
          auVar12 = NEON_scvtf(auVar12,8);
          *(float *)(param_1 + 0x18) =
               *(float *)(param_1 + 0x18) +
               (float)(auVar12._0_8_ * auVar12._0_8_ + auVar12._8_8_ * auVar12._8_8_);
        }
        lVar5 = SDV_StardewValley_Mobile_AStarNode_GetNeighbouringNodeList_0600662d(lVar8,1);
        uVar7 = _UNK_1036d36c8;
        if (lRam0000000103976fb8 != 0) {
          func_0x00010119b8f8();
          uVar7 = _UNK_1036d36c8;
        }
        lVar11 = lVar11 + 8;
        _UNK_1036d36c8 = uVar7;
        if (lVar5 == 0) goto LAB_101fae6a0;
      }
      plVar6 = *(long **)(lVar4 + 0x10);
      *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
      uVar7 = _UNK_1036d36d8;
      if (plVar6 == (long *)0x0) break;
      uVar1 = *(uint *)(lVar4 + 0x18);
      if (uVar1 < *(uint *)(plVar6 + 3)) {
        *(uint *)(lVar4 + 0x18) = uVar1 + 1;
        (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,lVar8);
      }
      else {
        func_0x00010037d11c(lVar4,lVar8);
      }
      lVar8 = *(long *)(param_1 + 0x10);
      if (lRam0000000103976fb8 == 0) {
        uVar9 = uVar9 + 1;
        uVar7 = _UNK_1036d36e0;
        if (lVar8 == 0) break;
        goto LAB_101fae468;
      }
      func_0x00010119b8f8();
      uVar9 = uVar9 + 1;
      uVar7 = _UNK_1036d36e0;
    } while (lVar8 != 0);
  }
LAB_101fae6a0:
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fae6ac);
  (*pcVar2)();
}

