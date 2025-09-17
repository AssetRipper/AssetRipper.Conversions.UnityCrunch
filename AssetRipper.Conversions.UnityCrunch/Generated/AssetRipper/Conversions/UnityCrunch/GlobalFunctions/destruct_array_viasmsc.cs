using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$destruct_array@G@helpers@crnd@@YAXPEAGI@Z")]
[DemangledName("void __cdecl crnd::helpers::destruct_array<unsigned short>(unsigned short *, unsigned int)")]
[CleanName("destruct_array")]
internal static partial class destruct_array_viasmsc
{
	public unsafe static void Invoke(void* p, int n)
	{
		void* ptr = null;
		void* ptr2 = null;
		ptr = p;
		unchecked
		{
			for (ptr2 = (byte*)ptr + (nint)(uint)n * (nint)2; ptr != ptr2; ptr = (byte*)ptr + 2)
			{
			}
		}
	}
}
