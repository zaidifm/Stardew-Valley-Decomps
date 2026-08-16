/* 0x06006710 StardewValley.Mobile.TapToMoveUtils.GetWalkDirectionFacing @ 0x101fce8f8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined4
SDV_StardewValley_Mobile_TapToMoveUtils_GetWalkDirectionFacing_06006710
          (float param_1,float param_2,float param_3,float param_4)

{
  bool bVar1;
  bool bVar2;
  undefined4 uVar3;
  double dVar4;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  dVar4 = (double)func_0x00010035d358((double)(param_2 - param_4),(double)(param_1 - param_3));
  if ((dVar4 < _UNK_103333c70) || (_UNK_103333c78 < dVar4)) {
    if ((dVar4 < _UNK_103333c78) || (_UNK_103333c80 < dVar4)) {
      bVar1 = false;
      bVar2 = true;
      if (_UNK_103333c88 <= dVar4) {
        bVar1 = false;
        bVar2 = true;
        if (!NAN(dVar4) && !NAN(_UNK_103333c70)) {
          bVar1 = dVar4 == _UNK_103333c70;
          bVar2 = _UNK_103333c70 <= dVar4;
        }
      }
      uVar3 = 3;
      if (!bVar2 || bVar1) {
        uVar3 = 1;
      }
    }
    else {
      uVar3 = 2;
    }
  }
  else {
    uVar3 = 4;
  }
  return uVar3;
}

