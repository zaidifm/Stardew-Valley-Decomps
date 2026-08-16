/* 0x060032dd StardewValley.CloudSync.DeleteSave @ 0x10179db44 */

/* WARNING: Removing unreachable block (ram,0x00010179dc94) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync_DeleteSave_060032dd(long param_1,undefined8 param_2)

{
  uint uVar1;
  char cVar2;
  code *pcVar3;
  int iVar4;
  long lVar5;
  undefined8 uVar6;
  long *plVar7;
  char cStack_39;
  long lStack_38;
  
  cVar2 = cRam000000010390e0ec;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1032d3ab8);
    cRam000000010390e0ec = '\x01';
    uVar6 = *(undefined8 *)(param_1 + 0x10);
  }
  else {
    uVar6 = *(undefined8 *)(param_1 + 0x10);
  }
  cStack_39 = '\0';
  iVar4 = func_0x000100331adc(uVar6,&cStack_39);
  if (iVar4 == 0) {
    func_0x000100331bb8(uVar6,&cStack_39);
  }
  lVar5 = *(long *)(param_1 + 0x28);
  if (lVar5 != 0) {
    plVar7 = *(long **)(lVar5 + 0x10);
    *(int *)(lVar5 + 0x1c) = *(int *)(lVar5 + 0x1c) + 1;
    if (plVar7 != (long *)0x0) {
      uVar1 = *(uint *)(lVar5 + 0x18);
      if (uVar1 < *(uint *)(plVar7 + 3)) {
        *(uint *)(lVar5 + 0x18) = uVar1 + 1;
        (**(code **)(*plVar7 + 0x110))(plVar7,(long)(int)uVar1,param_2);
      }
      else {
        func_0x00010033e7c8(lVar5,param_2);
      }
      SDV_StardewValley_CloudSync_BeginSync_060032db(param_1,1);
      lStack_38 = 0;
      if (cStack_39 != '\0') {
        func_0x000100331c1c(uVar6);
      }
      if (lStack_38 != 0) {
        func_0x000100331ba4();
      }
      return;
    }
  }
  func_0x0001003316f4(0xee,_UNK_1035f5488);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x10179dc04);
  (*pcVar3)();
}

