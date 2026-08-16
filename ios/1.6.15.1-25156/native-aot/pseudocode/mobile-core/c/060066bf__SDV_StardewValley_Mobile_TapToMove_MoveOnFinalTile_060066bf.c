/* 0x060066bf StardewValley.Mobile.TapToMove.MoveOnFinalTile @ 0x101fc5a58 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_MoveOnFinalTile_060066bf
               (undefined1 param_1 [16],float param_2,long param_3)

{
  int iVar1;
  undefined1 auVar2 [16];
  undefined1 auVar3 [16];
  undefined1 auVar4 [16];
  undefined1 auVar5 [16];
  undefined1 auVar6 [16];
  code *pcVar7;
  bool bVar8;
  char cVar9;
  long lVar10;
  long *plVar11;
  undefined8 uVar12;
  int iVar13;
  long lVar14;
  float fVar15;
  float fVar16;
  double dVar17;
  float fVar18;
  float fVar19;
  float fVar20;
  float fVar21;
  int iVar22;
  int iVar23;
  undefined1 auStack_80 [16];
  undefined8 uStack_70;
  undefined8 uStack_68;
  
  auStack_80._0_8_ = 0;
  auStack_80._8_8_ = 0;
  if (lRam0000000103976fb8 == 0) {
    cVar9 = *(char *)(param_3 + 0xf8);
  }
  else {
    func_0x00010119b8f8();
    cVar9 = *(char *)(param_3 + 0xf8);
  }
  SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
  auVar2._8_8_ = auStack_80._8_8_;
  auVar2._0_8_ = auStack_80._0_8_;
  if (cVar9 == '\0') {
    uVar12 = _UNK_1036d6ef8;
    if (*(long *)(param_3 + 0x40) == 0) goto LAB_101fc616c;
    fVar15 = (float)func_0x000100354758();
    if (*(float *)(param_3 + 0x118) <= fVar15) {
      *(int *)(param_3 + 0x11c) = *(int *)(param_3 + 0x11c) + 1;
    }
    *(float *)(param_3 + 0x118) = fVar15;
    lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar12 = _UNK_1036d6f00;
    if (lVar10 == 0) goto LAB_101fc616c;
    fVar16 = (float)StardewValley_StardewValley_Farmer_getMovementSpeed_060036c1();
    auVar6._8_8_ = auStack_80._8_8_;
    auVar6._0_8_ = auStack_80._0_8_;
    auVar5._8_8_ = auStack_80._8_8_;
    auVar5._0_8_ = auStack_80._0_8_;
    auVar4._8_8_ = auStack_80._8_8_;
    auVar4._0_8_ = auStack_80._0_8_;
    if ((((fVar15 < fVar16) || (auStack_80 = auVar4, 3 < *(int *)(param_3 + 0x11c))) ||
        ((*(char *)(param_3 + 0xf5) != '\0' && (auStack_80 = auVar5, fVar15 < 64.0)))) ||
       ((*(long *)(param_3 + 0x48) != 0 && (auStack_80 = auVar6, fVar15 < 66.0))))
    goto LAB_101fc5d9c;
    lVar14 = *(long *)(param_3 + 0x28);
    fVar15 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
    lVar10 = *(long *)(param_3 + 0x58);
    uVar12 = _UNK_1036d6f08;
    if (lVar10 == 0) goto LAB_101fc616c;
    iVar13 = *(int *)(lVar10 + 0x34);
    iVar1 = *(int *)(lVar10 + 0x38);
    lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar12 = _UNK_1036d6f10;
    if (lVar10 == 0) goto LAB_101fc616c;
    fVar16 = (float)StardewValley_StardewValley_Farmer_getMovementSpeed_060036c1();
    uVar12 = _UNK_1036d6f18;
    if (lVar14 == 0) goto LAB_101fc616c;
    fVar20 = (float)(iVar13 << 6) + 32.0;
    fVar18 = (float)(iVar1 << 6) + 32.0;
    fVar21 = ABS(fVar15 - fVar20);
    fVar19 = ABS(param_2 - fVar18);
    if ((((fVar15 <= fVar20) || (param_2 <= fVar18)) || (fVar21 < fVar16)) || (fVar19 < fVar16)) {
      if (((fVar20 <= fVar15) || (param_2 <= fVar18)) || ((fVar21 < fVar16 || (fVar19 < fVar16)))) {
        if (((fVar15 <= fVar20) || (fVar18 <= param_2)) || ((fVar21 < fVar16 || (fVar19 < fVar16))))
        {
          if ((((fVar20 <= fVar15) || (fVar18 <= param_2)) || (fVar21 < fVar16)) ||
             (fVar19 < fVar16)) {
            if ((param_2 <= fVar18) || (fVar19 <= fVar21)) {
              iVar13 = (uint)(fVar15 < fVar20) << 2;
              if (fVar20 < fVar15) {
                iVar13 = 3;
              }
              bVar8 = false;
              if ((fVar21 < fVar19) && (bVar8 = false, !NAN(param_2) && !NAN(fVar18))) {
                bVar8 = param_2 < fVar18;
              }
              if (bVar8) {
                iVar13 = 2;
              }
            }
            else {
              iVar13 = 1;
            }
          }
          else {
            iVar13 = 8;
          }
        }
        else {
          iVar13 = 7;
        }
      }
      else {
        iVar13 = 6;
      }
    }
    else {
      iVar13 = 5;
    }
    lVar10 = *(long *)(param_3 + 0x18);
    uVar12 = _UNK_1036d6f20;
joined_r0x000101fc606c:
    if (lVar10 != 0) {
      SDV_StardewValley_Mobile_MobileKeyStates_SetMovePressed_06006670(lVar10,iVar13);
      return;
    }
LAB_101fc616c:
    func_0x0001003316f4(0xee,uVar12);
                    /* WARNING: Does not return */
    pcVar7 = (code *)SoftwareBreakpoint(1,0x101fc6178);
    (*pcVar7)();
  }
  uVar12 = _UNK_1036d6f28;
  auStack_80 = auVar2;
  if (*(long *)(param_3 + 0x40) == 0) goto LAB_101fc616c;
  fVar15 = (float)func_0x000100354758();
  uVar12 = _UNK_1036d6f30;
  if (*(long *)(param_3 + 0x40) == 0) goto LAB_101fc616c;
  iVar13 = *(int *)(*(long *)(param_3 + 0x40) + 0x34);
  fVar16 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
  lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  auVar3._8_8_ = auStack_80._8_8_;
  auVar3._0_8_ = auStack_80._0_8_;
  uVar12 = _UNK_1036d6f40;
  if ((*(long *)(lVar10 + 0x28) == 0) ||
     (uVar12 = _UNK_1036d6f48, auStack_80 = auVar3, *(long *)(param_3 + 0x40) == 0))
  goto LAB_101fc616c;
  iVar22 = *(int *)(*(long *)(lVar10 + 0x28) + 0x68);
  iVar1 = *(int *)(*(long *)(param_3 + 0x40) + 0x38);
  SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
  fVar18 = param_2;
  lVar10 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar12 = _UNK_1036d6f58;
  if (*(long *)(lVar10 + 0x28) == 0) goto LAB_101fc616c;
  iVar23 = *(int *)(*(long *)(lVar10 + 0x28) + 0x68);
  if (fVar15 == *(float *)(param_3 + 0x118)) {
    *(int *)(param_3 + 0x11c) = *(int *)(param_3 + 0x11c) + 1;
  }
  *(float *)(param_3 + 0x118) = fVar15;
  plVar11 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
  auStack_80 = (**(code **)(*plVar11 + 0x110))();
  lVar10 = *(long *)(param_3 + 0x40);
  uVar12 = _UNK_1036d6f68;
  if (lVar10 == 0) goto LAB_101fc616c;
  uStack_70 = 0;
  uStack_68 = 0;
  func_0x00010034ede4(&uStack_70,*(int *)(lVar10 + 0x34) << 6,*(int *)(lVar10 + 0x38) << 6,0x40,0x40
                     );
  cVar9 = func_0x00010035a4b4(auStack_80,uStack_70,uStack_68);
  if (cVar9 == '\0') {
LAB_101fc5b90:
    if (*(int *)(param_3 + 0x13c) != 2) goto LAB_101fc5b98;
  }
  else {
    if (*(int *)(param_3 + 0x13c) != 1) {
      if (*(long *)(param_3 + 0xa8) == 0) {
        lVar10 = *(long *)(param_3 + 0x28);
        fVar21 = *(float *)(param_3 + 0x108);
        fVar16 = *(float *)(param_3 + 0x10c);
        *(undefined4 *)(param_3 + 0x13c) = 2;
        fVar15 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
        uVar12 = _UNK_1036d6f88;
        if (lVar10 == 0) goto LAB_101fc616c;
        fVar19 = fVar21 - fVar15;
        fVar20 = fVar16 - fVar18;
        if ((((fVar21 <= fVar15) || (NAN(fVar20))) || (fVar16 <= fVar18)) || (NAN(fVar19))) {
          if (((fVar15 <= fVar21) || (NAN(fVar20))) || ((fVar16 <= fVar18 || (NAN(fVar19))))) {
            if (((fVar21 <= fVar15) || (NAN(fVar20))) || ((fVar18 <= fVar16 || (NAN(fVar19))))) {
              if ((((fVar15 <= fVar21) || (NAN(fVar20))) || (fVar18 <= fVar16)) || (NAN(fVar19))) {
                if ((fVar16 <= fVar18) || (ABS(fVar16 - fVar18) <= ABS(fVar21 - fVar15))) {
                  iVar13 = (uint)(fVar21 < fVar15) << 2;
                  if (fVar15 < fVar21) {
                    iVar13 = 3;
                  }
                  bVar8 = false;
                  if ((ABS(fVar21 - fVar15) < ABS(fVar16 - fVar18)) &&
                     (bVar8 = false, !NAN(fVar16) && !NAN(fVar18))) {
                    bVar8 = fVar16 < fVar18;
                  }
                  if (bVar8) {
                    iVar13 = 2;
                  }
                }
                else {
                  iVar13 = 1;
                }
              }
              else {
                iVar13 = 8;
              }
            }
            else {
              iVar13 = 7;
            }
          }
          else {
            iVar13 = 6;
          }
        }
        else {
          iVar13 = 5;
        }
        lVar10 = *(long *)(param_3 + 0x18);
        uVar12 = _UNK_1036d6f90;
        goto joined_r0x000101fc606c;
      }
      goto LAB_101fc5b90;
    }
LAB_101fc5b98:
    if (*(int *)(param_3 + 0x11c) < 4) {
      fVar15 = ABS(((float)(iVar13 << 6) + 32.0) - fVar16) - (float)iVar22;
      fVar16 = ABS(((float)(iVar1 << 6) + 32.0) - param_2) - (float)iVar23;
      if (fVar15 == fVar16) {
        if (-1 < (int)fVar16) {
          fVar15 = fVar16;
        }
      }
      else if (fVar15 <= fVar16) {
        fVar15 = fVar16;
      }
      fVar16 = 64.0;
      if (64.0 < fVar15) {
        *(undefined4 *)(param_3 + 0x13c) = 1;
        iVar13 = *(int *)(*(long *)(param_3 + 0x40) + 0x38);
        SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
        uVar12 = _UNK_1036d6f78;
        if (*(long *)(param_3 + 0x40) == 0) goto LAB_101fc616c;
        iVar1 = *(int *)(*(long *)(param_3 + 0x40) + 0x34);
        fVar15 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
        dVar17 = (double)func_0x00010035d358((double)(((float)(iVar13 << 6) + 32.0) - fVar16),
                                             (double)(((float)(iVar1 << 6) + 32.0) - fVar15));
        fVar15 = ((float)dVar17 / 6.2831855) * 360.0;
        if ((fVar15 < -22.5) || (22.5 <= fVar15)) {
          if ((fVar15 < 22.5) || (67.5 <= fVar15)) {
            if ((fVar15 < 67.5) || (112.5 <= fVar15)) {
              if ((fVar15 < 112.5) || (157.5 <= fVar15)) {
                if ((-112.5 <= fVar15) || (fVar15 < -157.5)) {
                  if ((-22.5 <= fVar15) || (fVar15 < -67.5)) {
                    bVar8 = false;
                    if ((-112.5 <= fVar15) && (bVar8 = false, !NAN(fVar15))) {
                      bVar8 = fVar15 < -67.5;
                    }
                    iVar13 = 3;
                    if (bVar8) {
                      iVar13 = 1;
                    }
                  }
                  else {
                    iVar13 = 6;
                  }
                }
                else {
                  iVar13 = 5;
                }
              }
              else {
                iVar13 = 7;
              }
            }
            else {
              iVar13 = 2;
            }
          }
          else {
            iVar13 = 8;
          }
        }
        else {
          iVar13 = 4;
        }
        lVar10 = *(long *)(param_3 + 0x18);
        uVar12 = _UNK_1036d6f80;
        goto joined_r0x000101fc606c;
      }
    }
  }
  *(undefined4 *)(param_3 + 0x13c) = 0;
LAB_101fc5d9c:
  SDV_StardewValley_Mobile_TapToMove_OnReachEndOfPath_060066c0(param_3);
  return;
}

