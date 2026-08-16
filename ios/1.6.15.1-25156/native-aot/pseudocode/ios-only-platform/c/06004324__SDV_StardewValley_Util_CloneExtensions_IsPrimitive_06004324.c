/* 0x06004324 StardewValley.Util.CloneExtensions.IsPrimitive @ 0x101a3cea8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

uint SDV_StardewValley_Util_CloneExtensions_IsPrimitive_06004324(long param_1)

{
  code *pcVar1;
  char cVar2;
  uint uVar3;
  uint uVar4;
  
  cVar2 = cRam000000010390f133;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1032eec3d);
    cRam000000010390f133 = '\x01';
  }
  cVar2 = func_0x000100331be0(param_1,uRam00000001038c4d38);
  if (cVar2 == '\0') {
    if (param_1 == 0) {
      func_0x0001003316f4(0xee,_UNK_10363a930);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101a3cf54);
      (*pcVar1)();
    }
    uVar3 = func_0x000100367c40(param_1);
    uVar4 = func_0x000100367c54(param_1);
    uVar4 = uVar4 & uVar3;
  }
  else {
    uVar4 = 1;
  }
  return uVar4;
}

