/* 0x06005e77 StardewValley.Menus.TutorialManager.checkIgnores @ 0x101e1f580 */

/* WARNING: Removing unreachable block (ram,0x000101e1f684) */
/* WARNING: Removing unreachable block (ram,0x000101e1f668) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1 SDV_StardewValley_Menus_TutorialManager_checkIgnores_06005e77(long param_1,long param_2)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined8 uVar4;
  int iVar5;
  undefined8 uStack_70;
  undefined8 uStack_68;
  ulong uStack_60;
  undefined1 uStack_51;
  undefined8 uStack_50;
  undefined8 *puStack_48;
  
  cVar2 = cRam0000000103910c86;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1033177b2);
    cRam0000000103910c86 = '\x01';
  }
  uStack_70 = 0;
  uStack_68 = 0;
  uStack_60 = 0;
  uStack_51 = 0;
  if (*(char *)(param_1 + 0xac) == '\0') {
    return 0;
  }
  uVar4 = _UNK_1036a2c00;
  if (*(long *)(param_2 + 0x70) != 0) {
    func_0x000100377fdc(&uStack_70);
    while (cVar2 = func_0x000100377ff0(&uStack_70), cVar2 != '\0') {
      lVar3 = SDV_StardewValley_Menus_TutorialManager_GetTutorial_06005e6b
                        (param_1,uStack_60 & 0xffffffff);
      if ((lVar3 != 0) && (*(char *)(lVar3 + 0xb0) != '\0')) {
        iVar5 = 1;
        uStack_51 = 0;
        goto LAB_101e1f644;
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
    }
    iVar5 = 2;
LAB_101e1f644:
    uStack_50 = 0;
    puStack_48 = &uStack_70;
    if (puStack_48 != (undefined8 *)0x0) {
      if (iVar5 == 1) {
        return uStack_51;
      }
      if (iVar5 == 2) {
        return 1;
      }
      func_0x000100331c30();
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1f70c);
      (*pcVar1)();
    }
    puStack_48 = (undefined8 *)0x0;
    uVar4 = _UNK_1036a2c08;
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1f704);
  (*pcVar1)();
}

