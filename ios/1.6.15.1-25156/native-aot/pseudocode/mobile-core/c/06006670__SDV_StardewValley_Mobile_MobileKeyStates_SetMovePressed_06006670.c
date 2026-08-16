/* 0x06006670 StardewValley.Mobile.MobileKeyStates.SetMovePressed @ 0x101fafa9c */

void SDV_StardewValley_Mobile_MobileKeyStates_SetMovePressed_06006670(long param_1,int param_2)

{
  ulong uVar1;
  ulong uVar2;
  ulong uVar3;
  ulong uVar4;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (param_2 - 1U < 8) {
    uVar2 = (ulong)(param_2 - 1U) << 3;
    uVar1 = 0x10100000001 >> (uVar2 & 0x38);
    uVar4 = 0x101000000000100 >> (uVar2 & 0x38);
    uVar3 = 0x1000100010000 >> (uVar2 & 0x38);
    uVar2 = 0x100010001000000 >> (uVar2 & 0x38);
  }
  else {
    uVar1 = 0;
    uVar4 = 0;
    uVar3 = 0;
    uVar2 = 0;
  }
  SDV_StardewValley_Mobile_MobileKeyStates_SetUp_06006672(param_1,uVar1);
  SDV_StardewValley_Mobile_MobileKeyStates_SetDown_06006673(param_1,uVar4 & 0xffffffff);
  SDV_StardewValley_Mobile_MobileKeyStates_SetLeft_06006674(param_1,uVar3 & 0xffffffff);
  SDV_StardewValley_Mobile_MobileKeyStates_SetRight_06006675(param_1,uVar2 & 0xffffffff);
  *(int *)(param_1 + 0x10) = param_2;
  return;
}

