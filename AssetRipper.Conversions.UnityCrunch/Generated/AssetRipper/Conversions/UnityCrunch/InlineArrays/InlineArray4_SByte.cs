using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(4)]
public partial struct InlineArray4_SByte : IEquatable<InlineArray4_SByte>, IEqualityOperators<InlineArray4_SByte, InlineArray4_SByte, bool>, IEnumerable, IInlineArray<InlineArray4_SByte, sbyte>, IInlineArray<InlineArray4_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 4;

	public static bool operator ==(InlineArray4_SByte x, InlineArray4_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray4_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray4_SByte x, InlineArray4_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray4_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray4_SByte)
		{
			return Equals((InlineArray4_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray4_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
