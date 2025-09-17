using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace AssetRipper.Conversions.UnityCrunch.Helpers;

internal static partial class NativeMemoryHelper
{
	private static readonly ConcurrentDictionary<nint, long> allocationSizes = new ConcurrentDictionary<nint, long>();

	private static void SetAllocation(nint ptr, long size)
	{
		allocationSizes[ptr] = size;
	}

	private static void RemoveAllocation(nint ptr)
	{
		allocationSizes.TryRemove(ptr, out var _);
	}

	public unsafe static void* Allocate(int size)
	{
		return Allocate(unchecked((long)size));
	}

	public unsafe static void* Allocate(long size)
	{
		nint ptr = Marshal.AllocHGlobal((nint)size);
		SetAllocation(ptr, size);
		return unchecked((IntPtr)ptr).ToPointer();
	}

	public unsafe static void Free(void* ptr)
	{
		nint num = (nint)ptr;
		RemoveAllocation(num);
		Marshal.FreeHGlobal(num);
	}

	public unsafe static void* Reallocate(void* ptr, int newSize)
	{
		return Reallocate(ptr, unchecked((long)newSize));
	}

	public unsafe static void* Reallocate(void* ptr, long newSize)
	{
		nint num = (nint)ptr;
		nint num2 = Marshal.ReAllocHGlobal(num, (nint)newSize);
		SetAllocation(num2, newSize);
		if (num2 != num)
		{
			RemoveAllocation(num);
		}
		return unchecked((IntPtr)num2).ToPointer();
	}

	public unsafe static long Size(void* ptr)
	{
		return allocationSizes[(nint)ptr];
	}
}
