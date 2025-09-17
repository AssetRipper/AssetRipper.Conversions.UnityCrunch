using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?pack_endpoints@dxt5_block@crnd@@SAIII@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt5_block::pack_endpoints(unsigned int, unsigned int)")]
[CleanName("pack_endpoints")]
internal static partial class pack_endpoints_ed3miea
{
	public unsafe static int Invoke(int lo, int hi)
	{
		int num = 0;
		int num2 = 0;
		num = hi;
		num2 = lo;
		int num3;
		if (unchecked((uint)num2 <= 255u && (uint)num <= 255u))
		{
			num3 = -1;
		}
		else
		{
			crnd_assert.Invoke(String_7bcfjea.__pointer, String_yguirrd.__pointer, 2924);
			num3 = 0;
		}
		return num2 | (num << 8);
	}
}
