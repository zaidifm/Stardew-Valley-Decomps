/* 0x060032ea StardewValley.CloudSync.GetLocalSaves @ 0x10179f65c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_CloudSync_GetLocalSaves_060032ea(void)

{
  int iVar1;
  undefined1 auVar2 [16];
  undefined1 auVar3 [16];
  long lVar4;
  undefined8 uVar5;
  code *pcVar6;
  char cVar7;
  long lVar8;
  long lVar9;
  ulong uVar10;
  ulong uVar11;
  ulong uVar12;
  ulong uVar13;
  undefined8 uVar14;
  long lVar15;
  long *plVar16;
  ulong *puVar17;
  ulong uVar18;
  long *plVar19;
  undefined1 auVar20 [16];
  undefined8 uStack_a8;
  undefined8 uStack_a0;
  undefined8 uStack_98;
  undefined8 uStack_90;
  undefined4 uStack_84;
  undefined8 uStack_80;
  undefined4 uStack_74;
  ulong uStack_70;
  ulong uStack_68;
  
  cVar7 = cRam000000010390e0f9;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar7 == '\0') {
    func_0x00010119b908(&UNK_1032d3b90);
    cRam000000010390e0f9 = '\x01';
  }
  uStack_a8 = 0;
  uStack_a0 = 0;
  uStack_98 = 0;
  uStack_90 = 0;
  uStack_84 = 0;
  uStack_80 = 0;
  uStack_74 = 0;
  lVar8 = func_0x000100331820(uRam00000001038df7f0,0x20);
  lVar4 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar8 + 0x10) = *puRam00000001038df7f8;
  *(undefined1 *)(((ulong)(lVar8 + 0x10) >> 9 & 0x7fffff) + lVar4) = 1;
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  lVar9 = func_0x0001003579bc(*puRam00000001038d5308);
  uVar18 = (ulong)*(uint *)(lVar9 + 0x18);
  if (0 < (int)*(uint *)(lVar9 + 0x18)) {
    plVar19 = (long *)(lVar9 + 0x20);
    do {
      lVar9 = *plVar19;
      uVar14 = _UNK_1035f5648;
      if (lVar9 == 0) {
LAB_10179f99c:
        func_0x0001003316f4(0xee,uVar14);
                    /* WARNING: Does not return */
        pcVar6 = (code *)SoftwareBreakpoint(1,0x10179f9a8);
        (*pcVar6)();
      }
      cVar7 = func_0x0001003579d0(lVar9,uRam00000001038d5310,5);
      if (cVar7 == '\0') {
        SDV_StardewValley_CloudSync_GetSaveInfoAndFarmer_060032ef
                  (lVar9,&uStack_a8,&uStack_a0,&uStack_98);
        cVar7 = SDV_StardewValley_CloudSync_GetNameAndSeedFromTitle_060032f1
                          (uStack_a8,&uStack_90,&uStack_84);
        if (cVar7 != '\0') {
          cVar7 = func_0x0001003579f8(uStack_a0);
          uVar14 = uRam00000001038df8a8;
          if ((cVar7 == '\0') ||
             (cVar7 = func_0x0001003579f8(uStack_98), uVar5 = uStack_98,
             uVar14 = uRam00000001038df8a0, cVar7 == '\0')) {
            func_0x000100357a34(uVar14,lVar9);
          }
          else {
            uVar10 = func_0x000100357994(uStack_98);
            uVar11 = func_0x0001003579a8(uVar5);
            uVar14 = uStack_a0;
            uVar12 = func_0x000100357994(uStack_a0);
            uVar13 = func_0x0001003579a8(uVar14);
            auVar20._8_8_ = uVar12;
            auVar20._0_8_ = uVar10;
            lVar15 = -(ulong)((uVar13 & 0x3fffffffffffffff) < (uVar12 & 0x3fffffffffffffff));
            auVar2[8] = (char)uVar13;
            auVar2._0_8_ = uVar11;
            auVar2[9] = (char)(uVar13 >> 8);
            auVar2[10] = (char)(uVar13 >> 0x10);
            auVar2[0xb] = (char)(uVar13 >> 0x18);
            auVar2[0xc] = (char)(uVar13 >> 0x20);
            auVar2[0xd] = (char)(uVar13 >> 0x28);
            auVar2[0xe] = (char)(uVar13 >> 0x30);
            auVar2[0xf] = (char)(uVar13 >> 0x38);
            auVar3[8] = (char)lVar15;
            auVar3._0_8_ = -(ulong)((uVar11 & 0x3fffffffffffffff) < (uVar10 & 0x3fffffffffffffff));
            auVar3[9] = (char)((ulong)lVar15 >> 8);
            auVar3[10] = (char)((ulong)lVar15 >> 0x10);
            auVar3[0xb] = (char)((ulong)lVar15 >> 0x18);
            auVar3[0xc] = (char)((ulong)lVar15 >> 0x20);
            auVar3[0xd] = (char)((ulong)lVar15 >> 0x28);
            auVar3[0xe] = (char)((ulong)lVar15 >> 0x30);
            auVar3[0xf] = (char)((ulong)lVar15 >> 0x38);
            auVar20 = auVar20 ^ (auVar20 ^ auVar2) & ~auVar3;
            uVar10 = auVar20._0_8_;
            uVar11 = auVar20._8_8_;
            if ((uVar11 & 0x3fffffffffffffff) < (uVar10 & 0x3fffffffffffffff)) {
              puVar17 = &uStack_68;
              uStack_68 = uVar10;
            }
            else {
              puVar17 = &uStack_70;
              uStack_70 = uVar11;
            }
            SDV_StardewValley_CloudSync_ReadSyncronizedState_060032e2
                      (uStack_a8,&uStack_80,&uStack_74);
            lVar15 = func_0x000100331820(uRam00000001038df890,0x48);
            DataMemoryBarrier(2,3);
            *(undefined8 *)(lVar15 + 0x10U) = uStack_90;
            *(undefined1 *)((lVar15 + 0x10U >> 9 & 0x7fffff) + lVar4) = 1;
            DataMemoryBarrier(2,3);
            *(undefined8 *)(lVar15 + 0x18U) = uStack_a8;
            *(undefined1 *)((lVar15 + 0x18U >> 9 & 0x7fffff) + lVar4) = 1;
            DataMemoryBarrier(2,3);
            *(long *)(lVar15 + 0x28U) = lVar9;
            uVar10 = *puVar17;
            *(undefined1 *)((lVar15 + 0x28U >> 9 & 0x7fffff) + lVar4) = 1;
            *(ulong *)(lVar15 + 0x38) = uVar10;
            DataMemoryBarrier(2,3);
            *(undefined8 *)(lVar15 + 0x20U) = uStack_80;
            *(undefined1 *)((lVar15 + 0x20U >> 9 & 0x7fffff) + lVar4) = 1;
            iVar1 = *(int *)(lVar8 + 0x1c);
            plVar16 = *(long **)(lVar8 + 0x10);
            *(undefined4 *)(lVar15 + 0x40) = uStack_74;
            *(int *)(lVar8 + 0x1c) = iVar1 + 1;
            uVar14 = _UNK_1035f5650;
            if (plVar16 == (long *)0x0) goto LAB_10179f99c;
            if (*(uint *)(lVar8 + 0x18) < *(uint *)(plVar16 + 3)) {
              *(uint *)(lVar8 + 0x18) = *(uint *)(lVar8 + 0x18) + 1;
              (**(code **)(*plVar16 + 0x110))();
            }
            else {
              func_0x00010035787c(lVar8,lVar15);
            }
          }
        }
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      plVar19 = plVar19 + 1;
      uVar18 = uVar18 - 1;
    } while (uVar18 != 0);
  }
  return lVar8;
}

