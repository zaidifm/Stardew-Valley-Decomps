/* 0x0600676c StardewValley.Mobile.VirtualJoypad.drawJoystickAndButtons @ 0x101fd7eb4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_drawJoystickAndButtons_0600676c
               (long param_1,long param_2)

{
  undefined8 *puVar1;
  int iVar2;
  int iVar3;
  undefined4 uVar4;
  undefined4 uVar5;
  undefined4 uVar6;
  code *pcVar7;
  char cVar8;
  undefined4 uVar9;
  undefined4 uVar10;
  undefined8 *puVar11;
  long *plVar12;
  undefined8 uVar13;
  long lVar14;
  undefined8 uVar15;
  undefined8 uVar16;
  undefined8 *puVar17;
  undefined4 uVar18;
  float fVar19;
  float fVar20;
  undefined8 uStack_198;
  undefined8 uStack_190;
  undefined4 uStack_188;
  undefined8 uStack_180;
  undefined8 uStack_178;
  undefined4 uStack_168;
  undefined4 uStack_164;
  undefined4 uStack_160;
  undefined4 uStack_15c;
  undefined4 uStack_158;
  undefined8 uStack_150;
  undefined8 uStack_148;
  undefined4 uStack_140;
  undefined4 uStack_13c;
  undefined4 uStack_138;
  undefined4 uStack_134;
  undefined4 uStack_130;
  undefined4 uStack_128;
  undefined4 uStack_124;
  undefined4 uStack_120;
  undefined4 uStack_11c;
  undefined4 uStack_118;
  undefined8 uStack_110;
  undefined8 uStack_108;
  undefined8 uStack_100;
  undefined8 uStack_f8;
  undefined4 uStack_f0;
  undefined8 auStack_e0 [2];
  undefined8 auStack_d0 [3];
  undefined4 uStack_b8;
  undefined4 uStack_b4;
  undefined4 uStack_b0;
  undefined4 uStack_ac;
  undefined4 uStack_a8;
  undefined4 uStack_a0;
  undefined4 uStack_9c;
  undefined4 uStack_98;
  undefined4 uStack_94;
  undefined4 uStack_90;
  undefined8 auStack_88 [2];
  undefined8 auStack_78 [3];
  
  cVar8 = cRam000000010391157b;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar8 == '\0') {
    func_0x00010119b908(&UNK_103325e82);
    cRam000000010391157b = '\x01';
  }
  cVar8 = SDV_StardewValley_Mobile_VirtualJoypad_get_showJoystick_06006750();
  if ((cVar8 == '\0') && (*(char *)(param_1 + 0x107) == '\0')) {
    *(undefined4 *)(param_1 + 0x15c) = 0;
    return;
  }
  SDV_StardewValley_Mobile_VirtualJoypad_UpdateButtonSizes_06006759(param_1);
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
    lVar14 = *(long *)(param_1 + 0x70);
  }
  else {
    lVar14 = *(long *)(param_1 + 0x70);
  }
  uVar13 = _UNK_1036d93b8;
  if (lVar14 != 0) {
    uStack_108 = *(undefined8 *)(lVar14 + 0x40);
    uStack_110 = *(undefined8 *)(lVar14 + 0x38);
    puVar1 = (undefined8 *)(param_1 + 0x130);
    uVar16 = *puRam00000001038d5350;
    uStack_11c = (undefined4)*(undefined8 *)(param_1 + 0x138);
    uStack_118 = (undefined4)((ulong)*(undefined8 *)(param_1 + 0x138) >> 0x20);
    uStack_124 = (undefined4)*(undefined8 *)(param_1 + 0x130);
    uStack_120 = (undefined4)((ulong)*(undefined8 *)(param_1 + 0x130) >> 0x20);
    uStack_128 = 1;
    uStack_f8 = CONCAT44(uStack_11c,uStack_120);
    uStack_100 = CONCAT44(uStack_124,1);
    cVar8 = *(char *)(param_1 + 0x106);
    uStack_f0 = uStack_118;
    uVar9 = func_0x000100331988();
    uVar9 = func_0x0001003519f4(*(undefined4 *)(param_1 + 300),uVar9);
    if (cVar8 == '\0') {
      puVar11 = auStack_d0;
      puVar17 = auStack_e0;
    }
    else {
      uVar9 = func_0x0001003519f4(0x40000000,uVar9);
      puVar11 = auStack_78;
      puVar17 = auStack_88;
    }
    uVar9 = func_0x0001003519f4(*(undefined4 *)(param_1 + 0x15c),uVar9);
    puVar17[1] = uStack_108;
    *puVar17 = uStack_110;
    puVar11[1] = uStack_f8;
    *puVar11 = uStack_100;
    *(undefined4 *)(puVar11 + 2) = uStack_f0;
    uVar13 = _UNK_1036d93c0;
    if (puVar1 == (undefined8 *)0x0) goto LAB_101fd8418;
    iVar2 = *(int *)(param_1 + 0x138);
    iVar3 = *(int *)(param_1 + 0x13c);
    uStack_190 = puVar11[1];
    uStack_198 = *puVar11;
    uStack_188 = *(undefined4 *)(puVar11 + 2);
    uVar13 = _UNK_1036d93c8;
    if (param_2 == 0) goto LAB_101fd8418;
    if (iVar2 < 0) {
      iVar2 = iVar2 + 1;
    }
    if (iVar3 < 0) {
      iVar3 = iVar3 + 1;
    }
    func_0x00010035615c(0,(float)(iVar2 >> 1),(float)(iVar3 >> 1),0x3a83126f,param_2,uVar16,*puVar17
                        ,puVar17[1],&uStack_198,uVar9,0);
    lVar14 = StardewValley_StardewValley_Game1_get_options_06002fec();
    if ((*(int *)(lVar14 + 0x178) != 4) &&
       (lVar14 = StardewValley_StardewValley_Game1_get_options_06002fec(),
       *(int *)(lVar14 + 0x178) != 8)) {
      lVar14 = StardewValley_StardewValley_Game1_get_options_06002fec();
      if ((*(int *)(lVar14 + 0x178) != 5) &&
         (lVar14 = StardewValley_StardewValley_Game1_get_options_06002fec(),
         *(int *)(lVar14 + 0x178) != 6)) goto LAB_101fd8264;
      lVar14 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar13 = _UNK_1036d93f8;
      if (lVar14 == 0) goto LAB_101fd8418;
      puVar11 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
      if ((puVar11 == (undefined8 *)0x0) ||
         (lRam00000001038c7a50 != *(long *)(*(long *)(*(long *)*puVar11 + 0x10) + 0x18)))
      goto LAB_101fd8264;
      lVar14 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar13 = _UNK_1036d9400;
      if (lVar14 == 0) goto LAB_101fd8418;
      plVar12 = (long *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
      cVar8 = (**(code **)(*plVar12 + 0x3f8))();
      if (cVar8 != '\0') goto LAB_101fd8264;
    }
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    lVar14 = *(long *)(param_1 + 0x78);
    uVar13 = _UNK_1036d93d8;
    if (lVar14 != 0) {
      uVar16 = *(undefined8 *)(lVar14 + 0x38);
      uVar13 = *(undefined8 *)(lVar14 + 0x40);
      uStack_178 = *(undefined8 *)(param_1 + 0x138);
      uStack_180 = *puVar1;
      uVar15 = *puRam00000001038d5350;
      uStack_ac = (undefined4)uStack_178;
      uVar5 = uStack_ac;
      uStack_a8 = (undefined4)((ulong)uStack_178 >> 0x20);
      uVar6 = uStack_a8;
      uStack_b4 = (undefined4)uStack_180;
      uVar9 = uStack_b4;
      uStack_b0 = (undefined4)((ulong)uStack_180 >> 0x20);
      uVar4 = uStack_b0;
      uStack_b8 = 1;
      if ((*(char *)(param_1 + 0x159) == '\0') || (*(char *)(param_1 + 0xd8) == '\0')) {
        uVar10 = func_0x000100331988();
        uVar18 = *(undefined4 *)(param_1 + 300);
      }
      else {
        uVar10 = func_0x000100331988();
        uVar10 = func_0x0001003519f4(*(undefined4 *)(param_1 + 300),uVar10);
        uVar18 = 0x40000000;
      }
      uVar10 = func_0x0001003519f4(uVar18,uVar10);
      uVar10 = func_0x0001003519f4(*(undefined4 *)(param_1 + 0x15c),uVar10);
      iVar2 = *(int *)(param_1 + 0x138);
      iVar3 = *(int *)(param_1 + 0x13c);
      if (iVar2 < 0) {
        iVar2 = iVar2 + 1;
      }
      if (iVar3 < 0) {
        iVar3 = iVar3 + 1;
      }
      uStack_168 = 1;
      uStack_164 = uVar9;
      uStack_160 = uVar4;
      uStack_15c = uVar5;
      uStack_158 = uVar6;
      func_0x00010035615c(0,(float)(iVar2 >> 1),(float)(iVar3 >> 1),0x3a83126f,param_2,uVar15,uVar16
                          ,uVar13,&uStack_168,uVar10,0);
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      lVar14 = *(long *)(param_1 + 0x80);
      uVar13 = _UNK_1036d93e0;
      if (lVar14 != 0) {
        uVar13 = *(undefined8 *)(lVar14 + 0x38);
        uVar16 = *(undefined8 *)(lVar14 + 0x40);
        uVar15 = *puRam00000001038d5350;
        uStack_148 = *(undefined8 *)(param_1 + 0x138);
        uStack_150 = *puVar1;
        uStack_94 = (undefined4)uStack_148;
        uVar5 = uStack_94;
        uStack_90 = (undefined4)((ulong)uStack_148 >> 0x20);
        uVar6 = uStack_90;
        uStack_9c = (undefined4)uStack_150;
        uVar9 = uStack_9c;
        uStack_98 = (undefined4)((ulong)uStack_150 >> 0x20);
        uVar4 = uStack_98;
        uStack_a0 = 1;
        if ((*(char *)(param_1 + 0x15a) == '\0') || (*(char *)(param_1 + 0xd9) == '\0')) {
          uVar10 = func_0x000100331988();
          uVar18 = *(undefined4 *)(param_1 + 300);
        }
        else {
          uVar10 = func_0x000100331988();
          uVar10 = func_0x0001003519f4(*(undefined4 *)(param_1 + 300),uVar10);
          uVar18 = 0x40000000;
        }
        uVar10 = func_0x0001003519f4(uVar18,uVar10);
        uVar10 = func_0x0001003519f4(*(undefined4 *)(param_1 + 0x15c),uVar10);
        iVar2 = *(int *)(param_1 + 0x138);
        iVar3 = *(int *)(param_1 + 0x13c);
        if (iVar2 < 0) {
          iVar2 = iVar2 + 1;
        }
        if (iVar3 < 0) {
          iVar3 = iVar3 + 1;
        }
        uStack_140 = 1;
        uStack_13c = uVar9;
        uStack_138 = uVar4;
        uStack_134 = uVar5;
        uStack_130 = uVar6;
        func_0x00010035615c(0,(float)(iVar2 >> 1),(float)(iVar3 >> 1),0x3a83126f,param_2,uVar15,
                            uVar13,uVar16,&uStack_140,uVar10,0);
LAB_101fd8264:
        if (*(float *)(param_1 + 0x15c) < 1.0) {
          fVar20 = *(float *)(param_1 + 0x15c) + *(float *)(param_1 + 0x160);
          fVar19 = 1.0;
          if ((fVar20 != 1.0) && (fVar19 = fVar20, !NAN(fVar20))) {
            fVar19 = (float)NEON_fminnm(fVar20,0x3f800000);
          }
          *(float *)(param_1 + 0x15c) = fVar19;
        }
        return;
      }
    }
  }
LAB_101fd8418:
  func_0x0001003316f4(0xee,uVar13);
                    /* WARNING: Does not return */
  pcVar7 = (code *)SoftwareBreakpoint(1,0x101fd8424);
  (*pcVar7)();
}

