/* 0x06006753 StardewValley.Mobile.VirtualJoypad.BackupSizeAndPositions @ 0x101fd4fc8 */

void SDV_StardewValley_Mobile_VirtualJoypad_BackupSizeAndPositions_06006753(long param_1)

{
  undefined8 uVar1;
  undefined4 uVar2;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar1 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionJoystick_0600672a();
  *(undefined8 *)(param_1 + 0x108) = uVar1;
  uVar1 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonA_0600672d();
  *(undefined8 *)(param_1 + 0x110) = uVar1;
  uVar1 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonB_06006730();
  *(undefined8 *)(param_1 + 0x118) = uVar1;
  uVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
  *(undefined4 *)(param_1 + 0x120) = uVar2;
  uVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonA_06006726();
  *(undefined4 *)(param_1 + 0x124) = uVar2;
  uVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonB_06006728();
  *(undefined4 *)(param_1 + 0x128) = uVar2;
  return;
}

