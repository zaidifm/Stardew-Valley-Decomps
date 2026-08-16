/* 0x06006e5d StardewValley.Util.CloneExtensions+<>c__DisplayClass5_0.<InternalCopy>b__0 @ 0x1020567b4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Util_CloneExtensions___c__DisplayClass5_0__InternalCopy_b__0_06006e5d
               (long param_1,long param_2,undefined8 param_3)

{
  code *pcVar1;
  long lVar2;
  undefined8 uVar3;
  undefined8 uVar4;
  
  if (lRam0000000103976fb8 == 0) {
    lVar2 = *(long *)(param_1 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    lVar2 = *(long *)(param_1 + 0x18);
  }
  uVar3 = _UNK_1036e4e28;
  if (lVar2 != 0) {
    uVar3 = func_0x000100380268(lVar2,param_3);
    uVar4 = SDV_StardewValley_Util_CloneExtensions_InternalCopy_06004328
                      (uVar3,*(undefined8 *)(param_1 + 0x10));
    uVar3 = _UNK_1036e4e30;
    if (param_2 != 0) {
      func_0x00010038027c(param_2,uVar4,param_3);
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x102056850);
  (*pcVar1)();
}

