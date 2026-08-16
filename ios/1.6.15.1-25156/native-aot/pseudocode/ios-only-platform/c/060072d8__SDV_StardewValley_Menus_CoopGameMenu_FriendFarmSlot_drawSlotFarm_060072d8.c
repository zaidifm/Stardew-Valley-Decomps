/* 0x060072d8 StardewValley.Menus.CoopGameMenu+FriendFarmSlot.drawSlotFarm @ 0x1020a7844 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_FriendFarmSlot_drawSlotFarm_060072d8
               (long param_1,long param_2,uint param_3)

{
  int iVar1;
  int iVar2;
  char cVar3;
  undefined8 uVar4;
  undefined8 uVar5;
  code *pcVar6;
  undefined4 uVar7;
  undefined8 uVar8;
  long lVar9;
  undefined8 uVar10;
  undefined8 uStack_a0;
  undefined8 uStack_98;
  undefined4 uStack_90;
  undefined8 uStack_88;
  undefined8 uStack_80;
  undefined8 uStack_78;
  undefined8 uStack_70;
  undefined8 uStack_68;
  undefined8 uStack_60;
  undefined4 uStack_58;
  undefined4 uStack_54;
  undefined4 uStack_50;
  undefined4 uStack_4c;
  undefined4 uStack_48;
  
  cVar3 = cRam00000001039120e7;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_10332fcd1);
    cRam00000001039120e7 = '\x01';
  }
  uStack_88 = 0;
  uStack_80 = 0;
  uStack_78 = 0;
  uStack_70 = 0;
  uStack_68 = 0;
  uStack_60 = 0;
  func_0x00010034ede4(&uStack_88,*(int *)(*(long *)(param_1 + 0x30) + 0x38) * 0x16,0x144,0x16,0x14);
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  lVar9 = *(long *)(*(long *)(param_1 + 0x28) + 0x90);
  if (*(uint *)(lVar9 + 0x18) <= param_3) {
    func_0x000100331b90();
                    /* WARNING: Does not return */
    pcVar6 = (code *)SoftwareBreakpoint(1,0x1020a7a1c);
    (*pcVar6)();
  }
  lVar9 = *(long *)(lVar9 + 0x10);
  if (*(uint *)(lVar9 + 0x18) <= param_3) {
    func_0x0001003316f4(0xcc,_UNK_1036edca8);
                    /* WARNING: Does not return */
    pcVar6 = (code *)SoftwareBreakpoint(1,0x1020a7a3c);
    (*pcVar6)();
  }
  lVar9 = *(long *)(lVar9 + (long)(int)param_3 * 8 + 0x20);
  uVar8 = _UNK_1036edc90;
  if ((lVar9 != 0) && (uVar8 = _UNK_1036edc98, (undefined4 *)(lVar9 + 0x38) != (undefined4 *)0x0)) {
    uVar10 = *puRam00000001038d53d0;
    func_0x00010034ede4(&uStack_78,*(undefined4 *)(lVar9 + 0x38),*(undefined4 *)(lVar9 + 0x3c),0xa0,
                        *(undefined4 *)(lVar9 + 0x44));
    iVar1 = (int)uStack_70 + (int)uStack_80 * -4;
    iVar2 = uStack_70._4_4_ + uStack_80._4_4_ * -4;
    if (iVar1 < 0) {
      iVar1 = iVar1 + 1;
    }
    if (iVar2 < 0) {
      iVar2 = iVar2 + 1;
    }
    func_0x00010034ede4(&uStack_68,(int)uStack_78 + (iVar1 >> 1),uStack_78._4_4_ + (iVar2 >> 1));
    uVar5 = uStack_60;
    uVar4 = uStack_68;
    uStack_4c = (undefined4)uStack_80;
    uStack_48 = (undefined4)((ulong)uStack_80 >> 0x20);
    uStack_54 = (undefined4)uStack_88;
    uStack_50 = (undefined4)((ulong)uStack_88 >> 0x20);
    uStack_58 = 1;
    uStack_98 = CONCAT44(uStack_4c,uStack_50);
    uStack_a0 = CONCAT44(uStack_54,1);
    uStack_90 = uStack_48;
    uVar7 = func_0x000100331988();
    uVar8 = _UNK_1036edca0;
    if (param_2 != 0) {
      func_0x000100356120(param_2,uVar10,uVar4,uVar5,&uStack_a0,uVar7);
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
  pcVar6 = (code *)SoftwareBreakpoint(1,0x1020a7a68);
  (*pcVar6)();
}

