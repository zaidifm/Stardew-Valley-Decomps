/* 0x06005df9 StardewValley.Menus.MobileColorPicker.RGBtoHSV @ 0x101e0657c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileColorPicker_RGBtoHSV_06005df9
               (float param_1,float param_2,float param_3,undefined8 param_4,float *param_5,
               float *param_6,float *param_7)

{
  code *pcVar1;
  undefined8 uVar2;
  float fVar3;
  float fVar4;
  
  fVar4 = param_1;
  if (lRam0000000103976fb8 == 0) {
    if (param_1 != param_2) goto LAB_101e065dc;
LAB_101e065c0:
    if (-1 < (int)param_1) {
      fVar4 = param_2;
    }
  }
  else {
    func_0x00010119b8f8();
    if (param_1 == param_2) goto LAB_101e065c0;
LAB_101e065dc:
    if (param_2 <= param_1) {
      fVar4 = param_2;
    }
  }
  if (fVar4 == param_3) {
    if (-1 < (int)fVar4) {
      fVar4 = param_3;
    }
  }
  else if (param_3 <= fVar4) {
    fVar4 = param_3;
  }
  fVar3 = param_1;
  if (param_1 == param_2) {
    if (-1 < (int)param_2) {
      fVar3 = param_2;
    }
  }
  else if (param_1 <= param_2) {
    fVar3 = param_2;
  }
  if (fVar3 == param_3) {
    if (-1 < (int)param_3) {
      fVar3 = param_3;
    }
  }
  else if (fVar3 <= param_3) {
    fVar3 = param_3;
  }
  uVar2 = _UNK_10369eef0;
  if (param_7 != (float *)0x0) {
    *param_7 = fVar3;
    if (fVar3 == 0.0) {
      uVar2 = _UNK_10369eef8;
      if (param_6 != (float *)0x0) {
        fVar3 = -1.0;
        *param_6 = 0.0;
        uVar2 = _UNK_10369ef00;
        if (param_5 != (float *)0x0) goto LAB_101e06714;
      }
    }
    else {
      uVar2 = _UNK_10369ef08;
      if (param_6 != (float *)0x0) {
        fVar4 = fVar3 - fVar4;
        *param_6 = fVar4 / fVar3;
        if (fVar3 == param_1) {
          uVar2 = _UNK_10369ef20;
          if (param_5 == (float *)0x0) goto LAB_101e06774;
          fVar3 = (param_2 - param_3) / fVar4;
        }
        else {
          if (fVar3 == param_2) {
            uVar2 = _UNK_10369ef18;
            if (param_5 == (float *)0x0) goto LAB_101e06774;
            param_1 = param_3 - param_1;
            fVar3 = 2.0;
          }
          else {
            uVar2 = _UNK_10369ef10;
            if (param_5 == (float *)0x0) goto LAB_101e06774;
            param_1 = param_1 - param_2;
            fVar3 = 4.0;
          }
          fVar3 = param_1 / fVar4 + fVar3;
        }
        fVar3 = fVar3 * 60.0;
        *param_5 = fVar3;
        if (0.0 <= fVar3) {
          return;
        }
        fVar3 = fVar3 + 360.0;
LAB_101e06714:
        *param_5 = fVar3;
        return;
      }
    }
  }
LAB_101e06774:
  func_0x0001003316f4(0xee,uVar2);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e06780);
  (*pcVar1)();
}

