using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$destruct_array@G@helpers@crnd@@YAXPEAGI@Z")]
[DemangledName("void __cdecl crnd::helpers::destruct_array<unsigned short>(unsigned short *, unsigned int)")]
[CleanName("destruct_array")]
internal static partial class destruct_array_viasmsc
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned short *")] void* p, [NativeType("unsigned int")] int n)
	{
		void* ptr = p;
		unchecked
		{
			for (void* ptr2 = (byte*)ptr + (nint)(uint)n * (nint)2; ptr != ptr2; ptr = (byte*)ptr + 2)
			{
			}
		}
	}
}
