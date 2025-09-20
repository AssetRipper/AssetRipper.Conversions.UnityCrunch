using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(96)]
public partial struct InlineArray96_SByte : IEquatable<InlineArray96_SByte>, IEqualityOperators<InlineArray96_SByte, InlineArray96_SByte, bool>, IEnumerable, IInlineArray<InlineArray96_SByte, sbyte>, IInlineArray<InlineArray96_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 96;

	public static bool operator ==(InlineArray96_SByte x, InlineArray96_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray96_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray96_SByte x, InlineArray96_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray96_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray96_SByte)
		{
			return Equals((InlineArray96_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray96_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
