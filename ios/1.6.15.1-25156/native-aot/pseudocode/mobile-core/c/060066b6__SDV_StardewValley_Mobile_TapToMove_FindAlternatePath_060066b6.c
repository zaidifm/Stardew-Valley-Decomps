/* 0x060066b6 StardewValley.Mobile.TapToMove.FindAlternatePath @ 0x101fc3790 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined4
SDV_StardewValley_Mobile_TapToMove_FindAlternatePath_060066b6
          (long param_1,long param_2,undefined4 param_3,undefined4 param_4)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  long lVar4;
  long *plVar5;
  undefined8 uVar6;
  ulong uVar7;
  
  if (lRam0000000103976fb8 == 0) {
    lVar3 = *(long *)(param_1 + 0x28);
  }
  else {
    func_0x00010119b8f8();
    lVar3 = *(long *)(param_1 + 0x28);
  }
  uVar6 = _UNK_1036d6958;
  if (lVar3 != 0) {
    lVar3 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc(lVar3,param_3,param_4);
    if (((param_2 == 0) || (lVar3 == 0)) ||
       (cVar2 = SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(lVar3), cVar2 == '\0')) {
      return 0;
    }
    uVar6 = _UNK_1036d6960;
    if (*(long *)(param_1 + 0x28) != 0) {
      lVar4 = SDV_StardewValley_Mobile_AStarGraph_GetShortestPathAStar_06006603
                        (*(long *)(param_1 + 0x28),param_2,lVar3);
      lVar3 = lRam00000001038c4be0;
      DataMemoryBarrier(2,3);
      plVar5 = (long *)(param_1 + 0x30);
      *plVar5 = lVar4;
      uVar7 = (ulong)plVar5 >> 9 & 0x7fffff;
      *(undefined1 *)(uVar7 + lVar3) = 1;
      if ((long *)*plVar5 == (long *)0x0) {
        return 0;
      }
      lVar4 = (**(code **)(*(long *)*plVar5 + 0x88))();
      if (lVar4 == 0) {
        return 0;
      }
      uVar6 = _UNK_1036d6968;
      if (*(long *)(param_1 + 0x28) != 0) {
        uVar6 = *(undefined8 *)(param_1 + 0x30);
        SDV_StardewValley_Mobile_AStarGraph_SmoothRightAngles_06006605
                  (*(long *)(param_1 + 0x28),uVar6,1);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 0x30) = uVar6;
        *(undefined1 *)(lVar3 + uVar7) = 1;
        *(undefined4 *)(param_1 + 0x124) = 1;
        return 1;
      }
    }
  }
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc38d0);
  (*pcVar1)();
}

