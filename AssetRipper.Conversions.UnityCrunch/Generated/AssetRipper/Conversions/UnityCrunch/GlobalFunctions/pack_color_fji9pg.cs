using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?pack_color@dxt1_block@crnd@@SAGIII_NI@Z")]
[DemangledName("public: static unsigned short __cdecl crnd::dxt1_block::pack_color(unsigned int, unsigned int, unsigned int, bool, unsigned int)")]
[CleanName("pack_color")]
internal static partial class pack_color_fji9pg
{
	[return: NativeType("unsigned short")]
	public unsafe static short Invoke([NativeType("unsigned int")] int r, [NativeType("unsigned int")] int g, [NativeType("unsigned int")] int b, [NativeType("bool")] bool scaled, [NativeType("unsigned int")] int bias)
	{
		crnd_color_quad crnd_color_quad2 = default(crnd_color_quad);
		sbyte b2 = (scaled ? ((sbyte)1) : ((sbyte)0));
		bool scaled2 = (b2 & 1) == 1;
		color_quad_unsigned_char_int_Constructor.Invoke(&crnd_color_quad2, r, g, b, 0);
		return pack_color_ej3cup.Invoke(&crnd_color_quad2, scaled2, bias);
	}
}
