/* 0x0600692b StardewValley.CloudSync+<>c__DisplayClass35_0.<UploadToCloud>b__0 @ 0x101feff80 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync___c__DisplayClass35_0__UploadToCloud_b__0_0600692b
               (long param_1,undefined8 param_2)

{
  code *pcVar1;
  
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x18U) = param_2;
    *(undefined1 *)((param_1 + 0x18U >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036dbbe0);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101feffc0);
  (*pcVar1)();
}

