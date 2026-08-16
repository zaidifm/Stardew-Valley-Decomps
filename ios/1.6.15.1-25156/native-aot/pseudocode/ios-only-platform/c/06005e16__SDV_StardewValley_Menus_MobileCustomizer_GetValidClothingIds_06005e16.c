/* 0x06005e16 StardewValley.Menus.MobileCustomizer.GetValidClothingIds @ 0x101e140d0 */

/* WARNING: Removing unreachable block (ram,0x000101e14364) */
/* WARNING: Removing unreachable block (ram,0x000101e1432c) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_Menus_MobileCustomizer_GetValidClothingIds_06005e16
               (undefined8 param_1,undefined8 param_2,long *param_3,long param_4)

{
  uint uVar1;
  long lVar2;
  code *pcVar3;
  char cVar4;
  long lVar5;
  long *plVar6;
  undefined8 uVar7;
  long *plVar8;
  long in_x15;
  undefined1 auVar9 [16];
  
  cVar4 = cRam0000000103910c25;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b95c(&UNK_103317130);
    cRam0000000103910c25 = '\x01';
  }
  if (*(long *)(in_x15 + 0x18) == 0) {
    func_0x000100331708(in_x15,uRam00000001039005e0);
  }
  lVar5 = func_0x000100331820(uRam00000001038c59b8,0x20);
  lVar2 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar5 + 0x10) = *puRam00000001038c59c0;
  *(undefined1 *)(((ulong)(lVar5 + 0x10) >> 9 & 0x7fffff) + lVar2) = 1;
  plVar6 = (long *)(**(code **)(*param_3 + -0x10))(param_3);
  while (plVar6 != (long *)0x0) {
    cVar4 = (**(code **)(*plVar6 + -0x78))(plVar6);
    if (cVar4 == '\0') {
      if (plVar6 != (long *)0x0) {
        if (plVar6 == (long *)0x0) {
          func_0x0001003316f4(0xee,_UNK_1036a15c0);
                    /* WARNING: Does not return */
          pcVar3 = (code *)SoftwareBreakpoint(1,0x101e142f8);
          (*pcVar3)();
        }
        (**(code **)(*plVar6 + -0x28))();
      }
      return lVar5;
    }
    if (plVar6 == (long *)0x0) break;
    auVar9 = (**(code **)(*plVar6 + -0x38))();
    uVar7 = auVar9._0_8_;
    cVar4 = func_0x000100345aa0(uVar7,param_2);
    if (cVar4 == '\0') {
      if (param_4 == 0) break;
      cVar4 = (**(code **)(param_4 + 0x18))(param_4,auVar9._8_8_);
      if (cVar4 != '\0') goto LAB_101e14214;
    }
    else {
LAB_101e14214:
      if (lVar5 == 0) break;
      plVar8 = *(long **)(lVar5 + 0x10);
      *(int *)(lVar5 + 0x1c) = *(int *)(lVar5 + 0x1c) + 1;
      if (plVar8 == (long *)0x0) break;
      uVar1 = *(uint *)(lVar5 + 0x18);
      if (uVar1 < *(uint *)(plVar8 + 3)) {
        *(uint *)(lVar5 + 0x18) = uVar1 + 1;
        (**(code **)(*plVar8 + 0x110))(plVar8,(long)(int)uVar1,uVar7);
      }
      else {
        func_0x00010033e7c8(lVar5,uVar7);
      }
    }
    if (lRam0000000103976fb8 != 0) {
      func_0x00010119b8f8();
    }
  }
  func_0x0001003316f4(0xee,_UNK_1036a15b8);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101e1429c);
  (*pcVar3)();
}

