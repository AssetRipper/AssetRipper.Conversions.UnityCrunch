using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?construct_array@?$scalar_type@E@crnd@@SAXPEAEI@Z")]
[DemangledName("public: static void __cdecl crnd::scalar_type<unsigned char>::construct_array(unsigned char *, unsigned int)")]
[CleanName("construct_array")]
internal static partial class construct_array_oifcoec
{
	public unsafe static void Invoke(void* p, int n)
	{
		llvm_memset_p0_i64.Invoke(p, 0, unchecked(1L * (long)(uint)n), isVolatile: false);
	}
}
