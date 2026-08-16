/* 0x06006679 StardewValley.Mobile.PinchZoom.get_Instance @ 0x101fafe28 */

/* WARNING: Removing unreachable block (ram,0x000101faff64) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_Mobile_PinchZoom_get_Instance_06006679(void)

{
  char cVar1;
  code *pcVar2;
  int iVar3;
  long lVar4;
  undefined8 uVar5;
  long lVar6;
  undefined4 uVar7;
  char cStack_31;
  long lStack_30;
  long lStack_28;
  
  cVar1 = cRam0000000103911488;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103324fc0);
    cRam0000000103911488 = '\x01';
  }
  lStack_30 = 0;
  cStack_31 = '\0';
  uVar5 = *puRam0000000103904870;
  iVar3 = func_0x000100331adc(uVar5,&cStack_31);
  if (iVar3 == 0) {
    func_0x000100331bb8(uVar5,&cStack_31);
  }
  if (*plRam0000000103904878 == 0) {
    lVar4 = func_0x000100331820(uRam0000000103904880,0x88);
    SDV_StardewValley_Mobile_PinchZoom_ctor_06006685();
    DataMemoryBarrier(2,3);
    *plRam0000000103904878 = lVar4;
    lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec();
    if (lVar4 != 0) {
      lVar6 = *plRam0000000103904878;
      lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec();
      if ((lVar4 == 0) || (uVar7 = SDV_StardewValley_Options_get_zoomLevel_06003ee1(), lVar6 == 0))
      {
        func_0x0001003316f4(0xee,_UNK_1036d3948);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101faff44);
        (*pcVar2)();
      }
      *(undefined4 *)(lVar6 + 0x18) = uVar7;
    }
  }
  lStack_30 = *plRam0000000103904878;
  lStack_28 = 0;
  if (cStack_31 != '\0') {
    func_0x000100331c1c(uVar5);
  }
  if (lStack_28 != 0) {
    func_0x000100331ba4();
  }
  return lStack_30;
}

