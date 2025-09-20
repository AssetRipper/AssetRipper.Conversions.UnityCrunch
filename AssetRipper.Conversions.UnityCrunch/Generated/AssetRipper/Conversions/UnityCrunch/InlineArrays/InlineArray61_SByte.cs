using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(61)]
public partial struct InlineArray61_SByte : IEquatable<InlineArray61_SByte>, IEqualityOperators<InlineArray61_SByte, InlineArray61_SByte, bool>, IEnumerable, IInlineArray<InlineArray61_SByte, sbyte>, IInlineArray<InlineArray61_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 61;

	public static bool operator ==(InlineArray61_SByte x, InlineArray61_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray61_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray61_SByte x, InlineArray61_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray61_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray61_SByte)
		{
			return Equals((InlineArray61_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray61_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
