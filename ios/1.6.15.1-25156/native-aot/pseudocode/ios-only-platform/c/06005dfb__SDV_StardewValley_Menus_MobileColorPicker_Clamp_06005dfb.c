/* 0x06005dfb StardewValley.Menus.MobileColorPicker.Clamp @ 0x101e069bc */

int SDV_StardewValley_Menus_MobileColorPicker_Clamp_06005dfb(undefined8 param_1,int param_2)

{
  if (0xfe < param_2) {
    param_2 = 0xff;
  }
  if (param_2 < 1) {
    param_2 = 0;
  }
  return param_2;
}

