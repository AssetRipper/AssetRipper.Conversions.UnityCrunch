using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(70)]
public partial struct InlineArray70_SByte : IEquatable<InlineArray70_SByte>, IEqualityOperators<InlineArray70_SByte, InlineArray70_SByte, bool>, IEnumerable, IInlineArray<InlineArray70_SByte, sbyte>, IInlineArray<InlineArray70_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 70;

	public static bool operator ==(InlineArray70_SByte x, InlineArray70_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray70_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray70_SByte x, InlineArray70_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray70_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray70_SByte)
		{
			return Equals((InlineArray70_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray70_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
