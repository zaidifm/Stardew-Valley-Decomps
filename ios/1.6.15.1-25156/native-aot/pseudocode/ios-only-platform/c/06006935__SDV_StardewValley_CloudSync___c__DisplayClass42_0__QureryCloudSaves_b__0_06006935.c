/* 0x06006935 StardewValley.CloudSync+<>c__DisplayClass42_0.<QureryCloudSaves>b__0 @ 0x101ff052c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync___c__DisplayClass42_0__QureryCloudSaves_b__0_06006935
               (long param_1,long param_2)

{
  uint uVar1;
  char cVar2;
  code *pcVar3;
  long *plVar4;
  undefined8 uVar5;
  long lVar6;
  long lVar7;
  undefined8 uVar8;
  long lVar9;
  undefined8 uStack_48;
  
  cVar2 = cRam0000000103911744;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_10332712b);
    cRam0000000103911744 = '\x01';
  }
  uVar8 = _UNK_1036dbca8;
  if ((((param_2 != 0) &&
       (plVar4 = (long *)func_0x00010037f14c(param_2,uRam00000001038df8e0), uVar8 = _UNK_1036dbcb0,
       plVar4 != (long *)0x0)) && (lRam0000000103905560 == *plVar4)) &&
     (uVar5 = func_0x00010037f160(), uVar8 = _UNK_1036dbcb8, param_1 != 0)) {
    lVar9 = *(long *)(param_1 + 0x10);
    lVar6 = func_0x000100331820(uRam00000001038df890,0x48);
    lVar7 = func_0x00010037f174(param_2);
    uVar8 = _UNK_1036dbcc0;
    if (lVar7 != 0) {
      uVar8 = func_0x00010037f188();
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lVar6 + 0x18) = uVar8;
      lVar7 = lRam00000001038c4be0;
      *(undefined1 *)(((ulong)(lVar6 + 0x18) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
      uStack_48 = 0;
      func_0x00010037f19c(&uStack_48,uVar5);
      *(undefined8 *)(lVar6 + 0x38) = uStack_48;
      uVar8 = func_0x00010037f138(param_2);
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lVar6 + 0x20) = uVar8;
      *(undefined1 *)(((ulong)(lVar6 + 0x20) >> 9 & 0x7fffff) + lVar7) = 1;
      plVar4 = *(long **)(lVar9 + 0x10);
      *(int *)(lVar9 + 0x1c) = *(int *)(lVar9 + 0x1c) + 1;
      uVar8 = _UNK_1036dbcd0;
      if (plVar4 != (long *)0x0) {
        uVar1 = *(uint *)(lVar9 + 0x18);
        if (uVar1 < *(uint *)(plVar4 + 3)) {
          *(uint *)(lVar9 + 0x18) = uVar1 + 1;
          (**(code **)(*plVar4 + 0x110))(plVar4,(long)(int)uVar1,lVar6);
        }
        else {
          func_0x00010035787c(lVar9,lVar6);
        }
        return;
      }
    }
  }
  func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101ff06f4);
  (*pcVar3)();
}

