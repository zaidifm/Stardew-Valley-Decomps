/* 0x06006766 StardewValley.Mobile.VirtualJoypad.SetGrabTile @ 0x101fd76e8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_SetGrabTile_06006766
               (undefined1 param_1 [16],float param_2)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined8 *puVar4;
  long *plVar5;
  undefined8 uVar6;
  undefined4 uVar7;
  float fVar8;
  
  cVar2 = cRam0000000103911575;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103911575 != '\0') goto LAB_101fd7710;
LAB_101fd78c0:
    func_0x00010119b908(&UNK_103325e68);
    cRam0000000103911575 = '\x01';
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  }
  else {
    func_0x00010119b8f8();
    if (cVar2 == '\0') goto LAB_101fd78c0;
LAB_101fd7710:
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  }
  uVar6 = _UNK_1036d9298;
  if (lVar3 == 0) goto LAB_101fd7970;
  puVar4 = (undefined8 *)StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
  if ((((puVar4 == (undefined8 *)0x0) ||
       (lRam00000001038c7420 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x18))) ||
      (puVar4 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8(),
      puVar4 == (undefined8 *)0x0)) ||
     (lRam00000001038c6c08 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x10))) {
    puVar4 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    if ((puVar4 != (undefined8 *)0x0) &&
       (lRam00000001038c6c08 == *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x10))) {
      puVar4 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
      if ((puVar4 != (undefined8 *)0x0) &&
         (lRam00000001038c6c08 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x10))) {
        func_0x0001003316f4(0xd3,_UNK_1036d92e8);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd7944);
        (*pcVar1)();
      }
      lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar6 = _UNK_1036d92c8;
      if (lVar3 == 0) goto LAB_101fd7970;
      fVar8 = (float)func_0x0001017976a8();
      plVar5 = (long *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
      uVar6 = _UNK_1036d92d0;
      if (plVar5 == (long *)0x0) goto LAB_101fd7970;
      puVar4 = (undefined8 *)
               (**(code **)(*plVar5 + 0x308))
                         (plVar5,(int)fVar8 << 6 | 0x20,(int)param_2 << 6 | 0x20,0);
      if (puVar4 == (undefined8 *)0x0) {
        return;
      }
      if (lRam00000001038c7420 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x18)) {
        return;
      }
      lVar3 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
      lVar3 = *(long *)(lVar3 + 0x238);
      uVar6 = _UNK_1036d92e0;
      if (lVar3 == 0) goto LAB_101fd7970;
      *(float *)(lVar3 + 0x158) = fVar8;
      goto LAB_101fd7800;
    }
    lVar3 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    if (lVar3 == 0) {
      return;
    }
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar6 = _UNK_1036d92a0;
    if (lVar3 == 0) goto LAB_101fd7970;
    lVar3 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
    if (lVar3 == 0) {
      return;
    }
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar6 = _UNK_1036d92a8;
    if (lVar3 == 0) goto LAB_101fd7970;
    plVar5 = (long *)StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
    cVar2 = (**(code **)(*plVar5 + 0x2d0))();
    if (cVar2 == '\0') {
      return;
    }
    lVar3 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    lVar3 = *(long *)(lVar3 + 0x238);
    uVar7 = SDV_StardewValley_Mobile_VirtualJoypad_get_GrabTile_06006767();
    uVar6 = _UNK_1036d92c0;
  }
  else {
    lVar3 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    lVar3 = *(long *)(lVar3 + 0x238);
    uVar7 = SDV_StardewValley_Mobile_VirtualJoypad_get_GrabTile_06006767();
    uVar6 = _UNK_1036d92f8;
  }
  if (lVar3 == 0) {
LAB_101fd7970:
    func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd797c);
    (*pcVar1)();
  }
  *(undefined4 *)(lVar3 + 0x158) = uVar7;
LAB_101fd7800:
  *(float *)(lVar3 + 0x15c) = param_2;
  return;
}

