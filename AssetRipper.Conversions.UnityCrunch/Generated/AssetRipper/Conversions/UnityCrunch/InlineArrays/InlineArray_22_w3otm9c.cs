using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(22)]
public partial struct InlineArray_22_w3otm9c : IEquatable<InlineArray_22_w3otm9c>, IEqualityOperators<InlineArray_22_w3otm9c, InlineArray_22_w3otm9c, bool>, IEnumerable, IInlineArray<InlineArray_22_w3otm9c, sbyte>, IInlineArray<InlineArray_22_w3otm9c, byte>
{
	private sbyte __element0;

	public static int Length => 22;

	public static bool operator ==(InlineArray_22_w3otm9c x, InlineArray_22_w3otm9c y)
	{
		return InlineArrayHelper.Equals<InlineArray_22_w3otm9c, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray_22_w3otm9c x, InlineArray_22_w3otm9c y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_22_w3otm9c other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_22_w3otm9c)
		{
			return Equals((InlineArray_22_w3otm9c)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_22_w3otm9c, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
