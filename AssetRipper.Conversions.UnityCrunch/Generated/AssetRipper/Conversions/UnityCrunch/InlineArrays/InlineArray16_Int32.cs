using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(16)]
public partial struct InlineArray16_Int32 : IEquatable<InlineArray16_Int32>, IEqualityOperators<InlineArray16_Int32, InlineArray16_Int32, bool>, IEnumerable, IInlineArray<InlineArray16_Int32, int>, IInlineArray<InlineArray16_Int32, uint>
{
	private int __element0;

	public static int Length => 16;

	public static bool operator ==(InlineArray16_Int32 x, InlineArray16_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray16_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray16_Int32 x, InlineArray16_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray16_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray16_Int32)
		{
			return Equals((InlineArray16_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray16_Int32, int>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
