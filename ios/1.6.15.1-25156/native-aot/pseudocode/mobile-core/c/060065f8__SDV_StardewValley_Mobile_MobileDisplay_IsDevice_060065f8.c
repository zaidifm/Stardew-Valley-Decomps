/* 0x060065f8 StardewValley.Mobile.MobileDisplay.IsDevice @ 0x101fa10e4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Mobile_MobileDisplay_IsDevice_060065f8(long param_1,long param_2)

{
  undefined4 uVar1;
  char cVar2;
  code *pcVar3;
  int iVar4;
  ulong uVar5;
  undefined4 *puVar6;
  undefined8 uStack_70;
  long lStack_68;
  undefined8 uStack_60;
  undefined8 uStack_58;
  
  cVar2 = cRam0000000103911407;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103324890);
    cRam0000000103911407 = '\x01';
  }
  lStack_68 = 0;
  uStack_70 = 0;
  uStack_58 = 0;
  uStack_60 = 0;
  uVar5 = (ulong)*(uint *)(param_2 + 0x18);
  if (0 < (int)*(uint *)(param_2 + 0x18)) {
    puVar6 = (undefined4 *)(param_2 + 0x20);
    do {
      uVar1 = *puVar6;
      if (*(char *)(lRam00000001038d7890 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      if (*plRam00000001039044e0 == 0) {
        func_0x0001003316f4(0xee,_UNK_1036d1658);
                    /* WARNING: Does not return */
        pcVar3 = (code *)SoftwareBreakpoint(1,0x101fa1224);
        (*pcVar3)();
      }
      func_0x00010037cfa0(&uStack_70,*plRam00000001039044e0,uVar1);
      if ((((param_1 != 0) && (*(int *)(param_1 + 0x10) != 0)) && (lStack_68 != 0)) &&
         ((*(int *)(lStack_68 + 0x10) != 0 &&
          (iVar4 = func_0x000100374fd0(lStack_68,param_1,5), iVar4 != -1)))) {
        return 1;
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      puVar6 = puVar6 + 1;
      uVar5 = uVar5 - 1;
    } while (uVar5 != 0);
  }
  return 0;
}

