/* 0x0600662d StardewValley.Mobile.AStarNode.GetNeighbouringNodeList @ 0x101fa7a78 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_Mobile_AStarNode_GetNeighbouringNodeList_0600662d(long param_1,char param_2)

{
  uint uVar1;
  code *pcVar2;
  char cVar3;
  long lVar4;
  long lVar5;
  long *plVar6;
  undefined8 uVar7;
  
  cVar3 = cRam000000010391143c;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103324a40);
    cRam000000010391143c = '\x01';
  }
  lVar4 = func_0x000100331820(uRam00000001039045a8,0x20);
  lVar5 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar4 + 0x10) = *puRam00000001039045b0;
  *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar5) = 1;
  uVar7 = _UNK_1036d28e0;
  if ((param_1 != 0) && (uVar7 = _UNK_1036d28e8, *(long *)(param_1 + 0x18) != 0)) {
    lVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                      (*(long *)(param_1 + 0x18),*(undefined4 *)(param_1 + 0x34),
                       *(int *)(param_1 + 0x38) + -1);
    if ((lVar5 != 0) &&
       (cVar3 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(), cVar3 == param_2)) {
      plVar6 = *(long **)(lVar4 + 0x10);
      *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
      uVar7 = _UNK_1036d2920;
      if (plVar6 == (long *)0x0) goto LAB_101fa7d88;
      uVar1 = *(uint *)(lVar4 + 0x18);
      if (uVar1 < *(uint *)(plVar6 + 3)) {
        *(uint *)(lVar4 + 0x18) = uVar1 + 1;
        (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,lVar5);
      }
      else {
        func_0x00010037d11c(lVar4,lVar5);
      }
    }
    uVar7 = _UNK_1036d28f0;
    if (*(long *)(param_1 + 0x18) != 0) {
      lVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                        (*(long *)(param_1 + 0x18),*(undefined4 *)(param_1 + 0x34),
                         *(int *)(param_1 + 0x38) + 1);
      if ((lVar5 != 0) &&
         (cVar3 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(), cVar3 == param_2)) {
        plVar6 = *(long **)(lVar4 + 0x10);
        *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
        uVar7 = _UNK_1036d2918;
        if (plVar6 == (long *)0x0) goto LAB_101fa7d88;
        uVar1 = *(uint *)(lVar4 + 0x18);
        if (uVar1 < *(uint *)(plVar6 + 3)) {
          *(uint *)(lVar4 + 0x18) = uVar1 + 1;
          (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,lVar5);
        }
        else {
          func_0x00010037d11c(lVar4,lVar5);
        }
      }
      uVar7 = _UNK_1036d28f8;
      if (*(long *)(param_1 + 0x18) != 0) {
        lVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                          (*(long *)(param_1 + 0x18),*(int *)(param_1 + 0x34) + -1,
                           *(undefined4 *)(param_1 + 0x38));
        if ((lVar5 != 0) &&
           (cVar3 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(), cVar3 == param_2))
        {
          plVar6 = *(long **)(lVar4 + 0x10);
          *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
          uVar7 = _UNK_1036d2910;
          if (plVar6 == (long *)0x0) goto LAB_101fa7d88;
          uVar1 = *(uint *)(lVar4 + 0x18);
          if (uVar1 < *(uint *)(plVar6 + 3)) {
            *(uint *)(lVar4 + 0x18) = uVar1 + 1;
            (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,lVar5);
          }
          else {
            func_0x00010037d11c(lVar4,lVar5);
          }
        }
        uVar7 = _UNK_1036d2900;
        if (*(long *)(param_1 + 0x18) != 0) {
          lVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                            (*(long *)(param_1 + 0x18),*(int *)(param_1 + 0x34) + 1,
                             *(undefined4 *)(param_1 + 0x38));
          if ((lVar5 != 0) &&
             (cVar3 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(), cVar3 == param_2)
             ) {
            plVar6 = *(long **)(lVar4 + 0x10);
            *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
            uVar7 = _UNK_1036d2908;
            if (plVar6 == (long *)0x0) goto LAB_101fa7d88;
            uVar1 = *(uint *)(lVar4 + 0x18);
            if (uVar1 < *(uint *)(plVar6 + 3)) {
              *(uint *)(lVar4 + 0x18) = uVar1 + 1;
              (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,lVar5);
            }
            else {
              func_0x00010037d11c(lVar4,lVar5);
            }
          }
          return lVar4;
        }
      }
    }
  }
LAB_101fa7d88:
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fa7d94);
  (*pcVar2)();
}

