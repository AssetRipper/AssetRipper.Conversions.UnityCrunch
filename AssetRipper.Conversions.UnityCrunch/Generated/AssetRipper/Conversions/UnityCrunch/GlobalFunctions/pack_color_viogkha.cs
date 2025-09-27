using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?pack_color@dxt1_block@crnd@@SAGAEBV?$color_quad@EH@2@_NI@Z")]
[DemangledName("public: static unsigned short __cdecl crnd::dxt1_block::pack_color(class crnd::color_quad<unsigned char, int> const &, bool, unsigned int)")]
[CleanName("pack_color")]
internal static partial class pack_color_viogkha
{
	[return: NativeType("unsigned short")]
	public unsafe static short Invoke([NativeType("class crnd::color_quad<unsigned char, int> const &")] void* color, [NativeType("bool")] bool scaled, [NativeType("unsigned int")] int bias)
	{
		bool num = scaled;
		unchecked
		{
			int num2 = (byte)((anon_b9ijpuc*)(&((crnd_color_quad*)color)->field))->field_0;
			int num3 = (byte)((anon_b9ijpuc*)(&((crnd_color_quad*)color)->field))->field_1;
			int num4 = (byte)((anon_b9ijpuc*)(&((crnd_color_quad*)color)->field))->field_2;
			if (((num ? 1u : 0u) & 1u) == 1)
			{
				num2 = (int)((uint)(num2 * 31 + bias) / 255u);
				num3 = (int)((uint)(num3 * 63 + bias) / 255u);
				num4 = (int)((uint)(num4 * 31 + bias) / 255u);
			}
			num2 = minimum.Invoke(num2, 31);
			num3 = minimum.Invoke(num3, 63);
			return (short)(minimum.Invoke(num4, 31) | (num3 << 5) | (num2 << 11));
		}
	}
}
