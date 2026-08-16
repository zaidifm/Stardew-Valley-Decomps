/* 0x06005e7d StardewValley.Menus.TutorialManager.HandleChallengeDialogueResponse @ 0x101e1ff18 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Menus_TutorialManager_HandleChallengeDialogueResponse_06005e7d(long param_1)

{
  code *pcVar1;
  bool bVar2;
  char cVar3;
  int iVar4;
  undefined4 uVar5;
  undefined4 uVar6;
  long lVar7;
  long lVar8;
  undefined8 uVar9;
  undefined8 uVar10;
  long lVar11;
  ulong uVar12;
  long *plVar13;
  undefined8 uVar14;
  undefined8 *puVar15;
  long lVar16;
  char cStack_a1;
  long alStack_a0 [5];
  undefined8 uStack_78;
  undefined8 uStack_70;
  int iStack_64;
  long lStack_60;
  undefined1 uStack_51;
  long lStack_50;
  long lStack_48;
  
  cVar3 = cRam0000000103910c8c;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103317830);
    cRam0000000103910c8c = '\x01';
  }
  cStack_a1 = '\0';
  alStack_a0[1] = 0;
  alStack_a0[2] = 0;
  alStack_a0[0] = 0;
  lVar7 = func_0x000100331820(uRam0000000103900838,0x18);
  iVar4 = *(int *)(*(long *)(param_1 + 0xa0) + 0xf4);
  if (iVar4 == 0) {
    lVar8 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    if ((lVar8 != 0) &&
       (lVar8 = StardewValley_StardewValley_Character_get_currentLocation_0600326b(), lVar8 != 0)) {
      uVar9 = func_0x000100331820(uRam00000001038c4d88,0x30);
      func_0x000100331c58();
      uVar14 = _UNK_1036a2cc8;
      if (lVar7 == 0) {
LAB_101e20604:
        func_0x0001003316f4(0xee,uVar14);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101e20610);
        (*pcVar1)();
      }
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lVar7 + 0x10) = uVar9;
      lVar8 = lRam00000001038c4be0;
      *(undefined1 *)(((ulong)(lVar7 + 0x10) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      cStack_a1 = '\0';
      uVar14 = *puRam00000001038d5478;
      iVar4 = func_0x000100331adc(uVar14,&cStack_a1);
      if (iVar4 == 0) {
        func_0x000100331bb8(uVar14,&cStack_a1);
      }
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      if (*pcRam00000001038d5480 == '\0') {
        uVar9 = func_0x000100331794(uRam00000001038c4f40,3);
        func_0x000100331f8c(uVar9,0,uRam00000001038c6ba0);
        func_0x000100331f8c(uVar9,1,uRam00000001038c6c10);
        func_0x000100331f8c(uVar9,2,uRam00000001038e6188);
        uVar9 = SDV_StardewValley_Menus_TutorialManager_GetAllNpcsFromLocations_06005e7a(uVar9);
        cVar3 = StardewValley_StardewValley_Game1_isDarkOut_0600303d(0);
        if (cVar3 == '\0') {
          if ((lVar7 == 0) || (lVar16 = *(long *)(lVar7 + 0x10), lVar16 == 0)) goto LAB_101e205c4;
          puVar15 = (undefined8 *)0x103900850;
        }
        else {
          if ((lVar7 == 0) || (lVar16 = *(long *)(lVar7 + 0x10), lVar16 == 0)) goto LAB_101e205c4;
          puVar15 = (undefined8 *)0x1038e8008;
        }
        func_0x000100331b2c(lVar16,*puVar15);
        if (((lVar7 == 0) || (*(long *)(lVar7 + 0x10) == 0)) ||
           (func_0x000100331b2c(*(long *)(lVar7 + 0x10),uRam0000000103900858), lVar7 == 0)) {
LAB_101e205c4:
          func_0x0001003316f4(0xee,_UNK_1036a2d40);
                    /* WARNING: Does not return */
          pcVar1 = (code *)SoftwareBreakpoint(1,0x101e205d8);
          (*pcVar1)();
        }
        lVar16 = *(long *)(lVar7 + 0x10);
        uVar10 = func_0x0001003780f4(uVar9);
        if (((lVar16 == 0) || (func_0x000100331b2c(lVar16,uVar10), lVar7 == 0)) ||
           ((*(long *)(lVar7 + 0x10) == 0 ||
            (func_0x000100331b2c(*(long *)(lVar7 + 0x10),uRam0000000103900860), lVar7 == 0))))
        goto LAB_101e205c4;
        lVar16 = *(long *)(lVar7 + 0x10);
        uVar10 = func_0x000100378108(uRam00000001038c6ba0,uVar9);
        if (((lVar16 == 0) || (func_0x000100331b2c(lVar16,uVar10), lVar7 == 0)) ||
           ((*(long *)(lVar7 + 0x10) == 0 ||
            (func_0x000100331b2c(*(long *)(lVar7 + 0x10),uRam0000000103900868), lVar7 == 0))))
        goto LAB_101e205c4;
        lVar16 = *(long *)(lVar7 + 0x10);
        uVar10 = func_0x000100378108(uRam00000001038c6c10,uVar9);
        if ((((lVar16 == 0) || (func_0x000100331b2c(lVar16,uVar10), lVar7 == 0)) ||
            (*(long *)(lVar7 + 0x10) == 0)) ||
           (func_0x000100331b2c(*(long *)(lVar7 + 0x10),uRam0000000103900870), lVar7 == 0))
        goto LAB_101e205c4;
        lVar16 = *(long *)(lVar7 + 0x10);
        uVar9 = func_0x000100378108(uRam00000001038e6188,uVar9);
        if (((lVar16 == 0) || (func_0x000100331b2c(lVar16,uVar9), lVar7 == 0)) ||
           (*(long *)(lVar7 + 0x10) == 0)) goto LAB_101e205c4;
        func_0x000100331b2c(*(long *)(lVar7 + 0x10),uRam0000000103900878);
        iVar4 = 1;
      }
      else if (*pcRam00000001038d5480 == '\x01') {
        uVar9 = func_0x000100331794(uRam00000001038c4f40,2);
        func_0x000100331f8c(uVar9,0,uRam00000001038c6e80);
        func_0x000100331f8c(uVar9,1,uRam00000001038cb208);
        uVar9 = SDV_StardewValley_Menus_TutorialManager_GetAllNpcsFromLocations_06005e7a(uVar9);
        cVar3 = StardewValley_StardewValley_Game1_isDarkOut_0600303d(0);
        if (cVar3 == '\0') {
          if (lVar7 == 0) goto LAB_101e205c4;
          lVar16 = *(long *)(lVar7 + 0x10);
          DataMemoryBarrier(2,3);
          *(undefined1 *)(((ulong)(alStack_a0 + 4) >> 9 & 0x7fffff) + lVar8) = 1;
          uStack_78 = 0;
          uStack_70 = 0;
          alStack_a0[1] = 0;
          alStack_a0[2] = 0;
          alStack_a0[0] = lVar16;
          alStack_a0[4] = lVar16;
          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
            func_0x0001003319b0();
          }
          uVar5 = *puRam00000001038d5670;
          lVar11 = func_0x000100331820(uRam00000001038eaed0,0x14);
          *(undefined4 *)(lVar11 + 0x10) = uVar5;
          lVar11 = func_0x000100356abc();
          if (lVar11 == 0) goto LAB_101e205c4;
          uVar10 = func_0x000100357d54();
          func_0x000100368b40(alStack_a0,uVar10);
          func_0x000100368b2c(alStack_a0,uRam0000000103900880);
          if (lVar16 == 0) goto LAB_101e205c4;
        }
        else {
          if ((lVar7 == 0) || (*(long *)(lVar7 + 0x10) == 0)) goto LAB_101e205c4;
          func_0x000100331b2c(*(long *)(lVar7 + 0x10),uRam00000001038e8008);
        }
        if (((lVar7 == 0) || (*(long *)(lVar7 + 0x10) == 0)) ||
           (func_0x000100331b2c(*(long *)(lVar7 + 0x10),uRam0000000103900858), lVar7 == 0))
        goto LAB_101e205c4;
        lVar16 = *(long *)(lVar7 + 0x10);
        uVar10 = func_0x0001003780f4(uVar9);
        if (((lVar16 == 0) || (func_0x000100331b2c(lVar16,uVar10), lVar7 == 0)) ||
           ((*(long *)(lVar7 + 0x10) == 0 ||
            (func_0x000100331b2c(*(long *)(lVar7 + 0x10),uRam0000000103900860), lVar7 == 0))))
        goto LAB_101e205c4;
        lVar16 = *(long *)(lVar7 + 0x10);
        uVar10 = func_0x000100378108(uRam00000001038c6e80,uVar9);
        if ((((lVar16 == 0) || (func_0x000100331b2c(lVar16,uVar10), lVar7 == 0)) ||
            (*(long *)(lVar7 + 0x10) == 0)) ||
           (func_0x000100331b2c(*(long *)(lVar7 + 0x10),uRam0000000103900888), lVar7 == 0))
        goto LAB_101e205c4;
        lVar16 = *(long *)(lVar7 + 0x10);
        uVar9 = func_0x000100378108(uRam00000001038cb208,uVar9);
        if (((lVar16 == 0) || (func_0x000100331b2c(lVar16,uVar9), lVar7 == 0)) ||
           (*(long *)(lVar7 + 0x10) == 0)) goto LAB_101e205c4;
        func_0x000100331b2c(*(long *)(lVar7 + 0x10),uRam0000000103900890);
        iVar4 = 2;
      }
      else {
        iVar4 = 3;
      }
      alStack_a0[3] = 0;
      if (cStack_a1 != '\0') {
        func_0x000100331c1c(uVar14);
      }
      if (((iVar4 != 1) && (iVar4 != 2)) && (iVar4 != 3)) {
        func_0x000100331c30();
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101e20624);
        (*pcVar1)();
      }
      if (alStack_a0[3] != 0) {
        func_0x000100331ba4();
      }
      lStack_60 = *(long *)(lVar7 + 0x10);
      uVar14 = _UNK_1036a2cd8;
      if (lStack_60 == 0) goto LAB_101e20604;
      iStack_64 = *(int *)(lStack_60 + 0x20) + *(int *)(lStack_60 + 0x24);
      if (0 < iStack_64) {
        lVar16 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar14 = _UNK_1036a2cf0;
        if ((lVar16 == 0) ||
           (lVar16 = StardewValley_StardewValley_Character_get_currentLocation_0600326b(),
           uVar14 = _UNK_1036a2cf8, lVar16 == 0)) goto LAB_101e20604;
        uVar9 = StardewValley_StardewValley_GameLocation_get_NameOrUniqueName_0600397a();
        lVar16 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar14 = _UNK_1036a2d00;
        if (lVar16 == 0) goto LAB_101e20604;
        lVar16 = StardewValley_StardewValley_Character_get_currentLocation_0600326b();
        lStack_50 = *(long *)(lVar16 + 0x1b0);
        uVar14 = _UNK_1036a2d10;
        if (lStack_50 == 0) goto LAB_101e20604;
        uStack_51 = *(undefined1 *)(lStack_50 + 0x68);
        lVar16 = StardewValley_StardewValley_Game1_getLocationRequest_060030c9(uVar9,uStack_51);
        lStack_48 = lVar16;
        if (lVar7 == 0) {
          func_0x0001003316f4(0x69,_UNK_1036a2d48);
                    /* WARNING: Does not return */
          pcVar1 = (code *)SoftwareBreakpoint(1,0x101e206b0);
          (*pcVar1)();
        }
        lVar11 = func_0x000100331820(uRam00000001038d6620,0x80);
        DataMemoryBarrier(2,3);
        *(long *)(lVar11 + 0x20) = lVar7;
        *(undefined1 *)(((ulong)(lVar11 + 0x20) >> 9 & 0x7fffff) + lVar8) = 1;
        uVar14 = uRam0000000103900848;
        lVar7 = lRam0000000103900840;
        *(long *)(lVar11 + 0x40) = lRam0000000103900840;
        *(undefined8 *)(lVar11 + 0x28) = uVar14;
        *(undefined8 *)(lVar11 + 0x18) = *(undefined8 *)(lVar7 + 0x30);
        *(undefined8 *)(lVar11 + 0x10) = *(undefined8 *)(lVar7 + 0x28);
        uVar14 = _UNK_1036a2d20;
        if (lVar16 == 0) goto LAB_101e20604;
        StardewValley_StardewValley_LocationRequest_add_OnWarp_06003916(lVar16,lVar11);
        lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar14 = _UNK_1036a2d28;
        if (lVar7 == 0) goto LAB_101e20604;
        uVar5 = StardewValley_StardewValley_Character_get_TilePoint_06003257();
        lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar14 = _UNK_1036a2d30;
        if (lVar7 == 0) goto LAB_101e20604;
        uVar12 = StardewValley_StardewValley_Character_get_TilePoint_06003257();
        plVar13 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar6 = (**(code **)(*plVar13 + 0x1f0))();
        StardewValley_StardewValley_Game1_warpFarmer_060030cf(lVar16,uVar5,uVar12 >> 0x20,uVar6);
      }
    }
    bVar2 = true;
  }
  else {
    bVar2 = iVar4 != -1;
  }
  return bVar2;
}

