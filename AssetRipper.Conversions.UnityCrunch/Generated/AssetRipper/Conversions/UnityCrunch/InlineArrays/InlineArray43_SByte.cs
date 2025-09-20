using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(43)]
public partial struct InlineArray43_SByte : IEquatable<InlineArray43_SByte>, IEqualityOperators<InlineArray43_SByte, InlineArray43_SByte, bool>, IEnumerable, IInlineArray<InlineArray43_SByte, sbyte>, IInlineArray<InlineArray43_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 43;

	public static bool operator ==(InlineArray43_SByte x, InlineArray43_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray43_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray43_SByte x, InlineArray43_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray43_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray43_SByte)
		{
			return Equals((InlineArray43_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray43_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
