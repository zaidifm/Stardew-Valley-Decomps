/* 0x06006770 StardewValley.iOS.AppDelegate.ContinueUserActivity @ 0x101fd8d90 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1
SDV_StardewValley_iOS_AppDelegate_ContinueUserActivity_06006770
          (undefined8 param_1,undefined8 param_2,long param_3)

{
  code *pcVar1;
  char cVar2;
  int iVar3;
  long *plVar4;
  long lVar5;
  undefined8 uVar6;
  undefined8 uVar7;
  undefined1 uVar8;
  undefined1 uStack_52;
  undefined1 uStack_51;
  char cStack_41;
  long lStack_40;
  
  cVar2 = cRam000000010391157f;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325ef0);
    cRam000000010391157f = '\x01';
  }
  cStack_41 = '\0';
  if (*plRam0000000103904b90 == 0) {
    plVar4 = (long *)func_0x00010037e6ac();
    lVar5 = (**(code **)(*plVar4 + 0x60))();
    DataMemoryBarrier(2,3);
    *plRam0000000103904b90 = lVar5;
  }
  if (param_3 == 0) {
    func_0x0001003316f4(0xee,_UNK_1036d9590);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd9068);
    (*pcVar1)();
  }
  uVar6 = func_0x00010037e648(param_3);
  cVar2 = func_0x00010035011c(uVar6,*plRam0000000103904b90);
  if (cVar2 != '\0') {
    return 0;
  }
  plVar4 = (long *)func_0x00010037e65c(param_3);
  if (plVar4 == (long *)0x0) {
LAB_101fd9034:
    func_0x0001003316f4(0xee,_UNK_1036d9598);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd9048);
    (*pcVar1)();
  }
  uVar6 = (**(code **)(*plVar4 + 0x60))();
  uVar7 = func_0x000100331820(uRam0000000103904b98,0x38);
  func_0x00010037e670(uVar7,uVar6);
  func_0x00010037e684(uVar7);
  plVar4 = (long *)func_0x00010037e698();
  if (plVar4 == (long *)0x0) goto LAB_101fd9034;
  lVar5 = (**(code **)(*plVar4 + 0xf0))(plVar4,uRam00000001038e0ea0);
  if (lVar5 == 0) {
    return 0;
  }
  if (*(int *)(lVar5 + 0x10) == 0) {
    return 0;
  }
  cVar2 = func_0x000100357df4(lVar5,uRam0000000103904ba0);
  if (cVar2 == '\0') {
    return 0;
  }
  uVar6 = func_0x0001003562c4(lVar5,*(int *)(lRam0000000103904ba8 + 0x10) + 1);
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0(lRam00000001038c4c88);
  }
  cStack_41 = '\0';
  uVar7 = *puRam00000001038d5478;
  iVar3 = func_0x000100331adc(uVar7,&cStack_41);
  if (iVar3 == 0) {
    func_0x000100331bb8(uVar7,&cStack_41);
  }
  cVar2 = func_0x000100345aa0(uVar6,uRam0000000103904bb0);
  if (cVar2 == '\0') {
    cVar2 = func_0x000100345aa0(uVar6,uRam0000000103904bb8);
    if (cVar2 == '\0') {
      iVar3 = 2;
      goto LAB_101fd8f68;
    }
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar8 = 0;
  }
  else {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar8 = 1;
  }
  *puRam00000001038d5480 = uVar8;
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  iVar3 = 1;
  *puRam00000001038d5488 = 1;
LAB_101fd8f68:
  uStack_51 = 0;
  lStack_40 = 0;
  if (cStack_41 != '\0') {
    func_0x000100331c1c(uVar7);
  }
  if (iVar3 == 1) {
    if (lStack_40 != 0) {
      func_0x000100331ba4();
    }
    uStack_52 = 1;
  }
  else {
    if (iVar3 != 2) {
      func_0x000100331c30();
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd9070);
      (*pcVar1)();
    }
    uStack_52 = uStack_51;
    if (lStack_40 != 0) {
      func_0x000100331ba4();
    }
  }
  return uStack_52;
}

