using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(33)]
public partial struct InlineArray33_SByte : IEquatable<InlineArray33_SByte>, IEqualityOperators<InlineArray33_SByte, InlineArray33_SByte, bool>, IEnumerable, IInlineArray<InlineArray33_SByte, sbyte>, IInlineArray<InlineArray33_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 33;

	public static bool operator ==(InlineArray33_SByte x, InlineArray33_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray33_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray33_SByte x, InlineArray33_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray33_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray33_SByte)
		{
			return Equals((InlineArray33_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray33_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
