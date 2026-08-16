/* 0x06006718 StardewValley.Mobile.TapToMoveUtils.FetchFarmAnimal @ 0x101fcf87c */

/* WARNING: Removing unreachable block (ram,0x000101fcfa40) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_Mobile_TapToMoveUtils_FetchFarmAnimal_06006718
               (long param_1,undefined4 param_2,undefined4 param_3)

{
  code *pcVar1;
  char cVar2;
  undefined8 uVar3;
  int iVar4;
  long lVar5;
  long lVar6;
  undefined1 auVar7 [16];
  long lStack_c8;
  undefined8 uStack_c0;
  undefined8 uStack_b8;
  undefined8 uStack_b0;
  undefined8 uStack_a8;
  undefined8 uStack_a0;
  undefined8 uStack_98;
  long lStack_90;
  undefined8 uStack_88;
  long lStack_78;
  undefined1 auStack_70 [16];
  undefined8 uStack_58;
  long lStack_50;
  undefined8 *puStack_48;
  
  cVar2 = cRam0000000103911527;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325b41);
    cRam0000000103911527 = '\x01';
  }
  lStack_78 = 0;
  auStack_70._0_8_ = 0;
  auStack_70._8_8_ = 0;
  auVar7 = ZEXT816(0);
  lStack_c8 = 0;
  uStack_b8 = 0;
  uStack_c0 = 0;
  uStack_a8 = 0;
  uStack_b0 = 0;
  uStack_98 = 0;
  uStack_a0 = 0;
  uStack_88 = 0;
  lStack_90 = 0;
  lVar5 = *(long *)(param_1 + 0x28);
  uVar3 = _UNK_1036d7ff8;
  if (lVar5 != 0) {
    DataMemoryBarrier(2,3);
    *(undefined1 *)(((ulong)&lStack_50 >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    lStack_78 = lVar5;
    lStack_50 = lVar5;
    func_0x00010035aff4(&uStack_c0,&lStack_78);
    while( true ) {
      cVar2 = func_0x00010035b008(&uStack_c0);
      lVar5 = lStack_90;
      if (cVar2 == '\0') break;
      if ((lStack_90 == 0) || (*(long *)(lStack_90 + 0x1f0) == 0)) {
LAB_101fcf9a0:
        func_0x0001003316f4(0xee,_UNK_1036d8008);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcf9b4);
        (*pcVar1)();
      }
      if ((*(char *)(*(long *)(lStack_90 + 0x1f0) + 0x68) == '\0') || (lStack_c8 == 0)) {
        auVar7 = func_0x000101827f34(lStack_90);
        auStack_70 = auVar7;
        cVar2 = func_0x000100356238(auStack_70,param_2,param_3);
        if (cVar2 != '\0') {
          lStack_c8 = lVar5;
          lVar6 = *(long *)(lVar5 + 0x1f0);
          if (lVar6 == 0) goto LAB_101fcf9a0;
          if (*(char *)(lVar6 + 0x68) == '\0') {
            iVar4 = 1;
            goto LAB_101fcfa18;
          }
        }
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
    }
    iVar4 = 2;
LAB_101fcfa18:
    uStack_58 = 0;
    puStack_48 = &uStack_c0;
    if (puStack_48 != (undefined8 *)0x0) {
      if ((iVar4 != 1) && (iVar4 != 2)) {
        func_0x000100331c30();
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcfa7c);
        (*pcVar1)();
      }
      return lStack_c8;
    }
    puStack_48 = (undefined8 *)0x0;
    uVar3 = _UNK_1036d8000;
    auVar7 = auStack_70;
  }
  auStack_70 = auVar7;
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcfa14);
  (*pcVar1)();
}

