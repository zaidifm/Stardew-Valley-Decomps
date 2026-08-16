/* 0x06005e26 StardewValley.Menus.MobileFarmChooser.releaseLeftClick @ 0x101e17bf4 */

/* WARNING: Removing unreachable block (ram,0x000101e18518) */
/* WARNING: Removing unreachable block (ram,0x000101e184b0) */
/* WARNING: Removing unreachable block (ram,0x000101e184fc) */
/* WARNING: Removing unreachable block (ram,0x000101e18478) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* WARNING: Restarted to delay deadcode elimination for space: stack */

void SDV_StardewValley_Menus_MobileFarmChooser_releaseLeftClick_06005e26
               (long param_1,undefined4 param_2,uint param_3)

{
  undefined4 *puVar1;
  ulong *puVar2;
  code *pcVar3;
  char cVar4;
  ulong uVar5;
  undefined8 uVar6;
  undefined8 uVar7;
  long lVar8;
  long *plVar9;
  undefined8 uStack_110;
  undefined8 uStack_108;
  ulong *puStack_100;
  ulong *puStack_f8;
  undefined8 uStack_f0;
  undefined8 uStack_e8;
  long *plStack_e0;
  long *plStack_d0;
  undefined8 uStack_c8;
  undefined8 uStack_c0;
  undefined8 uStack_b8;
  undefined8 *puStack_b0;
  undefined8 uStack_a8;
  undefined8 uStack_a0;
  ulong *puStack_98;
  ulong *puStack_90;
  undefined8 *puStack_88;
  undefined8 *puStack_80;
  undefined8 uStack_78;
  undefined8 uStack_70;
  long *plStack_68;
  long *plStack_60;
  undefined8 *puStack_58;
  undefined8 uStack_50;
  ulong *puStack_48;
  
  cVar4 = cRam0000000103910c35;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103317410);
    cRam0000000103910c35 = '\x01';
  }
  uStack_110 = 0;
  uStack_108 = 0;
  puStack_100 = (ulong *)0x0;
  puStack_f8 = (ulong *)0x0;
  uStack_e8 = 0;
  plStack_e0 = (long *)0x0;
  uStack_f0 = 0;
  plStack_d0 = (long *)0x0;
  if (*(char *)(param_1 + 0x1c0) == '\0') {
    uVar7 = _UNK_1036a1db0;
    uVar6 = uStack_c0;
    if (*(long *)(param_1 + 0xf8) != 0) {
      *(undefined1 *)(*(long *)(param_1 + 0xf8) + 0xad) = 1;
      uVar7 = _UNK_1036a1dc0;
      if ((((*(long *)(param_1 + 0xf8) != 0) && (uVar7 = _UNK_1036a1dc8, param_1 != 0)) &&
          (uVar7 = _UNK_1036a1dd0, (undefined4 *)(param_1 + 0x1dc) != (undefined4 *)0x0)) &&
         (puVar1 = (undefined4 *)(*(long *)(param_1 + 0xf8) + 0x38), uVar7 = _UNK_1036a1dd8,
         puVar1 != (undefined4 *)0x0)) {
        *puVar1 = *(undefined4 *)(param_1 + 0x1dc);
        lVar8 = *(long *)(param_1 + 0xf8);
        uVar7 = _UNK_1036a1de8;
        if (((lVar8 != 0) && (uVar7 = _UNK_1036a1df0, param_1 != 0)) &&
           ((uVar7 = _UNK_1036a1df8, param_1 != -0x1dc && (uVar7 = _UNK_1036a1e00, lVar8 != -0x38)))
           ) {
          *(undefined4 *)(lVar8 + 0x3c) = *(undefined4 *)(param_1 + 0x1e0);
          uVar7 = _UNK_1036a1e10;
          if (*(long *)(param_1 + 0x100) != 0) {
            *(undefined1 *)(*(long *)(param_1 + 0x100) + 0xad) = 1;
            uVar7 = _UNK_1036a1e20;
            if (((*(long *)(param_1 + 0x100) != 0) && (uVar7 = _UNK_1036a1e28, param_1 != 0)) &&
               ((uVar7 = _UNK_1036a1e30, (undefined4 *)(param_1 + 0x1ec) != (undefined4 *)0x0 &&
                (puVar1 = (undefined4 *)(*(long *)(param_1 + 0x100) + 0x38), uVar7 = _UNK_1036a1e38,
                puVar1 != (undefined4 *)0x0)))) {
              *puVar1 = *(undefined4 *)(param_1 + 0x1ec);
              lVar8 = *(long *)(param_1 + 0x100);
              uVar7 = _UNK_1036a1e48;
              if ((((lVar8 != 0) && (uVar7 = _UNK_1036a1e50, param_1 != 0)) &&
                  (uVar7 = _UNK_1036a1e58, param_1 != -0x1ec)) &&
                 (uVar7 = _UNK_1036a1e60, lVar8 != -0x38)) {
                *(undefined4 *)(lVar8 + 0x3c) = *(undefined4 *)(param_1 + 0x1f0);
                return;
              }
            }
          }
        }
      }
    }
  }
  else {
    cVar4 = (**(code **)(**(long **)(param_1 + 0x88) + 0x90))
                      (*(long **)(param_1 + 0x88),param_2,param_3);
    if ((cVar4 != '\0') &&
       (cVar4 = SDV_StardewValley_Menus_MobileFarmChooser_canLeaveMenu_06005e29(param_1),
       cVar4 != '\0')) {
      func_0x000100377d5c(param_1,*(undefined8 *)(*(long *)(param_1 + 0x88) + 0x10));
    }
    cVar4 = (**(code **)(**(long **)(param_1 + 0x90) + 0x90))
                      (*(long **)(param_1 + 0x90),param_2,param_3);
    if (cVar4 != '\0') {
      func_0x000100377d5c(param_1,*(undefined8 *)(*(long *)(param_1 + 0x90) + 0x10));
    }
    uVar7 = _UNK_1036a1e90;
    uVar6 = uStack_c0;
    if (*(long *)(param_1 + 0x88) != 0) {
      *(undefined1 *)(*(long *)(param_1 + 0x88) + 0xad) = 1;
      uVar7 = _UNK_1036a1ea0;
      if (((*(long *)(param_1 + 0x88) != 0) && (uVar7 = _UNK_1036a1ea8, param_1 != 0)) &&
         ((uVar7 = _UNK_1036a1eb0, (undefined4 *)(param_1 + 400) != (undefined4 *)0x0 &&
          (puVar1 = (undefined4 *)(*(long *)(param_1 + 0x88) + 0x38), uVar7 = _UNK_1036a1eb8,
          puVar1 != (undefined4 *)0x0)))) {
        *puVar1 = *(undefined4 *)(param_1 + 400);
        lVar8 = *(long *)(param_1 + 0x88);
        uVar7 = _UNK_1036a1ec8;
        if ((((lVar8 != 0) && (uVar7 = _UNK_1036a1ed0, param_1 != 0)) &&
            (uVar7 = _UNK_1036a1ed8, param_1 != -400)) && (uVar7 = _UNK_1036a1ee0, lVar8 != -0x38))
        {
          *(undefined4 *)(lVar8 + 0x3c) = *(undefined4 *)(param_1 + 0x194);
          uVar7 = _UNK_1036a1ef0;
          if (*(long *)(param_1 + 0x90) != 0) {
            *(undefined1 *)(*(long *)(param_1 + 0x90) + 0xad) = 1;
            uVar7 = _UNK_1036a1f00;
            if (((*(long *)(param_1 + 0x90) != 0) && (uVar7 = _UNK_1036a1f08, param_1 != 0)) &&
               ((uVar7 = _UNK_1036a1f10, (undefined4 *)(param_1 + 0x1a0) != (undefined4 *)0x0 &&
                (puVar1 = (undefined4 *)(*(long *)(param_1 + 0x90) + 0x38), uVar7 = _UNK_1036a1f18,
                puVar1 != (undefined4 *)0x0)))) {
              *puVar1 = *(undefined4 *)(param_1 + 0x1a0);
              lVar8 = *(long *)(param_1 + 0x90);
              uVar7 = _UNK_1036a1f28;
              if ((((lVar8 != 0) && (uVar7 = _UNK_1036a1f30, param_1 != 0)) &&
                  (uVar7 = _UNK_1036a1f38, param_1 != -0x1a0)) &&
                 (uVar7 = _UNK_1036a1f40, lVar8 != -0x38)) {
                *(undefined4 *)(lVar8 + 0x3c) = *(undefined4 *)(param_1 + 0x1a4);
                if (*(char *)(param_1 + 0x1fd) == '\0') {
                  return;
                }
                uVar7 = _UNK_1036a1f58;
                if (*(long *)(param_1 + 0x118) != 0) {
                  func_0x00010037744c(&uStack_110);
                  while (cVar4 = func_0x000100377460(&uStack_110), puVar2 = puStack_100,
                        cVar4 != '\0') {
                    if (puStack_100 == (ulong *)0x0) {
                      uVar6 = 0xee;
                      plVar9 = (long *)(ulong)param_3;
LAB_101e17f48:
                      func_0x0001003316f4(plVar9,uVar6,_UNK_1036a1f60);
                      goto LAB_101e1843c;
                    }
                    plVar9 = (long *)*puStack_100;
                    if (lRam00000001039005b0 != *(long *)(*(long *)(*plVar9 + 0x10) + 0x10)) {
                      uVar6 = 0xd3;
                      goto LAB_101e17f48;
                    }
                    uVar5 = (*(code *)plVar9[0x12])(puStack_100,param_2,param_3);
                    if ((uVar5 & 0xff) != 0) {
                      SDV_StardewValley_Menus_MobileFarmChooser_selectionClick_06005e22
                                (param_1,uVar5,puVar2[2],1);
                    }
                    if (lRam0000000103976fb8 != 0) {
                      func_0x00010119b8f8();
                    }
                  }
                  uStack_c8 = 0;
                  puStack_b0 = &uStack_110;
                  uVar7 = _UNK_1036a1fa0;
                  uVar6 = uStack_c0;
                  if ((puStack_b0 != (undefined8 *)0x0) &&
                     (uStack_c8 = 0, uVar7 = _UNK_1036a1f68, *(long *)(param_1 + 0x110) != 0)) {
                    func_0x00010037744c(&uStack_a8);
                    uStack_108 = uStack_a0;
                    uStack_110 = uStack_a8;
                    puStack_100 = puStack_98;
                    while (cVar4 = func_0x000100377460(&uStack_110), cVar4 != '\0') {
                      puStack_88 = &uStack_110;
                      if (&uStack_110 == (undefined8 *)0x0) {
LAB_101e18348:
                        uVar6 = 0xee;
LAB_101e1834c:
                        func_0x0001003316f4(uVar6,_UNK_1036a1f90);
                        goto LAB_101e1843c;
                      }
                      puStack_90 = puStack_100;
                      puStack_48 = puStack_90;
                      if ((puStack_100 != (ulong *)0x0) &&
                         (lRam00000001039005b0 !=
                          *(long *)(*(long *)(*(long *)*puStack_100 + 0x10) + 0x10))) {
                        uVar6 = 0xd3;
                        goto LAB_101e1834c;
                      }
                      puStack_f8 = puStack_90;
                      if (puStack_100 == (ulong *)0x0) goto LAB_101e18348;
                      uVar5 = (**(code **)(*puStack_100 + 0x90))(puStack_100,param_2,param_3);
                      if ((uVar5 & 0xff) != 0) {
                        if (puStack_f8 == (ulong *)0x0) goto LAB_101e18348;
                        SDV_StardewValley_Menus_MobileFarmChooser_selectionClick_06005e22
                                  (uVar5,puStack_f8[2],0xffffffff);
                      }
                      if (lRam0000000103976fb8 != 0) {
                        func_0x00010119b8f8();
                      }
                    }
                    uStack_c0 = 0;
                    uVar6 = uStack_c0;
                    puStack_80 = &uStack_110;
                    uVar7 = _UNK_1036a1f88;
                    if ((puStack_80 != (undefined8 *)0x0) &&
                       (uStack_c0 = 0, uVar7 = _UNK_1036a1f70, *(long *)(param_1 + 0x140) != 0)) {
                      func_0x000100377d98(&uStack_78);
                      uStack_e8 = uStack_70;
                      uStack_f0 = uStack_78;
                      plStack_e0 = plStack_68;
                      while (cVar4 = func_0x000100377dac(&uStack_f0), cVar4 != '\0') {
                        puStack_58 = &uStack_f0;
                        if ((&uStack_f0 == (undefined8 *)0x0) ||
                           (plStack_d0 = plStack_e0, plStack_60 = plStack_d0,
                           plStack_e0 == (long *)0x0)) {
LAB_101e1842c:
                          func_0x0001003316f4(0xee,_UNK_1036a1f80);
LAB_101e1843c:
                    /* WARNING: Does not return */
                          pcVar3 = (code *)SoftwareBreakpoint(1,0x101e18440);
                          (*pcVar3)();
                        }
                        cVar4 = (**(code **)(*plStack_e0 + 0x90))(plStack_e0,param_2,param_3);
                        if (cVar4 != '\0') {
                          if (plStack_d0 == (long *)0x0) goto LAB_101e1842c;
                          func_0x000100377d5c(param_1,plStack_d0[2]);
                        }
                        if (lRam0000000103976fb8 != 0) {
                          func_0x00010119b8f8();
                        }
                      }
                      uStack_b8 = 0;
                      if (&stack0x00000000 != (undefined1 *)0xf0) {
                        return;
                      }
                      uStack_50 = 0;
                      uVar7 = _UNK_1036a1f78;
                      uVar6 = uStack_c0;
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
  uStack_c0 = uVar6;
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101e18258);
  (*pcVar3)();
}

