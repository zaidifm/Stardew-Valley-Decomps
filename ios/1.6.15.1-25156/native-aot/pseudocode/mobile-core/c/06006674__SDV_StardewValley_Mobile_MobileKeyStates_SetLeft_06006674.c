/* 0x06006674 StardewValley.Mobile.MobileKeyStates.SetLeft @ 0x101fafcb4 */

void SDV_StardewValley_Mobile_MobileKeyStates_SetLeft_06006674(long param_1,char param_2)

{
  undefined1 uVar1;
  
  if (param_2 == '\0') {
    uVar1 = *(undefined1 *)(param_1 + 0x24);
    *(undefined1 *)(param_1 + 0x1b) = 0;
  }
  else {
    uVar1 = 0;
    *(bool *)(param_1 + 0x1b) = *(char *)(param_1 + 0x24) == '\0';
  }
  *(undefined1 *)(param_1 + 0x20) = uVar1;
  *(char *)(param_1 + 0x24) = param_2;
  return;
}

