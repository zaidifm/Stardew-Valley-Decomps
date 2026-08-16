/* 0x06006712 StardewValley.Mobile.TapToMoveUtils.FetchNextPointOut @ 0x101fcea50 */

undefined8
SDV_StardewValley_Mobile_TapToMoveUtils_FetchNextPointOut_06006712
          (int param_1,int param_2,int param_3,int param_4)

{
  uint uVar1;
  uint uVar2;
  
  uVar1 = (uint)(param_3 < param_1);
  if (param_1 < param_3) {
    uVar1 = 0xffffffff;
  }
  uVar2 = (uint)(param_4 < param_2);
  if (param_2 < param_4) {
    uVar2 = 0xffffffff;
  }
  return CONCAT44(uVar2 + param_4,uVar1 + param_3);
}

