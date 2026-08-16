/* 0x060066b2 StardewValley.Mobile.TapToMove.SwitchBackToLastTool @ 0x101fc32c4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_SwitchBackToLastTool_060066b2(long param_1)

{
  undefined4 uVar1;
  undefined1 uVar2;
  code *pcVar3;
  char cVar4;
  int iVar5;
  undefined8 *puVar6;
  ulong uVar7;
  undefined8 uVar8;
  long lVar9;
  int iVar10;
  int iVar11;
  float fVar12;
  
  cVar4 = cRam00000001039114c1;
  if (lRam0000000103976fb8 == 0) {
    if (cRam00000001039114c1 != '\0') goto LAB_101fc32f0;
LAB_101fc34a0:
    func_0x00010119b908(&UNK_103325610);
    cRam00000001039114c1 = '\x01';
    fVar12 = *(float *)(param_1 + 0x110);
  }
  else {
    func_0x00010119b8f8();
    if (cVar4 == '\0') goto LAB_101fc34a0;
LAB_101fc32f0:
    fVar12 = *(float *)(param_1 + 0x110);
  }
  iVar10 = (int)fVar12;
  iVar11 = (int)*(float *)(param_1 + 0x114);
  cVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_IsTreeAt_060066f7(iVar10,iVar11);
  if ((((((cVar4 != '\0') ||
         (iVar5 = SDV_StardewValley_Mobile_TapToMoveUtils_TreeGrowthStage_060066f4(iVar10,iVar11),
         0 < iVar5)) ||
        (cVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_IsChoppableBushAtPoint_060066fd
                           (iVar10,iVar11), cVar4 != '\0')) ||
       ((cVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_IsStumpAt_06006703(iVar10,iVar11),
        cVar4 != '\0' ||
        (cVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_IsBoulderAt_06006709(iVar10,iVar11),
        cVar4 != '\0')))) || (*(long *)(param_1 + 0x88) != 0)) &&
     (*(char *)(*(long *)(param_1 + 0x18) + 0x14) != '\0')) {
    return;
  }
  iVar10 = *(int *)(*(long *)(param_1 + 200) + 0x18);
  uVar7 = (ulong)(iVar10 - 1);
  if (iVar10 < 1) {
    return;
  }
  lVar9 = *(long *)(*(long *)(param_1 + 200) + 0x10);
  if ((ulong)(long)*(int *)(lVar9 + 0x18) <= uVar7) {
    func_0x0001003316f4(0xcc,_UNK_1036d6910);
                    /* WARNING: Does not return */
    pcVar3 = (code *)SoftwareBreakpoint(1,0x101fc3500);
    (*pcVar3)();
  }
  lVar9 = lVar9 + uVar7 * 8;
  uVar1 = *(undefined4 *)(lVar9 + 0x20);
  uVar2 = *(undefined1 *)(lVar9 + 0x24);
  func_0x00010037ddec();
  if (*(int *)(*(long *)(param_1 + 200) + 0x18) != 0) {
    return;
  }
  lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar8 = _UNK_1036d68d8;
  if (lVar9 != 0) {
    StardewValley_StardewValley_Farmer_set_CurrentToolIndex_060035a4(lVar9,uVar1);
    lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar8 = _UNK_1036d68e8;
    if (*(long *)(lVar9 + 0x468) == 0) goto LAB_101fc355c;
    func_0x00010035197c(*(long *)(lVar9 + 0x468),uVar2);
    lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar8 = _UNK_1036d68f0;
    if (lVar9 == 0) goto LAB_101fc355c;
    func_0x00010186367c();
    lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar8 = _UNK_1036d68f8;
    if (lVar9 == 0) goto LAB_101fc355c;
    lVar9 = StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
    if (lVar9 != 0) {
      lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar8 = _UNK_1036d6908;
      if (lVar9 == 0) goto LAB_101fc355c;
      puVar6 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
      if ((puVar6 != (undefined8 *)0x0) &&
         (lRam00000001038c7a00 == *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18)))
      goto LAB_101fc3474;
    }
    lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar8 = _UNK_1036d6900;
    if (lVar9 != 0) {
      puVar6 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
      if (puVar6 == (undefined8 *)0x0) {
        return;
      }
      if (lRam00000001038c7ab0 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18)) {
        return;
      }
LAB_101fc3474:
      SDV_StardewValley_Mobile_TapToMove_Reset_06006698(param_1,1);
      uVar7 = func_0x000100332090();
      *puRam00000001039048c8 = uVar7 & 0x3fffffffffffffff;
      return;
    }
  }
LAB_101fc355c:
  func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fc3568);
  (*pcVar3)();
}

