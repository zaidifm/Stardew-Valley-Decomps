/* 0x06006757 StardewValley.Mobile.VirtualJoypad.update @ 0x101fd59b4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_update_06006757(long param_1)

{
  code *pcVar1;
  char cVar2;
  undefined4 uVar3;
  undefined4 uVar4;
  long lVar5;
  undefined8 *puVar6;
  long *plVar7;
  undefined8 uVar8;
  int iVar9;
  
  cVar2 = cRam0000000103911566;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103911566 == '\0') goto LAB_101fd5b8c;
LAB_101fd59e0:
    lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
  }
  else {
    func_0x00010119b8f8();
    if (cVar2 != '\0') goto LAB_101fd59e0;
LAB_101fd5b8c:
    func_0x00010119b908(&UNK_103325de9);
    cRam0000000103911566 = '\x01';
    lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
  }
  if (lVar5 == 0) {
    return;
  }
  lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  if (lVar5 == 0) {
    return;
  }
  lVar5 = SDV_StardewValley_Mobile_PinchZoom_get_Instance_06006679();
  if (*(char *)(lVar5 + 0x1c) != '\0') {
    return;
  }
  if (*(char *)(param_1 + 0x107) != '\0') {
    uVar3 = SDV_StardewValley_Game1_getMouseX_06003129(1);
    uVar4 = SDV_StardewValley_Game1_getMouseY_0600312d(1);
    SDV_StardewValley_Mobile_VirtualJoypad_UpdateSliderPosition_06006758(param_1,uVar3,uVar4);
    SDV_StardewValley_Mobile_VirtualJoypad_UpdateButtonSizes_06006759(param_1);
    SDV_StardewValley_Mobile_VirtualJoypad_MoveButtonPositions_0600675b(param_1,uVar3,uVar4);
    SDV_StardewValley_Mobile_VirtualJoypad_UpdateButtonScales_0600675a(param_1);
    *(undefined4 *)(param_1 + 0x144) = uVar3;
    *(undefined4 *)(param_1 + 0x148) = uVar4;
    return;
  }
  cVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_showJoystick_06006750();
  if (cVar2 != '\0') {
    lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
    if ((((*(int *)(lVar5 + 0x178) == 4) ||
         (lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec(),
         *(int *)(lVar5 + 0x178) == 7)) ||
        (lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec(),
        *(int *)(lVar5 + 0x178) == 6)) ||
       (lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec(),
       *(int *)(lVar5 + 0x178) == 8)) {
LAB_101fd5aa4:
      SDV_StardewValley_Mobile_VirtualJoypad_UpdateJoystick_06006751(param_1);
    }
    else {
      lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
      if (*(int *)(lVar5 + 0x178) == 5) {
        lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar8 = _UNK_1036d8d48;
        if (lVar5 == 0) {
LAB_101fd5c50:
          func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
          pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd5c5c);
          (*pcVar1)();
        }
        puVar6 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
        if ((puVar6 != (undefined8 *)0x0) &&
           (lRam00000001038c7a50 == *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18))) {
          lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          uVar8 = _UNK_1036d8d50;
          if (lVar5 == 0) goto LAB_101fd5c50;
          plVar7 = (long *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
          cVar2 = (**(code **)(*plVar7 + 0x3f8))();
          if (cVar2 == '\0') goto LAB_101fd5aa4;
        }
      }
    }
  }
  lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if (*(int *)(lVar5 + 0x178) == 0) {
    iVar9 = *(int *)(param_1 + 0x100);
  }
  else {
    lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
    iVar9 = *(int *)(lVar5 + 0x178);
    if (iVar9 != *(int *)(param_1 + 0x100)) {
      lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
      cVar2 = *(char *)(param_1 + 0x104);
      *(undefined4 *)(param_1 + 0x100) = *(undefined4 *)(lVar5 + 0x178);
      goto joined_r0x000101fd5b00;
    }
  }
  if (iVar9 != -1) {
    return;
  }
  lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if (*(int *)(lVar5 + 0x178) != 0) {
    return;
  }
  cVar2 = *(char *)(param_1 + 0x104);
joined_r0x000101fd5b00:
  if (cVar2 == '\0') {
    SDV_StardewValley_Mobile_VirtualJoypad_set_showJoypad_0600675d(param_1,1);
  }
  return;
}

