using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(10)]
public partial struct InlineArray10_SByte : IEquatable<InlineArray10_SByte>, IEqualityOperators<InlineArray10_SByte, InlineArray10_SByte, bool>, IEnumerable, IInlineArray<InlineArray10_SByte, sbyte>, IInlineArray<InlineArray10_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 10;

	public static bool operator ==(InlineArray10_SByte x, InlineArray10_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray10_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray10_SByte x, InlineArray10_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray10_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray10_SByte)
		{
			return Equals((InlineArray10_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray10_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
