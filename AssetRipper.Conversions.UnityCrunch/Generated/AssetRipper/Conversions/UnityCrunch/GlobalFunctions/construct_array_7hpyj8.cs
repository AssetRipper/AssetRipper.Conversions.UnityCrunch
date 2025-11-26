using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$construct_array@I@helpers@crnd@@YAXPEAII@Z")]
[DemangledName("void __cdecl crnd::helpers::construct_array<unsigned int>(unsigned int *, unsigned int)")]
[CleanName("construct_array")]
internal static partial class construct_array_7hpyj8
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned int *")] void* p, [NativeType("unsigned int")] int n)
	{
		void* ptr = p;
		unchecked
		{
			for (void* ptr2 = (byte*)ptr + (nint)(uint)n * (nint)4; ptr != ptr2; ptr = (byte*)ptr + 4)
			{
			}
		}
	}
}
