using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_color@dxt1_block@crnd@@SAXAEAI00G_N@Z")]
[DemangledName("public: static void __cdecl crnd::dxt1_block::unpack_color(unsigned int &, unsigned int &, unsigned int &, unsigned short, bool)")]
[CleanName("unpack_color")]
internal static partial class unpack_color_dn9xcr
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned int &")] void* r, [NativeType("unsigned int &")] void* g, [NativeType("unsigned int &")] void* b, [NativeType("unsigned short")] short packed_color, [NativeType("bool")] bool scaled)
	{
		crnd_color_quad crnd_color_quad2 = default(crnd_color_quad);
		bool num = scaled;
		short packed_color2 = packed_color;
		unpack_color_gac4s5.Invoke(&crnd_color_quad2, packed_color2, ((num ? 1u : 0u) & 1u) == 1, 0);
		unchecked
		{
			*(int*)r = (byte)((anon_m9uqrv*)(&crnd_color_quad2.field))->field_0;
			*(int*)g = (byte)((anon_m9uqrv*)(&crnd_color_quad2.field))->field_1;
			*(int*)b = (byte)((anon_m9uqrv*)(&crnd_color_quad2.field))->field_2;
		}
	}
}
