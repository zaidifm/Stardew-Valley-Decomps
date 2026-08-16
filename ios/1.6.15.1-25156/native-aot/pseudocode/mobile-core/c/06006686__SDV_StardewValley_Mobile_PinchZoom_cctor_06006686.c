/* 0x06006686 StardewValley.Mobile.PinchZoom..cctor @ 0x101fb0f30 */

void SDV_StardewValley_Mobile_PinchZoom_cctor_06006686(void)

{
  char cVar1;
  undefined8 uVar2;
  
  cVar1 = cRam0000000103911495;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033250b0);
    cRam0000000103911495 = '\x01';
  }
  DataMemoryBarrier(2,3);
  *puRam0000000103904878 = 0;
  uVar2 = func_0x000100331820(uRam00000001038c6120,0x10);
  DataMemoryBarrier(2,3);
  *puRam0000000103904870 = uVar2;
  return;
}

