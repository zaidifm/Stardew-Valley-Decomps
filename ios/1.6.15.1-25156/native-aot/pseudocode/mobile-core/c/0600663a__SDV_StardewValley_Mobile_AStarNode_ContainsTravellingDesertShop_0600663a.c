/* 0x0600663a StardewValley.Mobile.AStarNode.ContainsTravellingDesertShop @ 0x101fa8d00 */

bool SDV_StardewValley_Mobile_AStarNode_ContainsTravellingDesertShop_0600663a(long param_1)

{
  bool bVar1;
  char cVar2;
  long lVar3;
  undefined8 *puVar4;
  undefined8 uStack_40;
  undefined8 uStack_38;
  
  cVar2 = cRam0000000103911449;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103324af1);
    cRam0000000103911449 = '\x01';
    lVar3 = *(long *)(param_1 + 0x18);
  }
  else {
    lVar3 = *(long *)(param_1 + 0x18);
  }
  puVar4 = *(undefined8 **)(lVar3 + 0x10);
  if ((puVar4 == (undefined8 *)0x0) ||
     (lRam00000001038c6c18 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x10))) {
    bVar1 = false;
  }
  else {
    uStack_40 = 0;
    uStack_38 = 0;
    func_0x00010034ede4(&uStack_40,*(int *)(param_1 + 0x34) << 6,*(int *)(param_1 + 0x38) << 6,0x40,
                        0x40);
    cVar2 = func_0x00010035a4b4(puVar4 + 99,uStack_40,uStack_38);
    bVar1 = cVar2 != '\0';
  }
  return bVar1;
}

