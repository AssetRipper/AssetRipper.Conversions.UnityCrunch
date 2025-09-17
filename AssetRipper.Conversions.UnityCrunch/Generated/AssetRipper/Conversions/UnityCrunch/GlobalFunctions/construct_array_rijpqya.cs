using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$construct_array@I@helpers@crnd@@YAXPEAII@Z")]
[DemangledName("void __cdecl crnd::helpers::construct_array<unsigned int>(unsigned int *, unsigned int)")]
[CleanName("construct_array")]
internal static partial class construct_array_rijpqya
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
