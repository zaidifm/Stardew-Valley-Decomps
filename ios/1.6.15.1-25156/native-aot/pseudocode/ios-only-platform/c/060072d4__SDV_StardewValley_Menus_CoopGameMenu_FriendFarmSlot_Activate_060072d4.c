/* 0x060072d4 StardewValley.Menus.CoopGameMenu+FriendFarmSlot.Activate @ 0x1020a7310 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_FriendFarmSlot_Activate_060072d4(long param_1)

{
  char cVar1;
  code *pcVar2;
  long *plVar3;
  undefined8 uVar4;
  undefined8 uVar5;
  long *plVar6;
  
  cVar1 = cRam00000001039120e3;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_10332fca0);
    cRam00000001039120e3 = '\x01';
    plVar6 = *(long **)(param_1 + 0x28);
  }
  else {
    plVar6 = *(long **)(param_1 + 0x28);
  }
  plVar3 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
  uVar4 = _UNK_1036edba8;
  if (plVar3 != (long *)0x0) {
    plVar3 = (long *)(**(code **)(*plVar3 + -0x38))();
    uVar4 = _UNK_1036edbb0;
    if ((*(long *)(param_1 + 0x30) != 0) && (uVar4 = _UNK_1036edbb8, plVar3 != (long *)0x0)) {
      uVar4 = (**(code **)(*plVar3 + -0x50))
                        (plVar3,*(undefined8 *)(*(long *)(param_1 + 0x30) + 0x10));
      uVar5 = func_0x000100331870(uRam00000001039001f0);
      StardewValley_StardewValley_Menus_FarmhandMenu__ctor_060060f2(uVar5,uVar4);
      (**(code **)(*plVar6 + 0x220))(plVar6,uVar5);
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x1020a7428);
  (*pcVar2)();
}

