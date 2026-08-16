/* 0x060032d8 StardewValley.CloudSync.get_Progress @ 0x10179d6bc */

int SDV_StardewValley_CloudSync_get_Progress_060032d8(long param_1)

{
  char cVar1;
  int iVar2;
  float fVar3;
  
  cVar1 = cRam000000010390e0e7;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1032d3aa4);
    cRam000000010390e0e7 = '\x01';
    fVar3 = *(float *)(param_1 + 0x38);
  }
  else {
    fVar3 = *(float *)(param_1 + 0x38);
  }
  iVar2 = (int)fVar3;
  if (99 < iVar2) {
    iVar2 = 100;
  }
  if (iVar2 < 1) {
    iVar2 = 0;
  }
  return iVar2;
}

