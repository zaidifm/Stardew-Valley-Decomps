/* 0x060066e7 StardewValley.Mobile.TapToMoveUtils.HoeSelectedAndTileHoeable @ 0x101fcb350 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_TapToMoveUtils_HoeSelectedAndTileHoeable_060066e7
          (float param_1,float param_2)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined8 *puVar4;
  undefined8 uVar5;
  long *plVar6;
  
  cVar2 = cRam00000001039114f6;
  if (lRam0000000103976fb8 == 0) {
    if (cRam00000001039114f6 != '\0') goto LAB_101fcb384;
LAB_101fcb46c:
    func_0x00010119b908(&UNK_1033258f7);
    cRam00000001039114f6 = '\x01';
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  }
  else {
    func_0x00010119b8f8();
    if (cVar2 == '\0') goto LAB_101fcb46c;
LAB_101fcb384:
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  }
  uVar5 = _UNK_1036d7920;
  if (lVar3 == 0) {
LAB_101fcb490:
    func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcb49c);
    (*pcVar1)();
  }
  puVar4 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
  uVar5 = 0;
  if (puVar4 != (undefined8 *)0x0) {
    if (lRam00000001038c7a20 == *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x18)) {
      plVar6 = (long *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
      uVar5 = _UNK_1036d7928;
      if (plVar6 == (long *)0x0) goto LAB_101fcb490;
      lVar3 = (**(code **)(*plVar6 + 0x260))
                        (plVar6,(int)param_1,(int)param_2,uRam00000001038e7d60,uRam00000001038c90d0,
                         0);
      uVar5 = 0;
      if (lVar3 != 0) {
        plVar6 = (long *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
        cVar2 = (**(code **)(*plVar6 + 1000))(param_1,param_2,plVar6,0xff,0,0);
        uVar5 = 0;
        if (cVar2 == '\0') {
          lVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb(0);
          uVar5 = _UNK_1036d7938;
          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
            func_0x0001003319b0(lRam00000001038c4c88);
            uVar5 = _UNK_1036d7938;
          }
          _UNK_1036d7938 = uVar5;
          if (lVar3 == 0) goto LAB_101fcb490;
          uVar5 = func_0x0001018d3064((float)(int)param_1,(float)(int)param_2);
        }
      }
    }
    else {
      uVar5 = 0;
    }
  }
  return uVar5;
}

