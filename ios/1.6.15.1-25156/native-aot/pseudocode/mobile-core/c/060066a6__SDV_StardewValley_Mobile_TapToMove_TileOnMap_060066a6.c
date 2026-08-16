/* 0x060066a6 StardewValley.Mobile.TapToMove.TileOnMap @ 0x101fb9030 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_TapToMove_TileOnMap_060066a6(long param_1,int param_2,int param_3)

{
  int iVar1;
  char cVar2;
  code *pcVar3;
  undefined8 uVar4;
  long lVar5;
  long lVar6;
  
  cVar2 = cRam00000001039114b5;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1033253bf);
    cRam00000001039114b5 = '\x01';
    lVar5 = *(long *)(param_1 + 0x28);
  }
  else {
    lVar5 = *(long *)(param_1 + 0x28);
  }
  lVar5 = *(long *)(*(long *)(lVar5 + 0x18) + 0x48);
  uVar4 = _UNK_1036d44a0;
  if ((((lVar5 != 0) &&
       (lVar5 = func_0x000100353ce0(lVar5,0), uVar4 = _UNK_1036d44b0, lVar5 != -0x68)) &&
      (uVar4 = _UNK_1036d44a8, lVar5 != 0)) &&
     (lVar6 = *(long *)(*(long *)(*(long *)(param_1 + 0x28) + 0x18) + 0x48), uVar4 = _UNK_1036d44c8,
     lVar6 != 0)) {
    iVar1 = *(int *)(lVar5 + 0x68);
    lVar5 = func_0x000100353ce0(lVar6,0);
    uVar4 = _UNK_1036d44d0;
    if ((lVar5 != 0) && (uVar4 = _UNK_1036d44d8, lVar5 != -0x68)) {
      return (((-(param_2 <= iVar1) & 1U | (-(param_3 <= *(int *)(lVar5 + 0x6c)) & 1U) << 1 |
                (-(-1 < param_2) & 1U) << 2 | (-1 < param_3) * -8) ^ 0xff) & 0xf) == 0;
    }
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fb91f0);
  (*pcVar3)();
}

