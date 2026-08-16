/* 0x060032ec StardewValley.CloudSync.QureryCloudSaves @ 0x10179fab0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1
SDV_StardewValley_CloudSync_QureryCloudSaves_060032ec(undefined8 param_1,undefined8 *param_2)

{
  long lVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  long lVar5;
  undefined8 uVar6;
  undefined8 uVar7;
  undefined8 uVar8;
  long lVar9;
  long lVar10;
  undefined1 uVar11;
  long lVar12;
  long lStack_68;
  undefined8 uStack_60;
  undefined8 uStack_58;
  
  cVar2 = cRam000000010390e0fb;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1032d3bb0);
    cRam000000010390e0fb = '\x01';
  }
  lStack_68 = 0;
  uStack_60 = 0;
  uStack_58 = 0;
  lVar4 = func_0x000100331820(uRam00000001038df8b8,0x20);
  lVar5 = func_0x000100331820(uRam00000001038df7f0,0x20);
  lVar1 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar5 + 0x10) = *puRam00000001038df7f8;
  *(undefined1 *)(((ulong)(lVar5 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
  uVar6 = _UNK_1035f5678;
  if (lVar4 == 0) {
LAB_10179fe30:
    func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
    pcVar3 = (code *)SoftwareBreakpoint(1,0x10179fe3c);
    (*pcVar3)();
  }
  DataMemoryBarrier(2,3);
  *(long *)(lVar4 + 0x10) = lVar5;
  *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
  DataMemoryBarrier(2,3);
  *param_2 = 0;
  uVar6 = _UNK_1035f5688;
  if (lVar4 == 0) goto LAB_10179fe30;
  *(undefined1 *)(lVar4 + 0x18) = 0;
  lVar5 = func_0x000100331820(uRam00000001038df8c0,0x20);
  DataMemoryBarrier(2,3);
  *(long *)(lVar5 + 0x18) = lVar4;
  *(undefined1 *)(((ulong)(lVar5 + 0x18) >> 9 & 0x7fffff) + lVar1) = 1;
  SDV_StardewValley_CloudSync_GetDbAndZoneId_060032eb(&lStack_68,&uStack_60);
  uVar6 = func_0x000100331820(uRam00000001038df7a0,0x18);
  func_0x0001003577f0(uVar6,0);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar5 + 0x10) = uVar6;
  *(undefined1 *)(((ulong)(lVar5 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
  uVar7 = func_0x000100357aac(1);
  uVar6 = uRam00000001038df8c8;
  uVar8 = func_0x000100331870(uRam00000001038df8d0);
  func_0x000100357ac0(uVar8,uVar6,uVar7);
  lVar9 = func_0x000100331870(uRam00000001038df8d8);
  func_0x000100357ad4(lVar9,uVar8);
  uVar6 = func_0x000100331794(uRam00000001038c4f40,1);
  func_0x000100331f8c(uVar6,0,uRam00000001038df8e0);
  if (lVar9 != 0) {
    func_0x000100357ae8(lVar9,uVar6);
    func_0x000100357afc(lVar9,uStack_60);
    func_0x000100357b10(lVar9,100);
    func_0x000100357b24(lVar9,0x19);
    lVar12 = *(long *)(lVar5 + 0x18);
    if (lVar12 == 0) {
      uVar6 = 0x69;
      goto LAB_10179fddc;
    }
    lVar10 = func_0x000100331820(uRam00000001038df8e8,0x80);
    DataMemoryBarrier(2,3);
    *(long *)(lVar10 + 0x20U) = lVar12;
    *(undefined1 *)((lVar10 + 0x20U >> 9 & 0x7fffff) + lVar1) = 1;
    uVar6 = uRam00000001038df8f8;
    lVar12 = lRam00000001038df8f0;
    *(long *)(lVar10 + 0x40) = lRam00000001038df8f0;
    *(undefined8 *)(lVar10 + 0x28) = uVar6;
    *(undefined8 *)(lVar10 + 0x18) = *(undefined8 *)(lVar12 + 0x30);
    *(undefined8 *)(lVar10 + 0x10) = *(undefined8 *)(lVar12 + 0x28);
    func_0x000100357b38(lVar9);
    lVar10 = func_0x000100331820(uRam00000001038df900,0x80);
    DataMemoryBarrier(2,3);
    *(long *)(lVar10 + 0x20) = lVar5;
    *(undefined1 *)(((ulong)(lVar10 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
    uVar6 = uRam00000001038df910;
    lVar12 = lRam00000001038df908;
    *(long *)(lVar10 + 0x40) = lRam00000001038df908;
    *(undefined8 *)(lVar10 + 0x28) = uVar6;
    *(undefined8 *)(lVar10 + 0x18) = *(undefined8 *)(lVar12 + 0x30);
    *(undefined8 *)(lVar10 + 0x10) = *(undefined8 *)(lVar12 + 0x28);
    func_0x000100357b4c(lVar9);
    if ((lStack_68 != 0) && (func_0x000100357b60(lStack_68,lVar9), *(long *)(lVar5 + 0x10) != 0)) {
      func_0x000100357818();
      if (*(char *)(lVar4 + 0x18) == '\0') {
        DataMemoryBarrier(2,3);
        uVar6 = _UNK_1035f56a0;
        if (param_2 == (undefined8 *)0x0) goto LAB_10179fe30;
        uVar11 = 1;
        *param_2 = *(undefined8 *)(lVar4 + 0x10);
        *(undefined1 *)(((ulong)param_2 >> 9 & 0x7fffff) + lVar1) = 1;
      }
      else {
        uVar11 = 0;
      }
      return uVar11;
    }
  }
  uVar6 = 0xee;
LAB_10179fddc:
  func_0x0001003316f4(uVar6,_UNK_1035f56a8);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x10179fdec);
  (*pcVar3)();
}

