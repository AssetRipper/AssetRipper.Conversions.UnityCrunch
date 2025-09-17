using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?total_bits@math@crnd@@YAII@Z")]
[DemangledName("unsigned int __cdecl crnd::math::total_bits(unsigned int)")]
internal static partial class total_bits
{
	public static int Invoke(int v)
	{
		int num = 0;
		int num2 = 0;
		num = v;
		num2 = 0;
		while (num != 0)
		{
			num >>>= 1;
			num2 = unchecked(num2 + 1);
		}
		return num2;
	}
}
