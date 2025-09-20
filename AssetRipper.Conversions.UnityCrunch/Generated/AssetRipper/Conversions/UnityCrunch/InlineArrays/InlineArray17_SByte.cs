using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(17)]
public partial struct InlineArray17_SByte : IEquatable<InlineArray17_SByte>, IEqualityOperators<InlineArray17_SByte, InlineArray17_SByte, bool>, IEnumerable, IInlineArray<InlineArray17_SByte, sbyte>, IInlineArray<InlineArray17_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 17;

	public static bool operator ==(InlineArray17_SByte x, InlineArray17_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray17_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray17_SByte x, InlineArray17_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray17_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray17_SByte)
		{
			return Equals((InlineArray17_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray17_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
