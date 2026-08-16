/* 0x06006631 StardewValley.Mobile.AStarNode.get_NodeCenterOnMap @ 0x101fa8398 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

float SDV_StardewValley_Mobile_AStarNode_get_NodeCenterOnMap_06006631(long param_1)

{
  code *pcVar1;
  
  if (param_1 != 0) {
    return (float)(*(int *)(param_1 + 0x34) << 6) + 32.0;
  }
  func_0x0001003316f4(0xee,_UNK_1036d29b0);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fa83dc);
  (*pcVar1)();
}

