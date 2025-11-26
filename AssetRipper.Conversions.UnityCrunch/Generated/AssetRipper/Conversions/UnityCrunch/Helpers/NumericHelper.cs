using System;
using System.Buffers.Binary;
using System.Numerics;
using System.Numerics.Tensors;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Conversions.UnityCrunch.Helpers;

internal static partial class NumericHelper
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Negate<T>(T x) where T : IUnaryNegationOperators<T, T>
	{
		return unchecked(-x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T ShiftLeft<T>(T x, T y) where T : IShiftOperators<T, int, T>
	{
		return x << ConvertToInt32(y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T ShiftRightArithmetic<T>(T x, T y) where T : IShiftOperators<T, int, T>
	{
		return x >> ConvertToInt32(y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T ShiftRightLogical<T>(T x, T y) where T : IShiftOperators<T, int, T>
	{
		return x >>> ConvertToInt32(y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T BitwiseAnd<T>(T x, T y) where T : IBitwiseOperators<T, T, T>
	{
		return x & y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T BitwiseOr<T>(T x, T y) where T : IBitwiseOperators<T, T, T>
	{
		return x | y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T BitwiseXor<T>(T x, T y) where T : IBitwiseOperators<T, T, T>
	{
		return x ^ y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T CtPop<T>(T x) where T : unmanaged
	{
		return ConvertFromInt32<T>((int)TensorPrimitives.PopCount(MemoryMarshal.AsBytes(new ReadOnlySpan<T>(in x))));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsOrdered<T>(T x, T y) where T : INumberBase<T>
	{
		return !IsUnordered(x, y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsUnordered<T>(T x, T y) where T : INumberBase<T>
	{
		return T.IsNaN(x) || T.IsNaN(y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsUnorderedOrEquals<T>(T x, T y) where T : INumberBase<T>
	{
		return IsUnordered(x, y) || x == y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsUnorderedOrNotEquals<T>(T x, T y) where T : INumberBase<T>
	{
		return IsUnordered(x, y) || x != y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsUnorderedOrGreaterThan<T>(T x, T y) where T : INumberBase<T>, IComparisonOperators<T, T, bool>
	{
		return IsUnordered(x, y) || x > y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsUnorderedOrGreaterThanOrEquals<T>(T x, T y) where T : INumberBase<T>, IComparisonOperators<T, T, bool>
	{
		return IsUnordered(x, y) || x >= y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsUnorderedOrLessThan<T>(T x, T y) where T : INumberBase<T>, IComparisonOperators<T, T, bool>
	{
		return IsUnordered(x, y) || x < y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsUnorderedOrLessThanOrEquals<T>(T x, T y) where T : INumberBase<T>, IComparisonOperators<T, T, bool>
	{
		return IsUnordered(x, y) || x <= y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int ConvertToInt32<T>(T x)
	{
		if (typeof(T) == typeof(sbyte))
		{
			return (sbyte)(object)x;
		}
		if (typeof(T) == typeof(byte))
		{
			return (byte)(object)x;
		}
		if (typeof(T) == typeof(short))
		{
			return (short)(object)x;
		}
		if (typeof(T) == typeof(ushort))
		{
			return (ushort)(object)x;
		}
		if (typeof(T) == typeof(int))
		{
			return (int)(object)x;
		}
		unchecked
		{
			if (typeof(T) == typeof(uint))
			{
				return (int)(uint)(object)x;
			}
			if (typeof(T) == typeof(long))
			{
				return (int)(long)(object)x;
			}
			if (typeof(T) == typeof(ulong))
			{
				return (int)(ulong)(object)x;
			}
			if (typeof(T) == typeof(Int128))
			{
				return (int)(Int128)(object)x;
			}
			if (typeof(T) == typeof(UInt128))
			{
				return (int)(UInt128)(object)x;
			}
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static T ConvertFromInt32<T>(int x)
	{
		unchecked
		{
			if (typeof(T) == typeof(sbyte))
			{
				return (T)(object)(sbyte)x;
			}
			if (typeof(T) == typeof(byte))
			{
				return (T)(object)(byte)x;
			}
			if (typeof(T) == typeof(short))
			{
				return (T)(object)(short)x;
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)(object)(ushort)x;
			}
			if (typeof(T) == typeof(int))
			{
				return (T)(object)x;
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)(object)(uint)x;
			}
			if (typeof(T) == typeof(long))
			{
				return (T)(object)(long)x;
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)(object)(ulong)x;
			}
			if (typeof(T) == typeof(Int128))
			{
				return (T)(object)(Int128)x;
			}
			if (typeof(T) == typeof(UInt128))
			{
				return (T)(object)(UInt128)x;
			}
			return default(T);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Add<T>(T x, T y) where T : IAdditionOperators<T, T, T>, IAdditiveIdentity<T, T>
	{
		return unchecked(x + y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T AddSigned<T>(T x, T y) where T : IAdditionOperators<T, T, T>, IAdditiveIdentity<T, T>
	{
		unchecked
		{
			if (typeof(T) == typeof(byte))
			{
				return (T)(object)(byte)checked((sbyte)(unchecked((sbyte)(byte)(object)x) + unchecked((sbyte)(byte)(object)y)));
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)(object)(ushort)checked((short)(unchecked((short)(ushort)(object)x) + unchecked((short)(ushort)(object)y)));
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)(object)(uint)checked(unchecked((int)(uint)(object)x) + unchecked((int)(uint)(object)y));
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)(object)(ulong)checked(unchecked((long)(ulong)(object)x) + unchecked((long)(ulong)(object)y));
			}
			if (typeof(T) == typeof(UInt128))
			{
				UInt128 uInt = (UInt128)(object)x;
				UInt128 uInt2 = (UInt128)(object)y;
				return (T)(object)(UInt128)checked(unchecked((Int128)uInt) + unchecked((Int128)uInt2));
			}
		}
		return x + y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T AddUnsigned<T>(T x, T y) where T : IAdditionOperators<T, T, T>, IAdditiveIdentity<T, T>
	{
		unchecked
		{
			if (typeof(T) == typeof(sbyte))
			{
				return (T)(object)(sbyte)checked((byte)(unchecked((byte)(sbyte)(object)x) + unchecked((byte)(sbyte)(object)y)));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)(object)(short)checked((ushort)(unchecked((ushort)(short)(object)x) + unchecked((ushort)(short)(object)y)));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)(object)(int)checked(unchecked((uint)(int)(object)x) + unchecked((uint)(int)(object)y));
			}
			if (typeof(T) == typeof(long))
			{
				return (T)(object)(long)checked(unchecked((ulong)(long)(object)x) + unchecked((ulong)(long)(object)y));
			}
			if (typeof(T) == typeof(Int128))
			{
				Int128 @int = (Int128)(object)x;
				Int128 int2 = (Int128)(object)y;
				return (T)(object)(Int128)checked(unchecked((UInt128)@int) + unchecked((UInt128)int2));
			}
		}
		return x + y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Subtract<T>(T x, T y) where T : ISubtractionOperators<T, T, T>
	{
		return unchecked(x - y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T SubtractSigned<T>(T x, T y) where T : ISubtractionOperators<T, T, T>
	{
		unchecked
		{
			if (typeof(T) == typeof(byte))
			{
				return (T)(object)(byte)checked((sbyte)(unchecked((sbyte)(byte)(object)x) - unchecked((sbyte)(byte)(object)y)));
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)(object)(ushort)checked((short)(unchecked((short)(ushort)(object)x) - unchecked((short)(ushort)(object)y)));
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)(object)(uint)checked(unchecked((int)(uint)(object)x) - unchecked((int)(uint)(object)y));
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)(object)(ulong)checked(unchecked((long)(ulong)(object)x) - unchecked((long)(ulong)(object)y));
			}
			if (typeof(T) == typeof(UInt128))
			{
				UInt128 uInt = (UInt128)(object)x;
				UInt128 uInt2 = (UInt128)(object)y;
				return (T)(object)(UInt128)checked(unchecked((Int128)uInt) - unchecked((Int128)uInt2));
			}
		}
		return x - y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T SubtractUnsigned<T>(T x, T y) where T : ISubtractionOperators<T, T, T>
	{
		unchecked
		{
			if (typeof(T) == typeof(sbyte))
			{
				return (T)(object)(sbyte)checked((byte)(unchecked((byte)(sbyte)(object)x) - unchecked((byte)(sbyte)(object)y)));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)(object)(short)checked((ushort)(unchecked((ushort)(short)(object)x) - unchecked((ushort)(short)(object)y)));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)(object)(int)checked(unchecked((uint)(int)(object)x) - unchecked((uint)(int)(object)y));
			}
			if (typeof(T) == typeof(long))
			{
				return (T)(object)(long)checked(unchecked((ulong)(long)(object)x) - unchecked((ulong)(long)(object)y));
			}
			if (typeof(T) == typeof(Int128))
			{
				Int128 @int = (Int128)(object)x;
				Int128 int2 = (Int128)(object)y;
				return (T)(object)(Int128)checked(unchecked((UInt128)@int) - unchecked((UInt128)int2));
			}
		}
		return x - y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Multiply<T>(T x, T y) where T : IMultiplyOperators<T, T, T>, IMultiplicativeIdentity<T, T>
	{
		return unchecked(x * y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T MultiplySigned<T>(T x, T y) where T : IMultiplyOperators<T, T, T>, IMultiplicativeIdentity<T, T>
	{
		unchecked
		{
			if (typeof(T) == typeof(byte))
			{
				return (T)(object)(byte)checked((sbyte)(unchecked((sbyte)(byte)(object)x) * unchecked((sbyte)(byte)(object)y)));
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)(object)(ushort)checked((short)(unchecked((short)(ushort)(object)x) * unchecked((short)(ushort)(object)y)));
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)(object)(uint)checked(unchecked((int)(uint)(object)x) * unchecked((int)(uint)(object)y));
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)(object)(ulong)checked(unchecked((long)(ulong)(object)x) * unchecked((long)(ulong)(object)y));
			}
			if (typeof(T) == typeof(UInt128))
			{
				UInt128 uInt = (UInt128)(object)x;
				UInt128 uInt2 = (UInt128)(object)y;
				return (T)(object)(UInt128)checked(unchecked((Int128)uInt) * unchecked((Int128)uInt2));
			}
		}
		return x * y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T MultiplyUnsigned<T>(T x, T y) where T : IMultiplyOperators<T, T, T>, IMultiplicativeIdentity<T, T>
	{
		unchecked
		{
			if (typeof(T) == typeof(sbyte))
			{
				return (T)(object)(sbyte)checked((byte)(unchecked((byte)(sbyte)(object)x) * unchecked((byte)(sbyte)(object)y)));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)(object)(short)checked((ushort)(unchecked((ushort)(short)(object)x) * unchecked((ushort)(short)(object)y)));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)(object)(int)checked(unchecked((uint)(int)(object)x) * unchecked((uint)(int)(object)y));
			}
			if (typeof(T) == typeof(long))
			{
				return (T)(object)(long)checked(unchecked((ulong)(long)(object)x) * unchecked((ulong)(long)(object)y));
			}
			if (typeof(T) == typeof(Int128))
			{
				Int128 @int = (Int128)(object)x;
				Int128 int2 = (Int128)(object)y;
				return (T)(object)(Int128)checked(unchecked((UInt128)@int) * unchecked((UInt128)int2));
			}
		}
		return x * y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Divide<T>(T x, T y) where T : IDivisionOperators<T, T, T>
	{
		return unchecked(x / y);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T DivideSigned<T>(T x, T y) where T : IDivisionOperators<T, T, T>
	{
		unchecked
		{
			if (typeof(T) == typeof(byte))
			{
				return (T)(object)(byte)checked((sbyte)unchecked((sbyte)(byte)(object)x / (sbyte)(byte)(object)y));
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)(object)(ushort)checked((short)unchecked((short)(ushort)(object)x / (short)(ushort)(object)y));
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)(object)(uint)((int)(uint)(object)x / (int)(uint)(object)y);
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)(object)(ulong)((long)(ulong)(object)x / (long)(ulong)(object)y);
			}
			if (typeof(T) == typeof(UInt128))
			{
				UInt128 uInt = (UInt128)(object)x;
				UInt128 uInt2 = (UInt128)(object)y;
				return (T)(object)(UInt128)checked(unchecked((Int128)uInt) / unchecked((Int128)uInt2));
			}
		}
		return x / y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T DivideUnsigned<T>(T x, T y) where T : IDivisionOperators<T, T, T>
	{
		unchecked
		{
			if (typeof(T) == typeof(sbyte))
			{
				return (T)(object)(sbyte)checked((byte)unchecked((byte)(sbyte)(object)x / (byte)(sbyte)(object)y));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)(object)(short)checked((ushort)unchecked((ushort)(short)(object)x / (ushort)(short)(object)y));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)(object)(int)((uint)(int)(object)x / (uint)(int)(object)y);
			}
			if (typeof(T) == typeof(long))
			{
				return (T)(object)(long)((ulong)(long)(object)x / (ulong)(long)(object)y);
			}
			if (typeof(T) == typeof(Int128))
			{
				Int128 @int = (Int128)(object)x;
				Int128 int2 = (Int128)(object)y;
				return (T)(object)(Int128)checked(unchecked((UInt128)@int) / unchecked((UInt128)int2));
			}
		}
		return x / y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Remainder<T>(T x, T y) where T : IModulusOperators<T, T, T>
	{
		return x % y;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T RemainderSigned<T>(T x, T y) where T : IModulusOperators<T, T, T>
	{
		unchecked
		{
			if (typeof(T) == typeof(byte))
			{
				return (T)(object)(byte)checked((sbyte)unchecked((sbyte)(byte)(object)x % (sbyte)(byte)(object)y));
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)(object)(ushort)checked((short)unchecked((short)(ushort)(object)x % (short)(ushort)(object)y));
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)(object)(uint)((int)(uint)(object)x % (int)(uint)(object)y);
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)(object)(ulong)((long)(ulong)(object)x % (long)(ulong)(object)y);
			}
			if (typeof(T) == typeof(UInt128))
			{
				UInt128 uInt = (UInt128)(object)x;
				UInt128 uInt2 = (UInt128)(object)y;
				return (T)(object)(UInt128)((Int128)uInt % (Int128)uInt2);
			}
			return x % y;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T RemainderUnsigned<T>(T x, T y) where T : IModulusOperators<T, T, T>
	{
		unchecked
		{
			if (typeof(T) == typeof(sbyte))
			{
				return (T)(object)(sbyte)checked((byte)unchecked((byte)(sbyte)(object)x % (byte)(sbyte)(object)y));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)(object)(short)checked((ushort)unchecked((ushort)(short)(object)x % (ushort)(short)(object)y));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)(object)(int)((uint)(int)(object)x % (uint)(int)(object)y);
			}
			if (typeof(T) == typeof(long))
			{
				return (T)(object)(long)((ulong)(long)(object)x % (ulong)(long)(object)y);
			}
			if (typeof(T) == typeof(Int128))
			{
				Int128 @int = (Int128)(object)x;
				Int128 int2 = (Int128)(object)y;
				return (T)(object)(Int128)((UInt128)@int % (UInt128)int2);
			}
			return x % y;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T BSwap<T>(T x)
	{
		if (typeof(T) == typeof(sbyte))
		{
			return (T)(object)BinaryPrimitives.ReverseEndianness((sbyte)(object)x);
		}
		if (typeof(T) == typeof(byte))
		{
			return (T)(object)BinaryPrimitives.ReverseEndianness((byte)(object)x);
		}
		if (typeof(T) == typeof(short))
		{
			return (T)(object)BinaryPrimitives.ReverseEndianness((short)(object)x);
		}
		if (typeof(T) == typeof(ushort))
		{
			return (T)(object)BinaryPrimitives.ReverseEndianness((ushort)(object)x);
		}
		if (typeof(T) == typeof(int))
		{
			return (T)(object)BinaryPrimitives.ReverseEndianness((int)(object)x);
		}
		if (typeof(T) == typeof(uint))
		{
			return (T)(object)BinaryPrimitives.ReverseEndianness((uint)(object)x);
		}
		if (typeof(T) == typeof(long))
		{
			return (T)(object)BinaryPrimitives.ReverseEndianness((long)(object)x);
		}
		if (typeof(T) == typeof(ulong))
		{
			return (T)(object)BinaryPrimitives.ReverseEndianness((ulong)(object)x);
		}
		if (typeof(T) == typeof(Int128))
		{
			return (T)(object)BinaryPrimitives.ReverseEndianness((Int128)(object)x);
		}
		if (typeof(T) == typeof(UInt128))
		{
			return (T)(object)BinaryPrimitives.ReverseEndianness((UInt128)(object)x);
		}
		return default(T);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Abs<T>(T x) where T : INumberBase<T>
	{
		return T.Abs(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T FAbs<T>(T x) where T : INumberBase<T>
	{
		return T.Abs(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Sin<T>(T x) where T : ITrigonometricFunctions<T>
	{
		return T.Sin(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Cos<T>(T x) where T : ITrigonometricFunctions<T>
	{
		return T.Cos(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Tan<T>(T x) where T : ITrigonometricFunctions<T>
	{
		return T.Tan(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Asin<T>(T x) where T : ITrigonometricFunctions<T>
	{
		return T.Asin(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Acos<T>(T x) where T : ITrigonometricFunctions<T>
	{
		return T.Acos(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Atan<T>(T x) where T : ITrigonometricFunctions<T>
	{
		return T.Atan(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Sinh<T>(T x) where T : IHyperbolicFunctions<T>
	{
		return T.Sinh(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Cosh<T>(T x) where T : IHyperbolicFunctions<T>
	{
		return T.Cosh(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Tanh<T>(T x) where T : IHyperbolicFunctions<T>
	{
		return T.Tanh(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Exp<T>(T x) where T : IExponentialFunctions<T>
	{
		return T.Exp(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Exp2<T>(T x) where T : IExponentialFunctions<T>
	{
		return T.Exp2(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Exp10<T>(T x) where T : IExponentialFunctions<T>
	{
		return T.Exp10(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Log<T>(T x) where T : ILogarithmicFunctions<T>
	{
		return T.Log(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Log2<T>(T x) where T : ILogarithmicFunctions<T>
	{
		return T.Log2(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Log10<T>(T x) where T : ILogarithmicFunctions<T>
	{
		return T.Log10(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Sqrt<T>(T x) where T : IRootFunctions<T>
	{
		return T.Sqrt(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Ceil<T>(T x) where T : IFloatingPoint<T>
	{
		return T.Ceiling(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Floor<T>(T x) where T : IFloatingPoint<T>
	{
		return T.Floor(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Round<T>(T x) where T : IFloatingPoint<T>
	{
		return T.Round(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T CtLz<T>(T x) where T : IBinaryInteger<T>
	{
		return T.LeadingZeroCount(x);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Pow<T>(T x, T y) where T : IPowerFunctions<T>
	{
		return T.Pow(x, y);
	}
}
