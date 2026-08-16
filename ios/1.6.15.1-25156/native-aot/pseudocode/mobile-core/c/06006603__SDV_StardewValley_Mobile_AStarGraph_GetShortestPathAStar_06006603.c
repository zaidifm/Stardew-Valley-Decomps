/* 0x06006603 StardewValley.Mobile.AStarGraph.GetShortestPathAStar @ 0x101fa23f0 */

/* WARNING: Removing unreachable block (ram,0x000101fa2e8c) */
/* WARNING: Removing unreachable block (ram,0x000101fa2c3c) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* WARNING: Restarted to delay deadcode elimination for space: stack */

undefined8
SDV_StardewValley_Mobile_AStarGraph_GetShortestPathAStar_06006603
          (long param_1,long param_2,long param_3)

{
  uint uVar1;
  long lVar2;
  undefined8 uVar3;
  code *pcVar4;
  bool bVar5;
  char cVar6;
  long lVar7;
  long lVar8;
  undefined8 uVar9;
  long lVar10;
  long *plVar11;
  undefined1 auVar12 [16];
  long lStack_260;
  uint uStack_254;
  undefined8 uStack_250;
  undefined8 uStack_248;
  long lStack_240;
  long lStack_238;
  float fStack_22c;
  undefined8 uStack_228;
  long lStack_220;
  long lStack_218;
  undefined4 uStack_20c;
  long lStack_208;
  long lStack_200;
  uint uStack_1f8;
  float fStack_1f4;
  long lStack_1f0;
  float fStack_1e4;
  long lStack_1e0;
  long lStack_1d8;
  long lStack_1d0;
  uint uStack_1c8;
  float fStack_1c4;
  long lStack_1c0;
  float fStack_1b4;
  long lStack_1b0;
  long lStack_1a8;
  long lStack_1a0;
  uint uStack_198;
  float fStack_194;
  long lStack_190;
  float fStack_184;
  long lStack_180;
  long lStack_178;
  long lStack_170;
  uint uStack_168;
  int iStack_164;
  long lStack_160;
  undefined1 auStack_158 [16];
  long lStack_148;
  long lStack_140;
  undefined8 *puStack_138;
  float fStack_12c;
  long lStack_128;
  float fStack_11c;
  long lStack_118;
  long lStack_110;
  float fStack_108;
  int iStack_104;
  long lStack_100;
  int iStack_f4;
  long lStack_f0;
  int iStack_e4;
  long lStack_e0;
  int iStack_d4;
  long lStack_d0;
  long lStack_c8;
  float fStack_bc;
  long lStack_b8;
  long lStack_b0;
  long *plStack_a8;
  uint uStack_9c;
  long lStack_98;
  long lStack_90;
  undefined8 *puStack_88;
  int iStack_7c;
  long lStack_78;
  
  cVar6 = cRam0000000103911412;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar6 == '\0') {
    func_0x00010119b908(&UNK_1033249a0);
    cRam0000000103911412 = '\x01';
  }
  uStack_248 = 0;
  lStack_240 = 0;
  uStack_250 = 0;
  lStack_238 = 0;
  fStack_22c = 0.0;
  if ((param_2 == 0) || (param_3 == 0)) {
    return 0;
  }
  lVar7 = func_0x000100331820(uRam00000001039045a8,0x20);
  lVar2 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar7 + 0x10) = *puRam00000001039045b0;
  *(undefined1 *)(((ulong)(lVar7 + 0x10) >> 9 & 0x7fffff) + lVar2) = 1;
  lVar8 = func_0x000100331820(uRam0000000103904640,0x40);
  func_0x00010037d248();
  plVar11 = *(long **)(lVar7 + 0x10);
  *(int *)(lVar7 + 0x1c) = *(int *)(lVar7 + 0x1c) + 1;
  uVar9 = _UNK_1036d1818;
  if (plVar11 != (long *)0x0) {
    if (*(uint *)(lVar7 + 0x18) < *(uint *)(plVar11 + 3)) {
      *(uint *)(lVar7 + 0x18) = *(uint *)(lVar7 + 0x18) + 1;
      (**(code **)(*plVar11 + 0x110))(plVar11);
    }
    else {
      func_0x00010037d11c(lVar7,param_2);
    }
    bVar5 = false;
    if (*(undefined8 **)(param_1 + 0x10) != (undefined8 *)0x0) {
      if (lRam00000001038c6c08 ==
          *(long *)(*(long *)(*(long *)**(undefined8 **)(param_1 + 0x10) + 0x10) + 0x10)) {
        uVar9 = _UNK_1036d19a0;
        if (param_3 == 0) goto LAB_101fa2e60;
        cVar6 = SDV_StardewValley_Mobile_AStarNode_isBlockingBedTile_0600663c();
        bVar5 = cVar6 == '\0';
      }
      else {
        bVar5 = false;
      }
    }
    uVar9 = _UNK_1036d1998;
    lStack_78 = lVar7;
    if (lVar7 != 0) {
LAB_101fa259c:
      iStack_7c = *(int *)(lStack_78 + 0x18);
      if (iStack_7c < 1) {
        return 0;
      }
      uStack_20c = 0;
      uVar9 = _UNK_1036d1830;
      lStack_218 = lVar7;
      if (lVar7 != 0) {
        if (*(int *)(lVar7 + 0x18) == 0) {
LAB_101fa2cd0:
          func_0x000100331b90();
                    /* WARNING: Does not return */
          pcVar4 = (code *)SoftwareBreakpoint(1,0x101fa2cd8);
          (*pcVar4)();
        }
        uVar9 = _UNK_1036d1850;
        if (*(int *)(*(long *)(lVar7 + 0x10) + 0x18) == 0) {
LAB_101fa2e74:
          func_0x0001003316f4(0xcc,uVar9);
                    /* WARNING: Does not return */
          pcVar4 = (code *)SoftwareBreakpoint(1,0x101fa2e80);
          (*pcVar4)();
        }
        lStack_260 = *(long *)(*(long *)(lVar7 + 0x10) + 0x20);
        uStack_254 = 1;
        lStack_220 = lStack_260;
        uVar1 = uStack_254;
        uVar9 = _UNK_1036d1858;
joined_r0x000101fa261c:
        _UNK_1036d1858 = uVar9;
        uStack_254 = uVar1;
        lStack_160 = lVar7;
        if (lVar7 != 0) {
          do {
            lVar10 = lStack_260;
            iStack_164 = *(int *)(lStack_160 + 0x18);
            if (iStack_164 <= (int)uStack_254) {
              uVar9 = _UNK_1036d1968;
              if ((lVar7 == 0) ||
                 (func_0x00010037d1a8(lVar7,lStack_260), uVar9 = _UNK_1036d1970, lVar8 == 0)) break;
              uVar9 = func_0x00010037d25c(lVar8,lStack_260);
              if (lStack_260 == param_3) {
                uVar9 = SDV_StardewValley_Mobile_AStarGraph_RetracePath_06006604
                                  (param_1,uVar9,param_2,param_3);
                return uVar9;
              }
              uVar9 = _UNK_1036d1978;
              if ((lStack_260 == 0) ||
                 (lVar10 = SDV_StardewValley_Mobile_AStarNode_GetNeighbouringNodeList_0600662d
                                     (lStack_260,1), uVar9 = _UNK_1036d1980, lVar10 == 0)) break;
              func_0x00010037d270(auStack_158);
              uStack_248 = auStack_158._8_8_;
              uStack_250 = auStack_158._0_8_;
              lStack_240 = lStack_148;
              goto LAB_101fa2920;
            }
            uStack_1f8 = uStack_254;
            uVar9 = _UNK_1036d1868;
            lStack_200 = lVar7;
            if (lVar7 == 0) break;
            if (*(uint *)(lVar7 + 0x18) <= uStack_254) goto LAB_101fa2cd0;
            uVar9 = _UNK_1036d1888;
            if (*(uint *)(*(long *)(lVar7 + 0x10) + 0x18) <= uStack_254) goto LAB_101fa2e74;
            lStack_208 = *(long *)(*(long *)(lVar7 + 0x10) + (long)(int)uStack_254 * 8 + 0x20);
            uVar9 = _UNK_1036d1890;
            lStack_1f0 = lStack_208;
            if (lStack_208 == 0) break;
            fStack_1f4 = *(float *)(lStack_208 + 0x28);
            lStack_1e0 = lStack_260;
            uVar9 = _UNK_1036d18a0;
            if (lStack_260 == 0) break;
            fStack_1e4 = *(float *)(lStack_260 + 0x28);
            if (fStack_1f4 < fStack_1e4) {
LAB_101fa2768:
              uStack_198 = uStack_254;
              uVar9 = _UNK_1036d18b0;
              lStack_1a0 = lVar7;
              if (lVar7 == 0) break;
              if (*(uint *)(lVar7 + 0x18) <= uStack_254) goto LAB_101fa2cd0;
              uVar9 = _UNK_1036d18d0;
              if (*(uint *)(*(long *)(lVar7 + 0x10) + 0x18) <= uStack_254) goto LAB_101fa2e74;
              lStack_1a8 = *(long *)(*(long *)(lVar7 + 0x10) + (long)(int)uStack_254 * 8 + 0x20);
              uVar9 = _UNK_1036d18d8;
              lStack_190 = lStack_1a8;
              if (lStack_1a8 == 0) break;
              fStack_194 = *(float *)(lStack_1a8 + 0x30);
              lStack_180 = lStack_260;
              uVar9 = _UNK_1036d18e8;
              if (lStack_260 == 0) break;
              fStack_184 = *(float *)(lStack_260 + 0x30);
              if (fStack_194 < fStack_184) {
                uStack_168 = uStack_254;
                uVar9 = _UNK_1036d18f8;
                lStack_170 = lVar7;
                if (lVar7 == 0) break;
                if (*(uint *)(lVar7 + 0x18) <= uStack_254) goto LAB_101fa2cd0;
                uVar9 = _UNK_1036d1918;
                if (*(uint *)(*(long *)(lVar7 + 0x10) + 0x18) <= uStack_254) goto LAB_101fa2e74;
                lStack_260 = *(long *)(*(long *)(lVar7 + 0x10) + (long)(int)uStack_254 * 8 + 0x20);
                lStack_178 = lStack_260;
              }
            }
            else {
              uStack_1c8 = uStack_254;
              uVar9 = _UNK_1036d1920;
              lStack_1d0 = lVar7;
              if (lVar7 == 0) break;
              if (*(uint *)(lVar7 + 0x18) <= uStack_254) goto LAB_101fa2cd0;
              uVar9 = _UNK_1036d1940;
              if (*(uint *)(*(long *)(lVar7 + 0x10) + 0x18) <= uStack_254) goto LAB_101fa2e74;
              lStack_1d8 = *(long *)(*(long *)(lVar7 + 0x10) + (long)(int)uStack_254 * 8 + 0x20);
              uVar9 = _UNK_1036d1948;
              lStack_1c0 = lStack_1d8;
              if (lStack_1d8 == 0) break;
              fStack_1c4 = *(float *)(lStack_1d8 + 0x28);
              lStack_1b0 = lStack_260;
              uVar9 = _UNK_1036d1958;
              if (lStack_260 == 0) break;
              fStack_1b4 = *(float *)(lStack_260 + 0x28);
              if (fStack_1c4 == fStack_1b4) goto LAB_101fa2768;
            }
            uVar1 = uStack_254 + 1;
            uVar9 = _UNK_1036d1858;
            if (lRam0000000103976fb8 == 0) goto joined_r0x000101fa261c;
            lStack_160 = lVar7;
            func_0x00010119b8f8();
            uVar9 = _UNK_1036d1858;
            uStack_254 = uVar1;
            if (lVar7 == 0) break;
          } while( true );
        }
      }
    }
  }
