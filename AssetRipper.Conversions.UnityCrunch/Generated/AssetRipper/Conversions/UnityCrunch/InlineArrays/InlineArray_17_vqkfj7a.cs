using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(17)]
public partial struct InlineArray_17_vqkfj7a : IEquatable<InlineArray_17_vqkfj7a>, IEqualityOperators<InlineArray_17_vqkfj7a, InlineArray_17_vqkfj7a, bool>, IEnumerable, IInlineArray<InlineArray_17_vqkfj7a, int>, IInlineArray<InlineArray_17_vqkfj7a, uint>
{
	private int __element0;

	public static int Length => 17;

	public static bool operator ==(InlineArray_17_vqkfj7a x, InlineArray_17_vqkfj7a y)
	{
		return InlineArrayHelper.Equals<InlineArray_17_vqkfj7a, int>(x, y);
	}

	public static bool operator !=(InlineArray_17_vqkfj7a x, InlineArray_17_vqkfj7a y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_17_vqkfj7a other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_17_vqkfj7a)
		{
			return Equals((InlineArray_17_vqkfj7a)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_17_vqkfj7a, int>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
