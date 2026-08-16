/* 0x060066c3 StardewValley.Mobile.TapToMove.CheckForQueuedReadyToHarvestTaps @ 0x101fc7020 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_TapToMove_CheckForQueuedReadyToHarvestTaps_060066c3(long param_1)

{
  undefined4 uVar1;
  undefined4 uVar2;
  undefined4 uVar3;
  undefined4 uVar4;
  char cVar5;
  code *pcVar6;
  long lVar7;
  undefined8 *puVar8;
  undefined8 uVar9;
  long *plVar10;
  int *piVar11;
  long lVar12;
  
  cVar5 = cRam00000001039114d2;
  if (lRam0000000103976fb8 == 0) {
    if (cRam00000001039114d2 != '\0') goto LAB_101fc7050;
LAB_101fc726c:
    func_0x00010119b908(&UNK_103325740);
    cRam00000001039114d2 = '\x01';
    *(undefined1 *)(param_1 + 0xfd) = 0;
  }
  else {
    func_0x00010119b8f8();
    if (cVar5 == '\0') goto LAB_101fc726c;
LAB_101fc7050:
    *(undefined1 *)(param_1 + 0xfd) = 0;
  }
  lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar9 = _UNK_1036d7120;
  if (lVar7 == 0) goto LAB_101fc737c;
  puVar8 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
  if (((puVar8 == (undefined8 *)0x0) ||
      (lRam00000001038c7ad0 != *(long *)(*(long *)(*(long *)*puVar8 + 0x10) + 0x18))) ||
     (lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a(),
     *(char *)(*(long *)(lVar7 + 0x530) + 0x68) == '\0')) {
    if (*(int *)(*(long *)(param_1 + 0xc0) + 0x18) < 1) {
      return 0;
    }
    lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar9 = _UNK_1036d7130;
    if (lVar7 == 0) goto LAB_101fc737c;
    puVar8 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
    if ((puVar8 != (undefined8 *)0x0) &&
       (lRam00000001038c7ad0 == *(long *)(*(long *)(*(long *)*puVar8 + 0x10) + 0x18))) {
      lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar9 = _UNK_1036d7150;
      if ((lVar7 == 0) ||
         (puVar8 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c(),
         uVar9 = _UNK_1036d7160, puVar8 == (undefined8 *)0x0)) goto LAB_101fc737c;
      if (lRam00000001038c7ad0 != *(long *)(*(long *)(*(long *)*puVar8 + 0x10) + 0x18)) {
        func_0x0001003316f4(0xd3,_UNK_1036d7158);
                    /* WARNING: Does not return */
        pcVar6 = (code *)SoftwareBreakpoint(1,0x101fc7344);
        (*pcVar6)();
      }
      if (*(char *)(puVar8[0x23] + 0x68) == '\0') {
        uVar9 = _UNK_1036d7180;
        if (puVar8[0x24] == 0) goto LAB_101fc737c;
        piVar11 = (int *)(puVar8[0x24] + 0x68);
      }
      else {
        piVar11 = (int *)((long)puVar8 + 300);
      }
      if (*piVar11 < 1) {
        lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar9 = _UNK_1036d7168;
        if (lVar7 != 0) {
          func_0x0001018693b0(lVar7,4);
          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
            func_0x0001003319b0();
          }
          plVar10 = (long *)*plRam00000001038d5338;
          uVar9 = _UNK_1036d7170;
          if (plVar10 != (long *)0x0) {
            uVar9 = (**(code **)(*plVar10 + 0x100))(plVar10,uRam00000001038f0f78);
            func_0x00010171ab70(uVar9,1);
            lVar7 = *(long *)(param_1 + 0xc0);
            uVar9 = _UNK_1036d7178;
            if (lVar7 != 0) {
              *(undefined4 *)(lVar7 + 0x18) = 0;
              *(int *)(lVar7 + 0x1c) = *(int *)(lVar7 + 0x1c) + 1;
              return 0;
            }
          }
        }
        goto LAB_101fc737c;
      }
    }
    lVar7 = *(long *)(param_1 + 0xc0);
    if (*(int *)(lVar7 + 0x18) == 0) {
      func_0x000100331b90();
                    /* WARNING: Does not return */
      pcVar6 = (code *)SoftwareBreakpoint(1,0x101fc72d4);
      (*pcVar6)();
    }
    lVar12 = *(long *)(lVar7 + 0x10);
    if (*(int *)(lVar12 + 0x18) == 0) {
      func_0x0001003316f4(0xcc,_UNK_1036d71a0);
                    /* WARNING: Does not return */
      pcVar6 = (code *)SoftwareBreakpoint(1,0x101fc72f4);
      (*pcVar6)();
    }
    uVar1 = *(undefined4 *)(lVar12 + 0x28);
    uVar3 = *(undefined4 *)(lVar12 + 0x2c);
    uVar2 = *(undefined4 *)(lVar12 + 0x20);
    uVar4 = *(undefined4 *)(lVar12 + 0x24);
    func_0x00010037e008(lVar7,0);
    SDV_StardewValley_Mobile_TapToMove_OnTap_060066a5(param_1,uVar2,uVar4,uVar1,uVar3,0);
    lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar9 = _UNK_1036d7148;
    if (lVar7 == 0) {
LAB_101fc737c:
      func_0x0001003316f4(0xee,uVar9);
                    /* WARNING: Does not return */
      pcVar6 = (code *)SoftwareBreakpoint(1,0x101fc7388);
      (*pcVar6)();
    }
    puVar8 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
    if ((puVar8 == (undefined8 *)0x0) ||
       (lRam00000001038c7ad0 != *(long *)(*(long *)(*(long *)*puVar8 + 0x10) + 0x18))) {
      uVar9 = 1;
    }
    else {
      SDV_StardewValley_Mobile_TapToMove_OnTapRelease_0600669d(param_1,0,0,0,0);
      uVar9 = 1;
    }
  }
  else {
    uVar9 = 0;
    *(undefined1 *)(param_1 + 0x101) = 1;
    *(undefined1 *)(param_1 + 0xfd) = 1;
  }
  return uVar9;
}

