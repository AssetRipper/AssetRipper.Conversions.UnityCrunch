using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(2)]
public partial struct InlineArray2_SByte : IEquatable<InlineArray2_SByte>, IEqualityOperators<InlineArray2_SByte, InlineArray2_SByte, bool>, IEnumerable, IInlineArray<InlineArray2_SByte, sbyte>, IInlineArray<InlineArray2_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 2;

	public static bool operator ==(InlineArray2_SByte x, InlineArray2_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray2_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray2_SByte x, InlineArray2_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray2_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray2_SByte)
		{
			return Equals((InlineArray2_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray2_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
