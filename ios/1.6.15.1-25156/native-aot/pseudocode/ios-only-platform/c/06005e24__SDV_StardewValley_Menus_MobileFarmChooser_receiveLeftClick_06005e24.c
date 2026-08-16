/* 0x06005e24 StardewValley.Menus.MobileFarmChooser.receiveLeftClick @ 0x101e17144 */

/* WARNING: Removing unreachable block (ram,0x000101e17698) */
/* WARNING: Removing unreachable block (ram,0x000101e17684) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileFarmChooser_receiveLeftClick_06005e24
               (long param_1,undefined4 param_2,undefined4 param_3)

{
  uint uVar1;
  long *plVar2;
  code *pcVar3;
  char cVar4;
  long lVar5;
  undefined8 uVar6;
  uint *puVar7;
  uint uVar8;
  undefined8 uStack_68;
  undefined8 uStack_60;
  long *plStack_58;
  undefined8 uStack_50;
  undefined8 *puStack_48;
  long *plStack_40;
  long *plStack_38;
  
  cVar4 = cRam0000000103910c33;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_1033173e0);
    cRam0000000103910c33 = '\x01';
  }
  uStack_68 = 0;
  uStack_60 = 0;
  plStack_58 = (long *)0x0;
  if (*(char *)(param_1 + 0x1c0) == '\0') {
    cVar4 = (**(code **)(**(long **)(param_1 + 0xf8) + 0x90))
                      (*(long **)(param_1 + 0xf8),param_2,param_3);
    if (cVar4 != '\0') {
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      puVar7 = puRam00000001038d6430;
      uVar8 = *puRam00000001038d6430 - 1;
      *puRam00000001038d6430 = uVar8;
      if ((int)uVar8 < 0) {
        uVar6 = _UNK_1036a1bf0;
        if (*(long *)(param_1 + 0x68) == 0) goto LAB_101e17658;
        uVar8 = *(int *)(*(long *)(param_1 + 0x68) + 0x18) - 1;
        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
          func_0x0001003319b0();
          puVar7 = puRam00000001038d6430;
        }
        *puVar7 = uVar8;
      }
      uVar6 = _UNK_1036a1bc0;
      if (param_1 == 0) goto LAB_101e17658;
      lVar5 = *(long *)(param_1 + 0x68);
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0(lRam00000001038c4c88);
        uVar8 = *puRam00000001038d6430;
        uVar1 = *(uint *)(lVar5 + 0x18);
      }
      else {
        uVar1 = *(uint *)(lVar5 + 0x18);
      }
      if (uVar1 <= uVar8) goto LAB_101e17474;
      uVar6 = _UNK_1036a1bd8;
      if (*(uint *)(*(long *)(lVar5 + 0x10) + 0x18) <= uVar8) goto LAB_101e17514;
      func_0x000100377d5c(param_1,*(undefined8 *)
                                   (*(long *)(*(long *)(lVar5 + 0x10) + (long)(int)uVar8 * 8 + 0x20)
                                   + 0x10));
    }
    cVar4 = (**(code **)(**(long **)(param_1 + 0x100) + 0x90))
                      (*(long **)(param_1 + 0x100),param_2,param_3);
    if (cVar4 != '\0') {
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      puVar7 = puRam00000001038d6430;
      uVar8 = *puRam00000001038d6430 + 1;
      *puRam00000001038d6430 = uVar8;
      if (*(int *)(*(long *)(param_1 + 0x68) + 0x18) <= (int)uVar8) {
        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
          func_0x0001003319b0();
          puVar7 = puRam00000001038d6430;
        }
        uVar8 = 0;
        *puVar7 = 0;
      }
      uVar6 = _UNK_1036a1b98;
      if (param_1 == 0) goto LAB_101e17658;
      lVar5 = *(long *)(param_1 + 0x68);
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0(lRam00000001038c4c88);
        uVar8 = *puRam00000001038d6430;
        uVar1 = *(uint *)(lVar5 + 0x18);
      }
      else {
        uVar1 = *(uint *)(lVar5 + 0x18);
      }
      if (uVar1 <= uVar8) {
LAB_101e17474:
        func_0x000100331b90(param_1);
                    /* WARNING: Does not return */
        pcVar3 = (code *)SoftwareBreakpoint(1,0x101e1747c);
        (*pcVar3)();
      }
      uVar6 = _UNK_1036a1bb0;
      if (*(uint *)(*(long *)(lVar5 + 0x10) + 0x18) <= uVar8) {
LAB_101e17514:
        func_0x0001003316f4(0xcc,uVar6);
                    /* WARNING: Does not return */
        pcVar3 = (code *)SoftwareBreakpoint(1,0x101e17520);
        (*pcVar3)();
      }
      func_0x000100377d5c(param_1,*(undefined8 *)
                                   (*(long *)(*(long *)(lVar5 + 0x10) + (long)(int)uVar8 * 8 + 0x20)
                                   + 0x10));
    }
  }
  else {
    uVar6 = _UNK_1036a1c00;
    if (*(long *)(param_1 + 0x68) == 0) {
LAB_101e17658:
      func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
      pcVar3 = (code *)SoftwareBreakpoint(1,0x101e17664);
      (*pcVar3)();
    }
    func_0x000100377d98(&uStack_68);
    while (cVar4 = func_0x000100377dac(&uStack_68), plVar2 = plStack_58, cVar4 != '\0') {
      if (plStack_58 == (long *)0x0) {
LAB_101e17228:
        func_0x0001003316f4(0xee,_UNK_1036a1c10);
                    /* WARNING: Does not return */
        pcVar3 = (code *)SoftwareBreakpoint(1,0x101e1723c);
        (*pcVar3)();
      }
      cVar4 = (**(code **)(*plStack_58 + 0x90))(plStack_58,param_2,param_3);
      if (cVar4 != '\0') {
        lVar5 = plVar2[2];
        if (lVar5 == 0) goto LAB_101e17228;
        cVar4 = func_0x000100350144(lVar5,uRam0000000103900770);
        if (cVar4 == '\0') {
          func_0x000100377d5c(param_1,plVar2[2]);
        }
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
    }
    uStack_50 = 0;
    puStack_48 = &uStack_68;
    if (puStack_48 == (undefined8 *)0x0) {
      puStack_48 = (undefined8 *)0x0;
      uVar6 = _UNK_1036a1c08;
      goto LAB_101e17658;
    }
  }
  if (*(char *)(param_1 + 0x1c0) != '\0') {
    plStack_40 = *(long **)(param_1 + 0x80);
    plStack_38 = plStack_40;
    if (plStack_40 != (long *)0x0) {
      (**(code **)(*plStack_40 + 0xc0))();
    }
    cVar4 = (**(code **)(**(long **)(param_1 + 0x88) + 0x90))
                      (*(long **)(param_1 + 0x88),param_2,param_3);
    if ((cVar4 != '\0') &&
       (cVar4 = SDV_StardewValley_Menus_MobileFarmChooser_canLeaveMenu_06005e29(param_1),
       cVar4 != '\0')) {
      StardewValley_StardewValley_Game1_playSound_0600301b(uRam00000001038d7418,0);
    }
    cVar4 = (**(code **)(**(long **)(param_1 + 0x90) + 0x90))
                      (*(long **)(param_1 + 0x90),param_2,param_3);
    if (cVar4 != '\0') {
      StardewValley_StardewValley_Game1_playSound_0600301b(uRam00000001038d7418,0);
    }
  }
  return;
}

