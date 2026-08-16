/* 0x06005e32 StardewValley.Menus.MobileScrollbar.sliderRunnerContains @ 0x101e1ba24 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Menus_MobileScrollbar_sliderRunnerContains_06005e32
               (long param_1,int param_2,int param_3)

{
  code *pcVar1;
  undefined8 uVar2;
  
  uVar2 = _UNK_1036a26d0;
  if ((param_1 != 0) && (uVar2 = _UNK_1036a26d8, param_1 != -0x40)) {
    if (*(int *)(param_1 + 0x40) - *(int *)(param_1 + 0x6c) <= param_2) {
      uVar2 = _UNK_1036a26e0;
      if (param_1 == -0x50) goto LAB_101e1bab8;
      if ((param_2 <= *(int *)(param_1 + 0x58) + *(int *)(param_1 + 0x40) + *(int *)(param_1 + 0x70)
          ) && (*(int *)(param_1 + 0x44) <= param_3)) {
        return param_3 <= *(int *)(param_1 + 0x4c) + *(int *)(param_1 + 0x44);
      }
    }
    return false;
  }
LAB_101e1bab8:
  func_0x0001003316f4(0xee,uVar2);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1bac4);
  (*pcVar1)();
}

