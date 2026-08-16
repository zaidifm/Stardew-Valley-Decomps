/* 0x0600432a StardewValley.Util.CloneExtensions.CopyFields @ 0x101a3d558 */

void SDV_StardewValley_Util_CloneExtensions_CopyFields_0600432a
               (undefined8 param_1,undefined8 param_2,undefined8 param_3,long *param_4,
               undefined4 param_5,long param_6)

{
  char cVar1;
  undefined8 uVar2;
  long lVar3;
  long *plVar4;
  ulong uVar5;
  undefined8 *puVar6;
  
  cVar1 = cRam000000010390f139;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1032eecd0);
    cRam000000010390f139 = '\x01';
    lVar3 = *param_4;
  }
  else {
    lVar3 = *param_4;
  }
  lVar3 = (**(code **)(lVar3 + 0x240))(param_4,param_5);
  uVar5 = (ulong)*(uint *)(lVar3 + 0x18);
  if (0 < (int)*(uint *)(lVar3 + 0x18)) {
    puVar6 = (undefined8 *)(lVar3 + 0x20);
    do {
      plVar4 = (long *)*puVar6;
      if ((param_6 == 0) || (cVar1 = (**(code **)(param_6 + 0x18))(param_6,plVar4), cVar1 != '\0'))
      {
        (**(code **)(*plVar4 + 0x128))(plVar4);
        cVar1 = SDV_StardewValley_Util_CloneExtensions_IsPrimitive_06004324();
        if (cVar1 == '\0') {
          uVar2 = (**(code **)(*plVar4 + 0x100))(plVar4,param_1);
          uVar2 = SDV_StardewValley_Util_CloneExtensions_InternalCopy_06004328(uVar2,param_2);
          func_0x000100332770(plVar4,param_3,uVar2);
        }
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      puVar6 = puVar6 + 1;
      uVar5 = uVar5 - 1;
    } while (uVar5 != 0);
  }
  return;
}

