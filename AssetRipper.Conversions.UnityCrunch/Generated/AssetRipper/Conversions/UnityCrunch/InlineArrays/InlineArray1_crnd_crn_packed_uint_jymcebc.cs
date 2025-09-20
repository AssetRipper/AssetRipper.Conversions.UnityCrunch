using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(1)]
public partial struct InlineArray1_crnd_crn_packed_uint_jymcebc : IEquatable<InlineArray1_crnd_crn_packed_uint_jymcebc>, IEqualityOperators<InlineArray1_crnd_crn_packed_uint_jymcebc, InlineArray1_crnd_crn_packed_uint_jymcebc, bool>, IEnumerable, IInlineArray<InlineArray1_crnd_crn_packed_uint_jymcebc, crnd_crn_packed_uint_jymcebc>
{
	private crnd_crn_packed_uint_jymcebc __element0;

	public static int Length => 1;

	public static bool operator ==(InlineArray1_crnd_crn_packed_uint_jymcebc x, InlineArray1_crnd_crn_packed_uint_jymcebc y)
	{
		return InlineArrayHelper.Equals<InlineArray1_crnd_crn_packed_uint_jymcebc, crnd_crn_packed_uint_jymcebc>(x, y);
	}

	public static bool operator !=(InlineArray1_crnd_crn_packed_uint_jymcebc x, InlineArray1_crnd_crn_packed_uint_jymcebc y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray1_crnd_crn_packed_uint_jymcebc other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray1_crnd_crn_packed_uint_jymcebc)
		{
			return Equals((InlineArray1_crnd_crn_packed_uint_jymcebc)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray1_crnd_crn_packed_uint_jymcebc, crnd_crn_packed_uint_jymcebc>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<crnd_crn_packed_uint_jymcebc>)this).GetEnumerator();
	}
}
