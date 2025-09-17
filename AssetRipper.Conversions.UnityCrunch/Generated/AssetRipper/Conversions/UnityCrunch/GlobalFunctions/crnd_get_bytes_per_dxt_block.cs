using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_get_bytes_per_dxt_block@crnd@@YAIW4crn_format@@@Z")]
[DemangledName("unsigned int __cdecl crnd::crnd_get_bytes_per_dxt_block(enum crn_format)")]
internal static partial class crnd_get_bytes_per_dxt_block
{
	public static int Invoke(int fmt)
	{
		return crnd_get_crn_format_bits_per_texel.Invoke(fmt) << 4 >>> 3;
	}
}
