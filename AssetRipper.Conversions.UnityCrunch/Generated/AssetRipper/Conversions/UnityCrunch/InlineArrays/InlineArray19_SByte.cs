using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(19)]
public partial struct InlineArray19_SByte : IEquatable<InlineArray19_SByte>, IEqualityOperators<InlineArray19_SByte, InlineArray19_SByte, bool>, IEnumerable, IInlineArray<InlineArray19_SByte, sbyte>, IInlineArray<InlineArray19_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 19;

	public static bool operator ==(InlineArray19_SByte x, InlineArray19_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray19_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray19_SByte x, InlineArray19_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray19_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray19_SByte)
		{
			return Equals((InlineArray19_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray19_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
