using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(16)]
public partial struct InlineArray16_SByte : IEquatable<InlineArray16_SByte>, IEqualityOperators<InlineArray16_SByte, InlineArray16_SByte, bool>, IEnumerable, IInlineArray<InlineArray16_SByte, sbyte>, IInlineArray<InlineArray16_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 16;

	public static bool operator ==(InlineArray16_SByte x, InlineArray16_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray16_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray16_SByte x, InlineArray16_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray16_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray16_SByte)
		{
			return Equals((InlineArray16_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray16_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
