/* 0x060066b9 StardewValley.Mobile.TapToMove.CheckToRetargetNPC @ 0x101fc3e7c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_CheckToRetargetNPC_060066b9(long param_1)

{
  uint uVar1;
  int iVar2;
  code *pcVar3;
  char cVar4;
  int iVar5;
  uint uVar6;
  long lVar7;
  long lVar8;
  undefined8 uVar9;
  uint extraout_var;
  int extraout_var_00;
  undefined8 uVar10;
  float fVar11;
  
  cVar4 = cRam00000001039114c8;
  if (lRam0000000103976fb8 == 0) {
    if (cRam00000001039114c8 == '\0') goto LAB_101fc4020;
LAB_101fc3eac:
    lVar7 = *(long *)(param_1 + 0x78);
  }
  else {
    func_0x00010119b8f8();
    if (cVar4 != '\0') goto LAB_101fc3eac;
LAB_101fc4020:
    func_0x00010119b908(&UNK_103325670);
    cRam00000001039114c8 = '\x01';
    lVar7 = *(long *)(param_1 + 0x78);
  }
  if (lVar7 != 0) {
    uVar9 = _UNK_1036d6a58;
    if (param_1 == -0x110) goto LAB_101fc4058;
    if ((*(float *)(param_1 + 0x110) != -1.0) || (*(float *)(param_1 + 0x114) != -1.0)) {
      lVar7 = func_0x000101794214();
      lVar8 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
      if (lVar7 == lVar8) {
        uVar10 = *(undefined8 *)(param_1 + 0x78);
        uVar9 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
        cVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_NpcAtWarpOrDoor_060066db(uVar10,uVar9);
        if (cVar4 == '\0') {
          uVar9 = _UNK_1036d6a60;
          if (*(long *)(param_1 + 0x78) != 0) {
            fVar11 = *(float *)(param_1 + 0x110);
            iVar5 = StardewValley_StardewValley_Character_get_StandingPixel_06003255();
            iVar2 = iVar5 + 0x3f;
            if (-1 < iVar5) {
              iVar2 = iVar5;
            }
            if (fVar11 == (float)(iVar2 >> 6)) {
              uVar9 = _UNK_1036d6a88;
              if (*(long *)(param_1 + 0x78) == 0) goto LAB_101fc4058;
              fVar11 = *(float *)(param_1 + 0x114);
              StardewValley_StardewValley_Character_get_StandingPixel_06003255();
              iVar2 = extraout_var_00 + 0x3f;
              if (-1 < extraout_var_00) {
                iVar2 = extraout_var_00;
              }
              if (fVar11 == (float)(iVar2 >> 6)) {
                return;
              }
            }
            uVar9 = _UNK_1036d6a68;
            if (*(long *)(param_1 + 0x78) != 0) {
              uVar6 = StardewValley_StardewValley_Character_get_StandingPixel_06003255();
              uVar1 = uVar6 + 0x3f;
              if (-1 < (int)uVar6) {
                uVar1 = uVar6;
              }
              if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                func_0x0001003319b0();
              }
              uVar9 = _UNK_1036d6a70;
              if ((piRam00000001038d5380 != (int *)0x0) &&
                 (uVar9 = _UNK_1036d6a78, *(long *)(param_1 + 0x78) != 0)) {
                iVar2 = *piRam00000001038d5380;
                StardewValley_StardewValley_Character_get_StandingPixel_06003255();
                uVar9 = _UNK_1036d6a80;
                if (piRam00000001038d5380 != (int *)0x0) {
                  uVar6 = extraout_var + 0x3f;
                  if (-1 < (int)extraout_var) {
                    uVar6 = extraout_var;
                  }
                  SDV_StardewValley_Mobile_TapToMove_OnTap_060066a5
                            (param_1,(uVar1 & 0xffffffc0 | 0x20) - iVar2,
                             (uVar6 & 0xffffffc0 | 0x20) - piRam00000001038d5380[1],
                             *piRam00000001038d5380,piRam00000001038d5380[1],0);
                  return;
                }
              }
            }
          }
LAB_101fc4058:
          func_0x0001003316f4(0xee,uVar9);
                    /* WARNING: Does not return */
          pcVar3 = (code *)SoftwareBreakpoint(1,0x101fc4064);
          (*pcVar3)();
        }
      }
      SDV_StardewValley_Mobile_TapToMove_Reset_06006698(param_1,1);
    }
  }
  return;
}

