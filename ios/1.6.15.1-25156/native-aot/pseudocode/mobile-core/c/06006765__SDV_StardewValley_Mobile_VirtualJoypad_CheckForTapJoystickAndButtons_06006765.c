/* 0x06006765 StardewValley.Mobile.VirtualJoypad.CheckForTapJoystickAndButtons @ 0x101fd6ca8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_CheckForTapJoystickAndButtons_06006765(long param_1)

{
  char *pcVar1;
  char *pcVar2;
  char *pcVar3;
  long lVar4;
  code *pcVar5;
  bool bVar6;
  char cVar7;
  long lVar8;
  ulong uVar9;
  undefined8 *puVar10;
  undefined8 uVar11;
  long lVar12;
  char *pcVar13;
  undefined4 uVar14;
  int iVar15;
  int iVar16;
  long lVar17;
  ulong uVar18;
  float fVar19;
  float fVar20;
  float fVar21;
  float fVar22;
  float fVar23;
  float fVar24;
  undefined8 uStack_e0;
  undefined8 uStack_d8;
  undefined8 uStack_d0;
  undefined8 uStack_c8;
  undefined8 uStack_c0;
  undefined8 uStack_b8;
  undefined8 uStack_b0;
  undefined8 uStack_a8;
  undefined8 uStack_a0;
  undefined8 uStack_98;
  
  cVar7 = cRam0000000103911574;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar7 == '\0') {
    func_0x00010119b908(&UNK_103325e40);
    cRam0000000103911574 = '\x01';
  }
  uStack_c8 = 0;
  uStack_d0 = 0;
  uStack_b8 = 0;
  uStack_c0 = 0;
  uStack_a8 = 0;
  uStack_b0 = 0;
  uStack_98 = 0;
  uStack_a0 = 0;
  uStack_d8 = 0;
  uStack_e0 = 0;
  lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if (((((*(int *)(lVar8 + 0x178) != 2) &&
        (lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec(),
        *(int *)(lVar8 + 0x178) != 3)) &&
       (lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec(),
       *(int *)(lVar8 + 0x178) != 4)) &&
      ((lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec(),
       *(int *)(lVar8 + 0x178) != 7 &&
       (lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec(),
       *(int *)(lVar8 + 0x178) != 6)))) &&
     (lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec(), *(int *)(lVar8 + 0x178) != 8
     )) {
    lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec();
    if (*(int *)(lVar8 + 0x178) != 5) {
      return;
    }
    lVar8 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar11 = _UNK_1036d9278;
    if (lVar8 == 0) goto LAB_101fd7478;
    lVar8 = StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
    if (lVar8 == 0) {
      return;
    }
    lVar8 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar11 = _UNK_1036d9280;
    if (lVar8 == 0) goto LAB_101fd7478;
    puVar10 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
    if (puVar10 == (undefined8 *)0x0) {
      return;
    }
    if (lRam00000001038c7a50 != *(long *)(*(long *)(*(long *)*puVar10 + 0x10) + 0x18)) {
      return;
    }
    lVar8 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar11 = _UNK_1036d9288;
    if ((lVar8 == 0) ||
       (lVar8 = StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c(),
       uVar11 = _UNK_1036d9290, lVar8 == 0)) goto LAB_101fd7478;
    uVar11 = StardewValley_StardewValley_Item_get_ItemId_06003848();
    cVar7 = func_0x00010035011c(uVar11,uRam00000001038eeb18);
    if (cVar7 == '\0') {
      return;
    }
  }
  uVar11 = _UNK_1036d9088;
  if (param_1 != 0) {
    *(undefined2 *)(param_1 + 0x158) = 0;
    *(undefined1 *)(param_1 + 0x15a) = 0;
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar11 = _UNK_1036d9090;
    if (*plRam00000001038d5220 != 0) {
      pcVar1 = (char *)(param_1 + 0x159);
      pcVar2 = (char *)(param_1 + 0x15a);
      lVar8 = 0;
      uVar18 = 0;
      pcVar3 = (char *)(param_1 + 0x158);
      lVar17 = *(long *)(*plRam00000001038d5220 + 0x60);
      lVar12 = lVar17;
      if (lVar17 != 0) goto LAB_101fd6dcc;
LAB_101fd6dc4:
      lVar12 = *plRam00000001038e67e0;
LAB_101fd6dcc:
      while ((long)uVar18 < (long)*(int *)(lVar12 + 0x18)) {
        lVar12 = lVar17;
        if (lVar17 == 0) {
          lVar12 = *plRam00000001038e67e0;
        }
        uVar11 = _UNK_1036d90b0;
        if (*(uint *)(lVar12 + 0x18) <= uVar18) goto LAB_101fd7464;
        lVar4 = (lVar8 >> 0x20) + 0x20;
        puVar10 = (undefined8 *)(lVar4 + lVar12);
        uStack_c8 = puVar10[3];
        uVar11 = puVar10[2];
        uStack_b8 = puVar10[5];
        uStack_c0 = puVar10[4];
        uStack_a8 = puVar10[7];
        uStack_b0 = puVar10[6];
        uStack_98 = puVar10[9];
        uStack_a0 = puVar10[8];
        uStack_d8 = puVar10[1];
        uStack_e0 = *puVar10;
        uStack_d0._4_4_ = (int)((ulong)uVar11 >> 0x20);
        bVar6 = uStack_d0._4_4_ == 2;
        uStack_d0 = uVar11;
        if (bVar6) {
LAB_101fd6e70:
          lVar12 = lVar17;
          if (lVar17 == 0) {
            lVar12 = *plRam00000001038e67e0;
          }
          uVar11 = _UNK_1036d90c0;
          if (*(uint *)(lVar12 + 0x18) <= uVar18) {
LAB_101fd7464:
            func_0x0001003316f4(0xcc,uVar11);
                    /* WARNING: Does not return */
            pcVar5 = (code *)SoftwareBreakpoint(1,0x101fd7470);
            (*pcVar5)();
          }
          puVar10 = (undefined8 *)(lVar4 + lVar12);
          uStack_d8 = puVar10[1];
          uStack_e0 = *puVar10;
          uStack_a8 = puVar10[7];
          uStack_b0 = puVar10[6];
          uStack_98 = puVar10[9];
          uStack_a0 = puVar10[8];
          uStack_c8 = puVar10[3];
          uStack_d0 = puVar10[2];
          uStack_b8 = puVar10[5];
          uStack_c0 = puVar10[4];
          fVar19 = *(float *)((ulong)&uStack_e0 | 4);
          lVar12 = StardewValley_StardewValley_Game1_get_options_06002fec();
          uVar11 = _UNK_1036d90c8;
          if (lVar12 == 0) goto LAB_101fd7478;
          fVar20 = *(float *)(lVar12 + 0x150);
          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
            func_0x0001003319b0(lRam00000001038c4c88);
          }
          uVar11 = _UNK_1036d90d0;
          if (*plRam00000001038d53a0 == 0) goto LAB_101fd7478;
          lVar12 = lVar17;
          if (lVar17 == 0) {
            lVar12 = *plRam00000001038e67e0;
          }
          uVar11 = _UNK_1036d90e0;
          if (*(uint *)(lVar12 + 0x18) <= uVar18) goto LAB_101fd7464;
          puVar10 = (undefined8 *)(lVar4 + lVar12);
          fVar21 = *(float *)(*plRam00000001038d53a0 + 0xbc);
          uStack_d8 = puVar10[1];
          uStack_e0 = *puVar10;
          uStack_a8 = puVar10[7];
          uStack_b0 = puVar10[6];
          uStack_98 = puVar10[9];
          uStack_a0 = puVar10[8];
          uStack_c8 = puVar10[3];
          uStack_d0 = puVar10[2];
          uStack_b8 = puVar10[5];
          uStack_c0 = puVar10[4];
          fVar22 = ((float *)((ulong)&uStack_e0 | 4))[1];
          lVar12 = StardewValley_StardewValley_Game1_get_options_06002fec();
          uVar11 = _UNK_1036d90e8;
          if (lVar12 == 0) goto LAB_101fd7478;
          fVar23 = *(float *)(lVar12 + 0x150);
          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
            func_0x0001003319b0(lRam00000001038c4c88);
          }
          fVar24 = *(float *)(*plRam00000001038d53a0 + 0xbc);
          lVar12 = StardewValley_StardewValley_Game1_get_options_06002fec();
          uVar11 = _UNK_1036d90f8;
          if (lVar12 == 0) goto LAB_101fd7478;
          iVar16 = (int)(fVar19 / (fVar20 * fVar21));
          iVar15 = (int)(fVar22 / (fVar23 * fVar24));
          pcVar13 = pcVar3;
          if (*(int *)(lVar12 + 0x178) == 2) {
            uVar9 = SDV_StardewValley_Mobile_VirtualJoypad_OnTapInvisibleJoystick_0600674a
                              (param_1,iVar16,iVar15);
            if (((uVar9 & 0xff) == 0) &&
               (uVar9 = SDV_StardewValley_Mobile_VirtualJoypad_TappedInvisibleAttackButtonA_06006747
                                  (uVar9,iVar16,iVar15), pcVar13 = pcVar1, (uVar9 & 0xff) == 0)) {
              cVar7 = SDV_StardewValley_Mobile_VirtualJoypad_TappedInvisibleAttackButtonB_06006748
                                (uVar9,iVar16,iVar15);
              pcVar13 = pcVar2;
LAB_101fd6ff0:
              if (cVar7 == '\0') goto LAB_101fd7014;
            }
          }
          else {
            lVar12 = StardewValley_StardewValley_Game1_get_options_06002fec();
            if (*(int *)(lVar12 + 0x178) == 3) {
              uVar9 = SDV_StardewValley_Mobile_VirtualJoypad_OnTapInvisibleJoystick_0600674a();
              if ((uVar9 & 0xff) != 0) {
                *pcVar3 = '\x01';
              }
              cVar7 = SDV_StardewValley_Mobile_VirtualJoypad_TappedInvisibleSingleAttackButton_06006749
                                (uVar9,iVar16,iVar15);
              pcVar13 = pcVar1;
              goto LAB_101fd6ff0;
            }
            cVar7 = SDV_StardewValley_Mobile_VirtualJoypad_OnTapJoystick_0600674c
                              (param_1,iVar16,iVar15);
            if (((cVar7 == '\0') &&
                ((cVar7 = SDV_StardewValley_Mobile_VirtualJoypad_TappedButtonA_0600674d
                                    (param_1,iVar16,iVar15), cVar7 == '\0' ||
                 (lVar12 = StardewValley_StardewValley_Game1_get_options_06002fec(),
                 pcVar13 = pcVar1, *(int *)(lVar12 + 0x178) == 7)))) &&
               ((cVar7 = SDV_StardewValley_Mobile_VirtualJoypad_TappedButtonB_0600674e
                                   (param_1,iVar16,iVar15), cVar7 == '\0' ||
                (lVar12 = StardewValley_StardewValley_Game1_get_options_06002fec(), pcVar13 = pcVar2
                , *(int *)(lVar12 + 0x178) == 7)))) goto LAB_101fd7014;
          }
          *pcVar13 = '\x01';
        }
        else {
          lVar12 = lVar17;
          if (lVar17 == 0) {
            lVar12 = *plRam00000001038e67e0;
          }
          uVar11 = _UNK_1036d9120;
          if (*(uint *)(lVar12 + 0x18) <= uVar18) goto LAB_101fd7464;
          puVar10 = (undefined8 *)(lVar4 + lVar12);
          uStack_c8 = puVar10[3];
          uVar11 = puVar10[2];
          uStack_b8 = puVar10[5];
          uStack_c0 = puVar10[4];
          uStack_a8 = puVar10[7];
          uStack_b0 = puVar10[6];
          uStack_98 = puVar10[9];
          uStack_a0 = puVar10[8];
          uStack_d8 = puVar10[1];
          uStack_e0 = *puVar10;
          uStack_d0._4_4_ = (int)((ulong)uVar11 >> 0x20);
          bVar6 = uStack_d0._4_4_ == 1;
          uStack_d0 = uVar11;
          if (bVar6) goto LAB_101fd6e70;
        }
