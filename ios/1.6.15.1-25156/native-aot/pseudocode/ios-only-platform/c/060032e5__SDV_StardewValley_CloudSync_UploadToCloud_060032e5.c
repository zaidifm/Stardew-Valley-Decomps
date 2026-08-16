/* 0x060032e5 StardewValley.CloudSync.UploadToCloud @ 0x1000a98e0 */

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

ulong SDV_StardewValley_CloudSync_UploadToCloud_060032e5
                (undefined1 param_1 [16],ulong param_2,undefined8 param_3,long param_4)

{
  byte bVar1;
  uint uVar2;
  long lVar3;
  int *piVar4;
  bool bVar5;
  char cVar6;
  int iVar7;
  long lVar8;
  long lVar9;
  undefined8 uVar10;
  undefined8 uVar11;
  long lVar12;
  long lVar13;
  long *plVar14;
  ulong uVar15;
  ulong uVar16;
  long *plVar17;
  long extraout_x1;
  undefined8 extraout_x17;
  undefined8 extraout_x17_00;
  undefined8 extraout_x17_01;
  float fVar18;
  int iVar19;
  int iVar20;
  int iStack_510;
  uint uStack_50c;
  undefined8 uStack_508;
  float fStack_500;
  float fStack_4fc;
  undefined4 uStack_4f8;
  undefined4 uStack_4f4;
  undefined8 uStack_4f0;
  undefined8 uStack_4e8;
  undefined8 uStack_4e0;
  undefined8 uStack_4d8;
  undefined8 uStack_4d0;
  long *plStack_4c8;
  undefined8 uStack_4c0;
  undefined8 uStack_4b8;
  long *plStack_4b0;
  int iStack_4a8;
  int iStack_4a4;
  int iStack_4a0;
  int iStack_49c;
  int *piStack_498;
  long lStack_490;
  long lStack_480;
  long lStack_470;
  undefined4 uStack_460;
  undefined4 uStack_45c;
  long lStack_458;
  undefined8 uStack_400;
  undefined8 uStack_3f8;
  undefined1 *puStack_3f0;
  undefined8 uStack_3e8;
  undefined8 uStack_3a8;
  undefined8 uStack_3a0;
  undefined8 uStack_398;
  undefined8 uStack_390;
  undefined8 uStack_388;
  undefined8 uStack_380;
  undefined1 auStack_378 [8];
  undefined8 uStack_370;
  long lStack_368;
  long lStack_358;
  long lStack_310;
  undefined8 uStack_308;
  undefined8 uStack_300;
  undefined1 *puStack_2f0;
  undefined8 uStack_2e8;
  undefined8 uStack_278;
  undefined8 uStack_270;
  undefined8 uStack_268;
  undefined8 uStack_260;
  undefined8 uStack_258;
  undefined1 uStack_250;
  undefined8 uStack_248;
  long *plStack_240;
  long *plStack_238;
  long lStack_230;
  long lStack_228;
  long lStack_220;
  undefined8 uStack_1c0;
  undefined8 uStack_1b8;
  undefined8 uStack_1b0;
  undefined8 uStack_1a8;
  undefined8 uStack_1a0;
  undefined8 uStack_198;
  long *plStack_190;
  undefined8 uStack_188;
  long *plStack_180;
  undefined8 uStack_178;
  undefined8 uStack_170;
  long *plStack_168;
  undefined8 uStack_160;
  long *plStack_158;
  undefined8 uStack_150;
  undefined8 uStack_148;
  long lStack_140;
  long lStack_138;
  undefined8 uStack_f0;
  undefined8 uStack_e8;
  undefined8 uStack_e0;
  long lStack_d8;
  long lStack_90;
  long lStack_88;
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
  uStack_f0 = 0;
  uStack_e8 = 0;
  uStack_e0 = 0;
  lVar8 = func_0x000100331820(uRam0000000103800cd0,0x28);
  *(undefined1 *)(lVar8 + 0x20) = 1;
  *(undefined8 *)(lVar8 + 0x10) = 0;
  func_0x000100357a98(&uStack_f0,&uStack_e8);
  *(undefined8 *)(lVar8 + 0x18) = 0;
  lVar9 = func_0x000100331820(uRam0000000103800cd8,0x20);
  DataMemoryBarrier(2,3);
  *(long *)(lVar9 + 0x18U) = lVar8;
  *(undefined1 *)((lVar9 + 0x18U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
  lStack_10 = lVar9;
  lStack_8 = lVar9;
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
  uVar10 = func_0x000100383418(uStack_68,plStack_60);
  uStack_70 = uRam0000000103800d18;
  uStack_78 = func_0x000100331870(uRam0000000103800d20);
  func_0x000100357ac0(uStack_78,uStack_70,uVar10);
  uStack_80 = func_0x000100331870(uRam0000000103800d28);
  func_0x000100357ad4(uStack_80,uStack_78);
  uVar10 = uStack_80;
  func_0x000100357afc(uStack_80,uStack_e8);
  func_0x000100357b10(uVar10,1);
  uVar11 = func_0x000100331794(uRam0000000103800990,0);
  func_0x000100357ae8(uVar10,uVar11);
  func_0x000100357b24(uVar10,0x19);
  lStack_88 = *(long *)(lVar9 + 0x18);
  uVar11 = 0x1000a9bc8;
  if (lStack_88 != 0) {
    lVar12 = func_0x000100331820(uRam0000000103800d30,0x80);
    lStack_90 = lStack_88;
    uVar11 = 0x1000a9bf4;
    if (lStack_88 != 0) {
      DataMemoryBarrier(2,3);
      *(long *)(lVar12 + 0x20) = lStack_88;
      *(undefined1 *)((lVar12 + 0x20U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
      lVar13 = lRam0000000103800d38;
      *(long *)(lVar12 + 0x40) = lRam0000000103800d38;
      *(undefined8 *)(lVar12 + 0x28) = uRam0000000103800d40;
      *(undefined8 *)(lVar12 + 0x18) = *(undefined8 *)(lVar13 + 0x30);
      *(undefined8 *)(lVar12 + 0x10) = *(undefined8 *)(lVar13 + 0x28);
      func_0x000100357b38(uVar10);
      uVar11 = 0x1000a9c74;
      if (lVar9 == 0) goto LAB_1000aa230;
      lVar12 = func_0x000100331820(uRam0000000103800d48,0x80);
      uVar11 = 0x1000a9c98;
      if (lVar9 != 0) {
        DataMemoryBarrier(2,3);
        *(long *)(lVar12 + 0x20) = lVar9;
        *(undefined1 *)((lVar12 + 0x20U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
        lVar13 = lRam0000000103800d50;
        *(long *)(lVar12 + 0x40) = lRam0000000103800d50;
        *(undefined8 *)(lVar12 + 0x28) = uRam0000000103800d58;
        *(undefined8 *)(lVar12 + 0x18) = *(undefined8 *)(lVar13 + 0x30);
        *(undefined8 *)(lVar12 + 0x10) = *(undefined8 *)(lVar13 + 0x28);
        func_0x000100357b4c(uVar10);
        func_0x000100357b60(uStack_f0,uVar10);
        func_0x000100357818(*(undefined8 *)(lVar9 + 0x10));
        if (*(char *)(lVar8 + 0x20) == '\0') {
          bVar1 = 0;
          lStack_d8 = 0;
          func_0x0001000aa1b8();
          if (lStack_d8 != 0) {
            func_0x000100331ba4();
          }
LAB_1000aa214:
          return (ulong)bVar1;
        }
        uVar10 = func_0x00010038342c();
        func_0x000100383440(uVar10,*(undefined8 *)(param_4 + 0x30));
        lVar9 = func_0x000100331820(uRam0000000103800d60,0x20);
        DataMemoryBarrier(2,3);
        *(long *)(lVar9 + 0x18U) = lVar8;
        *(undefined1 *)((lVar9 + 0x18U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
        lStack_90 = lVar9;
        if (*(long *)(*(long *)(lVar9 + 0x18) + 0x18) == 0) {
          lStack_88 = *(long *)(lVar9 + 0x18);
          uStack_80 = uRam0000000103800d18;
          uStack_70 = *(undefined8 *)(param_4 + 0x18);
          uStack_78 = func_0x000100331870(uRam0000000103800d08);
          func_0x0001003833f0(uStack_78,uStack_70);
          lStack_90 = func_0x000100331870(uRam0000000103800d68);
          func_0x000100383454(lStack_90,uStack_80,uStack_78);
          DataMemoryBarrier(2,3);
          *(long *)(lStack_88 + 0x18U) = lStack_90;
          *(undefined1 *)((lStack_88 + 0x18U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
        }
        uStack_40 = *(undefined8 *)(*(long *)(lVar9 + 0x18) + 0x18);
        uStack_48 = uRam0000000103800d70;
        uVar11 = 0x1000a9e9c;
        if (param_4 != 0) {
          uVar11 = func_0x000100383468(*(ulong *)(param_4 + 0x38) & 0x3fffffffffffffff);
          func_0x00010038347c(uStack_40,uStack_48,uVar11);
          uStack_68 = *(undefined8 *)(*(long *)(lVar9 + 0x18) + 0x18);
          uStack_78 = uRam0000000103800d78;
          plStack_50 = (long *)func_0x0001003323d8(uRam0000000103800d80,uVar10);
          uStack_58 = func_0x000100331870(uRam0000000103800d88);
          func_0x000100378310(uStack_58,plStack_50);
          plStack_60 = (long *)func_0x000100383490(uStack_58);
          uStack_70 = func_0x000100331870(lRam0000000103800d90);
          func_0x0001003834a4(uStack_70,plStack_60);
          func_0x00010038347c(uStack_68,uStack_78,uStack_70);
          uStack_80 = func_0x000100331820(uRam0000000103800ce0,0x18);
          func_0x0001003577f0(uStack_80,0);
          DataMemoryBarrier(2,3);
          *(undefined8 *)(lVar9 + 0x10U) = uStack_80;
          *(undefined1 *)((lVar9 + 0x10U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
          lStack_88 = func_0x000100331794(uRam0000000103800d98,1);
          func_0x000100331f8c(lStack_88,0,*(undefined8 *)(*(long *)(lVar9 + 0x18) + 0x18));
          lStack_90 = func_0x000100331870(uRam0000000103800da0);
          func_0x0001003834b8(lStack_90,lStack_88,0);
          lVar12 = lStack_90;
          func_0x0001003834cc(lStack_90,2);
          func_0x000100357b24(lVar12,0x19);
          uVar11 = 0x1000aa044;
          if (lVar9 == 0) goto LAB_1000aa230;
          lVar13 = func_0x000100331820(uRam0000000103800da8,0x80);
          uVar11 = 0x1000aa068;
          if (lVar9 != 0) {
            DataMemoryBarrier(2,3);
            *(long *)(lVar13 + 0x20) = lVar9;
            *(undefined1 *)((lVar13 + 0x20U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
            lVar3 = lRam0000000103800db0;
            *(long *)(lVar13 + 0x40) = lRam0000000103800db0;
            *(undefined8 *)(lVar13 + 0x28) = uRam0000000103800db8;
            *(undefined8 *)(lVar13 + 0x18) = *(undefined8 *)(lVar3 + 0x30);
            *(undefined8 *)(lVar13 + 0x10) = *(undefined8 *)(lVar3 + 0x28);
            func_0x0001003834e0(lVar12);
            func_0x000100357b60(uStack_f0,lVar12);
            func_0x000100357818(*(undefined8 *)(lVar9 + 0x10));
            lStack_d8 = 0;
            func_0x0001000aa1b8();
            if (lStack_d8 != 0) {
              func_0x000100331ba4();
            }
            func_0x000100383328(*(undefined8 *)(param_4 + 0x18),*(undefined8 *)(lVar8 + 0x10),0);
            bVar1 = *(byte *)(lVar8 + 0x20);
            goto LAB_1000aa214;
          }
        }
      }
    }
    func_0x000100382ea0(0xee,uVar11);
    uVar11 = extraout_x17;
  }
LAB_1000aa230:
  func_0x000100382ea0(0x69,uVar11);
  uStack_2e8 = 0x1000aa23c;
  puStack_2f0 = &stack0xfffffffffffffed0;
  if (*plRam00000001037fff88 != 0) {
    puStack_2f0 = &stack0xfffffffffffffed0;
    func_0x0001003316e0();
  }
  uStack_278 = 0;
  uStack_270 = 0;
  uStack_268 = 0;
  uStack_260 = 0;
  uStack_258 = 0;
  uStack_250 = 0;
  uStack_248 = 0;
  plStack_240 = (long *)0x0;
  plStack_238 = (long *)0x0;
  lVar8 = func_0x000100331820(uRam0000000103800dd0,0x18);
  lStack_138 = lVar8;
  func_0x000100357a98(&uStack_260,&uStack_258);
  *(undefined8 *)(lStack_138 + 0x10) = 0;
  lVar9 = func_0x000100331820(uRam0000000103800dd8,0x18);
  lStack_140 = lVar9;
  uStack_148 = func_0x000100331820(uRam0000000103800ce0,0x18);
  func_0x0001003577f0(uStack_148,0);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lStack_140 + 0x10U) = uStack_148;
  *(undefined1 *)((lStack_140 + 0x10U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
  uStack_198 = uRam0000000103800ce8;
  plStack_168 = (long *)func_0x000100331794(uRam0000000103800cf0,2);
  uStack_150 = uRam0000000103800cf8;
  plStack_158 = plStack_168;
  uStack_160 = func_0x000100331870(uRam0000000103800d00);
  func_0x0001003833dc(uStack_160,uStack_150);
  (**(code **)(*plStack_158 + 0x110))(plStack_158,0,uStack_160);
  plStack_180 = plStack_168;
  plStack_190 = plStack_168;
  uStack_170 = *(undefined8 *)(extraout_x1 + 0x18);
  uStack_178 = func_0x000100331870(uRam0000000103800d08);
  func_0x0001003833f0(uStack_178,uStack_170);
  uStack_188 = func_0x000100331870(uRam0000000103800d10);
  func_0x000100383404(uStack_188,uStack_178,0);
  (**(code **)(*plStack_180 + 0x110))(plStack_180,1,uStack_188);
  uVar10 = func_0x000100383418(uStack_198,plStack_190);
  uStack_1a0 = uRam0000000103800d18;
  uStack_1a8 = func_0x000100331870(uRam0000000103800d20);
  func_0x000100357ac0(uStack_1a8,uStack_1a0,uVar10);
  uStack_1b0 = func_0x000100331870(uRam0000000103800d28);
  func_0x000100357ad4(uStack_1b0,uStack_1a8);
  uVar10 = uStack_1b0;
  func_0x000100357afc(uStack_1b0,uStack_258);
  func_0x000100357b10(uVar10,1);
  uStack_1b8 = func_0x000100331794(uRam0000000103800990,2);
  func_0x000100331f8c(uStack_1b8,0,uRam0000000103800d70);
  uStack_1c0 = uStack_1b8;
  func_0x000100331f8c(uStack_1b8,1,uRam0000000103800d78);
  func_0x000100357ae8(uVar10,uStack_1c0);
  func_0x000100357b24(uVar10,0x19);
  uVar11 = 0x1000aa534;
  if (lVar8 != 0) {
    lVar12 = func_0x000100331820(uRam0000000103800d30,0x80);
    uVar11 = 0x1000aa558;
    if (lVar8 != 0) {
      DataMemoryBarrier(2,3);
      *(long *)(lVar12 + 0x20) = lVar8;
      *(undefined1 *)((lVar12 + 0x20U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
      lVar13 = lRam0000000103800de0;
      *(long *)(lVar12 + 0x40) = lRam0000000103800de0;
      *(undefined8 *)(lVar12 + 0x28) = uRam0000000103800de8;
      *(undefined8 *)(lVar12 + 0x18) = *(undefined8 *)(lVar13 + 0x30);
      *(undefined8 *)(lVar12 + 0x10) = *(undefined8 *)(lVar13 + 0x28);
      func_0x000100357b38(uVar10);
      uVar11 = 0x1000aa5d4;
      if (lVar9 == 0) goto LAB_1000aab90;
      lVar12 = func_0x000100331820(uRam0000000103800d48,0x80);
      uVar11 = 0x1000aa5f8;
      if (lVar9 != 0) {
        DataMemoryBarrier(2,3);
        *(long *)(lVar12 + 0x20) = lVar9;
        *(undefined1 *)((lVar12 + 0x20U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
        lVar13 = lRam0000000103800df0;
        *(long *)(lVar12 + 0x40) = lRam0000000103800df0;
        *(undefined8 *)(lVar12 + 0x28) = uRam0000000103800df8;
        *(undefined8 *)(lVar12 + 0x18) = *(undefined8 *)(lVar13 + 0x30);
        *(undefined8 *)(lVar12 + 0x10) = *(undefined8 *)(lVar13 + 0x28);
        func_0x000100357b4c(uVar10);
        func_0x000100357b60(uStack_260,uVar10);
        func_0x000100357818(*(undefined8 *)(lVar9 + 0x10));
        if (*(long *)(lVar8 + 0x10) == 0) {
          uVar16 = 0;
        }
        else {
          plVar14 = (long *)func_0x00010037f14c(*(undefined8 *)(lVar8 + 0x10),uRam0000000103800d78);
          if ((plVar14 != (long *)0x0) && (*plVar14 != lRam0000000103800d90)) {
            plVar14 = (long *)0x0;
          }
          uVar10 = func_0x000100383508(plVar14);
          uVar10 = func_0x00010038351c(uVar10);
          uVar10 = func_0x000100357980(uVar10);
          uVar11 = func_0x00010037f138(*(undefined8 *)(lVar8 + 0x10));
          uStack_1a8 = uVar10;
          uStack_1b0 = func_0x000100331820(uRam0000000103800e00,0x28);
          func_0x000100332630(uStack_1b0,uStack_1a8,1);
          uStack_1b8 = uStack_1b0;
          uStack_1c0 = func_0x000100331820(uRam0000000103800420,0x40);
          func_0x00010036c858(uStack_1c0,uStack_1b8);
          uVar10 = uStack_1c0;
          lVar8 = func_0x000100331794(uRam0000000103800010,0x1000);
          func_0x000100383530(*(undefined8 *)(extraout_x1 + 0x18),&uStack_278,&uStack_270,
                              &uStack_268);
          cVar6 = func_0x000100351774(uStack_278);
          if (cVar6 == '\0') {
            func_0x000100351788(uStack_278);
          }
          plStack_240 = (long *)func_0x000100365e90(uStack_270,2);
          iVar7 = func_0x00010034fe38(uVar10);
          uVar16 = (ulong)iVar7;
          do {
            if (*plRam00000001037fff88 != 0) {
              func_0x0001003316e0();
            }
            uVar15 = (ulong)*(int *)(lVar8 + 0x18);
            if ((int)uVar16 < *(int *)(lVar8 + 0x18)) {
              uVar15 = uVar16;
            }
            iVar7 = func_0x000100383544(uVar10,lVar8,0,uVar15);
            (**(code **)(*plStack_240 + 0x90))(plStack_240,lVar8,0,(long)iVar7);
            uVar16 = (ulong)(uint)((int)uVar16 - iVar7);
          } while (*(int *)(lVar8 + 0x18) <= iVar7);
          lStack_230 = 0;
          func_0x0001000aa938();
          if (lStack_230 != 0) {
            func_0x000100331ba4();
          }
          plStack_238 = (long *)func_0x000100365e90(uStack_268,2);
          iVar7 = func_0x00010034fe38(uVar10);
          uVar16 = (ulong)iVar7;
          do {
            if (*plRam00000001037fff88 != 0) {
              func_0x0001003316e0();
            }
            uVar15 = (ulong)*(int *)(lVar8 + 0x18);
            if ((int)uVar16 < *(int *)(lVar8 + 0x18)) {
              uVar15 = uVar16;
            }
            iVar7 = func_0x000100383544(uVar10,lVar8,0,uVar15);
            (**(code **)(*plStack_238 + 0x90))(plStack_238,lVar8,0,(long)iVar7);
            uVar16 = (ulong)(uint)((int)uVar16 - iVar7);
          } while (*(int *)(lVar8 + 0x18) <= iVar7);
          lStack_228 = 0;
          func_0x0001000aaa54();
          if (lStack_228 != 0) {
            func_0x000100331ba4();
          }
          func_0x000100383558(uStack_270,*(undefined8 *)(extraout_x1 + 0x38));
          func_0x000100383558(uStack_268,*(undefined8 *)(extraout_x1 + 0x38));
          func_0x000100383328(*(undefined8 *)(extraout_x1 + 0x18),uVar11,0);
          lStack_220 = 0;
          func_0x0001000aaafc();
          if (lStack_220 != 0) {
            func_0x000100331ba4();
          }
          uVar16 = 1;
        }
        return uVar16;
      }
    }
    func_0x000100382ea0(0xee,uVar11);
    uVar11 = extraout_x17_00;
  }
LAB_1000aab90:
  lVar8 = func_0x000100382ea0(0x69,uVar11);
  uStack_3e8 = 0x1000aab9c;
  puStack_3f0 = (undefined1 *)&puStack_2f0;
  if (*plRam00000001037fff88 != 0) {
    puStack_3f0 = (undefined1 *)&puStack_2f0;
    func_0x0001003316e0();
  }
  uStack_390 = 0;
  uStack_388 = 0;
  uStack_380 = 0;
  auStack_378[0] = 0;
  uStack_3a8 = 0;
  uStack_3a0 = 0;
  uStack_398 = 0;
  uStack_370 = 0;
  lVar9 = func_0x000100331820(uRam0000000103800e08,0x18);
  func_0x000100357a98(&uStack_390,&uStack_388);
  lVar12 = func_0x000100331820(uRam0000000103800e10,0x20);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar12 + 0x10U) = *puRam0000000103800e18;
  *(undefined1 *)((lVar12 + 0x10U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
  uVar10 = *(undefined8 *)(lVar8 + 0x10);
  auStack_378[0] = 0;
  uStack_380 = uVar10;
  lStack_310 = lVar12;
  iVar7 = func_0x000103141e78(uVar10,auStack_378);
  if (iVar7 == 0) {
    func_0x000100331bb8(uVar10,auStack_378);
  }
  func_0x00010035458c(&uStack_3a8);
  while (cVar6 = func_0x0001003545a0(&uStack_3a8), cVar6 != '\0') {
    if (*plRam00000001037fff88 != 0) {
      func_0x0001003316e0();
    }
    uVar10 = uStack_398;
    lStack_310 = func_0x000100331870(uRam0000000103800d08);
    func_0x0001003833f0(lStack_310,uVar10);
    *(int *)(lVar12 + 0x1c) = *(int *)(lVar12 + 0x1c) + 1;
    plVar14 = *(long **)(lVar12 + 0x10);
    uVar2 = *(uint *)(lVar12 + 0x18);
    if (uVar2 < *(uint *)(plVar14 + 3)) {
      *(uint *)(lVar12 + 0x18) = uVar2 + 1;
      (**(code **)(*plVar14 + 0x110))(plVar14,(long)(int)uVar2,lStack_310);
    }
    else {
      func_0x000100383580(lVar12,lStack_310);
    }
  }
  lStack_368 = 0;
  func_0x0001000aadb8();
  if (lStack_368 != 0) {
    func_0x000100331ba4();
  }
  lVar8 = *(long *)(lVar8 + 0x28);
  *(int *)(lVar8 + 0x1c) = *(int *)(lVar8 + 0x1c) + 1;
  iVar7 = *(int *)(lVar8 + 0x18);
  *(undefined4 *)(lVar8 + 0x18) = 0;
  if (0 < iVar7) {
    func_0x000100331c80(*(undefined8 *)(lVar8 + 0x10),0,(long)iVar7);
  }
  lStack_358 = 0;
  func_0x0001000aae44();
  if (lStack_358 != 0) {
    func_0x000100331ba4();
  }
  uStack_300 = func_0x000100331820(uRam0000000103800ce0,0x18);
  func_0x0001003577f0(uStack_300,0);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar9 + 0x10U) = uStack_300;
  *(undefined1 *)((lVar9 + 0x10U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
  uStack_308 = func_0x000100383594(lVar12);
  lStack_310 = func_0x000100331870(uRam0000000103800da0);
  func_0x0001003834b8(lStack_310,0,uStack_308);
  lVar8 = lStack_310;
  func_0x0001003834cc(lStack_310,2);
  func_0x000100357b24(lVar8,0x19);
  uVar10 = 0x1000aaf3c;
  if (lVar9 != 0) {
    lVar12 = func_0x000100331820(uRam0000000103800da8,0x80);
    if (lVar9 != 0) {
      DataMemoryBarrier(2,3);
      *(long *)(lVar12 + 0x20) = lVar9;
      *(undefined1 *)((lVar12 + 0x20U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
      lVar13 = lRam0000000103800e30;
      *(long *)(lVar12 + 0x40) = lRam0000000103800e30;
      *(undefined8 *)(lVar12 + 0x28) = uRam0000000103800e38;
      *(undefined8 *)(lVar12 + 0x18) = *(undefined8 *)(lVar13 + 0x30);
      *(undefined8 *)(lVar12 + 0x10) = *(undefined8 *)(lVar13 + 0x28);
      func_0x0001003834e0(lVar8);
      func_0x000100357b60(uStack_390,lVar8);
      uVar16 = func_0x000100357818(*(undefined8 *)(lVar9 + 0x10));
      return uVar16;
    }
    func_0x000100382ea0(0xee,0x1000aaf60);
    uVar10 = extraout_x17_01;
  }
  lVar8 = func_0x000100382ea0(0x69,uVar10);
  if (*plRam00000001037fff88 != 0) {
    func_0x0001003316e0();
  }
  iStack_4a0 = 0;
  iStack_49c = 0;
  iStack_4a8 = 0;
  iStack_4a4 = 0;
  uStack_4c0 = 0;
  uStack_4b8 = 0;
  plStack_4b0 = (long *)0x0;
  uStack_4d8 = 0;
  uStack_4d0 = 0;
  plStack_4c8 = (long *)0x0;
  uStack_4f0 = 0;
  uStack_4e8 = 0;
  uStack_4e0 = 0;
  uStack_4f8 = 0;
  uStack_4f4 = 0;
  *(undefined1 *)(lVar8 + 0x17f) = 1;
  if (*(long *)(lVar8 + 0x18) == 0) {
    bVar5 = true;
  }
  else {
    bVar5 = *(int *)(*(long *)(lVar8 + 0x18) + 0x10) == 0;
  }
  if ((!bVar5) &&
     (cVar6 = func_0x00010035011c(*(undefined8 *)(lVar8 + 0x18),uRam0000000103800e48), cVar6 != '\0'
     )) {
    if (*(char *)(lVar8 + 0x17e) != '\0') {
      lVar9 = func_0x0001003518a0();
      func_0x000100346bf8(*(undefined8 *)(lVar9 + 0x1f8),*(undefined8 *)(lVar8 + 0x18));
    }
    if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    func_0x000100346c20(*puRam0000000103800e58,*(undefined8 *)(lVar8 + 0x18));
  }
  func_0x00010035944c(lVar8);
  func_0x000100353128(3);
  func_0x0001003835a8(lVar8);
  cVar6 = func_0x000100345aa0(*(undefined8 *)(lVar8 + 0x18),uRam0000000103800e60);
  if (cVar6 != '\0') {
    func_0x00010035f0e0(uRam0000000103800e68,1,1);
    uVar10 = func_0x0001003518a0();
    lVar9 = func_0x000100351d28(uVar10);
    func_0x00010035d010(*(undefined8 *)(lVar9 + 0x148),uRam0000000103800e70);
  }
  lVar9 = func_0x0001003518a0();
  *(undefined1 *)(lVar9 + 0x76e) = 0;
  lVar9 = func_0x0001003518a0();
  *(undefined1 *)(lVar9 + 0x773) = 0;
  func_0x0001003528a4(1);
  cVar6 = func_0x0001003524a8();
  if (cVar6 != '\0') {
    fVar18 = (float)func_0x0001003524d0();
    param_2 = 0x3f800000;
    if (fVar18 < 1.0) goto LAB_1000ab2a8;
  }
  func_0x000100354ac8();
LAB_1000ab2a8:
  if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  *puRam0000000103800e80 = 1;
  func_0x000100353100(1);
  func_0x00010037fafc(5,3,4);
  *(int *)(lVar8 + 0x124) = *(int *)(lVar8 + 0x124) + 2;
  *puRam0000000103800e88 = 0;
  if (*(char *)(lVar8 + 0x118) == '\0') {
    uVar10 = func_0x0001003518a0();
    uVar16 = func_0x000100353920(uVar10);
  }
  else {
    if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    *piRam0000000103800e90 = 0x898;
    if ((*(long *)(lVar8 + 0x60) != 0) &&
       ((cVar6 = func_0x000100359938(lVar8,uRam0000000103800e98), cVar6 != '\0' ||
        (cVar6 = func_0x000100359938(lVar8,uRam0000000103800ea0), cVar6 != '\0')))) {
      if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      *piRam0000000103800e90 = 0x960;
    }
    if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    iVar7 = ((*piRam0000000103800e90 / 100) * 0x3c + *piRam0000000103800e90 % 100) -
            ((*piRam0000000103800ea8 / 100) * 0x3c + *piRam0000000103800ea8 % 100);
    cVar6 = func_0x000100351fa8();
    if (cVar6 == '\0') {
      func_0x0001003518a0();
      plVar14 = (long *)func_0x000100351954();
      piStack_498 = &iStack_4a8;
      uVar10 = (**(code **)(*plVar14 + 0x6e8))(plVar14);
      *(undefined8 *)piStack_498 = uVar10;
      func_0x0001003594b0(lVar8,uRam0000000103800eb0,(long)iStack_4a8,(long)iStack_4a4);
    }
    else {
      plVar14 = (long *)func_0x000100354a78();
      piStack_498 = &iStack_4a0;
      uVar10 = (**(code **)(*plVar14 + 0x648))(plVar14);
      *(undefined8 *)piStack_498 = uVar10;
      func_0x0001003594b0(lVar8,uRam0000000103800eb0,(long)iStack_4a0,(long)iStack_49c);
    }
    lVar9 = func_0x0001003518a0();
    *(undefined8 *)(lVar9 + 0x430) = 0;
    *(undefined1 *)(lVar8 + 0x118) = 0;
    func_0x00010035340c(&uStack_4c0);
    while (cVar6 = func_0x000100353470(&uStack_4c0), cVar6 != '\0') {
      if (*plRam00000001037fff88 != 0) {
        func_0x0001003316e0();
      }
      if (plStack_4b0 != (long *)0x0) {
        func_0x000100359dfc(lVar8,plStack_4b0);
      }
    }
    lStack_490 = 0;
    func_0x0001000ab5e8();
    if (lStack_490 != 0) {
      func_0x000100331ba4();
    }
    cVar6 = func_0x000100351fa8();
    if (cVar6 != '\0') {
      func_0x000100371830();
      func_0x00010035340c(&uStack_4c0);
      while (cVar6 = func_0x000100353470(&uStack_4c0), cVar6 != '\0') {
        if (*plRam00000001037fff88 != 0) {
          func_0x0001003316e0();
        }
        plVar14 = plStack_4b0;
        lVar8 = func_0x000100354500(plStack_4b0);
        if (lVar8 == 0) {
LAB_1000ab830:
          lVar8 = func_0x00010035309c(plVar14);
          if ((lVar8 != 0) && (*(long *)(plVar14[0x4a] + 0x60) != 0)) {
            func_0x00010035197c(plVar14[0x5f],0);
            plVar14[0x67] = 0;
            func_0x000100354118(plVar14[0x61],0);
            plVar14[0x15] = 0;
            plVar14[0x4c] = 0;
            (**(code **)(*plVar14 + 0x188))(plVar14);
            uStack_460 = 0x42800000;
            uStack_45c = 0x3c800000;
            fStack_500 = *(float *)(plVar14[0x49] + 0x68) * 0.015625;
            fStack_4fc = *(float *)(plVar14[0x49] + 0x6c) * 0.015625;
            param_2 = (ulong)(uint)fStack_4fc;
            func_0x000100354924(fStack_500,plVar14,*(undefined8 *)(plVar14[0x4a] + 0x60));
            *(undefined1 *)((long)plVar14 + 0x3b6) = 1;
          }
        }
        else {
          uVar10 = func_0x000100354500(plVar14);
          cVar6 = func_0x00010035becc(uVar10);
          iVar20 = (int)param_2;
          if (cVar6 == '\0') goto LAB_1000ab830;
          plVar14[0x15] = 0;
          plVar14[0x4c] = 0;
          plVar17 = (long *)func_0x000100351954(uVar10);
          (**(code **)(*plVar14 + 0x188))(plVar14);
          uVar11 = func_0x000100342e04(uVar10);
          piStack_498 = (int *)&uStack_508;
          uVar11 = func_0x0001003541e0(plVar17,uVar11);
          *(undefined8 *)piStack_498 = uVar11;
          piStack_498 = &iStack_510;
          iVar19 = func_0x0001003835bc(uStack_508);
          piVar4 = piStack_498;
          *piStack_498 = iVar19;
          piVar4[1] = iVar20;
          param_2 = (ulong)uStack_50c;
          func_0x000100354938(iStack_510,plVar14,plVar17);
          lVar8 = (**(code **)(*plVar17 + 0x6e0))(plVar17);
          if (lVar8 != 0) {
            uVar11 = func_0x000100351954(uVar10);
            func_0x00010035d90c(plVar14,uVar11);
          }
          *(undefined1 *)((long)plVar14 + 0x3b6) = 1;
          if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
            func_0x0001003319b0();
          }
          if (*piRam0000000103800e90 < 0x708) {
            if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
              func_0x0001003319b0();
            }
            if (1099 < *piRam0000000103800e90) {
              (**(code **)(*(long *)plVar14[0x55] + 0x218))((long *)plVar14[0x55]);
              uVar10 = func_0x000100351954(uVar10);
              func_0x00010035efb4(plVar14,0x44c,uVar10);
            }
          }
          else {
            (**(code **)(*(long *)plVar14[0x55] + 0x218))((long *)plVar14[0x55]);
            uVar10 = func_0x000100351954(uVar10);
            func_0x00010035efb4(plVar14,0x708,uVar10);
          }
        }
      }
      lStack_458 = 0;
      func_0x0001000ab994();
      if (lStack_458 != 0) {
        func_0x000100331ba4();
      }
    }
    func_0x000100352868();
    func_0x00010035296c(&uStack_4d8);
    while (cVar6 = func_0x000100352b38(&uStack_4d8), cVar6 != '\0') {
      if (*plRam00000001037fff88 != 0) {
        func_0x0001003316e0();
      }
      plVar14 = plStack_4c8;
      uStack_3f8 = func_0x0001003831ac(plStack_4c8[0x17]);
      uStack_400 = func_0x000100331820(uRam0000000103800ec0,0x20);
      func_0x00010036e9dc(uStack_400,uStack_3f8);
      func_0x00010035c28c(&uStack_4f0);
      while (cVar6 = func_0x00010035c2a0(&uStack_4f0), cVar6 != '\0') {
        if (*plRam00000001037fff88 != 0) {
          func_0x0001003316e0();
        }
        uStack_4f8 = (undefined4)uStack_4e0;
        uStack_4f4 = uStack_4e0._4_4_;
        plVar17 = (long *)func_0x00010035ef14(uStack_4e0 & 0xffffffff,uStack_4e0._4_4_,plVar14[0x17]
                                             );
        cVar6 = (**(code **)(*plVar17 + 0x440))(plVar17,iVar7);
        if (cVar6 != '\0') {
          func_0x000100355568(uStack_4f8,uStack_4f4,plVar14[0x17]);
        }
      }
      lStack_480 = 0;
      func_0x0001000abb14();
      if (lStack_480 != 0) {
        func_0x000100331ba4();
      }
      if ((plVar14 != (long *)0x0) &&
         (*(long *)(*(long *)(*(long *)*plVar14 + 0x10) + 0x10) != lRam0000000103800ee0)) {
        plVar14 = (long *)0x0;
      }
      if (plVar14 != (long *)0x0) {
        (**(code **)(*plVar14 + 0x230))(plVar14,iVar7);
      }
    }
    lStack_470 = 0;
    func_0x0001000abbc8();
    if (lStack_470 != 0) {
      func_0x000100331ba4();
    }
    uVar16 = func_0x0001003518a0();
    *(undefined4 *)(uVar16 + 0x79c) = 0x5dc;
  }
  return uVar16;
}

