/* 0x06005e2e StardewValley.Menus.MobileScrollbar.setY @ 0x101e1b748 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

float SDV_StardewValley_Menus_MobileScrollbar_setY_06005e2e(long param_1,int param_2)

{
  int iVar1;
  int iVar2;
  int iVar3;
  code *pcVar4;
  float fVar5;
  
  if (lRam0000000103976fb8 == 0) {
    iVar1 = *(int *)(param_1 + 100);
  }
  else {
    func_0x00010119b8f8();
    iVar1 = *(int *)(param_1 + 100);
  }
  if (iVar1 < param_2) {
    fVar5 = 100.0;
  }
  else {
    iVar2 = *(int *)(param_1 + 0x60);
    fVar5 = 0.0;
    if (iVar2 <= param_2) {
      iVar1 = iVar1 - iVar2;
      if (iVar1 == 0) {
        func_0x0001003316f4(0x95,_UNK_1036a2670);
                    /* WARNING: Does not return */
        pcVar4 = (code *)SoftwareBreakpoint(1,0x101e1b82c);
        (*pcVar4)();
      }
      iVar2 = (param_2 - iVar2) * 100;
      if ((iVar1 == -1) && (iVar2 == -0x80000000)) {
        func_0x0001003316f4(0x101,_UNK_1036a2678);
                    /* WARNING: Does not return */
        pcVar4 = (code *)SoftwareBreakpoint(1,0x101e1b840);
        (*pcVar4)();
      }
      iVar3 = 0;
      if (iVar1 != 0) {
        iVar3 = iVar2 / iVar1;
      }
      fVar5 = (float)iVar3;
      if (100.0 < fVar5) {
        fVar5 = 100.0;
      }
      if (fVar5 <= 0.0) {
        fVar5 = 0.0;
      }
    }
  }
  SDV_StardewValley_Menus_MobileScrollbar_setPercentage_06005e2d(fVar5,param_1);
  return fVar5;
}

