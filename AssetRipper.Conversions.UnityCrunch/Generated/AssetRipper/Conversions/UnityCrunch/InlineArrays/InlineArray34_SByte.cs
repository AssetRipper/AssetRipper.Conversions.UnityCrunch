using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(34)]
public partial struct InlineArray34_SByte : IEquatable<InlineArray34_SByte>, IEqualityOperators<InlineArray34_SByte, InlineArray34_SByte, bool>, IEnumerable, IInlineArray<InlineArray34_SByte, sbyte>, IInlineArray<InlineArray34_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 34;

	public static bool operator ==(InlineArray34_SByte x, InlineArray34_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray34_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray34_SByte x, InlineArray34_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray34_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray34_SByte)
		{
			return Equals((InlineArray34_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray34_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
