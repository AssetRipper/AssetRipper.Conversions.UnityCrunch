using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_get_fundamental_dxt_format@crnd@@YA?AW4crn_format@@W42@@Z")]
[DemangledName("enum crn_format __cdecl crnd::crnd_get_fundamental_dxt_format(enum crn_format)")]
internal static partial class crnd_get_fundamental_dxt_format
{
	public static int Invoke(int fmt)
	{
		int num = 0;
		int num2 = 0;
		num2 = fmt;
		int num3 = num2;
		if (num3 == 3 || num3 == 4 || num3 == 5 || num3 == 6)
		{
			return 2;
		}
		return num2;
	}
}
