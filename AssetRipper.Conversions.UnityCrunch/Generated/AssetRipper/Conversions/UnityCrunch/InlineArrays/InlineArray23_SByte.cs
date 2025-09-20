using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(23)]
public partial struct InlineArray23_SByte : IEquatable<InlineArray23_SByte>, IEqualityOperators<InlineArray23_SByte, InlineArray23_SByte, bool>, IEnumerable, IInlineArray<InlineArray23_SByte, sbyte>, IInlineArray<InlineArray23_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 23;

	public static bool operator ==(InlineArray23_SByte x, InlineArray23_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray23_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray23_SByte x, InlineArray23_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray23_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray23_SByte)
		{
			return Equals((InlineArray23_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray23_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
