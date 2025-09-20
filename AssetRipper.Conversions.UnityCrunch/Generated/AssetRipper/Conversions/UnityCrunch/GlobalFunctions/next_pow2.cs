using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?next_pow2@math@crnd@@YAHI@Z")]
[DemangledName("int __cdecl crnd::math::next_pow2(unsigned int)")]
internal static partial class next_pow2
{
	[return: NativeType("int")]
	public static int Invoke([NativeType("unsigned int")] int val)
	{
		unchecked
		{
			int num = val + -1;
			num |= num >>> 16;
			num |= num >>> 8;
			num |= num >>> 4;
			num |= num >>> 2;
			return (num | (num >>> 1)) + 1;
		}
	}
}
