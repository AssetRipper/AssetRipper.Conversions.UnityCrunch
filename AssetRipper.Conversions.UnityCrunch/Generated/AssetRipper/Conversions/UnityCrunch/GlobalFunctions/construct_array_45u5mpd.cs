using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?construct_array@?$scalar_type@I@crnd@@SAXPEAII@Z")]
[DemangledName("public: static void __cdecl crnd::scalar_type<unsigned int>::construct_array(unsigned int *, unsigned int)")]
[CleanName("construct_array")]
internal static partial class construct_array_45u5mpd
{
	public unsafe static void Invoke(void* p, int n)
	{
		llvm_memset_p0_i64.Invoke(p, 0, unchecked(4L * (long)(uint)n), isVolatile: false);
	}
}
