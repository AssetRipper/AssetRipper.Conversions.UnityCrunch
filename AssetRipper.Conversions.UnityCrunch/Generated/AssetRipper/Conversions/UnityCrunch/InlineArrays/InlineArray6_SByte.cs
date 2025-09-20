using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(6)]
public partial struct InlineArray6_SByte : IEquatable<InlineArray6_SByte>, IEqualityOperators<InlineArray6_SByte, InlineArray6_SByte, bool>, IEnumerable, IInlineArray<InlineArray6_SByte, sbyte>, IInlineArray<InlineArray6_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 6;

	public static bool operator ==(InlineArray6_SByte x, InlineArray6_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray6_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray6_SByte x, InlineArray6_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray6_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray6_SByte)
		{
			return Equals((InlineArray6_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray6_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
