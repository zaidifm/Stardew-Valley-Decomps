/* 0x06005e7c StardewValley.Menus.TutorialManager.ChangeLocation @ 0x1001232f0 */

void SDV_StardewValley_Menus_TutorialManager_ChangeLocation_06005e7c
               (undefined8 param_1,undefined8 param_2)

{
  long *plVar1;
  char cVar2;
  int iVar3;
  undefined8 uVar4;
  long lVar5;
  long *plVar6;
  undefined8 uVar7;
  undefined8 uVar8;
  undefined8 uStack_f0;
  undefined8 uStack_e8;
  undefined8 uStack_e0;
  undefined8 uStack_d8;
  int aiStack_d0 [2];
  undefined8 uStack_c8;
  undefined8 uStack_c0;
  undefined8 uStack_b8;
  undefined8 uStack_b0;
  int aiStack_a8 [2];
  undefined8 uStack_a0;
  undefined8 uStack_98;
  long *plStack_90;
  undefined8 uStack_88;
  undefined8 uStack_80;
  undefined8 uStack_78;
  undefined8 uStack_70;
  undefined8 uStack_68;
  undefined8 uStack_60;
  int *piStack_58;
  long lStack_50;
  long lStack_40;
  long *plStack_10;
  long *plStack_8;
  
  if (*plRam00000001037fff88 != 0) {
    func_0x0001003316e0();
  }
  uStack_70 = 0;
  uStack_68 = 0;
  uStack_60 = 0;
  uStack_88 = 0;
  uStack_80 = 0;
  uStack_78 = 0;
  uStack_a0 = 0;
  uStack_98 = 0;
  plStack_90 = (long *)0x0;
  uVar4 = func_0x0001003780a4(param_1);
  plStack_8 = (long *)func_0x000100331820(uRam0000000103800bf8,0x30);
  func_0x000100331c58();
  plVar1 = plStack_8;
  plStack_10 = plStack_8;
  func_0x000100384d7c(&uStack_70,0x29,1,plStack_8);
  func_0x000100368b2c(&uStack_70,uRam00000001038053a8);
  func_0x000100368b40(&uStack_70,uVar4);
  func_0x000100368b2c(&uStack_70,uRam00000001038053b0);
  lVar5 = func_0x0001003518a0();
  if (lVar5 == 0) {
    uVar8 = 0;
  }
  else {
    lVar5 = func_0x00010035309c(lVar5);
    uVar8 = *(undefined8 *)(*(long *)(lVar5 + 0x178) + 0x60);
  }
  cVar2 = func_0x000100345aa0(uVar4,uVar8);
  if (cVar2 == '\0') {
    func_0x000100331b2c(plVar1,uRam00000001038053d8);
  }
  else {
    func_0x000100384d7c(&uStack_70,0x29,3,plVar1);
    func_0x000100368b2c(&uStack_70,uRam00000001038053b8);
    uVar8 = func_0x0001003518a0();
    piStack_58 = aiStack_a8;
    uVar8 = func_0x000100354be0(uVar8);
    *(undefined8 *)piStack_58 = uVar8;
    func_0x00010037f624(&uStack_70,(long)aiStack_a8[0]);
    func_0x000100368b2c(&uStack_70,uRam0000000103800c08);
    uVar8 = func_0x0001003518a0();
    piStack_58 = (int *)&uStack_b0;
    uVar8 = func_0x000100354be0(uVar8);
    *(undefined8 *)piStack_58 = uVar8;
    func_0x00010037f624(&uStack_70,(long)uStack_b0._4_4_);
    func_0x000100368b2c(&uStack_70,uRam00000001038053c8);
    plVar6 = (long *)func_0x0001003518a0();
    iVar3 = (**(code **)(*plVar6 + 0x1f0))(plVar6);
    func_0x00010037f624(&uStack_70,(long)iVar3);
    func_0x000100368b2c(&uStack_70,uRam00000001038053d0);
  }
  func_0x000100384d90(param_2);
  func_0x000100384da4(&uStack_88);
  while (cVar2 = func_0x000100384db8(&uStack_88), cVar2 != '\0') {
    if (*plRam00000001037fff88 != 0) {
      func_0x0001003316e0();
    }
    uVar8 = uStack_78;
    func_0x0001003780cc(param_2,uStack_78);
    func_0x00010035340c(&uStack_a0);
    while (cVar2 = func_0x000100353470(&uStack_a0), cVar2 != '\0') {
      if (*plRam00000001037fff88 != 0) {
        func_0x0001003316e0();
      }
      plVar6 = plStack_90;
      cVar2 = func_0x000100345aa0(uVar4,uVar8);
      if (cVar2 == '\0') {
        uStack_f0 = 0;
        uStack_e8 = 0;
        uStack_e0 = 0;
        func_0x000100384d7c(&uStack_f0,0x26,2,plVar1);
        uStack_70 = uStack_f0;
        uStack_68 = uStack_e8;
        uStack_60 = uStack_e0;
        func_0x000100368b2c(&uStack_70,uRam00000001038053f8);
        func_0x000100368b40(&uStack_70,*(undefined8 *)(plVar6[0xb] + 0x60));
        func_0x000100368b2c(&uStack_70,uRam0000000103805400);
        func_0x000100368b40(&uStack_70,*(undefined8 *)(plVar6[0xb] + 0x60));
        func_0x000100368b2c(&uStack_70,uRam0000000103805408);
      }
      else {
        uStack_c8 = 0;
        uStack_c0 = 0;
        uStack_b8 = 0;
        func_0x000100384d7c(&uStack_c8,0x1d,5,plVar1);
        uStack_70 = uStack_c8;
        uStack_68 = uStack_c0;
        uStack_60 = uStack_b8;
        func_0x000100368b2c(&uStack_70,uRam00000001038053f8);
        func_0x000100368b40(&uStack_70,*(undefined8 *)(plVar6[0xb] + 0x60));
        func_0x000100368b2c(&uStack_70,uRam0000000103800c08);
        piStack_58 = aiStack_d0;
        uVar7 = func_0x000100354be0(plVar6);
        *(undefined8 *)piStack_58 = uVar7;
        func_0x00010037f624(&uStack_70,(long)aiStack_d0[0]);
        func_0x000100368b2c(&uStack_70,uRam0000000103800c08);
        piStack_58 = (int *)&uStack_d8;
        uVar7 = func_0x000100354be0(plVar6);
        *(undefined8 *)piStack_58 = uVar7;
        func_0x00010037f624(&uStack_70,(long)uStack_d8._4_4_);
        func_0x000100368b2c(&uStack_70,uRam0000000103804e90);
        func_0x000100368b40(&uStack_70,*(undefined8 *)(plVar6[0xb] + 0x60));
        func_0x000100368b2c(&uStack_70,uRam0000000103800c08);
        iVar3 = (**(code **)(*plVar6 + 0x1f0))(plVar6);
        func_0x00010037f624(&uStack_70,(long)iVar3);
        func_0x000100368b2c(&uStack_70,uRam00000001038053d0);
      }
    }
    lStack_50 = 0;
    func_0x00010012388c();
    if (lStack_50 != 0) {
      func_0x000100331ba4();
    }
  }
  lStack_40 = 0;
  func_0x0001001238ec();
  if (lStack_40 != 0) {
    func_0x000100331ba4();
  }
  func_0x000100331b2c(plVar1,uRam0000000103805418);
  (**(code **)(*plVar1 + 0x60))(plVar1);
  return;
}

