using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(1)]
public partial struct InlineArray1_SByte : IEquatable<InlineArray1_SByte>, IEqualityOperators<InlineArray1_SByte, InlineArray1_SByte, bool>, IEnumerable, IInlineArray<InlineArray1_SByte, sbyte>, IInlineArray<InlineArray1_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 1;

	public static bool operator ==(InlineArray1_SByte x, InlineArray1_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray1_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray1_SByte x, InlineArray1_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray1_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray1_SByte)
		{
			return Equals((InlineArray1_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray1_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
