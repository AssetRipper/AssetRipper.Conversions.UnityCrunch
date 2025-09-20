using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_bits_init@symbol_codec@crnd@@AEAAXXZ")]
[DemangledName("private: void __cdecl crnd::symbol_codec::get_bits_init(void)")]
internal static partial class Get_bits_init
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			((crnd_symbol_codec*)@this)->field_4 = 0;
			((crnd_symbol_codec*)@this)->field_5 = 0;
		}
	}
}
