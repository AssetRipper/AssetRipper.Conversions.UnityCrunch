using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_color@dxt1_block@crnd@@SA?AV?$color_quad@EH@2@G_NI@Z")]
[DemangledName("public: static class crnd::color_quad<unsigned char, int> __cdecl crnd::dxt1_block::unpack_color(unsigned short, bool, unsigned int)")]
[CleanName("unpack_color")]
internal static partial class unpack_color_ifs9dpd
{
	public unsafe static void Invoke(crnd_color_quad* agg_result, short packed_color, bool scaled, int alpha)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		num = alpha;
		bool num5 = scaled;
		short num6 = packed_color;
		unchecked
		{
			num2 = (ushort)num6 & 0x1F;
			num3 = ((ushort)num6 >> 5) & 0x3F;
			num4 = ((ushort)num6 >> 11) & 0x1F;
			if (((num5 ? 1u : 0u) & 1u) == 1)
			{
				num2 = (num2 << 3) | (num2 >>> 2);
				num3 = (num3 << 2) | (num3 >>> 4);
				num4 = (num4 << 3) | (num4 >>> 2);
			}
			color_quad_unsigned_char_int_Constructor.Invoke(agg_result, num4, num3, num2, num);
		}
	}
}
