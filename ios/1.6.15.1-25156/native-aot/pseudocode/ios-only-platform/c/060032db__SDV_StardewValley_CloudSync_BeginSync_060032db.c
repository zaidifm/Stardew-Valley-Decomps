/* 0x060032db StardewValley.CloudSync.BeginSync @ 0x10179d84c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync_BeginSync_060032db(long param_1,char param_2)

{
  long lVar1;
  undefined8 uVar2;
  undefined8 uVar3;
  char cVar4;
  code *pcVar5;
  int iVar6;
  long lVar7;
  long lVar8;
  undefined8 uVar9;
  long *plVar10;
  char cStack_49;
  long lStack_48;
  
  cVar4 = cRam000000010390e0ea;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_1032d3aab);
    cRam000000010390e0ea = '\x01';
  }
  uVar9 = *(undefined8 *)(param_1 + 0x10);
  cStack_49 = '\0';
  iVar6 = func_0x000100331adc(uVar9,&cStack_49);
  if (iVar6 == 0) {
    func_0x000100331bb8(uVar9,&cStack_49);
  }
  if (*(long *)(param_1 + 0x18) != 0) {
    DataMemoryBarrier(2,1);
    if ((*(uint *)(*(long *)(param_1 + 0x18) + 0x3c) >> 0x15 & 1) == 0) {
      iVar6 = 3;
      goto LAB_10179d8f8;
    }
    *(undefined8 *)(param_1 + 0x18) = 0;
  }
  *(undefined1 *)(param_1 + 0x3c) = 0;
  *(undefined4 *)(param_1 + 0x38) = 0;
  if (*(char *)(param_1 + 0x3d) == '\0') {
    *(bool *)(param_1 + 0x3e) = param_2 == '\0';
    lVar7 = func_0x000100331820(uRam00000001038d3b88,0x80);
    lVar1 = lRam00000001038c4be0;
    DataMemoryBarrier(2,3);
    *(long *)(lVar7 + 0x20) = param_1;
    *(undefined1 *)(((ulong)(lVar7 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
    uVar3 = uRam00000001038df760;
    lVar8 = lRam00000001038df758;
    uVar2 = uRam00000001038d5518;
    *(long *)(lVar7 + 0x40) = lRam00000001038df758;
    *(undefined8 *)(lVar7 + 0x28) = uVar3;
    *(undefined8 *)(lVar7 + 0x18) = *(undefined8 *)(lVar8 + 0x30);
    *(undefined8 *)(lVar7 + 0x10) = *(undefined8 *)(lVar8 + 0x28);
    lVar8 = func_0x000100331820(uVar2,0x40);
    func_0x000100351b84(lVar8,lVar7);
    DataMemoryBarrier(2,3);
    plVar10 = (long *)(param_1 + 0x18);
    *plVar10 = lVar8;
    *(undefined1 *)(((ulong)plVar10 >> 9 & 0x7fffff) + lVar1) = 1;
    if (*plVar10 == 0) {
      func_0x0001003316f4(0xee,_UNK_1035f5468);
                    /* WARNING: Does not return */
      pcVar5 = (code *)SoftwareBreakpoint(1,0x10179da14);
      (*pcVar5)();
    }
    func_0x000100357778();
    iVar6 = 1;
  }
  else {
    iVar6 = 2;
  }
LAB_10179d8f8:
  lStack_48 = 0;
  if (cStack_49 != '\0') {
    func_0x000100331c1c(uVar9);
  }
  if (((iVar6 != 1) && (iVar6 != 2)) && (iVar6 != 3)) {
    func_0x000100331c30();
                    /* WARNING: Does not return */
    pcVar5 = (code *)SoftwareBreakpoint(1,0x10179da50);
    (*pcVar5)();
  }
  if (lStack_48 != 0) {
    func_0x000100331ba4();
  }
  return;
}

