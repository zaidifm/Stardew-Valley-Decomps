/* 0x06006931 StardewValley.CloudSync+<>c__DisplayClass38_0.<DownloadCloudSave>b__0 @ 0x101ff0374 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync___c__DisplayClass38_0__DownloadCloudSave_b__0_06006931
               (long param_1,undefined8 param_2)

{
  code *pcVar1;
  
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x10U) = param_2;
    *(undefined1 *)((param_1 + 0x10U >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036dbc78);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101ff03b4);
  (*pcVar1)();
}

