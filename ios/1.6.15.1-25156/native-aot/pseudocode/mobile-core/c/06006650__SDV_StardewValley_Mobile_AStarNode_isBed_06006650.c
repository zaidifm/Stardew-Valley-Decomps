/* 0x06006650 StardewValley.Mobile.AStarNode.isBed @ 0x101fabfcc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_AStarNode_isBed_06006650(long param_1)

{
  char cVar1;
  code *pcVar2;
  long *plVar3;
  undefined8 uVar4;
  long lVar5;
  
  cVar1 = cRam000000010391145f;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103324d57);
    cRam000000010391145f = '\x01';
    lVar5 = *(long *)(param_1 + 0x18);
  }
  else {
    lVar5 = *(long *)(param_1 + 0x18);
  }
  if ((*(undefined8 **)(lVar5 + 0x10) != (undefined8 *)0x0) &&
     (lRam00000001038c6c50 ==
      *(long *)(*(long *)(*(long *)**(undefined8 **)(lVar5 + 0x10) + 0x10) + 0x18))) {
    StardewValley_StardewValley_Game1_get_player_06002f9a();
    lVar5 = func_0x000101a242f0();
    if (lVar5 == 0) {
      func_0x0001003316f4(0xee,_UNK_1036d30e0);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101fac0ec);
      (*pcVar2)();
    }
    plVar3 = (long *)func_0x000101c66fe0(lVar5,0xffffffff,0);
    if (plVar3 == (long *)0x0) {
      uVar4 = 0xfffffc18fffffc18;
    }
    else {
      uVar4 = (**(code **)(*plVar3 + 0x798))();
    }
    if (*(int *)(param_1 + 0x34) == (int)((float)(int)uVar4 * 64.0)) {
      return *(int *)(param_1 + 0x38) == (int)((float)(int)((ulong)uVar4 >> 0x20) * 64.0);
    }
  }
  return false;
}

