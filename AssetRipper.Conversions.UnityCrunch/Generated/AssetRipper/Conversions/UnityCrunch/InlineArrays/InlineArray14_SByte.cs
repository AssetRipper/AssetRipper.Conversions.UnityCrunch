using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(14)]
public partial struct InlineArray14_SByte : IEquatable<InlineArray14_SByte>, IEqualityOperators<InlineArray14_SByte, InlineArray14_SByte, bool>, IEnumerable, IInlineArray<InlineArray14_SByte, sbyte>, IInlineArray<InlineArray14_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 14;

	public static bool operator ==(InlineArray14_SByte x, InlineArray14_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray14_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray14_SByte x, InlineArray14_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray14_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray14_SByte)
		{
			return Equals((InlineArray14_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray14_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
