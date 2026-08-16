/* 0x06005d9c StardewValley.Menus.CoopGameMenu.readyToClose @ 0x101df68b0 */

bool SDV_StardewValley_Menus_CoopGameMenu_readyToClose_06005d9c(long param_1)

{
  char cVar1;
  bool bVar2;
  
  if (lRam0000000103976fb8 == 0) {
    cVar1 = *(char *)(param_1 + 0x1b0);
  }
  else {
    func_0x00010119b8f8();
    cVar1 = *(char *)(param_1 + 0x1b0);
  }
  if (cVar1 == '\0') {
    bVar2 = true;
  }
  else if ((((*(long *)(param_1 + 0xe0) == 0) && (*(long *)(param_1 + 0xe8) == 0)) &&
           (*(char *)(param_1 + 0x16c) == '\0')) && (*(char *)(param_1 + 0x16e) == '\0')) {
    bVar2 = 1 < *(int *)(param_1 + 0x170);
  }
  else {
    bVar2 = false;
  }
  return bVar2;
}

