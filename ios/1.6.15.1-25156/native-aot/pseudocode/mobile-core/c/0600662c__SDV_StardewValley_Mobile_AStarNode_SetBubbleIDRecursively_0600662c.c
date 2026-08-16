/* 0x0600662c StardewValley.Mobile.AStarNode.SetBubbleIDRecursively @ 0x101fa78ac */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_AStarNode_SetBubbleIDRecursively_0600662c
          (long param_1,undefined4 param_2,uint param_3)

{
  long lVar1;
  code *pcVar2;
  char cVar3;
  long lVar4;
  undefined8 uVar5;
  long *plVar6;
  ulong uVar7;
  
  if (lRam0000000103976fb8 == 0) {
    cVar3 = *(char *)(param_1 + 0x44);
  }
  else {
    func_0x00010119b8f8();
    cVar3 = *(char *)(param_1 + 0x44);
  }
  if ((cVar3 != '\0') ||
     ((*(undefined1 *)(param_1 + 0x44) = 1, *(int *)(param_1 + 0x3c) != 0 &&
      (cVar3 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(param_1), cVar3 == '\0'))))
  {
    return 0;
  }
  lVar1 = 0x3c;
  if ((param_3 & 0xff) != 0) {
    lVar1 = 0x40;
  }
  *(undefined4 *)(param_1 + lVar1) = param_2;
  uVar5 = _UNK_1036d28c0;
  if (*(long *)(param_1 + 0x18) != 0) {
    lVar4 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                      (*(long *)(param_1 + 0x18),*(undefined4 *)(param_1 + 0x34),
                       *(int *)(param_1 + 0x38) + -1);
    lVar1 = lRam00000001038c4be0;
    DataMemoryBarrier(2,3);
    plVar6 = (long *)(param_1 + 0x20);
    *plVar6 = lVar4;
    uVar7 = (ulong)plVar6 >> 9 & 0x7fffff;
    *(undefined1 *)(uVar7 + lVar1) = 1;
    if (*plVar6 != 0) {
      SDV_StardewValley_Mobile_AStarNode_SetBubbleIDRecursively_0600662c(*plVar6,param_2,param_3);
    }
    uVar5 = _UNK_1036d28c8;
    if (*(long *)(param_1 + 0x18) != 0) {
      uVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                        (*(long *)(param_1 + 0x18),*(undefined4 *)(param_1 + 0x34),
                         *(int *)(param_1 + 0x38) + 1);
      DataMemoryBarrier(2,3);
      *(undefined8 *)(param_1 + 0x20) = uVar5;
      *(undefined1 *)(lVar1 + uVar7) = 1;
      if (*(long *)(param_1 + 0x20) != 0) {
        SDV_StardewValley_Mobile_AStarNode_SetBubbleIDRecursively_0600662c
                  (*(long *)(param_1 + 0x20),param_2,param_3);
      }
      uVar5 = _UNK_1036d28d0;
      if (*(long *)(param_1 + 0x18) != 0) {
        uVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                          (*(long *)(param_1 + 0x18),*(int *)(param_1 + 0x34) + -1,
                           *(undefined4 *)(param_1 + 0x38));
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 0x20) = uVar5;
        *(undefined1 *)(lVar1 + uVar7) = 1;
        if (*(long *)(param_1 + 0x20) != 0) {
          SDV_StardewValley_Mobile_AStarNode_SetBubbleIDRecursively_0600662c
                    (*(long *)(param_1 + 0x20),param_2,param_3);
        }
        uVar5 = _UNK_1036d28d8;
        if (*(long *)(param_1 + 0x18) != 0) {
          uVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                            (*(long *)(param_1 + 0x18),*(int *)(param_1 + 0x34) + 1,
                             *(undefined4 *)(param_1 + 0x38));
          DataMemoryBarrier(2,3);
          *(undefined8 *)(param_1 + 0x20) = uVar5;
          *(undefined1 *)(lVar1 + uVar7) = 1;
          if (*(long *)(param_1 + 0x20) != 0) {
            SDV_StardewValley_Mobile_AStarNode_SetBubbleIDRecursively_0600662c
                      (*(long *)(param_1 + 0x20),param_2,param_3);
          }
          *(undefined8 *)(param_1 + 0x20) = 0;
          return 1;
        }
      }
    }
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fa7a78);
  (*pcVar2)();
}

