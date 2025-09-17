using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?is_power_of_2@math@crnd@@YA_NI@Z")]
[DemangledName("bool __cdecl crnd::math::is_power_of_2(unsigned int)")]
internal static partial class is_power_of_2
{
	public static bool Invoke(int x)
	{
		int num = 0;
		num = x;
		return num != 0 && (num & unchecked(num - 1)) == 0;
	}
}
