/* 0x06005da8 StardewValley.Menus.CoopGameMenu.addSaveFiles @ 0x101df741c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_addSaveFiles_06005da8(long param_1,undefined8 param_2)

{
  long *plVar1;
  char cVar2;
  code *pcVar3;
  undefined8 uVar4;
  long lVar5;
  undefined8 uVar6;
  long lVar7;
  long lVar8;
  long lVar9;
  
  cVar2 = cRam0000000103910bb7;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  lVar8 = lRam00000001038c4be0;
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103316510);
    cRam0000000103910bb7 = '\x01';
    lVar8 = lRam00000001038c4be0;
  }
  uVar6 = _UNK_10369cf10;
  lRam00000001038c4be0 = lVar8;
  if (param_1 != 0) {
    lVar7 = *(long *)(param_1 + 0x178);
    lVar5 = *plRam0000000103900130;
    if (lVar5 == 0) {
      lVar9 = *plRam0000000103900160;
      if (lVar9 == 0) {
        func_0x0001003316f4(0x69,_UNK_10369cf20);
                    /* WARNING: Does not return */
        pcVar3 = (code *)SoftwareBreakpoint(1,0x101df75e4);
        (*pcVar3)();
      }
      lVar5 = func_0x000100331820(uRam00000001038e8c10,0x80);
      lVar8 = lRam00000001038c4be0;
      DataMemoryBarrier(2,3);
      *(long *)(lVar5 + 0x20U) = lVar9;
      *(undefined1 *)((lVar5 + 0x20U >> 9 & 0x7fffff) + lVar8) = 1;
      uVar6 = uRam0000000103900170;
      lVar9 = lRam0000000103900168;
      *(long *)(lVar5 + 0x40) = lRam0000000103900168;
      *(undefined8 *)(lVar5 + 0x28) = uVar6;
      *(undefined8 *)(lVar5 + 0x18) = *(undefined8 *)(lVar9 + 0x30);
      plVar1 = plRam0000000103900130;
      *(undefined8 *)(lVar5 + 0x10) = *(undefined8 *)(lVar9 + 0x28);
      DataMemoryBarrier(2,3);
      *plVar1 = lVar5;
    }
    uVar4 = func_0x000100366d54(param_2,lVar5);
    lVar5 = func_0x000100331820(uRam0000000103900138,0x80);
    DataMemoryBarrier(2,3);
    *(long *)(lVar5 + 0x20) = param_1;
    *(undefined1 *)(((ulong)(lVar5 + 0x20) >> 9 & 0x7fffff) + lVar8) = 1;
    uVar6 = uRam0000000103900148;
    lVar8 = lRam0000000103900140;
    *(long *)(lVar5 + 0x40) = lRam0000000103900140;
    *(undefined8 *)(lVar5 + 0x28) = uVar6;
    *(undefined8 *)(lVar5 + 0x18) = *(undefined8 *)(lVar8 + 0x30);
    *(undefined8 *)(lVar5 + 0x10) = *(undefined8 *)(lVar8 + 0x28);
    uVar4 = func_0x00010037735c(uVar4,lVar5);
    uVar6 = _UNK_10369cf18;
    if (lVar7 != 0) {
      func_0x000100377370(lVar7,uVar4);
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101df75d0);
  (*pcVar3)();
}

