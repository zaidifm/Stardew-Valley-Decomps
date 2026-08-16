/* 0x06006777 StardewValley.iOS.AppDelegate.CheckToCopySaveGames @ 0x101fd92b0 */

void SDV_StardewValley_iOS_AppDelegate_CheckToCopySaveGames_06006777(undefined8 param_1)

{
  char cVar1;
  long lVar2;
  undefined8 uVar3;
  ulong uVar4;
  undefined8 *puVar5;
  
  cVar1 = cRam0000000103911586;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103325f60);
    cRam0000000103911586 = '\x01';
  }
  lVar2 = func_0x000100331794(uRam00000001038c4f40,3);
  func_0x000100331f8c(lVar2,0,uRam0000000103904bf8);
  func_0x000100331f8c(lVar2,1,uRam0000000103904c00);
  func_0x000100331f8c(lVar2,2,uRam0000000103904c08);
  uVar4 = (ulong)*(uint *)(lVar2 + 0x18);
  if (0 < (int)*(uint *)(lVar2 + 0x18)) {
    puVar5 = (undefined8 *)(lVar2 + 0x20);
    do {
      uVar3 = *puVar5;
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      func_0x0001003323d8(*puRam00000001038d5308,uVar3);
      cVar1 = func_0x000100351774();
      if (cVar1 == '\0') {
        func_0x00010037e6fc(param_1,uVar3);
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      puVar5 = puVar5 + 1;
      uVar4 = uVar4 - 1;
    } while (uVar4 != 0);
  }
  return;
}

