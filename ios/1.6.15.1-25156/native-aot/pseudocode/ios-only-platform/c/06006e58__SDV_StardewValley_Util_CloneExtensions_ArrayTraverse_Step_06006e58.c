/* 0x06006e58 StardewValley.Util.CloneExtensions+ArrayTraverse.Step @ 0x102056528 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Util_CloneExtensions_ArrayTraverse_Step_06006e58(long param_1)

{
  long lVar1;
  int *piVar2;
  uint uVar3;
  code *pcVar4;
  undefined8 uVar5;
  uint uVar6;
  long lVar7;
  long lVar8;
  ulong uVar9;
  long lVar10;
  
  if (lRam0000000103976fb8 == 0) {
    lVar8 = *(long *)(param_1 + 0x10);
  }
  else {
    func_0x00010119b8f8();
    lVar8 = *(long *)(param_1 + 0x10);
  }
  uVar3 = *(uint *)(lVar8 + 0x18);
  if (0 < (int)uVar3) {
    lVar7 = 0;
    lVar10 = *(long *)(param_1 + 0x18);
    do {
      uVar6 = (uint)lVar7;
      uVar5 = _UNK_1036e4de8;
      if ((uVar3 == uVar6) || (uVar5 = _UNK_1036e4df8, *(uint *)(lVar10 + 0x18) <= uVar6))
      goto LAB_102056694;
      lVar1 = (long)(int)uVar6 * 4 + 0x20;
      piVar2 = (int *)(lVar1 + lVar8);
      if (*piVar2 < *(int *)(lVar1 + lVar10)) {
        if (piVar2 == (int *)0x0) {
          func_0x0001003316f4(0xee,_UNK_1036e4e00);
                    /* WARNING: Does not return */
          pcVar4 = (code *)SoftwareBreakpoint(1,0x10205668c);
          (*pcVar4)();
        }
        *piVar2 = *piVar2 + 1;
        if (0 < (int)uVar6) {
          uVar9 = 0;
          lVar8 = 0x20;
          do {
            uVar5 = _UNK_1036e4e10;
            if (*(uint *)(*(long *)(param_1 + 0x10) + 0x18) <= uVar9) {
LAB_102056694:
              func_0x0001003316f4(0xcc,uVar5);
                    /* WARNING: Does not return */
              pcVar4 = (code *)SoftwareBreakpoint(1,0x1020566a0);
              (*pcVar4)();
            }
            *(undefined4 *)(lVar8 + *(long *)(param_1 + 0x10)) = 0;
            if (lRam0000000103976fb8 != 0) {
              func_0x00010119b8f8();
            }
            lVar8 = lVar8 + 4;
            lVar7 = lVar7 + -1;
            uVar9 = uVar9 + 1;
          } while (lVar7 != 0);
        }
        return 1;
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      lVar7 = lVar7 + 1;
    } while (uVar3 != (uint)lVar7);
  }
  return 0;
}

