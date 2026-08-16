/* 0x0600667a StardewValley.Mobile.PinchZoom.get_MinZoom @ 0x101faff7c */

float SDV_StardewValley_Mobile_PinchZoom_get_MinZoom_0600667a(void)

{
  bool bVar1;
  char cVar2;
  float fVar3;
  undefined8 uVar4;
  float fVar5;
  
  cVar2 = cRam0000000103911489;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103324fe0);
    cRam0000000103911489 = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar4 = NEON_scvtf(*(undefined8 *)(lRam00000001038d6278 + 8),4);
  fVar3 = (float)uVar4 * 0.00024414062;
  fVar5 = (float)((ulong)uVar4 >> 0x20) * 0.00024414062;
  bVar1 = (int)fVar5 < 0;
  if (fVar3 != fVar5) {
    bVar1 = fVar5 < fVar3;
  }
  if (!bVar1) {
    fVar3 = fVar5;
  }
  return fVar3;
}

