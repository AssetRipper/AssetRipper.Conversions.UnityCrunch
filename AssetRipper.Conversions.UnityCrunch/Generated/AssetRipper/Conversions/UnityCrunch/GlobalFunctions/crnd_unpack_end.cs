using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_unpack_end@crnd@@YA_NPEAX@Z")]
[DemangledName("bool __cdecl crnd::crnd_unpack_end(void *)")]
internal static partial class crnd_unpack_end
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("void *")] void* pContext)
	{
		bool flag = false;
		void* ptr = null;
		if (pContext == null)
		{
			return false;
		}
		ptr = pContext;
		if (!is_valid.Invoke(ptr))
		{
			return false;
		}
		crnd_delete_e7rwdhb.Invoke(ptr);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		return true;
	}
}
