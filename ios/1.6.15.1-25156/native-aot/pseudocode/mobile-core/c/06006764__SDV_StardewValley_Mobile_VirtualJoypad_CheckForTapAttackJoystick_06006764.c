/* 0x06006764 StardewValley.Mobile.VirtualJoypad.CheckForTapAttackJoystick @ 0x101fd6860 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_CheckForTapAttackJoystick_06006764(long param_1)

{
  long lVar1;
  char cVar2;
  code *pcVar3;
  bool bVar4;
  undefined1 uVar5;
  long lVar6;
  undefined8 *puVar7;
  long lVar8;
  ulong uVar9;
  long lVar10;
  undefined8 uVar11;
  float fVar12;
  float fVar13;
  float fVar14;
  float fVar15;
  float fVar16;
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
  
  cVar2 = cRam0000000103911573;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325e10);
    cRam0000000103911573 = '\x01';
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
  lVar6 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if (*(int *)(lVar6 + 0x178) != 1) {
    return;
  }
  *(undefined1 *)(param_1 + 0x158) = 0;
  lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar11 = _UNK_1036d8ff0;
  if (lVar6 != 0) {
    lVar6 = StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
    if (lVar6 == 0) {
      return;
    }
    lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar11 = _UNK_1036d8ff8;
    if (lVar6 != 0) {
      puVar7 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
      if (puVar7 == (undefined8 *)0x0) {
        return;
      }
      if (lRam00000001038c7a50 != *(long *)(*(long *)(*(long *)*puVar7 + 0x10) + 0x18)) {
        return;
      }
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar11 = _UNK_1036d9000;
      if (*plRam00000001038d5220 != 0) {
        lVar10 = *(long *)(*plRam00000001038d5220 + 0x60);
        lVar6 = 0;
        uVar9 = 0;
        do {
          lVar8 = lVar10;
          if (lVar10 == 0) {
            lVar8 = *plRam00000001038e67e0;
          }
          if ((long)*(int *)(lVar8 + 0x18) <= (long)uVar9) {
            if (*(char *)(param_1 + 0x158) != '\0') {
              return;
            }
            if (*(char *)(param_1 + 0x106) != '\0') {
              *(undefined1 *)(param_1 + 0x105) = 1;
            }
            *(undefined1 *)(param_1 + 0x106) = 0;
            lVar6 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
            uVar11 = _UNK_1036d9078;
            if (*(long *)(lVar6 + 0x238) != 0) {
              SDV_StardewValley_Mobile_TapToMove_OnButtonARelease_060066a3();
              return;
            }
            break;
          }
          lVar8 = lVar10;
          if (lVar10 == 0) {
            lVar8 = *plRam00000001038e67e0;
          }
          uVar11 = _UNK_1036d9018;
          if (*(uint *)(lVar8 + 0x18) <= uVar9) goto LAB_101fd6c40;
          lVar1 = (lVar6 >> 0x20) + 0x20;
          puVar7 = (undefined8 *)(lVar1 + lVar8);
          uStack_c8 = puVar7[3];
          uVar11 = puVar7[2];
          uStack_b8 = puVar7[5];
          uStack_c0 = puVar7[4];
          uStack_a8 = puVar7[7];
          uStack_b0 = puVar7[6];
          uStack_98 = puVar7[9];
          uStack_a0 = puVar7[8];
          uStack_d8 = puVar7[1];
          uStack_e0 = *puVar7;
          uStack_d0._4_4_ = (int)((ulong)uVar11 >> 0x20);
          bVar4 = uStack_d0._4_4_ == 2;
          uStack_d0 = uVar11;
          if (bVar4) {
LAB_101fd69fc:
            lVar8 = lVar10;
            if (lVar10 == 0) {
              lVar8 = *plRam00000001038e67e0;
            }
            uVar11 = _UNK_1036d9028;
            if (*(uint *)(lVar8 + 0x18) <= uVar9) {
LAB_101fd6c40:
              func_0x0001003316f4(0xcc,uVar11);
                    /* WARNING: Does not return */
              pcVar3 = (code *)SoftwareBreakpoint(1,0x101fd6c4c);
              (*pcVar3)();
            }
            puVar7 = (undefined8 *)(lVar1 + lVar8);
            uStack_d8 = puVar7[1];
            uStack_e0 = *puVar7;
            uStack_a8 = puVar7[7];
            uStack_b0 = puVar7[6];
            uStack_98 = puVar7[9];
            uStack_a0 = puVar7[8];
            uStack_c8 = puVar7[3];
            uStack_d0 = puVar7[2];
            uStack_b8 = puVar7[5];
            uStack_c0 = puVar7[4];
            fVar12 = *(float *)((ulong)&uStack_e0 | 4);
            lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec();
            uVar11 = _UNK_1036d9030;
            if (lVar8 == 0) break;
            fVar13 = *(float *)(lVar8 + 0x150);
            if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
              func_0x0001003319b0(lRam00000001038c4c88);
            }
            uVar11 = _UNK_1036d9038;
            if (*plRam00000001038d53a0 == 0) break;
            lVar8 = lVar10;
            if (lVar10 == 0) {
              lVar8 = *plRam00000001038e67e0;
            }
            uVar11 = _UNK_1036d9048;
            if (*(uint *)(lVar8 + 0x18) <= uVar9) goto LAB_101fd6c40;
            puVar7 = (undefined8 *)(lVar1 + lVar8);
            fVar14 = *(float *)(*plRam00000001038d53a0 + 0xbc);
            uStack_d8 = puVar7[1];
            uStack_e0 = *puVar7;
            uStack_a8 = puVar7[7];
            uStack_b0 = puVar7[6];
            uStack_98 = puVar7[9];
            uStack_a0 = puVar7[8];
            uStack_c8 = puVar7[3];
            uStack_d0 = puVar7[2];
            uStack_b8 = puVar7[5];
            uStack_c0 = puVar7[4];
            fVar15 = ((float *)((ulong)&uStack_e0 | 4))[1];
            lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec();
            uVar11 = _UNK_1036d9050;
            if (lVar8 == 0) break;
            fVar16 = *(float *)(lVar8 + 0x150);
            if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
              func_0x0001003319b0(lRam00000001038c4c88);
            }
            uVar11 = _UNK_1036d9058;
            if (*plRam00000001038d53a0 == 0) break;
            uVar5 = SDV_StardewValley_Mobile_VirtualJoypad_OnTapJoystick_0600674c
                              (param_1,(int)(fVar12 / (fVar13 * fVar14)),
                               (int)(fVar15 / (fVar16 * *(float *)(*plRam00000001038d53a0 + 0xbc))))
            ;
            *(undefined1 *)(param_1 + 0x158) = uVar5;
          }
          else {
            lVar8 = lVar10;
            if (lVar10 == 0) {
              lVar8 = *plRam00000001038e67e0;
            }
            uVar11 = _UNK_1036d9068;
            if (*(uint *)(lVar8 + 0x18) <= uVar9) goto LAB_101fd6c40;
            puVar7 = (undefined8 *)(lVar1 + lVar8);
            uStack_c8 = puVar7[3];
            uVar11 = puVar7[2];
            uStack_b8 = puVar7[5];
            uStack_c0 = puVar7[4];
            uStack_a8 = puVar7[7];
            uStack_b0 = puVar7[6];
            uStack_98 = puVar7[9];
            uStack_a0 = puVar7[8];
            uStack_d8 = puVar7[1];
            uStack_e0 = *puVar7;
            uStack_d0._4_4_ = (int)((ulong)uVar11 >> 0x20);
            bVar4 = uStack_d0._4_4_ == 1;
            uStack_d0 = uVar11;
            if (bVar4) goto LAB_101fd69fc;
          }
          if (lRam0000000103976fb8 != 0) {
            func_0x00010119b8f8();
          }
          uVar9 = uVar9 + 1;
          lVar6 = lVar6 + 0x5000000000;
        } while( true );
      }
    }
  }
  func_0x0001003316f4(0xee,uVar11);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fd6c84);
  (*pcVar3)();
}

