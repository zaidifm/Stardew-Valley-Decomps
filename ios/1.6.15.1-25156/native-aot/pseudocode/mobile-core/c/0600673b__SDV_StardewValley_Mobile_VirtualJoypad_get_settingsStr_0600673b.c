/* 0x0600673b StardewValley.Mobile.VirtualJoypad.get_settingsStr @ 0x101fd29bc */

void SDV_StardewValley_Mobile_VirtualJoypad_get_settingsStr_0600673b(undefined8 param_1)

{
  char cVar1;
  undefined8 uVar2;
  undefined8 uVar3;
  ulong uVar4;
  undefined8 uStack_50;
  undefined4 uStack_48;
  undefined4 uStack_44;
  
  cVar1 = cRam000000010391154a;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103325cd0);
    cRam000000010391154a = '\x01';
  }
  uVar2 = func_0x000100331794(uRam00000001038c4f40,0x18);
  func_0x000100331f8c(uVar2,0,uRam0000000103904b50);
  uStack_50 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionJoystick_0600672a();
  uVar3 = func_0x00010034eec0(&uStack_50);
  func_0x000100331f8c(uVar2,1,uVar3);
  func_0x000100331f8c(uVar2,2,uRam00000001038d3dd0);
  uStack_50 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionJoystick_0600672a();
  uVar4 = (ulong)&uStack_50 | 4;
  uVar3 = func_0x00010034eec0(uVar4);
  func_0x000100331f8c(uVar2,3,uVar3);
  func_0x000100331f8c(uVar2,4,uRam0000000103904b58);
  uStack_48 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
  uVar3 = func_0x00010034eec0(&uStack_48);
  func_0x000100331f8c(uVar2,5,uVar3);
  func_0x000100331f8c(uVar2,6,uRam0000000103904b60);
  uStack_44 = SDV_StardewValley_Mobile_VirtualJoypad_get_joystickScale_06006736(param_1);
  uVar3 = func_0x000100360e2c(&uStack_44);
  func_0x000100331f8c(uVar2,7,uVar3);
  func_0x000100331f8c(uVar2,8,uRam0000000103904b68);
  uStack_50 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonA_0600672d();
  uVar3 = func_0x00010034eec0(&uStack_50);
  func_0x000100331f8c(uVar2,9,uVar3);
  func_0x000100331f8c(uVar2,10,uRam00000001038d3dd0);
  uStack_50 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonA_0600672d();
  uVar3 = func_0x00010034eec0(uVar4);
  func_0x000100331f8c(uVar2,0xb,uVar3);
  func_0x000100331f8c(uVar2,0xc,uRam0000000103904b58);
  uStack_48 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonA_06006726();
  uVar3 = func_0x00010034eec0(&uStack_48);
  func_0x000100331f8c(uVar2,0xd,uVar3);
  func_0x000100331f8c(uVar2,0xe,uRam0000000103904b60);
  uStack_44 = SDV_StardewValley_Mobile_VirtualJoypad_get_buttonAScale_06006737(param_1);
  uVar3 = func_0x000100360e2c(&uStack_44);
  func_0x000100331f8c(uVar2,0xf,uVar3);
  func_0x000100331f8c(uVar2,0x10,uRam0000000103904b70);
  uStack_50 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonB_06006730();
  uVar3 = func_0x00010034eec0(&uStack_50);
  func_0x000100331f8c(uVar2,0x11,uVar3);
  func_0x000100331f8c(uVar2,0x12,uRam00000001038d3dd0);
  uStack_50 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonB_06006730();
  uVar3 = func_0x00010034eec0(uVar4);
  func_0x000100331f8c(uVar2,0x13,uVar3);
  func_0x000100331f8c(uVar2,0x14,uRam0000000103904b58);
  uStack_48 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonB_06006728();
  uVar3 = func_0x00010034eec0(&uStack_48);
  func_0x000100331f8c(uVar2,0x15,uVar3);
  func_0x000100331f8c(uVar2,0x16,uRam0000000103904b60);
  uStack_44 = SDV_StardewValley_Mobile_VirtualJoypad_get_buttonBScale_06006738(param_1);
  uVar3 = func_0x000100360e2c(&uStack_44);
  func_0x000100331f8c(uVar2,0x17,uVar3);
  func_0x000100351da0(uVar2);
  return;
}

