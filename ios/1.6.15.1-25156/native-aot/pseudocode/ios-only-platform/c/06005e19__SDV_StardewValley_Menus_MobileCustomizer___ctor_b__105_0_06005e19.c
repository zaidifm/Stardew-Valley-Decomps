/* 0x06005e19 StardewValley.Menus.MobileCustomizer.<.ctor>b__105_0 @ 0x101e14648 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer___ctor_b__105_0_06005e19(long param_1)

{
  code *pcVar1;
  undefined4 uVar2;
  long lVar3;
  
  if (lRam0000000103976fb8 == 0) {
    lVar3 = *(long *)(param_1 + 0x68);
  }
  else {
    func_0x00010119b8f8();
    lVar3 = *(long *)(param_1 + 0x68);
  }
  if (lVar3 != 0) {
    uVar2 = SDV_StardewValley_Menus_MobileColorPicker_getSelectedColor_06005dee();
    SDV_StardewValley_Menus_MobileCustomizer_DyeItem_06005dfd(param_1,uVar2);
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036a1600);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e146b4);
  (*pcVar1)();
}

