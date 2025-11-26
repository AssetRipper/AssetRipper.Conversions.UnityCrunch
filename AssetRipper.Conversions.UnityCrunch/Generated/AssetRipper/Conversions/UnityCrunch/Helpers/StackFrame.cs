namespace AssetRipper.Conversions.UnityCrunch.Helpers;

internal unsafe partial struct StackFrame(int index, int size)
{
	internal readonly int Index = index;

	private unsafe void* Locals = ((size > 0) ? NativeMemoryHelper.Allocate(size) : null);

	internal unsafe void FreeLocals()
	{
		if (Locals != null)
		{
			NativeMemoryHelper.Free(Locals);
			Locals = null;
		}
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
