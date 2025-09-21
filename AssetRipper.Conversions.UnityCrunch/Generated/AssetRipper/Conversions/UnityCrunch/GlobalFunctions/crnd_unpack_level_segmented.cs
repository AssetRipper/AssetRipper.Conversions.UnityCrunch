using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_unpack_level_segmented@crnd@@YA_NPEAXPEBXIPEAPEAXIII@Z")]
[DemangledName("bool __cdecl crnd::crnd_unpack_level_segmented(void *, void const *, unsigned int, void **, unsigned int, unsigned int, unsigned int)")]
internal static partial class crnd_unpack_level_segmented
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("void *")] void* pContext, [NativeType("void const *")] void* pSrc, [NativeType("unsigned int")] int src_size_in_bytes, [NativeType("void **")] void* pDst, [NativeType("unsigned int")] int dst_size_in_bytes, [NativeType("unsigned int")] int row_pitch_in_bytes, [NativeType("unsigned int")] int level_index)
	{
		if (unchecked(pContext == null || pSrc == null || pDst == null || (uint)dst_size_in_bytes < 8u || (uint)level_index >= 16u))
		{
			return false;
		}
		if (!is_valid.Invoke(pContext))
		{
			return false;
		}
		bool result = unpack_level_zjb72ec.Invoke(pContext, pSrc, src_size_in_bytes, pDst, dst_size_in_bytes, row_pitch_in_bytes, level_index);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		return result;
	}
}
