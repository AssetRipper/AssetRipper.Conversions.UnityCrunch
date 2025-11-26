using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_color@dxt1_block@crnd@@SA?AV?$color_quad@EH@2@G_NI@Z")]
[DemangledName("public: static class crnd::color_quad<unsigned char, int> __cdecl crnd::dxt1_block::unpack_color(unsigned short, bool, unsigned int)")]
[CleanName("unpack_color")]
internal static partial class unpack_color_gac4s5
{
	[return: NativeType("class crnd::color_quad<unsigned char, int>")]
	public unsafe static void Invoke([MangledName("agg.result")] crnd_color_quad* agg_result, [NativeType("unsigned short")] short packed_color, [NativeType("bool")] bool scaled, [NativeType("unsigned int")] int alpha)
	{
		bool num = scaled;
		short num2 = packed_color;
		unchecked
		{
			int num3 = (ushort)num2 & 0x1F;
			int num4 = ((ushort)num2 >> 5) & 0x3F;
			int num5 = ((ushort)num2 >> 11) & 0x1F;
			if (((num ? 1u : 0u) & 1u) == 1)
			{
				num3 = (num3 << 3) | (num3 >>> 2);
				num4 = (num4 << 2) | (num4 >>> 4);
				num5 = (num5 << 3) | (num5 >>> 2);
			}
			color_quad_unsigned_char_int_Constructor.Invoke(agg_result, num5, num4, num3, alpha);
		}
	}
}
