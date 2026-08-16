/* 0x06005df7 StardewValley.Menus.MobileColorPicker.containsPoint @ 0x101e06318 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileColorPicker_containsPoint_06005df7
               (long param_1,undefined4 param_2,undefined4 param_3,char param_4)

{
  code *pcVar1;
  undefined8 uVar2;
  long lVar3;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (param_4 == '\0') {
    uVar2 = _UNK_10369eec0;
    if (param_1 == 0) goto LAB_101e063a0;
    lVar3 = 0x94;
  }
  else {
    uVar2 = _UNK_10369eec8;
    if (param_1 == 0) {
LAB_101e063a0:
      func_0x0001003316f4(0xee,uVar2);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101e063ac);
      (*pcVar1)();
    }
    lVar3 = 0xa4;
  }
  func_0x000100356238(lVar3 + param_1,param_2,param_3);
  return;
}

