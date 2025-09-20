using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$minimum@I@math@crnd@@YAIII@Z")]
[DemangledName("unsigned int __cdecl crnd::math::minimum<unsigned int>(unsigned int, unsigned int)")]
internal static partial class minimum
{
	[return: NativeType("unsigned int")]
	public static int Invoke([NativeType("unsigned int")] int a, [NativeType("unsigned int")] int b)
	{
		return unchecked((uint)a >= (uint)b) ? b : a;
	}
}
