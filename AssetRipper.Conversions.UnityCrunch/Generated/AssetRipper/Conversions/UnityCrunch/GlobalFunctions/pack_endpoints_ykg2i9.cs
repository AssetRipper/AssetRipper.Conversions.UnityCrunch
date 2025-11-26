using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?pack_endpoints@dxt1_block@crnd@@SAIII@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt1_block::pack_endpoints(unsigned int, unsigned int)")]
[CleanName("pack_endpoints")]
internal static partial class pack_endpoints_ykg2i9
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("unsigned int")] int lo, [NativeType("unsigned int")] int hi)
	{
		if (unchecked((uint)lo > 65535u || (uint)hi > 65535u))
		{
			crnd_assert.Invoke(String_fp3rum.__pointer, String_vvx8bt.__pointer, 2826);
		}
		return lo | (hi << 16);
	}
}
