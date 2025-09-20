using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(48)]
public partial struct InlineArray48_SByte : IEquatable<InlineArray48_SByte>, IEqualityOperators<InlineArray48_SByte, InlineArray48_SByte, bool>, IEnumerable, IInlineArray<InlineArray48_SByte, sbyte>, IInlineArray<InlineArray48_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 48;

	public static bool operator ==(InlineArray48_SByte x, InlineArray48_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray48_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray48_SByte x, InlineArray48_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray48_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray48_SByte)
		{
			return Equals((InlineArray48_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray48_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
