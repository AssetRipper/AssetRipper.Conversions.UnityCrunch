using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?pack_endpoints@dxt1_block@crnd@@SAIII@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt1_block::pack_endpoints(unsigned int, unsigned int)")]
[CleanName("pack_endpoints")]
internal static partial class pack_endpoints_9g27hna
{
	public unsafe static int Invoke(int lo, int hi)
	{
		int num = 0;
		int num2 = 0;
		num = hi;
		num2 = lo;
		int num3;
		if (unchecked((uint)num2 <= 65535u && (uint)num <= 65535u))
		{
			num3 = -1;
		}
		else
		{
			crnd_assert.Invoke(String_myspu3d.__pointer, String_yguirrd.__pointer, 2826);
			num3 = 0;
		}
		return num2 | (num << 16);
	}
}
