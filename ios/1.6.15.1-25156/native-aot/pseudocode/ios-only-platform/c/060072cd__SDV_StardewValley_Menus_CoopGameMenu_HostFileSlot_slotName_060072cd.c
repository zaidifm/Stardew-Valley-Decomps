/* 0x060072cd StardewValley.Menus.CoopGameMenu+HostFileSlot.slotName @ 0x1020a7068 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_HostFileSlot_slotName_060072cd(long param_1)

{
  char cVar1;
  code *pcVar2;
  long *plVar3;
  undefined8 uVar4;
  long lVar5;
  
  cVar1 = cRam00000001039120dc;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_10332fc8b);
    cRam00000001039120dc = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
    lVar5 = *(long *)(param_1 + 0x28);
  }
  else {
    lVar5 = *(long *)(param_1 + 0x28);
  }
  uVar4 = _UNK_1036edb50;
  if (((*(long *)(lVar5 + 0x58) != 0) && (uVar4 = _UNK_1036edb58, *(long *)(lVar5 + 0x2a0) != 0)) &&
     (plVar3 = (long *)*plRam00000001038d5338, uVar4 = _UNK_1036edb60, plVar3 != (long *)0x0)) {
    (**(code **)(*plVar3 + 0xe0))
              (plVar3,uRam0000000103909400,*(undefined8 *)(*(long *)(lVar5 + 0x58) + 0x60),
               *(undefined8 *)(*(long *)(lVar5 + 0x2a0) + 0x60));
    return;
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x1020a7164);
  (*pcVar2)();
}

