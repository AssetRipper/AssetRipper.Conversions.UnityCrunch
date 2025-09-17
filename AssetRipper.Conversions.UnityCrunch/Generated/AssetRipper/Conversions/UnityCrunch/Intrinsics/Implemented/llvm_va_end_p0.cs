using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;

[MangledName("llvm.va_end.p0")]
[DemangledName("llvm.va_end.p0")]
internal static partial class llvm_va_end_p0
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void Invoke(void* va_list)
	{
		IntrinsicFunctions.llvm_va_end(unchecked((void**)va_list));
	}
}
