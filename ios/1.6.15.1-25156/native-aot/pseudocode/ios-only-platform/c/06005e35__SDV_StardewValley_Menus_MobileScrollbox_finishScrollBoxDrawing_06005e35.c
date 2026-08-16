/* 0x06005e35 StardewValley.Menus.MobileScrollbox.finishScrollBoxDrawing @ 0x101e1be44 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileScrollbox_finishScrollBoxDrawing_06005e35
               (float param_1,long param_2,long param_3)

{
  char cVar1;
  code *pcVar2;
  undefined8 *puVar3;
  undefined8 uVar4;
  undefined8 uVar5;
  undefined8 uStack_180;
  undefined8 uStack_178;
  undefined8 uStack_170;
  undefined8 uStack_168;
  undefined8 uStack_160;
  undefined8 uStack_158;
  undefined8 uStack_150;
  undefined8 uStack_148;
  undefined4 uStack_140;
  undefined8 uStack_130;
  undefined8 uStack_128;
  undefined8 uStack_120;
  undefined8 uStack_118;
  undefined8 uStack_110;
  undefined8 uStack_108;
  undefined8 uStack_100;
  undefined8 uStack_f8;
  undefined4 uStack_f0;
  undefined4 uStack_e0;
  undefined4 uStack_dc;
  undefined4 uStack_d8;
  undefined4 uStack_d4;
  undefined4 uStack_d0;
  undefined4 uStack_cc;
  undefined4 uStack_c8;
  undefined4 uStack_c4;
  undefined4 uStack_c0;
  undefined4 uStack_bc;
  undefined4 uStack_b8;
  undefined4 uStack_b4;
  undefined4 uStack_b0;
  undefined4 uStack_ac;
  undefined4 uStack_a8;
  undefined4 uStack_a4;
  undefined4 uStack_a0;
  undefined8 uStack_90;
  undefined8 uStack_88;
  undefined8 uStack_80;
  undefined8 uStack_78;
  undefined8 uStack_70;
  undefined8 uStack_68;
  undefined8 uStack_60;
  undefined8 uStack_58;
  
  cVar1 = cRam0000000103910c44;
  puVar3 = &uStack_180;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103317590);
    cRam0000000103910c44 = '\x01';
  }
  uVar4 = _UNK_1036a2718;
  if (((param_3 != 0) && (func_0x00010033199c(param_3), uVar4 = _UNK_1036a2720, param_2 != 0)) &&
     (uVar4 = _UNK_1036a2728, *(long *)(param_3 + 0x10) != 0)) {
    func_0x0001003703a4(*(long *)(param_3 + 0x10),*(undefined8 *)(param_2 + 0x68),
                        *(undefined8 *)(param_2 + 0x70));
    if (param_1 == 1.0) {
      if (*(char *)(lRam00000001038d53e8 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar4 = *puRam00000001038d53f0;
      if (*(char *)(lRam00000001038d53f8 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      puVar3 = &uStack_130;
      uVar5 = *puRam00000001038d5400;
      uStack_128 = 0;
      uStack_130 = 0;
      uStack_118 = 0;
      uStack_120 = 0;
      uStack_108 = 0;
      uStack_110 = 0;
      uStack_f8 = 0;
      uStack_100 = 0;
      uStack_f0 = 0;
    }
    else {
      if (*(char *)(lRam00000001038d53e8 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar4 = *puRam00000001038d53f0;
      if (*(char *)(lRam00000001038d53f8 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar5 = *puRam00000001038d5400;
      func_0x000100356030(&uStack_90,param_1);
      uStack_d4 = (undefined4)uStack_88;
      uStack_d0 = (undefined4)((ulong)uStack_88 >> 0x20);
      uStack_dc = (undefined4)uStack_90;
      uStack_d8 = (undefined4)((ulong)uStack_90 >> 0x20);
      uStack_c4 = (undefined4)uStack_78;
      uStack_c0 = (undefined4)((ulong)uStack_78 >> 0x20);
      uStack_cc = (undefined4)uStack_80;
      uStack_c8 = (undefined4)((ulong)uStack_80 >> 0x20);
      uStack_b4 = (undefined4)uStack_68;
      uStack_b0 = (undefined4)((ulong)uStack_68 >> 0x20);
      uStack_bc = (undefined4)uStack_70;
      uStack_b8 = (undefined4)((ulong)uStack_70 >> 0x20);
      uStack_a4 = (undefined4)uStack_58;
      uStack_a0 = (undefined4)((ulong)uStack_58 >> 0x20);
      uStack_ac = (undefined4)uStack_60;
      uStack_a8 = (undefined4)((ulong)uStack_60 >> 0x20);
      uStack_e0 = 1;
      uStack_158 = CONCAT44(uStack_b4,uStack_b8);
      uStack_160 = CONCAT44(uStack_bc,uStack_c0);
      uStack_148 = CONCAT44(uStack_a4,uStack_a8);
      uStack_150 = CONCAT44(uStack_ac,uStack_b0);
      uStack_140 = uStack_a0;
      uStack_178 = CONCAT44(uStack_d4,uStack_d8);
      uStack_180 = CONCAT44(uStack_dc,1);
      uStack_168 = CONCAT44(uStack_c4,uStack_c8);
      uStack_170 = CONCAT44(uStack_cc,uStack_d0);
    }
    func_0x00010033194c(param_3,0,uVar4,uVar5,0,0,0,puVar3);
    return;
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e1c034);
  (*pcVar2)();
}

