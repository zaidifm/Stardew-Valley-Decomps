/* 0x06005e9c StardewValley.Menus.tweeningSprite.start @ 0x101e2431c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_tweeningSprite_start_06005e9c(long param_1)

{
  char cVar1;
  code *pcVar2;
  undefined4 uVar3;
  undefined4 uVar4;
  undefined4 uVar5;
  undefined4 uVar6;
  
  cVar1 = cRam0000000103910cab;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103317be0);
    cRam0000000103910cab = '\x01';
  }
  if (param_1 == 0) {
    func_0x0001003316f4(0xee,_UNK_1036a31b0);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x101e243e4);
    (*pcVar2)();
  }
  *(undefined1 *)(param_1 + 0x30) = 1;
  if (*(long *)(param_1 + 0x10) != 0) {
    if (*(char *)(param_1 + 0x31) == '\0') {
      uVar5 = *(undefined4 *)(param_1 + 0x3c);
      uVar6 = *(undefined4 *)(param_1 + 0x40);
      uVar3 = *(undefined4 *)(param_1 + 0x34);
      uVar4 = *(undefined4 *)(param_1 + 0x38);
    }
    else {
      uVar3 = 0;
      uVar4 = 0;
      uVar5 = 0x3f800000;
      uVar6 = 0x3f800000;
    }
    func_0x000100378284(uRam0000000103900a70,uVar3,uVar4,uVar5,uVar6,*(undefined4 *)(param_1 + 0x44)
                        ,*(long *)(param_1 + 0x10),*puRam00000001038d50a0);
  }
  return;
}

