using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?compute_max_mips@utils@crnd@@YAIII@Z")]
[DemangledName("unsigned int __cdecl crnd::utils::compute_max_mips(unsigned int, unsigned int)")]
internal static partial class compute_max_mips
{
	public static int Invoke(int width, int height)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		num2 = height;
		num3 = width;
		if ((num3 | num2) == 0)
		{
			return 0;
		}
		num4 = 1;
		unchecked
		{
			while (((uint)num3 <= 1u) ? ((uint)num2 > 1u) : true)
			{
				num3 >>>= 1;
				num2 >>>= 1;
				num4++;
			}
			return num4;
		}
	}
}
