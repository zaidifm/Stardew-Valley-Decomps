/* 0x060072e8 StardewValley.Menus.MobileCustomizer+<>c.<.ctor>b__105_7 @ 0x1020a8318 */

void SDV_StardewValley_Menus_MobileCustomizer___c___ctor_b__105_7_060072e8
               (undefined8 param_1,long param_2)

{
  int iVar1;
  
  if (lRam0000000103976fb8 == 0) {
    iVar1 = *(int *)(param_2 + 0x54);
  }
  else {
    func_0x00010119b8f8();
    iVar1 = *(int *)(param_2 + 0x54);
  }
  if (iVar1 == -500) {
    *(undefined4 *)(param_2 + 0x54) = 0xffffffff;
  }
  *(undefined8 *)(param_2 + 100) = 0xfffe7962fffe7962;
  *(undefined8 *)(param_2 + 0x5c) = 0xfffe7962fffe7962;
  return;
}

