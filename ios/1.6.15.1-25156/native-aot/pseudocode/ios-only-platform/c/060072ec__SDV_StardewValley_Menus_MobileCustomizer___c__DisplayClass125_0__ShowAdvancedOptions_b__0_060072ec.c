/* 0x060072ec StardewValley.Menus.MobileCustomizer+<>c__DisplayClass125_0.<ShowAdvancedOptions>b__0 @ 0x1020a83d4 */

void SDV_StardewValley_Menus_MobileCustomizer___c__DisplayClass125_0__ShowAdvancedOptions_b__0_060072ec
               (long param_1)

{
  undefined8 uVar1;
  
  if (lRam0000000103976fb8 == 0) {
    uVar1 = *(undefined8 *)(param_1 + 0x10);
  }
  else {
    func_0x00010119b8f8();
    uVar1 = *(undefined8 *)(param_1 + 0x10);
  }
  StardewValley_StardewValley_Menus_TitleMenu_set_subMenu_06006581(uVar1);
  StardewValley_StardewValley_Menus_IClickableMenu_RemoveDependency_0600616a
            (*(undefined8 *)(param_1 + 0x18));
  (**(code **)(**(long **)(param_1 + 0x18) + 0x188))();
  return;
}

