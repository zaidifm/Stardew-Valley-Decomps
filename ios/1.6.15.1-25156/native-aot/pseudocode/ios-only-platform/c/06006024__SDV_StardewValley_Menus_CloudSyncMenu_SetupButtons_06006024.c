/* 0x06006024 StardewValley.Menus.CloudSyncMenu.SetupButtons @ 0x101e60368 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CloudSyncMenu_SetupButtons_06006024
               (undefined1 param_1 [16],float param_2,long *param_3)

{
  int iVar1;
  undefined8 uVar2;
  undefined8 uVar3;
  code *pcVar4;
  char cVar5;
  long *plVar6;
  undefined8 uVar7;
  long lVar8;
  undefined8 uVar9;
  long lVar10;
  undefined4 uVar11;
  long lVar12;
  float fVar13;
  undefined8 uStack_60;
  undefined8 uStack_58;
  
  cVar5 = cRam0000000103910e33;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar5 == '\0') {
    func_0x00010119b908(&UNK_10331a040);
    cRam0000000103910e33 = '\x01';
  }
  fVar13 = (float)StardewValley_StardewValley_Utility_getTopLeftPositionForCenteringOnScreen_06004276
                            (800,0x168,0,0);
  lVar10 = param_3[0xd];
  uVar9 = _UNK_1036aa948;
  if (lVar10 != 0) {
    iVar1 = *(int *)(lVar10 + 0x18);
    *(undefined4 *)(lVar10 + 0x18) = 0;
    *(int *)(lVar10 + 0x1c) = *(int *)(lVar10 + 0x1c) + 1;
    if (0 < iVar1) {
      func_0x000100331c80(*(undefined8 *)(lVar10 + 0x10),0);
    }
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    plVar6 = (long *)*plRam00000001038d5338;
    uVar9 = _UNK_1036aa950;
    if (plVar6 != (long *)0x0) {
      uVar7 = (**(code **)(*plVar6 + 0x100))(plVar6,uRam0000000103901918);
      lVar12 = param_3[0xd];
      uStack_60 = 0;
      uStack_58 = 0;
      func_0x00010034ede4(&uStack_60,(int)fVar13 + 0x40,(int)param_2 + 0xde,0x2a0,0x53);
      uVar3 = uStack_58;
      uVar2 = uStack_60;
      uVar9 = uRam00000001038d6530;
      lVar8 = func_0x000100331820(uRam00000001038f6cb0,0x78);
      *(undefined8 *)(lVar8 + 0x38) = uVar2;
      *(undefined8 *)(lVar8 + 0x40) = uVar3;
      *(undefined4 *)(lVar8 + 0x48) = 0x3f800000;
      *(undefined8 *)(lVar8 + 0x54) = 0xfffffe0cfffffe0c;
      *(undefined1 *)(lVar8 + 0x4c) = 1;
      *(undefined8 *)(lVar8 + 0x5c) = 0xffffffffffffffff;
      *(undefined8 *)(lVar8 + 100) = 0xffffffffffffffff;
      lVar10 = lRam00000001038c4be0;
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lVar8 + 0x10) = uVar9;
      *(undefined1 *)(((ulong)(lVar8 + 0x10) >> 9 & 0x7fffff) + lVar10) = 1;
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lVar8 + 0x18) = uVar7;
      *(undefined1 *)(((ulong)(lVar8 + 0x18) >> 9 & 0x7fffff) + lVar10) = 1;
      *(undefined4 *)(lVar8 + 0x54) = 0;
      *(undefined4 *)(lVar8 + 0x68) = 0;
      uVar9 = _UNK_1036aa958;
      if (lVar12 != 0) {
        plVar6 = *(long **)(lVar12 + 0x10);
        *(int *)(lVar12 + 0x1c) = *(int *)(lVar12 + 0x1c) + 1;
        uVar9 = _UNK_1036aa960;
        if (plVar6 != (long *)0x0) {
          if (*(uint *)(lVar12 + 0x18) < *(uint *)(plVar6 + 3)) {
            *(uint *)(lVar12 + 0x18) = *(uint *)(lVar12 + 0x18) + 1;
            (**(code **)(*plVar6 + 0x110))();
          }
          else {
            func_0x000100377424(lVar12,lVar8);
          }
          lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec();
          uVar9 = _UNK_1036aa968;
          if (lVar8 != 0) {
            cVar5 = SDV_StardewValley_Options_get_SnappyMenus_06003eee();
            if (cVar5 != '\0') {
              if (param_3[9] == 0) {
                uVar11 = 0;
              }
              else {
                uVar11 = *(undefined4 *)(param_3[9] + 0x54);
              }
              (**(code **)(*param_3 + 0x188))(param_3);
              lVar8 = StardewValley_StardewValley_Menus_IClickableMenu_getComponentWithID_06006181
                                (param_3,uVar11);
              DataMemoryBarrier(2,3);
              param_3[9] = lVar8;
              *(undefined1 *)(((ulong)(param_3 + 9) >> 9 & 0x7fffff) + lVar10) = 1;
              (**(code **)(*param_3 + 0x168))(param_3);
            }
            return;
          }
        }
      }
    }
  }
  func_0x0001003316f4(0xee,uVar9);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101e6061c);
  (*pcVar4)();
}

