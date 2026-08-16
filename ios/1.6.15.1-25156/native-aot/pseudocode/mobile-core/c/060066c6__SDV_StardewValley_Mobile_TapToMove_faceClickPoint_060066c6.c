/* 0x060066c6 StardewValley.Mobile.TapToMove.faceClickPoint @ 0x101fc76f4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_faceClickPoint_060066c6
               (undefined1 param_1 [16],float param_2,long param_3)

{
  int iVar1;
  char cVar2;
  code *pcVar3;
  bool bVar4;
  bool bVar5;
  long lVar6;
  long *plVar7;
  undefined8 uVar8;
  int iVar9;
  float fVar10;
  double dVar11;
  float fVar12;
  float fVar13;
  
  cVar2 = cRam00000001039114d5;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325765);
    cRam00000001039114d5 = '\x01';
  }
  lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar8 = _UNK_1036d7230;
  if ((*(long *)(lVar6 + 0x38) != 0) && (uVar8 = _UNK_1036d7238, param_3 != 0)) {
    iVar1 = *(int *)(*(long *)(lVar6 + 0x38) + 0x68);
    fVar12 = *(float *)(param_3 + 0x108);
    fVar13 = *(float *)(param_3 + 0x10c);
    lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar8 = _UNK_1036d7248;
    if (*(long *)(lVar6 + 0x20) != 0) {
      fVar10 = (float)func_0x0001003436c4();
      dVar11 = (double)func_0x00010035d358((double)(fVar13 - param_2),(double)(fVar12 - fVar10));
      if ((dVar11 < _UNK_103333c70) || (_UNK_103333c78 < dVar11)) {
        if ((dVar11 < _UNK_103333c78) || (_UNK_103333c80 < dVar11)) {
          bVar4 = false;
          bVar5 = true;
          if (_UNK_103333c88 <= dVar11) {
            bVar4 = false;
            bVar5 = true;
            if (!NAN(dVar11) && !NAN(_UNK_103333c70)) {
              bVar4 = dVar11 == _UNK_103333c70;
              bVar5 = _UNK_103333c70 <= dVar11;
            }
          }
          iVar9 = 3;
          if (!bVar5 || bVar4) {
            iVar9 = 0;
          }
          if (iVar9 == iVar1) {
            return;
          }
        }
        else {
          iVar9 = 2;
          if (iVar1 == 2) {
            return;
          }
        }
      }
      else {
        iVar9 = 1;
        if (iVar1 == 1) {
          return;
        }
      }
      plVar7 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
      (**(code **)(*plVar7 + 0x188))();
      plVar7 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
      (**(code **)(*plVar7 + 0x178))(plVar7,iVar9);
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fc789c);
  (*pcVar3)();
}

