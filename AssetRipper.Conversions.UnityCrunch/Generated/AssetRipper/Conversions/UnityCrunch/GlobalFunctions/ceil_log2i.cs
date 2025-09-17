using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?ceil_log2i@math@crnd@@YAII@Z")]
[DemangledName("unsigned int __cdecl crnd::math::ceil_log2i(unsigned int)")]
internal static partial class ceil_log2i
{
	public static int Invoke(int v)
	{
		int num = 0;
		int num2 = 0;
		num = v;
		num2 = floor_log2i.Invoke(num);
		unchecked
		{
			if (num2 != 32 && (uint)num > (uint)(1 << num2))
			{
				num2++;
			}
			return num2;
		}
	}
}
