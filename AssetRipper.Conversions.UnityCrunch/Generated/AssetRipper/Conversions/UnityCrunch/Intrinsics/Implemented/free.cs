using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;

internal static partial class free
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void Invoke(void* ptr)
	{
		IntrinsicFunctions.Free(ptr);
	}
}
