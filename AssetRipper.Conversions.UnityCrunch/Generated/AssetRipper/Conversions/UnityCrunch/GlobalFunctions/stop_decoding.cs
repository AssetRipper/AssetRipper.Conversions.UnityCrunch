using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?stop_decoding@symbol_codec@crnd@@QEAA_KXZ")]
[DemangledName("public: unsigned __int64 __cdecl crnd::symbol_codec::stop_decoding(void)")]
internal static partial class stop_decoding
{
	public unsafe static long Invoke(void* @this)
	{
		return unchecked((long)((crnd_symbol_codec*)@this)->field_1 - (long)((crnd_symbol_codec*)@this)->field_0);
	}
}
