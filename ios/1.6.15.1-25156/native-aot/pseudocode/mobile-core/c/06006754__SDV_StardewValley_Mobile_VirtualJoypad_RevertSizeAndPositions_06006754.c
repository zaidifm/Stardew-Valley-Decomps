/* 0x06006754 StardewValley.Mobile.VirtualJoypad.RevertSizeAndPositions @ 0x101fd503c */

void SDV_StardewValley_Mobile_VirtualJoypad_RevertSizeAndPositions_06006754(long param_1)

{
  long lVar1;
  undefined8 uVar2;
  
  if (lRam0000000103976fb8 == 0) {
    uVar2 = *(undefined8 *)(param_1 + 0x108);
    lVar1 = param_1;
  }
  else {
    lVar1 = func_0x00010119b8f8();
    uVar2 = *(undefined8 *)(param_1 + 0x108);
  }
  uVar2 = SDV_StardewValley_Mobile_VirtualJoypad_set_positionJoystick_0600672b(lVar1,uVar2);
  uVar2 = SDV_StardewValley_Mobile_VirtualJoypad_set_positionButtonA_0600672e
                    (uVar2,*(undefined8 *)(param_1 + 0x110));
  uVar2 = SDV_StardewValley_Mobile_VirtualJoypad_set_positionButtonB_06006731
                    (uVar2,*(undefined8 *)(param_1 + 0x118));
  uVar2 = SDV_StardewValley_Mobile_VirtualJoypad_set_sizeJoystick_06006725
                    (uVar2,*(undefined4 *)(param_1 + 0x120));
  uVar2 = SDV_StardewValley_Mobile_VirtualJoypad_set_sizeButtonA_06006727
                    (uVar2,*(undefined4 *)(param_1 + 0x124));
  SDV_StardewValley_Mobile_VirtualJoypad_set_sizeButtonB_06006729
            (uVar2,*(undefined4 *)(param_1 + 0x128));
  SDV_StardewValley_Mobile_VirtualJoypad_UpdateButtonSizes_06006759(param_1);
  SDV_StardewValley_Mobile_VirtualJoypad_UpdateJoystickAndButtonsStartPositions_06006743(param_1);
  SDV_StardewValley_Mobile_VirtualJoypad_UpdateButtonScales_0600675a(param_1);
  return;
}

