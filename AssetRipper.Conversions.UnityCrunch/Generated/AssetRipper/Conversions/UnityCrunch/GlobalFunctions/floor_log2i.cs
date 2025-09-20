using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?floor_log2i@math@crnd@@YAII@Z")]
[DemangledName("unsigned int __cdecl crnd::math::floor_log2i(unsigned int)")]
internal static partial class floor_log2i
{
	[return: NativeType("unsigned int")]
	public static int Invoke([NativeType("unsigned int")] int v)
	{
		int num = v;
		int num2 = 0;
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
