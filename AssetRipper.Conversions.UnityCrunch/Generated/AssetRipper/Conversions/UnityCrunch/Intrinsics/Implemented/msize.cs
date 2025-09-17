using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;

[MangledName("_msize")]
[DemangledName("_msize")]
internal static partial class msize
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static long Invoke(void* ptr)
	{
		return IntrinsicFunctions.Size(ptr);
	}
}
