using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$zero_object@$$BY0BB@I@utils@crnd@@YAXAEAY0BB@I@Z")]
[DemangledName("void __cdecl crnd::utils::zero_object<unsigned int[17]>(unsigned int (&)[17])")]
internal static partial class zero_object
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned int (&)[17]")] void* obj)
	{
		llvm_memset_p0_i64.Invoke(obj, 0, 68L, isVolatile: false);
	}
}
