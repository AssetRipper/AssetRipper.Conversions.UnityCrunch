using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(31)]
public partial struct InlineArray31_SByte : IEquatable<InlineArray31_SByte>, IEqualityOperators<InlineArray31_SByte, InlineArray31_SByte, bool>, IEnumerable, IInlineArray<InlineArray31_SByte, sbyte>, IInlineArray<InlineArray31_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 31;

	public static bool operator ==(InlineArray31_SByte x, InlineArray31_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray31_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray31_SByte x, InlineArray31_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray31_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray31_SByte)
		{
			return Equals((InlineArray31_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray31_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
