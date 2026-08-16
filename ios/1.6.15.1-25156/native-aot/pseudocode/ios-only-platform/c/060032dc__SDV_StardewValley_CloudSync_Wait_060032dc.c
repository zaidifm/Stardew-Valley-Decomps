/* 0x060032dc StardewValley.CloudSync.Wait @ 0x10179da5c */

/* WARNING: Removing unreachable block (ram,0x00010179db18) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync_Wait_060032dc(long param_1)

{
  code *pcVar1;
  int iVar2;
  undefined8 uVar3;
  long lVar4;
  char cStack_29;
  long lStack_28;
  
  if (lRam0000000103976fb8 == 0) {
    uVar3 = *(undefined8 *)(param_1 + 0x10);
  }
  else {
    func_0x00010119b8f8();
    uVar3 = *(undefined8 *)(param_1 + 0x10);
  }
  cStack_29 = '\0';
  iVar2 = func_0x000100331adc(uVar3,&cStack_29);
  if (iVar2 == 0) {
    func_0x000100331bb8(uVar3,&cStack_29);
  }
  lVar4 = *(long *)(param_1 + 0x18);
  lStack_28 = 0;
  if (cStack_29 != '\0') {
    func_0x000100331c1c(uVar3);
  }
  if (lStack_28 != 0) {
    func_0x000100331ba4();
  }
  if (lVar4 != 0) {
    if (lVar4 == 0) {
      func_0x0001003316f4(0xee,_UNK_1035f5480);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x10179db34);
      (*pcVar1)();
    }
    func_0x00010035778c();
  }
  return;
}

