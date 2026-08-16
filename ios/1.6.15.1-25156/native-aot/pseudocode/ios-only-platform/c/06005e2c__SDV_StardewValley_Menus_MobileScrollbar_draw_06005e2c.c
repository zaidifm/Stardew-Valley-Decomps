/* 0x06005e2c StardewValley.Menus.MobileScrollbar.draw @ 0x101e1b4a0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileScrollbar_draw_06005e2c(long param_1,long param_2)

{
  char cVar1;
  code *pcVar2;
  undefined4 uVar3;
  long *plVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  int iVar7;
  int iVar8;
  undefined8 uStack_88;
  undefined8 uStack_80;
  undefined4 uStack_78;
  undefined4 uStack_74;
  undefined4 uStack_70;
  undefined4 uStack_6c;
  undefined4 uStack_68;
  undefined8 uStack_60;
  undefined8 uStack_58;
  undefined4 uStack_50;
  
  cVar1 = cRam0000000103910c3b;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103317557);
    cRam0000000103910c3b = '\x01';
    plVar4 = *(long **)(param_1 + 0x28);
  }
  else {
    plVar4 = *(long **)(param_1 + 0x28);
  }
  (**(code **)(*plVar4 + 0xa8))(plVar4,param_2);
  (**(code **)(**(long **)(param_1 + 0x30) + 0xa8))(*(long **)(param_1 + 0x30),param_2);
  if (*(char *)(param_1 + 0x74) != '\0') {
    (**(code **)(**(long **)(param_1 + 0x10) + 0xa8))(*(long **)(param_1 + 0x10),param_2);
    (**(code **)(**(long **)(param_1 + 0x18) + 0xa8))(*(long **)(param_1 + 0x18),param_2);
  }
  uVar5 = _UNK_1036a2628;
  if ((*(long *)(param_1 + 0x30) != 0) && (uVar5 = _UNK_1036a2630, param_1 != -0x50)) {
    iVar7 = *(int *)(param_1 + 0x50);
    iVar8 = *(int *)(param_1 + 0x54);
    uVar6 = *(undefined8 *)(*(long *)(param_1 + 0x30) + 0x78);
    uStack_88 = 0;
    uStack_80 = 0;
    func_0x00010034ede4(&uStack_88,0x28,0x5c,0xc,1);
    uStack_78 = 1;
    uStack_6c = (undefined4)uStack_80;
    uStack_68 = (undefined4)((ulong)uStack_80 >> 0x20);
    uStack_74 = (undefined4)uStack_88;
    uStack_70 = (undefined4)((ulong)uStack_88 >> 0x20);
    uStack_58 = CONCAT44(uStack_6c,uStack_70);
    uStack_60 = CONCAT44(uStack_74,1);
    uStack_50 = uStack_68;
    uVar3 = func_0x000100331988();
    uVar5 = _UNK_1036a2638;
    if (*(char *)(lRam00000001038c7e00 + 0x35) == '\0') {
      func_0x0001003319b0(lRam00000001038c7e00);
      uVar5 = _UNK_1036a2638;
    }
    _UNK_1036a2638 = uVar5;
    if (param_2 != 0) {
      func_0x00010035df9c((float)iVar7,(float)iVar8,0,*puRam00000001038d4510,
                          puRam00000001038d4510[1],0x40800000,(float)*(int *)(param_1 + 0x5c),0,
                          param_2,uVar6,&uStack_60,uVar3,0);
      (**(code **)(**(long **)(param_1 + 0x20) + 0xa8))(*(long **)(param_1 + 0x20),param_2);
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e1b6b8);
  (*pcVar2)();
}

