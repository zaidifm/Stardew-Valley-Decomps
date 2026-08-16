/* 0x060066a9 StardewValley.Mobile.TapToMove.TappedOnFarmer @ 0x101fb96b8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_TappedOnFarmer_060066a9
               (undefined8 param_1,undefined4 param_2,undefined4 param_3)

{
  code *pcVar1;
  long lVar2;
  undefined8 uVar3;
  float fVar4;
  float fVar5;
  undefined8 uStack_60;
  undefined8 uStack_58;
  undefined8 uStack_50;
  undefined8 uStack_48;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  lVar2 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar3 = _UNK_1036d4640;
  if (*(long *)(lVar2 + 0x20) != 0) {
    fVar4 = (float)func_0x000101b4d600();
    lVar2 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar3 = _UNK_1036d4650;
    if (*(long *)(lVar2 + 0x20) != 0) {
      fVar5 = (float)func_0x000101b4d714();
      uStack_50 = 0;
      uStack_48 = 0;
      func_0x00010034ede4(&uStack_50,(int)fVar4,(int)fVar5 + -0x55,0x40,0x7d);
      uStack_58 = uStack_48;
      uStack_60 = uStack_50;
      func_0x000100356238(&uStack_60,param_2,param_3);
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fb979c);
  (*pcVar1)();
}

