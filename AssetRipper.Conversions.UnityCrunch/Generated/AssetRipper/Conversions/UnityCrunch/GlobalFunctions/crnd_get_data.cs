using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_get_data@crnd@@YA_NPEAXPEAPEBXPEAI@Z")]
[DemangledName("bool __cdecl crnd::crnd_get_data(void *, void const **, unsigned int *)")]
internal static partial class crnd_get_data
{
	public unsafe static bool Invoke(void* pContext, void* ppData, void* pData_size)
	{
		bool flag = false;
		void* ptr = null;
		void* ptr2 = null;
		void* ptr3 = null;
		void* ptr4 = null;
		ptr = pData_size;
		ptr2 = ppData;
		ptr3 = pContext;
		if (ptr3 == null)
		{
			return false;
		}
		ptr4 = ptr3;
		if (!is_valid.Invoke(ptr4))
		{
			return false;
		}
		unchecked
		{
			if (ptr2 != null)
			{
				*(void**)ptr2 = Get_data.Invoke(ptr4);
			}
			if (ptr != null)
			{
				*(int*)ptr = Get_data_size.Invoke(ptr4);
			}
			return true;
		}
	}
}
