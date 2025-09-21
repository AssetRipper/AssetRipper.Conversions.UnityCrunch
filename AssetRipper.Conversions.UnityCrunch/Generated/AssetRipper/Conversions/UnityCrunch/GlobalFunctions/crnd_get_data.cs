using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_get_data@crnd@@YA_NPEAXPEAPEBXPEAI@Z")]
[DemangledName("bool __cdecl crnd::crnd_get_data(void *, void const **, unsigned int *)")]
internal static partial class crnd_get_data
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("void *")] void* pContext, [NativeType("void const **")] void* ppData, [NativeType("unsigned int *")] void* pData_size)
	{
		if (pContext == null)
		{
			return false;
		}
		if (!is_valid.Invoke(pContext))
		{
			return false;
		}
		unchecked
		{
			if (ppData != null)
			{
				*(void**)ppData = Get_data.Invoke(pContext);
			}
			if (pData_size != null)
			{
				*(int*)pData_size = Get_data_size.Invoke(pContext);
			}
			return true;
		}
	}
}
