/* 0x060032e9 StardewValley.CloudSync.GetTimestamp @ 0x10179f608 */

ulong SDV_StardewValley_CloudSync_GetTimestamp_060032e9(undefined8 param_1)

{
  ulong uVar1;
  ulong uVar2;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar1 = func_0x000100357994(param_1);
  uVar2 = func_0x0001003579a8(param_1);
  if ((uVar1 & 0x3fffffffffffffff) <= (uVar2 & 0x3fffffffffffffff)) {
    uVar1 = uVar2;
  }
  return uVar1;
}

