/* 0x06005e72 StardewValley.Menus.TutorialManager.completeAllTutorials @ 0x101e1efd4 */

/* WARNING: Removing unreachable block (ram,0x000101e1f140) */
/* WARNING: Removing unreachable block (ram,0x000101e1f118) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialManager_completeAllTutorials_06005e72(long param_1)

{
  long lVar1;
  code *pcVar2;
  char cVar3;
  undefined8 uVar4;
  undefined8 uStack_58;
  undefined8 uStack_50;
  long lStack_48;
  undefined8 uStack_40;
  undefined8 uStack_38;
  
  cVar3 = cRam0000000103910c81;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103317788);
    cRam0000000103910c81 = '\x01';
  }
  uStack_58 = 0;
  uStack_50 = 0;
  lStack_48 = 0;
  if (*(char *)(param_1 + 0xac) == '\0') {
    return;
  }
  uVar4 = _UNK_1036a2b88;
  if (*(long *)(param_1 + 0x68) != 0) {
    func_0x000100378040(&uStack_58);
    while (cVar3 = func_0x000100378054(&uStack_58), lVar1 = lStack_48, cVar3 != '\0') {
      if (lStack_48 == 0) {
        func_0x0001003316f4(0xee,_UNK_1036a2b90);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101e1f090);
        (*pcVar2)();
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      SDV_StardewValley_Menus_TutorialItem_setComplete_06005e56(lVar1);
    }
    uStack_40 = 0;
    if (&stack0x00000000 != (undefined1 *)0x58) {
      *(undefined8 *)(param_1 + 0x90) = 0;
      return;
    }
    uStack_38 = 0;
    uVar4 = _UNK_1036a2b98;
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e1f0e4);
  (*pcVar2)();
}

