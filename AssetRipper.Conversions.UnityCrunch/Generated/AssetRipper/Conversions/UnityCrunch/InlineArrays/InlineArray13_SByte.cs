using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(13)]
public partial struct InlineArray13_SByte : IEquatable<InlineArray13_SByte>, IEqualityOperators<InlineArray13_SByte, InlineArray13_SByte, bool>, IEnumerable, IInlineArray<InlineArray13_SByte, sbyte>, IInlineArray<InlineArray13_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 13;

	public static bool operator ==(InlineArray13_SByte x, InlineArray13_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray13_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray13_SByte x, InlineArray13_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray13_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray13_SByte)
		{
			return Equals((InlineArray13_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray13_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
