/* 0x06004329 StardewValley.Util.CloneExtensions.RecursiveCopyBaseTypePrivateFields @ 0x101a3d3c4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Util_CloneExtensions_RecursiveCopyBaseTypePrivateFields_06004329
               (undefined8 param_1,undefined8 param_2,undefined8 param_3,long *param_4)

{
  long lVar1;
  long *plVar2;
  undefined8 uVar3;
  code *pcVar4;
  char cVar5;
  undefined8 uVar6;
  long lVar7;
  long lVar8;
  
  cVar5 = cRam000000010390f138;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar5 == '\0') {
    func_0x00010119b908(&UNK_1032eecb0);
    cRam000000010390f138 = '\x01';
    lVar7 = *param_4;
  }
  else {
    lVar7 = *param_4;
  }
  uVar6 = (**(code **)(lVar7 + 0x198))(param_4);
  cVar5 = func_0x000100350ff4(uVar6,0);
  if (cVar5 != '\0') {
    uVar6 = (**(code **)(*param_4 + 0x198))(param_4);
    SDV_StardewValley_Util_CloneExtensions_RecursiveCopyBaseTypePrivateFields_06004329
              (param_1,param_2,param_3,uVar6);
    uVar6 = (**(code **)(*param_4 + 0x198))(param_4);
    lVar7 = *plRam00000001038f0300;
    if (lVar7 == 0) {
      lVar8 = *plRam00000001038f0308;
      if (lVar8 == 0) {
        func_0x0001003316f4(0x69,_UNK_10363a978);
                    /* WARNING: Does not return */
        pcVar4 = (code *)SoftwareBreakpoint(1,0x101a3d558);
        (*pcVar4)();
      }
      lVar7 = func_0x000100331820(uRam00000001038f0310,0x80);
      lVar1 = lRam00000001038c4be0;
      DataMemoryBarrier(2,3);
      *(long *)(lVar7 + 0x20U) = lVar8;
      *(undefined1 *)((lVar7 + 0x20U >> 9 & 0x7fffff) + lVar1) = 1;
      uVar3 = uRam00000001038f0320;
      lVar8 = lRam00000001038f0318;
      *(long *)(lVar7 + 0x40) = lRam00000001038f0318;
      *(undefined8 *)(lVar7 + 0x28) = uVar3;
      *(undefined8 *)(lVar7 + 0x18) = *(undefined8 *)(lVar8 + 0x30);
      plVar2 = plRam00000001038f0300;
      *(undefined8 *)(lVar7 + 0x10) = *(undefined8 *)(lVar8 + 0x28);
      DataMemoryBarrier(2,3);
      *plVar2 = lVar7;
    }
    SDV_StardewValley_Util_CloneExtensions_CopyFields_0600432a
              (param_1,param_2,param_3,uVar6,0x24,lVar7);
  }
  return;
}

