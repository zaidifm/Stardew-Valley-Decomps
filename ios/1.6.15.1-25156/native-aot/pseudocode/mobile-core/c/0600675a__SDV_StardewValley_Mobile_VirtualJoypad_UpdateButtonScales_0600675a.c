/* 0x0600675a StardewValley.Mobile.VirtualJoypad.UpdateButtonScales @ 0x101fd5ec4 */

void SDV_StardewValley_Mobile_VirtualJoypad_UpdateButtonScales_0600675a(long param_1)

{
  long lVar1;
  float fVar2;
  undefined4 uVar3;
  float fVar4;
  
  if (lRam0000000103976fb8 == 0) {
    lVar1 = *(long *)(param_1 + 0x70);
  }
  else {
    func_0x00010119b8f8();
    lVar1 = *(long *)(param_1 + 0x70);
  }
  fVar4 = *(float *)(lVar1 + 0x48);
  fVar2 = (float)SDV_StardewValley_Mobile_VirtualJoypad_get_joystickScale_06006736(param_1);
  if (((fVar4 != fVar2) ||
      (fVar4 = *(float *)(*(long *)(param_1 + 0x78) + 0x48),
      fVar2 = (float)SDV_StardewValley_Mobile_VirtualJoypad_get_buttonAScale_06006737(param_1),
      fVar4 != fVar2)) ||
     (fVar4 = *(float *)(*(long *)(param_1 + 0x80) + 0x48),
     fVar2 = (float)SDV_StardewValley_Mobile_VirtualJoypad_get_buttonBScale_06006738(param_1),
     fVar4 != fVar2)) {
    lVar1 = *(long *)(param_1 + 0x70);
    uVar3 = SDV_StardewValley_Mobile_VirtualJoypad_get_joystickScale_06006736(param_1);
    *(undefined4 *)(lVar1 + 0x48) = uVar3;
    lVar1 = *(long *)(param_1 + 0x78);
    uVar3 = SDV_StardewValley_Mobile_VirtualJoypad_get_buttonAScale_06006737(param_1);
    *(undefined4 *)(lVar1 + 0x48) = uVar3;
    lVar1 = *(long *)(param_1 + 0x80);
    uVar3 = SDV_StardewValley_Mobile_VirtualJoypad_get_buttonBScale_06006738(param_1);
    *(undefined4 *)(lVar1 + 0x48) = uVar3;
  }
  return;
}

