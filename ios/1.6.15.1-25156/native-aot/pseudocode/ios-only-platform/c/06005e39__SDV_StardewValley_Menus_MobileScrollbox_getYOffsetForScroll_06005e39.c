/* 0x06005e39 StardewValley.Menus.MobileScrollbox.getYOffsetForScroll @ 0x101e1c140 */

int SDV_StardewValley_Menus_MobileScrollbox_getYOffsetForScroll_06005e39(long param_1)

{
  int iVar1;
  int iVar2;
  
  iVar1 = *(int *)(param_1 + 0x4c) % 4;
  iVar2 = *(int *)(param_1 + 0x4c) - iVar1;
  if (2 < iVar1) {
    iVar2 = iVar2 + 4;
  }
  return iVar2;
}

