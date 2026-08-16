/* 0x06005da7 StardewValley.Menus.CoopGameMenu.onLobbyUpdate @ 0x100121a50 */

void SDV_StardewValley_Menus_CoopGameMenu_onLobbyUpdate_06005da7(long *param_1,undefined8 param_2)

{
  uint uVar1;
  char cVar2;
  char cVar3;
  undefined1 uVar4;
  long *plVar5;
  undefined8 uVar6;
  long lVar7;
  undefined8 uVar8;
  undefined8 *puVar9;
  undefined8 uStack_c0;
  undefined8 uStack_b8;
  undefined8 *puStack_b0;
  long lStack_a8;
  long *plStack_40;
  long lStack_38;
  undefined8 uStack_30;
  undefined8 uStack_28;
  undefined8 uStack_20;
  undefined8 uStack_18;
  undefined8 uStack_10;
  
  if (*plRam00000001037fff88 != 0) {
    func_0x0001003316e0();
  }
  uStack_c0 = 0;
  uStack_b8 = 0;
  puStack_b0 = (undefined8 *)0x0;
  func_0x00010033180c(uRam00000001038051e0);
  uStack_10 = uRam00000001038051e8;
  plVar5 = (long *)func_0x000100351b70();
  plVar5 = (long *)(**(code **)(*plVar5 + -0x38))(plVar5);
  uVar6 = (**(code **)(*plVar5 + -8))(plVar5,param_2);
  func_0x0001003323d8(uStack_10,uVar6);
  func_0x00010033180c();
  uStack_18 = uRam0000000103805200;
  plVar5 = (long *)func_0x000100351b70();
  plVar5 = (long *)(**(code **)(*plVar5 + -0x38))(plVar5);
  uVar6 = (**(code **)(*plVar5 + -0x58))(plVar5,param_2,uRam0000000103805208);
  func_0x0001003323d8(uStack_18,uVar6);
  func_0x00010033180c();
  uStack_20 = uRam0000000103805218;
  plVar5 = (long *)func_0x000100351b70();
  plVar5 = (long *)(**(code **)(*plVar5 + -0x38))(plVar5);
  uVar6 = (**(code **)(*plVar5 + -0x58))(plVar5,param_2,uRam0000000103805220);
  func_0x0001003323d8(uStack_20,uVar6);
  func_0x00010033180c();
  uStack_28 = uRam0000000103805228;
  plVar5 = (long *)func_0x000100351b70();
  plVar5 = (long *)(**(code **)(*plVar5 + -0x38))(plVar5);
  uVar6 = (**(code **)(*plVar5 + -0x58))(plVar5,param_2,uRam0000000103805230);
  func_0x0001003323d8(uStack_28,uVar6);
  func_0x00010033180c();
  uStack_30 = uRam0000000103805238;
  plVar5 = (long *)func_0x000100351b70();
  plVar5 = (long *)(**(code **)(*plVar5 + -0x38))(plVar5);
  uVar6 = (**(code **)(*plVar5 + -0x58))(plVar5,param_2,uRam0000000103805240);
  func_0x0001003323d8(uStack_30,uVar6);
  func_0x00010033180c();
  lStack_38 = uRam0000000103805248;
  plVar5 = (long *)func_0x000100351b70();
  plVar5 = (long *)(**(code **)(*plVar5 + -0x38))(plVar5);
  uVar6 = (**(code **)(*plVar5 + -0x58))(plVar5,param_2,uRam0000000103805250);
  func_0x0001003323d8(lStack_38,uVar6);
  func_0x00010033180c();
  plStack_40 = (long *)uRam0000000103805258;
  plVar5 = (long *)func_0x000100351b70();
  plVar5 = (long *)(**(code **)(*plVar5 + -0x38))(plVar5);
  uVar6 = (**(code **)(*plVar5 + -0x58))(plVar5,param_2,uRam0000000103805260);
  func_0x0001003323d8(plStack_40,uVar6);
  func_0x00010033180c();
  lVar7 = (**(code **)(*param_1 + 0x238))(param_1,param_2);
  cVar2 = (**(code **)(*param_1 + 0x230))(param_1,lVar7);
  if (cVar2 != '\0') {
    plVar5 = (long *)func_0x000100351b70();
    plVar5 = (long *)(**(code **)(*plVar5 + -0x38))(plVar5);
    uVar6 = (**(code **)(*plVar5 + -0x38))(plVar5);
    plVar5 = (long *)func_0x000100351b70();
    plVar5 = (long *)(**(code **)(*plVar5 + -0x38))(plVar5);
    uVar8 = (**(code **)(*plVar5 + -0x58))(plVar5,param_2,uRam0000000103805250);
    plVar5 = (long *)func_0x000100351b70();
    plVar5 = (long *)(**(code **)(*plVar5 + -0x38))(plVar5);
    (**(code **)(*plVar5 + -0x58))(plVar5,param_2,uRam0000000103805260);
    cVar2 = func_0x000100369cd4();
    cVar3 = func_0x000100345aa0(uVar8,uRam0000000103800060);
    if ((cVar3 == '\0') || (cVar2 != '\0')) {
      uVar8 = func_0x000100352110(uVar8,0x2c,0);
      cVar3 = func_0x0001003590f0(uVar8,uVar6);
      if ((cVar3 != '\0') || (cVar2 != '\0')) {
        uVar4 = func_0x0001003590f0(uVar8,uVar6);
        *(undefined1 *)(lVar7 + 0x3c) = uVar4;
        func_0x00010037af0c(&uStack_c0);
        do {
          cVar2 = func_0x00010037af20(&uStack_c0);
          if (cVar2 == '\0') {
            lStack_a8 = 0;
            func_0x0001001220ec();
            if (lStack_a8 != 0) {
              func_0x000100331ba4();
            }
            lStack_38 = param_1[0x1a];
            plStack_40 = (long *)func_0x000100331820(uRam0000000103805290,0x38);
            func_0x000100384d04(plStack_40,param_1,lVar7);
            *(int *)(lStack_38 + 0x1c) = *(int *)(lStack_38 + 0x1c) + 1;
            plVar5 = *(long **)(lStack_38 + 0x10);
            uVar1 = *(uint *)(lStack_38 + 0x18);
            if (uVar1 < *(uint *)(plVar5 + 3)) {
              *(uint *)(lStack_38 + 0x18) = uVar1 + 1;
              (**(code **)(*plVar5 + 0x110))(plVar5,(long)(int)uVar1,plStack_40);
              return;
            }
            func_0x0001003772e4(lStack_38,plStack_40);
            return;
          }
          if (*plRam00000001037fff88 != 0) {
            func_0x0001003316e0();
          }
          puVar9 = puStack_b0;
          if ((puStack_b0 != (undefined8 *)0x0) &&
             (*(long *)(*(long *)(*(long *)*puStack_b0 + 0x10) + 0x18) != lRam0000000103805280)) {
            puVar9 = (undefined8 *)0x0;
          }
        } while ((puVar9 == (undefined8 *)0x0) ||
                (cVar2 = func_0x000100384cf0(puVar9,param_2), cVar2 == '\0'));
        plStack_40 = puVar9 + 6;
        DataMemoryBarrier(2,3);
        *plStack_40 = lVar7;
        *(undefined1 *)(((ulong)plStack_40 >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
        lStack_a8 = 0;
        func_0x0001001220ec();
        if (lStack_a8 != 0) {
          func_0x000100331ba4();
        }
      }
    }
  }
  return;
}

