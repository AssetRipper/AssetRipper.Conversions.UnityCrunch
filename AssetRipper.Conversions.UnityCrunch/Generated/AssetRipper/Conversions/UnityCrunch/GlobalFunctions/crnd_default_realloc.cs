using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_default_realloc@crnd@@YAPEAXPEAX_KPEA_K_N0@Z")]
[DemangledName("void * __cdecl crnd::crnd_default_realloc(void *, unsigned __int64, unsigned __int64 *, bool, void *)")]
internal static partial class crnd_default_realloc
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, long, void*, bool, void*, void*>)(&Invoke));

	public unsafe static void* Invoke(void* p, long size, void* pActual_size, bool movable, void* parameter_4)
	{
		sbyte b = 0;
		void* ptr = null;
		long num = 0L;
		void* ptr2 = null;
		void* ptr3 = null;
		void* ptr4 = null;
		b = (movable ? ((sbyte)1) : ((sbyte)0));
		ptr = pActual_size;
		num = size;
		ptr2 = p;
		unchecked
		{
			if (ptr2 == null)
			{
				ptr3 = malloc.Invoke(num);
				if (ptr != null)
				{
					*(long*)ptr = ((ptr3 == null) ? 0L : msize.Invoke(ptr3));
				}
			}
			else if (num == 0L)
			{
				free.Invoke(ptr2);
				ptr3 = null;
				if (ptr != null)
				{
					*(long*)ptr = 0L;
				}
			}
			else
			{
				ptr4 = ptr2;
				ptr3 = null;
				if (ptr3 != null)
				{
					ptr4 = ptr3;
				}
				else if ((b & 1) == 1)
				{
					ptr3 = realloc.Invoke(ptr2, num);
					if (ptr3 != null)
					{
						ptr4 = ptr3;
					}
				}
				if (ptr != null)
				{
					*(long*)ptr = msize.Invoke(ptr4);
				}
			}
			return ptr3;
		}
	}
}
