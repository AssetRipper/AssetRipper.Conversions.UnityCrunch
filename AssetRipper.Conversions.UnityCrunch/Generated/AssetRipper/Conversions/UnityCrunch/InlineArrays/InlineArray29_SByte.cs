using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(29)]
public partial struct InlineArray29_SByte : IEquatable<InlineArray29_SByte>, IEqualityOperators<InlineArray29_SByte, InlineArray29_SByte, bool>, IEnumerable, IInlineArray<InlineArray29_SByte, sbyte>, IInlineArray<InlineArray29_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 29;

	public static bool operator ==(InlineArray29_SByte x, InlineArray29_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray29_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray29_SByte x, InlineArray29_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray29_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray29_SByte)
		{
			return Equals((InlineArray29_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray29_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
