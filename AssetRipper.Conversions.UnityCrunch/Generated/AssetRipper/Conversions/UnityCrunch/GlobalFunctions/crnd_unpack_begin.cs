using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_unpack_begin@crnd@@YAPEAXPEBXI@Z")]
[DemangledName("void * __cdecl crnd::crnd_unpack_begin(void const *, unsigned int)")]
internal static partial class crnd_unpack_begin
{
	[return: NativeType("void *")]
	public unsafe static void* Invoke([NativeType("void const *")] void* pData, [NativeType("unsigned int")] int data_size)
	{
		void* ptr = null;
		void* ptr2 = null;
		if (pData == null || unchecked((uint)data_size) < 62u)
		{
			return null;
		}
		void* ptr3 = crnd_new_xzix9sb.Invoke();
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		ptr2 = ptr3;
		if (ptr2 == null)
		{
			return null;
		}
		bool flag = init_lqqdgrc.Invoke(ptr2, pData, data_size);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		if (!flag)
		{
			crnd_delete_e7rwdhb.Invoke(ptr2);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			return null;
		}
		return ptr2;
	}
}
