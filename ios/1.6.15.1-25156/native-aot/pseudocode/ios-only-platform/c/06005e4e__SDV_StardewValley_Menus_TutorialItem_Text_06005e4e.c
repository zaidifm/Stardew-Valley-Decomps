/* 0x06005e4e StardewValley.Menus.TutorialItem.Text @ 0x101e1cc8c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_Menus_TutorialItem_Text_06005e4e(long param_1,undefined8 param_2)

{
  code *pcVar1;
  undefined8 uVar2;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar2 = StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                    (param_2,0,0,0);
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x80) = uVar2;
    *(undefined1 *)(((ulong)(param_1 + 0x80) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    return param_1;
  }
  func_0x0001003316f4(0xee,_UNK_1036a2868);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1cd10);
  (*pcVar1)();
}

