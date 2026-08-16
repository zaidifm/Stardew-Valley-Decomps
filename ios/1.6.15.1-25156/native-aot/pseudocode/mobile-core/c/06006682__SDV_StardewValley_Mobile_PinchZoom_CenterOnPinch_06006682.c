/* 0x06006682 StardewValley.Mobile.PinchZoom.CenterOnPinch @ 0x101fb0c18 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_PinchZoom_CenterOnPinch_06006682(long param_1)

{
  float *pfVar1;
  char cVar2;
  code *pcVar3;
  undefined8 uVar4;
  
  cVar2 = cRam0000000103911491;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325073);
    cRam0000000103911491 = '\x01';
  }
  pfVar1 = pfRam00000001038d5388;
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
    pfVar1 = pfRam00000001038d5388;
  }
  uVar4 = _UNK_1036d3ae0;
  pfRam00000001038d5388 = pfVar1;
  if ((param_1 != 0) && (uVar4 = _UNK_1036d3ae8, pfVar1 != (float *)0x0)) {
    *pfVar1 = *(float *)(param_1 + 0x60) +
              (*(float *)(param_1 + 0x30) - *(float *)(param_1 + 0x68) * *(float *)(param_1 + 0x38))
    ;
    pfVar1[1] = *(float *)(param_1 + 100) +
                (*(float *)(param_1 + 0x34) -
                *(float *)(param_1 + 0x6c) * *(float *)(param_1 + 0x3c));
    return;
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fb0cfc);
  (*pcVar3)();
}

