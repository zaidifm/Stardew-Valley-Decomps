/* 0x06005e9f StardewValley.Menus.tweeningSprite.draw @ 0x101e246c8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_tweeningSprite_draw_06005e9f(long param_1,undefined8 param_2)

{
  code *pcVar1;
  undefined4 uVar2;
  undefined8 uVar3;
  long lVar4;
  long *plVar5;
  undefined4 uVar6;
  undefined4 uVar7;
  
  if (lRam0000000103976fb8 == 0) {
    plVar5 = *(long **)(param_1 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    plVar5 = *(long **)(param_1 + 0x18);
  }
  if (plVar5 == (long *)0x0) {
LAB_101e24734:
    plVar5 = *(long **)(param_1 + 0x20);
    uVar3 = _UNK_1036a3238;
  }
  else {
    if (*(char *)(param_1 + 0x31) != '\0') {
      uVar2 = func_0x000100331988();
      (**(code **)(*plVar5 + 0xa0))(0x3c03126f,plVar5,param_2,uVar2,0,0,0);
      goto LAB_101e24734;
    }
    if (*(long *)(param_1 + 0x28) != 0) {
      SDV_StardewValley_Menus_tweeningSprite_resetVector_06005e9b
                (*(undefined4 *)(param_1 + 0x34),*(undefined4 *)(param_1 + 0x38),
                 *(undefined4 *)(param_1 + 0x3c),*(undefined4 *)(param_1 + 0x40),param_1);
      plVar5 = *(long **)(param_1 + 0x18);
      uVar3 = _UNK_1036a3240;
      if (plVar5 == (long *)0x0) goto LAB_101e24808;
    }
    (**(code **)(*plVar5 + 0xa8))(plVar5,param_2);
    plVar5 = *(long **)(param_1 + 0x20);
    uVar3 = _UNK_1036a3238;
  }
  _UNK_1036a3238 = uVar3;
  if (plVar5 != (long *)0x0) {
    lVar4 = *(long *)(param_1 + 0x10);
    if (lVar4 == 0) {
LAB_101e24808:
      func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101e24814);
      (*pcVar1)();
    }
    uVar7 = *(undefined4 *)(lVar4 + 0x3c);
    uVar6 = *(undefined4 *)(lVar4 + 0x40);
    uVar2 = func_0x000100331988();
    (**(code **)(*plVar5 + 0x308))
              (uVar7,uVar6,0x3f800000,0x3f800000,0x3f666666,plVar5,param_2,1,uVar2,1);
  }
  return;
}