LAB_101fa2e60:
  func_0x0001003316f4(0xee,uVar9);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101fa2e6c);
  (*pcVar4)();
LAB_101fa2920:
  cVar6 = func_0x00010037d284(&uStack_250);
  if (cVar6 != '\0') {
    puStack_138 = &uStack_250;
    if ((&uStack_250 == (undefined8 *)0x0) ||
       (lStack_238 = lStack_240, lStack_140 = lStack_238, lVar8 == 0)) goto LAB_101fa2c0c;
    cVar6 = func_0x00010037d298(lVar8,lStack_240);
    if (cVar6 == '\0') {
      if (bVar5) {
        if (lStack_238 == 0) goto LAB_101fa2c0c;
        cVar6 = SDV_StardewValley_Mobile_AStarNode_isBlockingBedTile_0600663c();
        if (cVar6 != '\0') goto LAB_101fa2918;
      }
      lStack_128 = lStack_260;
      if ((lStack_260 == 0) || (lStack_260 == 0)) goto LAB_101fa2c0c;
      fStack_12c = *(float *)(lStack_260 + 0x2c);
      fStack_22c = fStack_12c + 1.0;
      lStack_118 = lStack_238;
      if ((lStack_238 == 0) || (lStack_238 == 0)) goto LAB_101fa2c0c;
      fStack_11c = *(float *)(lStack_238 + 0x2c);
      if (fStack_11c <= fStack_22c) {
        if (lVar7 == 0) goto LAB_101fa2c0c;
        cVar6 = func_0x00010037d2ac(lVar7,lStack_238);
        if (cVar6 != '\0') goto LAB_101fa2918;
      }
      lStack_110 = lStack_238;
      fStack_108 = fStack_22c;
      if ((lStack_238 == 0) || (lStack_238 == 0)) {
LAB_101fa2c0c:
        func_0x0001003316f4(0xee,_UNK_1036d1990);
                    /* WARNING: Does not return */
        pcVar4 = (code *)SoftwareBreakpoint(1,0x101fa2f40);
        (*pcVar4)();
      }
      *(float *)(lStack_238 + 0x2c) = fStack_22c;
      lStack_100 = lStack_238;
      if ((lStack_238 == 0) || (lStack_238 == 0)) goto LAB_101fa2c0c;
      iStack_104 = *(int *)(lStack_238 + 0x34);
      lStack_f0 = lStack_238;
      if ((((lStack_238 == 0) || (lStack_238 == 0)) ||
          (iStack_f4 = *(int *)(lStack_238 + 0x38), lStack_e0 = param_3, param_3 == 0)) ||
         (((param_3 == 0 ||
           (iStack_e4 = *(int *)(param_3 + 0x34), lStack_d0 = param_3, param_3 == 0)) ||
          (param_3 == 0)))) goto LAB_101fa2c0c;
      iStack_d4 = *(int *)(param_3 + 0x38);
      lStack_c8 = lStack_238;
      auVar12._0_8_ = (long)(iStack_104 - iStack_e4);
      auVar12._8_8_ = (long)(iStack_f4 - iStack_d4);
      auVar12 = NEON_scvtf(auVar12,8);
      fStack_bc = (float)(auVar12._0_8_ * auVar12._0_8_ + auVar12._8_8_ * auVar12._8_8_);
      if ((lStack_238 == 0) || (lStack_238 == 0)) goto LAB_101fa2c0c;
      *(float *)(lStack_238 + 0x30) = fStack_bc;
      lStack_b8 = lStack_238;
      lStack_b0 = lStack_260;
      if ((lStack_238 == 0) || (lStack_238 == 0)) goto LAB_101fa2c0c;
      DataMemoryBarrier(2,3);
      *(long *)(lStack_238 + 0x10U) = lStack_260;
      *(undefined1 *)((lStack_238 + 0x10U >> 9 & 0x7fffff) + lVar2) = 1;
      if (lVar7 == 0) goto LAB_101fa2c0c;
      cVar6 = func_0x00010037d2ac(lVar7,lStack_238);
      if (cVar6 == '\0') {
        lStack_90 = lStack_238;
        plStack_a8 = (long *)0x0;
        uStack_9c = 0;
        lStack_98 = lVar7;
        if (((((lVar7 == 0) || (lVar7 == 0)) || (lVar7 == 0)) ||
            ((*(int *)(lVar7 + 0x1c) = *(int *)(lVar7 + 0x1c) + 1, lVar7 == 0 ||
             (plStack_a8 = *(long **)(lVar7 + 0x10), lVar7 == 0)))) ||
           (uStack_9c = *(uint *)(lVar7 + 0x18), plStack_a8 == (long *)0x0)) goto LAB_101fa2c0c;
        if (uStack_9c < *(uint *)(plStack_a8 + 3)) {
          if (lVar7 == 0) goto LAB_101fa2c0c;
          *(uint *)(lVar7 + 0x18) = uStack_9c + 1;
          if (plStack_a8 == (long *)0x0) goto LAB_101fa2c0c;
          (**(code **)(*plStack_a8 + 0x110))(plStack_a8,(long)(int)uStack_9c,lStack_238);
        }
        else {
          func_0x00010037d11c(lVar7,lStack_238);
        }
      }
    }
LAB_101fa2918:
    if (lRam0000000103976fb8 != 0) {
      func_0x00010119b8f8();
    }
    goto LAB_101fa2920;
  }
  uStack_228 = 0;
  uVar3 = uStack_228;
  uVar9 = _UNK_1036d1988;
  puStack_88 = &uStack_250;
  if (&uStack_250 == (undefined8 *)0x0) goto LAB_101fa2e60;
  uStack_228 = 0;
  uVar9 = _UNK_1036d1998;
  lStack_78 = lVar7;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
    uVar9 = _UNK_1036d1998;
    uVar3 = uStack_228;
  }
  uStack_228 = uVar3;
  _UNK_1036d1998 = uVar9;
  if (lVar7 == 0) goto LAB_101fa2e60;
  goto LAB_101fa259c;
}

