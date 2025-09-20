using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(35)]
public partial struct InlineArray35_SByte : IEquatable<InlineArray35_SByte>, IEqualityOperators<InlineArray35_SByte, InlineArray35_SByte, bool>, IEnumerable, IInlineArray<InlineArray35_SByte, sbyte>, IInlineArray<InlineArray35_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 35;

	public static bool operator ==(InlineArray35_SByte x, InlineArray35_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray35_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray35_SByte x, InlineArray35_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray35_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray35_SByte)
		{
			return Equals((InlineArray35_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray35_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
