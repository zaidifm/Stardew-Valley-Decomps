/* 0x060066a7 StardewValley.Mobile.TapToMove.CheckToEatFood @ 0x101fb91f0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_TapToMove_CheckToEatFood_060066a7
          (long param_1,undefined4 param_2,undefined4 param_3)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined8 uVar4;
  
  cVar2 = cRam00000001039114b6;
  lVar3 = param_1;
  if (lRam0000000103976fb8 != 0) {
    lVar3 = func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    lVar3 = func_0x00010119b908(&UNK_1033253d0);
    cRam00000001039114b6 = '\x01';
  }
  cVar2 = SDV_StardewValley_Mobile_TapToMove_TappedOnFarmer_060066a9(lVar3,param_2,param_3);
  if (cVar2 == '\0') {
LAB_101fb93cc:
    uVar4 = 0;
  }
  else {
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar4 = _UNK_1036d44e0;
    if (lVar3 == 0) goto LAB_101fb95d4;
    lVar3 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
    if (lVar3 == 0) {
      return 0;
    }
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar4 = _UNK_1036d44e8;
    if (lVar3 == 0) goto LAB_101fb95d4;
    lVar3 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
    if (*(int *)(*(long *)(lVar3 + 0xf0) + 0x68) == -300) {
      lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar4 = _UNK_1036d4500;
      if (lVar3 == 0) goto LAB_101fb95d4;
      lVar3 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
      if (10 < *(int *)(*(long *)(*(long *)(lVar3 + 0x50) + 0x60) + 0x10)) {
        lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar4 = _UNK_1036d45f0;
        if (lVar3 == 0) goto LAB_101fb95d4;
        lVar3 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
        lVar3 = *(long *)(*(long *)(lVar3 + 0x50) + 0x60);
        uVar4 = _UNK_1036d4608;
        if (lVar3 == 0) goto LAB_101fb95d4;
        uVar4 = func_0x00010035629c(lVar3,0,0xb);
        cVar2 = func_0x000100345aa0(uVar4,uRam0000000103904a18);
        if (cVar2 != '\0') goto LAB_101fb93b8;
      }
      lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar4 = _UNK_1036d4520;
      if (lVar3 == 0) goto LAB_101fb95d4;
      lVar3 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
      if (*(long *)(*(long *)(lVar3 + 0x50) + 0x60) != 0) {
        lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar4 = _UNK_1036d45d0;
        if (lVar3 == 0) goto LAB_101fb95d4;
        lVar3 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
        lVar3 = *(long *)(*(long *)(lVar3 + 0x50) + 0x60);
        uVar4 = _UNK_1036d45e8;
        if (lVar3 == 0) goto LAB_101fb95d4;
        cVar2 = func_0x000100350144(lVar3,uRam0000000103904a10);
        if (cVar2 != '\0') goto LAB_101fb93b8;
      }
      lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar4 = _UNK_1036d4538;
      if (lVar3 == 0) goto LAB_101fb95d4;
      lVar3 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
      if (*(long *)(*(long *)(lVar3 + 0x50) + 0x60) != 0) {
        lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar4 = _UNK_1036d45b0;
        if (lVar3 == 0) goto LAB_101fb95d4;
        lVar3 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
        lVar3 = *(long *)(*(long *)(lVar3 + 0x50) + 0x60);
        uVar4 = _UNK_1036d45c8;
        if (lVar3 == 0) goto LAB_101fb95d4;
        cVar2 = func_0x000100350144(lVar3,uRam00000001038e9758);
        if (cVar2 != '\0') goto LAB_101fb93b8;
      }
      lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar4 = _UNK_1036d4550;
      if (lVar3 == 0) goto LAB_101fb95d4;
      lVar3 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
      if (*(int *)(*(long *)(lVar3 + 0x58) + 0x68) != 0x38f) {
        lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar4 = _UNK_1036d4568;
        if (lVar3 == 0) goto LAB_101fb95d4;
        lVar3 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
        if (*(int *)(*(long *)(lVar3 + 0x58) + 0x68) != 0x36f) {
          lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          uVar4 = _UNK_1036d4580;
          if (lVar3 == 0) goto LAB_101fb95d4;
          lVar3 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
          if (*(int *)(*(long *)(lVar3 + 0x18) + 0x68) != -0x67) {
            lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
            uVar4 = _UNK_1036d4598;
            if (lVar3 == 0) goto LAB_101fb95d4;
            lVar3 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
            if (*(int *)(*(long *)(lVar3 + 0x18) + 0x68) != -0x66) goto LAB_101fb93cc;
          }
        }
      }
    }
LAB_101fb93b8:
    uVar4 = _UNK_1036d4610;
    if (param_1 == 0) {
LAB_101fb95d4:
      func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101fb95e0);
      (*pcVar1)();
    }
    uVar4 = 1;
    *(undefined4 *)(param_1 + 0x124) = 10;
  }
  return uVar4;
}

