/* 0x06006673 StardewValley.Mobile.MobileKeyStates.SetDown @ 0x101fafc58 */

void SDV_StardewValley_Mobile_MobileKeyStates_SetDown_06006673(long param_1,char param_2)

{
  undefined1 uVar1;
  
  if (param_2 == '\0') {
    uVar1 = *(undefined1 *)(param_1 + 0x23);
    *(undefined1 *)(param_1 + 0x1a) = 0;
  }
  else {
    uVar1 = 0;
    *(bool *)(param_1 + 0x1a) = *(char *)(param_1 + 0x23) == '\0';
  }
  *(undefined1 *)(param_1 + 0x1f) = uVar1;
  *(char *)(param_1 + 0x23) = param_2;
  return;
}

