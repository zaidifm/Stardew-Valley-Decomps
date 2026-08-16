/* 0x06004ba1 StardewValley.Network.LoopbackServer.receiveMessages @ 0x101b4398c */

/* WARNING: Removing unreachable block (ram,0x000101b44384) */
/* WARNING: Removing unreachable block (ram,0x000101b44368) */
/* WARNING: Removing unreachable block (ram,0x000101b43a70) */
/* WARNING: Removing unreachable block (ram,0x000101b4431c) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* WARNING: Restarted to delay deadcode elimination for space: stack */

void SDV_StardewValley_Network_LoopbackServer_receiveMessages_06004ba1(long *param_1)

{
  long lVar1;
  long *plVar2;
  undefined8 uVar3;
  code *pcVar4;
  char cVar5;
  undefined8 uVar6;
  long lVar7;
  undefined8 uVar8;
  long lVar9;
  long *plVar10;
  undefined8 uStack_270;
  undefined8 uStack_268;
  long *plStack_260;
  long *plStack_258;
  undefined8 uStack_250;
  undefined8 uStack_248;
  undefined8 uStack_240;
  undefined8 uStack_238;
  undefined8 uStack_230;
  undefined8 uStack_228;
  long lStack_220;
  long lStack_210;
  long lStack_208;
  undefined8 uStack_200;
  undefined8 uStack_1f8;
  undefined8 uStack_1f0;
  undefined8 uStack_1e8;
  undefined8 *puStack_1e0;
  int iStack_1d4;
  long lStack_1d0;
  undefined8 uStack_1c8;
  undefined8 uStack_1c0;
  long lStack_1b8;
  long lStack_1b0;
  undefined8 *puStack_1a8;
  long *plStack_1a0;
  uint uStack_194;
  long lStack_190;
  undefined8 uStack_188;
  undefined8 uStack_180;
  long lStack_178;
  long lStack_170;
  long *plStack_168;
  long lStack_160;
  long lStack_158;
  long lStack_150;
  long *plStack_148;
  undefined8 uStack_140;
  undefined8 uStack_138;
  long *plStack_130;
  undefined8 *puStack_128;
  undefined1 uStack_119;
  long lStack_118;
  long *plStack_110;
  undefined8 uStack_108;
  long lStack_100;
  undefined8 uStack_f8;
  long lStack_f0;
  undefined8 *puStack_e8;
  undefined1 uStack_d9;
  undefined8 uStack_d8;
  long *plStack_d0;
  undefined8 *puStack_c8;
  int iStack_bc;
  long lStack_b8;
  undefined8 uStack_b0;
  undefined8 uStack_a8;
  long lStack_a0;
  long lStack_98;
  undefined8 *puStack_90;
  undefined8 uStack_88;
  long lStack_80;
  undefined8 *puStack_78;
  int iStack_6c;
  long lStack_68;
  
  cVar5 = cRam000000010390f9b0;
  plStack_258 = param_1;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar5 == '\0') {
    func_0x00010119b908(&UNK_1032faa30);
    cRam000000010390f9b0 = '\x01';
  }
  uStack_228 = 0;
  lStack_220 = 0;
  uStack_230 = 0;
  lStack_210 = 0;
  lStack_208 = 0;
  uStack_200 = 0;
  uStack_248 = 0;
  uStack_250 = 0;
  uStack_238 = 0;
  uStack_240 = 0;
  if ((char)plStack_258[0xc] == '\0') {
    return;
  }
  uVar6 = _UNK_103654d30;
  uVar8 = uStack_1e8;
  if (plStack_258[4] != 0) {
    func_0x00010036ced4(&uStack_250);
    while (cVar5 = func_0x00010036cf38(&uStack_250), uVar8 = uStack_238, uVar6 = uStack_240,
          plVar10 = plStack_258, cVar5 != '\0') {
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      SDV_StardewValley_Network_LoopbackServer_parseDataMessageFromClient_06004ba4
                (plVar10,uVar6,uVar8);
    }
    uStack_1f8 = 0;
    puStack_1e0 = &uStack_250;
    uVar6 = _UNK_103654e18;
    uVar8 = uStack_1e8;
    if (puStack_1e0 != (undefined8 *)0x0) {
      uStack_1f8 = 0;
      lStack_1d0 = plStack_258[4];
      iStack_1d4 = 0;
      uVar6 = _UNK_103654d38;
      if (((lStack_1d0 != 0) && (uVar6 = _UNK_103654d40, lStack_1d0 != 0)) &&
         (uVar6 = _UNK_103654d48, lStack_1d0 != 0)) {
        *(int *)(lStack_1d0 + 0x1c) = *(int *)(lStack_1d0 + 0x1c) + 1;
        iStack_1d4 = *(int *)(lStack_1d0 + 0x18);
        *(undefined4 *)(lStack_1d0 + 0x18) = 0;
        if (0 < iStack_1d4) {
          func_0x000100331c80(*(undefined8 *)(lStack_1d0 + 0x10),0,iStack_1d4);
        }
        uVar6 = _UNK_103654d58;
        uVar8 = uStack_1e8;
        if (plStack_258[8] != 0) {
          func_0x00010036ce5c(&uStack_1c8);
          lVar1 = lRam00000001038c4be0;
          lStack_220 = lStack_1b8;
          uStack_228 = uStack_1c0;
          uStack_230 = uStack_1c8;
          while (cVar5 = func_0x00010036ce70(&uStack_230), cVar5 != '\0') {
            lStack_210 = func_0x000100331820(uRam00000001038f5510,0x28);
            if (lStack_210 == 0) {
LAB_101b43f00:
              uVar6 = 0xee;
LAB_101b43f04:
              func_0x0001003316f4(uVar6,_UNK_103654d60);
              goto LAB_101b441c4;
            }
            DataMemoryBarrier(2,3);
            *(undefined8 *)(lStack_210 + 0x18U) = plStack_258;
            *(undefined1 *)((lStack_210 + 0x18U >> 9 & 0x7fffff) + lVar1) = 1;
            puStack_1a8 = &uStack_230;
            if ((&uStack_230 == (undefined8 *)0x0) || (lStack_1b0 = lStack_220, lStack_210 == 0))
            goto LAB_101b43f00;
            DataMemoryBarrier(2,3);
            *(long *)(lStack_210 + 0x10U) = lStack_220;
            *(undefined1 *)((lStack_210 + 0x10U >> 9 & 0x7fffff) + lVar1) = 1;
            if ((plStack_258 == (long *)0x0) || (lVar9 = plStack_258[9], lStack_210 == 0))
            goto LAB_101b43f00;
            uStack_188 = *(undefined8 *)(lStack_210 + 0x10);
            plStack_1a0 = (long *)0x0;
            uStack_194 = 0;
            lStack_190 = lVar9;
            if (lVar9 == 0) goto LAB_101b43f00;
            uVar6 = 0xee;
            if (((lVar9 == 0) || (lVar9 == 0)) ||
               ((*(int *)(lVar9 + 0x1c) = *(int *)(lVar9 + 0x1c) + 1, lVar9 == 0 ||
                ((plStack_1a0 = *(long **)(lVar9 + 0x10), lVar9 == 0 ||
                 (uStack_194 = *(uint *)(lVar9 + 0x18), plStack_1a0 == (long *)0x0))))))
            goto LAB_101b43f04;
            if (uStack_194 < *(uint *)(plStack_1a0 + 3)) {
              if (lVar9 != 0) {
                *(uint *)(lVar9 + 0x18) = uStack_194 + 1;
                if (plStack_1a0 != (long *)0x0) {
                  (**(code **)(*plStack_1a0 + 0x110))(plStack_1a0,(long)(int)uStack_194,uStack_188);
                  goto LAB_101b43c5c;
                }
              }
              goto LAB_101b43f00;
            }
            func_0x00010036cdbc(lVar9,uStack_188);
LAB_101b43c5c:
            if ((((lStack_210 == 0) || (lStack_178 = *(long *)(lStack_210 + 0x10), lStack_178 == 0))
                || (lStack_178 == 0)) ||
               ((uStack_180 = *(undefined8 *)(lStack_178 + 0x50), plStack_258 == (long *)0x0 ||
                ((**(code **)(*plStack_258 + 0xb0))(plStack_258,uStack_180), lVar9 = lStack_210,
                plStack_258 == (long *)0x0)))) goto LAB_101b43f00;
            plVar10 = (long *)plStack_258[2];
            if (lStack_210 == 0) {
LAB_101b43f20:
              uVar6 = 0x69;
              goto LAB_101b43f04;
            }
            lVar7 = func_0x000100331820(uRam00000001038d3b88,0x80);
            DataMemoryBarrier(2,3);
            *(long *)(lVar7 + 0x20U) = lVar9;
            *(undefined1 *)((lVar7 + 0x20U >> 9 & 0x7fffff) + lVar1) = 1;
            lVar9 = lRam00000001038f5518;
            *(undefined8 *)(lVar7 + 0x28) = uRam00000001038f5520;
            *(long *)(lVar7 + 0x40) = lVar9;
            *(undefined8 *)(lVar7 + 0x18) = *(undefined8 *)(lVar9 + 0x30);
            plVar2 = plRam00000001038f5528;
            *(undefined8 *)(lVar7 + 0x10) = *(undefined8 *)(lVar9 + 0x28);
            lStack_170 = *plVar2;
            lStack_158 = lStack_170;
            plStack_168 = plVar10;
            lStack_160 = lVar7;
            if (lStack_170 == 0) {
              lVar9 = *plRam00000001038f5530;
              if (lVar9 == 0) goto LAB_101b43f20;
              lStack_158 = func_0x000100331820(uRam00000001038d60e0,0x80);
              DataMemoryBarrier(2,3);
              *(long *)(lStack_158 + 0x20U) = lVar9;
              *(undefined1 *)((lStack_158 + 0x20U >> 9 & 0x7fffff) + lVar1) = 1;
              lVar9 = lRam00000001038f5538;
              *(undefined8 *)(lStack_158 + 0x28) = uRam00000001038f5540;
              *(long *)(lStack_158 + 0x40) = lVar9;
              *(undefined8 *)(lStack_158 + 0x18) = *(undefined8 *)(lVar9 + 0x30);
              *(undefined8 *)(lStack_158 + 0x10) = *(undefined8 *)(lVar9 + 0x28);
              DataMemoryBarrier(2,3);
              *plRam00000001038f5528 = lStack_158;
              lStack_150 = lStack_158;
            }
            plStack_168 = plVar10;
            lStack_160 = lVar7;
            if (plVar10 == (long *)0x0) goto LAB_101b43f00;
            cVar5 = (**(code **)(*plVar10 + -0x10))(plVar10,lVar7,lStack_158);
            if (cVar5 == '\0') {
              func_0x00010033180c(uRam00000001038f5398);
              if (lStack_210 != 0) {
                uVar6 = *(undefined8 *)(lStack_210 + 0x10);
                lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
                plVar10 = (long *)func_0x000100331794(uRam00000001038c4c00,1);
                plStack_148 = plVar10;
                if (plVar10 != (long *)0x0) {
                  uVar8 = (**(code **)(*plVar10 + 0x110))(plVar10,0,uRam00000001038f53a0);
                  puStack_128 = &uStack_140;
                  uStack_140 = 0;
                  uStack_138 = 0;
                  plStack_130 = (long *)0x0;
                  uStack_119 = 0xb;
                  lStack_118 = lVar9;
                  plStack_110 = plVar10;
                  lStack_100 = lVar9;
                  if (((lVar9 != 0) && (lVar9 != 0)) &&
                     ((lStack_f0 = *(long *)(lVar9 + 0x2e0), lStack_f0 != 0 && (lStack_f0 != 0)))) {
                    uStack_108 = *(undefined8 *)(lStack_f0 + 0x68);
                    uStack_d9 = 0xb;
                    uStack_f8 = uStack_108;
                    puStack_e8 = puStack_128;
                    uStack_d8 = uStack_108;
                    plStack_d0 = plVar10;
                    /* WARNING: Ignoring partial resolution of indirect */
                    if (((puStack_128 != (undefined8 *)0x0) &&
                        (uStack_140._0_1_ = 0xb, puStack_128 != (undefined8 *)0x0)) &&
                       (uStack_138 = uStack_108, puStack_128 != (undefined8 *)0x0)) {
                      DataMemoryBarrier(2,3);
                      *(undefined1 *)(((ulong)&plStack_130 >> 9 & 0x7fffff) + lVar1) = 1;
                      uStack_270 = uStack_140;
                      uStack_268 = uStack_108;
                      plStack_260 = plVar10;
                      plStack_130 = plVar10;
                      SDV_StardewValley_Network_LoopbackServer_sendMessage_06004ba6
                                (uVar8,uVar6,&uStack_270);
                      goto LAB_101b43ef0;
                    }
                  }
                }
              }
              goto LAB_101b43f00;
            }
LAB_101b43ef0:
            if (lRam0000000103976fb8 != 0) {
              func_0x00010119b8f8();
            }
          }
          uStack_1f0 = 0;
          puStack_c8 = &uStack_230;
          uVar6 = _UNK_103654df0;
          uVar8 = uStack_1e8;
          if (puStack_c8 != (undefined8 *)0x0) {
            uStack_1f0 = 0;
            lStack_b8 = plStack_258[8];
            iStack_bc = 0;
            uVar6 = _UNK_103654d68;
            if (((lStack_b8 != 0) && (uVar6 = _UNK_103654d70, lStack_b8 != 0)) &&
               (uVar6 = _UNK_103654d78, lStack_b8 != 0)) {
              *(int *)(lStack_b8 + 0x1c) = *(int *)(lStack_b8 + 0x1c) + 1;
              iStack_bc = *(int *)(lStack_b8 + 0x18);
              *(undefined4 *)(lStack_b8 + 0x18) = 0;
              if (0 < iStack_bc) {
                func_0x000100331c80(*(undefined8 *)(lStack_b8 + 0x10),0,iStack_bc);
              }
              uVar6 = _UNK_103654d88;
              uVar8 = uStack_1e8;
              if (plStack_258[10] != 0) {
                func_0x00010036ce5c(&uStack_b0);
                uStack_228 = uStack_a8;
                uStack_230 = uStack_b0;
                lStack_220 = lStack_a0;
                while (cVar5 = func_0x00010036ce70(&uStack_230), cVar5 != '\0') {
                  puStack_90 = &uStack_230;
                  if (((&uStack_230 == (undefined8 *)0x0) ||
                      (lStack_208 = lStack_220, lStack_98 = lStack_208, plStack_258 == (long *)0x0))
                     || (plStack_258[0xb] == 0)) {
LAB_101b441b4:
                    func_0x0001003316f4(0xee,_UNK_103654dc8);
LAB_101b441c4:
                    /* WARNING: Does not return */
                    pcVar4 = (code *)SoftwareBreakpoint(1,0x101b441c8);
                    (*pcVar4)();
                  }
                  cVar5 = func_0x00010036cee8(plStack_258[0xb],lStack_220);
                  if (cVar5 == '\0') {
                    lStack_80 = lStack_208;
                    if (((((lStack_208 == 0) || (lStack_208 == 0)) ||
                         (uStack_88 = *(undefined8 *)(lStack_208 + 0x50), plStack_258 == (long *)0x0
                         )) || (((**(code **)(*plStack_258 + 0xa8))(plStack_258,uStack_88),
                                plStack_258 == (long *)0x0 || (plStack_258[9] == 0)))) ||
                       ((func_0x00010036cf10(plStack_258[9],lStack_208), plStack_258 == (long *)0x0
                        || (plStack_258[8] == 0)))) goto LAB_101b441b4;
                    func_0x00010036cf10(plStack_258[8],lStack_208);
                  }
                  else {
                    if (((plStack_258 == (long *)0x0) || (plStack_258[0xb] == 0)) ||
                       (uStack_200 = func_0x00010036cefc(plStack_258[0xb],lStack_208),
                       plStack_258 == (long *)0x0)) goto LAB_101b441b4;
                    (**(code **)(*plStack_258 + 0x88))(plStack_258,uStack_200);
                  }
                  if (lRam0000000103976fb8 != 0) {
                    func_0x00010119b8f8();
                  }
                }
                uStack_1e8 = 0;
                uVar3 = uStack_1e8;
                puStack_78 = &uStack_230;
                uVar6 = _UNK_103654dc0;
                uVar8 = uVar3;
                if (puStack_78 != (undefined8 *)0x0) {
                  uStack_1e8 = 0;
                  lStack_68 = plStack_258[10];
                  uVar6 = _UNK_103654d90;
                  uVar8 = uStack_1e8;
                  if (((lStack_68 != 0) && (uVar6 = _UNK_103654d98, lStack_68 != 0)) &&
                     (uVar6 = _UNK_103654da0, uVar8 = uVar3, lStack_68 != 0)) {
                    *(int *)(lStack_68 + 0x1c) = *(int *)(lStack_68 + 0x1c) + 1;
                    iStack_6c = *(int *)(lStack_68 + 0x18);
                    *(undefined4 *)(lStack_68 + 0x18) = 0;
                    if (iStack_6c < 1) {
                      return;
                    }
                    func_0x000100331c80(*(undefined8 *)(lStack_68 + 0x10),0,iStack_6c);
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
  uStack_1e8 = uVar8;
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101b44000);
  (*pcVar4)();
}

