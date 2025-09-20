using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$crnd_new@Vdecoder_tables@prefix_coding@crnd@@@crnd@@YAPEAVdecoder_tables@prefix_coding@0@AEBV120@@Z")]
[DemangledName("class crnd::prefix_coding::decoder_tables * __cdecl crnd::crnd_new<class crnd::prefix_coding::decoder_tables>(class crnd::prefix_coding::decoder_tables const &)")]
[CleanName("crnd_new")]
internal static partial class crnd_new_vzd3zqa
{
	[return: NativeType("class crnd::prefix_coding::decoder_tables *")]
	public unsafe static void* Invoke([NativeType("class crnd::prefix_coding::decoder_tables const &")] void* init)
	{
		void* ptr = null;
		void* ptr2 = crnd_malloc.Invoke(192L, null);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		void* ptr3 = ptr2;
		if (ptr3 == null)
		{
			return null;
		}
		void* result = construct_zybj4yc.Invoke(ptr3, init);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return result;
	}
}
