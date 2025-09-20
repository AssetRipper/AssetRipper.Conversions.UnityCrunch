using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_msize@crnd@@YA_KPEAX@Z")]
[DemangledName("unsigned __int64 __cdecl crnd::crnd_msize(void *)")]
internal static partial class crnd_msize
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke([NativeType("void *")] void* p)
	{
		long num = 0L;
		if (p == null)
		{
			return 0L;
		}
		unchecked
		{
			if (((int)p & 7) != 0)
			{
				crnd_mem_error.Invoke(String_zijibvd.__pointer);
				return 0L;
			}
			long result = ((delegate*<void*, void*, long>)g_pMSize.Value)(p, g_pUser_data.Value);
			if (ExceptionInfo.Current != null)
			{
				return 0L;
			}
			return result;
		}
	}
}
