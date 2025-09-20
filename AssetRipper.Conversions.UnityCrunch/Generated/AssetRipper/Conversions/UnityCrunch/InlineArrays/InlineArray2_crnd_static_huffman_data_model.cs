using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.InlineArrays;

[InlineArray(2)]
public partial struct InlineArray2_crnd_static_huffman_data_model : IEquatable<InlineArray2_crnd_static_huffman_data_model>, IEqualityOperators<InlineArray2_crnd_static_huffman_data_model, InlineArray2_crnd_static_huffman_data_model, bool>, IEnumerable, IInlineArray<InlineArray2_crnd_static_huffman_data_model, crnd_static_huffman_data_model>
{
	private crnd_static_huffman_data_model __element0;

	public static int Length => 2;

	public static bool operator ==(InlineArray2_crnd_static_huffman_data_model x, InlineArray2_crnd_static_huffman_data_model y)
	{
		return InlineArrayHelper.Equals<InlineArray2_crnd_static_huffman_data_model, crnd_static_huffman_data_model>(x, y);
	}

	public static bool operator !=(InlineArray2_crnd_static_huffman_data_model x, InlineArray2_crnd_static_huffman_data_model y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray2_crnd_static_huffman_data_model other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray2_crnd_static_huffman_data_model)
		{
			return Equals((InlineArray2_crnd_static_huffman_data_model)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray2_crnd_static_huffman_data_model, crnd_static_huffman_data_model>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<crnd_static_huffman_data_model>)this).GetEnumerator();
	}
}
