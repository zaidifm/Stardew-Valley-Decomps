/* 0x0600677c StardewValley.iOS.Application.Main @ 0x101fd973c */

void SDV_StardewValley_iOS_Application_Main_0600677c(undefined8 param_1)

{
  char cVar1;
  
  cVar1 = cRam000000010391158b;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103325fdc);
    cRam000000010391158b = '\x01';
  }
  func_0x00010037e738(param_1,0,uRam0000000103904c78);
  return;
}

