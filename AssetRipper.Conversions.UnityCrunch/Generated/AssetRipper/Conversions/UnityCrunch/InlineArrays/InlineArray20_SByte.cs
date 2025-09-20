using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(20)]
public partial struct InlineArray20_SByte : IEquatable<InlineArray20_SByte>, IEqualityOperators<InlineArray20_SByte, InlineArray20_SByte, bool>, IEnumerable, IInlineArray<InlineArray20_SByte, sbyte>, IInlineArray<InlineArray20_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 20;

	public static bool operator ==(InlineArray20_SByte x, InlineArray20_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray20_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray20_SByte x, InlineArray20_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray20_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray20_SByte)
		{
			return Equals((InlineArray20_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray20_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
