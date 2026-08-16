/* 0x060072d5 StardewValley.Menus.CoopGameMenu+FriendFarmSlot.slotName @ 0x1020a7428 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_FriendFarmSlot_slotName_060072d5(long param_1)

{
  undefined8 uVar1;
  char cVar2;
  undefined8 uVar3;
  code *pcVar4;
  undefined8 uVar5;
  long lVar6;
  
  cVar2 = cRam00000001039120e4;
  if (lRam0000000103976fb8 == 0) {
    if (cRam00000001039120e4 == '\0') goto LAB_1020a74bc;
LAB_1020a7454:
    lVar6 = *(long *)(param_1 + 0x30);
  }
  else {
    func_0x00010119b8f8();
    if (cVar2 != '\0') goto LAB_1020a7454;
LAB_1020a74bc:
    func_0x00010119b908(&UNK_10332fcb1);
    cRam00000001039120e4 = '\x01';
    lVar6 = *(long *)(param_1 + 0x30);
  }
  uVar1 = uRam0000000103909410;
  uVar3 = uRam0000000103909408;
  uVar5 = _UNK_1036edbd0;
  if (lVar6 == 0) {
LAB_1020a7510:
    func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
    pcVar4 = (code *)SoftwareBreakpoint(1,0x1020a751c);
    (*pcVar4)();
  }
  cVar2 = *(char *)(lVar6 + 0x3c);
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
    lVar6 = *(long *)(param_1 + 0x30);
    uVar5 = _UNK_1036edbd8;
    if (lVar6 == 0) goto LAB_1020a7510;
  }
  if (cVar2 != '\0') {
    uVar1 = uVar3;
  }
  (**(code **)(*(long *)*puRam00000001038d5338 + 0xe8))
            ((long *)*puRam00000001038d5338,uVar1,*(undefined8 *)(lVar6 + 0x20));
  return;
}

