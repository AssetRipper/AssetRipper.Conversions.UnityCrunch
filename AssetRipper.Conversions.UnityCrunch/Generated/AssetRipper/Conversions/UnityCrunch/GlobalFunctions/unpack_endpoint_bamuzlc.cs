using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_endpoint@dxt1_block@crnd@@SA?AV?$color_quad@EH@2@II_NI@Z")]
[DemangledName("public: static class crnd::color_quad<unsigned char, int> __cdecl crnd::dxt1_block::unpack_endpoint(unsigned int, unsigned int, bool, unsigned int)")]
[CleanName("unpack_endpoint")]
internal static partial class unpack_endpoint_bamuzlc
{
	public unsafe static void Invoke(crnd_color_quad* agg_result, int endpoints, int index, bool scaled, int alpha)
	{
		int num = 0;
		sbyte b = 0;
		int num2 = 0;
		int num3 = 0;
		num = alpha;
		b = (scaled ? ((sbyte)1) : ((sbyte)0));
		num2 = index;
		num3 = endpoints;
		unchecked
		{
			int num4;
			if ((uint)num2 < 2u)
			{
				num4 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_4tt2t2d.__pointer, String_yguirrd.__pointer, 2821);
				num4 = 0;
			}
			unpack_color_ifs9dpd.Invoke(agg_result, (short)((num3 >>> num2 * 16) & 0xFFFF), (b & 1) == 1, num);
		}
	}
}
