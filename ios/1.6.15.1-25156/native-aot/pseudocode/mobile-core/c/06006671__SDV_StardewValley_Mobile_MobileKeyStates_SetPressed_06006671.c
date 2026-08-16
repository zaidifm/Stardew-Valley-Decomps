/* 0x06006671 StardewValley.Mobile.MobileKeyStates.SetPressed @ 0x101fafb7c */

void SDV_StardewValley_Mobile_MobileKeyStates_SetPressed_06006671
               (undefined8 param_1,undefined4 param_2,undefined4 param_3,undefined4 param_4,
               undefined4 param_5)

{
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  SDV_StardewValley_Mobile_MobileKeyStates_SetUp_06006672(param_1,param_2);
  SDV_StardewValley_Mobile_MobileKeyStates_SetDown_06006673(param_1,param_3);
  SDV_StardewValley_Mobile_MobileKeyStates_SetLeft_06006674(param_1,param_4);
  SDV_StardewValley_Mobile_MobileKeyStates_SetRight_06006675(param_1,param_5);
  return;
}

