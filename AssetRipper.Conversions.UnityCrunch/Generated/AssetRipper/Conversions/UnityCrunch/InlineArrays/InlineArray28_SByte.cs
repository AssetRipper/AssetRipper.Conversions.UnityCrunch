using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(28)]
public partial struct InlineArray28_SByte : IEquatable<InlineArray28_SByte>, IEqualityOperators<InlineArray28_SByte, InlineArray28_SByte, bool>, IEnumerable, IInlineArray<InlineArray28_SByte, sbyte>, IInlineArray<InlineArray28_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 28;

	public static bool operator ==(InlineArray28_SByte x, InlineArray28_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray28_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray28_SByte x, InlineArray28_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray28_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray28_SByte)
		{
			return Equals((InlineArray28_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray28_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
