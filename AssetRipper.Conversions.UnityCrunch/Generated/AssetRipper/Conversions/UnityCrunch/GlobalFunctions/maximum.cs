using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$maximum@I@math@crnd@@YAIII@Z")]
[DemangledName("unsigned int __cdecl crnd::math::maximum<unsigned int>(unsigned int, unsigned int)")]
internal static partial class maximum
{
	public static int Invoke(int a, int b)
	{
		int num = 0;
		int num2 = 0;
		num = b;
		num2 = a;
		return unchecked((uint)num2 <= (uint)num) ? num : num2;
	}
}
