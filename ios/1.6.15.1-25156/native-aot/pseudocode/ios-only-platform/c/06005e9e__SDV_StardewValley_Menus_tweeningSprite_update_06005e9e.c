/* 0x06005e9e StardewValley.Menus.tweeningSprite.update @ 0x101e24474 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_tweeningSprite_update_06005e9e(long param_1,long param_2)

{
  char cVar1;
  code *pcVar2;
  undefined8 uVar3;
  long lVar4;
  float fVar5;
  
  cVar1 = cRam0000000103910cad;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103910cad == '\0') goto LAB_101e245fc;
LAB_101e244a4:
    cVar1 = *(char *)(param_1 + 0x30);
  }
  else {
    func_0x00010119b8f8();
    if (cVar1 != '\0') goto LAB_101e244a4;
LAB_101e245fc:
    func_0x00010119b908(&UNK_103317bfa);
    cRam0000000103910cad = '\x01';
    cVar1 = *(char *)(param_1 + 0x30);
  }
  if ((cVar1 != '\0') && (*(long *)(param_1 + 0x10) != 0)) {
    func_0x0001003782ac((float)((*(long *)(param_2 + 0x18) / 10000) % 1000));
    lVar4 = *(long *)(param_1 + 0x18);
    if (*(char *)(param_1 + 0x31) == '\0') {
      if (lVar4 == 0) goto LAB_101e245d0;
      uVar3 = _UNK_1036a3208;
      if ((*(long *)(param_1 + 0x10) == 0) ||
         (uVar3 = _UNK_1036a3210, (int *)(lVar4 + 0x38) == (int *)0x0)) goto LAB_101e246bc;
      *(int *)(lVar4 + 0x38) = (int)*(float *)(*(long *)(param_1 + 0x10) + 0x3c);
      uVar3 = _UNK_1036a3218;
      if ((*(long *)(param_1 + 0x18) == 0) ||
         ((uVar3 = _UNK_1036a3220, *(long *)(param_1 + 0x10) == 0 ||
          (lVar4 = *(long *)(param_1 + 0x18) + 0x38, uVar3 = _UNK_1036a3228, lVar4 == 0))))
      goto LAB_101e246bc;
      fVar5 = *(float *)(*(long *)(param_1 + 0x10) + 0x40);
    }
    else {
      if (lVar4 == 0) goto LAB_101e245d0;
      uVar3 = _UNK_1036a31d0;
      if ((((param_1 == -0x34) || (uVar3 = _UNK_1036a31d8, *(long *)(param_1 + 0x10) == 0)) ||
          (uVar3 = _UNK_1036a31e0, param_1 == -0x3c)) ||
         (uVar3 = _UNK_1036a31e8, (int *)(lVar4 + 0x38) == (int *)0x0)) {
LAB_101e246bc:
        func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101e246c8);
        (*pcVar2)();
      }
      *(int *)(lVar4 + 0x38) =
           (int)(*(float *)(param_1 + 0x34) +
                *(float *)(*(long *)(param_1 + 0x10) + 0x3c) *
                (*(float *)(param_1 + 0x3c) - *(float *)(param_1 + 0x34)));
      uVar3 = _UNK_1036a31f0;
      if (((*(long *)(param_1 + 0x18) == 0) ||
          (uVar3 = _UNK_1036a31f8, *(long *)(param_1 + 0x10) == 0)) ||
         (lVar4 = *(long *)(param_1 + 0x18) + 0x38, uVar3 = _UNK_1036a3200, lVar4 == 0))
      goto LAB_101e246bc;
      fVar5 = *(float *)(param_1 + 0x38) +
              *(float *)(*(long *)(param_1 + 0x10) + 0x40) *
              (*(float *)(param_1 + 0x40) - *(float *)(param_1 + 0x38));
    }
    *(int *)(lVar4 + 4) = (int)fVar5;
  }
LAB_101e245d0:
  if ((*(long *)(param_1 + 0x10) != 0) && (*(int *)(*(long *)(param_1 + 0x10) + 0x28) != 0)) {
    *(undefined1 *)(param_1 + 0x30) = 0;
  }
  return;
}

