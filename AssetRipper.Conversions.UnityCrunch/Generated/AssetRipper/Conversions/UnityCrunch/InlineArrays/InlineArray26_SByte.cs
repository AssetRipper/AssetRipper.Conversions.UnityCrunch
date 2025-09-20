using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(26)]
public partial struct InlineArray26_SByte : IEquatable<InlineArray26_SByte>, IEqualityOperators<InlineArray26_SByte, InlineArray26_SByte, bool>, IEnumerable, IInlineArray<InlineArray26_SByte, sbyte>, IInlineArray<InlineArray26_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 26;

	public static bool operator ==(InlineArray26_SByte x, InlineArray26_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray26_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray26_SByte x, InlineArray26_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray26_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray26_SByte)
		{
			return Equals((InlineArray26_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray26_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
