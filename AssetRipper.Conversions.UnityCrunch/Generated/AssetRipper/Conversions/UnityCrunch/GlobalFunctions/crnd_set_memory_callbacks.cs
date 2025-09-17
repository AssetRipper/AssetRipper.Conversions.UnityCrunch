using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_set_memory_callbacks@crnd@@YAXP6APEAXPEAX_KPEA_K_N0@ZP6A_K00@Z0@Z")]
[DemangledName("void __cdecl crnd::crnd_set_memory_callbacks(void * (__cdecl *)(void *, unsigned __int64, unsigned __int64 *, bool, void *), unsigned __int64 (__cdecl *)(void *, void *), void *)")]
internal static partial class crnd_set_memory_callbacks
{
	public unsafe static void Invoke(void* pRealloc, void* pMSize, void* pUser_data)
	{
		void* ptr = null;
		void* ptr2 = null;
		void* ptr3 = null;
		ptr = pUser_data;
		ptr2 = pMSize;
		ptr3 = pRealloc;
		if (ptr3 == null || ptr2 == null)
		{
			g_pRealloc.Value = crnd_default_realloc.__pointer;
			g_pMSize.Value = crnd_default_msize.__pointer;
			g_pUser_data.Value = null;
		}
		else
		{
			g_pRealloc.Value = ptr3;
			g_pMSize.Value = ptr2;
			g_pUser_data.Value = ptr;
		}
	}
}
