using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Conversions.UnityCrunch.Helpers;

internal static partial class InlineArrayHelper
{
	public static Span<TElement> AsSpan<TBuffer, TElement>(this ref TBuffer buffer) where TBuffer : struct, IInlineArray<TElement>
	{
		return MemoryMarshal.CreateSpan(ref Unsafe.As<TBuffer, TElement>(ref buffer), TBuffer.Length);
	}

	public static ReadOnlySpan<TElement> AsReadOnlySpan<TBuffer, TElement>(this ref TBuffer buffer) where TBuffer : struct, IInlineArray<TElement>
	{
		return MemoryMarshal.CreateReadOnlySpan(in Unsafe.As<TBuffer, TElement>(ref buffer), TBuffer.Length);
	}

	public static void Initialize<TBuffer, TElement>(this ref TBuffer buffer, ReadOnlySpan<TElement> span) where TBuffer : struct, IInlineArray<TElement>
	{
		span.CopyTo(buffer.AsSpan<TBuffer, TElement>());
	}

	public static TBuffer Create<TBuffer, TElement>(ReadOnlySpan<TElement> contents) where TBuffer : struct, IInlineArray<TElement>
	{
		TBuffer buffer = default(TBuffer);
		Initialize(ref buffer, contents);
		return buffer;
	}

	public static TElement GetElement<TBuffer, TElement>(this ref TBuffer buffer, int index) where TBuffer : struct, IInlineArray<TElement>
	{
		return buffer.AsReadOnlySpan<TBuffer, TElement>()[index];
	}

	public static void SetElement<TBuffer, TElement>(this ref TBuffer buffer, int index, TElement value) where TBuffer : struct, IInlineArray<TElement>
	{
		buffer.AsSpan<TBuffer, TElement>()[index] = value;
	}

	public static bool Equals<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement>
	{
		return x.AsReadOnlySpan<TBuffer, TElement>().SequenceEqual(y.AsReadOnlySpan<TBuffer, TElement>(), null);
	}

	public static int GetHashCode<TBuffer, TElement>(this ref TBuffer buffer) where TBuffer : struct, IInlineArray<TElement>
	{
		HashCode hashCode = default(HashCode);
		ReadOnlySpan<TElement> readOnlySpan = buffer.AsReadOnlySpan<TBuffer, TElement>();
		for (int i = 0; i < readOnlySpan.Length; i = unchecked(i + 1))
		{
			hashCode.Add(readOnlySpan[i]);
		}
		return hashCode.ToHashCode();
	}
}
