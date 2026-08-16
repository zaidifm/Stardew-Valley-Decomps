/* 0x06006225 StardewValley.Menus.TransferredItemSprite.Update @ 0x101ecda54 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Menus_TransferredItemSprite_Update_06006225(long param_1,long param_2)

{
  code *pcVar1;
  undefined8 uVar2;
  float fVar3;
  
  uVar2 = _UNK_1036b7080;
  if ((param_1 != 0) && (uVar2 = _UNK_1036b7088, param_1 != -0x1c)) {
    *(float *)(param_1 + 0x1c) =
         *(float *)(param_1 + 0x1c) +
         (float)((double)*(long *)(param_2 + 0x18) / 10000000.0) * -128.0;
    fVar3 = *(float *)(param_1 + 0x20) + (float)((double)*(long *)(param_2 + 0x18) / 10000000.0);
    *(float *)(param_1 + 0x20) = fVar3;
    *(float *)(param_1 + 0x24) = 1.0 - fVar3 / 0.15;
    return 0.15 <= fVar3;
  }
  func_0x0001003316f4(0xee,uVar2);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101ecdb04);
  (*pcVar1)();
}

