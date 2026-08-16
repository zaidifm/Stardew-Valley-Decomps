/* 0x06004326 StardewValley.Util.CloneExtensions.DeepCloneT @ 0x101a3cfb8 */

void SDV_StardewValley_Util_CloneExtensions_DeepCloneT_06004326(undefined8 param_1)

{
  long lVar1;
  char cVar2;
  undefined8 uVar3;
  long in_x15;
  long extraout_x15;
  
  cVar2 = cRam000000010390f135;
  lVar1 = in_x15;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
    lVar1 = extraout_x15;
  }
  if (cVar2 == '\0') {
    func_0x00010119b95c(&UNK_1032eec4d,lVar1);
    cRam000000010390f135 = '\x01';
  }
  if (*(long *)(in_x15 + 0x18) == 0) {
    func_0x000100331708(in_x15,uRam00000001038f0290);
  }
  uVar3 = SDV_StardewValley_Util_CloneExtensions_DeepCloneObject_06004327(param_1);
  func_0x00010034ef74(uVar3,*(undefined8 *)(*(long *)(in_x15 + 0x20) + 8));
  return;
}

