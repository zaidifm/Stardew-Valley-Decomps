/* 0x0600671b StardewValley.Mobile.TapToMoveUtils.GetTileNextToBuildingNearestFarmer @ 0x101fd065c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

float SDV_StardewValley_Mobile_TapToMoveUtils_GetTileNextToBuildingNearestFarmer_0600671b
                (undefined1 param_1 [16],undefined4 param_2,long param_3,long param_4,long param_5)

{
  int iVar1;
  uint uVar2;
  code *pcVar3;
  char cVar4;
  int iVar5;
  int iVar6;
  int iVar7;
  int iVar8;
  int extraout_var;
  int extraout_var_00;
  int extraout_var_01;
  int extraout_var_02;
  long lVar9;
  undefined8 uVar10;
  int iVar11;
  int iVar12;
  int iVar13;
  ulong uVar14;
  long lVar15;
  float *pfVar16;
  float fVar17;
  
  cVar4 = cRam000000010391152a;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103325be0);
    cRam000000010391152a = '\x01';
  }
  uVar10 = _UNK_1036d8170;
  if (param_5 == 0) goto LAB_101fd0cb0;
  iVar5 = StardewValley_StardewValley_Character_get_StandingPixel_06003255(param_5);
  iVar13 = iVar5 + 0x3f;
  if (-1 < iVar5) {
    iVar13 = iVar5;
  }
  uVar10 = _UNK_1036d8180;
  if (*(long *)(param_4 + 0x40) == 0) goto LAB_101fd0cb0;
  iVar5 = *(int *)(*(long *)(param_4 + 0x40) + 0x68);
  iVar6 = StardewValley_StardewValley_Character_get_StandingPixel_06003255(param_5);
  if (iVar13 >> 6 < iVar5) {
    iVar7 = iVar6 + 0x3f;
    if (-1 < iVar6) {
      iVar7 = iVar6;
    }
    iVar8 = 0;
    iVar6 = 0;
    iVar13 = 0;
    iVar5 = iVar5 - (iVar7 >> 6);
  }
  else {
    iVar13 = iVar6 + 0x3f;
    if (-1 < iVar6) {
      iVar13 = iVar6;
    }
    uVar10 = _UNK_1036d8188;
    if ((*(long *)(param_4 + 0x40) == 0) ||
       (uVar10 = _UNK_1036d8190, *(long *)(param_4 + 0x50) == 0)) goto LAB_101fd0cb0;
    iVar5 = *(int *)(*(long *)(param_4 + 0x40) + 0x68);
    iVar8 = *(int *)(*(long *)(param_4 + 0x50) + 0x68);
    iVar7 = StardewValley_StardewValley_Character_get_StandingPixel_06003255(param_5);
    iVar6 = iVar7 + 0x3f;
    if (-1 < iVar7) {
      iVar6 = iVar7;
    }
    iVar6 = iVar6 >> 6;
    if (iVar5 + iVar8 + -1 < iVar13 >> 6) {
      uVar10 = _UNK_1036d8250;
      if ((*(long *)(param_4 + 0x40) == 0) ||
         (uVar10 = _UNK_1036d8258, *(long *)(param_4 + 0x50) == 0)) goto LAB_101fd0cb0;
      iVar8 = 0;
      iVar5 = 0;
      iVar13 = iVar6 - (*(int *)(*(long *)(param_4 + 0x40) + 0x68) +
                       *(int *)(*(long *)(param_4 + 0x50) + 0x68));
      iVar6 = 0;
      iVar13 = iVar13 + 1;
    }
    else {
      StardewValley_StardewValley_Character_get_StandingPixel_06003255(param_5);
      uVar10 = _UNK_1036d8198;
      if (*(long *)(param_4 + 0x48) == 0) goto LAB_101fd0cb0;
      iVar8 = *(int *)(*(long *)(param_4 + 0x48) + 0x68);
      iVar13 = extraout_var + 0x3f;
      if (-1 < extraout_var) {
        iVar13 = extraout_var;
      }
      if (iVar13 >> 6 < iVar8) {
        iVar13 = 0;
        iVar5 = 0;
      }
      else {
        uVar10 = _UNK_1036d81a0;
        if (*(long *)(param_4 + 0x58) == 0) goto LAB_101fd0cb0;
        iVar13 = 0;
        iVar5 = 0;
        iVar8 = iVar8 + *(int *)(*(long *)(param_4 + 0x58) + 0x68) + -1;
      }
    }
  }
  StardewValley_StardewValley_Character_get_StandingPixel_06003255(param_5);
  uVar10 = _UNK_1036d81a8;
  if (*(long *)(param_4 + 0x48) == 0) goto LAB_101fd0cb0;
  iVar12 = *(int *)(*(long *)(param_4 + 0x48) + 0x68);
  iVar7 = extraout_var_00 + 0x3f;
  if (-1 < extraout_var_00) {
    iVar7 = extraout_var_00;
  }
  StardewValley_StardewValley_Character_get_StandingPixel_06003255(param_5);
  if (iVar7 >> 6 < iVar12) {
    iVar7 = extraout_var_01 + 0x3f;
    if (-1 < extraout_var_01) {
      iVar7 = extraout_var_01;
    }
    iVar11 = 0;
    iVar12 = iVar12 - (iVar7 >> 6);
    if (iVar6 == 0 && iVar8 == 0) goto LAB_101fd0918;
  }
  else {
    iVar7 = extraout_var_01 + 0x3f;
    if (-1 < extraout_var_01) {
      iVar7 = extraout_var_01;
    }
    uVar10 = _UNK_1036d81b0;
    if ((*(long *)(param_4 + 0x48) == 0) ||
       (uVar10 = _UNK_1036d81b8, *(long *)(param_4 + 0x58) == 0)) goto LAB_101fd0cb0;
    iVar12 = *(int *)(*(long *)(param_4 + 0x48) + 0x68);
    iVar11 = *(int *)(*(long *)(param_4 + 0x58) + 0x68);
    StardewValley_StardewValley_Character_get_StandingPixel_06003255(param_5);
    iVar1 = extraout_var_02 + 0x3f;
    if (-1 < extraout_var_02) {
      iVar1 = extraout_var_02;
    }
    iVar1 = iVar1 >> 6;
    if (iVar11 + iVar12 < iVar7 >> 6) {
      uVar10 = _UNK_1036d8240;
      if ((*(long *)(param_4 + 0x48) == 0) ||
         (uVar10 = _UNK_1036d8248, *(long *)(param_4 + 0x58) == 0)) goto LAB_101fd0cb0;
      iVar12 = 0;
      iVar11 = (iVar1 - (*(int *)(*(long *)(param_4 + 0x48) + 0x68) +
                        *(int *)(*(long *)(param_4 + 0x58) + 0x68))) + 1;
      if (iVar6 == 0 && iVar8 == 0) goto LAB_101fd0918;
    }
    else {
      iVar8 = StardewValley_StardewValley_Character_get_StandingPixel_06003255(param_5);
      uVar10 = _UNK_1036d81c0;
      if (*(long *)(param_4 + 0x40) == 0) goto LAB_101fd0cb0;
      iVar6 = *(int *)(*(long *)(param_4 + 0x40) + 0x68);
      iVar7 = iVar8 + 0x3f;
      if (-1 < iVar8) {
        iVar7 = iVar8;
      }
      iVar8 = iVar1;
      if (iVar7 >> 6 < iVar6) {
        iVar11 = 0;
        iVar12 = 0;
        if (iVar6 == 0 && iVar1 == 0) {
LAB_101fd0918:
          if ((iVar12 < 1) || (iVar5 < 1)) {
            if ((iVar12 < 1) || (iVar13 < 1)) {
              if ((iVar11 < 1) || (iVar5 < 1)) {
                iVar6 = 0;
                iVar8 = 0;
                if ((iVar11 < 1) || (iVar13 < 1)) goto LAB_101fd0a18;
                uVar10 = _UNK_1036d81e0;
                if ((((*(long *)(param_4 + 0x40) == 0) ||
                     (uVar10 = _UNK_1036d81e8, *(long *)(param_4 + 0x50) == 0)) ||
                    (uVar10 = _UNK_1036d81f0, *(long *)(param_4 + 0x48) == 0)) ||
                   (uVar10 = _UNK_1036d81f8, *(long *)(param_4 + 0x58) == 0)) goto LAB_101fd0cb0;
                iVar6 = *(int *)(*(long *)(param_4 + 0x40) + 0x68) +
                        *(int *)(*(long *)(param_4 + 0x50) + 0x68) + -1;
                iVar13 = *(int *)(*(long *)(param_4 + 0x48) + 0x68) +
                         *(int *)(*(long *)(param_4 + 0x58) + 0x68);
              }
              else {
                uVar10 = _UNK_1036d8200;
                if (((*(long *)(param_4 + 0x40) == 0) ||
                    (uVar10 = _UNK_1036d8208, *(long *)(param_4 + 0x48) == 0)) ||
                   (uVar10 = _UNK_1036d8210, *(long *)(param_4 + 0x58) == 0)) goto LAB_101fd0cb0;
                iVar6 = *(int *)(*(long *)(param_4 + 0x40) + 0x68);
                iVar13 = *(int *)(*(long *)(param_4 + 0x48) + 0x68) +
                         *(int *)(*(long *)(param_4 + 0x58) + 0x68);
              }
              iVar8 = iVar13 + -1;
            }
            else {
              uVar10 = _UNK_1036d8218;
              if (((*(long *)(param_4 + 0x40) == 0) ||
                  (uVar10 = _UNK_1036d8220, *(long *)(param_4 + 0x50) == 0)) ||
                 (uVar10 = _UNK_1036d8228, *(long *)(param_4 + 0x48) == 0)) goto LAB_101fd0cb0;
              iVar6 = *(int *)(*(long *)(param_4 + 0x40) + 0x68) +
                      *(int *)(*(long *)(param_4 + 0x50) + 0x68) + -1;
              iVar8 = *(int *)(*(long *)(param_4 + 0x48) + 0x68);
            }
          }
          else {
            uVar10 = _UNK_1036d8230;
            if ((*(long *)(param_4 + 0x40) == 0) ||
               (uVar10 = _UNK_1036d8238, *(long *)(param_4 + 0x48) == 0)) goto LAB_101fd0cb0;
            iVar6 = *(int *)(*(long *)(param_4 + 0x40) + 0x68);
            iVar8 = *(int *)(*(long *)(param_4 + 0x48) + 0x68);
          }
        }
      }
      else {
        uVar10 = _UNK_1036d81c8;
        if (*(long *)(param_4 + 0x50) == 0) goto LAB_101fd0cb0;
        iVar11 = 0;
        iVar12 = 0;
        iVar6 = iVar6 + *(int *)(*(long *)(param_4 + 0x50) + 0x68) + -1;
        if (iVar6 == 0 && iVar1 == 0) goto LAB_101fd0918;
      }
    }
  }
LAB_101fd0a18:
  lVar9 = SDV_StardewValley_Mobile_TapToMoveUtils_ListOfTilesSurroundingBuilding_0600671d(param_4);
  uVar2 = *(uint *)(lVar9 + 0x18);
  if (0 < (int)uVar2) {
    lVar15 = *(long *)(lVar9 + 0x10);
    uVar14 = 0;
    pfVar16 = (float *)(lVar15 + 0x20);
    do {
      if (*(uint *)(lVar15 + 0x18) <= uVar14) {
        func_0x0001003316f4(0xcc,_UNK_1036d8260);
                    /* WARNING: Does not return */
        pcVar3 = (code *)SoftwareBreakpoint(1,0x101fd0ca8);
        (*pcVar3)();
      }
      if ((iVar6 == (int)*pfVar16) && (iVar8 == (int)pfVar16[1])) goto LAB_101fd0a90;
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      uVar14 = uVar14 + 1;
      pfVar16 = pfVar16 + 2;
    } while (uVar2 != uVar14);
  }
  uVar14 = 0;
