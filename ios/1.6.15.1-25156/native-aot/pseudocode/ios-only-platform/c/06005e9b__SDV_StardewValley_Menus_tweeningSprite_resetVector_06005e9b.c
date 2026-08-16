/* 0x06005e9b StardewValley.Menus.tweeningSprite.resetVector @ 0x101e2422c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_tweeningSprite_resetVector_06005e9b
               (undefined4 param_1,undefined4 param_2,undefined4 param_3,undefined4 param_4,
               long param_5)

{
  int iVar1;
  int iVar2;
  int iVar3;
  code *pcVar4;
  undefined8 uVar5;
  long lVar6;
  
  lVar6 = *(long *)(param_5 + 0x28);
  if (lVar6 == 0) {
    *(undefined4 *)(param_5 + 0x34) = param_1;
    *(undefined4 *)(param_5 + 0x38) = param_2;
    *(undefined4 *)(param_5 + 0x3c) = param_3;
    *(undefined4 *)(param_5 + 0x40) = param_4;
    return;
  }
  uVar5 = _UNK_1036a3198;
  if ((int *)(lVar6 + 0x38) != (int *)0x0) {
    iVar1 = *(int *)(lVar6 + 0x40);
    iVar2 = *(int *)(lVar6 + 0x44);
    iVar3 = *(int *)(lVar6 + 0x3c);
    if (iVar1 < 0) {
      iVar1 = iVar1 + 1;
    }
    if (iVar2 < 0) {
      iVar2 = iVar2 + 1;
    }
    *(float *)(param_5 + 0x3c) = (float)(*(int *)(lVar6 + 0x38) + (iVar1 >> 1));
    *(float *)(param_5 + 0x40) = (float)(iVar3 + (iVar2 >> 1));
    if (*(char *)(param_5 + 0x54) != '\0') {
      *(undefined8 *)(param_5 + 0x34) = *(undefined8 *)(param_5 + 0x3c);
      return;
    }
    lVar6 = *(long *)(param_5 + 0x28);
    uVar5 = _UNK_1036a31a0;
    if ((lVar6 != 0) && (uVar5 = _UNK_1036a31a8, (int *)(lVar6 + 0x38) != (int *)0x0)) {
      iVar1 = *(int *)(lVar6 + 0x40);
      iVar2 = *(int *)(lVar6 + 0x44);
      iVar3 = *(int *)(lVar6 + 0x3c);
      if (iVar1 < 0) {
        iVar1 = iVar1 + 1;
      }
      if (iVar2 < 0) {
        iVar2 = iVar2 + 1;
      }
      *(float *)(param_5 + 0x34) = (float)(*(int *)(lVar6 + 0x38) + (iVar1 >> 1) + -0x40);
      *(float *)(param_5 + 0x38) = (float)(iVar3 + (iVar2 >> 1) + 0x40);
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101e2431c);
  (*pcVar4)();
}

