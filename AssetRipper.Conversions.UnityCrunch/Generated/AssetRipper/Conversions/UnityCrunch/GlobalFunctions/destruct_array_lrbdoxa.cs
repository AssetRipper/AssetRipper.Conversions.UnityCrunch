using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$destruct_array@I@helpers@crnd@@YAXPEAII@Z")]
[DemangledName("void __cdecl crnd::helpers::destruct_array<unsigned int>(unsigned int *, unsigned int)")]
[CleanName("destruct_array")]
internal static partial class destruct_array_lrbdoxa
{
	public unsafe static void Invoke(void* p, int n)
	{
		void* ptr = null;
		void* ptr2 = null;
		ptr = p;
		unchecked
		{
			for (ptr2 = (byte*)ptr + (nint)(uint)n * (nint)4; ptr != ptr2; ptr = (byte*)ptr + 4)
			{
			}
		}
	}
}
