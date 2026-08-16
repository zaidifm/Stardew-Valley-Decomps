/* 0x06005e00 StardewValley.Menus.MobileCustomizer.getSkinColor @ 0x101e06e14 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined4 SDV_StardewValley_Menus_MobileCustomizer_getSkinColor_06005e00(long param_1,int param_2)

{
  uint uVar1;
  int iVar2;
  int iVar3;
  code *pcVar4;
  long lVar5;
  
  if (lRam0000000103976fb8 == 0) {
    lVar5 = *(long *)(param_1 + 0x1c0);
  }
  else {
    func_0x00010119b8f8();
    lVar5 = *(long *)(param_1 + 0x1c0);
  }
  if (lVar5 == 0) {
    SDV_StardewValley_Menus_MobileCustomizer_setUpSkinColorData_06005dff(param_1);
    lVar5 = *(long *)(param_1 + 0x1c0);
  }
  iVar3 = *(int *)(*(long *)(param_1 + 0x1b8) + 0x74) * 3;
  if (iVar3 == 0) {
    func_0x0001003316f4(0x95,_UNK_10369efd8);
                    /* WARNING: Does not return */
    pcVar4 = (code *)SoftwareBreakpoint(1,0x101e06ed8);
    (*pcVar4)();
  }
  param_2 = param_2 * 3;
  if ((param_2 == -0x80000000) && (iVar3 == -1)) {
    func_0x0001003316f4(0x101,_UNK_10369efe0);
                    /* WARNING: Does not return */
    pcVar4 = (code *)SoftwareBreakpoint(1,0x101e06f14);
    (*pcVar4)();
  }
  if (lVar5 == 0) {
    func_0x0001003316f4(0xee,_UNK_10369efd0);
                    /* WARNING: Does not return */
    pcVar4 = (code *)SoftwareBreakpoint(1,0x101e06eec);
    (*pcVar4)();
  }
  iVar2 = 0;
  if (iVar3 != 0) {
    iVar2 = param_2 / iVar3;
  }
  uVar1 = (param_2 - iVar2 * iVar3) + 2;
  if (uVar1 < *(uint *)(lVar5 + 0x18)) {
    return *(undefined4 *)(lVar5 + (long)(int)uVar1 * 4 + 0x20);
  }
  func_0x0001003316f4(0xcc,_UNK_10369efe8);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101e06f00);
  (*pcVar4)();
}

