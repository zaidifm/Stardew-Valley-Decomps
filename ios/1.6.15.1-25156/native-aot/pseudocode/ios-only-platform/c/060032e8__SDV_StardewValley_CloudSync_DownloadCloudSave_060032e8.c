/* 0x060032e8 StardewValley.CloudSync.DownloadCloudSave @ 0x1000aa240 */

/* WARNING: Removing unreachable block (ram,0x0001000aae24) */
/* WARNING: Removing unreachable block (ram,0x0001000abc2c) */
/* WARNING: Removing unreachable block (ram,0x0001000abc38) */
/* WARNING: Removing unreachable block (ram,0x0001000abc70) */
/* WARNING: Removing unreachable block (ram,0x0001000abc74) */
/* WARNING: Removing unreachable block (ram,0x0001000abdf8) */
/* WARNING: Removing unreachable block (ram,0x0001000abe24) */
/* WARNING: Removing unreachable block (ram,0x0001000abe34) */
/* WARNING: Removing unreachable block (ram,0x0001000abe38) */
/* WARNING: Removing unreachable block (ram,0x0001000abcf4) */
/* WARNING: Removing unreachable block (ram,0x0001000abd08) */
/* WARNING: Removing unreachable block (ram,0x0001000abd0c) */
/* WARNING: Removing unreachable block (ram,0x0001000abd98) */
/* WARNING: Removing unreachable block (ram,0x0001000abdb4) */
/* WARNING: Removing unreachable block (ram,0x0001000abdc4) */
/* WARNING: Removing unreachable block (ram,0x0001000abdc8) */
/* WARNING: Removing unreachable block (ram,0x0001000abd58) */
/* WARNING: Removing unreachable block (ram,0x0001000abd6c) */
/* WARNING: Removing unreachable block (ram,0x0001000abd70) */

long SDV_StardewValley_CloudSync_DownloadCloudSave_060032e8
               (undefined1 param_1 [16],ulong param_2,undefined8 param_3,long param_4)

