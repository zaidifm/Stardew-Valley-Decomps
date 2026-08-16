/* 0x06006667 StardewValley.Mobile.MobileDebug.LoadCommand @ 0x101faee7c */

void SDV_StardewValley_Mobile_MobileDebug_LoadCommand_06006667(void)

{
  char cVar1;
  undefined8 uVar2;
  
  cVar1 = cRam0000000103911476;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103324e80);
    cRam0000000103911476 = '\x01';
  }
  uVar2 = func_0x00010037d5a4();
  cVar1 = func_0x000100345aa0(uVar2,uRam00000001039047f0);
  if (cVar1 == '\0') {
    uVar2 = func_0x00010037d5a4();
    func_0x000100345aa0(uVar2,uRam00000001039047f8);
  }
  return;
}