LAB_101fd7014:
        if (lRam0000000103976fb8 != 0) {
          func_0x00010119b8f8();
        }
        uVar18 = uVar18 + 1;
        lVar8 = lVar8 + 0x5000000000;
        lVar12 = lVar17;
        if (lVar17 == 0) goto LAB_101fd6dc4;
      }
      if ((*pcVar3 == '\0') && (*(char *)(param_1 + 0x106) != '\0')) {
        SDV_StardewValley_Mobile_VirtualJoypad_set_joystickHeld_06006721(param_1,0);
        lVar8 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
        uVar11 = _UNK_1036d9240;
        if (*(long *)(lVar8 + 0x238) == 0) goto LAB_101fd7478;
        SDV_StardewValley_Mobile_TapToMove_StopMoving_060066a1();
      }
      if ((*pcVar1 == '\0') || (*(char *)(param_1 + 0xd8) != '\0')) {
        lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec();
        if (*(int *)(lVar8 + 0x178) == 3) {
          if ((*pcVar1 == '\0') && (*(char *)(param_1 + 0xd8) != '\0')) {
            *(undefined1 *)(param_1 + 0xd8) = 0;
            uVar18 = func_0x000100332090();
            lVar12 = *(long *)(param_1 + 0xd0);
            lVar8 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
            if ((long)((uVar18 & 0x3fffffffffffffff) - lVar12) < 2500000) {
              lVar8 = *(long *)(lVar8 + 0x238);
              uVar11 = _UNK_1036d9210;
              if (lVar8 == 0) goto LAB_101fd7478;
LAB_101fd7304:
              uVar14 = 5;
            }
            else {
              lVar8 = *(long *)(lVar8 + 0x238);
              uVar11 = _UNK_1036d9200;
              if (lVar8 == 0) goto LAB_101fd7478;
              uVar14 = 10;
            }
            *(undefined4 *)(lVar8 + 0x124) = uVar14;
          }
        }
        else {
          if (*pcVar1 != '\0') {
            if (*(char *)(param_1 + 0xd8) != '\0') {
              lVar8 = StardewValley_StardewValley_Game1_get_player_06002f9a();
              uVar11 = _UNK_1036d91b8;
              if (lVar8 == 0) goto LAB_101fd7478;
              lVar8 = StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
              if ((lVar8 != 0) &&
                 (lVar8 = StardewValley_StardewValley_Game1_get_player_06002f9a(),
                 *(char *)(*(long *)(lVar8 + 0x530) + 0x68) == '\0')) {
                lVar8 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                uVar11 = _UNK_1036d91d0;
                if (lVar8 == 0) goto LAB_101fd7478;
                lVar8 = StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
                if (*(int *)(*(long *)(lVar8 + 0xd0) + 0x68) == 0) {
                  lVar8 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
                  lVar8 = *(long *)(lVar8 + 0x238);
                  uVar11 = _UNK_1036d91f0;
                  if (lVar8 != 0) goto LAB_101fd7304;
                  goto LAB_101fd7478;
                }
              }
            }
            if (*pcVar1 != '\0') {
              if (*(char *)(param_1 + 0xd8) == '\0') goto LAB_101fd730c;
              lVar8 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
              *(undefined1 *)(*(long *)(*(long *)(lVar8 + 0x238) + 0x18) + 0x15) = 0;
              lVar8 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
              *(undefined1 *)(*(long *)(*(long *)(lVar8 + 0x238) + 0x18) + 0x16) = 0;
              lVar8 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
              lVar8 = *(long *)(*(long *)(lVar8 + 0x238) + 0x18);
              uVar11 = _UNK_1036d91b0;
              if (lVar8 == 0) goto LAB_101fd7478;
              *(undefined1 *)(lVar8 + 0x17) = 1;
              goto LAB_101fd730c;
            }
          }
          if (*(char *)(param_1 + 0xd8) != '\0') {
            *(undefined1 *)(param_1 + 0xd8) = 0;
            lVar8 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
            lVar8 = *(long *)(*(long *)(lVar8 + 0x238) + 0x18);
            *(undefined1 *)(lVar8 + 0x15) = 0;
            *(undefined1 *)(lVar8 + 0x16) = *(undefined1 *)(lVar8 + 0x17);
            *(undefined1 *)(lVar8 + 0x17) = 0;
          }
        }
      }
      else {
        *(undefined1 *)(param_1 + 0xd8) = 1;
        lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec();
        if (*(int *)(lVar8 + 0x178) == 3) {
          uVar18 = func_0x000100332090();
          *(ulong *)(param_1 + 0xd0) = uVar18 & 0x3fffffffffffffff;
        }
        else {
          SDV_StardewValley_Mobile_VirtualJoypad_SetGrabTile_06006766();
          lVar8 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
          lVar8 = *(long *)(*(long *)(lVar8 + 0x238) + 0x18);
          *(undefined2 *)(lVar8 + 0x16) = 0x100;
          *(bool *)(lVar8 + 0x15) = *(char *)(lVar8 + 0x17) == '\0';
        }
      }
LAB_101fd730c:
      if (*(char *)(param_1 + 0x15a) == '\0') {
        if (*(char *)(param_1 + 0xd9) == '\0') {
          return;
        }
      }
      else if (*(char *)(param_1 + 0xd9) == '\0') {
        *(undefined1 *)(param_1 + 0xd9) = 1;
        lVar8 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
        lVar8 = *(long *)(*(long *)(lVar8 + 0x238) + 0x18);
        uVar11 = _UNK_1036d9150;
        if (lVar8 != 0) {
          *(undefined1 *)(lVar8 + 0x18) = 1;
          return;
        }
        goto LAB_101fd7478;
      }
      lVar8 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
      *(undefined1 *)(*(long *)(*(long *)(lVar8 + 0x238) + 0x18) + 0x18) = 0;
      if (*pcVar2 != '\0') {
        return;
      }
      if (*(char *)(param_1 + 0xd9) == '\0') {
        return;
      }
      *(undefined1 *)(param_1 + 0xd9) = 0;
      return;
    }
  }
LAB_101fd7478:
  func_0x0001003316f4(0xee,uVar11);
                    /* WARNING: Does not return */
  pcVar5 = (code *)SoftwareBreakpoint(1,0x101fd7484);
  (*pcVar5)();
}

