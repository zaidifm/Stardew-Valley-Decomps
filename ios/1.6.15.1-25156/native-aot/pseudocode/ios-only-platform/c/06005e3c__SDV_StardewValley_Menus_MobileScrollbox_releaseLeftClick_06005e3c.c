/* 0x06005e3c StardewValley.Menus.MobileScrollbox.releaseLeftClick @ 0x101e1c5e0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileScrollbox_releaseLeftClick_06005e3c(long param_1)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  uint uVar4;
  ulong uVar5;
  float *pfVar6;
  float fVar7;
  
  if (lRam0000000103976fb8 == 0) {
    cVar1 = *(char *)(param_1 + 0x49);
  }
  else {
    func_0x00010119b8f8();
    cVar1 = *(char *)(param_1 + 0x49);
  }
  if (cVar1 != '\0') {
    lVar3 = *(long *)(param_1 + 0x18);
    *(undefined4 *)(param_1 + 0x60) = 0;
    uVar4 = *(uint *)(lVar3 + 0x18);
    if ((int)uVar4 < 1) {
      fVar7 = 0.0;
    }
    else {
      fVar7 = 0.0;
      uVar5 = 0;
      pfVar6 = (float *)(lVar3 + 0x20);
      do {
        if (uVar4 <= uVar5) {
          func_0x0001003316f4(0xcc,_UNK_1036a27b8);
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101e1c6d0);
          (*pcVar2)();
        }
        fVar7 = fVar7 + *pfVar6;
        *(float *)(param_1 + 0x60) = fVar7;
        uVar4 = *(uint *)(lVar3 + 0x18);
        if (lRam0000000103976fb8 != 0) {
          func_0x00010119b8f8();
        }
        uVar5 = uVar5 + 1;
        pfVar6 = pfVar6 + 1;
      } while ((long)uVar5 < (long)(int)uVar4);
    }
    *(undefined1 *)(param_1 + 0x4a) = 1;
    *(float *)(param_1 + 0x60) = fVar7 / (float)(int)uVar4;
  }
  *(undefined2 *)(param_1 + 0x48) = 0;
  return;
}

