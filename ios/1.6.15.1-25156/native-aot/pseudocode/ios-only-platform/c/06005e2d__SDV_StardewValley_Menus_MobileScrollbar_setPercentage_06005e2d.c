/* 0x06005e2d StardewValley.Menus.MobileScrollbar.setPercentage @ 0x101e1b6b8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileScrollbar_setPercentage_06005e2d(float param_1,long param_2)

{
  code *pcVar1;
  undefined8 uVar2;
  long lVar3;
  float fVar4;
  
  fVar4 = 100.0;
  if ((param_1 <= 100.0) && (fVar4 = param_1, param_1 < 0.0)) {
    fVar4 = 0.0;
  }
  lVar3 = *(long *)(param_2 + 0x20);
  uVar2 = _UNK_1036a2660;
  if ((lVar3 != 0) && (uVar2 = _UNK_1036a2668, lVar3 != -0x38)) {
    *(int *)(lVar3 + 0x3c) =
         *(int *)(param_2 + 0x60) +
         (int)((fVar4 * (float)(*(int *)(param_2 + 100) - *(int *)(param_2 + 0x60))) / 100.0);
    return;
  }
  func_0x0001003316f4(0xee,uVar2);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1b748);
  (*pcVar1)();
}

