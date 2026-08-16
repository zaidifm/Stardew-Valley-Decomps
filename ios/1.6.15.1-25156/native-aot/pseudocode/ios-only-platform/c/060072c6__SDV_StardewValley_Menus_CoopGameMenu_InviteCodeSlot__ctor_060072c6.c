/* 0x060072c6 StardewValley.Menus.CoopGameMenu+InviteCodeSlot..ctor @ 0x1020a6cb4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_InviteCodeSlot__ctor_060072c6
               (undefined8 param_1,undefined8 param_2)

{
  char cVar1;
  code *pcVar2;
  long *plVar3;
  undefined8 uVar4;
  
  cVar1 = cRam00000001039120d5;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_10332fc62);
    cRam00000001039120d5 = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  plVar3 = (long *)*plRam00000001038d5338;
  if (plVar3 != (long *)0x0) {
    uVar4 = (**(code **)(*plVar3 + 0x100))(plVar3,uRam00000001039001a8);
    SDV_StardewValley_Menus_CoopGameMenu_LabeledSlot__ctor_060072c1(param_1,param_2,uVar4);
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036edb08);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x1020a6d74);
  (*pcVar2)();
}

