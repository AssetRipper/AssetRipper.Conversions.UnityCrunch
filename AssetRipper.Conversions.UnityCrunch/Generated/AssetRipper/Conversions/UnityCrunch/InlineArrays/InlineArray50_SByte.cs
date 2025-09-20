using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(50)]
public partial struct InlineArray50_SByte : IEquatable<InlineArray50_SByte>, IEqualityOperators<InlineArray50_SByte, InlineArray50_SByte, bool>, IEnumerable, IInlineArray<InlineArray50_SByte, sbyte>, IInlineArray<InlineArray50_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 50;

	public static bool operator ==(InlineArray50_SByte x, InlineArray50_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray50_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray50_SByte x, InlineArray50_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray50_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray50_SByte)
		{
			return Equals((InlineArray50_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray50_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
