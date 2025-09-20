using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_default_realloc@crnd@@YAPEAXPEAX_KPEA_K_N0@Z")]
[DemangledName("void * __cdecl crnd::crnd_default_realloc(void *, unsigned __int64, unsigned __int64 *, bool, void *)")]
internal static partial class crnd_default_realloc
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, long, void*, bool, void*, void*>)(&Invoke));

	[return: NativeType("void *")]
	public unsafe static void* Invoke([NativeType("void *")] void* p, [NativeType("unsigned __int64")] long size, [NativeType("unsigned __int64 *")] void* pActual_size, [NativeType("bool")] bool movable, [NativeType("void *")] void* parameter_4)
	{
		void* ptr = null;
		void* ptr2 = null;
		sbyte b = (movable ? ((sbyte)1) : ((sbyte)0));
		unchecked
		{
			if (p == null)
			{
				ptr = malloc.Invoke(size);
				if (pActual_size != null)
				{
					*(long*)pActual_size = ((ptr == null) ? 0L : msize.Invoke(ptr));
				}
			}
			else if (size == 0L)
			{
				free.Invoke(p);
				ptr = null;
				if (pActual_size != null)
				{
					*(long*)pActual_size = 0L;
				}
			}
			else
			{
				ptr2 = p;
				ptr = null;
				if (ptr != null)
				{
					ptr2 = ptr;
				}
				else if ((b & 1) == 1)
				{
					ptr = realloc.Invoke(p, size);
					if (ptr != null)
					{
						ptr2 = ptr;
					}
				}
				if (pActual_size != null)
				{
					*(long*)pActual_size = msize.Invoke(ptr2);
				}
			}
			return ptr;
		}
	}
}
