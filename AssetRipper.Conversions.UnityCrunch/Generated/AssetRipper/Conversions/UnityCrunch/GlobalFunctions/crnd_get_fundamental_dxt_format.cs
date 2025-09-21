using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_get_fundamental_dxt_format@crnd@@YA?AW4crn_format@@W42@@Z")]
[DemangledName("enum crn_format __cdecl crnd::crnd_get_fundamental_dxt_format(enum crn_format)")]
internal static partial class crnd_get_fundamental_dxt_format
{
	[return: NativeType("enum crn_format")]
	public static int Invoke([NativeType("enum crn_format")] int fmt)
	{
		if (fmt == 3 || fmt == 4 || fmt == 5 || fmt == 6)
		{
			return 2;
		}
		return fmt;
	}
}
