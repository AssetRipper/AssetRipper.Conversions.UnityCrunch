using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(11)]
public partial struct InlineArray11_SByte : IEquatable<InlineArray11_SByte>, IEqualityOperators<InlineArray11_SByte, InlineArray11_SByte, bool>, IEnumerable, IInlineArray<InlineArray11_SByte, sbyte>, IInlineArray<InlineArray11_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 11;

	public static bool operator ==(InlineArray11_SByte x, InlineArray11_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray11_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray11_SByte x, InlineArray11_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray11_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray11_SByte)
		{
			return Equals((InlineArray11_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray11_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
