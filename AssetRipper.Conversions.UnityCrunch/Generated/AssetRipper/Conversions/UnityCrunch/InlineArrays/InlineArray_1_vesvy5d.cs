using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(1)]
public partial struct InlineArray_1_vesvy5d : IEquatable<InlineArray_1_vesvy5d>, IEqualityOperators<InlineArray_1_vesvy5d, InlineArray_1_vesvy5d, bool>, IEnumerable, IInlineArray<InlineArray_1_vesvy5d, crnd_crn_packed_uint_0>
{
	private crnd_crn_packed_uint_0 __element0;

	public static int Length => 1;

	public static bool operator ==(InlineArray_1_vesvy5d x, InlineArray_1_vesvy5d y)
	{
		return InlineArrayHelper.Equals<InlineArray_1_vesvy5d, crnd_crn_packed_uint_0>(x, y);
	}

	public static bool operator !=(InlineArray_1_vesvy5d x, InlineArray_1_vesvy5d y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_1_vesvy5d other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_1_vesvy5d)
		{
			return Equals((InlineArray_1_vesvy5d)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_1_vesvy5d, crnd_crn_packed_uint_0>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<crnd_crn_packed_uint_0>)this).GetEnumerator();
	}
}
