using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?compute_max_mips@utils@crnd@@YAIII@Z")]
[DemangledName("unsigned int __cdecl crnd::utils::compute_max_mips(unsigned int, unsigned int)")]
internal static partial class compute_max_mips
{
	[return: NativeType("unsigned int")]
	public static int Invoke([NativeType("unsigned int")] int width, [NativeType("unsigned int")] int height)
	{
		int num = height;
		int num2 = width;
		if ((num2 | num) == 0)
		{
			return 0;
		}
		int num3 = 1;
		unchecked
		{
			while (((uint)num2 <= 1u) ? ((uint)num > 1u) : true)
			{
				num2 >>>= 1;
				num >>>= 1;
				num3++;
			}
			return num3;
		}
	}
}
