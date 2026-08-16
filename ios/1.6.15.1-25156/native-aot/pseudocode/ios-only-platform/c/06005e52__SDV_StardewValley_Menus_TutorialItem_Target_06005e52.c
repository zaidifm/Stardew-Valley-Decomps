/* 0x06005e52 StardewValley.Menus.TutorialItem.Target @ 0x101e1cfd4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialItem_Target_06005e52
               (long param_1,undefined4 param_2,undefined4 param_3)

{
  code *pcVar1;
  undefined8 uVar2;
  
  uVar2 = _UNK_1036a28c8;
  if (param_1 != 0) {
    *(undefined1 *)(param_1 + 0xb4) = 1;
    *(undefined4 *)(param_1 + 200) = 1;
    uVar2 = _UNK_1036a28d0;
    if (param_1 != -0xc0) {
      *(undefined4 *)(param_1 + 0xc0) = param_2;
      *(undefined4 *)(param_1 + 0xc4) = param_3;
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar2);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1d01c);
  (*pcVar1)();
}

