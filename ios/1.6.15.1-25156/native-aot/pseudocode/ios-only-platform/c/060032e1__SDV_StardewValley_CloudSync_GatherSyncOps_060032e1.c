/* 0x060032e1 StardewValley.CloudSync.GatherSyncOps @ 0x10179e528 */

/* WARNING: Removing unreachable block (ram,0x00010179edb8) */
/* WARNING: Removing unreachable block (ram,0x00010179eda0) */
/* WARNING: Removing unreachable block (ram,0x00010179ed64) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* WARNING: Restarted to delay deadcode elimination for space: stack */

undefined1
SDV_StardewValley_CloudSync_GatherSyncOps_060032e1
          (undefined8 param_1,long *param_2,long *param_3,long *param_4,long *param_5)

{
  code *pcVar1;
  char cVar2;
  uint uVar3;
  long lVar4;
  long lVar5;
  long lVar6;
  undefined8 uVar7;
  long *plVar8;
  long lVar9;
  long lVar10;
  uint *puVar11;
  long lStack_150;
  long lStack_148;
  undefined8 uStack_140;
  undefined8 uStack_138;
  long lStack_130;
  long lStack_120;
  undefined8 uStack_118;
  undefined8 uStack_110;
  undefined8 *puStack_108;
  undefined8 uStack_100;
  undefined8 uStack_f8;
  long lStack_f0;
  long lStack_e8;
  undefined8 *puStack_e0;
  undefined1 uStack_d1;
  long lStack_d0;
  long *plStack_c8;
  uint uStack_bc;
  long lStack_b8;
  long lStack_b0;
  long *plStack_a8;
  uint uStack_9c;
  long lStack_98;
  long lStack_90;
  long *plStack_88;
  uint uStack_7c;
  long lStack_78;
  long lStack_70;
  undefined8 uStack_68;
  
  cVar2 = cRam000000010390e0f0;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1032d3b10);
    cRam000000010390e0f0 = '\x01';
  }
  lStack_150 = 0;
  lStack_148 = 0;
  uStack_138 = 0;
  lStack_130 = 0;
  uStack_140 = 0;
  lStack_120 = 0;
  lVar4 = func_0x000100331820(uRam00000001038df7f0,0x20);
  lVar10 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar4 + 0x10) = *puRam00000001038df7f8;
  *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar10) = 1;
  DataMemoryBarrier(2,3);
  uVar7 = _UNK_1035f5540;
  if (param_2 != (long *)0x0) {
    *param_2 = lVar4;
    *(undefined1 *)(((ulong)param_2 >> 9 & 0x7fffff) + lVar10) = 1;
    lVar4 = func_0x000100331820(uRam00000001038df7f0,0x20);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar4 + 0x10) = *puRam00000001038df7f8;
    *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar10) = 1;
    DataMemoryBarrier(2,3);
    uVar7 = _UNK_1035f5548;
    if (param_3 != (long *)0x0) {
      *param_3 = lVar4;
      *(undefined1 *)(((ulong)param_3 >> 9 & 0x7fffff) + lVar10) = 1;
      lVar4 = func_0x000100331820(uRam00000001038df7f0,0x20);
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lVar4 + 0x10) = *puRam00000001038df7f8;
      *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar10) = 1;
      DataMemoryBarrier(2,3);
      uVar7 = _UNK_1035f5550;
      if (param_4 != (long *)0x0) {
        *param_4 = lVar4;
        *(undefined1 *)(((ulong)param_4 >> 9 & 0x7fffff) + lVar10) = 1;
        lVar4 = func_0x000100331820(uRam00000001038df800,0x20);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(lVar4 + 0x10) = *puRam00000001038df808;
        *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar10) = 1;
        DataMemoryBarrier(2,3);
        uVar7 = _UNK_1035f5558;
        if (param_5 != (long *)0x0) {
          *param_5 = lVar4;
          *(undefined1 *)(((ulong)param_5 >> 9 & 0x7fffff) + lVar10) = 1;
          cVar2 = SDV_StardewValley_CloudSync_QureryCloudSaves_060032ec(lVar4,&lStack_150);
          if (cVar2 == '\0') {
            return 0;
          }
          lStack_148 = SDV_StardewValley_CloudSync_GetLocalSaves_060032ea();
          uVar7 = _UNK_1035f5560;
          if (lStack_150 != 0) {
            func_0x000100357854(&uStack_140);
            while (cVar2 = func_0x000100357868(&uStack_140), cVar2 != '\0') {
              lVar5 = func_0x000100331820(uRam00000001038df828,0x18);
              lVar9 = lStack_148;
              DataMemoryBarrier(2,3);
              *(long *)(lVar5 + 0x10U) = lStack_130;
              *(undefined1 *)((lVar5 + 0x10U >> 9 & 0x7fffff) + lVar10) = 1;
              lVar6 = func_0x000100331820(uRam00000001038df830,0x80);
              DataMemoryBarrier(2,3);
              *(long *)(lVar6 + 0x20) = lVar5;
              *(undefined1 *)(((ulong)(lVar6 + 0x20) >> 9 & 0x7fffff) + lVar10) = 1;
              uVar7 = uRam00000001038df840;
              lVar4 = lRam00000001038df838;
              *(long *)(lVar6 + 0x40) = lRam00000001038df838;
              *(undefined8 *)(lVar6 + 0x28) = uVar7;
              *(undefined8 *)(lVar6 + 0x18) = *(undefined8 *)(lVar4 + 0x30);
              *(undefined8 *)(lVar6 + 0x10) = *(undefined8 *)(lVar4 + 0x28);
              if (lVar9 == 0) {
LAB_10179e984:
                uVar7 = 0xee;
LAB_10179e988:
                func_0x0001003316f4(uVar7,_UNK_1035f5580);
                goto LAB_10179ed34;
              }
              uVar3 = func_0x000100357890(lVar9);
              if (uVar3 == 0xffffffff) {
LAB_10179e8f8:
                lVar4 = *param_3;
                if (lVar4 != 0) {
                  uVar7 = *(undefined8 *)(lVar5 + 0x10);
                  plVar8 = *(long **)(lVar4 + 0x10);
                  *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
                  if (plVar8 != (long *)0x0) {
                    uVar3 = *(uint *)(lVar4 + 0x18);
                    if (uVar3 < *(uint *)(plVar8 + 3)) {
                      *(uint *)(lVar4 + 0x18) = uVar3 + 1;
                      (**(code **)(*plVar8 + 0x110))(plVar8,(long)(int)uVar3);
                    }
                    else {
                      func_0x00010035787c(lVar4,uVar7);
                    }
                    goto LAB_10179e6f0;
                  }
                }
                goto LAB_10179e984;
              }
              if (lStack_148 == 0) goto LAB_10179e984;
              if (*(uint *)(lStack_148 + 0x18) <= uVar3) {
                func_0x000100331b90();
                goto LAB_10179ed34;
              }
              lVar4 = *(long *)(lStack_148 + 0x10);
              if (lVar4 == 0) goto LAB_10179e984;
              if (*(uint *)(lVar4 + 0x18) <= uVar3) {
                uVar7 = 0xcc;
                goto LAB_10179e988;
              }
              lVar4 = *(long *)(lVar4 + (long)(int)uVar3 * 8 + 0x20);
              if (lStack_148 == 0) goto LAB_10179e984;
              func_0x0001003578a4();
              uVar7 = 0xee;
              if ((*(long *)(lVar5 + 0x10) == 0) || (lVar4 == 0)) goto LAB_10179e988;
              cVar2 = func_0x000100345aa0(*(undefined8 *)(*(long *)(lVar5 + 0x10) + 0x20),
                                          *(undefined8 *)(lVar4 + 0x20));
              if (cVar2 == '\0') {
                if (*(int *)(lVar4 + 0x40) < 1) goto LAB_10179e8f8;
                lVar6 = *param_5;
                lVar9 = func_0x000100331820(uRam00000001038df858,0x20);
                DataMemoryBarrier(2,3);
                *(undefined8 *)(lVar9 + 0x10) = *(undefined8 *)(lVar5 + 0x10);
                *(undefined1 *)(((ulong)(lVar9 + 0x10) >> 9 & 0x7fffff) + lVar10) = 1;
                DataMemoryBarrier(2,3);
                *(long *)(lVar9 + 0x18U) = lVar4;
                *(undefined1 *)((lVar9 + 0x18U >> 9 & 0x7fffff) + lVar10) = 1;
                if (lVar6 != 0) {
                  plVar8 = *(long **)(lVar6 + 0x10);
                  *(int *)(lVar6 + 0x1c) = *(int *)(lVar6 + 0x1c) + 1;
                  if (plVar8 != (long *)0x0) {
                    puVar11 = (uint *)(lVar6 + 0x18);
                    uVar3 = *puVar11;
                    lVar4 = lVar9;
                    if (uVar3 < *(uint *)(plVar8 + 3)) goto LAB_10179e8dc;
                    func_0x0001003578b8(lVar6,lVar9);
                    goto LAB_10179e6f0;
                  }
                }
                goto LAB_10179e984;
              }
              if (0 < *(int *)(lVar4 + 0x40)) {
                if ((param_2 != (long *)0x0) && (lVar9 = *param_2, lVar9 != 0)) {
                  plVar8 = *(long **)(lVar9 + 0x10);
                  *(int *)(lVar9 + 0x1c) = *(int *)(lVar9 + 0x1c) + 1;
                  if (plVar8 != (long *)0x0) {
                    puVar11 = (uint *)(lVar9 + 0x18);
                    uVar3 = *puVar11;
                    if (uVar3 < *(uint *)(plVar8 + 3)) {
LAB_10179e8dc:
                      *puVar11 = uVar3 + 1;
                      (**(code **)(*plVar8 + 0x110))(plVar8,(long)(int)uVar3,lVar4);
                    }
                    else {
                      func_0x00010035787c(lVar9,lVar4);
                    }
                    goto LAB_10179e6f0;
                  }
                }
                goto LAB_10179e984;
              }
LAB_10179e6f0:
              if (lRam0000000103976fb8 != 0) {
                func_0x00010119b8f8();
              }
            }
            uStack_118 = 0;
            puStack_108 = &uStack_140;
            uVar7 = _UNK_1035f5578;
            if ((puStack_108 != (undefined8 *)0x0) && (uVar7 = _UNK_1035f5588, lStack_148 != 0)) {
              func_0x000100357854(&uStack_100);
              uStack_138 = uStack_f8;
              uStack_140 = uStack_100;
              lStack_130 = lStack_f0;
              while (cVar2 = func_0x000100357868(&uStack_140), cVar2 != '\0') {
                puStack_e0 = &uStack_140;
                if ((&uStack_140 == (undefined8 *)0x0) ||
                   (lStack_120 = lStack_130, lStack_e8 = lStack_120, lStack_130 == 0))
                goto LAB_10179ed24;
                lStack_d0 = *(long *)(lStack_130 + 0x20);
                if (lStack_d0 == 0) {
                  uStack_d1 = true;
                }
                else {
                  if (lStack_d0 == 0) goto LAB_10179ed24;
                  uStack_d1 = *(int *)(lStack_d0 + 0x10) == 0;
                }
                if ((bool)uStack_d1 == false) {
                  if (lStack_130 == 0) goto LAB_10179ed24;
                  if (*(int *)(lStack_130 + 0x40) == 0) {
                    if (param_4 == (long *)0x0) goto LAB_10179ed24;
                    lVar10 = *param_4;
                    plStack_88 = (long *)0x0;
                    uStack_7c = 0;
                    lStack_78 = lVar10;
                    lStack_70 = lStack_120;
                    if (((((lVar10 == 0) || (lVar10 == 0)) || (lVar10 == 0)) ||
                        ((*(int *)(lVar10 + 0x1c) = *(int *)(lVar10 + 0x1c) + 1, lVar10 == 0 ||
                         (plStack_88 = *(long **)(lVar10 + 0x10), lVar10 == 0)))) ||
                       (uStack_7c = *(uint *)(lVar10 + 0x18), plStack_88 == (long *)0x0))
                    goto LAB_10179ed24;
                    if (*(uint *)(plStack_88 + 3) <= uStack_7c) goto LAB_10179ea7c;
                    if (lVar10 == 0) goto LAB_10179ed24;
                    *(uint *)(lVar10 + 0x18) = uStack_7c + 1;
                    plVar8 = plStack_88;
                    uVar3 = uStack_7c;
                    lStack_70 = lStack_130;
                    goto joined_r0x00010179ec54;
                  }
                  if (param_2 == (long *)0x0) goto LAB_10179ed24;
                  lVar10 = *param_2;
                  plStack_a8 = (long *)0x0;
                  uStack_9c = 0;
                  lStack_98 = lVar10;
                  lStack_90 = lStack_120;
                  if (((lVar10 == 0) || (lVar10 == 0)) ||
                     ((lVar10 == 0 ||
                      (((*(int *)(lVar10 + 0x1c) = *(int *)(lVar10 + 0x1c) + 1, lVar10 == 0 ||
                        (plStack_a8 = *(long **)(lVar10 + 0x10), lVar10 == 0)) ||
                       (uStack_9c = *(uint *)(lVar10 + 0x18), plStack_a8 == (long *)0x0))))))
                  goto LAB_10179ed24;
                  if (uStack_9c < *(uint *)(plStack_a8 + 3)) {
                    if (lVar10 == 0) goto LAB_10179ed24;
                    *(uint *)(lVar10 + 0x18) = uStack_9c + 1;
                    lStack_90 = lStack_130;
                    plVar8 = plStack_a8;
                    uVar3 = uStack_9c;
                    goto joined_r0x00010179ec54;
                  }
LAB_10179ea7c:
                  func_0x00010035787c(lVar10,lStack_130);
                }
                else {
                  if (param_2 == (long *)0x0) goto LAB_10179ed24;
                  lVar10 = *param_2;
                  plStack_c8 = (long *)0x0;
                  uStack_bc = 0;
                  lStack_b8 = lVar10;
                  lStack_b0 = lStack_120;
                  if ((((lVar10 == 0) || (lVar10 == 0)) ||
                      ((lVar10 == 0 ||
                       ((*(int *)(lVar10 + 0x1c) = *(int *)(lVar10 + 0x1c) + 1, lVar10 == 0 ||
                        (plStack_c8 = *(long **)(lVar10 + 0x10), lVar10 == 0)))))) ||
                     (uStack_bc = *(uint *)(lVar10 + 0x18), plStack_c8 == (long *)0x0))
                  goto LAB_10179ed24;
                  if (*(uint *)(plStack_c8 + 3) <= uStack_bc) goto LAB_10179ea7c;
                  if (lVar10 == 0) goto LAB_10179ed24;
                  *(uint *)(lVar10 + 0x18) = uStack_bc + 1;
                  plVar8 = plStack_c8;
                  uVar3 = uStack_bc;
                  lStack_b0 = lStack_130;
joined_r0x00010179ec54:
                  if (plVar8 == (long *)0x0) {
LAB_10179ed24:
                    func_0x0001003316f4(0xee,_UNK_1035f5570);
LAB_10179ed34:
                    /* WARNING: Does not return */
                    pcVar1 = (code *)SoftwareBreakpoint(1,0x10179ed38);
                    (*pcVar1)();
                  }
                  (**(code **)(*plVar8 + 0x110))(plVar8,(long)(int)uVar3,lStack_130);
                }
                if (lRam0000000103976fb8 != 0) {
                  func_0x00010119b8f8();
                }
              }
              uStack_110 = 0;
              if (&stack0x00000000 != (undefined1 *)0x140) {
                return 1;
              }
              uStack_68 = 0;
              uVar7 = _UNK_1035f5568;
            }
          }
        }
      }
    }
  }
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x10179ea28);
  (*pcVar1)();
}

