using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_unpack_begin@crnd@@YAPEAXPEBXI@Z")]
[DemangledName("void * __cdecl crnd::crnd_unpack_begin(void const *, unsigned int)")]
internal static partial class crnd_unpack_begin
{
	[return: NativeType("void *")]
	public unsafe static void* Invoke([NativeType("void const *")] void* pData, [NativeType("unsigned int")] int data_size)
	{
		if (pData == null || unchecked((uint)data_size) < 62u)
		{
			return null;
		}
		void* ptr = crnd_new_jsasrf.Invoke();
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		void* ptr2 = ptr;
		if (ptr2 == null)
		{
			return null;
		}
		bool flag = init_4dt3g9.Invoke(ptr2, pData, data_size);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		if (!flag)
		{
			crnd_delete_ps427s.Invoke(ptr2);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			return null;
		}
		return ptr2;
	}
}
