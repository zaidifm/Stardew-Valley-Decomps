/* 0x06006675 StardewValley.Mobile.MobileKeyStates.SetRight @ 0x101fafd10 */

void SDV_StardewValley_Mobile_MobileKeyStates_SetRight_06006675(long param_1,char param_2)

{
  undefined1 uVar1;
  
  if (param_2 == '\0') {
    uVar1 = *(undefined1 *)(param_1 + 0x22);
    *(undefined1 *)(param_1 + 0x1c) = 0;
  }
  else {
    uVar1 = 0;
    *(bool *)(param_1 + 0x1c) = *(char *)(param_1 + 0x22) == '\0';
  }
  *(undefined1 *)(param_1 + 0x1e) = uVar1;
  *(char *)(param_1 + 0x22) = param_2;
  return;
}

