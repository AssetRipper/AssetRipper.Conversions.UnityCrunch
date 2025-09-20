using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(44)]
public partial struct InlineArray44_SByte : IEquatable<InlineArray44_SByte>, IEqualityOperators<InlineArray44_SByte, InlineArray44_SByte, bool>, IEnumerable, IInlineArray<InlineArray44_SByte, sbyte>, IInlineArray<InlineArray44_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 44;

	public static bool operator ==(InlineArray44_SByte x, InlineArray44_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray44_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray44_SByte x, InlineArray44_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray44_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray44_SByte)
		{
			return Equals((InlineArray44_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray44_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
