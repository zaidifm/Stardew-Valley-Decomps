/* 0x06004327 StardewValley.Util.CloneExtensions.DeepCloneObject @ 0x101a3d058 */

void SDV_StardewValley_Util_CloneExtensions_DeepCloneObject_06004327(undefined8 param_1)

{
  char cVar1;
  undefined8 uVar2;
  undefined8 uVar3;
  
  cVar1 = cRam000000010390f136;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1032eec60);
    cRam000000010390f136 = '\x01';
  }
  uVar2 = func_0x000100331820(uRam00000001038f0298,0x10);
  uVar3 = func_0x000100331820(uRam00000001038f02a0,0x50);
  func_0x000100367c7c(uVar3,uVar2);
  SDV_StardewValley_Util_CloneExtensions_InternalCopy_06004328(param_1,uVar3);
  return;
}

