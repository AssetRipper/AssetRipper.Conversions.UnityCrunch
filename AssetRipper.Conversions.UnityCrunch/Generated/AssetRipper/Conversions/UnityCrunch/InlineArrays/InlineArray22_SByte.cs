using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(22)]
public partial struct InlineArray22_SByte : IEquatable<InlineArray22_SByte>, IEqualityOperators<InlineArray22_SByte, InlineArray22_SByte, bool>, IEnumerable, IInlineArray<InlineArray22_SByte, sbyte>, IInlineArray<InlineArray22_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 22;

	public static bool operator ==(InlineArray22_SByte x, InlineArray22_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray22_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray22_SByte x, InlineArray22_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray22_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray22_SByte)
		{
			return Equals((InlineArray22_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray22_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
