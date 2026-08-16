/* 0x06006680 StardewValley.Mobile.PinchZoom.CheckForPinchZoom @ 0x101fb0468 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined4 SDV_StardewValley_Mobile_PinchZoom_CheckForPinchZoom_06006680(long param_1)

{
  int iVar1;
  int *piVar2;
  float fVar3;
  code *pcVar4;
  char cVar5;
  undefined8 uVar6;
  long lVar7;
  float *pfVar8;
  long lVar9;
  float fVar10;
  undefined4 uVar11;
  float fVar12;
  ulong uVar13;
  float fVar14;
  float fVar15;
  float fVar16;
  float fVar17;
  undefined8 uStack_c0;
  ulong uStack_b8;
  undefined8 uStack_b0;
  undefined8 uStack_a8;
  undefined8 uStack_a0;
  undefined8 uStack_98;
  undefined8 uStack_90;
  undefined8 uStack_88;
  undefined8 uStack_80;
  undefined8 uStack_78;
  
  cVar5 = cRam000000010391148f;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar5 == '\0') {
    func_0x00010119b908(&UNK_103325010);
    cRam000000010391148f = '\x01';
  }
  uStack_a8 = 0;
  uStack_b0 = 0;
  uStack_98 = 0;
  uStack_a0 = 0;
  uStack_88 = 0;
  uStack_90 = 0;
  uStack_78 = 0;
  uStack_80 = 0;
  uStack_b8 = 0;
  uStack_c0 = 0;
  *(undefined1 *)(param_1 + 0x1c) = 0;
  cVar5 = SDV_StardewValley_Mobile_PinchZoom_get_ZoomingAllowed_0600667f(param_1);
  if (cVar5 == '\0') {
    return 0;
  }
  if ((*(char *)(lRam00000001038c7e00 + 0x35) == '\0') &&
     (func_0x0001003319b0(), *(char *)(lRam00000001038c7e00 + 0x35) == '\0')) {
    func_0x0001003319b0();
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  lVar7 = *(long *)(*plRam00000001038d5220 + 0x60);
  lVar9 = lVar7;
  if (lVar7 == 0) {
    lVar9 = *plRam00000001038e67e0;
  }
  if (*(int *)(lVar9 + 0x18) != 2) {
    if (*(float *)(param_1 + 0x10) != 3.4028235e+38) {
      *(undefined4 *)(param_1 + 0x10) = 0x7f7fffff;
      return 0;
    }
    return 0;
  }
  lVar9 = lVar7;
  if (lVar7 == 0) {
    lVar9 = *plRam00000001038e67e0;
  }
  uVar6 = _UNK_1036d3a98;
  if (*(int *)(lVar9 + 0x18) == 0) {
LAB_101fb0984:
    func_0x0001003316f4(0xcc,uVar6);
                    /* WARNING: Does not return */
    pcVar4 = (code *)SoftwareBreakpoint(1,0x101fb0990);
    (*pcVar4)();
  }
  uStack_b8 = *(ulong *)(lVar9 + 0x28);
  uStack_c0 = *(undefined8 *)(lVar9 + 0x20);
  uStack_88 = *(undefined8 *)(lVar9 + 0x58);
  uStack_90 = *(undefined8 *)(lVar9 + 0x50);
  uStack_78 = *(undefined8 *)(lVar9 + 0x68);
  uStack_80 = *(undefined8 *)(lVar9 + 0x60);
  uStack_a8 = *(undefined8 *)(lVar9 + 0x38);
  uStack_b0 = *(undefined8 *)(lVar9 + 0x30);
  uStack_98 = *(undefined8 *)(lVar9 + 0x48);
  uStack_a0 = *(undefined8 *)(lVar9 + 0x40);
  if (lVar7 == 0) {
    lVar7 = *plRam00000001038e67e0;
  }
  uVar6 = _UNK_1036d3aa8;
  if (*(uint *)(lVar7 + 0x18) < 2) goto LAB_101fb0984;
  uStack_c0._4_4_ = (float)((ulong)uStack_c0 >> 0x20);
  fVar15 = uStack_c0._4_4_;
  fVar3 = (float)uStack_b8;
  uStack_88 = *(undefined8 *)(lVar7 + 0xa8);
  uStack_90 = *(undefined8 *)(lVar7 + 0xa0);
  uStack_78 = *(undefined8 *)(lVar7 + 0xb8);
  uStack_80 = *(undefined8 *)(lVar7 + 0xb0);
  uStack_a8 = *(undefined8 *)(lVar7 + 0x88);
  uStack_b0 = *(undefined8 *)(lVar7 + 0x80);
  uStack_98 = *(undefined8 *)(lVar7 + 0x98);
  uStack_a0 = *(undefined8 *)(lVar7 + 0x90);
  uVar13 = uStack_b8 & 0xffffffff;
  fVar17 = *(float *)((ulong)&uStack_c0 | 4);
  fVar16 = ((float *)((ulong)&uStack_c0 | 4))[1];
  uStack_c0 = *(undefined8 *)(lVar7 + 0x70);
  uStack_b8 = *(undefined8 *)(lVar7 + 0x78);
  fVar10 = (float)func_0x000100354758(fVar15,uVar13,fVar17,fVar16);
  fVar12 = *(float *)(param_1 + 0x10);
  if (fVar12 == 3.4028235e+38) {
    *(float *)(param_1 + 0x10) = fVar10;
    lVar9 = StardewValley_StardewValley_Game1_get_options_06002fec();
    uVar6 = _UNK_1036d39f0;
    if (lVar9 == 0) goto LAB_101fb0a7c;
    fVar14 = (float)SDV_StardewValley_Options_get_zoomLevel_06003ee1();
    *(float *)(param_1 + 0x14) = fVar10 / fVar14;
    lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar6 = _UNK_1036d3a40;
    if (lVar9 == 0) goto LAB_101fb0a7c;
    uVar11 = StardewValley_StardewValley_Character_get_Position_06003253();
    *(undefined4 *)(param_1 + 0x20) = uVar11;
    lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar6 = _UNK_1036d3a48;
    if (lVar9 == 0) goto LAB_101fb0a7c;
    StardewValley_StardewValley_Character_get_Position_06003253();
    *(float *)(param_1 + 0x24) = fVar12;
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    piVar2 = piRam00000001038d5380;
    uVar6 = _UNK_1036d3a58;
    if ((piRam00000001038d5380 == (int *)0xfffffffffffffff8) ||
       (uVar6 = _UNK_1036d3a50, piRam00000001038d5380 == (int *)0x0)) goto LAB_101fb0a7c;
    iVar1 = piRam00000001038d5380[2];
    if (iVar1 < 0) {
      iVar1 = iVar1 + 1;
    }
    *(float *)(param_1 + 0x28) = (float)(*piRam00000001038d5380 + (iVar1 >> 1));
    iVar1 = piVar2[3];
    if (iVar1 < 0) {
      iVar1 = iVar1 + 1;
    }
    *(float *)(param_1 + 0x2c) = (float)(piVar2[1] + (iVar1 >> 1));
    iVar1 = *piVar2;
    lVar9 = StardewValley_StardewValley_Game1_get_options_06002fec();
    uVar6 = _UNK_1036d3a60;
    if (lVar9 == 0) goto LAB_101fb0a7c;
    fVar12 = (fVar15 + fVar17) * 0.5;
    fVar10 = (float)SDV_StardewValley_Options_get_zoomLevel_06003ee1();
    *(float *)(param_1 + 0x30) = fVar12 / fVar10 + (float)iVar1;
    iVar1 = piRam00000001038d5380[1];
    lVar9 = StardewValley_StardewValley_Game1_get_options_06002fec();
    uVar6 = _UNK_1036d3a70;
    if (lVar9 == 0) goto LAB_101fb0a7c;
    fVar14 = (fVar3 + fVar16) * 0.5;
    fVar10 = (float)SDV_StardewValley_Options_get_zoomLevel_06003ee1();
    *(float *)(param_1 + 0x50) = fVar12;
    *(float *)(param_1 + 0x40) = fVar15;
    *(float *)(param_1 + 0x44) = fVar3;
    *(float *)(param_1 + 0x48) = fVar17;
    *(float *)(param_1 + 0x4c) = fVar16;
    *(float *)(param_1 + 0x58) = fVar12;
    *(float *)(param_1 + 0x5c) = fVar14;
    *(float *)(param_1 + 0x54) = fVar14;
    *(float *)(param_1 + 0x34) = fVar14 / fVar10 + (float)iVar1;
    lVar9 = lRam00000001038d6278;
    uVar6 = _UNK_1036d3a78;
    if ((float *)(param_1 + 0x50) == (float *)0x0) goto LAB_101fb0a7c;
    *(float *)(param_1 + 0x38) =
         *(float *)(param_1 + 0x50) / (float)*(int *)(lRam00000001038d6278 + 8);
    *(float *)(param_1 + 0x3c) = *(float *)(param_1 + 0x54) / (float)*(int *)(lVar9 + 0xc);
    lVar9 = StardewValley_StardewValley_Game1_get_options_06002fec();
    uVar6 = _UNK_1036d3a88;
    if (lVar9 == 0) goto LAB_101fb0a7c;
    uVar11 = SDV_StardewValley_Options_get_zoomLevel_06003ee1();
    *(undefined4 *)(param_1 + 0x70) = uVar11;
  }
  else {
    *(float *)(param_1 + 0x18) = fVar10 / *(float *)(param_1 + 0x14);
    fVar12 = (float)SDV_StardewValley_Mobile_PinchZoom_get_MinZoom_0600667a();
    fVar14 = *(float *)(param_1 + 0x18);
    fVar10 = 4.0;
    if (fVar14 == 4.0) {
LAB_101fb05ec:
      fVar14 = fVar10;
      if (fVar12 == fVar14) goto LAB_101fb05f4;
LAB_101fb07c4:
      if (fVar12 <= fVar14) {
        fVar12 = fVar14;
      }
    }
    else {
      if (!NAN(fVar14)) {
        fVar10 = (float)NEON_fminnm(fVar14,0x40800000);
        goto LAB_101fb05ec;
      }
      if (fVar12 != fVar14) goto LAB_101fb07c4;
LAB_101fb05f4:
      if (-1 < (int)fVar14) {
        fVar12 = fVar14;
      }
    }
    *(float *)(param_1 + 0x18) = fVar12;
    fVar10 = *(float *)(param_1 + 0x5c);
    pfVar8 = (float *)(param_1 + 0x58);
    fVar12 = *pfVar8;
    *pfVar8 = (fVar15 + fVar17) * 0.5;
    *(float *)(param_1 + 0x5c) = (fVar3 + fVar16) * 0.5;
    uVar6 = _UNK_1036d39f8;
    if ((param_1 == -0x50) || (uVar6 = _UNK_1036d3a00, pfVar8 == (float *)0x0)) goto LAB_101fb0a7c;
    fVar15 = *(float *)(param_1 + 0x18);
    *(float *)(param_1 + 0x60) = (*(float *)(param_1 + 0x50) - *(float *)(param_1 + 0x58)) / fVar15;
    *(float *)(param_1 + 100) = (*(float *)(param_1 + 0x54) - *(float *)(param_1 + 0x5c)) / fVar15;
    *(float *)(param_1 + 0x78) = (*(float *)(param_1 + 0x58) - fVar12) / fVar15;
    *(float *)(param_1 + 0x7c) = (*(float *)(param_1 + 0x5c) - fVar10) / fVar15;
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar6 = _UNK_1036d3a08;
    if (piRam00000001038d5380 == (int *)0x0) goto LAB_101fb0a7c;
    if (*(float *)(param_1 + 0x18) != *(float *)(param_1 + 0x70)) {
      *(float *)(param_1 + 0x70) = *(float *)(param_1 + 0x18);
      lVar9 = StardewValley_StardewValley_Game1_get_options_06002fec();
      uVar6 = _UNK_1036d3a30;
      if (lVar9 == 0) goto LAB_101fb0a7c;
      SDV_StardewValley_Options_set_desiredBaseZoomLevel_06003ee3(*(undefined4 *)(param_1 + 0x18));
      *(undefined1 *)(param_1 + 0x1c) = 0;
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar6 = _UNK_1036d3a38;
      if (*plRam00000001038d53a0 == 0) goto LAB_101fb0a7c;
      StardewValley_StardewValley_Game1_refreshWindowSettings_06003005();
      *(undefined1 *)(param_1 + 0x1c) = 1;
    }
    SDV_StardewValley_Mobile_PinchZoom_Center_06006681(param_1);
  }
  *(undefined1 *)(param_1 + 0x1c) = 1;
  *(undefined1 *)(param_1 + 0x74) = 1;
  lVar9 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
  if ((lVar9 != 0) &&
     (lVar9 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8(),
     0 < *(int *)(*(long *)(lVar9 + 0x238) + 0x124))) {
    lVar9 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    uVar6 = _UNK_1036d3a28;
    if (*(long *)(lVar9 + 0x238) == 0) {
LAB_101fb0a7c:
      func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
      pcVar4 = (code *)SoftwareBreakpoint(1,0x101fb0a88);
      (*pcVar4)();
    }
    SDV_StardewValley_Mobile_TapToMove_Reset_06006698(*(long *)(lVar9 + 0x238),1);
  }
  return 1;
}

