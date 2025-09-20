using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(84)]
public partial struct InlineArray84_SByte : IEquatable<InlineArray84_SByte>, IEqualityOperators<InlineArray84_SByte, InlineArray84_SByte, bool>, IEnumerable, IInlineArray<InlineArray84_SByte, sbyte>, IInlineArray<InlineArray84_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 84;

	public static bool operator ==(InlineArray84_SByte x, InlineArray84_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray84_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray84_SByte x, InlineArray84_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray84_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray84_SByte)
		{
			return Equals((InlineArray84_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray84_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
