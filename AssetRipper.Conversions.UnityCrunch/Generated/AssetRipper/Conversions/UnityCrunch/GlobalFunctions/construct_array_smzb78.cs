using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$construct_array@G@helpers@crnd@@YAXPEAGI@Z")]
[DemangledName("void __cdecl crnd::helpers::construct_array<unsigned short>(unsigned short *, unsigned int)")]
[CleanName("construct_array")]
internal static partial class construct_array_smzb78
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