{
  uint uVar1;
  long lVar2;
  int *piVar3;
  bool bVar4;
  char cVar5;
  int iVar6;
  long lVar7;
  long lVar8;
  undefined8 uVar9;
  long lVar10;
  long *plVar11;
  ulong uVar12;
  long *plVar13;
  undefined8 uVar14;
  undefined8 extraout_x17;
  undefined8 extraout_x17_00;
  ulong uVar15;
  float fVar16;
  int iVar17;
  int iVar18;
  int iStack_3e0;
  uint uStack_3dc;
  undefined8 uStack_3d8;
  float fStack_3d0;
  float fStack_3cc;
  undefined4 uStack_3c8;
  undefined4 uStack_3c4;
  undefined8 uStack_3c0;
  undefined8 uStack_3b8;
  undefined8 uStack_3b0;
  undefined8 uStack_3a8;
  undefined8 uStack_3a0;
  long *plStack_398;
  undefined8 uStack_390;
  undefined8 uStack_388;
  long *plStack_380;
  int iStack_378;
  int iStack_374;
  int iStack_370;
  int iStack_36c;
  int *piStack_368;
  long lStack_360;
  long lStack_350;
  long lStack_340;
  undefined4 uStack_330;
  undefined4 uStack_32c;
  long lStack_328;
  undefined8 uStack_2d0;
  undefined8 uStack_2c8;
  undefined1 *puStack_2c0;
  undefined8 uStack_2b8;
  undefined8 uStack_278;
  undefined8 uStack_270;
  undefined8 uStack_268;
  undefined8 uStack_260;
  undefined8 uStack_258;
  undefined8 uStack_250;
  undefined1 auStack_248 [8];
  undefined8 uStack_240;
  long lStack_238;
  long lStack_228;
  long lStack_1e0;
  undefined8 uStack_1d8;
  undefined8 uStack_1d0;
  undefined8 uStack_148;
  undefined8 uStack_140;
  undefined8 uStack_138;
  undefined8 uStack_130;
  undefined8 uStack_128;
  undefined1 uStack_120;
  undefined8 uStack_118;
  long *plStack_110;
  long *plStack_108;
  long lStack_100;
  long lStack_f8;
  long lStack_f0;
  undefined8 uStack_90;
  undefined8 uStack_88;
  undefined8 uStack_80;
  undefined8 uStack_78;
  undefined8 uStack_70;
  undefined8 uStack_68;
  long *plStack_60;
  undefined8 uStack_58;
  long *plStack_50;
  undefined8 uStack_48;
  undefined8 uStack_40;
  long *plStack_38;
  undefined8 uStack_30;
  long *plStack_28;
  undefined8 uStack_20;
  undefined8 uStack_18;
  long lStack_10;
  long lStack_8;
  
  if (*plRam00000001037fff88 != 0) {
    func_0x0001003316e0();
  }
  uStack_148 = 0;
  uStack_140 = 0;
  uStack_138 = 0;
  uStack_130 = 0;
  uStack_128 = 0;
  uStack_120 = 0;
  uStack_118 = 0;
  plStack_110 = (long *)0x0;
  plStack_108 = (long *)0x0;
  lVar7 = func_0x000100331820(uRam0000000103800dd0,0x18);
  lStack_8 = lVar7;
  func_0x000100357a98(&uStack_130,&uStack_128);
  *(undefined8 *)(lStack_8 + 0x10) = 0;
  lVar8 = func_0x000100331820(uRam0000000103800dd8,0x18);
  lStack_10 = lVar8;
  uStack_18 = func_0x000100331820(uRam0000000103800ce0,0x18);
  func_0x0001003577f0(uStack_18,0);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lStack_10 + 0x10U) = uStack_18;
  *(undefined1 *)((lStack_10 + 0x10U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
  uStack_68 = uRam0000000103800ce8;
  plStack_38 = (long *)func_0x000100331794(uRam0000000103800cf0,2);
  uStack_20 = uRam0000000103800cf8;
  plStack_28 = plStack_38;
  uStack_30 = func_0x000100331870(uRam0000000103800d00);
  func_0x0001003833dc(uStack_30,uStack_20);
  (**(code **)(*plStack_28 + 0x110))(plStack_28,0,uStack_30);
  plStack_50 = plStack_38;
  plStack_60 = plStack_38;
  uStack_40 = *(undefined8 *)(param_4 + 0x18);
  uStack_48 = func_0x000100331870(uRam0000000103800d08);
  func_0x0001003833f0(uStack_48,uStack_40);
  uStack_58 = func_0x000100331870(uRam0000000103800d10);
  func_0x000100383404(uStack_58,uStack_48,0);
  (**(code **)(*plStack_50 + 0x110))(plStack_50,1,uStack_58);
  uVar9 = func_0x000100383418(uStack_68,plStack_60);
  uStack_70 = uRam0000000103800d18;
  uStack_78 = func_0x000100331870(uRam0000000103800d20);
  func_0x000100357ac0(uStack_78,uStack_70,uVar9);
  uStack_80 = func_0x000100331870(uRam0000000103800d28);
  func_0x000100357ad4(uStack_80,uStack_78);
  uVar9 = uStack_80;
  func_0x000100357afc(uStack_80,uStack_128);
  func_0x000100357b10(uVar9,1);
  uStack_88 = func_0x000100331794(uRam0000000103800990,2);
  func_0x000100331f8c(uStack_88,0,uRam0000000103800d70);
  uStack_90 = uStack_88;
  func_0x000100331f8c(uStack_88,1,uRam0000000103800d78);
  func_0x000100357ae8(uVar9,uStack_90);
  func_0x000100357b24(uVar9,0x19);
  uVar14 = 0x1000aa534;
  if (lVar7 != 0) {
    lVar10 = func_0x000100331820(uRam0000000103800d30,0x80);
    uVar14 = 0x1000aa558;
    if (lVar7 != 0) {
      DataMemoryBarrier(2,3);
      *(long *)(lVar10 + 0x20) = lVar7;
      *(undefined1 *)((lVar10 + 0x20U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
      lVar2 = lRam0000000103800de0;
      *(long *)(lVar10 + 0x40) = lRam0000000103800de0;
      *(undefined8 *)(lVar10 + 0x28) = uRam0000000103800de8;
      *(undefined8 *)(lVar10 + 0x18) = *(undefined8 *)(lVar2 + 0x30);
      *(undefined8 *)(lVar10 + 0x10) = *(undefined8 *)(lVar2 + 0x28);
      func_0x000100357b38(uVar9);
      uVar14 = 0x1000aa5d4;
      if (lVar8 == 0) goto LAB_1000aab90;
      lVar10 = func_0x000100331820(uRam0000000103800d48,0x80);
      uVar14 = 0x1000aa5f8;
      if (lVar8 != 0) {
        DataMemoryBarrier(2,3);
        *(long *)(lVar10 + 0x20) = lVar8;
        *(undefined1 *)((lVar10 + 0x20U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
        lVar2 = lRam0000000103800df0;
        *(long *)(lVar10 + 0x40) = lRam0000000103800df0;
        *(undefined8 *)(lVar10 + 0x28) = uRam0000000103800df8;
        *(undefined8 *)(lVar10 + 0x18) = *(undefined8 *)(lVar2 + 0x30);
        *(undefined8 *)(lVar10 + 0x10) = *(undefined8 *)(lVar2 + 0x28);
        func_0x000100357b4c(uVar9);
        func_0x000100357b60(uStack_130,uVar9);
        func_0x000100357818(*(undefined8 *)(lVar8 + 0x10));
        if (*(long *)(lVar7 + 0x10) == 0) {
          lVar7 = 0;
        }
        else {
          plVar11 = (long *)func_0x00010037f14c(*(undefined8 *)(lVar7 + 0x10),uRam0000000103800d78);
          if ((plVar11 != (long *)0x0) && (*plVar11 != lRam0000000103800d90)) {
            plVar11 = (long *)0x0;
          }
          uVar9 = func_0x000100383508(plVar11);
          uVar9 = func_0x00010038351c(uVar9);
          uVar9 = func_0x000100357980(uVar9);
          uVar14 = func_0x00010037f138(*(undefined8 *)(lVar7 + 0x10));
          uStack_78 = uVar9;
          uStack_80 = func_0x000100331820(uRam0000000103800e00,0x28);
          func_0x000100332630(uStack_80,uStack_78,1);
          uStack_88 = uStack_80;
          uStack_90 = func_0x000100331820(uRam0000000103800420,0x40);
          func_0x00010036c858(uStack_90,uStack_88);
          uVar9 = uStack_90;
          lVar7 = func_0x000100331794(uRam0000000103800010,0x1000);
          func_0x000100383530(*(undefined8 *)(param_4 + 0x18),&uStack_148,&uStack_140,&uStack_138);
          cVar5 = func_0x000100351774(uStack_148);
          if (cVar5 == '\0') {
            func_0x000100351788(uStack_148);
          }
          plStack_110 = (long *)func_0x000100365e90(uStack_140,2);
          iVar6 = func_0x00010034fe38(uVar9);
          uVar15 = (ulong)iVar6;
          do {
            if (*plRam00000001037fff88 != 0) {
              func_0x0001003316e0();
            }
            uVar12 = (ulong)*(int *)(lVar7 + 0x18);
            if ((int)uVar15 < *(int *)(lVar7 + 0x18)) {
              uVar12 = uVar15;
            }
            iVar6 = func_0x000100383544(uVar9,lVar7,0,uVar12);
            (**(code **)(*plStack_110 + 0x90))(plStack_110,lVar7,0,(long)iVar6);
            uVar15 = (ulong)(uint)((int)uVar15 - iVar6);
          } while (*(int *)(lVar7 + 0x18) <= iVar6);
          lStack_100 = 0;
          func_0x0001000aa938();
          if (lStack_100 != 0) {
            func_0x000100331ba4();
          }
          plStack_108 = (long *)func_0x000100365e90(uStack_138,2);
          iVar6 = func_0x00010034fe38(uVar9);
          uVar15 = (ulong)iVar6;
          do {
            if (*plRam00000001037fff88 != 0) {
              func_0x0001003316e0();
            }
            uVar12 = (ulong)*(int *)(lVar7 + 0x18);
            if ((int)uVar15 < *(int *)(lVar7 + 0x18)) {
              uVar12 = uVar15;
            }
            iVar6 = func_0x000100383544(uVar9,lVar7,0,uVar12);
            (**(code **)(*plStack_108 + 0x90))(plStack_108,lVar7,0,(long)iVar6);
            uVar15 = (ulong)(uint)((int)uVar15 - iVar6);
          } while (*(int *)(lVar7 + 0x18) <= iVar6);
          lStack_f8 = 0;
          func_0x0001000aaa54();
          if (lStack_f8 != 0) {
            func_0x000100331ba4();
          }
          func_0x000100383558(uStack_140,*(undefined8 *)(param_4 + 0x38));
          func_0x000100383558(uStack_138,*(undefined8 *)(param_4 + 0x38));
          func_0x000100383328(*(undefined8 *)(param_4 + 0x18),uVar14,0);
          lStack_f0 = 0;
          func_0x0001000aaafc();
          if (lStack_f0 != 0) {
            func_0x000100331ba4();
          }
          lVar7 = 1;
        }
        return lVar7;
      }
    }
    func_0x000100382ea0(0xee,uVar14);
    uVar14 = extraout_x17;
  }
LAB_1000aab90:
  lVar7 = func_0x000100382ea0(0x69,uVar14);
  uStack_2b8 = 0x1000aab9c;
  puStack_2c0 = &stack0xfffffffffffffe40;
  if (*plRam00000001037fff88 != 0) {
    puStack_2c0 = &stack0xfffffffffffffe40;
    func_0x0001003316e0();
  }
  uStack_260 = 0;
  uStack_258 = 0;
  uStack_250 = 0;
  auStack_248[0] = 0;
  uStack_278 = 0;
  uStack_270 = 0;
  uStack_268 = 0;
  uStack_240 = 0;
  lVar8 = func_0x000100331820(uRam0000000103800e08,0x18);
  func_0x000100357a98(&uStack_260,&uStack_258);
  lVar10 = func_0x000100331820(uRam0000000103800e10,0x20);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar10 + 0x10U) = *puRam0000000103800e18;
  *(undefined1 *)((lVar10 + 0x10U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
  uVar9 = *(undefined8 *)(lVar7 + 0x10);
  auStack_248[0] = 0;
  uStack_250 = uVar9;
  lStack_1e0 = lVar10;
  iVar6 = func_0x000103141e78(uVar9,auStack_248);
  if (iVar6 == 0) {
    func_0x000100331bb8(uVar9,auStack_248);
  }
  func_0x00010035458c(&uStack_278);
  while (cVar5 = func_0x0001003545a0(&uStack_278), cVar5 != '\0') {
    if (*plRam00000001037fff88 != 0) {
      func_0x0001003316e0();
    }
    uVar9 = uStack_268;
    lStack_1e0 = func_0x000100331870(uRam0000000103800d08);
    func_0x0001003833f0(lStack_1e0,uVar9);
    *(int *)(lVar10 + 0x1c) = *(int *)(lVar10 + 0x1c) + 1;
    plVar11 = *(long **)(lVar10 + 0x10);
    uVar1 = *(uint *)(lVar10 + 0x18);
    if (uVar1 < *(uint *)(plVar11 + 3)) {
      *(uint *)(lVar10 + 0x18) = uVar1 + 1;
      (**(code **)(*plVar11 + 0x110))(plVar11,(long)(int)uVar1,lStack_1e0);
    }
    else {
      func_0x000100383580(lVar10,lStack_1e0);
    }
  }
  lStack_238 = 0;
  func_0x0001000aadb8();
  if (lStack_238 != 0) {
    func_0x000100331ba4();
  }
  lVar7 = *(long *)(lVar7 + 0x28);
  *(int *)(lVar7 + 0x1c) = *(int *)(lVar7 + 0x1c) + 1;
  iVar6 = *(int *)(lVar7 + 0x18);
  *(undefined4 *)(lVar7 + 0x18) = 0;
  if (0 < iVar6) {
    func_0x000100331c80(*(undefined8 *)(lVar7 + 0x10),0,(long)iVar6);
  }
  lStack_228 = 0;
  func_0x0001000aae44();
  if (lStack_228 != 0) {
    func_0x000100331ba4();
  }
  uStack_1d0 = func_0x000100331820(uRam0000000103800ce0,0x18);
  func_0x0001003577f0(uStack_1d0,0);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar8 + 0x10U) = uStack_1d0;
  *(undefined1 *)((lVar8 + 0x10U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
  uStack_1d8 = func_0x000100383594(lVar10);
  lStack_1e0 = func_0x000100331870(uRam0000000103800da0);
  func_0x0001003834b8(lStack_1e0,0,uStack_1d8);
  lVar7 = lStack_1e0;
  func_0x0001003834cc(lStack_1e0,2);
  func_0x000100357b24(lVar7,0x19);
  uVar9 = 0x1000aaf3c;
  if (lVar8 != 0) {
    lVar10 = func_0x000100331820(uRam0000000103800da8,0x80);
    if (lVar8 != 0) {
      DataMemoryBarrier(2,3);
      *(long *)(lVar10 + 0x20) = lVar8;
      *(undefined1 *)((lVar10 + 0x20U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
      lVar2 = lRam0000000103800e30;
      *(long *)(lVar10 + 0x40) = lRam0000000103800e30;
      *(undefined8 *)(lVar10 + 0x28) = uRam0000000103800e38;
      *(undefined8 *)(lVar10 + 0x18) = *(undefined8 *)(lVar2 + 0x30);
      *(undefined8 *)(lVar10 + 0x10) = *(undefined8 *)(lVar2 + 0x28);
      func_0x0001003834e0(lVar7);
      func_0x000100357b60(uStack_260,lVar7);
      lVar7 = func_0x000100357818(*(undefined8 *)(lVar8 + 0x10));
      return lVar7;
    }
    func_0x000100382ea0(0xee,0x1000aaf60);
    uVar9 = extraout_x17_00;
  }
  lVar7 = func_0x000100382ea0(0x69,uVar9);
  if (*plRam00000001037fff88 != 0) {
    func_0x0001003316e0();
  }
  iStack_370 = 0;
  iStack_36c = 0;
  iStack_378 = 0;
  iStack_374 = 0;
  uStack_390 = 0;
  uStack_388 = 0;
  plStack_380 = (long *)0x0;
  uStack_3a8 = 0;
  uStack_3a0 = 0;
  plStack_398 = (long *)0x0;
  uStack_3c0 = 0;
  uStack_3b8 = 0;
  uStack_3b0 = 0;
  uStack_3c8 = 0;
  uStack_3c4 = 0;
  *(undefined1 *)(lVar7 + 0x17f) = 1;
  if (*(long *)(lVar7 + 0x18) == 0) {
    bVar4 = true;
  }
  else {
    bVar4 = *(int *)(*(long *)(lVar7 + 0x18) + 0x10) == 0;
  }
  if ((!bVar4) &&
     (cVar5 = func_0x00010035011c(*(undefined8 *)(lVar7 + 0x18),uRam0000000103800e48), cVar5 != '\0'
     )) {
    if (*(char *)(lVar7 + 0x17e) != '\0') {
      lVar8 = func_0x0001003518a0();
      func_0x000100346bf8(*(undefined8 *)(lVar8 + 0x1f8),*(undefined8 *)(lVar7 + 0x18));
    }
    if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    func_0x000100346c20(*puRam0000000103800e58,*(undefined8 *)(lVar7 + 0x18));
  }
  func_0x00010035944c(lVar7);
  func_0x000100353128(3);
  func_0x0001003835a8(lVar7);
  cVar5 = func_0x000100345aa0(*(undefined8 *)(lVar7 + 0x18),uRam0000000103800e60);
  if (cVar5 != '\0') {
    func_0x00010035f0e0(uRam0000000103800e68,1,1);
    uVar9 = func_0x0001003518a0();
    lVar8 = func_0x000100351d28(uVar9);
    func_0x00010035d010(*(undefined8 *)(lVar8 + 0x148),uRam0000000103800e70);
  }
  lVar8 = func_0x0001003518a0();
  *(undefined1 *)(lVar8 + 0x76e) = 0;
  lVar8 = func_0x0001003518a0();
  *(undefined1 *)(lVar8 + 0x773) = 0;
  func_0x0001003528a4(1);
  cVar5 = func_0x0001003524a8();
  if (cVar5 != '\0') {
    fVar16 = (float)func_0x0001003524d0();
    param_2 = 0x3f800000;
    if (fVar16 < 1.0) goto LAB_1000ab2a8;
  }
  func_0x000100354ac8();
LAB_1000ab2a8:
  if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  *puRam0000000103800e80 = 1;
  func_0x000100353100(1);
  func_0x00010037fafc(5,3,4);
  *(int *)(lVar7 + 0x124) = *(int *)(lVar7 + 0x124) + 2;
  *puRam0000000103800e88 = 0;
  if (*(char *)(lVar7 + 0x118) == '\0') {
    uVar9 = func_0x0001003518a0();
    lVar7 = func_0x000100353920(uVar9);
  }
  else {
    if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    *piRam0000000103800e90 = 0x898;
    if ((*(long *)(lVar7 + 0x60) != 0) &&
       ((cVar5 = func_0x000100359938(lVar7,uRam0000000103800e98), cVar5 != '\0' ||
        (cVar5 = func_0x000100359938(lVar7,uRam0000000103800ea0), cVar5 != '\0')))) {
      if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      *piRam0000000103800e90 = 0x960;
    }
    if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    iVar6 = ((*piRam0000000103800e90 / 100) * 0x3c + *piRam0000000103800e90 % 100) -
            ((*piRam0000000103800ea8 / 100) * 0x3c + *piRam0000000103800ea8 % 100);
    cVar5 = func_0x000100351fa8();
    if (cVar5 == '\0') {
      func_0x0001003518a0();
      plVar11 = (long *)func_0x000100351954();
      piStack_368 = &iStack_378;
      uVar9 = (**(code **)(*plVar11 + 0x6e8))(plVar11);
      *(undefined8 *)piStack_368 = uVar9;
      func_0x0001003594b0(lVar7,uRam0000000103800eb0,(long)iStack_378,(long)iStack_374);
    }
    else {
      plVar11 = (long *)func_0x000100354a78();
      piStack_368 = &iStack_370;
      uVar9 = (**(code **)(*plVar11 + 0x648))(plVar11);
      *(undefined8 *)piStack_368 = uVar9;
      func_0x0001003594b0(lVar7,uRam0000000103800eb0,(long)iStack_370,(long)iStack_36c);
    }
    lVar8 = func_0x0001003518a0();
    *(undefined8 *)(lVar8 + 0x430) = 0;
    *(undefined1 *)(lVar7 + 0x118) = 0;
    func_0x00010035340c(&uStack_390);
    while (cVar5 = func_0x000100353470(&uStack_390), cVar5 != '\0') {
      if (*plRam00000001037fff88 != 0) {
        func_0x0001003316e0();
      }
      if (plStack_380 != (long *)0x0) {
        func_0x000100359dfc(lVar7,plStack_380);
      }
    }
    lStack_360 = 0;
    func_0x0001000ab5e8();
    if (lStack_360 != 0) {
      func_0x000100331ba4();
    }
    cVar5 = func_0x000100351fa8();
    if (cVar5 != '\0') {
      func_0x000100371830();
      func_0x00010035340c(&uStack_390);
      while (cVar5 = func_0x000100353470(&uStack_390), cVar5 != '\0') {
        if (*plRam00000001037fff88 != 0) {
          func_0x0001003316e0();
        }
        plVar11 = plStack_380;
        lVar7 = func_0x000100354500(plStack_380);
        if (lVar7 == 0) {
LAB_1000ab830:
          lVar7 = func_0x00010035309c(plVar11);
          if ((lVar7 != 0) && (*(long *)(plVar11[0x4a] + 0x60) != 0)) {
            func_0x00010035197c(plVar11[0x5f],0);
            plVar11[0x67] = 0;
            func_0x000100354118(plVar11[0x61],0);
            plVar11[0x15] = 0;
            plVar11[0x4c] = 0;
            (**(code **)(*plVar11 + 0x188))(plVar11);
            uStack_330 = 0x42800000;
            uStack_32c = 0x3c800000;
            fStack_3d0 = *(float *)(plVar11[0x49] + 0x68) * 0.015625;
            fStack_3cc = *(float *)(plVar11[0x49] + 0x6c) * 0.015625;
            param_2 = (ulong)(uint)fStack_3cc;
            func_0x000100354924(fStack_3d0,plVar11,*(undefined8 *)(plVar11[0x4a] + 0x60));
            *(undefined1 *)((long)plVar11 + 0x3b6) = 1;
          }
        }
        else {
          uVar9 = func_0x000100354500(plVar11);
          cVar5 = func_0x00010035becc(uVar9);
          iVar18 = (int)param_2;
          if (cVar5 == '\0') goto LAB_1000ab830;
          plVar11[0x15] = 0;
          plVar11[0x4c] = 0;
          plVar13 = (long *)func_0x000100351954(uVar9);
          (**(code **)(*plVar11 + 0x188))(plVar11);
          uVar14 = func_0x000100342e04(uVar9);
          piStack_368 = (int *)&uStack_3d8;
          uVar14 = func_0x0001003541e0(plVar13,uVar14);
          *(undefined8 *)piStack_368 = uVar14;
          piStack_368 = &iStack_3e0;
          iVar17 = func_0x0001003835bc(uStack_3d8);
          piVar3 = piStack_368;
          *piStack_368 = iVar17;
          piVar3[1] = iVar18;
          param_2 = (ulong)uStack_3dc;
          func_0x000100354938(iStack_3e0,plVar11,plVar13);
          lVar7 = (**(code **)(*plVar13 + 0x6e0))(plVar13);
          if (lVar7 != 0) {
            uVar14 = func_0x000100351954(uVar9);
            func_0x00010035d90c(plVar11,uVar14);
          }
          *(undefined1 *)((long)plVar11 + 0x3b6) = 1;
          if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
            func_0x0001003319b0();
          }
          if (*piRam0000000103800e90 < 0x708) {
            if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
              func_0x0001003319b0();
            }
            if (1099 < *piRam0000000103800e90) {
              (**(code **)(*(long *)plVar11[0x55] + 0x218))((long *)plVar11[0x55]);
              uVar9 = func_0x000100351954(uVar9);
              func_0x00010035efb4(plVar11,0x44c,uVar9);
            }
          }
          else {
            (**(code **)(*(long *)plVar11[0x55] + 0x218))((long *)plVar11[0x55]);
            uVar9 = func_0x000100351954(uVar9);
            func_0x00010035efb4(plVar11,0x708,uVar9);
          }
        }
      }
      lStack_328 = 0;
      func_0x0001000ab994();
      if (lStack_328 != 0) {
        func_0x000100331ba4();
      }
    }
    func_0x000100352868();
    func_0x00010035296c(&uStack_3a8);
    while (cVar5 = func_0x000100352b38(&uStack_3a8), cVar5 != '\0') {
      if (*plRam00000001037fff88 != 0) {
        func_0x0001003316e0();
      }
      plVar11 = plStack_398;
      uStack_2c8 = func_0x0001003831ac(plStack_398[0x17]);
      uStack_2d0 = func_0x000100331820(uRam0000000103800ec0,0x20);
      func_0x00010036e9dc(uStack_2d0,uStack_2c8);
      func_0x00010035c28c(&uStack_3c0);
      while (cVar5 = func_0x00010035c2a0(&uStack_3c0), cVar5 != '\0') {
        if (*plRam00000001037fff88 != 0) {
          func_0x0001003316e0();
        }
        uStack_3c8 = (undefined4)uStack_3b0;
        uStack_3c4 = uStack_3b0._4_4_;
        plVar13 = (long *)func_0x00010035ef14(uStack_3b0 & 0xffffffff,uStack_3b0._4_4_,plVar11[0x17]
                                             );
        cVar5 = (**(code **)(*plVar13 + 0x440))(plVar13,iVar6);
        if (cVar5 != '\0') {
          func_0x000100355568(uStack_3c8,uStack_3c4,plVar11[0x17]);
        }
      }
      lStack_350 = 0;
      func_0x0001000abb14();
      if (lStack_350 != 0) {
        func_0x000100331ba4();
      }
      if ((plVar11 != (long *)0x0) &&
         (*(long *)(*(long *)(*(long *)*plVar11 + 0x10) + 0x10) != lRam0000000103800ee0)) {
        plVar11 = (long *)0x0;
      }
      if (plVar11 != (long *)0x0) {
        (**(code **)(*plVar11 + 0x230))(plVar11,iVar6);
      }
    }
    lStack_340 = 0;
    func_0x0001000abbc8();
    if (lStack_340 != 0) {
      func_0x000100331ba4();
    }
    lVar7 = func_0x0001003518a0();
    *(undefined4 *)(lVar7 + 0x79c) = 0x5dc;
  }
  return lVar7;
}

