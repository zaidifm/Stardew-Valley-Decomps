/* 0x06005e89 StardewValley.Menus.TutorialManager.initializeTutorials @ 0x101e21550 */

/* WARNING: Removing unreachable block (ram,0x000101e22a70) */
/* WARNING: Removing unreachable block (ram,0x000101e22a38) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialManager_initializeTutorials_06005e89(long param_1)

{
  int iVar1;
  bool bVar2;
  code *pcVar3;
  char cVar4;
  long lVar5;
  undefined8 uVar6;
  long lVar7;
  long lVar8;
  undefined4 uVar9;
  uint uVar10;
  undefined4 uVar11;
  undefined4 uVar12;
  undefined4 uVar13;
  undefined4 uVar14;
  undefined8 uStack_88;
  undefined8 uStack_80;
  long lStack_78;
  undefined8 uStack_70;
  undefined8 *puStack_68;
  
  cVar4 = cRam0000000103910c98;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103317950);
    cRam0000000103910c98 = '\x01';
  }
  uStack_88 = 0;
  uStack_80 = 0;
  lStack_78 = 0;
  uVar6 = _UNK_1036a2e28;
  if (param_1 != 0) {
    *(undefined8 *)(param_1 + 0x90) = 0;
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    if (*puRam00000001038d6430 < 4) {
      lVar8 = (long)(int)*puRam00000001038d6430 * 4;
      uVar12 = *(undefined4 *)(&UNK_103333e90 + lVar8);
      uVar9 = *(undefined4 *)(&UNK_103333ea0 + lVar8);
      uVar11 = *(undefined4 *)(&UNK_103333eb0 + lVar8);
      uVar13 = *(undefined4 *)(&UNK_103333ec0 + lVar8);
      uVar14 = *(undefined4 *)(&UNK_103333ed0 + lVar8);
    }
    else {
      uVar14 = 4;
      uVar13 = 7;
      uVar11 = 0x3a;
      uVar9 = 0x12;
      uVar12 = 10;
    }
    lVar5 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a(param_1,2);
    lVar8 = lRam00000001038c4be0;
    uVar6 = _UNK_1036a2e30;
    if (lVar5 != 0) {
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lVar5 + 0x88) = uRam00000001038c6c48;
      *(undefined1 *)(((ulong)(lVar5 + 0x88) >> 9 & 0x7fffff) + lVar8) = 1;
      uVar6 = StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                        (uRam00000001039008f0,0,0,0);
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lVar5 + 0x80) = uVar6;
      *(undefined1 *)(((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8) = 1;
      *(undefined1 *)(lVar5 + 0xb3) = 1;
      *(undefined4 *)(lVar5 + 0xd0) = 0x45bb8000;
      lVar5 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a(param_1,0xc);
      uVar6 = _UNK_1036a2e38;
      if (lVar5 != 0) {
        DataMemoryBarrier(2,3);
        *(undefined8 *)(lVar5 + 0x88) = uRam00000001038c6c48;
        *(undefined1 *)(((ulong)(lVar5 + 0x88) >> 9 & 0x7fffff) + lVar8) = 1;
        uVar6 = StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                          (uRam00000001039008f8,0,0,0);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(lVar5 + 0x80) = uVar6;
        *(undefined1 *)(((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8) = 1;
        SDV_StardewValley_Menus_TutorialItem_Target_06005e52(lVar5,uVar14,uVar13);
        lVar7 = func_0x000100331794(uRam00000001039008e8,1);
        *(undefined4 *)(lVar7 + 0x20) = 2;
        SDV_StardewValley_Menus_TutorialItem_Requires_06005e50(lVar5,lVar7);
        lVar5 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a(param_1,7);
        uVar6 = _UNK_1036a2e40;
        if (lVar5 != 0) {
          DataMemoryBarrier(2,3);
          *(undefined8 *)(lVar5 + 0x88) = uRam00000001038c6c48;
          *(undefined1 *)(((ulong)(lVar5 + 0x88) >> 9 & 0x7fffff) + lVar8) = 1;
          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
            func_0x0001003319b0();
          }
          uVar6 = _UNK_1036a2e48;
          if (*plRam00000001038d6880 != 0) {
            uVar6 = *(undefined8 *)(*plRam00000001038d6880 + 0x88);
            *(undefined4 *)(lVar5 + 200) = 0;
            *(undefined1 *)(lVar5 + 0xb4) = 1;
            DataMemoryBarrier(2,3);
            *(undefined8 *)(lVar5 + 0xa0) = uVar6;
            *(undefined1 *)(((ulong)(lVar5 + 0xa0) >> 9 & 0x7fffff) + lVar8) = 1;
            *(undefined4 *)(lVar5 + 0xd4) = 0x457a0000;
            lVar7 = func_0x000100331794(uRam00000001039008e8,1);
            *(undefined4 *)(lVar7 + 0x20) = 0xc;
            SDV_StardewValley_Menus_TutorialItem_Requires_06005e50(lVar5,lVar7);
            lVar5 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a(param_1,8);
            uVar6 = _UNK_1036a2e50;
            if (lVar5 != 0) {
              DataMemoryBarrier(2,3);
              *(undefined8 *)(lVar5 + 0x98) = uRam0000000103900900;
              *(undefined1 *)(((ulong)(lVar5 + 0x98) >> 9 & 0x7fffff) + lVar8) = 1;
              uVar6 = StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                (uRam0000000103900908,0,0,0);
              DataMemoryBarrier(2,3);
              *(undefined8 *)(lVar5 + 0x80) = uVar6;
              *(undefined1 *)(((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8) = 1;
              lVar7 = func_0x000100331794(uRam00000001039008e8,1);
              *(undefined4 *)(lVar7 + 0x20) = 7;
              SDV_StardewValley_Menus_TutorialItem_Requires_06005e50(lVar5,lVar7);
              lVar5 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a(param_1,9);
              uVar6 = _UNK_1036a2e58;
              if (lVar5 != 0) {
                DataMemoryBarrier(2,3);
                *(undefined8 *)(lVar5 + 0x98) = uRam0000000103900900;
                *(undefined1 *)(((ulong)(lVar5 + 0x98) >> 9 & 0x7fffff) + lVar8) = 1;
                uVar6 = StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                  (uRam0000000103900910,0,0,0);
                DataMemoryBarrier(2,3);
                *(undefined8 *)(lVar5 + 0x80) = uVar6;
                *(undefined1 *)(((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8) = 1;
                uVar6 = uRam0000000103900798;
                *(undefined1 *)(lVar5 + 0xb4) = 1;
                *(undefined4 *)(lVar5 + 200) = 0;
                DataMemoryBarrier(2,3);
                *(undefined8 *)(lVar5 + 0xa8) = uVar6;
                *(undefined1 *)(((ulong)(lVar5 + 0xa8) >> 9 & 0x7fffff) + lVar8) = 1;
                lVar7 = func_0x000100331794(uRam00000001039008e8,1);
                *(undefined4 *)(lVar7 + 0x20) = 8;
                SDV_StardewValley_Menus_TutorialItem_Requires_06005e50(lVar5,lVar7);
                lVar5 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a(param_1,6);
                uVar6 = _UNK_1036a2e60;
                if (lVar5 != 0) {
                  DataMemoryBarrier(2,3);
                  *(undefined8 *)(lVar5 + 0x88) = uRam00000001038c6c48;
                  *(undefined1 *)(((ulong)(lVar5 + 0x88) >> 9 & 0x7fffff) + lVar8) = 1;
                  SDV_StardewValley_Menus_TutorialItem_Target_06005e52(lVar5,3,uVar12);
                  lVar7 = func_0x000100331794(uRam00000001039008e8,1);
                  *(undefined4 *)(lVar7 + 0x20) = 9;
                  SDV_StardewValley_Menus_TutorialItem_Requires_06005e50(lVar5,lVar7);
                  lVar5 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a(param_1,0xd);
                  uVar6 = _UNK_1036a2e68;
                  if (lVar5 != 0) {
                    DataMemoryBarrier(2,3);
                    *(undefined8 *)(lVar5 + 0x88) = uRam00000001038c69c8;
                    *(undefined1 *)(((ulong)(lVar5 + 0x88) >> 9 & 0x7fffff) + lVar8) = 1;
                    uVar6 = StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                      (uRam0000000103900918,0,0,0);
                    DataMemoryBarrier(2,3);
                    *(undefined8 *)(lVar5 + 0x80) = uVar6;
                    *(undefined1 *)(((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8) = 1;
                    *(undefined1 *)(lVar5 + 0xb3) = 1;
                    *(undefined4 *)(lVar5 + 0xd0) = 0x45bb8000;
                    lVar7 = func_0x000100331794(uRam00000001039008e8,1);
                    *(undefined4 *)(lVar7 + 0x20) = 2;
                    SDV_StardewValley_Menus_TutorialItem_Requires_06005e50(lVar5,lVar7);
                    lVar5 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a(param_1,0xe);
                    uVar6 = _UNK_1036a2e70;
                    if (lVar5 != 0) {
                      DataMemoryBarrier(2,3);
                      *(undefined8 *)(lVar5 + 0x88) = uRam00000001038c69c8;
                      *(undefined1 *)(((ulong)(lVar5 + 0x88) >> 9 & 0x7fffff) + lVar8) = 1;
                      uVar6 = StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                        (uRam0000000103900920,0,0,0);
                      DataMemoryBarrier(2,3);
                      *(undefined8 *)(lVar5 + 0x80) = uVar6;
                      *(undefined1 *)(((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8) = 1;
                      SDV_StardewValley_Menus_TutorialItem_Target_06005e52(lVar5,uVar11,uVar9);
                      lVar7 = func_0x000100331794(uRam00000001039008e8,1);
                      *(undefined4 *)(lVar7 + 0x20) = 0xd;
                      SDV_StardewValley_Menus_TutorialItem_Requires_06005e50(lVar5,lVar7);
                      lVar5 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a(param_1,0xf)
                      ;
                      uVar6 = _UNK_1036a2e78;
                      if (lVar5 != 0) {
                        DataMemoryBarrier(2,3);
                        bVar2 = true;
                        *(undefined8 *)(lVar5 + 0x88) = uRam00000001038c69c8;
                        *(undefined1 *)(((ulong)(lVar5 + 0x88) >> 9 & 0x7fffff) + lVar8) = 1;
                        uVar6 = StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                          (uRam0000000103900928,0,0,0);
                        DataMemoryBarrier(2,3);
                        *(undefined8 *)(lVar5 + 0x80) = uVar6;
                        *(undefined1 *)(((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8) = 1;
                        lVar7 = func_0x000100331794(uRam00000001039008e8,1);
                        *(undefined4 *)(lVar7 + 0x20) = 0xe;
                        SDV_StardewValley_Menus_TutorialItem_Requires_06005e50(lVar5,lVar7);
                        lVar5 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                          (param_1,0x10);
                        uVar6 = _UNK_1036a2e80;
                        if (lVar5 != 0) {
                          DataMemoryBarrier(2,3);
                          *(undefined8 *)(lVar5 + 0x88) = uRam00000001038c69c8;
                          *(undefined1 *)(((ulong)(lVar5 + 0x88) >> 9 & 0x7fffff) + lVar8) = 1;
                          uVar6 = StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                            (uRam0000000103900930,0,0,0);
                          DataMemoryBarrier(2,3);
                          *(undefined8 *)(lVar5 + 0x80) = uVar6;
                          *(undefined1 *)(((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8) = 1;
                          uVar6 = uRam00000001038c7a18;
                          *(undefined1 *)(lVar5 + 0xb4) = 1;
                          *(undefined4 *)(lVar5 + 200) = 0;
                          DataMemoryBarrier(2,3);
                          *(undefined8 *)(lVar5 + 0xa8) = uVar6;
                          *(undefined1 *)(((ulong)(lVar5 + 0xa8) >> 9 & 0x7fffff) + lVar8) = 1;
                          lVar7 = func_0x000100331794(uRam00000001039008e8,1);
                          *(undefined4 *)(lVar7 + 0x20) = 0xf;
                          SDV_StardewValley_Menus_TutorialItem_Requires_06005e50(lVar5,lVar7);
                          lVar7 = func_0x000100331794(uRam00000001039008e8,1);
                          *(undefined4 *)(lVar7 + 0x20) = 0x11;
                          SDV_StardewValley_Menus_TutorialItem_SkippedBy_06005e51(lVar5,lVar7);
                          if (*puRam00000001038d6430 == 7) {
                            if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                              func_0x0001003319b0();
                            }
                            uVar6 = _UNK_1036a2fa0;
                            if (*plRam00000001038d5b20 == 0) goto LAB_101e2280c;
                            cVar4 = func_0x000100345aa0(*(undefined8 *)
                                                         (*plRam00000001038d5b20 + 0x10),
                                                        uRam00000001038e7130);
                            if (cVar4 == '\0') {
                              bVar2 = true;
                            }
                            else {
                              if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                                func_0x0001003319b0();
                              }
                              uVar6 = _UNK_1036a2f90;
                              if (*plRam00000001038d5338 == 0) goto LAB_101e2280c;
                              if (*(char *)(lRam00000001038c4c68 + 0x35) == '\0') {
                                func_0x0001003319b0();
                              }
                              if (*piRam00000001038d5f10 == 0) {
                                lVar5 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                                  (param_1,0x30);
                                uVar6 = _UNK_1036a2f98;
                                if (lVar5 == 0) goto LAB_101e2280c;
                                DataMemoryBarrier(2,3);
                                *(undefined8 *)(lVar5 + 0x88) = uRam00000001038c69c8;
                                *(undefined1 *)(((ulong)(lVar5 + 0x88) >> 9 & 0x7fffff) + lVar8) = 1
                                ;
                                uVar6 = StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                                  (uRam00000001039009f8,0,0,0);
                                DataMemoryBarrier(2,3);
                                *(undefined8 *)(lVar5 + 0x80) = uVar6;
                                *(undefined1 *)(((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8) = 1
                                ;
                                lVar7 = func_0x000100331794(uRam00000001039008e8,2);
                                *(undefined8 *)(lVar7 + 0x20) = 0xf0000000c;
                                SDV_StardewValley_Menus_TutorialItem_Requires_06005e50(lVar5,lVar7);
                              }
                              bVar2 = false;
                            }
                          }
                          iVar1 = *(int *)(*(long *)(param_1 + 0x68) + 0x18);
                          lVar5 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                            (param_1,0x11);
                          uVar6 = _UNK_1036a2e98;
                          if (lVar5 != 0) {
                            DataMemoryBarrier(2,3);
                            *(undefined8 *)(lVar5 + 0x88) = uRam00000001038c69c8;
                            *(undefined1 *)(((ulong)(lVar5 + 0x88) >> 9 & 0x7fffff) + lVar8) = 1;
                            uVar6 = StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                              (uRam0000000103900938,0,0,0);
                            DataMemoryBarrier(2,3);
                            *(undefined8 *)(lVar5 + 0x80) = uVar6;
                            *(undefined1 *)(((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8) = 1;
                            lVar7 = func_0x000100331794(uRam00000001039008e8,2);
                            *(undefined8 *)(lVar7 + 0x20) = 0xf00000010;
                            SDV_StardewValley_Menus_TutorialItem_Requires_06005e50(lVar5,lVar7);
                            lVar5 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                              (param_1,0x12);
                            uVar6 = _UNK_1036a2ea0;
                            if (lVar5 != 0) {
                              DataMemoryBarrier(2,3);
                              *(undefined8 *)(lVar5 + 0x88) = uRam00000001038c69c8;
                              *(undefined1 *)(((ulong)(lVar5 + 0x88) >> 9 & 0x7fffff) + lVar8) = 1;
                              uVar6 = StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                                (uRam0000000103900940,0,0,0);
                              DataMemoryBarrier(2,3);
                              *(undefined8 *)(lVar5 + 0x80) = uVar6;
                              *(undefined1 *)(((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8) = 1;
                              lVar7 = func_0x000100331794(uRam00000001039008e8,2);
                              *(undefined8 *)(lVar7 + 0x20) = 0xc00000011;
                              SDV_StardewValley_Menus_TutorialItem_Requires_06005e50(lVar5,lVar7);
                              lVar5 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                                (param_1,0x2f);
                              uVar6 = _UNK_1036a2ea8;
                              if (lVar5 != 0) {
                                DataMemoryBarrier(2,3);
                                *(undefined8 *)(lVar5 + 0x88) = uRam00000001038c69c8;
                                *(undefined1 *)(((ulong)(lVar5 + 0x88) >> 9 & 0x7fffff) + lVar8) = 1
                                ;
                                uVar6 = StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                                  (uRam0000000103900948,0,0,0);
                                DataMemoryBarrier(2,3);
                                *(undefined8 *)(lVar5 + 0x80) = uVar6;
                                *(undefined1 *)(((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8) = 1
                                ;
                                lVar7 = func_0x000100331794(uRam00000001039008e8,1);
                                *(undefined4 *)(lVar7 + 0x20) = 0x11;
                                SDV_StardewValley_Menus_TutorialItem_Requires_06005e50(lVar5,lVar7);
                                lVar7 = func_0x000100331794(uRam00000001039008e8,1);
                                *(undefined4 *)(lVar7 + 0x20) = 0xc;
                                SDV_StardewValley_Menus_TutorialItem_SkippedBy_06005e51(lVar5,lVar7)
                                ;
                                lVar5 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                                  (param_1,0x13);
                                uVar6 = _UNK_1036a2eb0;
                                if (lVar5 != 0) {
                                  DataMemoryBarrier(2,3);
                                  *(undefined8 *)(lVar5 + 0x88) = uRam00000001038c69c8;
                                  *(undefined1 *)(((ulong)(lVar5 + 0x88) >> 9 & 0x7fffff) + lVar8) =
                                       1;
                                  uVar6 = StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                                    (uRam0000000103900950,0,0,0);
                                  DataMemoryBarrier(2,3);
                                  *(undefined8 *)(lVar5 + 0x80) = uVar6;
                                  *(undefined1 *)(((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8) =
                                       1;
                                  lVar7 = func_0x000100331794(uRam00000001039008e8,1);
                                  *(undefined4 *)(lVar7 + 0x20) = 0x12;
                                  SDV_StardewValley_Menus_TutorialItem_Requires_06005e50
                                            (lVar5,lVar7);
                                  lVar5 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                                    (param_1,0x1e);
                                  uVar6 = _UNK_1036a2eb8;
                                  if (lVar5 != 0) {
                                    DataMemoryBarrier(2,3);
                                    *(undefined8 *)(lVar5 + 0x88) = uRam00000001038c69c8;
                                    *(undefined1 *)(((ulong)(lVar5 + 0x88) >> 9 & 0x7fffff) + lVar8)
                                         = 1;
                                    uVar6 = StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                                      (uRam0000000103900958,0,0,0);
                                    DataMemoryBarrier(2,3);
                                    *(undefined8 *)(lVar5 + 0x80) = uVar6;
                                    *(undefined1 *)(((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8)
                                         = 1;
                                    *(undefined1 *)(lVar5 + 0xb3) = 1;
                                    *(undefined4 *)(lVar5 + 0xd0) = 0x45bb8000;
                                    lVar7 = func_0x000100331794(uRam00000001039008e8,1);
                                    *(undefined4 *)(lVar7 + 0x20) = 0x13;
                                    SDV_StardewValley_Menus_TutorialItem_Requires_06005e50
                                              (lVar5,lVar7);
                                    lVar5 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                                      (param_1,0x1d);
                                    uVar6 = _UNK_1036a2ec0;
                                    if (lVar5 != 0) {
                                      DataMemoryBarrier(2,3);
                                      *(undefined8 *)(lVar5 + 0x88) = uRam00000001038c69c8;
                                      *(undefined1 *)
                                       (((ulong)(lVar5 + 0x88) >> 9 & 0x7fffff) + lVar8) = 1;
                                      uVar6 = StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                                        (uRam0000000103900960,0,0,0);
                                      DataMemoryBarrier(2,3);
                                      *(undefined8 *)(lVar5 + 0x80) = uVar6;
                                      *(undefined1 *)
                                       (((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8) = 1;
                                      *(undefined1 *)(lVar5 + 0xb3) = 1;
                                      *(undefined4 *)(lVar5 + 0xd0) = 0x45bb8000;
                                      lVar7 = func_0x000100331794(uRam00000001039008e8,1);
                                      *(undefined4 *)(lVar7 + 0x20) = 0x1e;
                                      SDV_StardewValley_Menus_TutorialItem_Requires_06005e50
                                                (lVar5,lVar7);
                                      if (bVar2) {
LAB_101e21fc0:
                                        lVar5 = SDV_StardewValley_Menus_TutorialManager_GetTutorial_06005e6b
                                                          (param_1,0x16);
                                        lVar7 = func_0x000100331794(uRam00000001039008e8,1);
                                        *(undefined4 *)(lVar7 + 0x20) = 0x13;
                                        uVar6 = _UNK_1036a2ed0;
                                        if (lVar5 != 0) {
                                          SDV_StardewValley_Menus_TutorialItem_Requires_06005e50
                                                    (lVar5,lVar7);
                                          lVar5 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                                            (param_1,0x17);
                                          uVar6 = _UNK_1036a2ed8;
                                          if (lVar5 != 0) {
                                            uVar6 = 
                                                  StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                                            (uRam0000000103900968,0,0,0);
                                            DataMemoryBarrier(2,3);
                                            *(undefined8 *)(lVar5 + 0x80) = uVar6;
                                            *(undefined1 *)
                                             (((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8) = 1;
                                            lVar7 = func_0x000100331794(uRam00000001039008e8,1);
                                            *(undefined4 *)(lVar7 + 0x20) = 0x16;
                                            SDV_StardewValley_Menus_TutorialItem_Requires_06005e50
                                                      (lVar5,lVar7);
                                            lVar5 = 
                                                  SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                                            (param_1,10);
                                            uVar6 = _UNK_1036a2ee0;
                                            if (lVar5 != 0) {
                                              DataMemoryBarrier(2,3);
                                              *(undefined8 *)(lVar5 + 0x88) = uRam00000001038c6ba0;
                                              *(undefined1 *)
                                               (((ulong)(lVar5 + 0x88) >> 9 & 0x7fffff) + lVar8) = 1
                                              ;
                                              uVar6 = 
                                                  StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                                            (uRam0000000103900970,0,0,0);
                                              DataMemoryBarrier(2,3);
                                              *(undefined8 *)(lVar5 + 0x80) = uVar6;
                                              *(undefined1 *)
                                               (((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8) = 1
                                              ;
                                              SDV_StardewValley_Menus_TutorialItem_Target_06005e52
                                                        (lVar5,0xc,0x17);
                                              lVar7 = func_0x000100331794(uRam00000001039008e8,1);
                                              *(undefined4 *)(lVar7 + 0x20) = 2;
                                              SDV_StardewValley_Menus_TutorialItem_Requires_06005e50
                                                        (lVar5,lVar7);
                                              lVar5 = 
                                                  SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                                            (param_1,0xb);
                                              uVar6 = _UNK_1036a2ee8;
                                              if (lVar5 != 0) {
                                                DataMemoryBarrier(2,3);
                                                *(undefined8 *)(lVar5 + 0x88) = uRam00000001038c6ba0
                                                ;
                                                *(undefined1 *)
                                                 (((ulong)(lVar5 + 0x88) >> 9 & 0x7fffff) + lVar8) =
                                                     1;
                                                uVar6 = 
                                                  StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                                            (uRam0000000103900978,0,0,0);
                                                DataMemoryBarrier(2,3);
                                                *(undefined8 *)(lVar5 + 0x80) = uVar6;
                                                *(undefined1 *)
                                                 (((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8) =
                                                     1;
                                                *(undefined1 *)(lVar5 + 0xb3) = 1;
                                                *(undefined4 *)(lVar5 + 0xd0) = 0x45bb8000;
                                                lVar7 = func_0x000100331794(uRam00000001039008e8,1);
                                                *(undefined4 *)(lVar7 + 0x20) = 10;
                                                SDV_StardewValley_Menus_TutorialItem_Requires_06005e50
                                                          (lVar5,lVar7);
                                                lVar5 = 
                                                  SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                                            (param_1,0x1c);
                                                uVar6 = _UNK_1036a2ef0;
                                                if (lVar5 != 0) {
                                                  uVar6 = 
                                                  StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                                            (uRam0000000103900980,0,0,0);
                                                  DataMemoryBarrier(2,3);
                                                  *(undefined8 *)(lVar5 + 0x80) = uVar6;
                                                  *(undefined1 *)
                                                   (((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8)
                                                       = 1;
                                                  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0'
                                                     ) {
                                                    func_0x0001003319b0();
                                                  }
                                                  uVar6 = _UNK_1036a2ef8;
                                                  if (*plRam00000001038d6880 != 0) {
                                                    uVar6 = *(undefined8 *)
                                                             (*plRam00000001038d6880 + 0x68);
                                                    *(undefined4 *)(lVar5 + 200) = 0;
                                                    *(undefined1 *)(lVar5 + 0xb4) = 1;
                                                    DataMemoryBarrier(2,3);
                                                    *(undefined8 *)(lVar5 + 0xa0) = uVar6;
                                                    *(undefined1 *)
                                                     (((ulong)(lVar5 + 0xa0) >> 9 & 0x7fffff) +
                                                     lVar8) = 1;
                                                    *(undefined4 *)(lVar5 + 0xd4) = 0x46ea6000;
                                                    lVar7 = func_0x000100331794(uRam00000001039008e8
                                                                                ,1);
                                                    *(undefined4 *)(lVar7 + 0x20) = 0xb;
                                                                                                        
                                                  SDV_StardewValley_Menus_TutorialItem_Requires_06005e50
                                                            (lVar5,lVar7);
                                                  lVar5 = 
                                                  SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                                            (param_1,0x20);
                                                  uVar6 = _UNK_1036a2f00;
                                                  if (lVar5 != 0) {
                                                    DataMemoryBarrier(2,3);
                                                    *(undefined8 *)(lVar5 + 0x98) =
                                                         uRam0000000103900988;
                                                    *(undefined1 *)
                                                     (((ulong)(lVar5 + 0x98) >> 9 & 0x7fffff) +
                                                     lVar8) = 1;
                                                    uVar6 = 
                                                  StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                                            (uRam0000000103900990,0,0,0);
                                                  DataMemoryBarrier(2,3);
                                                  *(undefined8 *)(lVar5 + 0x80) = uVar6;
                                                  *(undefined1 *)
                                                   (((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8)
                                                       = 1;
                                                  *(undefined1 *)(lVar5 + 0xb3) = 1;
                                                  *(undefined4 *)(lVar5 + 0xd0) = 0x45bb8000;
                                                  lVar7 = func_0x000100331794(uRam00000001039008e8,1
                                                                             );
                                                  *(undefined4 *)(lVar7 + 0x20) = 0x1f;
                                                  SDV_StardewValley_Menus_TutorialItem_Requires_06005e50
                                                            (lVar5,lVar7);
                                                  lVar5 = 
                                                  SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                                            (param_1,0x19);
                                                  uVar6 = _UNK_1036a2f08;
                                                  if (lVar5 != 0) {
                                                    DataMemoryBarrier(2,3);
                                                    *(undefined8 *)(lVar5 + 0x98) =
                                                         uRam0000000103900998;
                                                    *(undefined1 *)
                                                     (((ulong)(lVar5 + 0x98) >> 9 & 0x7fffff) +
                                                     lVar8) = 1;
                                                    uVar6 = 
                                                  StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                                            (uRam00000001039009a0,0,0,0);
                                                  DataMemoryBarrier(2,3);
                                                  *(undefined8 *)(lVar5 + 0x80) = uVar6;
                                                  *(undefined1 *)
                                                   (((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8)
                                                       = 1;
                                                  *(undefined1 *)(lVar5 + 0xb3) = 1;
                                                  *(undefined4 *)(lVar5 + 0xd0) = 0x45bb8000;
                                                  lVar7 = func_0x000100331794(uRam00000001039008e8,1
                                                                             );
                                                  *(undefined4 *)(lVar7 + 0x20) = 0x21;
                                                  SDV_StardewValley_Menus_TutorialItem_Requires_06005e50
                                                            (lVar5,lVar7);
                                                  lVar5 = 
                                                  SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                                            (param_1,0x1a);
                                                  uVar6 = _UNK_1036a2f10;
                                                  if (lVar5 != 0) {
                                                    DataMemoryBarrier(2,3);
                                                    *(undefined8 *)(lVar5 + 0x98) =
                                                         uRam00000001039009a8;
                                                    *(undefined1 *)
                                                     (((ulong)(lVar5 + 0x98) >> 9 & 0x7fffff) +
                                                     lVar8) = 1;
                                                    uVar6 = 
                                                  StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                                            (uRam00000001039009b0,0,0,0);
                                                  DataMemoryBarrier(2,3);
                                                  *(undefined8 *)(lVar5 + 0x80) = uVar6;
                                                  *(undefined1 *)
                                                   (((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8)
                                                       = 1;
                                                  *(undefined1 *)(lVar5 + 0xb3) = 1;
                                                  *(undefined4 *)(lVar5 + 0xd0) = 0x45bb8000;
                                                  lVar7 = func_0x000100331794(uRam00000001039008e8,1
                                                                             );
                                                  *(undefined4 *)(lVar7 + 0x20) = 0x22;
                                                  SDV_StardewValley_Menus_TutorialItem_Requires_06005e50
                                                            (lVar5,lVar7);
                                                  lVar5 = 
                                                  SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                                            (param_1,0x1b);
                                                  uVar6 = _UNK_1036a2f18;
                                                  if (lVar5 != 0) {
                                                    DataMemoryBarrier(2,3);
                                                    *(undefined8 *)(lVar5 + 0x98) =
                                                         uRam00000001039009b8;
                                                    *(undefined1 *)
                                                     (((ulong)(lVar5 + 0x98) >> 9 & 0x7fffff) +
                                                     lVar8) = 1;
                                                    uVar6 = 
                                                  StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                                            (uRam00000001039009c0,0,0,0);
                                                  DataMemoryBarrier(2,3);
                                                  *(undefined8 *)(lVar5 + 0x80) = uVar6;
                                                  *(undefined1 *)
                                                   (((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8)
                                                       = 1;
                                                  *(undefined1 *)(lVar5 + 0xb3) = 1;
                                                  *(undefined4 *)(lVar5 + 0xd0) = 0x45bb8000;
                                                  lVar7 = func_0x000100331794(uRam00000001039008e8,1
                                                                             );
                                                  *(undefined4 *)(lVar7 + 0x20) = 0x25;
                                                  SDV_StardewValley_Menus_TutorialItem_Requires_06005e50
                                                            (lVar5,lVar7);
                                                  lVar5 = 
                                                  SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                                            (param_1,0x24);
                                                  uVar6 = _UNK_1036a2f20;
                                                  if (lVar5 != 0) {
                                                    DataMemoryBarrier(2,3);
                                                    *(undefined8 *)(lVar5 + 0x98) =
                                                         uRam00000001039009c8;
                                                    *(undefined1 *)
                                                     (((ulong)(lVar5 + 0x98) >> 9 & 0x7fffff) +
                                                     lVar8) = 1;
                                                    uVar6 = 
                                                  StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                                            (uRam00000001039009d0,0,0,0);
                                                  DataMemoryBarrier(2,3);
                                                  *(undefined8 *)(lVar5 + 0x80) = uVar6;
                                                  *(undefined1 *)
                                                   (((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8)
                                                       = 1;
                                                  *(undefined1 *)(lVar5 + 0xb3) = 1;
                                                  *(undefined4 *)(lVar5 + 0xd0) = 0x45bb8000;
                                                  lVar7 = func_0x000100331794(uRam00000001039008e8,1
                                                                             );
                                                  *(undefined4 *)(lVar7 + 0x20) = 0x23;
                                                  SDV_StardewValley_Menus_TutorialItem_Requires_06005e50
                                                            (lVar5,lVar7);
                                                  lVar5 = 
                                                  SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                                            (param_1,0x27);
                                                  uVar6 = _UNK_1036a2f28;
                                                  if (lVar5 != 0) {
                                                    DataMemoryBarrier(2,3);
                                                    *(undefined8 *)(lVar5 + 0x98) =
                                                         uRam00000001039009d8;
                                                    *(undefined1 *)
                                                     (((ulong)(lVar5 + 0x98) >> 9 & 0x7fffff) +
                                                     lVar8) = 1;
                                                    uVar6 = 
                                                  StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                                            (uRam00000001039009e0,0,0,0);
                                                  DataMemoryBarrier(2,3);
                                                  *(undefined8 *)(lVar5 + 0x80) = uVar6;
                                                  *(undefined1 *)
                                                   (((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8)
                                                       = 1;
                                                  *(undefined1 *)(lVar5 + 0xb3) = 1;
                                                  *(undefined4 *)(lVar5 + 0xd0) = 0x45bb8000;
                                                  lVar7 = func_0x000100331794(uRam00000001039008e8,1
                                                                             );
                                                  *(undefined4 *)(lVar7 + 0x20) = 0x26;
                                                  SDV_StardewValley_Menus_TutorialItem_Requires_06005e50
                                                            (lVar5,lVar7);
                                                  lVar5 = 
                                                  SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                                            (param_1,0x14);
                                                  uVar6 = _UNK_1036a2f30;
                                                  if (lVar5 != 0) {
                                                    uVar6 = 
                                                  StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                                            (uRam00000001039009e8,0,0,0);
                                                  DataMemoryBarrier(2,3);
                                                  *(undefined8 *)(lVar5 + 0x80) = uVar6;
                                                  *(undefined1 *)
                                                   (((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8)
                                                       = 1;
                                                  *(undefined1 *)(lVar5 + 0xb3) = 1;
                                                  *(undefined4 *)(lVar5 + 0xd0) = 0x45bb8000;
                                                  lVar7 = func_0x000100331794(uRam00000001039008e8,1
                                                                             );
                                                  *(undefined4 *)(lVar7 + 0x20) = 0x28;
                                                  SDV_StardewValley_Menus_TutorialItem_Requires_06005e50
                                                            (lVar5,lVar7);
                                                  lVar5 = 
                                                  SDV_StardewValley_Menus_TutorialManager_Register_06005e6a
                                                            (param_1,0x2e);
                                                  uVar6 = _UNK_1036a2f38;
                                                  if (lVar5 != 0) {
                                                    uVar6 = 
                                                  StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                                                            (uRam00000001039009f0,0,0,0);
                                                  DataMemoryBarrier(2,3);
                                                  *(undefined8 *)(lVar5 + 0x80) = uVar6;
                                                  *(undefined1 *)
                                                   (((ulong)(lVar5 + 0x80) >> 9 & 0x7fffff) + lVar8)
                                                       = 1;
                                                  *(undefined1 *)(lVar5 + 0xb3) = 1;
                                                  *(undefined4 *)(lVar5 + 0xd0) = 0x45bb8000;
                                                  lVar8 = func_0x000100331794(uRam00000001039008e8,1
                                                                             );
                                                  *(undefined4 *)(lVar8 + 0x20) = 0x2d;
                                                  SDV_StardewValley_Menus_TutorialItem_Requires_06005e50
                                                            (lVar5,lVar8);
                                                  uVar6 = _UNK_1036a2f48;
                                                  if (*(long *)(param_1 + 0x68) != 0) {
                                                    func_0x000100378040(&uStack_88);
                                                    while (cVar4 = func_0x000100378054(&uStack_88),
                                                          lVar8 = lStack_78, cVar4 != '\0') {
                                                      if (lStack_78 == 0) {
                                                        uVar6 = 0xee;
LAB_101e22758:
                                                        func_0x0001003316f4(uVar6,_UNK_1036a2f58);
                    /* WARNING: Does not return */
                                                        pcVar3 = (code *)SoftwareBreakpoint(1,
                                                  0x101e22768);
                                                  (*pcVar3)();
                                                  }
                                                  if (*(int *)(lStack_78 + 0xcc) != 1) {
                                                    lVar5 = func_0x000100331794(uRam00000001039008e8
                                                                                ,1);
                                                    if (*(int *)(lVar5 + 0x18) == 0) {
                                                      uVar6 = 0xcc;
                                                      goto LAB_101e22758;
                                                    }
                                                    *(undefined4 *)(lVar5 + 0x20) = 0x2b;
                                                                                                        
                                                  SDV_StardewValley_Menus_TutorialItem_Requires_06005e50
                                                            (lVar8);
                                                  }
                                                  if (lRam0000000103976fb8 != 0) {
                                                    func_0x00010119b8f8();
                                                  }
                                                  }
                                                  uStack_70 = 0;
                                                  puStack_68 = &uStack_88;
                                                  if (puStack_68 != (undefined8 *)0x0) {
                                                    cVar4 = 
                                                  SDV_StardewValley_Game1_isGamePadConnected_06002f76
                                                            ();
                                                  if (cVar4 == '\0') {
                                                    *(undefined1 *)(param_1 + 0xce) = 0;
                                                  }
                                                  else {
                                                                                                        
                                                  SDV_StardewValley_Menus_TutorialManager_set_gamePadHasBeenUsed_06005e6d
                                                            (param_1,1);
                                                  }
                                                  return;
                                                  }
                                                  puStack_68 = (undefined8 *)0x0;
                                                  uVar6 = _UNK_1036a2f50;
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
                                          }
                                        }
                                      }
                                      else {
                                        uVar6 = _UNK_1036a2f88;
                                        if (param_1 != 0) {
                                          uVar10 = iVar1 + 1;
                                          do {
                                            while( true ) {
                                              if (*(int *)(*(long *)(param_1 + 0x68) + 0x18) <=
                                                  (int)uVar10) goto LAB_101e21fc0;
                                              if (*(uint *)(*(long *)(param_1 + 0x68) + 0x18) <=
                                                  uVar10) {
                                                func_0x000100331b90();
                    /* WARNING: Does not return */
                                                pcVar3 = (code *)SoftwareBreakpoint(1,0x101e227e4);
                                                (*pcVar3)();
                                              }
                                              lVar5 = *(long *)(*(long *)(param_1 + 0x68) + 0x10);
                                              if (*(uint *)(lVar5 + 0x18) <= uVar10) {
                                                func_0x0001003316f4(0xcc,_UNK_1036a2fa8);
                    /* WARNING: Does not return */
                                                pcVar3 = (code *)SoftwareBreakpoint(1,0x101e22804);
                                                (*pcVar3)();
                                              }
                                              uVar6 = _UNK_1036a2f80;
                                              if (*(long *)(lVar5 + (long)(int)uVar10 * 8 + 0x20) ==
                                                  0) goto LAB_101e2280c;
                                              SDV_StardewValley_Menus_TutorialItem_setComplete_06005e56
                                                        ();
                                              if (lRam0000000103976fb8 != 0) break;
                                              uVar10 = uVar10 + 1;
                                              uVar6 = _UNK_1036a2f88;
                                              if (param_1 == 0) goto LAB_101e2280c;
                                            }
                                            func_0x00010119b8f8();
                                            uVar10 = uVar10 + 1;
                                            uVar6 = _UNK_1036a2f88;
                                          } while (param_1 != 0);
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
              }
            }
          }
        }
      }
    }
  }
LAB_101e2280c:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101e22818);
  (*pcVar3)();
}

