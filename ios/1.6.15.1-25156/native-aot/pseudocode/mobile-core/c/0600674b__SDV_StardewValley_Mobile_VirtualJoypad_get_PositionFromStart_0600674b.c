/* 0x0600674b StardewValley.Mobile.VirtualJoypad.get_PositionFromStart @ 0x101fd4264 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

float SDV_StardewValley_Mobile_VirtualJoypad_get_PositionFromStart_0600674b(long param_1)

{
  code *pcVar1;
  undefined8 uVar2;
  
  uVar2 = _UNK_1036d88e0;
  if (((param_1 != 0) && (uVar2 = _UNK_1036d88e8, param_1 != -0xe0)) &&
     (uVar2 = _UNK_1036d88f0, param_1 != -0xf0)) {
    return (float)(*(int *)(param_1 + 0xe0) - *(int *)(param_1 + 0xf0));
  }
  func_0x0001003316f4(0xee,uVar2);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd42c8);
  (*pcVar1)();
}

