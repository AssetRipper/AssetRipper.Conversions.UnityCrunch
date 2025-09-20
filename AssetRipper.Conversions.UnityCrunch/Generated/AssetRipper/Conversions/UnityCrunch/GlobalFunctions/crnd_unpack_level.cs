using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_unpack_level@crnd@@YA_NPEAXPEAPEAXIII@Z")]
[DemangledName("bool __cdecl crnd::crnd_unpack_level(void *, void **, unsigned int, unsigned int, unsigned int)")]
internal static partial class crnd_unpack_level
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("void *")] void* pContext, [NativeType("void **")] void* pDst, [NativeType("unsigned int")] int dst_size_in_bytes, [NativeType("unsigned int")] int row_pitch_in_bytes, [NativeType("unsigned int")] int level_index)
	{
		bool flag = false;
		void* ptr = null;
		if (unchecked(pContext == null || pDst == null || (uint)dst_size_in_bytes < 8u || (uint)level_index >= 16u))
		{
			return false;
		}
		ptr = pContext;
		if (!is_valid.Invoke(ptr))
		{
			return false;
		}
		bool result = unpack_level_cvfjdga.Invoke(ptr, pDst, dst_size_in_bytes, row_pitch_in_bytes, level_index);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		return result;
	}
}
