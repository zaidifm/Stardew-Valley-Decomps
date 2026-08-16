/* 0x060065f7 StardewValley.Mobile.MobileDisplay.iOS_LookupPpi @ 0x101fa0ef0 */

/* WARNING: Removing unreachable block (ram,0x000101fa1058) */
/* WARNING: Removing unreachable block (ram,0x000101fa103c) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined4 SDV_StardewValley_Mobile_MobileDisplay_iOS_LookupPpi_060065f7(long param_1)

{
  undefined4 uVar1;
  long lVar2;
  code *pcVar3;
  char cVar4;
  int iVar5;
  long lVar6;
  long lVar7;
  undefined8 uStack_80;
  undefined8 uStack_78;
  undefined8 uStack_70;
  long lStack_68;
  undefined8 uStack_60;
  undefined8 uStack_58;
  undefined4 uStack_44;
  undefined8 uStack_40;
  undefined8 *puStack_38;
  
  cVar4 = cRam0000000103911406;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103324870);
    cRam0000000103911406 = '\x01';
  }
  uStack_44 = 0;
  lStack_68 = 0;
  uStack_70 = 0;
  uStack_58 = 0;
  uStack_60 = 0;
  uStack_78 = 0;
  uStack_80 = 0;
  if (*(char *)(lRam00000001038d7890 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  lVar7 = *plRam00000001039044e0;
  if (*(long *)(lVar7 + 0x30) == 0) {
    lVar6 = func_0x000100331820(uRam0000000103904560,0x18);
    lVar2 = lRam00000001038c4be0;
    DataMemoryBarrier(2,3);
    *(long *)(lVar6 + 0x10U) = lVar7;
    *(undefined1 *)((lVar6 + 0x10U >> 9 & 0x7fffff) + lVar2) = 1;
    DataMemoryBarrier(2,3);
    *(long *)(lVar7 + 0x30) = lVar6;
    *(undefined1 *)(((ulong)(lVar7 + 0x30) >> 9 & 0x7fffff) + lVar2) = 1;
  }
  func_0x00010037d054(&uStack_80);
  do {
    cVar4 = func_0x00010037d068(&uStack_80);
    if (cVar4 == '\0') {
      iVar5 = 2;
LAB_101fa1018:
      uStack_40 = 0;
      puStack_38 = &uStack_80;
      if (puStack_38 == (undefined8 *)0x0) {
        func_0x0001003316f4(0xee,_UNK_1036d1648);
                    /* WARNING: Does not return */
        pcVar3 = (code *)SoftwareBreakpoint(1,0x101fa10d0);
        (*pcVar3)();
      }
      if (iVar5 != 1) {
        if (iVar5 != 2) {
          func_0x000100331c30();
                    /* WARNING: Does not return */
          pcVar3 = (code *)SoftwareBreakpoint(1,0x101fa10d8);
          (*pcVar3)();
        }
        uStack_44 = 300;
      }
      return uStack_44;
    }
    if (((((int)uStack_70 != 1) && (param_1 != 0)) && (*(int *)(param_1 + 0x10) != 0)) &&
       ((lStack_68 != 0 && (*(int *)(lStack_68 + 0x10) != 0)))) {
      uVar1 = (undefined4)uStack_58;
      iVar5 = func_0x000100374fd0(lStack_68,param_1,5);
      if (iVar5 != -1) {
        iVar5 = 1;
        uStack_44 = uVar1;
        goto LAB_101fa1018;
      }
    }
    if (lRam0000000103976fb8 != 0) {
      func_0x00010119b8f8();
    }
  } while( true );
}

