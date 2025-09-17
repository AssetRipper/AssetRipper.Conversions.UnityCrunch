using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?floor_log2i@math@crnd@@YAII@Z")]
[DemangledName("unsigned int __cdecl crnd::math::floor_log2i(unsigned int)")]
internal static partial class floor_log2i
{
	public static int Invoke(int v)
	{
		int num = 0;
		int num2 = 0;
		num = v;
		num2 = 0;
		unchecked
		{
			while ((uint)num > 1u)
			{
				num >>>= 1;
				num2++;
			}
			return num2;
		}
	}
}
