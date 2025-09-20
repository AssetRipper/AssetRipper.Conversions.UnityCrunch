using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?compute_max_mips@utils@crnd@@YAIII@Z")]
[DemangledName("unsigned int __cdecl crnd::utils::compute_max_mips(unsigned int, unsigned int)")]
internal static partial class compute_max_mips
{
	[return: NativeType("unsigned int")]
	public static int Invoke([NativeType("unsigned int")] int width, [NativeType("unsigned int")] int height)
	{
		int num = 0;
		int num2 = 0;
		int num3 = height;
		int num4 = width;
		if ((num4 | num3) == 0)
		{
			return 0;
		}
		num2 = 1;
		unchecked
		{
			while (((uint)num4 <= 1u) ? ((uint)num3 > 1u) : true)
			{
				num4 >>>= 1;
				num3 >>>= 1;
				num2++;
			}
			return num2;
		}
	}
}
