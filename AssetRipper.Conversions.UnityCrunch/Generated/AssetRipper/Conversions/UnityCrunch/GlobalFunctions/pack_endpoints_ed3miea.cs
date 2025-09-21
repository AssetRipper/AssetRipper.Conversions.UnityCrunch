using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?pack_endpoints@dxt5_block@crnd@@SAIII@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt5_block::pack_endpoints(unsigned int, unsigned int)")]
[CleanName("pack_endpoints")]
internal static partial class pack_endpoints_ed3miea
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("unsigned int")] int lo, [NativeType("unsigned int")] int hi)
	{
		if (unchecked((uint)lo > 255u || (uint)hi > 255u))
		{
			crnd_assert.Invoke(String_7bcfjea.__pointer, String_yguirrd.__pointer, 2924);
		}
		return lo | (hi << 8);
	}
}
