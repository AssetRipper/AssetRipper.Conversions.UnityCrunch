using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(1)]
public partial struct InlineArray1_crnd_crn_packed_uint_25ciii : IEquatable<InlineArray1_crnd_crn_packed_uint_25ciii>, IEqualityOperators<InlineArray1_crnd_crn_packed_uint_25ciii, InlineArray1_crnd_crn_packed_uint_25ciii, bool>, IEnumerable, IInlineArray<InlineArray1_crnd_crn_packed_uint_25ciii, crnd_crn_packed_uint_25ciii>
{
	private crnd_crn_packed_uint_25ciii __element0;

	public static int Length => 1;

	public static bool operator ==(InlineArray1_crnd_crn_packed_uint_25ciii x, InlineArray1_crnd_crn_packed_uint_25ciii y)
	{
		return InlineArrayHelper.Equals<InlineArray1_crnd_crn_packed_uint_25ciii, crnd_crn_packed_uint_25ciii>(x, y);
	}

	public static bool operator !=(InlineArray1_crnd_crn_packed_uint_25ciii x, InlineArray1_crnd_crn_packed_uint_25ciii y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray1_crnd_crn_packed_uint_25ciii other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray1_crnd_crn_packed_uint_25ciii)
		{
			return Equals((InlineArray1_crnd_crn_packed_uint_25ciii)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray1_crnd_crn_packed_uint_25ciii, crnd_crn_packed_uint_25ciii>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<crnd_crn_packed_uint_25ciii>)this).GetEnumerator();
	}
}
