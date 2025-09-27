using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Conversions.UnityCrunch.Helpers;

internal static partial class SpanHelper
{
	public static ReadOnlySpan<T> ToReadOnly<T>(this Span<T> span)
	{
		return span;
	}

	public unsafe static T* ToPointer<T>(this ReadOnlySpan<T> span) where T : unmanaged
	{
		return unchecked((T*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(span)));
	}

	public static ReadOnlySpan<TTo> Cast<TFrom, TTo>(this ReadOnlySpan<TFrom> span) where TFrom : struct where TTo : struct
	{
		return MemoryMarshal.Cast<TFrom, TTo>(span);
	}
}