LAB_101fd0a90:
  uVar10 = _UNK_1036d81d0;
  if (param_3 != 0) {
    uVar10 = SDV_StardewValley_Mobile_AStarGraph_get_FarmerAStarNodeOffset_060065fe(param_3);
    fVar17 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_FetchAccessibleTileNextToBuilding_0600671c
                              (lVar9,uVar14 & 0xffffffff,param_3,uVar10);
    if (*(char *)(lRam00000001038c7e00 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    cVar4 = func_0x0001003501d0(fVar17,param_2,*puRam00000001038d4510,puRam00000001038d4510[1]);
    if (cVar4 == '\0') {
      iVar13 = *(int *)(lVar9 + 0x18);
      if (3 < iVar13) {
        iVar5 = 1;
        iVar6 = -1;
        do {
          iVar8 = (int)uVar14;
          if (iVar8 + iVar6 < 0) {
            fVar17 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_FetchAccessibleTileNextToBuilding_0600671c
                                      (lVar9,iVar8 + iVar13 + iVar6,param_3,uVar10);
            if (*(char *)(lRam00000001038c7e00 + 0x35) == '\0') {
              func_0x0001003319b0();
            }
            cVar4 = func_0x0001003501d0(fVar17,param_2,*puRam00000001038d4510,
                                        puRam00000001038d4510[1]);
            if (cVar4 != '\0') {
              return fVar17;
            }
            iVar13 = *(int *)(lVar9 + 0x18);
          }
          if (iVar13 + -1 < iVar8 + iVar5) {
            fVar17 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_FetchAccessibleTileNextToBuilding_0600671c
                                      (lVar9,(iVar8 + iVar5) - iVar13,param_3,uVar10);
            if (*(char *)(lRam00000001038c7e00 + 0x35) == '\0') {
              func_0x0001003319b0();
            }
            cVar4 = func_0x0001003501d0(fVar17,param_2,*puRam00000001038d4510,
                                        puRam00000001038d4510[1]);
            if (cVar4 != '\0') {
              return fVar17;
            }
            iVar13 = *(int *)(lVar9 + 0x18);
          }
          iVar8 = iVar13;
          if (iVar13 < 0) {
            iVar8 = iVar13 + 1;
          }
          if (lRam0000000103976fb8 != 0) {
            func_0x00010119b8f8();
          }
          iVar5 = iVar5 + 1;
          iVar6 = iVar6 + -1;
        } while (iVar5 < iVar8 >> 1);
      }
      iVar5 = StardewValley_StardewValley_Character_get_StandingPixel_06003255(param_5);
      iVar13 = iVar5 + 0x3f;
      if (-1 < iVar5) {
        iVar13 = iVar5;
      }
      fVar17 = (float)(iVar13 >> 6);
      StardewValley_StardewValley_Character_get_StandingPixel_06003255(param_5);
    }
    return fVar17;
  }
LAB_101fd0cb0:
  func_0x0001003316f4(0xee,uVar10);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fd0cbc);
  (*pcVar3)();
}

