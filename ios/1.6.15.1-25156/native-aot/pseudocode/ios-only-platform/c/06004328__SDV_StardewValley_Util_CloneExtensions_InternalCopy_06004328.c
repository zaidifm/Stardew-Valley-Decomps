/* 0x06004328 StardewValley.Util.CloneExtensions.InternalCopy @ 0x101a3d0f8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long * SDV_StardewValley_Util_CloneExtensions_InternalCopy_06004328
                 (long *param_1,undefined8 param_2)

{
  long lVar1;
  code *pcVar2;
  char cVar3;
  long lVar4;
  long *plVar5;
  long lVar6;
  undefined8 uVar7;
  long *plVar8;
  long *plVar9;
  long lVar10;
  
  cVar3 = cRam000000010390f137;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_1032eec80);
    cRam000000010390f137 = '\x01';
  }
  lVar4 = func_0x000100331820(uRam00000001038f02b0,0x20);
  lVar1 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar4 + 0x10) = param_2;
  *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
  if (param_1 != (long *)0x0) {
    plVar9 = *(long **)(*param_1 + 0x18);
    cVar3 = SDV_StardewValley_Util_CloneExtensions_IsPrimitive_06004324(plVar9);
    if (cVar3 != '\0') {
      return param_1;
    }
    uVar7 = _UNK_10363a938;
    if (*(long *)(lVar4 + 0x10) != 0) {
      cVar3 = func_0x000100367cb8(*(long *)(lVar4 + 0x10),param_1);
      if (cVar3 == '\0') {
        cVar3 = (**(code **)(*plRam00000001038f02c0 + 0xf0))(plRam00000001038f02c0,plVar9);
        if (cVar3 != '\0') {
          return (long *)0x0;
        }
        uVar7 = _UNK_10363a948;
        if ((*plRam00000001038f02c8 != 0) &&
           (plVar5 = (long *)func_0x000100340690(*plRam00000001038f02c8,param_1,0),
           uVar7 = _UNK_10363a950, plVar9 != (long *)0x0)) {
          cVar3 = func_0x000100367ccc(plVar9);
          if (cVar3 != '\0') {
            (**(code **)(*plVar9 + 0x308))(plVar9);
            cVar3 = SDV_StardewValley_Util_CloneExtensions_IsPrimitive_06004324();
            if (cVar3 == '\0') {
              if ((plVar5 != (long *)0x0) &&
                 (lRam00000001038f02f0 != *(long *)(*(long *)(*(long *)*plVar5 + 0x10) + 8))) {
                func_0x0001003316f4(0xd3,_UNK_10363a960);
                    /* WARNING: Does not return */
                pcVar2 = (code *)SoftwareBreakpoint(1,0x101a3d3c4);
                (*pcVar2)();
              }
              DataMemoryBarrier(2,3);
              plVar8 = (long *)(lVar4 + 0x18);
              *plVar8 = (long)plVar5;
              *(undefined1 *)(((ulong)plVar8 >> 9 & 0x7fffff) + lVar1) = 1;
              lVar10 = *plVar8;
              lVar6 = func_0x000100331820(uRam00000001038f02d8,0x80);
              DataMemoryBarrier(2,3);
              *(long *)(lVar6 + 0x20) = lVar4;
              *(undefined1 *)(((ulong)(lVar6 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
              uVar7 = uRam00000001038f02e8;
              lVar1 = lRam00000001038f02e0;
              *(long *)(lVar6 + 0x40) = lRam00000001038f02e0;
              *(undefined8 *)(lVar6 + 0x28) = uVar7;
              *(undefined8 *)(lVar6 + 0x18) = *(undefined8 *)(lVar1 + 0x30);
              *(undefined8 *)(lVar6 + 0x10) = *(undefined8 *)(lVar1 + 0x28);
              SDV_StardewValley_Util_CloneExtensions_ForEach_0600432c(lVar10,lVar6);
            }
          }
          uVar7 = _UNK_10363a958;
          if (*(long *)(lVar4 + 0x10) != 0) {
            func_0x000100367ce0(*(long *)(lVar4 + 0x10),param_1,plVar5);
            SDV_StardewValley_Util_CloneExtensions_CopyFields_0600432a
                      (param_1,*(undefined8 *)(lVar4 + 0x10),plVar5,plVar9,0x74,0);
            SDV_StardewValley_Util_CloneExtensions_RecursiveCopyBaseTypePrivateFields_06004329
                      (param_1,*(undefined8 *)(lVar4 + 0x10),plVar5,plVar9);
            return plVar5;
          }
        }
      }
      else {
        uVar7 = _UNK_10363a968;
        if (*(long *)(lVar4 + 0x10) != 0) {
          plVar9 = (long *)func_0x000100367d30(*(long *)(lVar4 + 0x10),param_1);
          return plVar9;
        }
      }
    }
    func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x101a3d3b0);
    (*pcVar2)();
  }
  return (long *)0x0;
}

