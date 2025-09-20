using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(17)]
public partial struct InlineArray17_Int32 : IEquatable<InlineArray17_Int32>, IEqualityOperators<InlineArray17_Int32, InlineArray17_Int32, bool>, IEnumerable, IInlineArray<InlineArray17_Int32, int>, IInlineArray<InlineArray17_Int32, uint>
{
	private int __element0;

	public static int Length => 17;

	public static bool operator ==(InlineArray17_Int32 x, InlineArray17_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray17_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray17_Int32 x, InlineArray17_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray17_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray17_Int32)
		{
			return Equals((InlineArray17_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray17_Int32, int>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
