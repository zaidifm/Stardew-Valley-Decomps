/* 0x060031ce StardewValley.TutorialMessage.update @ 0x101785170 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_TutorialMessage_update_060031ce(long param_1,long param_2)

{
  code *pcVar1;
  float fVar2;
  float fVar3;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (param_1 != 0) {
    fVar2 = *(float *)(param_1 + 0x84) - (float)((*(long *)(param_2 + 0x18) / 10000) % 1000);
    *(float *)(param_1 + 0x84) = fVar2;
    if (fVar2 < 0.0) {
      fVar2 = *(float *)(param_1 + 0x88) + -0.02;
      *(float *)(param_1 + 0x88) = fVar2;
      if (fVar2 < 0.0) {
        return 1;
      }
    }
    else if (*(char *)(param_1 + 0x95) != '\0') {
      fVar3 = *(float *)(param_1 + 0x88) + 0.02;
      fVar2 = 1.0;
      if ((fVar3 != 1.0) && (fVar2 = fVar3, !NAN(fVar3))) {
        fVar2 = (float)NEON_fminnm(fVar3,0x3f800000);
      }
      *(float *)(param_1 + 0x88) = fVar2;
      return 0;
    }
    return 0;
  }
  func_0x0001003316f4(0xee,_UNK_1035f2f88);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101785298);
  (*pcVar1)();
}

