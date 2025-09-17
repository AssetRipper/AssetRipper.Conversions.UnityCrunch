using AssetRipper.Conversions.UnityCrunch.GlobalFunctions;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("?g_pRealloc@crnd@@3P6APEAXPEAX_KPEA_K_N0@ZEA")]
[DemangledName("void * (__cdecl *crnd::g_pRealloc)(void *, unsigned __int64, unsigned __int64 *, bool, void *)")]
internal static partial class g_pRealloc
{
	private unsafe static void* __value;

	public unsafe static void* Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static g_pRealloc()
	{
		Value = crnd_default_realloc.__pointer;
	}
}
