using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(27)]
public partial struct InlineArray27_SByte : IEquatable<InlineArray27_SByte>, IEqualityOperators<InlineArray27_SByte, InlineArray27_SByte, bool>, IEnumerable, IInlineArray<InlineArray27_SByte, sbyte>, IInlineArray<InlineArray27_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 27;

	public static bool operator ==(InlineArray27_SByte x, InlineArray27_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray27_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray27_SByte x, InlineArray27_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray27_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray27_SByte)
		{
			return Equals((InlineArray27_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray27_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
