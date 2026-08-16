/* 0x060032ee StardewValley.CloudSync.DeleteLocalSave @ 0x10179fec0 */

void SDV_StardewValley_CloudSync_DeleteLocalSave_060032ee(undefined8 param_1)

{
  char cVar1;
  undefined8 uStack_40;
  undefined8 uStack_38;
  undefined8 auStack_30 [2];
  
  cVar1 = cRam000000010390e0fd;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1032d3bd9);
    cRam000000010390e0fd = '\x01';
  }
  uStack_40 = 0;
  uStack_38 = 0;
  auStack_30[0] = 0;
  SDV_StardewValley_CloudSync_GetSaveInfoAndFarmer_060032ef
            (param_1,&uStack_40,&uStack_38,auStack_30);
  func_0x000100357944(uStack_38);
  func_0x000100357944(auStack_30[0]);
  SDV_StardewValley_CloudSync_DeleteSyncronizedState_060032e4(uStack_40);
  func_0x000100357b88(param_1);
  return;
}

