using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("?g_bitmasks@math@crnd@@3PAIA")]
[DemangledName("unsigned int *crnd::math::g_bitmasks")]
internal static partial class g_bitmasks
{
	private static InlineArray32_Int32 __value;

	public static InlineArray32_Int32 Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	static g_bitmasks()
	{
		Value = InlineArrayHelper.Create<InlineArray32_Int32, int>(new int[32]
		{
			1, 2, 4, 8, 16, 32, 64, 128, 256, 512,
			1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288,
			1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912,
			1073741824, -2147483648
		});
	}
}
