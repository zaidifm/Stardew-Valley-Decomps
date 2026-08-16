/* 0x060032ed StardewValley.CloudSync.DeleteCloudSaves @ 0x1000aaba0 */

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

void SDV_StardewValley_CloudSync_DeleteCloudSaves_060032ed
               (undefined1 param_1 [16],ulong param_2,long param_3)

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
  long *plVar10;
  undefined8 uVar11;
  long *plVar12;
  undefined8 extraout_x17;
  long lVar13;
  float fVar14;
  int iVar15;
  int iVar16;
  int iStack_220;
  uint uStack_21c;
  undefined8 uStack_218;
  float fStack_210;
  float fStack_20c;
  undefined4 uStack_208;
  undefined4 uStack_204;
  undefined8 uStack_200;
  undefined8 uStack_1f8;
  undefined8 uStack_1f0;
  undefined8 uStack_1e8;
  undefined8 uStack_1e0;
  long *plStack_1d8;
  undefined8 uStack_1d0;
  undefined8 uStack_1c8;
  long *plStack_1c0;
  int iStack_1b8;
  int iStack_1b4;
  int iStack_1b0;
  int iStack_1ac;
  int *piStack_1a8;
  long lStack_1a0;
  long lStack_190;
  long lStack_180;
  undefined4 uStack_170;
  undefined4 uStack_16c;
  long lStack_168;
  undefined8 uStack_110;
  undefined8 uStack_108;
  undefined8 uStack_b8;
  undefined8 uStack_b0;
  undefined8 uStack_a8;
  undefined8 uStack_a0;
  undefined8 uStack_98;
  undefined8 uStack_90;
  undefined1 auStack_88 [8];
  undefined8 uStack_80;
  long lStack_78;
  long lStack_68;
  long lStack_20;
  undefined8 uStack_18;
  undefined8 uStack_10;
  
  if (*plRam00000001037fff88 != 0) {
    func_0x0001003316e0();
  }
  uStack_a0 = 0;
  uStack_98 = 0;
  uStack_90 = 0;
  auStack_88[0] = 0;
  uStack_b8 = 0;
  uStack_b0 = 0;
  uStack_a8 = 0;
  uStack_80 = 0;
  lVar7 = func_0x000100331820(uRam0000000103800e08,0x18);
  func_0x000100357a98(&uStack_a0,&uStack_98);
  lVar8 = func_0x000100331820(uRam0000000103800e10,0x20);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar8 + 0x10U) = *puRam0000000103800e18;
  *(undefined1 *)((lVar8 + 0x10U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
  uVar9 = *(undefined8 *)(param_3 + 0x10);
  auStack_88[0] = 0;
  uStack_90 = uVar9;
  lStack_20 = lVar8;
  iVar6 = func_0x000103141e78(uVar9,auStack_88);
  if (iVar6 == 0) {
    func_0x000100331bb8(uVar9,auStack_88);
  }
  func_0x00010035458c(&uStack_b8);
  while (cVar5 = func_0x0001003545a0(&uStack_b8), cVar5 != '\0') {
    if (*plRam00000001037fff88 != 0) {
      func_0x0001003316e0();
    }
    uVar9 = uStack_a8;
    lStack_20 = func_0x000100331870(uRam0000000103800d08);
    func_0x0001003833f0(lStack_20,uVar9);
    *(int *)(lVar8 + 0x1c) = *(int *)(lVar8 + 0x1c) + 1;
    plVar10 = *(long **)(lVar8 + 0x10);
    uVar1 = *(uint *)(lVar8 + 0x18);
    if (uVar1 < *(uint *)(plVar10 + 3)) {
      *(uint *)(lVar8 + 0x18) = uVar1 + 1;
      (**(code **)(*plVar10 + 0x110))(plVar10,(long)(int)uVar1,lStack_20);
    }
    else {
      func_0x000100383580(lVar8,lStack_20);
    }
  }
  lStack_78 = 0;
  func_0x0001000aadb8();
  if (lStack_78 != 0) {
    func_0x000100331ba4();
  }
  lVar13 = *(long *)(param_3 + 0x28);
  *(int *)(lVar13 + 0x1c) = *(int *)(lVar13 + 0x1c) + 1;
  iVar6 = *(int *)(lVar13 + 0x18);
  *(undefined4 *)(lVar13 + 0x18) = 0;
  if (0 < iVar6) {
    func_0x000100331c80(*(undefined8 *)(lVar13 + 0x10),0,(long)iVar6);
  }
  lStack_68 = 0;
  func_0x0001000aae44();
  if (lStack_68 != 0) {
    func_0x000100331ba4();
  }
  uStack_10 = func_0x000100331820(uRam0000000103800ce0,0x18);
  func_0x0001003577f0(uStack_10,0);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar7 + 0x10U) = uStack_10;
  *(undefined1 *)((lVar7 + 0x10U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
  uStack_18 = func_0x000100383594(lVar8);
  lStack_20 = func_0x000100331870(uRam0000000103800da0);
  func_0x0001003834b8(lStack_20,0,uStack_18);
  lVar8 = lStack_20;
  func_0x0001003834cc(lStack_20,2);
  func_0x000100357b24(lVar8,0x19);
  uVar9 = 0x1000aaf3c;
  if (lVar7 != 0) {
    lVar13 = func_0x000100331820(uRam0000000103800da8,0x80);
    if (lVar7 != 0) {
      DataMemoryBarrier(2,3);
      *(long *)(lVar13 + 0x20) = lVar7;
      *(undefined1 *)((lVar13 + 0x20U >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
      lVar2 = lRam0000000103800e30;
      *(long *)(lVar13 + 0x40) = lRam0000000103800e30;
      *(undefined8 *)(lVar13 + 0x28) = uRam0000000103800e38;
      *(undefined8 *)(lVar13 + 0x18) = *(undefined8 *)(lVar2 + 0x30);
      *(undefined8 *)(lVar13 + 0x10) = *(undefined8 *)(lVar2 + 0x28);
      func_0x0001003834e0(lVar8);
      func_0x000100357b60(uStack_a0,lVar8);
      func_0x000100357818(*(undefined8 *)(lVar7 + 0x10));
      return;
    }
    func_0x000100382ea0(0xee,0x1000aaf60);
    uVar9 = extraout_x17;
  }
  lVar7 = func_0x000100382ea0(0x69,uVar9);
  if (*plRam00000001037fff88 != 0) {
    func_0x0001003316e0();
  }
  iStack_1b0 = 0;
  iStack_1ac = 0;
  iStack_1b8 = 0;
  iStack_1b4 = 0;
  uStack_1d0 = 0;
  uStack_1c8 = 0;
  plStack_1c0 = (long *)0x0;
  uStack_1e8 = 0;
  uStack_1e0 = 0;
  plStack_1d8 = (long *)0x0;
  uStack_200 = 0;
  uStack_1f8 = 0;
  uStack_1f0 = 0;
  uStack_208 = 0;
  uStack_204 = 0;
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
    fVar14 = (float)func_0x0001003524d0();
    param_2 = 0x3f800000;
    if (fVar14 < 1.0) goto LAB_1000ab2a8;
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
    func_0x000100353920(uVar9);
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
      plVar10 = (long *)func_0x000100351954();
      piStack_1a8 = &iStack_1b8;
      uVar9 = (**(code **)(*plVar10 + 0x6e8))(plVar10);
      *(undefined8 *)piStack_1a8 = uVar9;
      func_0x0001003594b0(lVar7,uRam0000000103800eb0,(long)iStack_1b8,(long)iStack_1b4);
    }
    else {
      plVar10 = (long *)func_0x000100354a78();
      piStack_1a8 = &iStack_1b0;
      uVar9 = (**(code **)(*plVar10 + 0x648))(plVar10);
      *(undefined8 *)piStack_1a8 = uVar9;
      func_0x0001003594b0(lVar7,uRam0000000103800eb0,(long)iStack_1b0,(long)iStack_1ac);
    }
    lVar8 = func_0x0001003518a0();
    *(undefined8 *)(lVar8 + 0x430) = 0;
    *(undefined1 *)(lVar7 + 0x118) = 0;
    func_0x00010035340c(&uStack_1d0);
    while (cVar5 = func_0x000100353470(&uStack_1d0), cVar5 != '\0') {
      if (*plRam00000001037fff88 != 0) {
        func_0x0001003316e0();
      }
      if (plStack_1c0 != (long *)0x0) {
        func_0x000100359dfc(lVar7,plStack_1c0);
      }
    }
    lStack_1a0 = 0;
    func_0x0001000ab5e8();
    if (lStack_1a0 != 0) {
      func_0x000100331ba4();
    }
    cVar5 = func_0x000100351fa8();
    if (cVar5 != '\0') {
      func_0x000100371830();
      func_0x00010035340c(&uStack_1d0);
      while (cVar5 = func_0x000100353470(&uStack_1d0), cVar5 != '\0') {
        if (*plRam00000001037fff88 != 0) {
          func_0x0001003316e0();
        }
        plVar10 = plStack_1c0;
        lVar7 = func_0x000100354500(plStack_1c0);
        if (lVar7 == 0) {
LAB_1000ab830:
          lVar7 = func_0x00010035309c(plVar10);
          if ((lVar7 != 0) && (*(long *)(plVar10[0x4a] + 0x60) != 0)) {
            func_0x00010035197c(plVar10[0x5f],0);
            plVar10[0x67] = 0;
            func_0x000100354118(plVar10[0x61],0);
            plVar10[0x15] = 0;
            plVar10[0x4c] = 0;
            (**(code **)(*plVar10 + 0x188))(plVar10);
            uStack_170 = 0x42800000;
            uStack_16c = 0x3c800000;
            fStack_210 = *(float *)(plVar10[0x49] + 0x68) * 0.015625;
            fStack_20c = *(float *)(plVar10[0x49] + 0x6c) * 0.015625;
            param_2 = (ulong)(uint)fStack_20c;
            func_0x000100354924(fStack_210,plVar10,*(undefined8 *)(plVar10[0x4a] + 0x60));
            *(undefined1 *)((long)plVar10 + 0x3b6) = 1;
          }
        }
        else {
          uVar9 = func_0x000100354500(plVar10);
          cVar5 = func_0x00010035becc(uVar9);
          iVar16 = (int)param_2;
          if (cVar5 == '\0') goto LAB_1000ab830;
          plVar10[0x15] = 0;
          plVar10[0x4c] = 0;
          plVar12 = (long *)func_0x000100351954(uVar9);
          (**(code **)(*plVar10 + 0x188))(plVar10);
          uVar11 = func_0x000100342e04(uVar9);
          piStack_1a8 = (int *)&uStack_218;
          uVar11 = func_0x0001003541e0(plVar12,uVar11);
          *(undefined8 *)piStack_1a8 = uVar11;
          piStack_1a8 = &iStack_220;
          iVar15 = func_0x0001003835bc(uStack_218);
          piVar3 = piStack_1a8;
          *piStack_1a8 = iVar15;
          piVar3[1] = iVar16;
          param_2 = (ulong)uStack_21c;
          func_0x000100354938(iStack_220,plVar10,plVar12);
          lVar7 = (**(code **)(*plVar12 + 0x6e0))(plVar12);
          if (lVar7 != 0) {
            uVar11 = func_0x000100351954(uVar9);
            func_0x00010035d90c(plVar10,uVar11);
          }
          *(undefined1 *)((long)plVar10 + 0x3b6) = 1;
          if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
            func_0x0001003319b0();
          }
          if (*piRam0000000103800e90 < 0x708) {
            if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
              func_0x0001003319b0();
            }
            if (1099 < *piRam0000000103800e90) {
              (**(code **)(*(long *)plVar10[0x55] + 0x218))((long *)plVar10[0x55]);
              uVar9 = func_0x000100351954(uVar9);
              func_0x00010035efb4(plVar10,0x44c,uVar9);
            }
          }
          else {
            (**(code **)(*(long *)plVar10[0x55] + 0x218))((long *)plVar10[0x55]);
            uVar9 = func_0x000100351954(uVar9);
            func_0x00010035efb4(plVar10,0x708,uVar9);
          }
        }
      }
      lStack_168 = 0;
      func_0x0001000ab994();
      if (lStack_168 != 0) {
        func_0x000100331ba4();
      }
    }
    func_0x000100352868();
    func_0x00010035296c(&uStack_1e8);
    while (cVar5 = func_0x000100352b38(&uStack_1e8), cVar5 != '\0') {
      if (*plRam00000001037fff88 != 0) {
        func_0x0001003316e0();
      }
      plVar10 = plStack_1d8;
      uStack_108 = func_0x0001003831ac(plStack_1d8[0x17]);
      uStack_110 = func_0x000100331820(uRam0000000103800ec0,0x20);
      func_0x00010036e9dc(uStack_110,uStack_108);
      func_0x00010035c28c(&uStack_200);
      while (cVar5 = func_0x00010035c2a0(&uStack_200), cVar5 != '\0') {
        if (*plRam00000001037fff88 != 0) {
          func_0x0001003316e0();
        }
        uStack_208 = (undefined4)uStack_1f0;
        uStack_204 = uStack_1f0._4_4_;
        plVar12 = (long *)func_0x00010035ef14(uStack_1f0 & 0xffffffff,uStack_1f0._4_4_,plVar10[0x17]
                                             );
        cVar5 = (**(code **)(*plVar12 + 0x440))(plVar12,iVar6);
        if (cVar5 != '\0') {
          func_0x000100355568(uStack_208,uStack_204,plVar10[0x17]);
        }
      }
      lStack_190 = 0;
      func_0x0001000abb14();
      if (lStack_190 != 0) {
        func_0x000100331ba4();
      }
      if ((plVar10 != (long *)0x0) &&
         (*(long *)(*(long *)(*(long *)*plVar10 + 0x10) + 0x10) != lRam0000000103800ee0)) {
        plVar10 = (long *)0x0;
      }
      if (plVar10 != (long *)0x0) {
        (**(code **)(*plVar10 + 0x230))(plVar10,iVar6);
      }
    }
    lStack_180 = 0;
    func_0x0001000abbc8();
    if (lStack_180 != 0) {
      func_0x000100331ba4();
    }
    lVar7 = func_0x0001003518a0();
    *(undefined4 *)(lVar7 + 0x79c) = 0x5dc;
  }
  return;
}

