/* 0x06006733 StardewValley.Mobile.VirtualJoypad..ctor @ 0x101fd1b60 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_ctor_06006733(long param_1)

{
  undefined8 uVar1;
  undefined8 uVar2;
  undefined8 uVar3;
  long lVar4;
  char cVar5;
  code *pcVar6;
  undefined4 uVar7;
  undefined4 uVar8;
  undefined4 uVar9;
  ulong uVar10;
  undefined8 uVar11;
  undefined8 uVar12;
  undefined8 uVar13;
  undefined8 uStack_c0;
  undefined8 uStack_b8;
  undefined8 uStack_b0;
  undefined8 uStack_a8;
  undefined8 uStack_a0;
  undefined8 uStack_98;
  undefined8 uStack_90;
  undefined8 uStack_88;
  undefined8 uStack_80;
  undefined8 uStack_78;
  undefined8 uStack_70;
  undefined8 uStack_68;
  
  cVar5 = cRam0000000103911542;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar5 == '\0') {
    func_0x00010119b908(&UNK_103325c20);
    cRam0000000103911542 = '\x01';
  }
  if (param_1 == 0) {
    func_0x0001003316f4(0xee,_UNK_1036d8408);
                    /* WARNING: Does not return */
    pcVar6 = (code *)SoftwareBreakpoint(1,0x101fd1f5c);
    (*pcVar6)();
  }
  *(undefined8 *)(param_1 + 0xd0) = 0x7fffffffffffffff;
  *(undefined4 *)(param_1 + 0xdc) = 0xde;
  if (*(char *)(lRam00000001038c7de8 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  *(undefined8 *)(param_1 + 0xe0) = *puRam00000001038d7928;
  if (*(char *)(lRam00000001038c7de8 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  *(undefined8 *)(param_1 + 0xe8) = *puRam00000001038d7928;
  if (*(char *)(lRam00000001038c7de8 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  *(undefined8 *)(param_1 + 0xf0) = *puRam00000001038d7928;
  if (*(char *)(lRam00000001038c7e00 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar12 = *puRam00000001038d4510;
  *(undefined4 *)(param_1 + 0x100) = 0xffffffff;
  *(undefined1 *)(param_1 + 0x104) = 1;
  *(undefined8 *)(param_1 + 0x120) = 0x6f000000b9;
  *(undefined8 *)(param_1 + 0x128) = 0x3ecccccd0000006f;
  *(undefined8 *)(param_1 + 0xf8) = uVar12;
  uStack_c0 = 0;
  uStack_b8 = 0;
  func_0x00010034ede4(&uStack_c0,0,0x74,0x25,0x25);
  *(undefined4 *)(param_1 + 0x140) = 0xc;
  *(undefined4 *)(param_1 + 0x160) = 0x3dcccccd;
  uVar12 = uRam00000001038d6940;
  *(undefined8 *)(param_1 + 0x138) = uStack_b8;
  *(undefined8 *)(param_1 + 0x130) = uStack_c0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x20) = uVar12;
  lVar4 = lRam00000001038c4be0;
  *(undefined1 *)(((ulong)(param_1 + 0x20) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
  uVar7 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionJoystick_0600672a();
  uVar10 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionJoystick_0600672a();
  uVar8 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
  uVar9 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
  uStack_b0 = 0;
  uStack_a8 = 0;
  func_0x00010034ede4(&uStack_b0,uVar7,uVar10 >> 0x20,uVar8,uVar9);
  uVar3 = uStack_a8;
  uVar12 = uStack_b0;
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar1 = *(undefined8 *)(param_1 + 0x130);
  uVar2 = *(undefined8 *)(param_1 + 0x138);
  uVar13 = *puRam00000001038d5350;
  uVar11 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
  func_0x000101e5fa0c(0x40800000,uVar11,uVar12,uVar3,uVar13,uVar1,uVar2,0);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x70) = uVar11;
  *(undefined1 *)(((ulong)(param_1 + 0x70) >> 9 & 0x7fffff) + lVar4) = 1;
  uVar7 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonA_0600672d();
  uVar10 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonA_0600672d();
  uVar8 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonA_06006726();
  uVar9 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonA_06006726();
  uStack_a0 = 0;
  uStack_98 = 0;
  func_0x00010034ede4(&uStack_a0,uVar7,uVar10 >> 0x20,uVar8,uVar9);
  uVar2 = uStack_98;
  uVar1 = uStack_a0;
  uVar12 = *(undefined8 *)(param_1 + 0x130);
  uVar3 = *(undefined8 *)(param_1 + 0x138);
  uVar13 = *puRam00000001038d5350;
  uVar11 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
  func_0x000101e5fa0c(0x40800000,uVar11,uVar1,uVar2,uVar13,uVar12,uVar3,0);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x78) = uVar11;
  *(undefined1 *)(((ulong)(param_1 + 0x78) >> 9 & 0x7fffff) + lVar4) = 1;
  uVar7 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonB_06006730();
  uVar10 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonB_06006730();
  uVar8 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonB_06006728();
  uVar9 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonB_06006728();
  uStack_90 = 0;
  uStack_88 = 0;
  func_0x00010034ede4(&uStack_90,uVar7,uVar10 >> 0x20,uVar8,uVar9);
  uVar2 = uStack_88;
  uVar1 = uStack_90;
  uVar12 = *(undefined8 *)(param_1 + 0x130);
  uVar3 = *(undefined8 *)(param_1 + 0x138);
  uVar13 = *puRam00000001038d5350;
  uVar11 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
  func_0x000101e5fa0c(0x40800000,uVar11,uVar1,uVar2,uVar13,uVar12,uVar3,0);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x80) = uVar11;
  *(undefined1 *)(((ulong)(param_1 + 0x80) >> 9 & 0x7fffff) + lVar4) = 1;
  uStack_80 = 0;
  uStack_78 = 0;
  func_0x00010034ede4(&uStack_80,*piRam00000001038d57b8 + 0x24,0xc,0x40,0x40);
  uVar3 = uStack_78;
  uVar12 = uStack_80;
  uVar13 = *puRam00000001038d5350;
  uStack_70 = 0;
  uStack_68 = 0;
  func_0x00010034ede4(&uStack_70,0x62,0x2c,0x10,0x10);
  uVar2 = uStack_68;
  uVar1 = uStack_70;
  uVar11 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
  func_0x000101e5fa0c(0x40800000,uVar11,uVar12,uVar3,uVar13,uVar1,uVar2,0);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x68) = uVar11;
  *(undefined1 *)(((ulong)(param_1 + 0x68) >> 9 & 0x7fffff) + lVar4) = 1;
  return;
}

