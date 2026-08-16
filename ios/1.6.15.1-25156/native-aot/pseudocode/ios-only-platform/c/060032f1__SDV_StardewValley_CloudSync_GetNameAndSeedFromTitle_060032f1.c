/* 0x060032f1 StardewValley.CloudSync.GetNameAndSeedFromTitle @ 0x1017a01ec */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_CloudSync_GetNameAndSeedFromTitle_060032f1
          (long param_1,undefined8 *param_2,undefined4 *param_3)

{
  long lVar1;
  code *pcVar2;
  char cVar3;
  int iVar4;
  undefined8 uVar5;
  
  cVar3 = cRam000000010390e100;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_1032d3bf5);
    cRam000000010390e100 = '\x01';
  }
  DataMemoryBarrier(2,3);
  *param_2 = 0;
  *param_3 = 0;
  if (param_1 != 0) {
    iVar4 = func_0x0001003571c4(param_1 + 0x14,0x5f,*(undefined4 *)(param_1 + 0x10));
    if (-1 < iVar4) {
      uVar5 = func_0x0001003562c4(param_1,iVar4 + 1);
      cVar3 = func_0x000100352138(uVar5,param_3);
      if (cVar3 != '\0') {
        uVar5 = func_0x00010035629c(param_1,0,iVar4);
        lVar1 = lRam00000001038c4be0;
        DataMemoryBarrier(2,3);
        *param_2 = uVar5;
        *(undefined1 *)(((ulong)param_2 >> 9 & 0x7fffff) + lVar1) = 1;
        return 1;
      }
    }
    return 0;
  }
  func_0x0001003316f4(0xee,_UNK_1035f5708);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x1017a0308);
  (*pcVar2)();
}

