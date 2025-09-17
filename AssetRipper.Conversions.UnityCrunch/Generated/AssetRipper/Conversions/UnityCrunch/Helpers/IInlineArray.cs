using System.Collections;
using System.Collections.Generic;

namespace AssetRipper.Conversions.UnityCrunch.Helpers;

internal partial interface IInlineArray<out T>
{
	static abstract int Length { get; }
}
internal partial interface IInlineArray<TSelf, out TElement> : IInlineArray<TElement>, IReadOnlyList<TElement>, IEnumerable<TElement>, IEnumerable, IReadOnlyCollection<TElement> where TSelf : struct, IInlineArray<TElement>
{
	TElement IReadOnlyList<TElement>.this[int index]
	{
		get
		{
			TSelf buffer = (TSelf)this;
			return buffer.GetElement<TSelf, TElement>(index);
		}
	}

	int IReadOnlyCollection<TElement>.Count => TSelf.Length;

	IEnumerator<TElement> IEnumerable<TElement>.GetEnumerator()
	{
		for (int i = 0; i < TSelf.Length; i++)
		{
			yield return this[i];
		}
	}
}
