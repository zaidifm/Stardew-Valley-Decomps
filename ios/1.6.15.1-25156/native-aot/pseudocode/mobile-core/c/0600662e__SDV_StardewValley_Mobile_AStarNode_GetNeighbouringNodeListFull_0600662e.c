/* 0x0600662e StardewValley.Mobile.AStarNode.GetNeighbouringNodeListFull @ 0x101fa7d94 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_Mobile_AStarNode_GetNeighbouringNodeListFull_0600662e
               (long param_1,char param_2)

{
  uint uVar1;
  code *pcVar2;
  char cVar3;
  long lVar4;
  long lVar5;
  long *plVar6;
  undefined8 uVar7;
  
  cVar3 = cRam000000010391143d;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103324a60);
    cRam000000010391143d = '\x01';
  }
  lVar4 = func_0x000100331820(uRam00000001039045a8,0x20);
  lVar5 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar4 + 0x10) = *puRam00000001039045b0;
  *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar5) = 1;
  uVar7 = _UNK_1036d2928;
  if ((param_1 != 0) && (uVar7 = _UNK_1036d2930, *(long *)(param_1 + 0x18) != 0)) {
    lVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                      (*(long *)(param_1 + 0x18),*(undefined4 *)(param_1 + 0x34),
                       *(int *)(param_1 + 0x38) + -1);
    if ((lVar5 != 0) &&
       (cVar3 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(), cVar3 == param_2)) {
      plVar6 = *(long **)(lVar4 + 0x10);
      *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
      uVar7 = _UNK_1036d29a8;
      if (plVar6 == (long *)0x0) goto LAB_101fa8314;
      uVar1 = *(uint *)(lVar4 + 0x18);
      if (uVar1 < *(uint *)(plVar6 + 3)) {
        *(uint *)(lVar4 + 0x18) = uVar1 + 1;
        (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,lVar5);
      }
      else {
        func_0x00010037d11c(lVar4,lVar5);
      }
    }
    uVar7 = _UNK_1036d2938;
    if (*(long *)(param_1 + 0x18) != 0) {
      lVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                        (*(long *)(param_1 + 0x18),*(undefined4 *)(param_1 + 0x34),
                         *(int *)(param_1 + 0x38) + 1);
      if ((lVar5 != 0) &&
         (cVar3 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(), cVar3 == param_2)) {
        plVar6 = *(long **)(lVar4 + 0x10);
        *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
        uVar7 = _UNK_1036d29a0;
        if (plVar6 == (long *)0x0) goto LAB_101fa8314;
        uVar1 = *(uint *)(lVar4 + 0x18);
        if (uVar1 < *(uint *)(plVar6 + 3)) {
          *(uint *)(lVar4 + 0x18) = uVar1 + 1;
          (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,lVar5);
        }
        else {
          func_0x00010037d11c(lVar4,lVar5);
        }
      }
      uVar7 = _UNK_1036d2940;
      if (*(long *)(param_1 + 0x18) != 0) {
        lVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                          (*(long *)(param_1 + 0x18),*(int *)(param_1 + 0x34) + -1,
                           *(undefined4 *)(param_1 + 0x38));
        if ((lVar5 != 0) &&
           (cVar3 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(), cVar3 == param_2))
        {
          plVar6 = *(long **)(lVar4 + 0x10);
          *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
          uVar7 = _UNK_1036d2998;
          if (plVar6 == (long *)0x0) goto LAB_101fa8314;
          uVar1 = *(uint *)(lVar4 + 0x18);
          if (uVar1 < *(uint *)(plVar6 + 3)) {
            *(uint *)(lVar4 + 0x18) = uVar1 + 1;
            (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,lVar5);
          }
          else {
            func_0x00010037d11c(lVar4,lVar5);
          }
        }
        uVar7 = _UNK_1036d2948;
        if (*(long *)(param_1 + 0x18) != 0) {
          lVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                            (*(long *)(param_1 + 0x18),*(int *)(param_1 + 0x34) + 1,
                             *(undefined4 *)(param_1 + 0x38));
          if ((lVar5 != 0) &&
             (cVar3 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(), cVar3 == param_2)
             ) {
            plVar6 = *(long **)(lVar4 + 0x10);
            *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
            uVar7 = _UNK_1036d2990;
            if (plVar6 == (long *)0x0) goto LAB_101fa8314;
            uVar1 = *(uint *)(lVar4 + 0x18);
            if (uVar1 < *(uint *)(plVar6 + 3)) {
              *(uint *)(lVar4 + 0x18) = uVar1 + 1;
              (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,lVar5);
            }
            else {
              func_0x00010037d11c(lVar4,lVar5);
            }
          }
          uVar7 = _UNK_1036d2950;
          if (*(long *)(param_1 + 0x18) != 0) {
            lVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                              (*(long *)(param_1 + 0x18),*(int *)(param_1 + 0x34) + -1,
                               *(int *)(param_1 + 0x38) + -1);
            if ((lVar5 != 0) &&
               (cVar3 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(),
               cVar3 == param_2)) {
              plVar6 = *(long **)(lVar4 + 0x10);
              *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
              uVar7 = _UNK_1036d2988;
              if (plVar6 == (long *)0x0) goto LAB_101fa8314;
              uVar1 = *(uint *)(lVar4 + 0x18);
              if (uVar1 < *(uint *)(plVar6 + 3)) {
                *(uint *)(lVar4 + 0x18) = uVar1 + 1;
                (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,lVar5);
              }
              else {
                func_0x00010037d11c(lVar4,lVar5);
              }
            }
            uVar7 = _UNK_1036d2958;
            if (*(long *)(param_1 + 0x18) != 0) {
              lVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                                (*(long *)(param_1 + 0x18),*(int *)(param_1 + 0x34) + 1,
                                 *(int *)(param_1 + 0x38) + -1);
              if ((lVar5 != 0) &&
                 (cVar3 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(),
                 cVar3 == param_2)) {
                plVar6 = *(long **)(lVar4 + 0x10);
                *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
                uVar7 = _UNK_1036d2980;
                if (plVar6 == (long *)0x0) goto LAB_101fa8314;
                uVar1 = *(uint *)(lVar4 + 0x18);
                if (uVar1 < *(uint *)(plVar6 + 3)) {
                  *(uint *)(lVar4 + 0x18) = uVar1 + 1;
                  (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,lVar5);
                }
                else {
                  func_0x00010037d11c(lVar4,lVar5);
                }
              }
              uVar7 = _UNK_1036d2960;
              if (*(long *)(param_1 + 0x18) != 0) {
                lVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                                  (*(long *)(param_1 + 0x18),*(int *)(param_1 + 0x34) + -1,
                                   *(int *)(param_1 + 0x38) + 1);
                if ((lVar5 != 0) &&
                   (cVar3 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(),
                   cVar3 == param_2)) {
                  plVar6 = *(long **)(lVar4 + 0x10);
                  *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
                  uVar7 = _UNK_1036d2978;
                  if (plVar6 == (long *)0x0) goto LAB_101fa8314;
                  uVar1 = *(uint *)(lVar4 + 0x18);
                  if (uVar1 < *(uint *)(plVar6 + 3)) {
                    *(uint *)(lVar4 + 0x18) = uVar1 + 1;
                    (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,lVar5);
                  }
                  else {
                    func_0x00010037d11c(lVar4,lVar5);
                  }
                }
                uVar7 = _UNK_1036d2968;
                if (*(long *)(param_1 + 0x18) != 0) {
                  lVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                                    (*(long *)(param_1 + 0x18),*(int *)(param_1 + 0x34) + 1,
                                     *(int *)(param_1 + 0x38) + 1);
                  if ((lVar5 != 0) &&
                     (cVar3 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(),
                     cVar3 == param_2)) {
                    plVar6 = *(long **)(lVar4 + 0x10);
                    *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
                    uVar7 = _UNK_1036d2970;
                    if (plVar6 == (long *)0x0) goto LAB_101fa8314;
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
        }
      }
    }
  }
LAB_101fa8314:
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fa8320);
  (*pcVar2)();
}

