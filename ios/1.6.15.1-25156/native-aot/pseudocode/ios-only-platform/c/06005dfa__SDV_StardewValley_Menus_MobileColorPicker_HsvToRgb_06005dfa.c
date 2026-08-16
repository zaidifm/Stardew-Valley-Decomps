/* 0x06005dfa StardewValley.Menus.MobileColorPicker.HsvToRgb @ 0x101e06780 */

undefined4
SDV_StardewValley_Menus_MobileColorPicker_HsvToRgb_06005dfa
          (double param_1,double param_2,double param_3)

{
  int iVar1;
  int iVar2;
  int iVar3;
  double dVar4;
  double dVar5;
  double dVar6;
  double dVar7;
  double dVar8;
  double dVar9;
  undefined4 auStack_58 [2];
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  while (param_1 < 0.0) {
    while( true ) {
      param_1 = param_1 + 1.0;
      if (param_1 < -1000000.0) {
        param_1 = 0.0;
      }
      if (lRam0000000103976fb8 != 0) break;
      if (0.0 <= param_1) goto joined_r0x000101e0681c;
    }
    func_0x00010119b8f8();
  }
joined_r0x000101e0681c:
  for (; 360.0 <= param_1; param_1 = param_1 + -1.0) {
    if (lRam0000000103976fb8 != 0) {
      func_0x00010119b8f8();
    }
  }
  dVar4 = 0.0;
  dVar5 = 0.0;
  dVar6 = 0.0;
  if ((0.0 < param_3) && (dVar4 = param_3, dVar5 = param_3, dVar6 = param_3, 0.0 < param_2)) {
    iVar1 = (int)(param_1 / 60.0);
    if (0xfffffff7 < iVar1 - 7U) {
      dVar4 = param_1 / 60.0 - (double)iVar1;
      dVar7 = (1.0 - param_2) * param_3;
      dVar9 = (1.0 - dVar4 * param_2) * param_3;
      dVar8 = (1.0 - (1.0 - dVar4) * param_2) * param_3;
      dVar4 = dVar9;
      dVar5 = dVar7;
      switch(iVar1) {
      case 0:
      case 6:
        dVar4 = dVar7;
        dVar5 = dVar8;
        break;
      case 1:
        dVar4 = dVar7;
        dVar5 = param_3;
        dVar6 = dVar9;
        break;
      case 2:
        dVar4 = dVar8;
        dVar5 = param_3;
        dVar6 = dVar7;
        break;
      case 3:
        dVar4 = param_3;
        dVar5 = dVar9;
        dVar6 = dVar7;
        break;
      case 4:
        dVar4 = param_3;
        dVar6 = dVar8;
      }
    }
  }
  auStack_58[0] = 0;
  iVar1 = (int)(dVar6 * 255.0);
  iVar3 = (int)(dVar5 * 255.0);
  if (0xfe < iVar1) {
    iVar1 = 0xff;
  }
  if (iVar1 < 1) {
    iVar1 = 0;
  }
  iVar2 = (int)(dVar4 * 255.0);
  if (0xfe < iVar3) {
    iVar3 = 0xff;
  }
  if (iVar3 < 1) {
    iVar3 = 0;
  }
  if (0xfe < iVar2) {
    iVar2 = 0xff;
  }
  if (iVar2 < 1) {
    iVar2 = 0;
  }
  func_0x00010035205c(auStack_58,iVar1,iVar3,iVar2);
  return auStack_58[0];
}

