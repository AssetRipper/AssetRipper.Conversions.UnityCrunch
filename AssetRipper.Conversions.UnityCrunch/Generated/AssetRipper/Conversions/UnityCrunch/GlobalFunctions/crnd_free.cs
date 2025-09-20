using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_free@crnd@@YAXPEAX@Z")]
[DemangledName("void __cdecl crnd::crnd_free(void *)")]
internal static partial class crnd_free
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("void *")] void* p)
	{
		if (p == null)
		{
			return;
		}
		unchecked
		{
			if (((int)p & 7) != 0)
			{
				crnd_mem_error.Invoke(String_gcwah5d.__pointer);
				return;
			}
			((delegate*<void*, long, void*, bool, void*, void*>)g_pRealloc.Value)(p, 0L, null, true, g_pUser_data.Value);
			if (ExceptionInfo.Current == null)
			{
			}
		}
	}
}
