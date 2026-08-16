/* 0x0600670e StardewValley.Mobile.TapToMoveUtils.IsWizardBuilding @ 0x101fce788 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMoveUtils_IsWizardBuilding_0600670e(long param_1)

{
  code *pcVar1;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (param_1 == 0) {
    func_0x0001003316f4(0xee,_UNK_1036d7eb8);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101fce7e0);
    (*pcVar1)();
  }
  SDV_StardewValley_Mobile_TapToMoveUtils_IsWizardBuilding_0600670f
            ((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38));
  return;
}

