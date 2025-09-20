using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(64)]
public partial struct InlineArray64_SByte : IEquatable<InlineArray64_SByte>, IEqualityOperators<InlineArray64_SByte, InlineArray64_SByte, bool>, IEnumerable, IInlineArray<InlineArray64_SByte, sbyte>, IInlineArray<InlineArray64_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 64;

	public static bool operator ==(InlineArray64_SByte x, InlineArray64_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray64_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray64_SByte x, InlineArray64_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray64_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray64_SByte)
		{
			return Equals((InlineArray64_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray64_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
