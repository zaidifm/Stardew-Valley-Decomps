/* 0x06006739 StardewValley.Mobile.VirtualJoypad.CreateAdjusterControls @ 0x101fd2244 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_CreateAdjusterControls_06006739(long param_1)

{
  undefined4 *puVar1;
  int *piVar2;
  int iVar3;
  int iVar4;
  int iVar5;
  char cVar6;
  undefined8 uVar7;
  undefined8 uVar8;
  code *pcVar9;
  undefined4 uVar10;
  long lVar11;
  undefined8 uVar12;
  undefined8 uVar13;
  undefined8 in_x7;
  long *plVar14;
  long lVar15;
  long lVar16;
  undefined8 uVar17;
  undefined8 uVar18;
  undefined8 uVar19;
  undefined8 uStack_100;
  undefined8 uStack_f8;
  undefined8 uStack_f0;
  undefined8 uStack_e8;
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
  undefined8 uStack_90;
  undefined8 uStack_88;
  undefined8 uStack_80;
  undefined8 uStack_78;
  undefined8 uStack_70;
  undefined8 uStack_68;
  
  cVar6 = cRam0000000103911548;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar6 == '\0') {
    func_0x00010119b908(&UNK_103325c70);
    cRam0000000103911548 = '\x01';
  }
  uVar13 = uRam00000001038f6ee0;
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar12 = _UNK_1036d8468;
  if ((lRam00000001038d6bc0 != -8) && (uVar12 = _UNK_1036d8460, lRam00000001038d6bc0 != 0)) {
    iVar3 = *(int *)(lRam00000001038d6bc0 + 8);
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uStack_100 = 0;
    uStack_f8 = 0;
    func_0x00010034ede4(&uStack_100,(iVar3 - *piRam00000001038d57b0) + -100,0x14,0x50,0x50);
    uVar7 = uStack_f8;
    uVar12 = uStack_100;
    uVar19 = *puRam00000001038d5350;
    uStack_f0 = 0;
    uStack_e8 = 0;
    func_0x00010034ede4(&uStack_f0,0x14,0,0x14,0x14);
    uVar17 = uStack_e8;
    uVar8 = uStack_f0;
    lVar11 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
    func_0x000101e5f834(0x40800000,lVar11,uVar13,uVar12,uVar7,0,0,uVar19,in_x7,uVar8,uVar17,0);
    lVar16 = lRam00000001038c4be0;
    uVar12 = _UNK_1036d8470;
    if (param_1 != 0) {
      DataMemoryBarrier(2,3);
      plVar14 = (long *)(param_1 + 0x98);
      *plVar14 = lVar11;
      *(undefined1 *)(((ulong)plVar14 >> 9 & 0x7fffff) + lVar16) = 1;
      uVar13 = uRam00000001039004f0;
      uVar12 = _UNK_1036d8478;
      if ((*plVar14 != 0) &&
         (puVar1 = (undefined4 *)(*plVar14 + 0x38), uVar12 = _UNK_1036d8480,
         puVar1 != (undefined4 *)0x0)) {
        uStack_e0 = 0;
        uStack_d8 = 0;
        func_0x00010034ede4(&uStack_e0,*puVar1,0x90,0x50,0x50);
        uVar7 = uStack_d8;
        uVar12 = uStack_e0;
        uVar18 = *puRam00000001038d5350;
        uStack_d0 = 0;
        uStack_c8 = 0;
        func_0x00010034ede4(&uStack_d0,0,0,0x14,0x14);
        uVar17 = uStack_c8;
        uVar8 = uStack_d0;
        uVar19 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
        func_0x000101e5f834(0x40800000,uVar19,uVar13,uVar12,uVar7,0,0,uVar18,in_x7,uVar8,uVar17,0);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 0x90) = uVar19;
        *(undefined1 *)(((ulong)(param_1 + 0x90) >> 9 & 0x7fffff) + lVar16) = 1;
        uStack_c0 = 0;
        uStack_b8 = 0;
        func_0x00010034ede4(&uStack_c0,*piRam00000001038d57b0 + 0x14,0x14,0x4a,0x46);
        uVar12 = uStack_b8;
        uVar13 = uStack_c0;
        uVar17 = *puRam00000001038d5fa8;
        uStack_b0 = 0;
        uStack_a8 = 0;
        func_0x00010034ede4(&uStack_b0,0x200,8,0x4a,0x46);
        uVar8 = uStack_a8;
        uVar7 = uStack_b0;
        lVar11 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
        func_0x000101e5fa0c(0x3f800000,lVar11,uVar13,uVar12,uVar17,uVar7,uVar8,0);
        DataMemoryBarrier(2,3);
        plVar14 = (long *)(param_1 + 0xb0);
        *plVar14 = lVar11;
        *(undefined1 *)(((ulong)plVar14 >> 9 & 0x7fffff) + lVar16) = 1;
        lVar11 = *plVar14;
        uVar12 = _UNK_1036d8488;
        if ((lVar11 != 0) && (uVar12 = _UNK_1036d8490, (int *)(lVar11 + 0x38) != (int *)0x0)) {
          uStack_a0 = 0;
          uStack_98 = 0;
          func_0x00010034ede4(&uStack_a0,*(int *)(lVar11 + 0x38) + *(int *)(lVar11 + 0x40) + 8,
                              *(undefined4 *)(lVar11 + 0x3c),0x4a,0x46);
          uVar12 = uStack_98;
          uVar13 = uStack_a0;
          uVar17 = *puRam00000001038d5fa8;
          uStack_90 = 0;
          uStack_88 = 0;
          func_0x00010034ede4(&uStack_90,0x254,8,0x4a,0x46);
          uVar8 = uStack_88;
          uVar7 = uStack_90;
          lVar11 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
          func_0x000101e5fa0c(0x3f800000,lVar11,uVar13,uVar12,uVar17,uVar7,uVar8,0);
          DataMemoryBarrier(2,3);
          plVar14 = (long *)(param_1 + 0xb8);
          *plVar14 = lVar11;
          *(undefined1 *)(((ulong)plVar14 >> 9 & 0x7fffff) + lVar16) = 1;
          lVar11 = *plVar14;
          uVar12 = _UNK_1036d8498;
          if ((((lVar11 != 0) && (uVar12 = _UNK_1036d84a0, (int *)(lVar11 + 0x38) != (int *)0x0)) &&
              (lVar15 = *(long *)(param_1 + 0xb0), uVar12 = _UNK_1036d84a8, lVar15 != 0)) &&
             (uVar12 = _UNK_1036d84b0, lVar15 != -0x38)) {
            uStack_80 = 0;
            uStack_78 = 0;
            func_0x00010034ede4(&uStack_80,*(int *)(lVar11 + 0x38) + *(int *)(lVar11 + 0x40) + 8,
                                *(undefined4 *)(lVar15 + 0x3c),0x4a,0x46);
            uVar12 = uStack_78;
            uVar13 = uStack_80;
            uVar19 = *puRam00000001038d5fa8;
            uStack_70 = 0;
            uStack_68 = 0;
            func_0x00010034ede4(&uStack_70,0x200,0x4a,0x4a,0x46);
            uVar8 = uStack_68;
            uVar7 = uStack_70;
            uVar17 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
            func_0x000101e5fa0c(0x3f800000,uVar17,uVar13,uVar12,uVar19,uVar7,uVar8,0);
            DataMemoryBarrier(2,3);
            *(undefined8 *)(param_1 + 0xc0) = uVar17;
            *(undefined1 *)(((ulong)(param_1 + 0xc0) >> 9 & 0x7fffff) + lVar16) = 1;
            plVar14 = (long *)*plRam00000001038d5338;
            uVar12 = _UNK_1036d84b8;
            if (plVar14 != (long *)0x0) {
              uVar12 = (**(code **)(*plVar14 + 0x100))(plVar14,uRam0000000103904b30);
              lVar15 = func_0x000100331820(uRam00000001038d3b88,0x80);
              DataMemoryBarrier(2,3);
              *(long *)(lVar15 + 0x20) = param_1;
              *(undefined1 *)(((ulong)(lVar15 + 0x20) >> 9 & 0x7fffff) + lVar16) = 1;
              uVar13 = uRam0000000103904b40;
              lVar11 = lRam0000000103904b38;
              *(long *)(lVar15 + 0x40) = lRam0000000103904b38;
              *(undefined8 *)(lVar15 + 0x28) = uVar13;
              *(undefined8 *)(lVar15 + 0x18) = *(undefined8 *)(lVar11 + 0x30);
              uVar13 = uRam0000000103902d28;
              *(undefined8 *)(lVar15 + 0x10) = *(undefined8 *)(lVar11 + 0x28);
              lVar11 = func_0x000100331820(uVar13,0xb0);
              func_0x000101f0f050(lVar11,uVar12,lVar15,0,0x14);
              DataMemoryBarrier(2,3);
              plVar14 = (long *)(param_1 + 0xa8);
              *plVar14 = lVar11;
              *(undefined1 *)(((ulong)plVar14 >> 9 & 0x7fffff) + lVar16) = 1;
              lVar11 = *plVar14;
              lVar15 = *(long *)(lVar11 + 0x90);
              uVar12 = _UNK_1036d84c8;
              if ((lVar15 != 0) && (uVar12 = _UNK_1036d84d0, lVar15 != -0x38)) {
                *(undefined4 *)(lVar15 + 0x44) = 0x46;
                *(undefined4 *)(lVar11 + 0x7c) = 0x46;
                plVar14 = (long *)*plRam00000001038d5338;
                uVar12 = _UNK_1036d84e0;
                if (plVar14 != (long *)0x0) {
                  uVar13 = (**(code **)(*plVar14 + 0x100))(plVar14,uRam0000000103904b48);
                  lVar11 = *(long *)(param_1 + 0xb0);
                  uVar12 = _UNK_1036d84e8;
                  if ((lVar11 != 0) && (uVar12 = _UNK_1036d84f0, lVar11 != -0x38)) {
                    iVar3 = *(int *)(lVar11 + 0x3c);
                    iVar4 = *(int *)(lVar11 + 0x44);
                    iVar5 = *piRam00000001038d57b0;
                    lVar11 = func_0x000100331820(uRam0000000103902d50,200);
                    func_0x000101f109f0(lVar11,uVar13,0x8f,iVar5 + 0x14,iVar3 + iVar4 + 8,0xffffffff
                                       );
                    DataMemoryBarrier(2,3);
                    plVar14 = (long *)(param_1 + 0xa0);
                    *plVar14 = lVar11;
                    *(undefined1 *)(((ulong)plVar14 >> 9 & 0x7fffff) + lVar16) = 1;
                    uVar12 = _UNK_1036d84f8;
                    if (*plVar14 != 0) {
                      *(undefined4 *)(*plVar14 + 0xb4) = 0x14;
                      uVar12 = _UNK_1036d8500;
                      if (*(long *)(param_1 + 0xa0) != 0) {
                        *(undefined4 *)(*(long *)(param_1 + 0xa0) + 0xb8) = 300;
                        lVar16 = *(long *)(param_1 + 0xa0);
                        uVar10 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
                        uVar12 = _UNK_1036d8508;
                        if (lVar16 != 0) {
                          func_0x000101f10d44(lVar16,uVar10);
                          uVar12 = _UNK_1036d8510;
                          if ((*(long *)(param_1 + 0xb0) != 0) &&
                             (piVar2 = (int *)(*(long *)(param_1 + 0xb0) + 0x38),
                             uVar12 = _UNK_1036d8518, piVar2 != (int *)0x0)) {
                            *(int *)(param_1 + 0x140) = *piVar2 + -4;
                            return;
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
  }
  func_0x0001003316f4(0xee,uVar12);
                    /* WARNING: Does not return */
  pcVar9 = (code *)SoftwareBreakpoint(1,0x101fd296c);
  (*pcVar9)();
}

