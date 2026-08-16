/* 0x0600432b StardewValley.Util.CloneExtensions.Copy @ 0x101a3d6bc */

void SDV_StardewValley_Util_CloneExtensions_Copy_0600432b(undefined8 param_1)

{
  char cVar1;
  undefined8 uVar2;
  long in_x15;
  
  cVar1 = cRam000000010390f13a;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b95c(&UNK_1032eecd7);
    cRam000000010390f13a = '\x01';
  }
  if (*(long *)(in_x15 + 0x18) == 0) {
    func_0x000100331708(in_x15,uRam00000001038f0328);
  }
  uVar2 = func_0x000100367d44(param_1);
  func_0x00010034ef74(uVar2,*(undefined8 *)(*(long *)(in_x15 + 0x20) + 8));
  return;
}

