/* 0x06005e3d StardewValley.Menus.MobileScrollbox.receiveLeftClick @ 0x101e1c6e4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileScrollbox_receiveLeftClick_06005e3d
               (long param_1,undefined4 param_2,undefined4 param_3)

{
  code *pcVar1;
  char cVar2;
  undefined8 uVar3;
  ulong uVar4;
  long lVar5;
  long lVar6;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar3 = _UNK_1036a27c0;
  if (param_1 != 0) {
    *(undefined4 *)(param_1 + 0x60) = 0;
    cVar2 = func_0x000100356238(param_1 + 0x28,param_2,param_3);
    if (cVar2 == '\0') {
      return;
    }
    lVar5 = *(long *)(param_1 + 0x18);
    *(undefined2 *)(param_1 + 0x48) = 1;
    *(undefined4 *)(param_1 + 0x50) = param_3;
    *(undefined4 *)(param_1 + 0x54) = *(undefined4 *)(param_1 + 0x4c);
    uVar3 = _UNK_1036a27c8;
    if (lVar5 != 0) {
      uVar4 = 0;
      lVar6 = 0x20;
      do {
        if ((long)(int)*(uint *)(lVar5 + 0x18) <= (long)uVar4) {
          *(undefined4 *)(param_1 + 0x5c) = 0;
          return;
        }
        if (*(uint *)(lVar5 + 0x18) <= uVar4) {
          func_0x0001003316f4(0xcc,_UNK_1036a27d0);
                    /* WARNING: Does not return */
          pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1c7d0);
          (*pcVar1)();
        }
        *(undefined4 *)(lVar5 + lVar6) = 0;
        lVar5 = *(long *)(param_1 + 0x18);
        if (lRam0000000103976fb8 != 0) {
          func_0x00010119b8f8();
        }
        lVar6 = lVar6 + 4;
        uVar4 = uVar4 + 1;
        uVar3 = _UNK_1036a27c8;
      } while (lVar5 != 0);
    }
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1c7e4);
  (*pcVar1)();
}

