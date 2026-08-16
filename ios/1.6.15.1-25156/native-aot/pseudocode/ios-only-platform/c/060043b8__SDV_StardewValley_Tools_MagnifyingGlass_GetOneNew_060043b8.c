/* 0x060043b8 StardewValley.Tools.MagnifyingGlass.GetOneNew @ 0x101a59814 */

undefined8 SDV_StardewValley_Tools_MagnifyingGlass_GetOneNew_060043b8(void)

{
  char cVar1;
  undefined8 uVar2;
  
  cVar1 = cRam000000010390f1c7;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1032efef6);
    cRam000000010390f1c7 = '\x01';
  }
  uVar2 = func_0x000100331820(uRam00000001038ce5f0,0x118);
  StardewValley_StardewValley_Tool__ctor_060040fd();
  return uVar2;
}

