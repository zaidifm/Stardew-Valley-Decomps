/* 0x0600670b StardewValley.Mobile.TapToMoveUtils.FetchMostAccessibleNodeToCrabPot @ 0x101fce1d0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_Mobile_TapToMoveUtils_FetchMostAccessibleNodeToCrabPot_0600670b
               (long param_1,long param_2)

{
  int iVar1;
  int iVar2;
  code *pcVar3;
  char cVar4;
  long lVar5;
  undefined8 uVar6;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar6 = _UNK_1036d7da8;
  if (param_2 != 0) {
    iVar1 = *(int *)(param_2 + 0x34);
    iVar2 = *(int *)(param_2 + 0x38);
    lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    uVar6 = _UNK_1036d7db0;
    if (lVar5 != 0) {
      iVar2 = iVar2 + -1;
      cVar4 = func_0x00010191e0c4(lVar5,CONCAT44(iVar2,iVar1));
      uVar6 = _UNK_1036d7e28;
      if (cVar4 != '\0') {
        iVar1 = *(int *)(param_2 + 0x34);
        iVar2 = *(int *)(param_2 + 0x38);
        lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
        uVar6 = _UNK_1036d7db8;
        if (lVar5 == 0) goto LAB_101fce430;
        iVar2 = iVar2 + 1;
        cVar4 = func_0x00010191e0c4(lVar5,CONCAT44(iVar2,iVar1));
        uVar6 = _UNK_1036d7e20;
        if (cVar4 != '\0') {
          iVar1 = *(int *)(param_2 + 0x34);
          iVar2 = *(int *)(param_2 + 0x38);
          lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
          uVar6 = _UNK_1036d7dc0;
          if (lVar5 == 0) goto LAB_101fce430;
          iVar1 = iVar1 + -1;
          cVar4 = func_0x00010191e0c4(lVar5,CONCAT44(iVar2,iVar1));
          uVar6 = _UNK_1036d7e18;
          if (cVar4 != '\0') {
            iVar1 = *(int *)(param_2 + 0x34);
            iVar2 = *(int *)(param_2 + 0x38);
            lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
            uVar6 = _UNK_1036d7dc8;
            if (lVar5 == 0) goto LAB_101fce430;
            iVar1 = iVar1 + 1;
            cVar4 = func_0x00010191e0c4(lVar5,CONCAT44(iVar2,iVar1));
            uVar6 = _UNK_1036d7e10;
            if (cVar4 != '\0') {
              iVar1 = *(int *)(param_2 + 0x34);
              iVar2 = *(int *)(param_2 + 0x38);
              lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
              uVar6 = _UNK_1036d7dd0;
              if (lVar5 == 0) goto LAB_101fce430;
              iVar2 = iVar2 + -1;
              iVar1 = iVar1 + -1;
              cVar4 = func_0x00010191e0c4(lVar5,CONCAT44(iVar2,iVar1));
              uVar6 = _UNK_1036d7e08;
              if (cVar4 != '\0') {
                iVar1 = *(int *)(param_2 + 0x34);
                iVar2 = *(int *)(param_2 + 0x38);
                lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
                uVar6 = _UNK_1036d7dd8;
                if (lVar5 == 0) goto LAB_101fce430;
                iVar2 = iVar2 + -1;
                iVar1 = iVar1 + 1;
                cVar4 = func_0x00010191e0c4(lVar5,CONCAT44(iVar2,iVar1));
                uVar6 = _UNK_1036d7e00;
                if (cVar4 != '\0') {
                  iVar1 = *(int *)(param_2 + 0x34);
                  iVar2 = *(int *)(param_2 + 0x38);
                  lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
                  uVar6 = _UNK_1036d7de0;
                  if (lVar5 == 0) goto LAB_101fce430;
                  iVar2 = iVar2 + 1;
                  iVar1 = iVar1 + -1;
                  cVar4 = func_0x00010191e0c4(lVar5,CONCAT44(iVar2,iVar1));
                  uVar6 = _UNK_1036d7df8;
                  if (cVar4 != '\0') {
                    iVar1 = *(int *)(param_2 + 0x34);
                    iVar2 = *(int *)(param_2 + 0x38);
                    lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
                    uVar6 = _UNK_1036d7de8;
                    if (lVar5 == 0) goto LAB_101fce430;
                    iVar2 = iVar2 + 1;
                    iVar1 = iVar1 + -1;
                    cVar4 = func_0x00010191e0c4(lVar5,CONCAT44(iVar2,iVar1));
                    uVar6 = _UNK_1036d7df0;
                    if (cVar4 != '\0') {
                      return param_2;
                    }
                  }
                }
              }
            }
          }
        }
      }
      if (param_1 != 0) {
        lVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc(param_1,iVar1,iVar2);
        return lVar5;
      }
    }
  }
LAB_101fce430:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fce43c);
  (*pcVar3)();
}

