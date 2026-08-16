/* 0x06006672 StardewValley.Mobile.MobileKeyStates.SetUp @ 0x101fafbfc */

void SDV_StardewValley_Mobile_MobileKeyStates_SetUp_06006672(long param_1,char param_2)

{
  undefined1 uVar1;
  
  if (param_2 == '\0') {
    uVar1 = *(undefined1 *)(param_1 + 0x21);
    *(undefined1 *)(param_1 + 0x19) = 0;
  }
  else {
    uVar1 = 0;
    *(bool *)(param_1 + 0x19) = *(char *)(param_1 + 0x21) == '\0';
  }
  *(undefined1 *)(param_1 + 0x1d) = uVar1;
  *(char *)(param_1 + 0x21) = param_2;
  return;
}

