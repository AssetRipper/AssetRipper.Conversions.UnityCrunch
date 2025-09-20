using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(8)]
public partial struct InlineArray8_SByte : IEquatable<InlineArray8_SByte>, IEqualityOperators<InlineArray8_SByte, InlineArray8_SByte, bool>, IEnumerable, IInlineArray<InlineArray8_SByte, sbyte>, IInlineArray<InlineArray8_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 8;

	public static bool operator ==(InlineArray8_SByte x, InlineArray8_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray8_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray8_SByte x, InlineArray8_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray8_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray8_SByte)
		{
			return Equals((InlineArray8_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray8_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
