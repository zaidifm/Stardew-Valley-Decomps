/* 0x06005df8 StardewValley.Menus.MobileColorPicker.setColor @ 0x101e063ac */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileColorPicker_setColor_06005df8(long param_1,undefined4 param_2)

{
  bool bVar1;
  float fVar2;
  code *pcVar3;
  byte bVar4;
  undefined8 uVar5;
  float fVar6;
  float fVar7;
  float fVar8;
  float fVar9;
  float fVar10;
  float fVar11;
  undefined4 auStack_38 [2];
  
  auStack_38[0] = param_2;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  bVar4 = func_0x000100342a44(auStack_38);
  fVar10 = (float)bVar4;
  bVar4 = func_0x000100342a30(auStack_38);
  fVar11 = (float)bVar4;
  bVar4 = func_0x000100342a1c(auStack_38);
  fVar9 = fVar10;
  if (fVar10 <= fVar11) {
    fVar9 = fVar11;
  }
  fVar8 = (float)bVar4;
  fVar6 = fVar10;
  if (fVar11 <= fVar10) {
    fVar6 = fVar11;
  }
  fVar7 = fVar11;
  fVar2 = fVar11;
  if (fVar10 != fVar11) {
    fVar7 = fVar6;
    fVar2 = fVar9;
  }
  bVar1 = (int)fVar7 < 0;
  if (fVar7 != fVar8) {
    bVar1 = fVar7 < fVar8;
  }
  if (!bVar1) {
    fVar7 = fVar8;
  }
  fVar9 = fVar2;
  if (fVar2 == fVar8 || fVar2 < fVar8) {
    fVar9 = fVar8;
  }
  fVar6 = fVar8;
  if (fVar2 != fVar8) {
    fVar6 = fVar9;
  }
  if (fVar6 == 0.0) {
    fVar7 = 0.0;
    fVar9 = -1.0;
  }
  else {
    fVar7 = fVar6 - fVar7;
    if (fVar6 == fVar10) {
      fVar9 = (fVar11 - fVar8) / fVar7;
    }
    else {
      if (fVar6 == fVar11) {
        fVar10 = fVar8 - fVar10;
        fVar9 = 2.0;
      }
      else {
        fVar10 = fVar10 - fVar11;
        fVar9 = 4.0;
      }
      fVar9 = fVar10 / fVar7 + fVar9;
    }
    fVar7 = fVar7 / fVar6;
    fVar9 = fVar9 * 60.0;
    if (fVar9 < 0.0) {
      fVar9 = fVar9 + 360.0;
    }
  }
  uVar5 = _UNK_10369eed8;
  if (*(long *)(param_1 + 0x68) != 0) {
    *(int *)(*(long *)(param_1 + 0x68) + 0x10) = (int)((fVar9 / 360.0) * 100.0);
    uVar5 = _UNK_10369eee0;
    if (*(long *)(param_1 + 0x78) != 0) {
      *(int *)(*(long *)(param_1 + 0x78) + 0x10) = (int)(fVar7 * 100.0);
      uVar5 = _UNK_10369eee8;
      if (*(long *)(param_1 + 0x70) != 0) {
        *(int *)(*(long *)(param_1 + 0x70) + 0x10) = (int)((fVar6 / 255.0) * 100.0);
        return;
      }
    }
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101e0657c);
  (*pcVar3)();
}

