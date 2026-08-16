/* 0x06005df5 StardewValley.Menus.MobileColorPicker.releaseClick @ 0x101e051e0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileColorPicker_releaseClick_06005df5(long param_1)

{
  code *pcVar1;
  undefined8 uVar2;
  
  uVar2 = _UNK_10369ed20;
  if (((*(long *)(param_1 + 0x68) != 0) && (uVar2 = _UNK_10369ed28, *(long *)(param_1 + 0x78) != 0))
     && (uVar2 = _UNK_10369ed30, *(long *)(param_1 + 0x70) != 0)) {
    *(undefined8 *)(param_1 + 0x80) = 0;
    return;
  }
  func_0x0001003316f4(0xee,uVar2);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e05240);
  (*pcVar1)();
}

