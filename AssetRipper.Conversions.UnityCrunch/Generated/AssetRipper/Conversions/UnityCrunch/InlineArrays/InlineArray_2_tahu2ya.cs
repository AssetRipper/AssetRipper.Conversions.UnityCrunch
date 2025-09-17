using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(2)]
public partial struct InlineArray_2_tahu2ya : IEquatable<InlineArray_2_tahu2ya>, IEqualityOperators<InlineArray_2_tahu2ya, InlineArray_2_tahu2ya, bool>, IEnumerable, IInlineArray<InlineArray_2_tahu2ya, crnd_static_huffman_data_model>
{
	private crnd_static_huffman_data_model __element0;

	public static int Length => 2;

	public static bool operator ==(InlineArray_2_tahu2ya x, InlineArray_2_tahu2ya y)
	{
		return InlineArrayHelper.Equals<InlineArray_2_tahu2ya, crnd_static_huffman_data_model>(x, y);
	}

	public static bool operator !=(InlineArray_2_tahu2ya x, InlineArray_2_tahu2ya y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray_2_tahu2ya other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray_2_tahu2ya)
		{
			return Equals((InlineArray_2_tahu2ya)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray_2_tahu2ya, crnd_static_huffman_data_model>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<crnd_static_huffman_data_model>)this).GetEnumerator();
	}
}
