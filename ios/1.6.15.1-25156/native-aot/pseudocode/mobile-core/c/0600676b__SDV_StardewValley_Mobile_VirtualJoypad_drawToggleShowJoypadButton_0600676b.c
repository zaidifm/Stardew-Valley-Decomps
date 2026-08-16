/* 0x0600676b StardewValley.Mobile.VirtualJoypad.drawToggleShowJoypadButton @ 0x101fd7dc4 */

void SDV_StardewValley_Mobile_VirtualJoypad_drawToggleShowJoypadButton_0600676b
               (long param_1,undefined8 param_2)

{
  undefined4 uVar1;
  undefined4 uVar2;
  long lVar3;
  long *plVar4;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  lVar3 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if (*(char *)(lVar3 + 0x17c) == '\0') {
    if (*(char *)(param_1 + 0x104) == '\0') {
      SDV_StardewValley_Mobile_VirtualJoypad_set_showJoypad_0600675d(param_1,1);
    }
  }
  else {
    plVar4 = *(long **)(param_1 + 0x68);
    uVar2 = 0x3f000000;
    if (*(char *)(param_1 + 0x104) != '\0') {
      uVar2 = 0x3f800000;
    }
    uVar1 = func_0x000100331988();
    uVar2 = func_0x0001003519f4(uVar2,uVar1);
    (**(code **)(*plVar4 + 0xa0))(0x33d6bf95,plVar4,param_2,uVar2,0,0,0);
  }
  return;
}

