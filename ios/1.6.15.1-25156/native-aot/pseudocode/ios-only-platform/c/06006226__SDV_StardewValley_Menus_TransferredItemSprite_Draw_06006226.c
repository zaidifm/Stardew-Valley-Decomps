/* 0x06006226 StardewValley.Menus.TransferredItemSprite.Draw @ 0x101ecdb04 */

void SDV_StardewValley_Menus_TransferredItemSprite_Draw_06006226(long param_1,undefined8 param_2)

{
  undefined4 uVar1;
  long *plVar2;
  undefined4 uVar3;
  undefined4 uVar4;
  undefined4 uVar5;
  
  if (lRam0000000103976fb8 == 0) {
    plVar2 = *(long **)(param_1 + 0x10);
  }
  else {
    func_0x00010119b8f8();
    plVar2 = *(long **)(param_1 + 0x10);
  }
  uVar3 = *(undefined4 *)(param_1 + 0x18);
  uVar4 = *(undefined4 *)(param_1 + 0x1c);
  uVar5 = *(undefined4 *)(param_1 + 0x24);
  uVar1 = func_0x000100331988();
  (**(code **)(*plVar2 + 0x308))(uVar3,uVar4,0x3f800000,uVar5,0x3f666666,plVar2,param_2,0,uVar1,0);
  return;
}

