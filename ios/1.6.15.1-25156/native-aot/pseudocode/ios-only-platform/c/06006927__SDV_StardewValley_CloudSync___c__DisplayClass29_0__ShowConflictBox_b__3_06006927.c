/* 0x06006927 StardewValley.CloudSync+<>c__DisplayClass29_0.<ShowConflictBox>b__3 @ 0x101fefdb4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync___c__DisplayClass29_0__ShowConflictBox_b__3_06006927(long param_1)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  long lVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  
  cVar1 = cRam0000000103911736;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033270f0);
    cRam0000000103911736 = '\x01';
    lVar3 = func_0x0001003782fc();
  }
  else {
    lVar3 = func_0x0001003782fc();
  }
  uVar6 = _UNK_1036dbba0;
  if (((lVar3 != 0) && (lVar3 = func_0x00010037f0ac(), uVar6 = _UNK_1036dbba8, lVar3 != 0)) &&
     (lVar3 = func_0x00010037f0c0(), uVar6 = _UNK_1036dbbb0, param_1 != 0)) {
    lVar4 = func_0x00010037f0d4(*(undefined8 *)(param_1 + 0x30),*(undefined8 *)(param_1 + 0x38),1);
    uVar5 = func_0x00010037f0e8(uRam0000000103905530,0,*(undefined8 *)(param_1 + 0x40));
    uVar6 = _UNK_1036dbbb8;
    if (lVar4 != 0) {
      func_0x00010037f0fc(lVar4,uVar5);
      uVar6 = func_0x00010037f0e8(uRam0000000103905538,0,*(undefined8 *)(param_1 + 0x48));
      func_0x00010037f0fc(lVar4,uVar6);
      uVar6 = func_0x00010037f0e8(uRam00000001038f6ee0,0,*(undefined8 *)(param_1 + 0x50));
      func_0x00010037f0fc(lVar4,uVar6);
      uVar6 = _UNK_1036dbbc0;
      if (lVar3 != 0) {
        func_0x00010037f110(lVar3,lVar4,1,0);
        return;
      }
    }
  }
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101feff00);
  (*pcVar2)();
}

