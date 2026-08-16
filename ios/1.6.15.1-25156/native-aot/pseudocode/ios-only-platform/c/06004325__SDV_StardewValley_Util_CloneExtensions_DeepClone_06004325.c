/* 0x06004325 StardewValley.Util.CloneExtensions.DeepClone @ 0x101a3cf54 */

void SDV_StardewValley_Util_CloneExtensions_DeepClone_06004325(undefined8 param_1)

{
  char cVar1;
  
  cVar1 = cRam000000010390f134;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1032eec46);
    cRam000000010390f134 = '\x01';
  }
  SDV_StardewValley_Util_CloneExtensions_DeepCloneObject_06004327(param_1);
  return;
}

