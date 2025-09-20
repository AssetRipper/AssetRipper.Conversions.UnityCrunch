using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?is_power_of_2@math@crnd@@YA_NI@Z")]
[DemangledName("bool __cdecl crnd::math::is_power_of_2(unsigned int)")]
internal static partial class is_power_of_2
{
	[return: NativeType("bool")]
	public static bool Invoke([NativeType("unsigned int")] int x)
	{
		return x != 0 && (x & unchecked(x - 1)) == 0;
	}
}
