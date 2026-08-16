/* 0x0600673e StardewValley.Mobile.VirtualJoypad.SetButtonADefaults @ 0x101fd2edc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_SetButtonADefaults_0600673e(long param_1)

{
  int iVar1;
  char cVar2;
  code *pcVar3;
  int iVar4;
  undefined8 uVar5;
  long lVar6;
  undefined8 uVar7;
  
  cVar2 = cRam000000010391154d;
  lVar6 = param_1;
  if (lRam0000000103976fb8 != 0) {
    lVar6 = func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    lVar6 = func_0x00010119b908(&UNK_103325d0b);
    cRam000000010391154d = '\x01';
  }
  SDV_StardewValley_Mobile_VirtualJoypad_set_sizeButtonA_06006727(lVar6,0x6f);
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar7 = _UNK_1036d8558;
  if ((lRam00000001038d6bc0 != -8) && (uVar7 = _UNK_1036d8550, lRam00000001038d6bc0 != 0)) {
    iVar1 = *(int *)(lRam00000001038d6bc0 + 8);
    iVar4 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonB_06006728();
    uVar5 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonA_06006726();
    uVar7 = _UNK_1036d8560;
    if ((param_1 != 0) && (uVar7 = _UNK_1036d8568, param_1 != -0xe0)) {
      SDV_StardewValley_Mobile_VirtualJoypad_SetPositionButtonA_0600672f
                (uVar5,(iVar1 - (iVar4 + (int)uVar5)) + -0xbc,*(undefined4 *)(param_1 + 0xe4));
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fd2fd4);
  (*pcVar3)();
}

