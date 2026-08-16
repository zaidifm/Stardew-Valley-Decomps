/* 0x060066c7 StardewValley.Mobile.TapToMove.WateringCanActionAtEndNode @ 0x101fc789c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_TapToMove_WateringCanActionAtEndNode_060066c7(long param_1)

{
  code *pcVar1;
  bool bVar2;
  char cVar3;
  long lVar4;
  undefined8 *puVar5;
  undefined8 uVar6;
  int *piVar7;
  long lVar8;
  undefined8 *puStack_38;
  
  cVar3 = cRam00000001039114d6;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103325770);
    cRam00000001039114d6 = '\x01';
  }
  puStack_38 = (undefined8 *)0x0;
  lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar6 = _UNK_1036d7260;
  if (lVar4 == 0) goto LAB_101fc7a70;
  puVar5 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
  if (puVar5 == (undefined8 *)0x0) {
    return false;
  }
  if (lRam00000001038c7ad0 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18)) {
    return false;
  }
  lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar6 = _UNK_1036d7268;
  if ((lVar4 == 0) ||
     (puVar5 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c(),
     uVar6 = _UNK_1036d7278, puVar5 == (undefined8 *)0x0)) goto LAB_101fc7a70;
  if (lRam00000001038c7ad0 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18)) {
    func_0x0001003316f4(0xd3,_UNK_1036d7270);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc7aa8);
    (*pcVar1)();
  }
  if (*(char *)(puVar5[0x23] + 0x68) == '\0') {
    uVar6 = _UNK_1036d72c0;
    if (puVar5[0x24] == 0) goto LAB_101fc7a70;
    piVar7 = (int *)(puVar5[0x24] + 0x68);
  }
  else {
    piVar7 = (int *)((long)puVar5 + 300);
  }
  if (*piVar7 < 1) {
LAB_101fc79cc:
    puVar5 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    if ((puVar5 == (undefined8 *)0x0) ||
       (lRam00000001038c7768 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18))) {
      uVar6 = _UNK_1036d7280;
      if (param_1 == 0) {
LAB_101fc7a70:
        func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc7a7c);
        (*pcVar1)();
      }
    }
    else if ((*(int *)(*(long *)(param_1 + 0x40) + 0x34) == 0x10) &&
            (0xfffffffb < *(int *)(*(long *)(param_1 + 0x40) + 0x38) - 10U)) goto LAB_101fc7a40;
    cVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_IsWateringCanFillingSource_060066ef
                      (*(undefined4 *)(param_1 + 0x110),*(undefined4 *)(param_1 + 0x114));
    bVar2 = cVar3 != '\0';
  }
  else {
    lVar4 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    uVar6 = _UNK_1036d7298;
    if (((lVar4 == 0) || (lVar8 = *(long *)(param_1 + 0x40), uVar6 = _UNK_1036d72a8, lVar8 == 0)) ||
       (uVar6 = _UNK_1036d72b0, *(long *)(lVar4 + 0x120) == 0)) goto LAB_101fc7a70;
    func_0x0001003554a0((float)*(int *)(lVar8 + 0x34),(float)*(int *)(lVar8 + 0x38),
                        *(long *)(lVar4 + 0x120),&puStack_38);
    if (((puStack_38 == (undefined8 *)0x0) ||
        (lRam00000001038c7940 != *(long *)(*(long *)(*(long *)*puStack_38 + 0x10) + 0x10))) ||
       (*(int *)(puStack_38[8] + 0x68) == 1)) goto LAB_101fc79cc;
LAB_101fc7a40:
    bVar2 = true;
  }
  return bVar2;
}

