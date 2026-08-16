/* 0x0600742a StardewValley.iOS.AppDelegate+<>c__DisplayClass6_0.<DidEnterBackground>b__1 @ 0x1020b4b04 */

void SDV_StardewValley_iOS_AppDelegate_c_DisplayClass6_0_DidEnterBackground_b_1_0600742a
               (long param_1)

{
  long lVar1;
  undefined8 uVar2;
  
  if (lRam0000000103976fb8 == 0) {
    uVar2 = *(undefined8 *)(param_1 + 0x18);
    lVar1 = param_1;
  }
  else {
    lVar1 = func_0x00010119b8f8();
    uVar2 = *(undefined8 *)(param_1 + 0x18);
  }
  SDV_StardewValley_iOS_AppDelegate_FinishLongRunningTask_06006773(lVar1,uVar2);
  return;
}

