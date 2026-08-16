/* 0x06006767 StardewValley.Mobile.VirtualJoypad.get_GrabTile @ 0x101fd797c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

float SDV_StardewValley_Mobile_VirtualJoypad_get_GrabTile_06006767(void)

{
  int iVar1;
  code *pcVar2;
  int iVar3;
  int iVar4;
  long lVar5;
  long *plVar6;
  undefined8 uVar7;
  undefined1 auStack_40 [16];
  
  if (lRam0000000103976fb8 == 0) {
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  }
  else {
    func_0x00010119b8f8();
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  }
  uVar7 = _UNK_1036d9300;
  if (lVar5 != 0) {
    lVar5 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
    if (lVar5 == 0) {
      iVar4 = -1;
LAB_101fd7a00:
      plVar6 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
      auStack_40 = (**(code **)(*plVar6 + 0x110))();
      iVar3 = func_0x00010035034c(auStack_40);
      iVar1 = iVar3 + 0x3f;
      if (-1 < iVar3) {
        iVar1 = iVar3;
      }
      func_0x00010035034c(auStack_40);
      plVar6 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
      iVar3 = (**(code **)(*plVar6 + 0x1f0))();
      if (iVar3 == 3) {
        iVar1 = auStack_40._0_4_ + 0x3f;
        if (-1 < (int)auStack_40._0_4_) {
          iVar1 = auStack_40._0_4_;
        }
        iVar4 = iVar4 + (iVar1 >> 6);
      }
      else {
        plVar6 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
        iVar4 = (**(code **)(*plVar6 + 0x1f0))();
        if (iVar4 == 1) {
          iVar4 = auStack_40._8_4_ + auStack_40._0_4_;
          iVar1 = iVar4 + 0x3f;
          if (-1 < iVar4) {
            iVar1 = iVar4;
          }
          iVar4 = (iVar1 >> 6) + 1;
        }
        else {
          plVar6 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
          iVar4 = iVar1 >> 6;
          (**(code **)(*plVar6 + 0x1f0))();
        }
      }
      return (float)iVar4;
    }
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar7 = _UNK_1036d9328;
    if (lVar5 != 0) {
      lVar5 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
      iVar1 = *(int *)(*(long *)(lVar5 + 0x150) + 0x70);
      iVar4 = iVar1 + 0x3f;
      if (-1 < iVar1) {
        iVar4 = iVar1;
      }
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar7 = _UNK_1036d9340;
      if (lVar5 != 0) {
        StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
        iVar4 = -(iVar4 >> 6);
        goto LAB_101fd7a00;
      }
    }
  }
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fd7bb0);
  (*pcVar2)();
}

