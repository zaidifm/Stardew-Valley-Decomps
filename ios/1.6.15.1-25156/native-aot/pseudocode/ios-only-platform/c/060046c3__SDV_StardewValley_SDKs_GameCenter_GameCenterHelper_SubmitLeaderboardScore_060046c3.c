/* 0x060046c3 StardewValley.SDKs.GameCenter.GameCenterHelper.SubmitLeaderboardScore @ 0x1000db900 */

void SDV_StardewValley_SDKs_GameCenter_GameCenterHelper_SubmitLeaderboardScore_060046c3
               (undefined8 param_1,long param_2,int param_3)

{
  undefined8 uVar1;
  
  if (*plRam00000001037fff88 != 0) {
    func_0x0001003316e0();
  }
  if (param_2 != 0) {
    uVar1 = func_0x0001003323d8(uRam0000000103802d58,param_2);
    uVar1 = func_0x000100369d60(uVar1);
    func_0x000100384174(uVar1,(long)param_3);
    func_0x000100384188(uVar1);
  }
  return;
}

