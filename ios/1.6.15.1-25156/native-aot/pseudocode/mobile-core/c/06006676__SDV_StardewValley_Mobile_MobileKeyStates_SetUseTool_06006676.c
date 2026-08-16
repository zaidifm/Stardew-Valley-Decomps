/* 0x06006676 StardewValley.Mobile.MobileKeyStates.SetUseTool @ 0x101fafd6c */

void SDV_StardewValley_Mobile_MobileKeyStates_SetUseTool_06006676(long param_1,char param_2)

{
  undefined1 uVar1;
  
  if (param_2 == '\0') {
    uVar1 = *(undefined1 *)(param_1 + 0x17);
    *(undefined1 *)(param_1 + 0x15) = 0;
  }
  else {
    uVar1 = 0;
    *(bool *)(param_1 + 0x15) = *(char *)(param_1 + 0x17) == '\0';
  }
  *(undefined1 *)(param_1 + 0x16) = uVar1;
  *(char *)(param_1 + 0x17) = param_2;
  return;
}

