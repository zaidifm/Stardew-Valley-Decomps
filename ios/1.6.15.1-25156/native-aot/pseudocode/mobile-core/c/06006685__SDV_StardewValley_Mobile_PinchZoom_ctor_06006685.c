/* 0x06006685 StardewValley.Mobile.PinchZoom..ctor @ 0x101fb0ebc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_PinchZoom_ctor_06006685(long param_1)

{
  code *pcVar1;
  
  if (cRam0000000103911494 == '\0') {
    func_0x00010119b908(&UNK_10332509a);
    cRam0000000103911494 = '\x01';
  }
  if (param_1 == 0) {
    func_0x0001003316f4(0xee,_UNK_1036d3b10);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101fb0f30);
    (*pcVar1)();
  }
  *(undefined4 *)(param_1 + 0x10) = 0x7f7fffff;
  *(undefined4 *)(param_1 + 0x18) = 0x3f800000;
  *(undefined8 *)(param_1 + 0x20) = 0x7f7fffff7f7fffff;
  *(undefined8 *)(param_1 + 0x28) = 0x7f7fffff7f7fffff;
  *(undefined8 *)(param_1 + 0x30) = 0x7f7fffff7f7fffff;
  return;
}

