using System.Numerics;
using System.Numerics.Tensors;

namespace AssetRipper.Conversions.UnityCrunch.Helpers;

internal static partial class InlineArrayNumericHelper
{
	public static TBuffer Add<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IAdditionOperators<TElement, TElement, TElement>, IAdditiveIdentity<TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Add(x.AsReadOnlySpan<TBuffer, TElement>(), y.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer AddSigned<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IAdditionOperators<TElement, TElement, TElement>, IAdditiveIdentity<TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		for (int i = 0; i < TBuffer.Length; i++)
		{
			InlineArrayHelper.SetElement(ref buffer, i, NumericHelper.AddSigned(x.GetElement<TBuffer, TElement>(i), y.GetElement<TBuffer, TElement>(i)));
		}
		return buffer;
	}

	public static TBuffer AddUnsigned<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IAdditionOperators<TElement, TElement, TElement>, IAdditiveIdentity<TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		for (int i = 0; i < TBuffer.Length; i++)
		{
			InlineArrayHelper.SetElement(ref buffer, i, NumericHelper.AddUnsigned(x.GetElement<TBuffer, TElement>(i), y.GetElement<TBuffer, TElement>(i)));
		}
		return buffer;
	}

	public static TBuffer Subtract<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : ISubtractionOperators<TElement, TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Subtract(x.AsReadOnlySpan<TBuffer, TElement>(), y.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer SubtractSigned<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : ISubtractionOperators<TElement, TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		for (int i = 0; i < TBuffer.Length; i++)
		{
			InlineArrayHelper.SetElement(ref buffer, i, NumericHelper.SubtractSigned(x.GetElement<TBuffer, TElement>(i), y.GetElement<TBuffer, TElement>(i)));
		}
		return buffer;
	}

	public static TBuffer SubtractUnsigned<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : ISubtractionOperators<TElement, TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		for (int i = 0; i < TBuffer.Length; i++)
		{
			InlineArrayHelper.SetElement(ref buffer, i, NumericHelper.SubtractUnsigned(x.GetElement<TBuffer, TElement>(i), y.GetElement<TBuffer, TElement>(i)));
		}
		return buffer;
	}

	public static TBuffer Multiply<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IMultiplyOperators<TElement, TElement, TElement>, IMultiplicativeIdentity<TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Multiply(x.AsReadOnlySpan<TBuffer, TElement>(), y.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer MultiplySigned<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IMultiplyOperators<TElement, TElement, TElement>, IMultiplicativeIdentity<TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		for (int i = 0; i < TBuffer.Length; i++)
		{
			InlineArrayHelper.SetElement(ref buffer, i, NumericHelper.MultiplySigned(x.GetElement<TBuffer, TElement>(i), y.GetElement<TBuffer, TElement>(i)));
		}
		return buffer;
	}

	public static TBuffer MultiplyUnsigned<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IMultiplyOperators<TElement, TElement, TElement>, IMultiplicativeIdentity<TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		for (int i = 0; i < TBuffer.Length; i++)
		{
			InlineArrayHelper.SetElement(ref buffer, i, NumericHelper.MultiplyUnsigned(x.GetElement<TBuffer, TElement>(i), y.GetElement<TBuffer, TElement>(i)));
		}
		return buffer;
	}

	public static TBuffer Divide<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IDivisionOperators<TElement, TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Divide(x.AsReadOnlySpan<TBuffer, TElement>(), y.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer DivideSigned<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IDivisionOperators<TElement, TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		for (int i = 0; i < TBuffer.Length; i++)
		{
			InlineArrayHelper.SetElement(ref buffer, i, NumericHelper.DivideSigned(x.GetElement<TBuffer, TElement>(i), y.GetElement<TBuffer, TElement>(i)));
		}
		return buffer;
	}

	public static TBuffer DivideUnsigned<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IDivisionOperators<TElement, TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		for (int i = 0; i < TBuffer.Length; i++)
		{
			InlineArrayHelper.SetElement(ref buffer, i, NumericHelper.DivideUnsigned(x.GetElement<TBuffer, TElement>(i), y.GetElement<TBuffer, TElement>(i)));
		}
		return buffer;
	}

	public static TBuffer Remainder<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IModulusOperators<TElement, TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Remainder(x.AsReadOnlySpan<TBuffer, TElement>(), y.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer RemainderSigned<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IModulusOperators<TElement, TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		for (int i = 0; i < TBuffer.Length; i++)
		{
			InlineArrayHelper.SetElement(ref buffer, i, NumericHelper.RemainderSigned(x.GetElement<TBuffer, TElement>(i), y.GetElement<TBuffer, TElement>(i)));
		}
		return buffer;
	}

	public static TBuffer RemainderUnsigned<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IModulusOperators<TElement, TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		for (int i = 0; i < TBuffer.Length; i++)
		{
			InlineArrayHelper.SetElement(ref buffer, i, NumericHelper.RemainderUnsigned(x.GetElement<TBuffer, TElement>(i), y.GetElement<TBuffer, TElement>(i)));
		}
		return buffer;
	}

	public static TBuffer Negate<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : IUnaryNegationOperators<TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Negate(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer ShiftLeft<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IShiftOperators<TElement, int, TElement>
	{
		TBuffer buffer = default(TBuffer);
		for (int i = 0; i < TBuffer.Length; i++)
		{
			InlineArrayHelper.SetElement(ref buffer, i, NumericHelper.ShiftLeft(x.GetElement<TBuffer, TElement>(i), y.GetElement<TBuffer, TElement>(i)));
		}
		return buffer;
	}

	public static TBuffer ShiftRightLogical<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IShiftOperators<TElement, int, TElement>
	{
		TBuffer buffer = default(TBuffer);
		for (int i = 0; i < TBuffer.Length; i++)
		{
			InlineArrayHelper.SetElement(ref buffer, i, NumericHelper.ShiftRightLogical(x.GetElement<TBuffer, TElement>(i), y.GetElement<TBuffer, TElement>(i)));
		}
		return buffer;
	}

	public static TBuffer ShiftRightArithmetic<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IShiftOperators<TElement, int, TElement>
	{
		TBuffer buffer = default(TBuffer);
		for (int i = 0; i < TBuffer.Length; i++)
		{
			InlineArrayHelper.SetElement(ref buffer, i, NumericHelper.ShiftRightArithmetic(x.GetElement<TBuffer, TElement>(i), y.GetElement<TBuffer, TElement>(i)));
		}
		return buffer;
	}

	public static TBuffer BitwiseAnd<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IBitwiseOperators<TElement, TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.BitwiseAnd(x.AsReadOnlySpan<TBuffer, TElement>(), y.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer BitwiseOr<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IBitwiseOperators<TElement, TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.BitwiseOr(x.AsReadOnlySpan<TBuffer, TElement>(), y.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer BitwiseXor<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IBitwiseOperators<TElement, TElement, TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Xor(x.AsReadOnlySpan<TBuffer, TElement>(), y.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer CtPop<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : unmanaged
	{
		TBuffer buffer = default(TBuffer);
		for (int i = 0; i < TBuffer.Length; i++)
		{
			InlineArrayHelper.SetElement(ref buffer, i, NumericHelper.CtPop(x.GetElement<TBuffer, TElement>(i)));
		}
		return buffer;
	}

	public static TBuffer Abs<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : INumberBase<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Abs(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer FAbs<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : INumberBase<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Abs(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Sin<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : ITrigonometricFunctions<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Sin(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Cos<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : ITrigonometricFunctions<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Cos(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Tan<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : ITrigonometricFunctions<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Tan(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Asin<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : ITrigonometricFunctions<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Asin(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Acos<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : ITrigonometricFunctions<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Acos(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Atan<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : ITrigonometricFunctions<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Atan(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Sinh<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : IHyperbolicFunctions<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Sinh(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Cosh<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : IHyperbolicFunctions<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Cosh(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Tanh<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : IHyperbolicFunctions<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Tanh(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Exp<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : IExponentialFunctions<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Exp(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Exp2<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : IExponentialFunctions<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Exp2(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Exp10<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : IExponentialFunctions<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Exp10(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Log<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : ILogarithmicFunctions<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Log(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Log2<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : ILogarithmicFunctions<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Log2(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Log10<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : ILogarithmicFunctions<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Log10(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Sqrt<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : IRootFunctions<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Sqrt(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Ceil<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : IFloatingPoint<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Ceiling(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Floor<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : IFloatingPoint<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Floor(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Round<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : IFloatingPoint<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Round(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer CtLz<TBuffer, TElement>(TBuffer x) where TBuffer : struct, IInlineArray<TElement> where TElement : IBinaryInteger<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.LeadingZeroCount(x.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}

	public static TBuffer Pow<TBuffer, TElement>(TBuffer x, TBuffer y) where TBuffer : struct, IInlineArray<TElement> where TElement : IPowerFunctions<TElement>
	{
		TBuffer buffer = default(TBuffer);
		TensorPrimitives.Pow(x.AsReadOnlySpan<TBuffer, TElement>(), y.AsReadOnlySpan<TBuffer, TElement>(), buffer.AsSpan<TBuffer, TElement>());
		return buffer;
	}
}
