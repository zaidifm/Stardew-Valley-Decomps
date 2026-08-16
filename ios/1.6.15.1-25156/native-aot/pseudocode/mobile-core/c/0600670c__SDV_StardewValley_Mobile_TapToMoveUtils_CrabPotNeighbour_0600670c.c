/* 0x0600670c StardewValley.Mobile.TapToMoveUtils.CrabPotNeighbour @ 0x101fce43c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Mobile_TapToMoveUtils_CrabPotNeighbour_0600670c(long param_1)

{
  code *pcVar1;
  long lVar2;
  long lVar3;
  undefined8 uVar4;
  long lVar5;
  uint uVar6;
  uint uVar7;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar4 = _UNK_1036d7e30;
  if ((param_1 != 0) &&
     (lVar2 = SDV_StardewValley_Mobile_AStarNode_GetNeighbouringNodeListFull_0600662e(param_1,0),
     uVar4 = _UNK_1036d7e38, lVar2 != 0)) {
    uVar7 = *(uint *)(lVar2 + 0x18);
    if (0 < (int)uVar7) {
      uVar6 = 0;
      lVar5 = 0x20;
      do {
        if (uVar7 <= uVar6) {
LAB_101fce53c:
          func_0x000100331b90();
                    /* WARNING: Does not return */
          pcVar1 = (code *)SoftwareBreakpoint(1,0x101fce544);
          (*pcVar1)();
        }
        uVar4 = _UNK_1036d7e48;
        if (*(uint *)(*(long *)(lVar2 + 0x10) + 0x18) <= uVar6) {
LAB_101fce54c:
          func_0x0001003316f4(0xcc,uVar4);
                    /* WARNING: Does not return */
          pcVar1 = (code *)SoftwareBreakpoint(1,0x101fce558);
          (*pcVar1)();
        }
        uVar4 = _UNK_1036d7e50;
        if (*(long *)(lVar5 + *(long *)(lVar2 + 0x10)) == 0) goto LAB_101fce578;
        lVar3 = SDV_StardewValley_Mobile_AStarNode_FetchObject_06006640();
        if ((lVar3 != 0) && (*(int *)(*(long *)(lVar3 + 0x58) + 0x68) == 0x2c6)) {
          if (*(uint *)(lVar2 + 0x18) <= uVar6) goto LAB_101fce53c;
          uVar4 = _UNK_1036d7e68;
          if (uVar6 < *(uint *)(*(long *)(lVar2 + 0x10) + 0x18)) {
            return *(undefined8 *)(*(long *)(lVar2 + 0x10) + lVar5);
          }
          goto LAB_101fce54c;
        }
        uVar7 = *(uint *)(lVar2 + 0x18);
        if (lRam0000000103976fb8 != 0) {
          func_0x00010119b8f8();
        }
        uVar6 = uVar6 + 1;
        lVar5 = lVar5 + 8;
      } while ((int)uVar6 < (int)uVar7);
    }
    return 0;
  }
LAB_101fce578:
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fce584);
  (*pcVar1)();
}

