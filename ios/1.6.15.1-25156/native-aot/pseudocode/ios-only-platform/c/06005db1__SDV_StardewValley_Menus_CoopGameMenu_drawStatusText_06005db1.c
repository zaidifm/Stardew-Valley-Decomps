/* 0x06005db1 StardewValley.Menus.CoopGameMenu.drawStatusText @ 0x101df7f2c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_drawStatusText_06005db1(long *param_1,undefined8 param_2)

{
  char cVar1;
  code *pcVar2;
  uint uVar3;
  int iVar4;
  int iVar5;
  long lVar6;
  long *plVar7;
  undefined8 uVar8;
  undefined8 uVar9;
  ulong uVar10;
  undefined8 in_x6;
  int iVar11;
  undefined1 auVar12 [16];
  undefined8 uStack_80;
  undefined8 uStack_78;
  undefined8 uStack_70;
  undefined1 auStack_60 [16];
  
  cVar1 = cRam0000000103910bc0;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033165e0);
    cRam0000000103910bc0 = '\x01';
  }
  uStack_80 = 0;
  uStack_78 = 0;
  uStack_70 = 0;
  auStack_60._0_8_ = 0;
  auStack_60._8_8_ = 0;
  lVar6 = (**(code **)(*param_1 + 0x1d8))(param_1);
  if (lVar6 == 0) {
    if ((char)param_1[0x36] == '\0') {
      plVar7 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
      uVar9 = _UNK_10369cff0;
      if (plVar7 != (long *)0x0) {
        uVar3 = (**(code **)(*plVar7 + -0x30))();
        iVar4 = uVar3 + 1;
        if (0xfffffffe < uVar3) {
          func_0x0001003316f4(0x95,_UNK_10369d050);
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101df825c);
          (*pcVar2)();
        }
        iVar5 = *(int *)((long)param_1 + 0x1b4);
        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        plVar7 = (long *)*plRam00000001038d5338;
        uVar9 = _UNK_10369cff8;
        if (plVar7 != (long *)0x0) {
          uVar8 = (**(code **)(*plVar7 + 0x100))(plVar7,uRam00000001039001d0);
          uVar9 = _UNK_10369d000;
          if (param_1[0x35] != 0) {
            func_0x000100331af0(param_1[0x35]);
            uVar9 = _UNK_10369d008;
            if (param_1[0x35] != 0) {
              iVar5 = iVar5 / 5;
              iVar11 = 0;
              if (iVar4 != 0) {
                iVar11 = iVar5 / iVar4;
              }
              iVar5 = iVar5 - iVar11 * iVar4;
              func_0x000100331b2c(param_1[0x35],uVar8);
              iVar11 = iVar5;
              if (0 < iVar5) {
                do {
                  while( true ) {
                    uVar9 = _UNK_10369d010;
                    if (param_1[0x35] == 0) goto LAB_101df8230;
                    func_0x000100331b2c(param_1[0x35],uRam00000001038d4c08);
                    if (lRam0000000103976fb8 != 0) break;
                    iVar11 = iVar11 + -1;
                    if (iVar11 == 0) goto LAB_101df8080;
                  }
                  func_0x00010119b8f8();
                  iVar11 = iVar11 + -1;
                } while (iVar11 != 0);
              }
LAB_101df8080:
              uVar8 = (**(code **)(*(long *)param_1[0x35] + 0x60))();
              if (-1 < iVar4) {
                do {
                  uVar9 = _UNK_10369d020;
                  if (param_1[0x35] == 0) goto LAB_101df8230;
                  func_0x000100331b2c(param_1[0x35],uRam00000001038d4c08);
                  if (lRam0000000103976fb8 != 0) {
                    func_0x00010119b8f8();
                  }
                  iVar5 = iVar5 + 1;
                } while (iVar5 < iVar4);
              }
              uVar9 = (**(code **)(*(long *)param_1[0x35] + 0x60))();
              iVar4 = StardewValley_StardewValley_BellsAndWhistles_SpriteText_getWidthOfString_06005d29
                                (uVar9,999999);
              if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                func_0x0001003319b0(lRam00000001038c4c88);
              }
              lVar6 = *(long *)(*plRam00000001038d5630 + 0x18);
              uVar9 = _UNK_10369d038;
              if (lVar6 != 0) {
                uStack_70 = *(undefined8 *)(lVar6 + 0x1d4);
                uStack_78 = *(undefined8 *)(lVar6 + 0x1cc);
                uStack_80 = *(undefined8 *)(lVar6 + 0x1c4);
                auStack_60 = func_0x000100355dec(&uStack_80);
                iVar5 = func_0x00010035034c(auStack_60);
                if (iVar4 < 0) {
                  iVar4 = iVar4 + 1;
                }
                lVar6 = *(long *)(*plRam00000001038d5630 + 0x18);
                uVar9 = _UNK_10369d048;
                if (lVar6 != 0) {
                  uStack_70 = *(undefined8 *)(lVar6 + 0x1d4);
                  uStack_78 = *(undefined8 *)(lVar6 + 0x1cc);
                  uStack_80 = *(undefined8 *)(lVar6 + 0x1c4);
                  auVar12 = func_0x000100355dec(&uStack_80);
                  auStack_60 = auVar12;
                  uVar10 = func_0x00010035034c(auStack_60);
                  StardewValley_StardewValley_BellsAndWhistles_SpriteText_drawString_06005d44
                            (0x3f800000,0x3f6147ae,param_2,uVar8,iVar5 - (iVar4 >> 1),uVar10 >> 0x20
                             ,999999,0xffffffff,in_x6,0,0xffffffff,uRam00000001038c4f58,0,0);
                  return;
                }
              }
            }
          }
        }
      }
LAB_101df8230:
      func_0x0001003316f4(0xee,uVar9);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101df823c);
      (*pcVar2)();
    }
  }
  else {
    StardewValley_StardewValley_Menus_LoadGameMenu_drawStatusText_060062df(param_1,param_2);
  }
  return;
}

