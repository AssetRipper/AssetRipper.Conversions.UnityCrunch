using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;

[MangledName("llvm.memcpy.p0.p0.i64")]
[DemangledName("llvm.memcpy.p0.p0.i64")]
internal static partial class llvm_memcpy_p0_p0_i64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void Invoke(void* destination, void* source, long length, bool isVolatile)
	{
		IntrinsicFunctions.llvm_memcpy_p0_p0_i64(destination, source, length, isVolatile);
	}
}
