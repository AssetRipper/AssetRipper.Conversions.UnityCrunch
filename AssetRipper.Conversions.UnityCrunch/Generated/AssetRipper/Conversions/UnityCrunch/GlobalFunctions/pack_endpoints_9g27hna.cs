using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?pack_endpoints@dxt1_block@crnd@@SAIII@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt1_block::pack_endpoints(unsigned int, unsigned int)")]
[CleanName("pack_endpoints")]
internal static partial class pack_endpoints_9g27hna
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("unsigned int")] int lo, [NativeType("unsigned int")] int hi)
	{
		int num;
		if (unchecked((uint)lo <= 65535u && (uint)hi <= 65535u))
		{
			num = -1;
		}
		else
		{
			crnd_assert.Invoke(String_myspu3d.__pointer, String_yguirrd.__pointer, 2826);
			num = 0;
		}
		return lo | (hi << 16);
	}
}
