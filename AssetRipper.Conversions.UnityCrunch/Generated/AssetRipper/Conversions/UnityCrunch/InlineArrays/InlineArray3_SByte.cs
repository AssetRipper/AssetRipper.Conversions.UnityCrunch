using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(3)]
public partial struct InlineArray3_SByte : IEquatable<InlineArray3_SByte>, IEqualityOperators<InlineArray3_SByte, InlineArray3_SByte, bool>, IEnumerable, IInlineArray<InlineArray3_SByte, sbyte>, IInlineArray<InlineArray3_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 3;

	public static bool operator ==(InlineArray3_SByte x, InlineArray3_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray3_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray3_SByte x, InlineArray3_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray3_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray3_SByte)
		{
			return Equals((InlineArray3_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray3_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
