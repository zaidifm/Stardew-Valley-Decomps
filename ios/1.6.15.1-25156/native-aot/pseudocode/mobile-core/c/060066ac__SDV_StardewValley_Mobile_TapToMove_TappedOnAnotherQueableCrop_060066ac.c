/* 0x060066ac StardewValley.Mobile.TapToMove.TappedOnAnotherQueableCrop @ 0x101fb9a54 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_TapToMove_TappedOnAnotherQueableCrop_060066ac
               (long param_1,int param_2,int param_3)

{
  int iVar1;
  int iVar2;
  code *pcVar3;
  char cVar4;
  long lVar5;
  long lVar6;
  undefined8 uVar7;
  undefined8 *puVar8;
  undefined8 *puVar9;
  long *plVar10;
  int *piVar11;
  undefined8 *puStack_48;
  
  cVar4 = cRam00000001039114bb;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103325400);
    cRam00000001039114bb = '\x01';
  }
  puStack_48 = (undefined8 *)0x0;
  uVar7 = _UNK_1036d46c0;
  if (*(long *)(param_1 + 0x28) == 0) goto LAB_101fb9e2c;
  iVar1 = param_2 + 0x3f;
  if (-1 < param_2) {
    iVar1 = param_2;
  }
  iVar2 = param_3 + 0x3f;
  if (-1 < param_3) {
    iVar2 = param_3;
  }
  lVar5 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                    (*(long *)(param_1 + 0x28),iVar1 >> 6,iVar2 >> 6);
  if (lVar5 == 0) {
    return false;
  }
  lVar6 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
  uVar7 = _UNK_1036d46d0;
  if (*(long *)(lVar6 + 0x120) == 0) goto LAB_101fb9e2c;
  func_0x0001003554a0((float)*(int *)(lVar5 + 0x34),(float)*(int *)(lVar5 + 0x38),
                      *(long *)(lVar6 + 0x120),&puStack_48);
  puVar8 = puStack_48;
  if ((puStack_48 != (undefined8 *)0x0) &&
     (lRam00000001038c7940 == *(long *)(*(long *)(*(long *)*puStack_48 + 0x10) + 0x10))) {
    if (*(int *)(puStack_48[8] + 0x68) != 1) {
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar7 = _UNK_1036d4788;
      if (lVar5 == 0) goto LAB_101fb9e2c;
      puVar9 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
      if ((puVar9 != (undefined8 *)0x0) &&
         (lRam00000001038c7ad0 == *(long *)(*(long *)(*(long *)*puVar9 + 0x10) + 0x18))) {
        lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar7 = _UNK_1036d4790;
        if ((lVar5 == 0) ||
           (puVar9 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c(),
           uVar7 = _UNK_1036d47a0, puVar9 == (undefined8 *)0x0)) goto LAB_101fb9e2c;
        uVar7 = _UNK_1036d4798;
        if (lRam00000001038c7ad0 != *(long *)(*(long *)(*(long *)*puVar9 + 0x10) + 0x18))
        goto LAB_101fb9f48;
        if (*(char *)(puVar9[0x23] + 0x68) == '\0') {
          uVar7 = _UNK_1036d47a8;
          if (puVar9[0x24] == 0) goto LAB_101fb9e2c;
          piVar11 = (int *)(puVar9[0x24] + 0x68);
        }
        else {
          piVar11 = (int *)((long)puVar9 + 300);
        }
        if (0 < *piVar11) {
          return true;
        }
      }
    }
    if (*(int *)(puVar8[8] + 0x68) != 1) {
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar7 = _UNK_1036d4748;
      if (lVar5 == 0) goto LAB_101fb9e2c;
      puVar9 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
      if ((puVar9 != (undefined8 *)0x0) &&
         (lRam00000001038c7ad0 == *(long *)(*(long *)(*(long *)*puVar9 + 0x10) + 0x18))) {
        lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar7 = _UNK_1036d4750;
        if ((lVar5 == 0) ||
           (puVar9 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c(),
           uVar7 = _UNK_1036d4760, puVar9 == (undefined8 *)0x0)) goto LAB_101fb9e2c;
        uVar7 = _UNK_1036d4758;
        if (lRam00000001038c7ad0 != *(long *)(*(long *)(*(long *)*puVar9 + 0x10) + 0x18))
        goto LAB_101fb9f48;
        if (*(char *)(puVar9[0x23] + 0x68) == '\0') {
          uVar7 = _UNK_1036d4778;
          if (puVar9[0x24] == 0) goto LAB_101fb9e2c;
          piVar11 = (int *)(puVar9[0x24] + 0x68);
        }
        else {
          piVar11 = (int *)((long)puVar9 + 300);
        }
        if (*piVar11 < 1) {
          lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          uVar7 = _UNK_1036d4768;
          if (lVar5 == 0) goto LAB_101fb9e2c;
          func_0x0001018693b0(lVar5,4);
          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
            func_0x0001003319b0();
          }
          plVar10 = (long *)*plRam00000001038d5338;
          uVar7 = _UNK_1036d4770;
          if (plVar10 == (long *)0x0) goto LAB_101fb9e2c;
          uVar7 = (**(code **)(*plVar10 + 0x100))(plVar10,uRam00000001038f0f78);
          func_0x00010171ab70(uVar7,1);
        }
      }
    }
    if (*(long *)(puVar8[7] + 0x60) != 0) {
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar7 = _UNK_1036d4700;
      if (lVar5 == 0) goto LAB_101fb9e2c;
      puVar9 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
      if ((puVar9 != (undefined8 *)0x0) &&
         (lRam00000001038c7ad0 == *(long *)(*(long *)(*(long *)*puVar9 + 0x10) + 0x18))) {
        lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar7 = _UNK_1036d4720;
        if ((lVar5 == 0) ||
           (puVar9 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c(),
           uVar7 = _UNK_1036d4730, puVar9 == (undefined8 *)0x0)) goto LAB_101fb9e2c;
        uVar7 = _UNK_1036d4728;
        if (lRam00000001038c7ad0 != *(long *)(*(long *)(*(long *)*puVar9 + 0x10) + 0x18)) {
LAB_101fb9f48:
          func_0x0001003316f4(0xd3,uVar7);
                    /* WARNING: Does not return */
          pcVar3 = (code *)SoftwareBreakpoint(1,0x101fb9f54);
          (*pcVar3)();
        }
        if (*(char *)(puVar9[0x23] + 0x68) == '\0') {
          uVar7 = _UNK_1036d4738;
          if (puVar9[0x24] == 0) goto LAB_101fb9e2c;
          piVar11 = (int *)(puVar9[0x24] + 0x68);
        }
        else {
          piVar11 = (int *)((long)puVar9 + 300);
        }
        if (0 < *piVar11) {
          return true;
        }
      }
      if (*(char *)(*(long *)(*(long *)(puVar8[7] + 0x60) + 0x68) + 0x68) != '\0') {
        return true;
      }
    }
  }
  if (*(int *)(param_1 + 0xe0) != 6) {
    uVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    cVar4 = func_0x000101a24d68(param_2,param_3,uVar7);
    if (cVar4 == '\0') {
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar7 = _UNK_1036d46d8;
      if (lVar5 != 0) {
        puVar8 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
        if (puVar8 == (undefined8 *)0x0) {
          return false;
        }
        if (lRam00000001038c7ad0 == *(long *)(*(long *)(*(long *)*puVar8 + 0x10) + 0x18)) {
          lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          return *(char *)(*(long *)(lVar5 + 0x530) + 0x68) != '\0';
        }
        return false;
      }
LAB_101fb9e2c:
      func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
      pcVar3 = (code *)SoftwareBreakpoint(1,0x101fb9e38);
      (*pcVar3)();
    }
  }
  return true;
}

