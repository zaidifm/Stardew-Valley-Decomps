/* 0x0600673f StardewValley.Mobile.VirtualJoypad.SetButtonBDefaults @ 0x101fd2fd4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_SetButtonBDefaults_0600673f(long param_1)

{
  int iVar1;
  char cVar2;
  code *pcVar3;
  undefined8 uVar4;
  long lVar5;
  undefined8 uVar6;
  
  cVar2 = cRam000000010391154e;
  lVar5 = param_1;
  if (lRam0000000103976fb8 != 0) {
    lVar5 = func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    lVar5 = func_0x00010119b908(&UNK_103325d13);
    cRam000000010391154e = '\x01';
  }
  SDV_StardewValley_Mobile_VirtualJoypad_set_sizeButtonB_06006729(lVar5,0x6f);
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar6 = _UNK_1036d8578;
  if ((lRam00000001038d6bc0 != -8) && (uVar6 = _UNK_1036d8570, lRam00000001038d6bc0 != 0)) {
    iVar1 = *(int *)(lRam00000001038d6bc0 + 8);
    uVar4 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonB_06006728();
    uVar6 = _UNK_1036d8580;
    if ((param_1 != 0) && (uVar6 = _UNK_1036d8588, param_1 != -0xe0)) {
      SDV_StardewValley_Mobile_VirtualJoypad_SetPositionButtonB_06006732
                (uVar4,(iVar1 - (int)uVar4) + -0x7c,*(undefined4 *)(param_1 + 0xe4));
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fd30c0);
  (*pcVar3)();
}

