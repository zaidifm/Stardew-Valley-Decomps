/* 0x06006681 StardewValley.Mobile.PinchZoom.Center @ 0x101fb0a88 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_PinchZoom_Center_06006681(long param_1)

{
  int iVar1;
  int *piVar2;
  float *pfVar3;
  char cVar4;
  code *pcVar5;
  long lVar6;
  undefined8 uVar7;
  float fVar8;
  float fVar9;
  
  cVar4 = cRam0000000103911490;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103325050);
    cRam0000000103911490 = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  iVar1 = *(int *)(lRam00000001038d6278 + 8);
  lVar6 = StardewValley_StardewValley_Game1_get_options_06002fec();
  uVar7 = _UNK_1036d3ab8;
  if ((lVar6 != 0) &&
     (fVar8 = (float)SDV_StardewValley_Options_get_zoomLevel_06003ee1(), uVar7 = _UNK_1036d3ac0,
     param_1 != 0)) {
    *(float *)(param_1 + 0x68) = (float)iVar1 / fVar8;
    iVar1 = *(int *)(lRam00000001038d6278 + 0xc);
    lVar6 = StardewValley_StardewValley_Game1_get_options_06002fec();
    uVar7 = _UNK_1036d3ad0;
    if (lVar6 != 0) {
      fVar8 = (float)SDV_StardewValley_Options_get_zoomLevel_06003ee1();
      *(float *)(param_1 + 0x6c) = (float)iVar1 / fVar8;
      *(undefined8 *)(param_1 + 0x80) = *(undefined8 *)pfRam00000001038d5388;
      SDV_StardewValley_Mobile_PinchZoom_CenterOnPinch_06006682(param_1);
      fVar9 = pfRam00000001038d5388[1];
      fVar8 = (float)func_0x000101763750(*pfRam00000001038d5388);
      pfVar3 = pfRam00000001038d5388;
      *pfRam00000001038d5388 = fVar8;
      pfVar3[1] = fVar9;
      uVar7 = *(undefined8 *)pfVar3;
      *puRam00000001038d6150 = uVar7;
      *puRam00000001038d6f60 = uVar7;
      piVar2 = piRam00000001038d5380;
      uVar7 = _UNK_1036d3ad8;
      if (piRam00000001038d5380 != (int *)0x0) {
        *piRam00000001038d5380 = (int)*pfVar3;
        piVar2[1] = (int)pfVar3[1];
        *puRam00000001038d5dc8 = 1;
        return;
      }
    }
  }
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar5 = (code *)SoftwareBreakpoint(1,0x101fb0c18);
  (*pcVar5)();
}

