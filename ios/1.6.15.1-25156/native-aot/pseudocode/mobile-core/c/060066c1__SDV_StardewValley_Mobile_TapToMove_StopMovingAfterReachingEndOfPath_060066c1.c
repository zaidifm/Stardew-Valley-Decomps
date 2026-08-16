/* 0x060066c1 StardewValley.Mobile.TapToMove.StopMovingAfterReachingEndOfPath @ 0x101fc6acc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_StopMovingAfterReachingEndOfPath_060066c1(long param_1)

{
  undefined1 uVar1;
  code *pcVar2;
  char cVar3;
  int iVar4;
  undefined8 *puVar5;
  undefined8 uVar6;
  int iVar7;
  long lVar8;
  int iVar9;
  
  cVar3 = cRam00000001039114d0;
  if (lRam0000000103976fb8 == 0) {
    if (cRam00000001039114d0 == '\0') goto LAB_101fc6dbc;
LAB_101fc6af8:
    lVar8 = *(long *)(param_1 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    if (cVar3 != '\0') goto LAB_101fc6af8;
LAB_101fc6dbc:
    func_0x00010119b908(&UNK_103325720);
    cRam00000001039114d0 = '\x01';
    lVar8 = *(long *)(param_1 + 0x18);
  }
  uVar6 = _UNK_1036d7078;
  if (lVar8 == 0) goto LAB_101fc6e7c;
  SDV_StardewValley_Mobile_MobileKeyStates_SetUp_06006672(lVar8,0);
  SDV_StardewValley_Mobile_MobileKeyStates_SetDown_06006673(lVar8,0);
  SDV_StardewValley_Mobile_MobileKeyStates_SetLeft_06006674(lVar8,0);
  SDV_StardewValley_Mobile_MobileKeyStates_SetRight_06006675(lVar8,0);
  *(undefined4 *)(lVar8 + 0x10) = 0;
  *(undefined1 *)(*(long *)(param_1 + 0x18) + 0x18) = 0;
  iVar7 = (int)*(float *)(param_1 + 0x110);
  iVar9 = (int)*(float *)(param_1 + 0x114);
  cVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_IsTreeAt_060066f7(iVar7,iVar9);
  if ((((((cVar3 == '\0') &&
         (iVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_TreeGrowthStage_060066f4(iVar7,iVar9),
         iVar4 < 1)) &&
        (cVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_IsChoppableBushAtPoint_060066fd
                           (iVar7,iVar9), cVar3 == '\0')) &&
       ((cVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_IsStumpAt_06006703(iVar7,iVar9),
        cVar3 == '\0' &&
        (cVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_IsBoulderAt_06006709(iVar7,iVar9),
        cVar3 == '\0')))) && (*(long *)(param_1 + 0x88) == 0)) ||
     (*(char *)(*(long *)(param_1 + 0x18) + 0x14) == '\0')) {
LAB_101fc6c84:
    lVar8 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    if (*(char *)(*(long *)(lVar8 + 0x530) + 0x68) != '\0') {
      lVar8 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar6 = _UNK_1036d70a8;
      if (lVar8 == 0) {
LAB_101fc6e7c:
        func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101fc6e88);
        (*pcVar2)();
      }
      puVar5 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
      if ((puVar5 == (undefined8 *)0x0) ||
         (lRam00000001038c7ad0 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18))) {
        lVar8 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar6 = _UNK_1036d70b8;
        if (lVar8 == 0) goto LAB_101fc6e7c;
        puVar5 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
        if ((puVar5 == (undefined8 *)0x0) ||
           (lRam00000001038c7a20 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18)))
        goto LAB_101fc6d00;
      }
      lVar8 = *(long *)(param_1 + 0x18);
      if (*(char *)(lVar8 + 0x14) != '\0') goto LAB_101fc6d64;
    }
LAB_101fc6d00:
    lVar8 = *(long *)(param_1 + 0x18);
    uVar1 = *(undefined1 *)(lVar8 + 0x17);
    *(undefined1 *)(lVar8 + 0x15) = 0;
    *(undefined1 *)(lVar8 + 0x17) = 0;
    *(undefined1 *)(lVar8 + 0x16) = uVar1;
    *(undefined4 *)(param_1 + 0x124) = 4;
  }
  else {
    lVar8 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar6 = _UNK_1036d70c0;
    if (lVar8 == 0) goto LAB_101fc6e7c;
    puVar5 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
    if ((puVar5 == (undefined8 *)0x0) ||
       (lRam00000001038c79e0 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18))) {
      lVar8 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar6 = _UNK_1036d70d0;
      if (lVar8 == 0) goto LAB_101fc6e7c;
      puVar5 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
      if ((puVar5 == (undefined8 *)0x0) ||
         (lRam00000001038c7a80 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18))) {
        if (*(long *)(param_1 + 0x40) != 0) {
          uVar6 = _UNK_1036d70d8;
          if (param_1 == -0x110) goto LAB_101fc6e7c;
          lVar8 = SDV_StardewValley_Mobile_TapToMoveUtils_GetTreeAt_060066f8
                            ((int)*(float *)(param_1 + 0x110),(int)*(float *)(param_1 + 0x114));
          if ((((lVar8 != 0) &&
               (puVar5 = (undefined8 *)
                         SDV_StardewValley_Mobile_TapToMoveUtils_GetTreeAt_060066f8
                                   ((int)*(float *)(param_1 + 0x110),
                                    (int)*(float *)(param_1 + 0x114)), puVar5 != (undefined8 *)0x0))
              && (lRam00000001038c7998 == *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x10))) &&
             (*(char *)(puVar5[0x10] + 0x68) != '\0')) {
            lVar8 = StardewValley_StardewValley_Game1_get_player_06002f9a();
            uVar6 = _UNK_1036d70e8;
            if (lVar8 == 0) goto LAB_101fc6e7c;
            puVar5 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
            if ((puVar5 != (undefined8 *)0x0) &&
               (lRam00000001038c7a50 == *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18)))
            goto LAB_101fc6d5c;
          }
        }
        goto LAB_101fc6c84;
      }
    }
LAB_101fc6d5c:
    lVar8 = *(long *)(param_1 + 0x18);
    uVar6 = _UNK_1036d70c8;
    if (lVar8 == 0) goto LAB_101fc6e7c;
LAB_101fc6d64:
    *(undefined2 *)(lVar8 + 0x16) = 0x100;
    *(bool *)(lVar8 + 0x15) = *(char *)(lVar8 + 0x17) == '\0';
    *(undefined4 *)(param_1 + 0x124) = 8;
    if (*(char *)(param_1 + 0xff) == '\0') {
      SDV_StardewValley_Mobile_TapToMove_OnTapRelease_0600669d(param_1,0,0,0,0);
    }
  }
  return;
}

