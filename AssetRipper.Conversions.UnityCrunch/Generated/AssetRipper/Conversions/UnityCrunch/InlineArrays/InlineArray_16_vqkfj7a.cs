using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(16)]
public partial struct InlineArray_16_vqkfj7a : IEquatable<InlineArray_16_vqkfj7a>, IEqualityOperators<InlineArray_16_vqkfj7a, InlineArray_16_vqkfj7a, bool>, IEnumerable, IInlineArray<InlineArray_16_vqkfj7a, int>, IInlineArray<InlineArray_16_vqkfj7a, uint>
{
	private int __element0;

	public static int Length => 16;

	public static bool operator ==(InlineArray_16_vqkfj7a x, InlineArray_16_vqkfj7a y)
	{
		return InlineArrayHelper.Equals<InlineArray_16_vqkfj7a, int>(x, y);
	}

	public static bool operator !=(InlineArray_16_vqkfj7a x, InlineArray_16_vqkfj7a y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_16_vqkfj7a other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_16_vqkfj7a)
		{
			return Equals((InlineArray_16_vqkfj7a)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_16_vqkfj7a, int>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
