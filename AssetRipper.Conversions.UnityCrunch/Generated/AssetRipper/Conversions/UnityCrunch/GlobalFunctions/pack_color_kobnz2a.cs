using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?pack_color@dxt1_block@crnd@@SAGIII_NI@Z")]
[DemangledName("public: static unsigned short __cdecl crnd::dxt1_block::pack_color(unsigned int, unsigned int, unsigned int, bool, unsigned int)")]
[CleanName("pack_color")]
internal static partial class pack_color_kobnz2a
{
	public unsafe static short Invoke(int r, int g, int b, bool scaled, int bias)
	{
		crnd_color_quad crnd_color_quad = default(crnd_color_quad);
		sbyte b2 = (scaled ? ((sbyte)1) : ((sbyte)0));
		bool scaled2 = (b2 & 1) == 1;
		color_quad_unsigned_char_int_Constructor.Invoke(&crnd_color_quad, r, g, b, 0);
		return pack_color_viogkha.Invoke(&crnd_color_quad, scaled2, bias);
	}
}
