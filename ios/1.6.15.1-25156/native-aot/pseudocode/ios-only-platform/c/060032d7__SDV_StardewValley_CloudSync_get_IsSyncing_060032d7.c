/* 0x060032d7 StardewValley.CloudSync.get_IsSyncing @ 0x10179d5d4 */

/* WARNING: Removing unreachable block (ram,0x00010179d6a4) */

byte SDV_StardewValley_CloudSync_get_IsSyncing_060032d7(long param_1)

{
  int iVar1;
  undefined8 uVar2;
  char cStack_2a;
  byte bStack_29;
  long lStack_28;
  
  bStack_29 = 0;
  if (lRam0000000103976fb8 == 0) {
    uVar2 = *(undefined8 *)(param_1 + 0x10);
  }
  else {
    func_0x00010119b8f8();
    uVar2 = *(undefined8 *)(param_1 + 0x10);
  }
  cStack_2a = '\0';
  iVar1 = func_0x000100331adc(uVar2,&cStack_2a);
  if (iVar1 == 0) {
    func_0x000100331bb8(uVar2,&cStack_2a);
  }
  bStack_29 = 0;
  if (*(long *)(param_1 + 0x18) != 0) {
    DataMemoryBarrier(2,1);
    bStack_29 = ((byte)(*(uint *)(*(long *)(param_1 + 0x18) + 0x3c) >> 0x15) ^ 0xff) & 1;
  }
  lStack_28 = 0;
  if (cStack_2a != '\0') {
    func_0x000100331c1c(uVar2);
  }
  if (lStack_28 != 0) {
    func_0x000100331ba4();
  }
  return bStack_29;
}

