/* 0x06006926 StardewValley.CloudSync+<>c__DisplayClass29_0.<ShowConflictBox>b__2 @ 0x101fefd50 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync___c__DisplayClass29_0__ShowConflictBox_b__2_06006926(long param_1)

{
  code *pcVar1;
  long lVar2;
  
  if (lRam0000000103976fb8 == 0) {
    lVar2 = *(long *)(param_1 + 0x20);
  }
  else {
    func_0x00010119b8f8();
    lVar2 = *(long *)(param_1 + 0x20);
  }
  *(undefined8 *)(param_1 + 0x10) = 0;
  if (lVar2 != 0) {
    func_0x00010037f098();
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036dbb98);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fefdb4);
  (*pcVar1)();
}

