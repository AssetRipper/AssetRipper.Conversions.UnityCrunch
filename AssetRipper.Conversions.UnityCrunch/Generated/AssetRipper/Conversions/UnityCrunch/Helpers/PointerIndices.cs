using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.UnityCrunch.Helpers;

internal static partial class PointerIndices
{
	private static readonly Dictionary<int, nint> IndexToPointer = new Dictionary<int, nint>();

	private static readonly Dictionary<nint, int> PointerToIndex = new Dictionary<nint, int>();

	public unsafe static void* Register(void* ptr)
	{
		ThrowIfNull(ptr, "ptr");
		int num = IndexToPointer.Count + 1;
		IndexToPointer.Add(num, (nint)ptr);
		PointerToIndex.Add((nint)ptr, num);
		return ptr;
		unsafe static void ThrowIfNull(void* value, [CallerArgumentExpression("value")] string? paramName = null)
		{
			if (value == null)
			{
				throw new ArgumentNullException(paramName);
			}
		}
	}

	public unsafe static int GetIndex(void* ptr)
	{
		if (ptr == null)
		{
			return 0;
		}
		return PointerToIndex[(nint)ptr];
	}

	public unsafe static void* GetPointer(int index)
	{
		if (index == 0)
		{
			return null;
		}
		unchecked
		{
			return (void*)checked((nuint)IndexToPointer[index]);
		}
	}
}
