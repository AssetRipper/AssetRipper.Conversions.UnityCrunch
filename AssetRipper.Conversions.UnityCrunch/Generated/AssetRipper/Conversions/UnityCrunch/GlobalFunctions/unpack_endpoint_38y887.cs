using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_endpoint@dxt1_block@crnd@@SA?AV?$color_quad@EH@2@II_NI@Z")]
[DemangledName("public: static class crnd::color_quad<unsigned char, int> __cdecl crnd::dxt1_block::unpack_endpoint(unsigned int, unsigned int, bool, unsigned int)")]
[CleanName("unpack_endpoint")]
internal static partial class unpack_endpoint_38y887
{
	[return: NativeType("class crnd::color_quad<unsigned char, int>")]
	public unsafe static void Invoke([MangledName("agg.result")] crnd_color_quad* agg_result, [NativeType("unsigned int")] int endpoints, [NativeType("unsigned int")] int index, [NativeType("bool")] bool scaled, [NativeType("unsigned int")] int alpha)
	{
		sbyte b = (scaled ? ((sbyte)1) : ((sbyte)0));
		unchecked
		{
			if ((uint)index >= 2u)
			{
				crnd_assert.Invoke(String_6s4rgc.__pointer, String_vvx8bt.__pointer, 2821);
			}
			unpack_color_gac4s5.Invoke(agg_result, (short)((endpoints >>> index * 16) & 0xFFFF), (b & 1) == 1, alpha);
		}
	}
}
