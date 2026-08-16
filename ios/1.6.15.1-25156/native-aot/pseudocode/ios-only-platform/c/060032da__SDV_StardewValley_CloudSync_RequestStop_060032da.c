/* 0x060032da StardewValley.CloudSync.RequestStop @ 0x10179d770 */

void SDV_StardewValley_CloudSync_RequestStop_060032da(long param_1)

{
  code *pcVar1;
  int iVar2;
  undefined8 uVar3;
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
  if (*(long *)(param_1 + 0x18) == 0) {
    iVar2 = 2;
  }
  else {
    iVar2 = 1;
    *(undefined1 *)(param_1 + 0x3c) = 1;
  }
  lStack_28 = 0;
  if (cStack_29 != '\0') {
    func_0x000100331c1c(uVar3);
  }
  if ((iVar2 != 1) && (iVar2 != 2)) {
    func_0x000100331c30();
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x10179d83c);
    (*pcVar1)();
  }
  if (lStack_28 != 0) {
    func_0x000100331ba4();
  }
  return;
}

