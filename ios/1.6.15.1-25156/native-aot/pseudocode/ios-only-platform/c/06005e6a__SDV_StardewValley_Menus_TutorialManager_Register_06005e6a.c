/* 0x06005e6a StardewValley.Menus.TutorialManager.Register @ 0x101e1e644 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Menus_TutorialManager_Register_06005e6a(long param_1,uint param_2)

{
  long lVar1;
  uint uVar2;
  char cVar3;
  code *pcVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  long lVar7;
  long *plVar8;
  int iVar9;
  undefined8 uStack_60;
  undefined8 uStack_58;
  long lStack_50;
  undefined8 uStack_48;
  ulong uStack_40;
  
  cVar3 = cRam0000000103910c79;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103317730);
    cRam0000000103910c79 = '\x01';
  }
  uStack_40 = 0;
  uStack_58 = 0;
  uStack_60 = 0;
  uStack_48 = 0;
  lStack_50 = 0;
  lVar7 = *(long *)(param_1 + 0x70);
  if (*(uint *)(lVar7 + 0x18) <= param_2) {
    func_0x0001003316f4(0xcc,_UNK_1036a2ae0);
                    /* WARNING: Does not return */
    pcVar4 = (code *)SoftwareBreakpoint(1,0x101e1e788);
    (*pcVar4)();
  }
  lVar1 = (-(ulong)(param_2 >> 0x1f) & 0xfffffffc00000000 | (ulong)param_2 << 2) + 0x20;
  if (*(int *)(lVar1 + lVar7) < 0) {
    *(undefined4 *)(lVar7 + lVar1) = *(undefined4 *)(*(long *)(param_1 + 0x68) + 0x18);
    uVar5 = func_0x000100331820(uRam00000001039007b8,0xe0);
    SDV_StardewValley_Menus_TutorialItem__ctor_06005e4b(uVar5,param_2);
    lVar7 = *(long *)(param_1 + 0x68);
    plVar8 = *(long **)(lVar7 + 0x10);
    *(int *)(lVar7 + 0x1c) = *(int *)(lVar7 + 0x1c) + 1;
    uVar6 = _UNK_1036a2aa8;
    if (plVar8 != (long *)0x0) {
      uVar2 = *(uint *)(lVar7 + 0x18);
      if (uVar2 < *(uint *)(plVar8 + 3)) {
        *(uint *)(lVar7 + 0x18) = uVar2 + 1;
        (**(code **)(*plVar8 + 0x110))(plVar8,(long)(int)uVar2,uVar5);
      }
      else {
        func_0x000100377f14(lVar7,uVar5);
      }
      return uVar5;
    }
  }
  else {
    func_0x0001003318fc(&uStack_60,0x28,1);
    lVar7 = func_0x000100331a28(uRam00000001038c4cb8,0xe33df);
    uVar6 = _UNK_1036a2ab0;
    if (&stack0x00000000 != (undefined1 *)0x50) {
      if ((uint)uStack_40 <= (uint)uStack_48) {
        uVar6 = _UNK_1036a2ab8;
        if (lVar7 == 0) goto LAB_101e1e824;
        uVar2 = *(uint *)(lVar7 + 0x10);
        if ((uint)uStack_48 - (uint)uStack_40 < uVar2) {
          func_0x000100331910(&uStack_60,lVar7);
        }
        else {
          iVar9 = 0;
          if (uVar2 != 0) {
            lVar1 = lStack_50 + (uStack_40 & 0xffffffff) * 2;
            uVar6 = _UNK_1036a2ac0;
            if ((lVar1 == 0) || (uVar6 = _UNK_1036a2ad8, lVar7 + 0x14 == 0)) goto LAB_101e1e824;
            _memmove(lVar1,lVar7 + 0x14,(ulong)uVar2 << 1);
            iVar9 = *(int *)(lVar7 + 0x10);
          }
          uStack_40 = CONCAT44(uStack_40._4_4_,iVar9 + (uint)uStack_40);
        }
        func_0x000100377f28(&uStack_60,param_2);
        lVar7 = lRam00000001039007d0;
        if ((uint)uStack_40 <= (uint)uStack_48) {
          uVar2 = *(uint *)(lRam00000001039007d0 + 0x10);
          if ((uint)uStack_48 - (uint)uStack_40 < uVar2) {
            func_0x000100331910(&uStack_60,lRam00000001039007d0);
          }
          else {
            iVar9 = 0;
            if (uVar2 != 0) {
              lVar1 = lStack_50 + (uStack_40 & 0xffffffff) * 2;
              uVar6 = _UNK_1036a2ac8;
              if ((lVar1 == 0) || (uVar6 = _UNK_1036a2ad0, lRam00000001039007d0 + 0x14 == 0))
              goto LAB_101e1e824;
              _memmove(lVar1,lRam00000001039007d0 + 0x14,(ulong)uVar2 << 1);
              iVar9 = *(int *)(lVar7 + 0x10);
            }
            uStack_40 = CONCAT44(uStack_40._4_4_,iVar9 + (uint)uStack_40);
          }
          uVar6 = func_0x000100331938(&uStack_60);
          uVar5 = func_0x000100331820(uRam00000001039007d8,0x98);
          func_0x000100377f3c(uVar5,uVar6);
          func_0x000100331a50(uVar5);
                    /* WARNING: Does not return */
          pcVar4 = (code *)SoftwareBreakpoint(1,0x101e1e914);
          (*pcVar4)();
        }
      }
      func_0x0001003319d8();
                    /* WARNING: Does not return */
      pcVar4 = (code *)SoftwareBreakpoint(1,0x101e1e88c);
      (*pcVar4)();
    }
  }
LAB_101e1e824:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101e1e830);
  (*pcVar4)();
}

