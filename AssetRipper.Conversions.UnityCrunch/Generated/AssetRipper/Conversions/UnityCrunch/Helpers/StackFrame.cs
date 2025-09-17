using System.Runtime.CompilerServices;

namespace AssetRipper.Conversions.UnityCrunch.Helpers;

internal partial struct StackFrame
{
	internal readonly int Index;

	private unsafe void* Locals;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe StackFrame(int index, int size)
	{
		Index = index;
		Locals = ((size > 0) ? NativeMemoryHelper.Allocate(size) : null);
	}

	internal unsafe void FreeLocals()
	{
		if (Locals != null)
		{
			NativeMemoryHelper.Free(Locals);
			Locals = null;
		}
	}

	public unsafe readonly ref T GetLocalsRef<T>() where T : unmanaged
	{
		return ref Unsafe.AsRef<T>(Locals);
	}

	public unsafe readonly T* GetLocalsPointer<T>() where T : unmanaged
	{
		return unchecked((T*)Locals);
	}

	internal unsafe static StackFrame Create<T>(int index) where T : unmanaged
	{
		return new StackFrame(index, sizeof(T));
	}
}
