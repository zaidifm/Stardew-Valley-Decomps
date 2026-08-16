/* 0x060032d6 StardewValley.CloudSync.get_SyncMenu @ 0x10179d4e8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_CloudSync_get_SyncMenu_060032d6(long param_1)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  long *plVar4;
  
  cVar2 = cRam000000010390e0e5;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1032d3a9d);
    cRam000000010390e0e5 = '\x01';
  }
  cVar2 = SDV_StardewValley_CloudSync_get_IsSyncing_060032d7(param_1);
  if (cVar2 == '\0') {
    if (param_1 == 0) {
      func_0x0001003316f4(0xee,_UNK_1035f5438);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x10179d5d4);
      (*pcVar1)();
    }
    lVar3 = 0;
    *(undefined8 *)(param_1 + 0x20) = 0;
  }
  else {
    lVar3 = *(long *)(param_1 + 0x20);
    if (lVar3 == 0) {
      if (*(char *)(param_1 + 0x3e) == '\0') {
        lVar3 = 0;
      }
      else {
        lVar3 = func_0x000100331820(uRam00000001038df738,0x70);
        SDV_StardewValley_Menus_CloudSyncMenu__ctor_06006023();
        DataMemoryBarrier(2,3);
        plVar4 = (long *)(param_1 + 0x20);
        *plVar4 = lVar3;
        *(undefined1 *)(((ulong)plVar4 >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
        lVar3 = *plVar4;
      }
    }
  }
  return lVar3;
}

