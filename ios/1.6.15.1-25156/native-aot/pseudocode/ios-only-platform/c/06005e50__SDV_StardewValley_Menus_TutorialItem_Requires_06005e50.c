/* 0x06005e50 StardewValley.Menus.TutorialItem.Requires @ 0x101e1cd44 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_Menus_TutorialItem_Requires_06005e50(long param_1,long param_2)

{
  uint uVar1;
  undefined4 uVar2;
  char cVar3;
  code *pcVar4;
  long lVar5;
  undefined8 uVar6;
  long lVar7;
  undefined4 *puVar8;
  ulong uVar9;
  
  cVar3 = cRam0000000103910c5f;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_1033175e3);
    cRam0000000103910c5f = '\x01';
    uVar1 = *(uint *)(param_2 + 0x18);
  }
  else {
    uVar1 = *(uint *)(param_2 + 0x18);
  }
  uVar9 = (ulong)uVar1;
  if (0 < (int)uVar1) {
    uVar6 = _UNK_1036a2890;
    if (param_1 == 0) {
LAB_101e1ce60:
      func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
      pcVar4 = (code *)SoftwareBreakpoint(1,0x101e1ce6c);
      (*pcVar4)();
    }
    puVar8 = (undefined4 *)(param_2 + 0x20);
    do {
      lVar5 = *(long *)(param_1 + 0x68);
      lVar7 = *(long *)(lVar5 + 0x10);
      uVar2 = *puVar8;
      *(int *)(lVar5 + 0x1c) = *(int *)(lVar5 + 0x1c) + 1;
      uVar6 = _UNK_1036a2888;
      if (lVar7 == 0) goto LAB_101e1ce60;
      uVar1 = *(uint *)(lVar5 + 0x18);
      if (uVar1 < *(uint *)(lVar7 + 0x18)) {
        *(uint *)(lVar5 + 0x18) = uVar1 + 1;
        if (*(uint *)(lVar7 + 0x18) <= uVar1) {
          func_0x0001003316f4(0xcc,_UNK_1036a2898);
                    /* WARNING: Does not return */
          pcVar4 = (code *)SoftwareBreakpoint(1,0x101e1ce80);
          (*pcVar4)();
        }
        *(undefined4 *)(lVar7 + (long)(int)uVar1 * 4 + 0x20) = uVar2;
      }
      else {
        func_0x000100346db0();
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      puVar8 = puVar8 + 1;
      uVar9 = uVar9 - 1;
    } while (uVar9 != 0);
  }
  return param_1;
}

