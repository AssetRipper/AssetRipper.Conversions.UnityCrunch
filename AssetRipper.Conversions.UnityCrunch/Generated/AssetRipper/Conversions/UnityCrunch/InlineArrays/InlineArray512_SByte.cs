using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(512)]
public partial struct InlineArray512_SByte : IEquatable<InlineArray512_SByte>, IEqualityOperators<InlineArray512_SByte, InlineArray512_SByte, bool>, IEnumerable, IInlineArray<InlineArray512_SByte, sbyte>, IInlineArray<InlineArray512_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 512;

	public static bool operator ==(InlineArray512_SByte x, InlineArray512_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray512_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray512_SByte x, InlineArray512_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray512_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray512_SByte)
		{
			return Equals((InlineArray512_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray512_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
