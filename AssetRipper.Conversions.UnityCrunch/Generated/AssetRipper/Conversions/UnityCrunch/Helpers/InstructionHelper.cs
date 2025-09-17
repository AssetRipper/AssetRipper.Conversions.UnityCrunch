using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace AssetRipper.Conversions.UnityCrunch.Helpers;

internal static partial class InstructionHelper
{
	public static TTo BitCast<TFrom, TTo>(TFrom value) where TFrom : struct where TTo : struct
	{
		ArgumentOutOfRangeException.ThrowIfLessThan(Unsafe.SizeOf<TFrom>(), Unsafe.SizeOf<TTo>(), "TFrom");
		return Unsafe.As<TFrom, TTo>(ref value);
	}

	public unsafe static void VAStart(void** vaListPtr, ReadOnlySpan<nint> args)
	{
		*vaListPtr = args.ToPointer<nint>();
	}

	public unsafe static void** VAArg(void*** vaListPtr)
	{
		return (*vaListPtr)++;
	}

	public unsafe static void* Select(bool condition, void* trueValue, void* falseValue)
	{
		return condition ? trueValue : falseValue;
	}

	public static T Select<T>(bool condition, T trueValue, T falseValue)
	{
		return condition ? trueValue : falseValue;
	}

	public static TValue Select<TCondition, TValue, TValueElement>(TCondition condition, TValue trueValue, TValue falseValue) where TCondition : unmanaged, IInlineArray<bool> where TValue : unmanaged, IInlineArray<TValueElement> where TValueElement : unmanaged
	{
		if (TCondition.Length != TValue.Length)
		{
			throw new ArgumentException($"Condition length ({TCondition.Length}) must match value length ({TValue.Length}).");
		}
		ReadOnlySpan<bool> readOnlySpan = condition.AsReadOnlySpan<TCondition, bool>();
		ReadOnlySpan<TValueElement> readOnlySpan2 = trueValue.AsReadOnlySpan<TValue, TValueElement>();
		ReadOnlySpan<TValueElement> readOnlySpan3 = falseValue.AsReadOnlySpan<TValue, TValueElement>();
		TValue buffer = default(TValue);
		Span<TValueElement> span = buffer.AsSpan<TValue, TValueElement>();
		for (int i = 0; i < TCondition.Length; i++)
		{
			span[i] = (readOnlySpan[i] ? readOnlySpan2[i] : readOnlySpan3[i]);
		}
		return buffer;
	}

	public static TElement ExtractElement<TBuffer, TElement>(this TBuffer buffer, int index) where TBuffer : struct, IInlineArray<TElement>
	{
		return buffer.AsReadOnlySpan<TBuffer, TElement>()[index];
	}

	public static TBuffer InsertElement<TBuffer, TElement>(this TBuffer buffer, TElement value, int index) where TBuffer : struct, IInlineArray<TElement>
	{
		buffer.AsSpan<TBuffer, TElement>()[index] = value;
		return buffer;
	}

	public static TResult ShuffleVector<TVector, TIndex, TResult, TElement>(TVector vector1, TVector vector2, TIndex indices) where TVector : struct, IInlineArray<TElement> where TIndex : struct, IInlineArray<int> where TResult : struct, IInlineArray<TElement> where TElement : unmanaged
	{
		ArgumentOutOfRangeException.ThrowIfNotEqual(TResult.Length, TIndex.Length, "TResult.Length");
		ReadOnlySpan<TElement> readOnlySpan = vector1.AsReadOnlySpan<TVector, TElement>();
		ReadOnlySpan<TElement> readOnlySpan2 = vector2.AsReadOnlySpan<TVector, TElement>();
		ReadOnlySpan<int> readOnlySpan3 = indices.AsReadOnlySpan<TIndex, int>();
		TResult buffer = default(TResult);
		Span<TElement> span = buffer.AsSpan<TResult, TElement>();
		for (int i = 0; i < TIndex.Length; i++)
		{
			int num = readOnlySpan3[i];
			ArgumentOutOfRangeException.ThrowIfNegative(num, "index");
			ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(num, TVector.Length * 2, "index");
			span[i] = ((num < TVector.Length) ? readOnlySpan[num] : readOnlySpan2[num - TVector.Length]);
		}
		return buffer;
	}

	public unsafe static (int, bool) Cmpxchg_i16(int* pointer, int cmp, int @new)
	{
		int num = Interlocked.CompareExchange(ref *pointer, @new, cmp);
		return (num, num == cmp);
	}

	public unsafe static (int, bool) Cmpxchg_i32(int* pointer, int cmp, int @new)
	{
		int num = Interlocked.CompareExchange(ref *pointer, @new, cmp);
		return (num, num == cmp);
	}

	public unsafe static void Cmpxchg(void** pointer, void* cmp, void* @new, out void* original, out bool success)
	{
		unchecked
		{
			original = (void*)checked((nuint)Interlocked.CompareExchange(comparand: (nint)cmp, location1: ref *unchecked((nint*)pointer), value: (nint)@new));
			success = original == cmp;
		}
	}

	public unsafe static (T, bool) Cmpxchg<T>(T* pointer, T cmp, T @new) where T : unmanaged, IEquatable<T>, IEqualityOperators<T, T, bool>
	{
		unchecked
		{
			T val;
			if (typeof(T) == typeof(bool))
			{
				val = (T)(object)Interlocked.CompareExchange(ref *(bool*)pointer, (bool)(object)@new, (bool)(object)cmp);
			}
			else if (typeof(T) == typeof(byte))
			{
				val = (T)(object)Interlocked.CompareExchange(ref *(byte*)pointer, (byte)(object)@new, (byte)(object)cmp);
			}
			else if (typeof(T) == typeof(sbyte))
			{
				val = (T)(object)Interlocked.CompareExchange(ref *(sbyte*)pointer, (sbyte)(object)@new, (sbyte)(object)cmp);
			}
			else if (typeof(T) == typeof(short))
			{
				val = (T)(object)Interlocked.CompareExchange(ref *(short*)pointer, (short)(object)@new, (short)(object)cmp);
			}
			else if (typeof(T) == typeof(ushort))
			{
				val = (T)(object)Interlocked.CompareExchange(ref *(ushort*)pointer, (ushort)(object)@new, (ushort)(object)cmp);
			}
			else if (typeof(T) == typeof(int))
			{
				val = (T)(object)Interlocked.CompareExchange(ref *(int*)pointer, (int)(object)@new, (int)(object)cmp);
			}
			else if (typeof(T) == typeof(uint))
			{
				val = (T)(object)Interlocked.CompareExchange(ref *(uint*)pointer, (uint)(object)@new, (uint)(object)cmp);
			}
			else if (typeof(T) == typeof(long))
			{
				val = (T)(object)Interlocked.CompareExchange(ref *(long*)pointer, (long)(object)@new, (long)(object)cmp);
			}
			else
			{
				if (!(typeof(T) == typeof(ulong)))
				{
					throw new NotSupportedException($"Type '{typeof(T)}' is not supported for atomic compare-and-exchange.");
				}
				val = (T)(object)Interlocked.CompareExchange(ref *(ulong*)pointer, (ulong)(object)@new, (ulong)(object)cmp);
			}
			return (val, val == cmp);
		}
	}
}
