/* 0x06006779 StardewValley.iOS.AppDelegate.ShowDiskFullDialogue @ 0x101fd93e0 */

void SDV_StardewValley_iOS_AppDelegate_ShowDiskFullDialogue_06006779(void)

{
  char cVar1;
  undefined8 uVar2;
  int iVar3;
  undefined8 uVar4;
  
  cVar1 = cRam0000000103911588;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103325f80);
    cRam0000000103911588 = '\x01';
  }
  StardewValley_Log_It_06000016(uRam0000000103904c10);
  uVar2 = uRam0000000103904c18;
  if (*(char *)(lRam00000001038c4c68 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  iVar3 = *piRam00000001038d5f10;
  uVar4 = uRam0000000103904c70;
  if (iVar3 != 6) {
    uVar4 = uRam0000000103904c68;
    if (*(char *)(lRam00000001038c4c68 + 0x35) == '\0') {
      func_0x0001003319b0();
      iVar3 = *piRam00000001038d5f10;
      uVar4 = uRam0000000103904c68;
    }
    uRam0000000103904c68 = uVar4;
    if (iVar3 != 5) {
      if (*(char *)(lRam00000001038c4c68 + 0x35) == '\0') {
        func_0x0001003319b0();
        iVar3 = *piRam00000001038d5f10;
      }
      uVar4 = uRam0000000103904c60;
      uRam0000000103904c60 = uVar4;
      if (iVar3 != 8) {
        if (*(char *)(lRam00000001038c4c68 + 0x35) == '\0') {
          func_0x0001003319b0();
          iVar3 = *piRam00000001038d5f10;
        }
        uVar4 = uRam0000000103904c58;
        uRam0000000103904c58 = uVar4;
        if (iVar3 != 0xc) {
          if (*(char *)(lRam00000001038c4c68 + 0x35) == '\0') {
            func_0x0001003319b0();
            iVar3 = *piRam00000001038d5f10;
          }
          uVar4 = uRam0000000103904c50;
          uRam0000000103904c50 = uVar4;
          if (iVar3 != 10) {
            if (*(char *)(lRam00000001038c4c68 + 0x35) == '\0') {
              func_0x0001003319b0();
              iVar3 = *piRam00000001038d5f10;
            }
            uVar4 = uRam0000000103904c48;
            uRam0000000103904c48 = uVar4;
            if (iVar3 != 1) {
              if (*(char *)(lRam00000001038c4c68 + 0x35) == '\0') {
                func_0x0001003319b0();
                iVar3 = *piRam00000001038d5f10;
              }
              uVar4 = uRam0000000103904c40;
              uRam0000000103904c40 = uVar4;
              if (iVar3 != 9) {
                if (*(char *)(lRam00000001038c4c68 + 0x35) == '\0') {
                  func_0x0001003319b0();
                  iVar3 = *piRam00000001038d5f10;
                }
                uVar4 = uRam0000000103904c38;
                uRam0000000103904c38 = uVar4;
                if (iVar3 != 4) {
                  if (*(char *)(lRam00000001038c4c68 + 0x35) == '\0') {
                    func_0x0001003319b0();
                    iVar3 = *piRam00000001038d5f10;
                  }
                  uVar4 = uRam0000000103904c30;
                  uRam0000000103904c30 = uVar4;
                  if (iVar3 != 2) {
                    if (*(char *)(lRam00000001038c4c68 + 0x35) == '\0') {
                      func_0x0001003319b0();
                      iVar3 = *piRam00000001038d5f10;
                    }
                    uVar4 = uRam0000000103904c28;
                    uRam0000000103904c28 = uVar4;
                    if (iVar3 != 0xb) {
                      if (*(char *)(lRam00000001038c4c68 + 0x35) == '\0') {
                        func_0x0001003319b0();
                        iVar3 = *piRam00000001038d5f10;
                      }
                      uVar4 = uRam0000000103904c20;
                      if (iVar3 != 3) {
                        uVar4 = uVar2;
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
  }
  uVar2 = func_0x000100331820(uRam00000001038d6f90,0x108);
  func_0x000101e6df18(uVar2,uVar4,1);
  SDV_StardewValley_Game1_set_activeClickableMenu_06002fe2(uVar2);
  return;
}

