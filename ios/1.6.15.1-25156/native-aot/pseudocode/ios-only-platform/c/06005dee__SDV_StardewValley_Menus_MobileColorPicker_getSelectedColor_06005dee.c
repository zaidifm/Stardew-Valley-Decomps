/* 0x06005dee StardewValley.Menus.MobileColorPicker.getSelectedColor @ 0x101e04ba8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileColorPicker_getSelectedColor_06005dee(long param_1)

{
  code *pcVar1;
  undefined8 uVar2;
  long lVar3;
  
  if (lRam0000000103976fb8 == 0) {
    lVar3 = *(long *)(param_1 + 0x68);
  }
  else {
    func_0x00010119b8f8();
    lVar3 = *(long *)(param_1 + 0x68);
  }
  uVar2 = _UNK_10369ec58;
  if (((lVar3 != 0) && (uVar2 = _UNK_10369ec60, *(long *)(param_1 + 0x78) != 0)) &&
     (uVar2 = _UNK_10369ec68, *(long *)(param_1 + 0x70) != 0)) {
    SDV_StardewValley_Menus_MobileColorPicker_HsvToRgb_06005dfa
              (((double)*(int *)(lVar3 + 0x10) / 100.0) * 360.0,
               (double)*(int *)(*(long *)(param_1 + 0x78) + 0x10) / 100.0,
               (double)*(int *)(*(long *)(param_1 + 0x70) + 0x10) / 100.0);
    return;
  }
  func_0x0001003316f4(0xee,uVar2);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e04c6c);
  (*pcVar1)();
}

